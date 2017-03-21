if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WPO_WFTaskActivity_RemarksDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WPO_WFTaskActivity_RemarksDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_WPO_WFTaskActivity_Remarks] table.
CREATE PROCEDURE pePortalWFApprovalSel_WPO_WFTaskActivity_RemarksDelete
        @pk_WPOP_PONMBR nvarchar(20),
    @pk_WPOP_C_ID int
AS
BEGIN
    DELETE [dbo].[sel_WPO_WFTaskActivity_Remarks]
    WHERE [WPOP_PONMBR] = @pk_WPOP_PONMBR
    AND [WPOP_C_ID] = @pk_WPOP_C_ID
END

