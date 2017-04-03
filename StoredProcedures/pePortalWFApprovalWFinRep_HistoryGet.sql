if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_HistoryGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_HistoryGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WFinRep_History] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_HistoryGet
        @pk_WFRHi_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WFinRep_History]
    WHERE [WFRHi_ID] =@pk_WFRHi_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WFRHi_ID],
        [WFRHi_WFRCH_ID],
        [WFRHi_File],
        [WFRHi_CreatedBy],
        [WFRHi_DateCreated],
        CAST(BINARY_CHECKSUM([WFRHi_ID],[WFRHi_WFRCH_ID],[WFRHi_File],[WFRHi_CreatedBy],[WFRHi_DateCreated]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WFinRep_History]
    WHERE [WFRHi_ID] =@pk_WFRHi_ID
    SET NOCOUNT OFF
END

