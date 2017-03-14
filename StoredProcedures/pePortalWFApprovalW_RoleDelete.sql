if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_RoleDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_RoleDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[W_Role] table.
CREATE PROCEDURE pePortalWFApprovalW_RoleDelete
        @pk_W_R_ID int
AS
BEGIN
    DELETE [dbo].[W_Role]
    WHERE [W_R_ID] = @pk_W_R_ID
END

