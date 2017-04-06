if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WCAR_Activity_WCAR_DocAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WCAR_Activity_WCAR_DocAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_WCAR_Activity_WCAR_Doc] table.
CREATE PROCEDURE pePortalWFApprovalSel_WCAR_Activity_WCAR_DocAdd
    @p_WCA_ID int,
    @p_WCA_WS_ID int,
    @p_WCA_WSD_ID int,
    @p_WCA_WDT_ID int,
    @p_WCA_W_U_ID int,
    @p_WCA_WCD_ID int,
    @p_WCA_Status varchar(50),
    @p_WCA_Date_Assign smalldatetime,
    @p_WCA_Date_Action smalldatetime,
    @p_WCA_Remark varchar(250),
    @p_WCD_No varchar(50),
    @p_WCD_Project_Title varchar(max),
    @p_WCD_Exp_Total numeric(18,2),
    @p_WCA_Is_Done bit,
    @p_WCD_U_ID int,
    @p_WCD_Remark varchar(max),
    @p_WCD_WCur_ID smallint,
    @p_WCD_Request_Date smalldatetime,
    @p_WCD_C_ID smallint,
    @p_SSC_CompanyID smallint
AS
BEGIN
    INSERT
    INTO [dbo].[sel_WCAR_Activity_WCAR_Doc]
        (
            [WCA_ID],
            [WCA_WS_ID],
            [WCA_WSD_ID],
            [WCA_WDT_ID],
            [WCA_W_U_ID],
            [WCA_WCD_ID],
            [WCA_Status],
            [WCA_Date_Assign],
            [WCA_Date_Action],
            [WCA_Remark],
            [WCD_No],
            [WCD_Project_Title],
            [WCD_Exp_Total],
            [WCA_Is_Done],
            [WCD_U_ID],
            [WCD_Remark],
            [WCD_WCur_ID],
            [WCD_Request_Date],
            [WCD_C_ID],
            [SSC_CompanyID]
        )
    VALUES
        (
             @p_WCA_ID,
             @p_WCA_WS_ID,
             @p_WCA_WSD_ID,
             @p_WCA_WDT_ID,
             @p_WCA_W_U_ID,
             @p_WCA_WCD_ID,
             @p_WCA_Status,
             @p_WCA_Date_Assign,
             @p_WCA_Date_Action,
             @p_WCA_Remark,
             @p_WCD_No,
             @p_WCD_Project_Title,
             @p_WCD_Exp_Total,
             @p_WCA_Is_Done,
             @p_WCD_U_ID,
             @p_WCD_Remark,
             @p_WCD_WCur_ID,
             @p_WCD_Request_Date,
             @p_WCD_C_ID,
             @p_SSC_CompanyID
        )

END

