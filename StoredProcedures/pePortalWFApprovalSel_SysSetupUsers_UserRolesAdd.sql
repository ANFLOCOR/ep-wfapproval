if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_SysSetupUsers_UserRolesAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_SysSetupUsers_UserRolesAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_SysSetupUsers_UserRoles] table.
CREATE PROCEDURE pePortalWFApprovalSel_SysSetupUsers_UserRolesAdd
    @p_SSU_UserName char(15),
    @p_SSU_RowID int,
    @p_SSUA_App_ID int,
    @p_SSUC_SSC_CompanyID smallint,
    @p_SSUP_SSR_RoleID int,
    @p_SSUP_RowID int,
    @p_SSR_RoleName varchar(50),
    @p_SSUC_RowID int,
    @p_SSUA_RowID int,
    @p_SSUP_Permission varchar(500)
AS
BEGIN
    INSERT
    INTO [dbo].[sel_SysSetupUsers_UserRoles]
        (
            [SSU_UserName],
            [SSU_RowID],
            [SSUA_App_ID],
            [SSUC_SSC_CompanyID],
            [SSUP_SSR_RoleID],
            [SSUP_RowID],
            [SSR_RoleName],
            [SSUC_RowID],
            [SSUA_RowID],
            [SSUP_Permission]
        )
    VALUES
        (
             @p_SSU_UserName,
             @p_SSU_RowID,
             @p_SSUA_App_ID,
             @p_SSUC_SSC_CompanyID,
             @p_SSUP_SSR_RoleID,
             @p_SSUP_RowID,
             @p_SSR_RoleName,
             @p_SSUC_RowID,
             @p_SSUA_RowID,
             @p_SSUP_Permission
        )

END

