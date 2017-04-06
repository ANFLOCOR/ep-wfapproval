if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WAttach_Type_WCAR_Doc_Attach1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WAttach_Type_WCAR_Doc_Attach1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_WAttach_Type_WCAR_Doc_Attach] table.
CREATE PROCEDURE pePortalWFApprovalSel_WAttach_Type_WCAR_Doc_Attach1Delete
        @pk_WCDA_ID int
AS
BEGIN
    DELETE [dbo].[sel_WAttach_Type_WCAR_Doc_Attach]
    WHERE [WCDA_ID] = @pk_WCDA_ID
END

