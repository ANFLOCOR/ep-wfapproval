if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_PO_Map_TempGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_PO_Map_TempGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WCanvass_PO_Map_Temp] table.
CREATE PROCEDURE pePortalWFApprovalWCanvass_PO_Map_TempGet
        @pk_Temp_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WCanvass_PO_Map_Temp]
    WHERE [Temp_ID] =@pk_Temp_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [Temp_ID],
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
        [Status],
        CAST(BINARY_CHECKSUM([Temp_ID],[WCDI_ID],[WCDI_WCI_ID],[WCDI_WPRL_ID],[WCDI_Status],[WCDI_Audit_Comment],[WCDI_Comment],[WCDI_PM00200_Vendor],[WCDI_Qty],[WCDI_Bid],[WCDI_Award],[WPRL_WPRD_ID],[Item],[ItemDescription],[UnitOfMeasure],[Site],[UnitPrice],[WPRL_Qty],[WPRL_Ext_Price],[WCI_C_ID],[WCI_Status],[WCI_U_ID],[WCI_WClass_ID],[WPRD_Created],[WCI_Date],[Offered_Qty],[Balance_Qty],[WCDI_Vat],[WCDI_Net],[WCDI_WCur_ID],[WPRD_Contract],[WCI_Contract_Done],[WCI_Contract_Closed],[WCI_Contract_U_ID],[Col_Marker],[Status]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WCanvass_PO_Map_Temp]
    WHERE [Temp_ID] =@pk_Temp_ID
    SET NOCOUNT OFF
END

