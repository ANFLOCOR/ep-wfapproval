if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_Activity1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_Activity1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WPR_Activity] table.
CREATE PROCEDURE pePortalWFApprovalWPR_Activity1Get
        @pk_WPRA_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WPR_Activity]
    WHERE [WPRA_ID] =@pk_WPRA_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WPRA_ID],
        [WPRA_WS_ID],
        [WPRA_WSD_ID],
        [WPRA_WDT_ID],
        [WPRA_W_U_ID],
        [WPRA_W_U_ID_Delegate],
        [WPRA_WPRD_ID],
        [WPRA_Status],
        [WPRA_Date_Assign],
        [WPRA_Date_Action],
        [WPRA_Remark],
        [WPRA_Is_Done],
        CAST(BINARY_CHECKSUM([WPRA_ID],[WPRA_WS_ID],[WPRA_WSD_ID],[WPRA_WDT_ID],[WPRA_W_U_ID],[WPRA_W_U_ID_Delegate],[WPRA_WPRD_ID],[WPRA_Status],[WPRA_Date_Assign],[WPRA_Date_Action],[WPRA_Remark],[WPRA_Is_Done]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WPR_Activity]
    WHERE [WPRA_ID] =@pk_WPRA_ID
    SET NOCOUNT OFF
END

