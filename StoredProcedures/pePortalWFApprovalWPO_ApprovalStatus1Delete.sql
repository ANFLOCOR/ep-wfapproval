if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_ApprovalStatus1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_ApprovalStatus1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WPO_ApprovalStatus] table.
CREATE PROCEDURE pePortalWFApprovalWPO_ApprovalStatus1Delete
        @pk_WPO_STAT_CD int
AS
BEGIN
    DELETE [dbo].[WPO_ApprovalStatus]
    WHERE [WPO_STAT_CD] = @pk_WPO_STAT_CD
END

