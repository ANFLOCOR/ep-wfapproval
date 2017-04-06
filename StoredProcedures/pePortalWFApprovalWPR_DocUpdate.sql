if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_DocUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_DocUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WPR_Doc] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWPR_DocUpdate
    @pk_WPRD_ID int,
    @p_WPRD_C_ID smallint,
    @p_WPRD_WDT_ID int,
    @p_WPRD_WCD_ID int,
    @p_WPRD_WCur_ID smallint,
    @p_WPRD_U_ID int,
    @p_WPRD_U_ID_Modify int,
    @p_WPRD_No varchar(50),
    @p_WPRD_Created smalldatetime,
    @p_WPRD_Modified smalldatetime,
    @p_WPRD_Total numeric(18,5),
    @p_WPRD_Comment nvarchar(max),
    @p_WPRD_WPRDS_ID smallint,
    @p_WPRD_Submit bit,
    @p_WPRD_Title varchar(250),
    @p_WPRD_Contract bit,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WPR_Doc] WHERE [WPRD_ID] = @pk_WPRD_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WPR_Doc]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WPR_Doc]
            SET 
            [WPRD_C_ID] = @p_WPRD_C_ID,
            [WPRD_WDT_ID] = @p_WPRD_WDT_ID,
            [WPRD_WCD_ID] = @p_WPRD_WCD_ID,
            [WPRD_WCur_ID] = @p_WPRD_WCur_ID,
            [WPRD_U_ID] = @p_WPRD_U_ID,
            [WPRD_U_ID_Modify] = @p_WPRD_U_ID_Modify,
            [WPRD_No] = @p_WPRD_No,
            [WPRD_Created] = @p_WPRD_Created,
            [WPRD_Modified] = @p_WPRD_Modified,
            [WPRD_Total] = @p_WPRD_Total,
            [WPRD_Comment] = @p_WPRD_Comment,
            [WPRD_WPRDS_ID] = @p_WPRD_WPRDS_ID,
            [WPRD_Submit] = @p_WPRD_Submit,
            [WPRD_Title] = @p_WPRD_Title,
            [WPRD_Contract] = @p_WPRD_Contract
            WHERE [WPRD_ID] = @pk_WPRD_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WPRD_ID],[WPRD_C_ID],[WPRD_WDT_ID],[WPRD_WCD_ID],[WPRD_WCur_ID],[WPRD_U_ID],[WPRD_U_ID_Modify],[WPRD_No],[WPRD_Created],[WPRD_Modified],[WPRD_Total],[WPRD_Comment],[WPRD_WPRDS_ID],[WPRD_Submit],[WPRD_Title],[WPRD_Contract]) AS nvarchar(max)) 
            FROM [dbo].[WPR_Doc] with (rowlock, holdlock)
            WHERE [WPRD_ID] = @pk_WPRD_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WPR_Doc]
                    SET 
                    [WPRD_C_ID] = @p_WPRD_C_ID,
                    [WPRD_WDT_ID] = @p_WPRD_WDT_ID,
                    [WPRD_WCD_ID] = @p_WPRD_WCD_ID,
                    [WPRD_WCur_ID] = @p_WPRD_WCur_ID,
                    [WPRD_U_ID] = @p_WPRD_U_ID,
                    [WPRD_U_ID_Modify] = @p_WPRD_U_ID_Modify,
                    [WPRD_No] = @p_WPRD_No,
                    [WPRD_Created] = @p_WPRD_Created,
                    [WPRD_Modified] = @p_WPRD_Modified,
                    [WPRD_Total] = @p_WPRD_Total,
                    [WPRD_Comment] = @p_WPRD_Comment,
                    [WPRD_WPRDS_ID] = @p_WPRD_WPRDS_ID,
                    [WPRD_Submit] = @p_WPRD_Submit,
                    [WPRD_Title] = @p_WPRD_Title,
                    [WPRD_Contract] = @p_WPRD_Contract
                    WHERE [WPRD_ID] = @pk_WPRD_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WPR_Doc]', 16, 1)

        END
END

