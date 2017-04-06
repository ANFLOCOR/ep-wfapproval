if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_WFHistory_Details_new1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_WFHistory_Details_new1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WPO_WFHistory_Details_new] table.
CREATE PROCEDURE pePortalWFApprovalWPO_WFHistory_Details_new1Delete
        @pk_WPO_ID int,
    @pk_WPO_PONum nvarchar(20),
    @pk_WPOP_C_ID int
AS
BEGIN
    DELETE [dbo].[WPO_WFHistory_Details_new]
    WHERE [WPO_ID] = @pk_WPO_ID
    AND [WPO_PONum] = @pk_WPO_PONum
    AND [WPOP_C_ID] = @pk_WPOP_C_ID
END

