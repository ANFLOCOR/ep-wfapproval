if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalCategoryDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalCategoryDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[Category] table.
CREATE PROCEDURE pePortalWFApprovalCategoryDelete
        @pk_ID int
AS
BEGIN
    DELETE [dbo].[Category]
    WHERE [ID] = @pk_ID
END

