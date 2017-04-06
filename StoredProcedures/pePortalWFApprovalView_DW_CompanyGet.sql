if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalView_DW_CompanyGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalView_DW_CompanyGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


