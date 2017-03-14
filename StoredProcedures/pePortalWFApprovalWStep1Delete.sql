if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWStep1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWStep1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WStep] table.
CREATE PROCEDURE pePortalWFApprovalWStep1Delete
        @pk_WS_ID int
AS
BEGIN
    DELETE [dbo].[WStep]
    WHERE [WS_ID] = @pk_WS_ID
END

