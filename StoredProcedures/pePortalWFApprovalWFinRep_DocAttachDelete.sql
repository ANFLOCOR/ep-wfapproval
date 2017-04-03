if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_DocAttachDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_DocAttachDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WFinRep_DocAttach] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_DocAttachDelete
        @pk_FIN_ID int
AS
BEGIN
    DELETE [dbo].[WFinRep_DocAttach]
    WHERE [FIN_ID] = @pk_FIN_ID
END

