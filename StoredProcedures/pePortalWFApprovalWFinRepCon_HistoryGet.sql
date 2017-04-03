if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepCon_HistoryGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepCon_HistoryGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WFinRepCon_History] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepCon_HistoryGet
        @pk_WFRCHi_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WFinRepCon_History]
    WHERE [WFRCHi_ID] =@pk_WFRCHi_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WFRCHi_ID],
        [WFRCHi_WFRCH_ID],
        [WFRCHi_File],
        [WFRCHi_CreatedBy],
        [WFRCHi_DateCreated],
        CAST(BINARY_CHECKSUM([WFRCHi_ID],[WFRCHi_WFRCH_ID],[WFRCHi_File],[WFRCHi_CreatedBy],[WFRCHi_DateCreated]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WFinRepCon_History]
    WHERE [WFRCHi_ID] =@pk_WFRCHi_ID
    SET NOCOUNT OFF
END

