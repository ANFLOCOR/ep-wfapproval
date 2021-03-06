﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_WFHistory_Details_new1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_WFHistory_Details_new1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WPO_WFHistory_Details_new] table.
CREATE PROCEDURE pePortalWFApprovalWPO_WFHistory_Details_new1Add
    @p_WPO_ID int,
    @p_WPO_W_U_ID int,
    @p_WPO_WS_ID int,
    @p_WPO_Status int,
    @p_WPO_Date_Assign smalldatetime,
    @p_WPO_Date_Action smalldatetime,
    @p_WPO_Remark nvarchar(500),
    @p_WPO_PONum nvarchar(20),
    @p_WPOP_C_ID int,
    @p_WPOP_ID int
AS
BEGIN
    INSERT
    INTO [dbo].[WPO_WFHistory_Details_new]
        (
            [WPO_ID],
            [WPO_W_U_ID],
            [WPO_WS_ID],
            [WPO_Status],
            [WPO_Date_Assign],
            [WPO_Date_Action],
            [WPO_Remark],
            [WPO_PONum],
            [WPOP_C_ID],
            [WPOP_ID]
        )
    VALUES
        (
             @p_WPO_ID,
             @p_WPO_W_U_ID,
             @p_WPO_WS_ID,
             @p_WPO_Status,
             @p_WPO_Date_Assign,
             @p_WPO_Date_Action,
             @p_WPO_Remark,
             @p_WPO_PONum,
             @p_WPOP_C_ID,
             @p_WPOP_ID
        )

END

