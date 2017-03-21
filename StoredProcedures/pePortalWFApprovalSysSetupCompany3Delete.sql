if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupCompany3Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupCompany3Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[SysSetupCompany] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupCompany3Delete
        @pk_SSC_CompanyID smallint
AS
BEGIN
    DELETE [dbo].[SysSetupCompany]
    WHERE [SSC_CompanyID] = @pk_SSC_CompanyID
END

