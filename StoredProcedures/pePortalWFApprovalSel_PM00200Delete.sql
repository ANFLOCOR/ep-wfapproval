if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_PM00200Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_PM00200Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_PM00200] table.
CREATE PROCEDURE pePortalWFApprovalSel_PM00200Delete
        @pk_VENDORID char(15),
    @pk_Company_ID int
AS
BEGIN
    DELETE [dbo].[sel_PM00200]
    WHERE [VENDORID] = @pk_VENDORID
    AND [Company_ID] = @pk_Company_ID
END

