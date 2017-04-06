if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_LineDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_LineDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WPR_Line] table.
CREATE PROCEDURE pePortalWFApprovalWPR_LineDelete
        @pk_WPRL_ID int
AS
BEGIN
    DELETE [dbo].[WPR_Line]
    WHERE [WPRL_ID] = @pk_WPRL_ID
END

