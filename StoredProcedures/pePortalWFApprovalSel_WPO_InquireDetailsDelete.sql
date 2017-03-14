if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WPO_InquireDetailsDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WPO_InquireDetailsDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_WPO_InquireDetails] table.
CREATE PROCEDURE pePortalWFApprovalSel_WPO_InquireDetailsDelete
        @pk_CompanyID int,
    @pk_PONUMBER char(17),
    @pk_LineNumber smallint,
    @pk_ITEMNMBR char(31)
AS
BEGIN
    DELETE [dbo].[sel_WPO_InquireDetails]
    WHERE [CompanyID] = @pk_CompanyID
    AND [PONUMBER] = @pk_PONUMBER
    AND [LineNumber] = @pk_LineNumber
    AND [ITEMNMBR] = @pk_ITEMNMBR
END

