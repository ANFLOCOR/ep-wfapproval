if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WPO_WFTaskActivity_RemarksAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WPO_WFTaskActivity_RemarksAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_WPO_WFTaskActivity_Remarks] table.
CREATE PROCEDURE pePortalWFApprovalSel_WPO_WFTaskActivity_RemarksAdd
    @p_WPOP_PONMBR nvarchar(20),
    @p_WPOP_C_ID int,
    @p_WPO_Remark nvarchar(max)
AS
BEGIN
    INSERT
    INTO [dbo].[sel_WPO_WFTaskActivity_Remarks]
        (
            [WPOP_PONMBR],
            [WPOP_C_ID],
            [WPO_Remark]
        )
    VALUES
        (
             @p_WPOP_PONMBR,
             @p_WPOP_C_ID,
             @p_WPO_Remark
        )

END

