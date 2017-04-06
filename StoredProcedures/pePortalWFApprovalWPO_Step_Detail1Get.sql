if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_Step_Detail1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_Step_Detail1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WPO_Step_Detail] table.
CREATE PROCEDURE pePortalWFApprovalWPO_Step_Detail1Get
        @pk_WPO_SD_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WPO_Step_Detail]
    WHERE [WPO_SD_ID] =@pk_WPO_SD_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WPO_SD_ID],
        [WPO_SD_S_ID],
        [WPO_SD_W_U_ID],
        [WPO_SD_Desc],
        [WPO_SD_Status],
        [WPO_SD_Variable_Ref],
        [WPO_SD_Variable_SQL],
        [WPO_SD_Expire],
        [WPO_SD_W_U_ID_Delegate],
        [WPO_SD_Is_Escalate],
        [WPO_SD_Is_FAP],
        CAST(BINARY_CHECKSUM([WPO_SD_ID],[WPO_SD_S_ID],[WPO_SD_W_U_ID],[WPO_SD_Desc],[WPO_SD_Status],[WPO_SD_Variable_Ref],[WPO_SD_Variable_SQL],[WPO_SD_Expire],[WPO_SD_W_U_ID_Delegate],[WPO_SD_Is_Escalate],[WPO_SD_Is_FAP]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WPO_Step_Detail]
    WHERE [WPO_SD_ID] =@pk_WPO_SD_ID
    SET NOCOUNT OFF
END

