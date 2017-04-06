if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_Approver_Pending_TasksGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_Approver_Pending_TasksGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


