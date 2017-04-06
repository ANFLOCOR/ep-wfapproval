if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepNGP_HeadAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepNGP_HeadAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WFinRepNGP_Head] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepNGP_HeadAdd
    @p_WFRCHNGP_Year int,
    @p_WFRCHNGP_Month int,
    @p_WFRCHNGP_DT_ID int,
    @p_WFRCHNGP_Code nvarchar(20),
    @p_WFRCHNGP_Submit bit,
    @p_WFRCHNGP_Status int,
    @p_WFRCHNGP_C_ID int,
    @p_WFRCHNGP_U_ID int,
    @p_WFRCHNGP_Remark nvarchar(max),
    @p_WFRCHNGP_PRTCNT int,
    @p_WFRCHNGP_FinID int,
    @p_WFRCHNGP_RptCount int,
    @p_WFRCHNGP_Description varchar(250),
    @p_WFRCHNGP_File image,
    @p_WFRCHNGP_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WFinRepNGP_Head]
        (
            [WFRCHNGP_Year],
            [WFRCHNGP_Month],
            [WFRCHNGP_DT_ID],
            [WFRCHNGP_Code],
            [WFRCHNGP_Submit],
            [WFRCHNGP_Status],
            [WFRCHNGP_C_ID],
            [WFRCHNGP_U_ID],
            [WFRCHNGP_Remark],
            [WFRCHNGP_PRTCNT],
            [WFRCHNGP_FinID],
            [WFRCHNGP_RptCount],
            [WFRCHNGP_Description],
            [WFRCHNGP_File]
        )
    VALUES
        (
             @p_WFRCHNGP_Year,
             @p_WFRCHNGP_Month,
             @p_WFRCHNGP_DT_ID,
             @p_WFRCHNGP_Code,
             @p_WFRCHNGP_Submit,
             @p_WFRCHNGP_Status,
             @p_WFRCHNGP_C_ID,
             @p_WFRCHNGP_U_ID,
             @p_WFRCHNGP_Remark,
             @p_WFRCHNGP_PRTCNT,
             @p_WFRCHNGP_FinID,
             @p_WFRCHNGP_RptCount,
             @p_WFRCHNGP_Description,
             @p_WFRCHNGP_File
        )

    SET @p_WFRCHNGP_ID_out = SCOPE_IDENTITY()

END

