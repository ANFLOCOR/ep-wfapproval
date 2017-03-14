if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_W_User_DYNAMICS_CompanyGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_W_User_DYNAMICS_CompanyGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


