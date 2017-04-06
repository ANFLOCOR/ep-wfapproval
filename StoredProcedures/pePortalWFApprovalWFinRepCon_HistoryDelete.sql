if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepCon_HistoryDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepCon_HistoryDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WFinRepCon_History] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepCon_HistoryDelete
        @pk_WFRCHi_ID int
AS
BEGIN
    DELETE [dbo].[WFinRepCon_History]
    WHERE [WFRCHi_ID] = @pk_WFRCHi_ID
END

