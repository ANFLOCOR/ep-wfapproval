if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_ANFLO_DW_CompanyNonGPDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_ANFLO_DW_CompanyNonGPDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[vw_ANFLO_DW_CompanyNonGP] table.
CREATE PROCEDURE pePortalWFApprovalVw_ANFLO_DW_CompanyNonGPDelete
        @pk_CompanyID smallint
AS
BEGIN
    DELETE [dbo].[vw_ANFLO_DW_CompanyNonGP]
    WHERE [CompanyID] = @pk_CompanyID
END

