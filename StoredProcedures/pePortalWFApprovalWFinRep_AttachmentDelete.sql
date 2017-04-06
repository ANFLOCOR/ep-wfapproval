if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_AttachmentDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_AttachmentDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WFinRep_Attachment] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_AttachmentDelete
        @pk_WFRA_ID int
AS
BEGIN
    DELETE [dbo].[WFinRep_Attachment]
    WHERE [WFRA_ID] = @pk_WFRA_ID
END

