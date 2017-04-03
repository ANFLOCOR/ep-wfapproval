if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_Dynamics_CompanyAllGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_Dynamics_CompanyAllGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


