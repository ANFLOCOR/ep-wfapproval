if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWStep1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWStep1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WStep] table.
CREATE PROCEDURE pePortalWFApprovalWStep1Add
    @p_WS_WDT_ID int,
    @p_WS_ID_Next int,
    @p_WS_Step_Type varchar(20),
    @p_WS_Desc varchar(100),
    @p_WS_Approval_Needed smallint,
    @p_WS_C_ID smallint,
    @p_WS_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WStep]
        (
            [WS_WDT_ID],
            [WS_ID_Next],
            [WS_Step_Type],
            [WS_Desc],
            [WS_Approval_Needed],
            [WS_C_ID]
        )
    VALUES
        (
             @p_WS_WDT_ID,
             @p_WS_ID_Next,
             @p_WS_Step_Type,
             @p_WS_Desc,
             @p_WS_Approval_Needed,
             @p_WS_C_ID
        )

    SET @p_WS_ID_out = SCOPE_IDENTITY()

END

