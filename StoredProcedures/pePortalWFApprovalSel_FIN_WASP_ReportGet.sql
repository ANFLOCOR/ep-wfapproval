if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_FIN_WASP_ReportGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_FIN_WASP_ReportGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


