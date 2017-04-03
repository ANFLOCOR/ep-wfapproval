if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_Step1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_Step1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WFinRep_Step] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_Step1Delete
        @pk_WFIN_S_ID int
AS
BEGIN
    DELETE [dbo].[WFinRep_Step]
    WHERE [WFIN_S_ID] = @pk_WFIN_S_ID
END

