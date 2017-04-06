if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_SysSetupUsers_UserRolesDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_SysSetupUsers_UserRolesDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_SysSetupUsers_UserRoles] table.
CREATE PROCEDURE pePortalWFApprovalSel_SysSetupUsers_UserRolesDelete
        @pk_SSUP_RowID int
AS
BEGIN
    DELETE [dbo].[sel_SysSetupUsers_UserRoles]
    WHERE [SSUP_RowID] = @pk_SSUP_RowID
END

