if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WASS_Dynamics_CompaniesGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WASS_Dynamics_CompaniesGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


