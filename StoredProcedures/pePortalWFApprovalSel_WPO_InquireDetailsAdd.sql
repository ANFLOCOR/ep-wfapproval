if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WPO_InquireDetailsAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WPO_InquireDetailsAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_WPO_InquireDetails] table.
CREATE PROCEDURE pePortalWFApprovalSel_WPO_InquireDetailsAdd
    @p_CompanyID int,
    @p_PONUMBER char(17),
    @p_LineNumber smallint,
    @p_ITEMNMBR char(31),
    @p_ITEMDESC char(101),
    @p_UOFM char(9),
    @p_UNITCOST numeric(19,5),
    @p_QTYORDER numeric(20,5),
    @p_EXTDCOST numeric(19,5),
    @p_DOCDATE datetime,
    @p_REQSTDBY char(21),
    @p_ORD int,
    @p_COMMENTS varchar(103),
    @p_COMMENT_4 char(51),
    @p_WPOFR_Unit_Cost numeric(19,5),
    @p_WCur_Short varchar(5),
    @p_WPOFR_Rate numeric(18,5)
AS
BEGIN
    INSERT
    INTO [dbo].[sel_WPO_InquireDetails]
        (
            [CompanyID],
            [PONUMBER],
            [LineNumber],
            [ITEMNMBR],
            [ITEMDESC],
            [UOFM],
            [UNITCOST],
            [QTYORDER],
            [EXTDCOST],
            [DOCDATE],
            [REQSTDBY],
            [ORD],
            [COMMENTS],
            [COMMENT_4],
            [WPOFR_Unit_Cost],
            [WCur_Short],
            [WPOFR_Rate]
        )
    VALUES
        (
             @p_CompanyID,
             @p_PONUMBER,
             @p_LineNumber,
             @p_ITEMNMBR,
             @p_ITEMDESC,
             @p_UOFM,
             @p_UNITCOST,
             @p_QTYORDER,
             @p_EXTDCOST,
             @p_DOCDATE,
             @p_REQSTDBY,
             @p_ORD,
             @p_COMMENTS,
             @p_COMMENT_4,
             @p_WPOFR_Unit_Cost,
             @p_WCur_Short,
             @p_WPOFR_Rate
        )

END

