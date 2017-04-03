if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepNGP_Attachment1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepNGP_Attachment1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WFinRepNGP_Attachment] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepNGP_Attachment1Add
    @p_WFRNGPAt_WFRCHNGP_ID int,
    @p_WFRNGPAt_Desc varchar(150),
    @p_WFRNGPAt_Doc image,
    @p_WFRNGPAt_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WFinRepNGP_Attachment]
        (
            [WFRNGPAt_WFRCHNGP_ID],
            [WFRNGPAt_Desc],
            [WFRNGPAt_Doc]
        )
    VALUES
        (
             @p_WFRNGPAt_WFRCHNGP_ID,
             @p_WFRNGPAt_Desc,
             @p_WFRNGPAt_Doc
        )

    SET @p_WFRNGPAt_ID_out = SCOPE_IDENTITY()

END

