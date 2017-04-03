if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepNGP_Attachment1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepNGP_Attachment1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WFinRepNGP_Attachment] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepNGP_Attachment1Delete
        @pk_WFRNGPAt_ID int
AS
BEGIN
    DELETE [dbo].[WFinRepNGP_Attachment]
    WHERE [WFRNGPAt_ID] = @pk_WFRNGPAt_ID
END

