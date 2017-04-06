if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalCFBS_CategoryMappingDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalCFBS_CategoryMappingDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[CFBS_CategoryMapping] table.
CREATE PROCEDURE pePortalWFApprovalCFBS_CategoryMappingDelete
        @pk_MapID int
AS
BEGIN
    DELETE [dbo].[CFBS_CategoryMapping]
    WHERE [MapID] = @pk_MapID
END

