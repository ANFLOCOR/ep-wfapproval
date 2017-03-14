if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCAR_Doc_AttachAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCAR_Doc_AttachAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WCAR_Doc_Attach] table.
CREATE PROCEDURE pePortalWFApprovalWCAR_Doc_AttachAdd
    @p_WCDA_WCD_ID int,
    @p_WCDA_Desc varchar(50),
    @p_WCDA_File image,
    @p_WCDA_WAT_ID smallint,
    @p_WCDA_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WCAR_Doc_Attach]
        (
            [WCDA_WCD_ID],
            [WCDA_Desc],
            [WCDA_File],
            [WCDA_WAT_ID]
        )
    VALUES
        (
             @p_WCDA_WCD_ID,
             @p_WCDA_Desc,
             @p_WCDA_File,
             @p_WCDA_WAT_ID
        )

    SET @p_WCDA_ID_out = SCOPE_IDENTITY()

END

