if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_IV001011Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_IV001011Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_IV00101] table.
CREATE PROCEDURE pePortalWFApprovalSel_IV001011Delete
        @pk_ITEMNMBR char(31),
    @pk_Company_ID int
AS
BEGIN
    DELETE [dbo].[sel_IV00101]
    WHERE [ITEMNMBR] = @pk_ITEMNMBR
    AND [Company_ID] = @pk_Company_ID
END

