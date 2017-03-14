if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WPO_Activity_WPOP10100Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WPO_Activity_WPOP10100Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_WPO_Activity_WPOP10100] table.
CREATE PROCEDURE pePortalWFApprovalSel_WPO_Activity_WPOP10100Delete
        @pk_WPO_ID int
AS
BEGIN
    DELETE [dbo].[sel_WPO_Activity_WPOP10100]
    WHERE [WPO_ID] = @pk_WPO_ID
END

