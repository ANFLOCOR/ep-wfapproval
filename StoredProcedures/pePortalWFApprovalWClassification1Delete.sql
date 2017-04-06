if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWClassification1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWClassification1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WClassification] table.
CREATE PROCEDURE pePortalWFApprovalWClassification1Delete
        @pk_WClass_ID int
AS
BEGIN
    DELETE [dbo].[WClassification]
    WHERE [WClass_ID] = @pk_WClass_ID
END

