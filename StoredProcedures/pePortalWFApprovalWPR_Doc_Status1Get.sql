if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_Doc_Status1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_Doc_Status1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WPR_Doc_Status] table.
CREATE PROCEDURE pePortalWFApprovalWPR_Doc_Status1Get
        @pk_WPRDS_ID smallint
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WPR_Doc_Status]
    WHERE [WPRDS_ID] =@pk_WPRDS_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WPRDS_ID],
        [WPRDS_Desc],
        [WPRDS_Value],
        CAST(BINARY_CHECKSUM([WPRDS_ID],[WPRDS_Desc],[WPRDS_Value]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WPR_Doc_Status]
    WHERE [WPRDS_ID] =@pk_WPRDS_ID
    SET NOCOUNT OFF
END

