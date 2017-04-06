if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WAttach_Type_WCAR_Doc_Attach1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WAttach_Type_WCAR_Doc_Attach1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_WAttach_Type_WCAR_Doc_Attach] table.
CREATE PROCEDURE pePortalWFApprovalSel_WAttach_Type_WCAR_Doc_Attach1Add
    @p_WCDA_ID int,
    @p_WCDA_WCD_ID int,
    @p_WCDA_Desc varchar(50),
    @p_WCDA_File image,
    @p_WAT_ID smallint,
    @p_WAT_Name varchar(50),
    @p_WAT_Order smallint
AS
BEGIN
    INSERT
    INTO [dbo].[sel_WAttach_Type_WCAR_Doc_Attach]
        (
            [WCDA_ID],
            [WCDA_WCD_ID],
            [WCDA_Desc],
            [WCDA_File],
            [WAT_ID],
            [WAT_Name],
            [WAT_Order]
        )
    VALUES
        (
             @p_WCDA_ID,
             @p_WCDA_WCD_ID,
             @p_WCDA_Desc,
             @p_WCDA_File,
             @p_WAT_ID,
             @p_WAT_Name,
             @p_WAT_Order
        )

END

