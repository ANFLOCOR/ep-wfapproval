if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWStep1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWStep1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WStep] table.
CREATE PROCEDURE pePortalWFApprovalWStep1Get
        @pk_WS_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WStep]
    WHERE [WS_ID] =@pk_WS_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WS_ID],
        [WS_WDT_ID],
        [WS_ID_Next],
        [WS_Step_Type],
        [WS_Desc],
        [WS_Approval_Needed],
        [WS_C_ID],
        CAST(BINARY_CHECKSUM([WS_ID],[WS_WDT_ID],[WS_ID_Next],[WS_Step_Type],[WS_Desc],[WS_Approval_Needed],[WS_C_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WStep]
    WHERE [WS_ID] =@pk_WS_ID
    SET NOCOUNT OFF
END

