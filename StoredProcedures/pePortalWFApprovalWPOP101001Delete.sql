if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPOP101001Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPOP101001Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WPOP10100] table.
CREATE PROCEDURE pePortalWFApprovalWPOP101001Delete
        @pk_WPOP_ID int
AS
BEGIN
    DELETE [dbo].[WPOP10100]
    WHERE [WPOP_ID] = @pk_WPOP_ID
END

