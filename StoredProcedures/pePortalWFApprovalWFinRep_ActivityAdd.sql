if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_ActivityAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_ActivityAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WFinRep_Activity] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_ActivityAdd
    @p_AFIN_WS_ID int,
    @p_AFIN_WSD_ID int,
    @p_AFIN_WDT_ID int,
    @p_AFIN_W_U_ID int,
    @p_AFIN_W_U_ID_Delegate int,
    @p_AFIN_Status int,
    @p_AFIN_Date_Assign smalldatetime,
    @p_AFIN_Date_Action smalldatetime,
    @p_AFIN_Remark nvarchar(500),
    @p_AFIN_Is_Done bit,
    @p_AFIN_Code nvarchar(20),
    @p_AFIN_FinID int,
    @p_AFIN_HFIN_ID int,
    @p_AFIN_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WFinRep_Activity]
        (
            [AFIN_WS_ID],
            [AFIN_WSD_ID],
            [AFIN_WDT_ID],
            [AFIN_W_U_ID],
            [AFIN_W_U_ID_Delegate],
            [AFIN_Status],
            [AFIN_Date_Assign],
            [AFIN_Date_Action],
            [AFIN_Remark],
            [AFIN_Is_Done],
            [AFIN_Code],
            [AFIN_FinID],
            [AFIN_HFIN_ID]
        )
    VALUES
        (
             @p_AFIN_WS_ID,
             @p_AFIN_WSD_ID,
             @p_AFIN_WDT_ID,
             @p_AFIN_W_U_ID,
             @p_AFIN_W_U_ID_Delegate,
             @p_AFIN_Status,
             @p_AFIN_Date_Assign,
             @p_AFIN_Date_Action,
             @p_AFIN_Remark,
             @p_AFIN_Is_Done,
             @p_AFIN_Code,
             @p_AFIN_FinID,
             @p_AFIN_HFIN_ID
        )

    SET @p_AFIN_ID_out = SCOPE_IDENTITY()

END

