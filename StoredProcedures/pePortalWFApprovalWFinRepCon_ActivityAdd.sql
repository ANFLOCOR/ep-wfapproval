if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepCon_ActivityAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepCon_ActivityAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WFinRepCon_Activity] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepCon_ActivityAdd
    @p_WFRCA_WS_ID int,
    @p_WFRCA_WSD_ID int,
    @p_WFRCA_WDT_ID int,
    @p_WFRCA_W_U_ID int,
    @p_WFRCA_W_U_ID_Delegate int,
    @p_WFRCA_Status int,
    @p_WFRCA_Date_Assign smalldatetime,
    @p_WFRCA_Date_Action smalldatetime,
    @p_WFRCA_Remark nvarchar(500),
    @p_WFRCA_Is_Done bit,
    @p_WFRCA_Code nvarchar(20),
    @p_WFRCA_FinID int,
    @p_WFRCA_WFRCH_ID int,
    @p_WFRCA_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WFinRepCon_Activity]
        (
            [WFRCA_WS_ID],
            [WFRCA_WSD_ID],
            [WFRCA_WDT_ID],
            [WFRCA_W_U_ID],
            [WFRCA_W_U_ID_Delegate],
            [WFRCA_Status],
            [WFRCA_Date_Assign],
            [WFRCA_Date_Action],
            [WFRCA_Remark],
            [WFRCA_Is_Done],
            [WFRCA_Code],
            [WFRCA_FinID],
            [WFRCA_WFRCH_ID]
        )
    VALUES
        (
             @p_WFRCA_WS_ID,
             @p_WFRCA_WSD_ID,
             @p_WFRCA_WDT_ID,
             @p_WFRCA_W_U_ID,
             @p_WFRCA_W_U_ID_Delegate,
             @p_WFRCA_Status,
             @p_WFRCA_Date_Assign,
             @p_WFRCA_Date_Action,
             @p_WFRCA_Remark,
             @p_WFRCA_Is_Done,
             @p_WFRCA_Code,
             @p_WFRCA_FinID,
             @p_WFRCA_WFRCH_ID
        )

    SET @p_WFRCA_ID_out = SCOPE_IDENTITY()

END

