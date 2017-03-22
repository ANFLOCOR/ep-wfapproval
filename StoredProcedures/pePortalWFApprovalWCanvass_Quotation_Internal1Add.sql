if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_Quotation_Internal1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_Quotation_Internal1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WCanvass_Quotation_Internal] table.
CREATE PROCEDURE pePortalWFApprovalWCanvass_Quotation_Internal1Add
    @p_WCQI_WCI_ID int,
    @p_WCQI_Desc varchar(250),
    @p_WCQI_File image,
    @p_WCQI_PM00200_Vendor_ID char(15),
    @p_WCQI_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WCanvass_Quotation_Internal]
        (
            [WCQI_WCI_ID],
            [WCQI_Desc],
            [WCQI_File],
            [WCQI_PM00200_Vendor_ID]
        )
    VALUES
        (
             @p_WCQI_WCI_ID,
             @p_WCQI_Desc,
             @p_WCQI_File,
             @p_WCQI_PM00200_Vendor_ID
        )

    SET @p_WCQI_ID_out = SCOPE_IDENTITY()

END

