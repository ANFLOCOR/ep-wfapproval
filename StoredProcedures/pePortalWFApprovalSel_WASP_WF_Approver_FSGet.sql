if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WASP_WF_Approver_FSGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WASP_WF_Approver_FSGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


