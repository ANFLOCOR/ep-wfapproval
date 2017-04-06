if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_UserDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_UserDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[W_User] table.
CREATE PROCEDURE pePortalWFApprovalW_UserDelete
        @pk_W_U_ID int
AS
BEGIN
    DELETE [dbo].[W_User]
    WHERE [W_U_ID] = @pk_W_U_ID
END

