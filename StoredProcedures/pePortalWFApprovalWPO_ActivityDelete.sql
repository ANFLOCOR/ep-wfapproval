if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_ActivityDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_ActivityDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WPO_Activity] table.
CREATE PROCEDURE pePortalWFApprovalWPO_ActivityDelete
        @pk_WPO_ID int
AS
BEGIN
    DELETE [dbo].[WPO_Activity]
    WHERE [WPO_ID] = @pk_WPO_ID
END

