if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_Step_Detail1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_Step_Detail1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WPO_Step_Detail] table.
CREATE PROCEDURE pePortalWFApprovalWPO_Step_Detail1Delete
        @pk_WPO_SD_ID int
AS
BEGIN
    DELETE [dbo].[WPO_Step_Detail]
    WHERE [WPO_SD_ID] = @pk_WPO_SD_ID
END

