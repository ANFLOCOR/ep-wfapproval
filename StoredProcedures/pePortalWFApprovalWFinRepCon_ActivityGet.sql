if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepCon_ActivityGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepCon_ActivityGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WFinRepCon_Activity] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepCon_ActivityGet
        @pk_WFRCA_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WFinRepCon_Activity]
    WHERE [WFRCA_ID] =@pk_WFRCA_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WFRCA_ID],
        [WFRCA_WS_ID],
        [WFRCA_WSD_ID],
        [WFRCA_WDT_ID],
        [WFRCA_W_U_ID],
        [WFRCA_W_U_ID_Delegate],
        [WFRCA_Status],
        [WFRCA_Date_Assign],
        [WFRCA_Date_Action],
        [WFRCA_Remark],
        [WFRCA_Is_Done],
        [WFRCA_Code],
        [WFRCA_FinID],
        [WFRCA_WFRCH_ID],
        CAST(BINARY_CHECKSUM([WFRCA_ID],[WFRCA_WS_ID],[WFRCA_WSD_ID],[WFRCA_WDT_ID],[WFRCA_W_U_ID],[WFRCA_W_U_ID_Delegate],[WFRCA_Status],[WFRCA_Date_Assign],[WFRCA_Date_Action],[WFRCA_Remark],[WFRCA_Is_Done],[WFRCA_Code],[WFRCA_FinID],[WFRCA_WFRCH_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WFinRepCon_Activity]
    WHERE [WFRCA_ID] =@pk_WFRCA_ID
    SET NOCOUNT OFF
END

