if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WCAR_Doc_Creator_Approver1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WCAR_Doc_Creator_Approver1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_WCAR_Doc_Creator_Approver] table.
CREATE PROCEDURE pePortalWFApprovalSel_WCAR_Doc_Creator_Approver1Delete
        @pk_Row bigint
AS
BEGIN
    DELETE [dbo].[sel_WCAR_Doc_Creator_Approver]
    WHERE [Row] = @pk_Row
END

