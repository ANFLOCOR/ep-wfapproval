if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_StepDetailDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_StepDetailDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WFinRep_StepDetail] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_StepDetailDelete
        @pk_WFIN_SD_ID int
AS
BEGIN
    DELETE [dbo].[WFinRep_StepDetail]
    WHERE [WFIN_SD_ID] = @pk_WFIN_SD_ID
END

