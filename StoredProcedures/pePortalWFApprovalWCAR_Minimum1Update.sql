if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCAR_Minimum1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCAR_Minimum1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WCAR_Minimum] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWCAR_Minimum1Update
    @pk_WCM_ID smallint,
    @p_WCM_C_ID smallint,
    @p_WCM_Min numeric(18,2),
    @p_WCM_WCur_ID smallint,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WCAR_Minimum] WHERE [WCM_ID] = @pk_WCM_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WCAR_Minimum]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WCAR_Minimum]
            SET 
            [WCM_C_ID] = @p_WCM_C_ID,
            [WCM_Min] = @p_WCM_Min,
            [WCM_WCur_ID] = @p_WCM_WCur_ID
            WHERE [WCM_ID] = @pk_WCM_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WCM_ID],[WCM_C_ID],[WCM_Min],[WCM_WCur_ID]) AS nvarchar(max)) 
            FROM [dbo].[WCAR_Minimum] with (rowlock, holdlock)
            WHERE [WCM_ID] = @pk_WCM_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WCAR_Minimum]
                    SET 
                    [WCM_C_ID] = @p_WCM_C_ID,
                    [WCM_Min] = @p_WCM_Min,
                    [WCM_WCur_ID] = @p_WCM_WCur_ID
                    WHERE [WCM_ID] = @pk_WCM_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WCAR_Minimum]', 16, 1)

        END
END

