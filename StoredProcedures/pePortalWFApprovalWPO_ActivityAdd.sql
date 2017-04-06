if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_ActivityAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_ActivityAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WPO_Activity] table.
CREATE PROCEDURE pePortalWFApprovalWPO_ActivityAdd
    @p_WPO_WS_ID int,
    @p_WPO_WSD_ID int,
    @p_WPO_WDT_ID int,
    @p_WPO_W_U_ID int,
    @p_WPO_W_U_ID_Delegate int,
    @p_WPO_Status int,
    @p_WPO_Date_Assign smalldatetime,
    @p_WPO_Date_Action smalldatetime,
    @p_WPO_Remark nvarchar(500),
    @p_WPO_Is_Done bit,
    @p_WPO_PONum nvarchar(20),
    @p_WPO_Is_InclPrint bit,
    @p_WPO_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WPO_Activity]
        (
            [WPO_WS_ID],
            [WPO_WSD_ID],
            [WPO_WDT_ID],
            [WPO_W_U_ID],
            [WPO_W_U_ID_Delegate],
            [WPO_Status],
            [WPO_Date_Assign],
            [WPO_Date_Action],
            [WPO_Remark],
            [WPO_Is_Done],
            [WPO_PONum]
        )
    VALUES
        (
             @p_WPO_WS_ID,
             @p_WPO_WSD_ID,
             @p_WPO_WDT_ID,
             @p_WPO_W_U_ID,
             @p_WPO_W_U_ID_Delegate,
             @p_WPO_Status,
             @p_WPO_Date_Assign,
             @p_WPO_Date_Action,
             @p_WPO_Remark,
             @p_WPO_Is_Done,
             @p_WPO_PONum
        )

    SET @p_WPO_ID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_WPO_Is_InclPrint IS NOT NULL
        UPDATE [dbo].[WPO_Activity] SET [WPO_Is_InclPrint] = @p_WPO_Is_InclPrint WHERE [WPO_ID] = @p_WPO_ID_out

END

