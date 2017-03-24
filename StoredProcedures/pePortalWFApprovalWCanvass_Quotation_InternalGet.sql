if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_Quotation_InternalGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_Quotation_InternalGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WCanvass_Quotation_Internal] table.
CREATE PROCEDURE pePortalWFApprovalWCanvass_Quotation_InternalGet
        @pk_WCQI_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WCanvass_Quotation_Internal]
    WHERE [WCQI_ID] =@pk_WCQI_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WCQI_ID],
        [WCQI_WCI_ID],
        [WCQI_Desc],
        [WCQI_File],
        [WCQI_PM00200_Vendor_ID],
        CAST(BINARY_CHECKSUM([WCQI_ID],[WCQI_WCI_ID],[WCQI_Desc],[WCQI_File],[WCQI_PM00200_Vendor_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WCanvass_Quotation_Internal]
    WHERE [WCQI_ID] =@pk_WCQI_ID
    SET NOCOUNT OFF
END

