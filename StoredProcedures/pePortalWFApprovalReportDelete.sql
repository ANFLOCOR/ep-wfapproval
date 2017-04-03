if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalReportDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalReportDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[Report] table.
CREATE PROCEDURE pePortalWFApprovalReportDelete
        @pk_ReportID int
AS
BEGIN
    DELETE [dbo].[Report]
    WHERE [ReportID] = @pk_ReportID
END

