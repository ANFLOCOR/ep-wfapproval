if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUserCompany2Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUserCompany2Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[SysSetupUserCompany] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupUserCompany2Delete
        @pk_SSUC_RowID int
AS
BEGIN
    DELETE [dbo].[SysSetupUserCompany]
    WHERE [SSUC_RowID] = @pk_SSUC_RowID
END

