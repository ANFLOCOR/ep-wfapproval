if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupCompanyDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupCompanyDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[SysSetupCompany] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupCompanyDelete
        @pk_SSC_CompanyID smallint
AS
BEGIN
    DELETE [dbo].[SysSetupCompany]
    WHERE [SSC_CompanyID] = @pk_SSC_CompanyID
END

