if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepCon_HeadAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepCon_HeadAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WFinRepCon_Head] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepCon_HeadAdd
    @p_WFRCH_Year int,
    @p_WFRCH_Month int,
    @p_WFRCH_DT_ID int,
    @p_WFRCH_Code nvarchar(20),
    @p_WFRCH_Submit bit,
    @p_WFRCH_Status int,
    @p_WFRCH_C_ID int,
    @p_WFRCH_U_ID int,
    @p_WFRCH_Remark nvarchar(max),
    @p_WFRCH_PRTCNT int,
    @p_WFRCH_FinID int,
    @p_WFRCH_RptCount int,
    @p_WFRCH_Description varchar(250),
    @p_WFRCH_File image,
    @p_WFRCH_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WFinRepCon_Head]
        (
            [WFRCH_Year],
            [WFRCH_Month],
            [WFRCH_DT_ID],
            [WFRCH_Code],
            [WFRCH_Submit],
            [WFRCH_Status],
            [WFRCH_C_ID],
            [WFRCH_U_ID],
            [WFRCH_Remark],
            [WFRCH_PRTCNT],
            [WFRCH_FinID],
            [WFRCH_RptCount],
            [WFRCH_Description],
            [WFRCH_File]
        )
    VALUES
        (
             @p_WFRCH_Year,
             @p_WFRCH_Month,
             @p_WFRCH_DT_ID,
             @p_WFRCH_Code,
             @p_WFRCH_Submit,
             @p_WFRCH_Status,
             @p_WFRCH_C_ID,
             @p_WFRCH_U_ID,
             @p_WFRCH_Remark,
             @p_WFRCH_PRTCNT,
             @p_WFRCH_FinID,
             @p_WFRCH_RptCount,
             @p_WFRCH_Description,
             @p_WFRCH_File
        )

    SET @p_WFRCH_ID_out = SCOPE_IDENTITY()

END

