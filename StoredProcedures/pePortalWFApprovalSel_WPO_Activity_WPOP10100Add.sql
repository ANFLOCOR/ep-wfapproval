if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WPO_Activity_WPOP10100Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WPO_Activity_WPOP10100Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_WPO_Activity_WPOP10100] table.
CREATE PROCEDURE pePortalWFApprovalSel_WPO_Activity_WPOP10100Add
    @p_WPO_ID int,
    @p_WPO_WS_ID int,
    @p_WPO_WSD_ID int,
    @p_WPO_WDT_ID int,
    @p_WPO_Status int,
    @p_WPO_Date_Assign smalldatetime,
    @p_WPO_Date_Action smalldatetime,
    @p_WPO_Remark nvarchar(500),
    @p_WPO_Is_Done bit,
    @p_WPO_PONum nvarchar(20),
    @p_WPOP_U_ID int,
    @p_WPOP_C_ID int,
    @p_WPO_W_U_ID int,
    @p_TOTAL numeric(15,2),
    @p_WPO_W_U_ID_Delegate int
AS
BEGIN
    INSERT
    INTO [dbo].[sel_WPO_Activity_WPOP10100]
        (
            [WPO_ID],
            [WPO_WS_ID],
            [WPO_WSD_ID],
            [WPO_WDT_ID],
            [WPO_Status],
            [WPO_Date_Assign],
            [WPO_Date_Action],
            [WPO_Remark],
            [WPO_Is_Done],
            [WPO_PONum],
            [WPOP_U_ID],
            [WPOP_C_ID],
            [WPO_W_U_ID],
            [TOTAL],
            [WPO_W_U_ID_Delegate]
        )
    VALUES
        (
             @p_WPO_ID,
             @p_WPO_WS_ID,
             @p_WPO_WSD_ID,
             @p_WPO_WDT_ID,
             @p_WPO_Status,
             @p_WPO_Date_Assign,
             @p_WPO_Date_Action,
             @p_WPO_Remark,
             @p_WPO_Is_Done,
             @p_WPO_PONum,
             @p_WPOP_U_ID,
             @p_WPOP_C_ID,
             @p_WPO_W_U_ID,
             @p_TOTAL,
             @p_WPO_W_U_ID_Delegate
        )

END

