if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_HeadAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_HeadAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WFinRep_Head] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_HeadAdd
    @p_HFIN_Year int,
    @p_HFIN_Month int,
    @p_HFIN_DT_ID int,
    @p_HFIN_Code nvarchar(20),
    @p_HFIN_Submit bit,
    @p_HFIN_Status int,
    @p_HFIN_C_ID int,
    @p_HFIN_U_ID int,
    @p_HFIN_Remark nvarchar(max),
    @p_HFIN_PRTCNT int,
    @p_HFIN_FinID int,
    @p_HFIN_RptCount int,
    @p_HFIN_Description varchar(250),
    @p_HFIN_File image,
    @p_HFIN_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WFinRep_Head]
        (
            [HFIN_Year],
            [HFIN_Month],
            [HFIN_DT_ID],
            [HFIN_Code],
            [HFIN_Submit],
            [HFIN_C_ID],
            [HFIN_U_ID],
            [HFIN_Remark],
            [HFIN_PRTCNT],
            [HFIN_FinID],
            [HFIN_RptCount],
            [HFIN_Description],
            [HFIN_File]
        )
    VALUES
        (
             @p_HFIN_Year,
             @p_HFIN_Month,
             @p_HFIN_DT_ID,
             @p_HFIN_Code,
             @p_HFIN_Submit,
             @p_HFIN_C_ID,
             @p_HFIN_U_ID,
             @p_HFIN_Remark,
             @p_HFIN_PRTCNT,
             @p_HFIN_FinID,
             @p_HFIN_RptCount,
             @p_HFIN_Description,
             @p_HFIN_File
        )

    SET @p_HFIN_ID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_HFIN_Status IS NOT NULL
        UPDATE [dbo].[WFinRep_Head] SET [HFIN_Status] = @p_HFIN_Status WHERE [HFIN_ID] = @p_HFIN_ID_out

END

