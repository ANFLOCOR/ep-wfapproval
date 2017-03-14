if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_Role1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_Role1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[W_Role] table.
CREATE PROCEDURE pePortalWFApprovalW_Role1Delete
        @pk_W_R_ID int
AS
BEGIN
    DELETE [dbo].[W_Role]
    WHERE [W_R_ID] = @pk_W_R_ID
END

