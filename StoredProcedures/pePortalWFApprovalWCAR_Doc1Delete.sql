if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCAR_Doc1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCAR_Doc1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WCAR_Doc] table.
CREATE PROCEDURE pePortalWFApprovalWCAR_Doc1Delete
        @pk_WCD_ID int
AS
BEGIN
    DELETE [dbo].[WCAR_Doc]
    WHERE [WCD_ID] = @pk_WCD_ID
END

