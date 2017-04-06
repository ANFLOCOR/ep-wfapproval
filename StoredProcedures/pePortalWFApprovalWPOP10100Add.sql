if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPOP10100Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPOP10100Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WPOP10100] table.
CREATE PROCEDURE pePortalWFApprovalWPOP10100Add
    @p_WPOP_DT_ID int,
    @p_WPOP_PONMBR nvarchar(17),
    @p_WPOP_Submit bit,
    @p_WPOP_Status int,
    @p_WPOP_C_ID int,
    @p_WPOP_U_ID int,
    @p_WPOP_Remark nvarchar(500),
    @p_WPOP_PRTCNT int,
    @p_WPOP_WCur_ID smallint,
    @p_WPOP_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WPOP10100]
        (
            [WPOP_DT_ID],
            [WPOP_PONMBR],
            [WPOP_Submit],
            [WPOP_Status],
            [WPOP_C_ID],
            [WPOP_U_ID],
            [WPOP_Remark],
            [WPOP_PRTCNT],
            [WPOP_WCur_ID]
        )
    VALUES
        (
             @p_WPOP_DT_ID,
             @p_WPOP_PONMBR,
             @p_WPOP_Submit,
             @p_WPOP_Status,
             @p_WPOP_C_ID,
             @p_WPOP_U_ID,
             @p_WPOP_Remark,
             @p_WPOP_PRTCNT,
             @p_WPOP_WCur_ID
        )

    SET @p_WPOP_ID_out = SCOPE_IDENTITY()

END

