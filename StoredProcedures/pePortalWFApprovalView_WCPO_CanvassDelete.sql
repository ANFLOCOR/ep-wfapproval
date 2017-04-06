if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalView_WCPO_CanvassDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalView_WCPO_CanvassDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[view_WCPO_Canvass] table.
CREATE PROCEDURE pePortalWFApprovalView_WCPO_CanvassDelete
        @pk_WCI_ID int
AS
BEGIN
    DELETE [dbo].[view_WCPO_Canvass]
    WHERE [WCI_ID] = @pk_WCI_ID
END

