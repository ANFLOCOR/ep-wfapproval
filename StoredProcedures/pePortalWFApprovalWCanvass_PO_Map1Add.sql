if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_PO_Map1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_PO_Map1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WCanvass_PO_Map] table.
CREATE PROCEDURE pePortalWFApprovalWCanvass_PO_Map1Add
    @p_WCPOM_C_ID smallint,
    @p_WCPOM_WCDI_ID int,
    @p_WCPOM_WPRD_ID int,
    @p_WCPOM_WPRL_ID int,
    @p_WCPOM_U_ID int,
    @p_WCPOM_PO_No char(17),
    @p_WCPOM_Date smalldatetime,
    @p_WCPOM_PM00200_Vendor char(15),
    @p_WCPOM_Bid numeric(18,5),
    @p_WCPOM_Qty numeric(18,4),
    @p_WCPOM_PO_Line smallint,
    @p_WCPOM_Col_Marker int,
    @p_WCPOM_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WCanvass_PO_Map]
        (
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
            [WCPOM_Col_Marker]
        )
    VALUES
        (
             @p_WCPOM_C_ID,
             @p_WCPOM_WCDI_ID,
             @p_WCPOM_WPRD_ID,
             @p_WCPOM_WPRL_ID,
             @p_WCPOM_U_ID,
             @p_WCPOM_PO_No,
             @p_WCPOM_Date,
             @p_WCPOM_PM00200_Vendor,
             @p_WCPOM_Bid,
             @p_WCPOM_Qty,
             @p_WCPOM_PO_Line,
             @p_WCPOM_Col_Marker
        )

    SET @p_WCPOM_ID_out = SCOPE_IDENTITY()

END

