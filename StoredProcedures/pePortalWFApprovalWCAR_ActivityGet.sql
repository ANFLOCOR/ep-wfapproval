if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCAR_ActivityGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCAR_ActivityGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WCAR_Activity] table.
CREATE PROCEDURE pePortalWFApprovalWCAR_ActivityGet
        @pk_WCA_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WCAR_Activity]
    WHERE [WCA_ID] =@pk_WCA_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WCA_ID],
        [WCA_WS_ID],
        [WCA_WSD_ID],
        [WCA_WDT_ID],
        [WCA_W_U_ID],
        [WCA_W_U_ID_Delegate],
        [WCA_WCD_ID],
        [WCA_Status],
        [WCA_Date_Assign],
        [WCA_Date_Action],
        [WCA_Remark],
        [WCA_Is_Done],
        CAST(BINARY_CHECKSUM([WCA_ID],[WCA_WS_ID],[WCA_WSD_ID],[WCA_WDT_ID],[WCA_W_U_ID],[WCA_W_U_ID_Delegate],[WCA_WCD_ID],[WCA_Status],[WCA_Date_Assign],[WCA_Date_Action],[WCA_Remark],[WCA_Is_Done]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WCAR_Activity]
    WHERE [WCA_ID] =@pk_WCA_ID
    SET NOCOUNT OFF
END

