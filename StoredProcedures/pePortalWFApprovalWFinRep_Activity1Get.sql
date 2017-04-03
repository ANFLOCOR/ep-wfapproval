if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_Activity1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_Activity1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WFinRep_Activity] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_Activity1Get
        @pk_AFIN_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WFinRep_Activity]
    WHERE [AFIN_ID] =@pk_AFIN_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [AFIN_ID],
        [AFIN_WS_ID],
        [AFIN_WSD_ID],
        [AFIN_WDT_ID],
        [AFIN_W_U_ID],
        [AFIN_W_U_ID_Delegate],
        [AFIN_Status],
        [AFIN_Date_Assign],
        [AFIN_Date_Action],
        [AFIN_Remark],
        [AFIN_Is_Done],
        [AFIN_Code],
        [AFIN_FinID],
        [AFIN_HFIN_ID],
        CAST(BINARY_CHECKSUM([AFIN_ID],[AFIN_WS_ID],[AFIN_WSD_ID],[AFIN_WDT_ID],[AFIN_W_U_ID],[AFIN_W_U_ID_Delegate],[AFIN_Status],[AFIN_Date_Assign],[AFIN_Date_Action],[AFIN_Remark],[AFIN_Is_Done],[AFIN_Code],[AFIN_FinID],[AFIN_HFIN_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WFinRep_Activity]
    WHERE [AFIN_ID] =@pk_AFIN_ID
    SET NOCOUNT OFF
END

