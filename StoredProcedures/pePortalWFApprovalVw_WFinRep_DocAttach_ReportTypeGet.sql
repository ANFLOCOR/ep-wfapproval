if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_WFinRep_DocAttach_ReportTypeGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_WFinRep_DocAttach_ReportTypeGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


