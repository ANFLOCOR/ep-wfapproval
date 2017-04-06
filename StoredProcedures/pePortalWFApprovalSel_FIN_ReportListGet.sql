if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_FIN_ReportListGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_FIN_ReportListGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


