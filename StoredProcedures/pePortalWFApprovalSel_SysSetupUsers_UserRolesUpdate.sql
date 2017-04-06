if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_SysSetupUsers_UserRolesUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_SysSetupUsers_UserRolesUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[sel_SysSetupUsers_UserRoles] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSel_SysSetupUsers_UserRolesUpdate
    @p_SSU_UserName char(15),
    @p_SSU_RowID int,
    @p_SSUA_App_ID int,
    @p_SSUC_SSC_CompanyID smallint,
    @p_SSUP_SSR_RoleID int,
    @p_SSUP_RowID int,
    @pk_SSUP_RowID int,
    @p_SSR_RoleName varchar(50),
    @p_SSUC_RowID int,
    @p_SSUA_RowID int,
    @p_SSUP_Permission varchar(500),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[sel_SysSetupUsers_UserRoles] WHERE [SSUP_RowID] = @pk_SSUP_RowID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[sel_SysSetupUsers_UserRoles]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[sel_SysSetupUsers_UserRoles]
            SET 
            [SSU_UserName] = @p_SSU_UserName,
            [SSU_RowID] = @p_SSU_RowID,
            [SSUA_App_ID] = @p_SSUA_App_ID,
            [SSUC_SSC_CompanyID] = @p_SSUC_SSC_CompanyID,
            [SSUP_SSR_RoleID] = @p_SSUP_SSR_RoleID,
            [SSUP_RowID] = @p_SSUP_RowID,
            [SSR_RoleName] = @p_SSR_RoleName,
            [SSUC_RowID] = @p_SSUC_RowID,
            [SSUA_RowID] = @p_SSUA_RowID,
            [SSUP_Permission] = @p_SSUP_Permission
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
            Select @l_newValue = CAST(BINARY_CHECKSUM([SSU_UserName],[SSU_RowID],[SSUA_App_ID],[SSUC_SSC_CompanyID],[SSUP_SSR_RoleID],[SSUP_RowID],[SSR_RoleName],[SSUC_RowID],[SSUA_RowID],[SSUP_Permission]) AS nvarchar(max)) 
            FROM [dbo].[sel_SysSetupUsers_UserRoles] with (rowlock, holdlock)
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

                    UPDATE [dbo].[sel_SysSetupUsers_UserRoles]
                    SET 
                    [SSU_UserName] = @p_SSU_UserName,
                    [SSU_RowID] = @p_SSU_RowID,
                    [SSUA_App_ID] = @p_SSUA_App_ID,
                    [SSUC_SSC_CompanyID] = @p_SSUC_SSC_CompanyID,
                    [SSUP_SSR_RoleID] = @p_SSUP_SSR_RoleID,
                    [SSUP_RowID] = @p_SSUP_RowID,
                    [SSR_RoleName] = @p_SSR_RoleName,
                    [SSUC_RowID] = @p_SSUC_RowID,
                    [SSUA_RowID] = @p_SSUA_RowID,
                    [SSUP_Permission] = @p_SSUP_Permission
                    WHERE [SSUP_RowID] = @pk_SSUP_RowID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[sel_SysSetupUsers_UserRoles]', 16, 1)

        END
END

