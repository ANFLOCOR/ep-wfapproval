if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_Line_Status1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_Line_Status1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WPR_Line_Status] table.
CREATE PROCEDURE pePortalWFApprovalWPR_Line_Status1Delete
        @pk_WPRLS_ID smallint
AS
BEGIN
    DELETE [dbo].[WPR_Line_Status]
    WHERE [WPRLS_ID] = @pk_WPRLS_ID
END

