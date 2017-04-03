if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_Attachment1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_Attachment1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WFinRep_Attachment] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_Attachment1Add
    @p_WFRA_FIN_ID int,
    @p_WFRA_Desc varchar(150),
    @p_WFRA_Doc image,
    @p_WFRA_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WFinRep_Attachment]
        (
            [WFRA_FIN_ID],
            [WFRA_Desc],
            [WFRA_Doc]
        )
    VALUES
        (
             @p_WFRA_FIN_ID,
             @p_WFRA_Desc,
             @p_WFRA_Doc
        )

    SET @p_WFRA_ID_out = SCOPE_IDENTITY()

END

