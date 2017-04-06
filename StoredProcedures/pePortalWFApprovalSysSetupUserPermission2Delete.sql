if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUserPermission2Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUserPermission2Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[SysSetupUserPermission] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupUserPermission2Delete
        @pk_SSUP_RowID int
AS
BEGIN
    DELETE [dbo].[SysSetupUserPermission]
    WHERE [SSUP_RowID] = @pk_SSUP_RowID
END

