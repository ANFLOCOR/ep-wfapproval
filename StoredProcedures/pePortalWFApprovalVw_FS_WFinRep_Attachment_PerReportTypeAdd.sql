if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_FS_WFinRep_Attachment_PerReportTypeAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_FS_WFinRep_Attachment_PerReportTypeAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[vw_FS_WFinRep_Attachment_PerReportType] table.
CREATE PROCEDURE pePortalWFApprovalVw_FS_WFinRep_Attachment_PerReportTypeAdd
    @p_WFRA_ID int,
    @p_WFRA_FIN_ID int,
    @p_WFRA_Desc varchar(150),
    @p_WFRA_Doc image,
    @p_WFRT_Description varchar(350),
    @p_WFRT_SortOrder int,
    @p_FIN_HFIN_ID int
AS
BEGIN
    INSERT
    INTO [dbo].[vw_FS_WFinRep_Attachment_PerReportType]
        (
            [WFRA_ID],
            [WFRA_FIN_ID],
            [WFRA_Desc],
            [WFRA_Doc],
            [WFRT_Description],
            [WFRT_SortOrder],
            [FIN_HFIN_ID]
        )
    VALUES
        (
             @p_WFRA_ID,
             @p_WFRA_FIN_ID,
             @p_WFRA_Desc,
             @p_WFRA_Doc,
             @p_WFRT_Description,
             @p_WFRT_SortOrder,
             @p_FIN_HFIN_ID
        )

END

