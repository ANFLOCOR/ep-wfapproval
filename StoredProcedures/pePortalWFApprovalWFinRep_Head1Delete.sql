if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_Head1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_Head1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WFinRep_Head] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_Head1Delete
        @pk_HFIN_ID int
AS
BEGIN
    DELETE [dbo].[WFinRep_Head]
    WHERE [HFIN_ID] = @pk_HFIN_ID
END

