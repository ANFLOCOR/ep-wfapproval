if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUserCompanyDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUserCompanyDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[SysSetupUserCompany] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupUserCompanyDelete
        @pk_SSUC_RowID int
AS
BEGIN
    DELETE [dbo].[SysSetupUserCompany]
    WHERE [SSUC_RowID] = @pk_SSUC_RowID
END

