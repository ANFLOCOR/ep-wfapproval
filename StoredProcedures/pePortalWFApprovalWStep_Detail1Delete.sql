if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWStep_Detail1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWStep_Detail1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WStep_Detail] table.
CREATE PROCEDURE pePortalWFApprovalWStep_Detail1Delete
        @pk_WSD_ID int
AS
BEGIN
    DELETE [dbo].[WStep_Detail]
    WHERE [WSD_ID] = @pk_WSD_ID
END

