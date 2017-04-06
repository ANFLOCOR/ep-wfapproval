if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_FS_WFinRep_Attachment_PerReportTypeDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_FS_WFinRep_Attachment_PerReportTypeDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[vw_FS_WFinRep_Attachment_PerReportType] table.
CREATE PROCEDURE pePortalWFApprovalVw_FS_WFinRep_Attachment_PerReportTypeDelete
        @pk_WFRA_ID int
AS
BEGIN
    DELETE [dbo].[vw_FS_WFinRep_Attachment_PerReportType]
    WHERE [WFRA_ID] = @pk_WFRA_ID
END

