if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WStep_WStep_DetailDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WStep_WStep_DetailDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_WStep_WStep_Detail] table.
CREATE PROCEDURE pePortalWFApprovalSel_WStep_WStep_DetailDelete
        @pk_WSD_ID int
AS
BEGIN
    DELETE [dbo].[sel_WStep_WStep_Detail]
    WHERE [WSD_ID] = @pk_WSD_ID
END

