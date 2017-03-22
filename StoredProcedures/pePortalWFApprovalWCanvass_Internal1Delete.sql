if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_Internal1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_Internal1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WCanvass_Internal] table.
CREATE PROCEDURE pePortalWFApprovalWCanvass_Internal1Delete
        @pk_WCI_ID int
AS
BEGIN
    DELETE [dbo].[WCanvass_Internal]
    WHERE [WCI_ID] = @pk_WCI_ID
END

