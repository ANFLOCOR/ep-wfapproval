if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_PO_Map_TempDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_PO_Map_TempDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WCanvass_PO_Map_Temp] table.
CREATE PROCEDURE pePortalWFApprovalWCanvass_PO_Map_TempDelete
        @pk_Temp_ID int
AS
BEGIN
    DELETE [dbo].[WCanvass_PO_Map_Temp]
    WHERE [Temp_ID] = @pk_Temp_ID
END

