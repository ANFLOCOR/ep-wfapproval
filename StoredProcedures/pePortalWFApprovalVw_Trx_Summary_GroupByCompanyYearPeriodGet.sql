if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_Trx_Summary_GroupByCompanyYearPeriodGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_Trx_Summary_GroupByCompanyYearPeriodGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


