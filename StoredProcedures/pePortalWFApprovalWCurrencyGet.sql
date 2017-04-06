if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCurrencyGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCurrencyGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WCurrency] table.
CREATE PROCEDURE pePortalWFApprovalWCurrencyGet
        @pk_WCur_ID smallint
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WCurrency]
    WHERE [WCur_ID] =@pk_WCur_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WCur_ID],
        [WCur_Short],
        [WCur_Desc],
        CAST(BINARY_CHECKSUM([WCur_ID],[WCur_Short],[WCur_Desc]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WCurrency]
    WHERE [WCur_ID] =@pk_WCur_ID
    SET NOCOUNT OFF
END

