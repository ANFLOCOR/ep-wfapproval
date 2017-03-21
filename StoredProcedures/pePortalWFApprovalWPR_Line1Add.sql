if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_Line1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_Line1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WPR_Line] table.
CREATE PROCEDURE pePortalWFApprovalWPR_Line1Add
    @p_WPRL_WPRD_ID int,
    @p_WPRL_IV00101_Item_No char(31),
    @p_WPRL_IV40700_Locn_Code char(11),
    @p_WPRL_PM00200_Vendor_ID char(15),
    @p_WPRL_GL00101_Acct_Indx int,
    @p_WPRL_IV00101_Prchs_UOM char(10),
    @p_WPRL_Line_Seq_No int,
    @p_WPRL_Item_Comment varchar(500),
    @p_WPRL_Item_Text varchar(500),
    @p_WPRL_Item_Desc varchar(500),
    @p_WPRL_Item_Non_Inv varchar(500),
    @p_WPRL_Required_Date smalldatetime,
    @p_WPRL_Unit_Price numeric(18,5),
    @p_WPRL_Qty numeric(18,5),
    @p_WPRL_Ext_Price numeric(18,5),
    @p_WPRL_WPRLS_ID smallint,
    @p_WPRL_PO_No varchar(30),
    @p_WPRL_PO_Line_Seq_No int,
    @p_WPRL_Item_Non_Inv_UOM varchar(20),
    @p_WPRL_Vendor_Name varchar(250),
    @p_WPRL_Account varchar(50),
    @p_WPRL_WClass_ID int,
    @p_WPRL_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WPR_Line]
        (
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
            [WPRL_WClass_ID]
        )
    VALUES
        (
             @p_WPRL_WPRD_ID,
             @p_WPRL_IV00101_Item_No,
             @p_WPRL_IV40700_Locn_Code,
             @p_WPRL_PM00200_Vendor_ID,
             @p_WPRL_GL00101_Acct_Indx,
             @p_WPRL_IV00101_Prchs_UOM,
             @p_WPRL_Line_Seq_No,
             @p_WPRL_Item_Comment,
             @p_WPRL_Item_Text,
             @p_WPRL_Item_Desc,
             @p_WPRL_Item_Non_Inv,
             @p_WPRL_Required_Date,
             @p_WPRL_Unit_Price,
             @p_WPRL_Qty,
             @p_WPRL_Ext_Price,
             @p_WPRL_WPRLS_ID,
             @p_WPRL_PO_No,
             @p_WPRL_PO_Line_Seq_No,
             @p_WPRL_Item_Non_Inv_UOM,
             @p_WPRL_Vendor_Name,
             @p_WPRL_Account,
             @p_WPRL_WClass_ID
        )

    SET @p_WPRL_ID_out = SCOPE_IDENTITY()

END

