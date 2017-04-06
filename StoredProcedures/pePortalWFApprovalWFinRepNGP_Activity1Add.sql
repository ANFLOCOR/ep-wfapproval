if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepNGP_Activity1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepNGP_Activity1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WFinRepNGP_Activity] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepNGP_Activity1Add
    @p_WFRNGPA_WS_ID int,
    @p_WFRNGPA_WSD_ID int,
    @p_WFRNGPA_WDT_ID int,
    @p_WFRNGPA_W_U_ID int,
    @p_WFRNGPA_W_U_ID_Delegate int,
    @p_WFRNGPA_Status int,
    @p_WFRNGPA_Date_Assign smalldatetime,
    @p_WFRNGPA_Date_Action smalldatetime,
    @p_WFRNGPA_Remark nvarchar(500),
    @p_WFRNGPA_Is_Done bit,
    @p_WFRNGPA_Code nvarchar(20),
    @p_WFRNGPA_FinID int,
    @p_WFRNGPA_WFRCHNGP_ID int,
    @p_WFRNGPA_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WFinRepNGP_Activity]
        (
            [WFRNGPA_WS_ID],
            [WFRNGPA_WSD_ID],
            [WFRNGPA_WDT_ID],
            [WFRNGPA_W_U_ID],
            [WFRNGPA_W_U_ID_Delegate],
            [WFRNGPA_Status],
            [WFRNGPA_Date_Assign],
            [WFRNGPA_Date_Action],
            [WFRNGPA_Remark],
            [WFRNGPA_Is_Done],
            [WFRNGPA_Code],
            [WFRNGPA_FinID],
            [WFRNGPA_WFRCHNGP_ID]
        )
    VALUES
        (
             @p_WFRNGPA_WS_ID,
             @p_WFRNGPA_WSD_ID,
             @p_WFRNGPA_WDT_ID,
             @p_WFRNGPA_W_U_ID,
             @p_WFRNGPA_W_U_ID_Delegate,
             @p_WFRNGPA_Status,
             @p_WFRNGPA_Date_Assign,
             @p_WFRNGPA_Date_Action,
             @p_WFRNGPA_Remark,
             @p_WFRNGPA_Is_Done,
             @p_WFRNGPA_Code,
             @p_WFRNGPA_FinID,
             @p_WFRNGPA_WFRCHNGP_ID
        )

    SET @p_WFRNGPA_ID_out = SCOPE_IDENTITY()

END

