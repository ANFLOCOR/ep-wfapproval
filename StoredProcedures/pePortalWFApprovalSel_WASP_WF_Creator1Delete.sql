if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WASP_WF_Creator1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WASP_WF_Creator1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_WASP_WF_Creator] table.
CREATE PROCEDURE pePortalWFApprovalSel_WASP_WF_Creator1Delete
        @pk_W_U_ID int
AS
BEGIN
    DELETE [dbo].[sel_WASP_WF_Creator]
    WHERE [W_U_ID] = @pk_W_U_ID
END

