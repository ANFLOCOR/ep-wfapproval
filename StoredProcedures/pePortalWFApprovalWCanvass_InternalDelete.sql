if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_InternalDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_InternalDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WCanvass_Internal] table.
CREATE PROCEDURE pePortalWFApprovalWCanvass_InternalDelete
        @pk_WCI_ID int
AS
BEGIN
    DELETE [dbo].[WCanvass_Internal]
    WHERE [WCI_ID] = @pk_WCI_ID
END

