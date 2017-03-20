if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_Doc1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_Doc1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WPR_Doc] table.
CREATE PROCEDURE pePortalWFApprovalWPR_Doc1Get
        @pk_WPRD_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WPR_Doc]
    WHERE [WPRD_ID] =@pk_WPRD_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WPRD_ID],
        [WPRD_C_ID],
        [WPRD_WDT_ID],
        [WPRD_WCD_ID],
        [WPRD_WCur_ID],
        [WPRD_U_ID],
        [WPRD_U_ID_Modify],
        [WPRD_No],
        [WPRD_Created],
        [WPRD_Modified],
        [WPRD_Total],
        [WPRD_Comment],
        [WPRD_WPRDS_ID],
        [WPRD_Submit],
        [WPRD_Title],
        [WPRD_Contract],
        CAST(BINARY_CHECKSUM([WPRD_ID],[WPRD_C_ID],[WPRD_WDT_ID],[WPRD_WCD_ID],[WPRD_WCur_ID],[WPRD_U_ID],[WPRD_U_ID_Modify],[WPRD_No],[WPRD_Created],[WPRD_Modified],[WPRD_Total],[WPRD_Comment],[WPRD_WPRDS_ID],[WPRD_Submit],[WPRD_Title],[WPRD_Contract]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WPR_Doc]
    WHERE [WPRD_ID] =@pk_WPRD_ID
    SET NOCOUNT OFF
END

