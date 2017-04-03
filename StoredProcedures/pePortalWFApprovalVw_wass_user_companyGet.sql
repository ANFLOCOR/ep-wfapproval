if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_wass_user_companyGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_wass_user_companyGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


