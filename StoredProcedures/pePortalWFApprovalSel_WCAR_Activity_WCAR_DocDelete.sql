if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WCAR_Activity_WCAR_DocDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WCAR_Activity_WCAR_DocDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_WCAR_Activity_WCAR_Doc] table.
CREATE PROCEDURE pePortalWFApprovalSel_WCAR_Activity_WCAR_DocDelete
        @pk_WCA_ID int
AS
BEGIN
    DELETE [dbo].[sel_WCAR_Activity_WCAR_Doc]
    WHERE [WCA_ID] = @pk_WCA_ID
END

