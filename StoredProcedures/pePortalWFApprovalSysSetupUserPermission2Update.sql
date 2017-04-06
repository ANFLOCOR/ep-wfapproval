if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUserPermission2Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUserPermission2Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[SysSetupUserPermission] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSysSetupUserPermission2Update
    @p_SSUP_SSU_UserName char(15),
    @p_SSUP_SSR_RoleID int,
    @p_SSUP_SSR_AppID int,
    @p_SSUP_SSC_CompanyID smallint,
    @p_SSUP_Permission varchar(500),
    @p_SSUP_SSUC_RowID int,
    @pk_SSUP_RowID int,
    @p_SSUP_isDefault bit,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[SysSetupUserPermission] WHERE [SSUP_RowID] = @pk_SSUP_RowID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[SysSetupUserPermission]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[SysSetupUserPermission]
            SET 
            [SSUP_SSU_UserName] = @p_SSUP_SSU_UserName,
            [SSUP_SSR_RoleID] = @p_SSUP_SSR_RoleID,
            [SSUP_SSR_AppID] = @p_SSUP_SSR_AppID,
            [SSUP_SSC_CompanyID] = @p_SSUP_SSC_CompanyID,
            [SSUP_Permission] = @p_SSUP_Permission,
            [SSUP_SSUC_RowID] = @p_SSUP_SSUC_RowID,
            [SSUP_isDefault] = @p_SSUP_isDefault
            WHERE [SSUP_RowID] = @pk_SSUP_RowID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([SSUP_SSU_UserName],[SSUP_SSR_RoleID],[SSUP_SSR_AppID],[SSUP_SSC_CompanyID],[SSUP_Permission],[SSUP_SSUC_RowID],[SSUP_RowID],[SSUP_isDefault]) AS nvarchar(max)) 
            FROM [dbo].[SysSetupUserPermission] with (rowlock, holdlock)
            WHERE [SSUP_RowID] = @pk_SSUP_RowID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[SysSetupUserPermission]
                    SET 
                    [SSUP_SSU_UserName] = @p_SSUP_SSU_UserName,
                    [SSUP_SSR_RoleID] = @p_SSUP_SSR_RoleID,
                    [SSUP_SSR_AppID] = @p_SSUP_SSR_AppID,
                    [SSUP_SSC_CompanyID] = @p_SSUP_SSC_CompanyID,
                    [SSUP_Permission] = @p_SSUP_Permission,
                    [SSUP_SSUC_RowID] = @p_SSUP_SSUC_RowID,
                    [SSUP_isDefault] = @p_SSUP_isDefault
                    WHERE [SSUP_RowID] = @pk_SSUP_RowID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[SysSetupUserPermission]', 16, 1)

        END
END

