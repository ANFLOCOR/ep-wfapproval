if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_Email_Default1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_Email_Default1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[W_Email_Default] table.
CREATE PROCEDURE pePortalWFApprovalW_Email_Default1Delete
        @pk_WED_ID int
AS
BEGIN
    DELETE [dbo].[W_Email_Default]
    WHERE [WED_ID] = @pk_WED_ID
END

