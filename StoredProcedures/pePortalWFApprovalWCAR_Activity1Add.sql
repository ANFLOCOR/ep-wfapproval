if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCAR_Activity1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCAR_Activity1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WCAR_Activity] table.
CREATE PROCEDURE pePortalWFApprovalWCAR_Activity1Add
    @p_WCA_WS_ID int,
    @p_WCA_WSD_ID int,
    @p_WCA_WDT_ID int,
    @p_WCA_W_U_ID int,
    @p_WCA_W_U_ID_Delegate int,
    @p_WCA_WCD_ID int,
    @p_WCA_Status varchar(50),
    @p_WCA_Date_Assign smalldatetime,
    @p_WCA_Date_Action smalldatetime,
    @p_WCA_Remark varchar(max),
    @p_WCA_Is_Done bit,
    @p_WCA_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WCAR_Activity]
        (
            [WCA_WS_ID],
            [WCA_WSD_ID],
            [WCA_WDT_ID],
            [WCA_W_U_ID],
            [WCA_W_U_ID_Delegate],
            [WCA_WCD_ID],
            [WCA_Status],
            [WCA_Date_Assign],
            [WCA_Date_Action],
            [WCA_Remark],
            [WCA_Is_Done]
        )
    VALUES
        (
             @p_WCA_WS_ID,
             @p_WCA_WSD_ID,
             @p_WCA_WDT_ID,
             @p_WCA_W_U_ID,
             @p_WCA_W_U_ID_Delegate,
             @p_WCA_WCD_ID,
             @p_WCA_Status,
             @p_WCA_Date_Assign,
             @p_WCA_Date_Action,
             @p_WCA_Remark,
             @p_WCA_Is_Done
        )

    SET @p_WCA_ID_out = SCOPE_IDENTITY()

END

