if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_HistoryDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_HistoryDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WFinRep_History] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_HistoryDelete
        @pk_WFRHi_ID int
AS
BEGIN
    DELETE [dbo].[WFinRep_History]
    WHERE [WFRHi_ID] = @pk_WFRHi_ID
END

