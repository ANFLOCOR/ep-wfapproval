if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_Doc_StatusDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_Doc_StatusDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WPR_Doc_Status] table.
CREATE PROCEDURE pePortalWFApprovalWPR_Doc_StatusDelete
        @pk_WPRDS_ID smallint
AS
BEGIN
    DELETE [dbo].[WPR_Doc_Status]
    WHERE [WPRDS_ID] = @pk_WPRDS_ID
END

