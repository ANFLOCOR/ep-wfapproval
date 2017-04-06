if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWStep_Detail1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWStep_Detail1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WStep_Detail] table.
CREATE PROCEDURE pePortalWFApprovalWStep_Detail1Get
        @pk_WSD_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WStep_Detail]
    WHERE [WSD_ID] =@pk_WSD_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WSD_ID],
        [WSD_WS_ID],
        [WSD_W_U_ID],
        [WSD_Desc],
        [WSD_Status],
        [WSD_Variable_Ref],
        [WSD_Variable_SQL],
        [WSD_Expire],
        [WSD_W_U_ID_Delegate],
        [WSD_Is_Escalate],
        CAST(BINARY_CHECKSUM([WSD_ID],[WSD_WS_ID],[WSD_W_U_ID],[WSD_Desc],[WSD_Status],[WSD_Variable_Ref],[WSD_Variable_SQL],[WSD_Expire],[WSD_W_U_ID_Delegate],[WSD_Is_Escalate]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WStep_Detail]
    WHERE [WSD_ID] =@pk_WSD_ID
    SET NOCOUNT OFF
END

