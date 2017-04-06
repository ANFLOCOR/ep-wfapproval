if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWClassificationDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWClassificationDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WClassification] table.
CREATE PROCEDURE pePortalWFApprovalWClassificationDelete
        @pk_WClass_ID int
AS
BEGIN
    DELETE [dbo].[WClassification]
    WHERE [WClass_ID] = @pk_WClass_ID
END

