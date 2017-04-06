if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_User_Role1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_User_Role1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[W_User_Role] table.
CREATE PROCEDURE pePortalWFApprovalW_User_Role1Delete
        @pk_W_UR_ID int
AS
BEGIN
    DELETE [dbo].[W_User_Role]
    WHERE [W_UR_ID] = @pk_W_UR_ID
END

