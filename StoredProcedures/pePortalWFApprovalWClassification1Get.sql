if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWClassification1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWClassification1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WClassification] table.
CREATE PROCEDURE pePortalWFApprovalWClassification1Get
        @pk_WClass_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WClassification]
    WHERE [WClass_ID] =@pk_WClass_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WClass_ID],
        [WClass_Name],
        [WClass_Value],
        CAST(BINARY_CHECKSUM([WClass_ID],[WClass_Name],[WClass_Value]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WClassification]
    WHERE [WClass_ID] =@pk_WClass_ID
    SET NOCOUNT OFF
END

