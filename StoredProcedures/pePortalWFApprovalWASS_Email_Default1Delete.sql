if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWASS_Email_Default1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWASS_Email_Default1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WASS_Email_Default] table.
CREATE PROCEDURE pePortalWFApprovalWASS_Email_Default1Delete
        @pk_WED_ID int
AS
BEGIN
    DELETE [dbo].[WASS_Email_Default]
    WHERE [WED_ID] = @pk_WED_ID
END

