if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_W_User_W_Module1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_W_User_W_Module1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_W_User_W_Module] table.
CREATE PROCEDURE pePortalWFApprovalSel_W_User_W_Module1Delete
        @pk_W_MS_ID int
AS
BEGIN
    DELETE [dbo].[sel_W_User_W_Module]
    WHERE [W_MS_ID] = @pk_W_MS_ID
END

