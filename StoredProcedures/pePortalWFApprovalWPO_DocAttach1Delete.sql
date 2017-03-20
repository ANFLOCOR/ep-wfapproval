if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_DocAttach1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_DocAttach1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WPO_DocAttach] table.
CREATE PROCEDURE pePortalWFApprovalWPO_DocAttach1Delete
        @pk_WPODA_ID int
AS
BEGIN
    DELETE [dbo].[WPO_DocAttach]
    WHERE [WPODA_ID] = @pk_WPODA_ID
END

