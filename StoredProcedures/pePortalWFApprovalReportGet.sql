if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalReportGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalReportGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[Report] table.
CREATE PROCEDURE pePortalWFApprovalReportGet
        @pk_ReportID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[Report]
    WHERE [ReportID] =@pk_ReportID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [ReportID],
        [Report],
        [Report_ShortName],
        CAST(BINARY_CHECKSUM([ReportID],[Report],[Report_ShortName]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[Report]
    WHERE [ReportID] =@pk_ReportID
    SET NOCOUNT OFF
END

