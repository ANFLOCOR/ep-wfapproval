if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WFinRepNGP_ApproverPageGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WFinRepNGP_ApproverPageGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


