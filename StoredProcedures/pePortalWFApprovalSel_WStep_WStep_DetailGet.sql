if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WStep_WStep_DetailGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WStep_WStep_DetailGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[sel_WStep_WStep_Detail] table.
CREATE PROCEDURE pePortalWFApprovalSel_WStep_WStep_DetailGet
        @pk_WSD_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[sel_WStep_WStep_Detail]
    WHERE [WSD_ID] =@pk_WSD_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WSD_ID],
        [WS_ID],
        [WS_WDT_ID],
        [WS_ID_Next],
        [WS_Step_Type],
        [WS_Approval_Needed],
        [WSD_W_U_ID],
        [WSD_Variable_Ref],
        [WSD_Variable_SQL],
        CAST(BINARY_CHECKSUM([WSD_ID],[WS_ID],[WS_WDT_ID],[WS_ID_Next],[WS_Step_Type],[WS_Approval_Needed],[WSD_W_U_ID],[WSD_Variable_Ref],[WSD_Variable_SQL]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[sel_WStep_WStep_Detail]
    WHERE [WSD_ID] =@pk_WSD_ID
    SET NOCOUNT OFF
END

