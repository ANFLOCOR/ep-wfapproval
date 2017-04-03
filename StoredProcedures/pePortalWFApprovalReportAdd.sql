if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalReportAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalReportAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[Report] table.
CREATE PROCEDURE pePortalWFApprovalReportAdd
    @p_ReportID int,
    @p_Report varchar(50),
    @p_Report_ShortName varchar(10)
AS
BEGIN
    INSERT
    INTO [dbo].[Report]
        (
            [ReportID],
            [Report],
            [Report_ShortName]
        )
    VALUES
        (
             @p_ReportID,
             @p_Report,
             @p_Report_ShortName
        )

END

