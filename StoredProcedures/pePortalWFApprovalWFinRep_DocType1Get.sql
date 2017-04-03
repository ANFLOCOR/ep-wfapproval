if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_DocType1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_DocType1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WFinRep_DocType] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_DocType1Get
        @pk_WFIN_DT_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WFinRep_DocType]
    WHERE [WFIN_DT_ID] =@pk_WFIN_DT_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WFIN_DT_ID],
        [WFIN_DT_C_ID],
        [WFIN_DT_Name],
        [WFIN_DT_Desc],
        [WFIN_DT_Type],
        [WFIN_DT_Minimum],
        [WFIN_DT_Maximum],
        CAST(BINARY_CHECKSUM([WFIN_DT_ID],[WFIN_DT_C_ID],[WFIN_DT_Name],[WFIN_DT_Desc],[WFIN_DT_Type],[WFIN_DT_Minimum],[WFIN_DT_Maximum]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WFinRep_DocType]
    WHERE [WFIN_DT_ID] =@pk_WFIN_DT_ID
    SET NOCOUNT OFF
END

