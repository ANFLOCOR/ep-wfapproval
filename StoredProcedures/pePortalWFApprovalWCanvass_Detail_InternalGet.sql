if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_Detail_InternalGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_Detail_InternalGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WCanvass_Detail_Internal] table.
CREATE PROCEDURE pePortalWFApprovalWCanvass_Detail_InternalGet
        @pk_WCDI_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WCanvass_Detail_Internal]
    WHERE [WCDI_ID] =@pk_WCDI_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WCDI_ID],
        [WCDI_WCI_ID],
        [WCDI_WPRL_ID],
        [WCDI_PM00200_Vendor_ID1],
        [WCDI_PM00200_Vendor_ID2],
        [WCDI_PM00200_Vendor_ID3],
        [WCDI_PM00200_Vendor_ID4],
        [WCDI_PM00200_Vendor_ID5],
        [WCDI_PM00200_Vendor_ID6],
        [WCDI_Bid1],
        [WCDI_Bid2],
        [WCDI_Bid3],
        [WCDI_Bid4],
        [WCDI_Bid5],
        [WCDI_Bid6],
        [WCDI_Award1],
        [WCDI_Award2],
        [WCDI_Award3],
        [WCDI_Award4],
        [WCDI_Award5],
        [WCDI_Award6],
        [WCDI_Status],
        [WCDI_Audit_Comment],
        [WCDI_Comment],
        [WCDI_PM00200_Vendor_ID7],
        [WCDI_PM00200_Vendor_ID8],
        [WCDI_PM00200_Vendor_ID9],
        [WCDI_PM00200_Vendor_ID10],
        [WCDI_Bid7],
        [WCDI_Bid8],
        [WCDI_Bid9],
        [WCDI_Bid10],
        [WCDI_Award7],
        [WCDI_Award8],
        [WCDI_Award9],
        [WCDI_Award10],
        [WCDI_Qty1],
        [WCDI_Qty2],
        [WCDI_Qty3],
        [WCDI_Qty4],
        [WCDI_Qty5],
        [WCDI_Qty6],
        [WCDI_Qty7],
        [WCDI_Qty8],
        [WCDI_Qty9],
        [WCDI_Qty10],
        [WCDI_PO1],
        [WCDI_PO2],
        [WCDI_PO3],
        [WCDI_PO4],
        [WCDI_PO5],
        [WCDI_PO6],
        [WCDI_PO7],
        [WCDI_PO8],
        [WCDI_PO9],
        [WCDI_PO10],
        [WCDI_Aw1],
        [WCDI_Aw2],
        [WCDI_Aw3],
        [WCDI_Aw4],
        [WCDI_Aw5],
        [WCDI_Aw6],
        [WCDI_Aw7],
        [WCDI_Aw8],
        [WCDI_Aw9],
        [WCDI_Aw10],
        [WCDI_Vat1],
        [WCDI_Vat2],
        [WCDI_Vat3],
        [WCDI_Vat4],
        [WCDI_Vat5],
        [WCDI_Vat6],
        [WCDI_Vat7],
        [WCDI_Vat8],
        [WCDI_Vat9],
        [WCDI_Vat10],
        [WCDI_Net1],
        [WCDI_Net2],
        [WCDI_Net3],
        [WCDI_Net4],
        [WCDI_Net5],
        [WCDI_Net6],
        [WCDI_Net7],
        [WCDI_Net8],
        [WCDI_Net9],
        [WCDI_Net10],
        [WCDI_WCur_ID1],
        [WCDI_WCur_ID2],
        [WCDI_WCur_ID3],
        [WCDI_WCur_ID4],
        [WCDI_WCur_ID5],
        [WCDI_WCur_ID6],
        [WCDI_WCur_ID7],
        [WCDI_WCur_ID8],
        [WCDI_WCur_ID9],
        [WCDI_WCur_ID10],
        CAST(BINARY_CHECKSUM([WCDI_ID],[WCDI_WCI_ID],[WCDI_WPRL_ID],[WCDI_PM00200_Vendor_ID1],[WCDI_PM00200_Vendor_ID2],[WCDI_PM00200_Vendor_ID3],[WCDI_PM00200_Vendor_ID4],[WCDI_PM00200_Vendor_ID5],[WCDI_PM00200_Vendor_ID6],[WCDI_Bid1],[WCDI_Bid2],[WCDI_Bid3],[WCDI_Bid4],[WCDI_Bid5],[WCDI_Bid6],[WCDI_Award1],[WCDI_Award2],[WCDI_Award3],[WCDI_Award4],[WCDI_Award5],[WCDI_Award6],[WCDI_Status],[WCDI_Audit_Comment],[WCDI_Comment],[WCDI_PM00200_Vendor_ID7],[WCDI_PM00200_Vendor_ID8],[WCDI_PM00200_Vendor_ID9],[WCDI_PM00200_Vendor_ID10],[WCDI_Bid7],[WCDI_Bid8],[WCDI_Bid9],[WCDI_Bid10],[WCDI_Award7],[WCDI_Award8],[WCDI_Award9],[WCDI_Award10],[WCDI_Qty1],[WCDI_Qty2],[WCDI_Qty3],[WCDI_Qty4],[WCDI_Qty5],[WCDI_Qty6],[WCDI_Qty7],[WCDI_Qty8],[WCDI_Qty9],[WCDI_Qty10],[WCDI_PO1],[WCDI_PO2],[WCDI_PO3],[WCDI_PO4],[WCDI_PO5],[WCDI_PO6],[WCDI_PO7],[WCDI_PO8],[WCDI_PO9],[WCDI_PO10],[WCDI_Aw1],[WCDI_Aw2],[WCDI_Aw3],[WCDI_Aw4],[WCDI_Aw5],[WCDI_Aw6],[WCDI_Aw7],[WCDI_Aw8],[WCDI_Aw9],[WCDI_Aw10],[WCDI_Vat1],[WCDI_Vat2],[WCDI_Vat3],[WCDI_Vat4],[WCDI_Vat5],[WCDI_Vat6],[WCDI_Vat7],[WCDI_Vat8],[WCDI_Vat9],[WCDI_Vat10],[WCDI_Net1],[WCDI_Net2],[WCDI_Net3],[WCDI_Net4],[WCDI_Net5],[WCDI_Net6],[WCDI_Net7],[WCDI_Net8],[WCDI_Net9],[WCDI_Net10],[WCDI_WCur_ID1],[WCDI_WCur_ID2],[WCDI_WCur_ID3],[WCDI_WCur_ID4],[WCDI_WCur_ID5],[WCDI_WCur_ID6],[WCDI_WCur_ID7],[WCDI_WCur_ID8],[WCDI_WCur_ID9],[WCDI_WCur_ID10]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WCanvass_Detail_Internal]
    WHERE [WCDI_ID] =@pk_WCDI_ID
    SET NOCOUNT OFF
END

