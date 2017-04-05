if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_FS_WFinRep_Attachment_PerReportType1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_FS_WFinRep_Attachment_PerReportType1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[vw_FS_WFinRep_Attachment_PerReportType] table.
CREATE PROCEDURE pePortalWFApprovalVw_FS_WFinRep_Attachment_PerReportType1Get
        @pk_WFRA_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[vw_FS_WFinRep_Attachment_PerReportType]
    WHERE [WFRA_ID] =@pk_WFRA_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WFRA_ID],
        [WFRA_FIN_ID],
        [WFRA_Desc],
        [WFRA_Doc],
        [WFRT_Description],
        [WFRT_SortOrder],
        [FIN_HFIN_ID],
        [WFRA_Doc_X],
        CAST(BINARY_CHECKSUM([WFRA_ID],[WFRA_FIN_ID],[WFRA_Desc],[WFRA_Doc],[WFRT_Description],[WFRT_SortOrder],[FIN_HFIN_ID],[WFRA_Doc_X]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[vw_FS_WFinRep_Attachment_PerReportType]
    WHERE [WFRA_ID] =@pk_WFRA_ID
    SET NOCOUNT OFF
END

