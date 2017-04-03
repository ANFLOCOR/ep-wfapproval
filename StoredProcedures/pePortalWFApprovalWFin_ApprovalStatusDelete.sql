if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFin_ApprovalStatusDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFin_ApprovalStatusDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WFin_ApprovalStatus] table.
CREATE PROCEDURE pePortalWFApprovalWFin_ApprovalStatusDelete
        @pk_WPO_STAT_CD int
AS
BEGIN
    DELETE [dbo].[WFin_ApprovalStatus]
    WHERE [WPO_STAT_CD] = @pk_WPO_STAT_CD
END

