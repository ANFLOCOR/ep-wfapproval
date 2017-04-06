if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_StepAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_StepAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WPO_Step] table.
CREATE PROCEDURE pePortalWFApprovalWPO_StepAdd
    @p_WPO_S_WDT_ID int,
    @p_WPO_S_ID_Next int,
    @p_WPO_S_Step_Type varchar(20),
    @p_WPO_S_Desc varchar(100),
    @p_WPO_S_Approval_Needed smallint,
    @p_WPO_S_C_ID smallint,
    @p_WPO_S_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WPO_Step]
        (
            [WPO_S_WDT_ID],
            [WPO_S_ID_Next],
            [WPO_S_Step_Type],
            [WPO_S_Desc],
            [WPO_S_Approval_Needed],
            [WPO_S_C_ID]
        )
    VALUES
        (
             @p_WPO_S_WDT_ID,
             @p_WPO_S_ID_Next,
             @p_WPO_S_Step_Type,
             @p_WPO_S_Desc,
             @p_WPO_S_Approval_Needed,
             @p_WPO_S_C_ID
        )

    SET @p_WPO_S_ID_out = SCOPE_IDENTITY()

END

