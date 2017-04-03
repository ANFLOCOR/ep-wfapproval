if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_FS_WFinRep_Attachment_PerReportTypeGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_FS_WFinRep_Attachment_PerReportTypeGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


