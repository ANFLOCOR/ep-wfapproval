if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_CARNo_QWF1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_CARNo_QWF1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WPO_CARNo_QWF] table.
CREATE PROCEDURE pePortalWFApprovalWPO_CARNo_QWF1Delete
        @pk_PONum char(30),
    @pk_PRNum varchar(50)
AS
BEGIN
    DELETE [dbo].[WPO_CARNo_QWF]
    WHERE [PONum] = @pk_PONum
    AND [PRNum] = @pk_PRNum
END

