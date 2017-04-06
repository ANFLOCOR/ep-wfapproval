if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepNGP_ActivityGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepNGP_ActivityGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WFinRepNGP_Activity] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepNGP_ActivityGet
        @pk_WFRNGPA_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WFinRepNGP_Activity]
    WHERE [WFRNGPA_ID] =@pk_WFRNGPA_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WFRNGPA_ID],
        [WFRNGPA_WS_ID],
        [WFRNGPA_WSD_ID],
        [WFRNGPA_WDT_ID],
        [WFRNGPA_W_U_ID],
        [WFRNGPA_W_U_ID_Delegate],
        [WFRNGPA_Status],
        [WFRNGPA_Date_Assign],
        [WFRNGPA_Date_Action],
        [WFRNGPA_Remark],
        [WFRNGPA_Is_Done],
        [WFRNGPA_Code],
        [WFRNGPA_FinID],
        [WFRNGPA_WFRCHNGP_ID],
        CAST(BINARY_CHECKSUM([WFRNGPA_ID],[WFRNGPA_WS_ID],[WFRNGPA_WSD_ID],[WFRNGPA_WDT_ID],[WFRNGPA_W_U_ID],[WFRNGPA_W_U_ID_Delegate],[WFRNGPA_Status],[WFRNGPA_Date_Assign],[WFRNGPA_Date_Action],[WFRNGPA_Remark],[WFRNGPA_Is_Done],[WFRNGPA_Code],[WFRNGPA_FinID],[WFRNGPA_WFRCHNGP_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WFinRepNGP_Activity]
    WHERE [WFRNGPA_ID] =@pk_WFRNGPA_ID
    SET NOCOUNT OFF
END

