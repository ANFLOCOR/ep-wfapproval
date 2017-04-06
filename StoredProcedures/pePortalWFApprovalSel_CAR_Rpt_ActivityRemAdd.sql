if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_CAR_Rpt_ActivityRemAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_CAR_Rpt_ActivityRemAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_CAR_Rpt_ActivityRem] table.
CREATE PROCEDURE pePortalWFApprovalSel_CAR_Rpt_ActivityRemAdd
    @p_WCD_No varchar(50),
    @p_WCD_C_ID smallint,
    @p_WCA_Remark varchar(250),
    @p_WCA_ID int,
    @p_WCA_Status varchar(50)
AS
BEGIN
    INSERT
    INTO [dbo].[sel_CAR_Rpt_ActivityRem]
        (
            [WCD_No],
            [WCD_C_ID],
            [WCA_Remark],
            [WCA_ID],
            [WCA_Status]
        )
    VALUES
        (
             @p_WCD_No,
             @p_WCD_C_ID,
             @p_WCA_Remark,
             @p_WCA_ID,
             @p_WCA_Status
        )

END

