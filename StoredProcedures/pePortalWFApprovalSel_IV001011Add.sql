if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_IV001011Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_IV001011Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_IV00101] table.
CREATE PROCEDURE pePortalWFApprovalSel_IV001011Add
    @p_ITEMNMBR char(31),
    @p_ITEMDESC varchar(101),
    @p_CURRCOST numeric(19,5),
    @p_IVIVOFIX int,
    @p_IVIVINDX int,
    @p_LOCNCODE char(11),
    @p_PRCHSUOM char(9),
    @p_Company_ID int,
    @p_Account varchar(39),
    @p_ITMSHNAM char(15)
AS
BEGIN
    INSERT
    INTO [dbo].[sel_IV00101]
        (
            [ITEMNMBR],
            [ITEMDESC],
            [CURRCOST],
            [IVIVOFIX],
            [IVIVINDX],
            [LOCNCODE],
            [PRCHSUOM],
            [Company_ID],
            [Account],
            [ITMSHNAM]
        )
    VALUES
        (
             @p_ITEMNMBR,
             @p_ITEMDESC,
             @p_CURRCOST,
             @p_IVIVOFIX,
             @p_IVIVINDX,
             @p_LOCNCODE,
             @p_PRCHSUOM,
             @p_Company_ID,
             @p_Account,
             @p_ITMSHNAM
        )

END

