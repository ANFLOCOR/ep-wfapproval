if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_Activity1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_Activity1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WPR_Activity] table.
CREATE PROCEDURE pePortalWFApprovalWPR_Activity1Add
    @p_WPRA_WS_ID int,
    @p_WPRA_WSD_ID int,
    @p_WPRA_WDT_ID int,
    @p_WPRA_W_U_ID int,
    @p_WPRA_W_U_ID_Delegate int,
    @p_WPRA_WPRD_ID int,
    @p_WPRA_Status varchar(50),
    @p_WPRA_Date_Assign smalldatetime,
    @p_WPRA_Date_Action smalldatetime,
    @p_WPRA_Remark varchar(250),
    @p_WPRA_Is_Done bit,
    @p_WPRA_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WPR_Activity]
        (
            [WPRA_WS_ID],
            [WPRA_WSD_ID],
            [WPRA_WDT_ID],
            [WPRA_W_U_ID],
            [WPRA_W_U_ID_Delegate],
            [WPRA_WPRD_ID],
            [WPRA_Status],
            [WPRA_Date_Assign],
            [WPRA_Date_Action],
            [WPRA_Remark],
            [WPRA_Is_Done]
        )
    VALUES
        (
             @p_WPRA_WS_ID,
             @p_WPRA_WSD_ID,
             @p_WPRA_WDT_ID,
             @p_WPRA_W_U_ID,
             @p_WPRA_W_U_ID_Delegate,
             @p_WPRA_WPRD_ID,
             @p_WPRA_Status,
             @p_WPRA_Date_Assign,
             @p_WPRA_Date_Action,
             @p_WPRA_Remark,
             @p_WPRA_Is_Done
        )

    SET @p_WPRA_ID_out = SCOPE_IDENTITY()

END

