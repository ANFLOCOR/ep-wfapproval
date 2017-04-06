if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_Step_StepDetail1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_Step_StepDetail1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WFinRep_Step_StepDetail] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_Step_StepDetail1Add
    @p_WFIN_S_ID int,
    @p_WFIN_S_WDT_ID int,
    @p_WFIN_S_ID_Next int,
    @p_WFIN_S_Step_Type varchar(20),
    @p_WFIN_S_Approval_Needed smallint,
    @p_WFIN_SD_ID int,
    @p_WFIN_SD_W_U_ID int,
    @p_W_U_Full_Name varchar(125)
AS
BEGIN
    INSERT
    INTO [dbo].[WFinRep_Step_StepDetail]
        (
            [WFIN_S_ID],
            [WFIN_S_WDT_ID],
            [WFIN_S_ID_Next],
            [WFIN_S_Step_Type],
            [WFIN_S_Approval_Needed],
            [WFIN_SD_ID],
            [WFIN_SD_W_U_ID],
            [W_U_Full_Name]
        )
    VALUES
        (
             @p_WFIN_S_ID,
             @p_WFIN_S_WDT_ID,
             @p_WFIN_S_ID_Next,
             @p_WFIN_S_Step_Type,
             @p_WFIN_S_Approval_Needed,
             @p_WFIN_SD_ID,
             @p_WFIN_SD_W_U_ID,
             @p_W_U_Full_Name
        )

END

