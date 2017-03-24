if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_Doc_AttachDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_Doc_AttachDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WPR_Doc_Attach] table.
CREATE PROCEDURE pePortalWFApprovalWPR_Doc_AttachDelete
        @pk_WPRDA_ID int
AS
BEGIN
    DELETE [dbo].[WPR_Doc_Attach]
    WHERE [WPRDA_ID] = @pk_WPRDA_ID
END

