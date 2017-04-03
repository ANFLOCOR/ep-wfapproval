if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_ReportType1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_ReportType1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WFinRep_ReportType] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_ReportType1Get
        @pk_WFRT_Type varchar(50)
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WFinRep_ReportType]
    WHERE [WFRT_Type] =@pk_WFRT_Type

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WFRT_Type],
        [WFRT_Description],
        [WFRT_SortOrder],
        CAST(BINARY_CHECKSUM([WFRT_Type],[WFRT_Description],[WFRT_SortOrder]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WFinRep_ReportType]
    WHERE [WFRT_Type] =@pk_WFRT_Type
    SET NOCOUNT OFF
END

