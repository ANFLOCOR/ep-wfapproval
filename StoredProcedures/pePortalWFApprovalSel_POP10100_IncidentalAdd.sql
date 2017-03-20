if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_POP10100_IncidentalAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_POP10100_IncidentalAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_POP10100_Incidental] table.
CREATE PROCEDURE pePortalWFApprovalSel_POP10100_IncidentalAdd
    @p_PONUMBER char(17),
    @p_POSTATUS smallint,
    @p_DOCDATE datetime,
    @p_SUBTOTAL numeric(19,5),
    @p_VENDORID char(15),
    @p_VENDNAME char(65),
    @p_Company_ID int,
    @p_PRMDATE datetime,
    @p_SHIPMTHD char(15),
    @p_TAXAMNT numeric(19,5),
    @p_PYMTRMID char(21),
    @p_COMMNTID char(15)
AS
BEGIN
    INSERT
    INTO [dbo].[sel_POP10100_Incidental]
        (
            [PONUMBER],
            [POSTATUS],
            [DOCDATE],
            [SUBTOTAL],
            [VENDORID],
            [VENDNAME],
            [Company_ID],
            [PRMDATE],
            [SHIPMTHD],
            [TAXAMNT],
            [PYMTRMID],
            [COMMNTID]
        )
    VALUES
        (
             @p_PONUMBER,
             @p_POSTATUS,
             @p_DOCDATE,
             @p_SUBTOTAL,
             @p_VENDORID,
             @p_VENDNAME,
             @p_Company_ID,
             @p_PRMDATE,
             @p_SHIPMTHD,
             @p_TAXAMNT,
             @p_PYMTRMID,
             @p_COMMNTID
        )

END

