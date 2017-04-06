if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_PO_Map1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_PO_Map1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WCanvass_PO_Map] table.
CREATE PROCEDURE pePortalWFApprovalWCanvass_PO_Map1Delete
        @pk_WCPOM_ID int
AS
BEGIN
    DELETE [dbo].[WCanvass_PO_Map]
    WHERE [WCPOM_ID] = @pk_WCPOM_ID
END

