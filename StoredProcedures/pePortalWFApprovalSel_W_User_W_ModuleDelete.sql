if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_W_User_W_ModuleDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_W_User_W_ModuleDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_W_User_W_Module] table.
CREATE PROCEDURE pePortalWFApprovalSel_W_User_W_ModuleDelete
        @pk_W_U_ID int,
    @pk_W_MS_ID int
AS
BEGIN
    DELETE [dbo].[sel_W_User_W_Module]
    WHERE [W_U_ID] = @pk_W_U_ID
    AND [W_MS_ID] = @pk_W_MS_ID
END

