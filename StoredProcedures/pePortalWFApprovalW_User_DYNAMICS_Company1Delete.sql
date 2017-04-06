if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_User_DYNAMICS_Company1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_User_DYNAMICS_Company1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[W_User_DYNAMICS_Company] table.
CREATE PROCEDURE pePortalWFApprovalW_User_DYNAMICS_Company1Delete
        @pk_W_UDC_ID int
AS
BEGIN
    DELETE [dbo].[W_User_DYNAMICS_Company]
    WHERE [W_UDC_ID] = @pk_W_UDC_ID
END

