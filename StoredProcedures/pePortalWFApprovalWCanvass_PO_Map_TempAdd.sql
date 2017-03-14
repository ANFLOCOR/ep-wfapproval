if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_PO_Map_TempAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_PO_Map_TempAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WCanvass_PO_Map_Temp] table.
CREATE PROCEDURE pePortalWFApprovalWCanvass_PO_Map_TempAdd
    @p_WCDI_ID int,
    @p_WCDI_WCI_ID int,
    @p_WCDI_WPRL_ID int,
    @p_WCDI_Status varchar(20),
    @p_WCDI_Audit_Comment varchar(500),
    @p_WCDI_Comment varchar(500),
    @p_WCDI_PM00200_Vendor char(15),
    @p_WCDI_Qty numeric(18,4),
    @p_WCDI_Bid numeric(18,5),
    @p_WCDI_Award bit,
    @p_WPRL_WPRD_ID int,
    @p_Item char(31),
    @p_ItemDescription varchar(500),
    @p_UnitOfMeasure varchar(20),
    @p_Site char(11),
    @p_UnitPrice numeric(18,5),
    @p_WPRL_Qty numeric(18,5),
    @p_WPRL_Ext_Price numeric(18,5),
    @p_WCI_C_ID smallint,
    @p_WCI_Status varchar(20),
    @p_WCI_U_ID int,
    @p_WCI_WClass_ID int,
    @p_WPRD_Created smalldatetime,
    @p_WCI_Date smalldatetime,
    @p_Offered_Qty numeric(38,9),
    @p_Balance_Qty numeric(38,9),
    @p_WCDI_Vat bit,
    @p_WCDI_Net numeric(18,5),
    @p_WCDI_WCur_ID smallint,
    @p_WPRD_Contract bit,
    @p_WCI_Contract_Done bit,
    @p_WCI_Contract_Closed smalldatetime,
    @p_WCI_Contract_U_ID int,
    @p_Col_Marker int,
    @p_Status varchar(7),
    @p_Temp_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WCanvass_PO_Map_Temp]
        (
            [WCDI_ID],
            [WCDI_WCI_ID],
            [WCDI_WPRL_ID],
            [WCDI_Status],
            [WCDI_Audit_Comment],
            [WCDI_Comment],
            [WCDI_PM00200_Vendor],
            [WCDI_Qty],
            [WCDI_Bid],
            [WCDI_Award],
            [WPRL_WPRD_ID],
            [Item],
            [ItemDescription],
            [UnitOfMeasure],
            [Site],
            [UnitPrice],
            [WPRL_Qty],
            [WPRL_Ext_Price],
            [WCI_C_ID],
            [WCI_Status],
            [WCI_U_ID],
            [WCI_WClass_ID],
            [WPRD_Created],
            [WCI_Date],
            [Offered_Qty],
            [Balance_Qty],
            [WCDI_Vat],
            [WCDI_Net],
            [WCDI_WCur_ID],
            [WPRD_Contract],
            [WCI_Contract_Done],
            [WCI_Contract_Closed],
            [WCI_Contract_U_ID],
            [Col_Marker],
            [Status]
        )
    VALUES
        (
             @p_WCDI_ID,
             @p_WCDI_WCI_ID,
             @p_WCDI_WPRL_ID,
             @p_WCDI_Status,
             @p_WCDI_Audit_Comment,
             @p_WCDI_Comment,
             @p_WCDI_PM00200_Vendor,
             @p_WCDI_Qty,
             @p_WCDI_Bid,
             @p_WCDI_Award,
             @p_WPRL_WPRD_ID,
             @p_Item,
             @p_ItemDescription,
             @p_UnitOfMeasure,
             @p_Site,
             @p_UnitPrice,
             @p_WPRL_Qty,
             @p_WPRL_Ext_Price,
             @p_WCI_C_ID,
             @p_WCI_Status,
             @p_WCI_U_ID,
             @p_WCI_WClass_ID,
             @p_WPRD_Created,
             @p_WCI_Date,
             @p_Offered_Qty,
             @p_Balance_Qty,
             @p_WCDI_Vat,
             @p_WCDI_Net,
             @p_WCDI_WCur_ID,
             @p_WPRD_Contract,
             @p_WCI_Contract_Done,
             @p_WCI_Contract_Closed,
             @p_WCI_Contract_U_ID,
             @p_Col_Marker,
             @p_Status
        )

    SET @p_Temp_ID_out = SCOPE_IDENTITY()

END

