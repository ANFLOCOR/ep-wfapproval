if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCAR_Doc_CheckerUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCAR_Doc_CheckerUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WCAR_Doc_Checker] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWCAR_Doc_CheckerUpdate
    @pk_WCDC_ID int,
    @p_WCDC_WCD_ID int,
    @p_WCDC_U_ID int,
    @p_WCDC_Status varchar(25),
    @p_WCDC_Rem varchar(250),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WCAR_Doc_Checker] WHERE [WCDC_ID] = @pk_WCDC_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WCAR_Doc_Checker]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WCAR_Doc_Checker]
            SET 
            [WCDC_WCD_ID] = @p_WCDC_WCD_ID,
            [WCDC_U_ID] = @p_WCDC_U_ID,
            [WCDC_Status] = @p_WCDC_Status,
            [WCDC_Rem] = @p_WCDC_Rem
            WHERE [WCDC_ID] = @pk_WCDC_ID

            -- Make sure only one record is affected
            SET @l_rowcount = @@ROWCOUNT
            IF @l_rowcount = 0
                RAISERROR ('The record cannot be updated.', 16, 1)
            IF @l_rowcount > 1
                RAISERROR ('duplicate object instances.', 16, 1)

        END
    ELSE
        BEGIN
            -- Get the checksum value for the record 
            -- and put an update lock on the record to 
            -- ensure transactional integrity.  The lock
            -- will be release when the transaction is 
            -- later committed or rolled back.
            Select @l_newValue = CAST(BINARY_CHECKSUM([WCDC_ID],[WCDC_WCD_ID],[WCDC_U_ID],[WCDC_Status],[WCDC_Rem]) AS nvarchar(max)) 
            FROM [dbo].[WCAR_Doc_Checker] with (rowlock, holdlock)
            WHERE [WCDC_ID] = @pk_WCDC_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WCAR_Doc_Checker]
                    SET 
                    [WCDC_WCD_ID] = @p_WCDC_WCD_ID,
                    [WCDC_U_ID] = @p_WCDC_U_ID,
                    [WCDC_Status] = @p_WCDC_Status,
                    [WCDC_Rem] = @p_WCDC_Rem
                    WHERE [WCDC_ID] = @pk_WCDC_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WCAR_Doc_Checker]', 16, 1)

        END
END

