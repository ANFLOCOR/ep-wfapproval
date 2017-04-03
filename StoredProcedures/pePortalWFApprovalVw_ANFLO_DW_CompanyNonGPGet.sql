if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_ANFLO_DW_CompanyNonGPGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_ANFLO_DW_CompanyNonGPGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


