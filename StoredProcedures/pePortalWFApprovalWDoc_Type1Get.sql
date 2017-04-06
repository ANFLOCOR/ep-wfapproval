if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWDoc_Type1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWDoc_Type1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WDoc_Type] table.
CREATE PROCEDURE pePortalWFApprovalWDoc_Type1Get
        @pk_WDT_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WDoc_Type]
    WHERE [WDT_ID] =@pk_WDT_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WDT_ID],
        [WDT_C_ID],
        [WDT_Name],
        [WDT_Desc],
        [WDT_Type],
        [WDT_Limit],
        [WDT_Minimum],
        CAST(BINARY_CHECKSUM([WDT_ID],[WDT_C_ID],[WDT_Name],[WDT_Desc],[WDT_Type],[WDT_Limit],[WDT_Minimum]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WDoc_Type]
    WHERE [WDT_ID] =@pk_WDT_ID
    SET NOCOUNT OFF
END

