if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_Step1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_Step1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WFinRep_Step] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_Step1Add
    @p_WFIN_S_WDT_ID int,
    @p_WFIN_S_ID_Next int,
    @p_WFIN_S_Step_Type varchar(20),
    @p_WFIN_S_Desc varchar(100),
    @p_WFIN_S_Approval_Needed smallint,
    @p_WFIN_S_C_ID smallint,
    @p_WFIN_S_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WFinRep_Step]
        (
            [WFIN_S_WDT_ID],
            [WFIN_S_ID_Next],
            [WFIN_S_Step_Type],
            [WFIN_S_Desc],
            [WFIN_S_Approval_Needed],
            [WFIN_S_C_ID]
        )
    VALUES
        (
             @p_WFIN_S_WDT_ID,
             @p_WFIN_S_ID_Next,
             @p_WFIN_S_Step_Type,
             @p_WFIN_S_Desc,
             @p_WFIN_S_Approval_Needed,
             @p_WFIN_S_C_ID
        )

    SET @p_WFIN_S_ID_out = SCOPE_IDENTITY()

END

