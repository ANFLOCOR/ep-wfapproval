if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUserApplication2Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUserApplication2Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[SysSetupUserApplication] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSysSetupUserApplication2Update
    @p_SSUA_SSU_UserName char(15),
    @p_SSUA_App_ID int,
    @p_SSUA_DateCreated datetime,
    @pk_SSUA_RowID int,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[SysSetupUserApplication] WHERE [SSUA_RowID] = @pk_SSUA_RowID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[SysSetupUserApplication]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[SysSetupUserApplication]
            SET 
            [SSUA_SSU_UserName] = @p_SSUA_SSU_UserName,
            [SSUA_App_ID] = @p_SSUA_App_ID,
            [SSUA_DateCreated] = @p_SSUA_DateCreated
            WHERE [SSUA_RowID] = @pk_SSUA_RowID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([SSUA_SSU_UserName],[SSUA_App_ID],[SSUA_DateCreated],[SSUA_RowID]) AS nvarchar(max)) 
            FROM [dbo].[SysSetupUserApplication] with (rowlock, holdlock)
            WHERE [SSUA_RowID] = @pk_SSUA_RowID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[SysSetupUserApplication]
                    SET 
                    [SSUA_SSU_UserName] = @p_SSUA_SSU_UserName,
                    [SSUA_App_ID] = @p_SSUA_App_ID,
                    [SSUA_DateCreated] = @p_SSUA_DateCreated
                    WHERE [SSUA_RowID] = @pk_SSUA_RowID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[SysSetupUserApplication]', 16, 1)

        END
END

