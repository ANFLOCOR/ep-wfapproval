if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_StepDetail1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_StepDetail1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WFinRep_StepDetail] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_StepDetail1Add
    @p_WFIN_SD_S_ID int,
    @p_WFIN_SD_W_U_ID int,
    @p_WFIN_SD_Desc varchar(50),
    @p_WFIN_SD_Status varchar(50),
    @p_WFIN_SD_Variable_Ref int,
    @p_WFIN_SD_Variable_SQL varchar(100),
    @p_WFIN_SD_Expire smallint,
    @p_WFIN_SD_W_U_ID_Delegate int,
    @p_WFIN_SD_Is_Escalate bit,
    @p_WFIN_SD_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WFinRep_StepDetail]
        (
            [WFIN_SD_S_ID],
            [WFIN_SD_W_U_ID],
            [WFIN_SD_Desc],
            [WFIN_SD_Status],
            [WFIN_SD_Variable_Ref],
            [WFIN_SD_Variable_SQL],
            [WFIN_SD_W_U_ID_Delegate]
        )
    VALUES
        (
             @p_WFIN_SD_S_ID,
             @p_WFIN_SD_W_U_ID,
             @p_WFIN_SD_Desc,
             @p_WFIN_SD_Status,
             @p_WFIN_SD_Variable_Ref,
             @p_WFIN_SD_Variable_SQL,
             @p_WFIN_SD_W_U_ID_Delegate
        )

    SET @p_WFIN_SD_ID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_WFIN_SD_Expire IS NOT NULL
        UPDATE [dbo].[WFinRep_StepDetail] SET [WFIN_SD_Expire] = @p_WFIN_SD_Expire WHERE [WFIN_SD_ID] = @p_WFIN_SD_ID_out

    IF @p_WFIN_SD_Is_Escalate IS NOT NULL
        UPDATE [dbo].[WFinRep_StepDetail] SET [WFIN_SD_Is_Escalate] = @p_WFIN_SD_Is_Escalate WHERE [WFIN_SD_ID] = @p_WFIN_SD_ID_out

END

