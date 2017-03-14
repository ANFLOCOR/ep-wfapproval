if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_ActivityGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_ActivityGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WPO_Activity] table.
CREATE PROCEDURE pePortalWFApprovalWPO_ActivityGet
        @pk_WPO_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WPO_Activity]
    WHERE [WPO_ID] =@pk_WPO_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WPO_ID],
        [WPO_WS_ID],
        [WPO_WSD_ID],
        [WPO_WDT_ID],
        [WPO_W_U_ID],
        [WPO_W_U_ID_Delegate],
        [WPO_Status],
        [WPO_Date_Assign],
        [WPO_Date_Action],
        [WPO_Remark],
        [WPO_Is_Done],
        [WPO_PONum],
        [WPO_Is_InclPrint],
        CAST(BINARY_CHECKSUM([WPO_ID],[WPO_WS_ID],[WPO_WSD_ID],[WPO_WDT_ID],[WPO_W_U_ID],[WPO_W_U_ID_Delegate],[WPO_Status],[WPO_Date_Assign],[WPO_Date_Action],[WPO_Remark],[WPO_Is_Done],[WPO_PONum],[WPO_Is_InclPrint]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WPO_Activity]
    WHERE [WPO_ID] =@pk_WPO_ID
    SET NOCOUNT OFF
END

