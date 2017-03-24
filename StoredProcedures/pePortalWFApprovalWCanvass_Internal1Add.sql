if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_Internal1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_Internal1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WCanvass_Internal] table.
CREATE PROCEDURE pePortalWFApprovalWCanvass_Internal1Add
    @p_WCI_C_ID smallint,
    @p_WCI_WPRD_ID int,
    @p_WCI_Date smalldatetime,
    @p_WCI_Submit bit,
    @p_WCI_Status varchar(20),
    @p_WCI_Vendors smallint,
    @p_WCI_U_ID int,
    @p_WCI_WClass_ID int,
    @p_WCI_Contract_Done bit,
    @p_WCI_Contract_Closed smalldatetime,
    @p_WCI_Contract_U_ID int,
    @p_WCI_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WCanvass_Internal]
        (
            [WCI_C_ID],
            [WCI_WPRD_ID],
            [WCI_Date],
            [WCI_Submit],
            [WCI_Status],
            [WCI_Vendors],
            [WCI_U_ID],
            [WCI_WClass_ID],
            [WCI_Contract_Done],
            [WCI_Contract_Closed],
            [WCI_Contract_U_ID]
        )
    VALUES
        (
             @p_WCI_C_ID,
             @p_WCI_WPRD_ID,
             @p_WCI_Date,
             @p_WCI_Submit,
             @p_WCI_Status,
             @p_WCI_Vendors,
             @p_WCI_U_ID,
             @p_WCI_WClass_ID,
             @p_WCI_Contract_Done,
             @p_WCI_Contract_Closed,
             @p_WCI_Contract_U_ID
        )

    SET @p_WCI_ID_out = SCOPE_IDENTITY()

END

