if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_ANFLO_DW_CompanyGPGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_ANFLO_DW_CompanyGPGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


