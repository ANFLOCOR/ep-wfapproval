if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WASP_WF_Approver_POGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WASP_WF_Approver_POGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


