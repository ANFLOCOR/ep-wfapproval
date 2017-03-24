if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WPO_POP105501Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WPO_POP105501Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_WPO_POP10550] table.
CREATE PROCEDURE pePortalWFApprovalSel_WPO_POP105501Delete
        @pk_POPNUMBE char(17),
    @pk_ORD int,
    @pk_CompanyID int
AS
BEGIN
    DELETE [dbo].[sel_WPO_POP10550]
    WHERE [POPNUMBE] = @pk_POPNUMBE
    AND [ORD] = @pk_ORD
    AND [CompanyID] = @pk_CompanyID
END

