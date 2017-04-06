if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_LineGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_LineGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WPR_Line] table.
CREATE PROCEDURE pePortalWFApprovalWPR_LineGet
        @pk_WPRL_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WPR_Line]
    WHERE [WPRL_ID] =@pk_WPRL_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WPRL_ID],
        [WPRL_WPRD_ID],
        [WPRL_IV00101_Item_No],
        [WPRL_IV40700_Locn_Code],
        [WPRL_PM00200_Vendor_ID],
        [WPRL_GL00101_Acct_Indx],
        [WPRL_IV00101_Prchs_UOM],
        [WPRL_Line_Seq_No],
        [WPRL_Item_Comment],
        [WPRL_Item_Text],
        [WPRL_Item_Desc],
        [WPRL_Item_Non_Inv],
        [WPRL_Required_Date],
        [WPRL_Unit_Price],
        [WPRL_Qty],
        [WPRL_Ext_Price],
        [WPRL_WPRLS_ID],
        [WPRL_PO_No],
        [WPRL_PO_Line_Seq_No],
        [WPRL_Item_Non_Inv_UOM],
        [WPRL_Vendor_Name],
        [WPRL_Account],
        [WPRL_WClass_ID],
        CAST(BINARY_CHECKSUM([WPRL_ID],[WPRL_WPRD_ID],[WPRL_IV00101_Item_No],[WPRL_IV40700_Locn_Code],[WPRL_PM00200_Vendor_ID],[WPRL_GL00101_Acct_Indx],[WPRL_IV00101_Prchs_UOM],[WPRL_Line_Seq_No],[WPRL_Item_Comment],[WPRL_Item_Text],[WPRL_Item_Desc],[WPRL_Item_Non_Inv],[WPRL_Required_Date],[WPRL_Unit_Price],[WPRL_Qty],[WPRL_Ext_Price],[WPRL_WPRLS_ID],[WPRL_PO_No],[WPRL_PO_Line_Seq_No],[WPRL_Item_Non_Inv_UOM],[WPRL_Vendor_Name],[WPRL_Account],[WPRL_WClass_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WPR_Line]
    WHERE [WPRL_ID] =@pk_WPRL_ID
    SET NOCOUNT OFF
END

