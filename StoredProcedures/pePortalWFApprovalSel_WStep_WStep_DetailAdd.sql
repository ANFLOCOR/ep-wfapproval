if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WStep_WStep_DetailAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WStep_WStep_DetailAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_WStep_WStep_Detail] table.
CREATE PROCEDURE pePortalWFApprovalSel_WStep_WStep_DetailAdd
    @p_WSD_ID int,
    @p_WS_ID int,
    @p_WS_WDT_ID int,
    @p_WS_ID_Next int,
    @p_WS_Step_Type varchar(20),
    @p_WS_Approval_Needed smallint,
    @p_WSD_W_U_ID int,
    @p_WSD_Variable_Ref int,
    @p_WSD_Variable_SQL varchar(100)
AS
BEGIN
    INSERT
    INTO [dbo].[sel_WStep_WStep_Detail]
        (
            [WSD_ID],
            [WS_ID],
            [WS_WDT_ID],
            [WS_ID_Next],
            [WS_Step_Type],
            [WS_Approval_Needed],
            [WSD_W_U_ID],
            [WSD_Variable_Ref],
            [WSD_Variable_SQL]
        )
    VALUES
        (
             @p_WSD_ID,
             @p_WS_ID,
             @p_WS_WDT_ID,
             @p_WS_ID_Next,
             @p_WS_Step_Type,
             @p_WS_Approval_Needed,
             @p_WSD_W_U_ID,
             @p_WSD_Variable_Ref,
             @p_WSD_Variable_SQL
        )

END

