if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCAR_Doc_CheckerDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCAR_Doc_CheckerDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WCAR_Doc_Checker] table.
CREATE PROCEDURE pePortalWFApprovalWCAR_Doc_CheckerDelete
        @pk_WCDC_ID int
AS
BEGIN
    DELETE [dbo].[WCAR_Doc_Checker]
    WHERE [WCDC_ID] = @pk_WCDC_ID
END

