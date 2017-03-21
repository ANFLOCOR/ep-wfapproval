if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_Doc_Type1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_Doc_Type1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WPO_Doc_Type] table.
CREATE PROCEDURE pePortalWFApprovalWPO_Doc_Type1Get
        @pk_WPO_DT_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WPO_Doc_Type]
    WHERE [WPO_DT_ID] =@pk_WPO_DT_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WPO_DT_ID],
        [WPO_DT_C_ID],
        [WPO_DT_Name],
        [WPO_DT_Desc],
        [WPO_DT_Type],
        [WPO_DT_Minimum],
        [WPO_DT_Maximum],
        [WPO_DT_Limit],
        CAST(BINARY_CHECKSUM([WPO_DT_ID],[WPO_DT_C_ID],[WPO_DT_Name],[WPO_DT_Desc],[WPO_DT_Type],[WPO_DT_Minimum],[WPO_DT_Maximum],[WPO_DT_Limit]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WPO_Doc_Type]
    WHERE [WPO_DT_ID] =@pk_WPO_DT_ID
    SET NOCOUNT OFF
END

