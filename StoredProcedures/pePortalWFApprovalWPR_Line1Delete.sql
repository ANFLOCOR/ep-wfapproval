if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_Line1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_Line1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WPR_Line] table.
CREATE PROCEDURE pePortalWFApprovalWPR_Line1Delete
        @pk_WPRL_ID int
AS
BEGIN
    DELETE [dbo].[WPR_Line]
    WHERE [WPRL_ID] = @pk_WPRL_ID
END

