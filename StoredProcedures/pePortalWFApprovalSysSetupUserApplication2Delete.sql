if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUserApplication2Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUserApplication2Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[SysSetupUserApplication] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupUserApplication2Delete
        @pk_SSUA_RowID int
AS
BEGIN
    DELETE [dbo].[SysSetupUserApplication]
    WHERE [SSUA_RowID] = @pk_SSUA_RowID
END

