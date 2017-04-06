if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUserPermissionDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUserPermissionDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[SysSetupUserPermission] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupUserPermissionDelete
        @pk_SSUP_RowID int
AS
BEGIN
    DELETE [dbo].[SysSetupUserPermission]
    WHERE [SSUP_RowID] = @pk_SSUP_RowID
END

