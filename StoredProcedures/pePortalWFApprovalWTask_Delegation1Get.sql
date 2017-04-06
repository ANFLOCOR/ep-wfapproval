if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWTask_Delegation1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWTask_Delegation1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WTask_Delegation] table.
CREATE PROCEDURE pePortalWFApprovalWTask_Delegation1Get
        @pk_WTD_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WTask_Delegation]
    WHERE [WTD_ID] =@pk_WTD_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WTD_ID],
        [WTD_W_U_ID],
        [WTD_W_U_ID_Delegate],
        [WTD_WDT_Type],
        [WTD_From],
        [WTD_To],
        [WTD_C_ID],
        CAST(BINARY_CHECKSUM([WTD_ID],[WTD_W_U_ID],[WTD_W_U_ID_Delegate],[WTD_WDT_Type],[WTD_From],[WTD_To],[WTD_C_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WTask_Delegation]
    WHERE [WTD_ID] =@pk_WTD_ID
    SET NOCOUNT OFF
END

