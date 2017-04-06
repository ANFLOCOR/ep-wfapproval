if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WCAR_Doc_Creator_Approver1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WCAR_Doc_Creator_Approver1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_WCAR_Doc_Creator_Approver] table.
CREATE PROCEDURE pePortalWFApprovalSel_WCAR_Doc_Creator_Approver1Add
    @p_WCD_ID int,
    @p_WCD_WDT_ID int,
    @p_WCD_No varchar(50),
    @p_WCD_Submit bit,
    @p_WCD_Status varchar(50),
    @p_WCD_Remark varchar(250),
    @p_WCD_Unit_Location varchar(50),
    @p_WCD_Project_Title varchar(max),
    @p_WCD_Project_No varchar(50),
    @p_WCD_Request_Date smalldatetime,
    @p_WCD_Proj_Inc_ACB bit,
    @p_WCD_Exp_Total numeric(18,2),
    @p_WCD_Exp_Prev_Total numeric(18,2),
    @p_WCD_Exp_Budget numeric(18,2),
    @p_WCD_Exp_Under_Over_Budget numeric(18,2),
    @p_WCD_Exp_Cur_Yr numeric(18,2),
    @p_WCD_Exp_Nxt_Yr numeric(18,2),
    @p_WCD_Exp_Sub_Yr numeric(18,2),
    @p_WCD_C_ID smallint,
    @p_WCD_U_ID int,
    @p_WCD_Created smalldatetime,
    @p_WCD_WCur_ID smallint,
    @p_WCD_Supplementary bit,
    @p_WCD_Supplementary_WCD_ID int,
    @p_WCD_Supplementary_Manual varchar(50),
    @p_User_ID int,
    @p_Row bigint
AS
BEGIN
    INSERT
    INTO [dbo].[sel_WCAR_Doc_Creator_Approver]
        (
            [WCD_ID],
            [WCD_WDT_ID],
            [WCD_No],
            [WCD_Submit],
            [WCD_Status],
            [WCD_Remark],
            [WCD_Unit_Location],
            [WCD_Project_Title],
            [WCD_Project_No],
            [WCD_Request_Date],
            [WCD_Proj_Inc_ACB],
            [WCD_Exp_Total],
            [WCD_Exp_Prev_Total],
            [WCD_Exp_Budget],
            [WCD_Exp_Under_Over_Budget],
            [WCD_Exp_Cur_Yr],
            [WCD_Exp_Nxt_Yr],
            [WCD_Exp_Sub_Yr],
            [WCD_C_ID],
            [WCD_U_ID],
            [WCD_Created],
            [WCD_WCur_ID],
            [WCD_Supplementary],
            [WCD_Supplementary_WCD_ID],
            [WCD_Supplementary_Manual],
            [User_ID],
            [Row]
        )
    VALUES
        (
             @p_WCD_ID,
             @p_WCD_WDT_ID,
             @p_WCD_No,
             @p_WCD_Submit,
             @p_WCD_Status,
             @p_WCD_Remark,
             @p_WCD_Unit_Location,
             @p_WCD_Project_Title,
             @p_WCD_Project_No,
             @p_WCD_Request_Date,
             @p_WCD_Proj_Inc_ACB,
             @p_WCD_Exp_Total,
             @p_WCD_Exp_Prev_Total,
             @p_WCD_Exp_Budget,
             @p_WCD_Exp_Under_Over_Budget,
             @p_WCD_Exp_Cur_Yr,
             @p_WCD_Exp_Nxt_Yr,
             @p_WCD_Exp_Sub_Yr,
             @p_WCD_C_ID,
             @p_WCD_U_ID,
             @p_WCD_Created,
             @p_WCD_WCur_ID,
             @p_WCD_Supplementary,
             @p_WCD_Supplementary_WCD_ID,
             @p_WCD_Supplementary_Manual,
             @p_User_ID,
             @p_Row
        )

END

