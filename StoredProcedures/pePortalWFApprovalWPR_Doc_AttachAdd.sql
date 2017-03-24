if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_Doc_AttachAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_Doc_AttachAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WPR_Doc_Attach] table.
CREATE PROCEDURE pePortalWFApprovalWPR_Doc_AttachAdd
    @p_WPRDA_WPRD_ID int,
    @p_WPRDA_Desc varchar(50),
    @p_WPRDA_File image,
    @p_WPRDA_WAT_ID smallint,
    @p_WPRDA_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WPR_Doc_Attach]
        (
            [WPRDA_WPRD_ID],
            [WPRDA_Desc],
            [WPRDA_File],
            [WPRDA_WAT_ID]
        )
    VALUES
        (
             @p_WPRDA_WPRD_ID,
             @p_WPRDA_Desc,
             @p_WPRDA_File,
             @p_WPRDA_WAT_ID
        )

    SET @p_WPRDA_ID_out = SCOPE_IDENTITY()

END

