if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_Email1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_Email1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[W_Email] table.
CREATE PROCEDURE pePortalWFApprovalW_Email1Delete
        @pk_WE_ID int
AS
BEGIN
    DELETE [dbo].[W_Email]
    WHERE [WE_ID] = @pk_WE_ID
END

