if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUserPermissionAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUserPermissionAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[SysSetupUserPermission] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupUserPermissionAdd
    @p_SSUP_SSU_UserName char(15),
    @p_SSUP_SSR_RoleID int,
    @p_SSUP_SSR_AppID int,
    @p_SSUP_SSC_CompanyID smallint,
    @p_SSUP_Permission varchar(500),
    @p_SSUP_SSUC_RowID int,
    @p_SSUP_isDefault bit,
    @p_SSUP_RowID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[SysSetupUserPermission]
        (
            [SSUP_SSU_UserName],
            [SSUP_SSR_RoleID],
            [SSUP_SSR_AppID],
            [SSUP_SSC_CompanyID],
            [SSUP_Permission],
            [SSUP_SSUC_RowID]
        )
    VALUES
        (
             @p_SSUP_SSU_UserName,
             @p_SSUP_SSR_RoleID,
             @p_SSUP_SSR_AppID,
             @p_SSUP_SSC_CompanyID,
             @p_SSUP_Permission,
             @p_SSUP_SSUC_RowID
        )

    SET @p_SSUP_RowID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_SSUP_isDefault IS NOT NULL
        UPDATE [dbo].[SysSetupUserPermission] SET [SSUP_isDefault] = @p_SSUP_isDefault WHERE [SSUP_RowID] = @p_SSUP_RowID_out

END

