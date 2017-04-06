if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_Doc_AttachDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_Doc_AttachDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WPO_Doc_Attach] table.
CREATE PROCEDURE pePortalWFApprovalWPO_Doc_AttachDelete
        @pk_WPODA_ID int
AS
BEGIN
    DELETE [dbo].[WPO_Doc_Attach]
    WHERE [WPODA_ID] = @pk_WPODA_ID
END

