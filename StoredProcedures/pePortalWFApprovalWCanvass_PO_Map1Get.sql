if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_PO_Map1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_PO_Map1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WCanvass_PO_Map] table.
CREATE PROCEDURE pePortalWFApprovalWCanvass_PO_Map1Get
        @pk_WCPOM_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WCanvass_PO_Map]
    WHERE [WCPOM_ID] =@pk_WCPOM_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WCPOM_ID],
        [WCPOM_C_ID],
        [WCPOM_WCDI_ID],
        [WCPOM_WPRD_ID],
        [WCPOM_WPRL_ID],
        [WCPOM_U_ID],
        [WCPOM_PO_No],
        [WCPOM_Date],
        [WCPOM_PM00200_Vendor],
        [WCPOM_Bid],
        [WCPOM_Qty],
        [WCPOM_PO_Line],
        [WCPOM_Col_Marker],
        CAST(BINARY_CHECKSUM([WCPOM_ID],[WCPOM_C_ID],[WCPOM_WCDI_ID],[WCPOM_WPRD_ID],[WCPOM_WPRL_ID],[WCPOM_U_ID],[WCPOM_PO_No],[WCPOM_Date],[WCPOM_PM00200_Vendor],[WCPOM_Bid],[WCPOM_Qty],[WCPOM_PO_Line],[WCPOM_Col_Marker]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WCanvass_PO_Map]
    WHERE [WCPOM_ID] =@pk_WCPOM_ID
    SET NOCOUNT OFF
END

