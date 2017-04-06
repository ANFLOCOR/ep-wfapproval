if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_WFinRep_DocAttach_FIN_MonthDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_WFinRep_DocAttach_FIN_MonthDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[vw_WFinRep_DocAttach_FIN_Month] table.
CREATE PROCEDURE pePortalWFApprovalVw_WFinRep_DocAttach_FIN_MonthDelete
        @pk_Mo int
AS
BEGIN
    DELETE [dbo].[vw_WFinRep_DocAttach_FIN_Month]
    WHERE [Mo] = @pk_Mo
END

