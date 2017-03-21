if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_ActivityDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_ActivityDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WPR_Activity] table.
CREATE PROCEDURE pePortalWFApprovalWPR_ActivityDelete
        @pk_WPRA_ID int
AS
BEGIN
    DELETE [dbo].[WPR_Activity]
    WHERE [WPRA_ID] = @pk_WPRA_ID
END

