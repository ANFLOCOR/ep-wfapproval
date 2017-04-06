if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCAR_Minimum1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCAR_Minimum1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WCAR_Minimum] table.
CREATE PROCEDURE pePortalWFApprovalWCAR_Minimum1Delete
        @pk_WCM_ID smallint
AS
BEGIN
    DELETE [dbo].[WCAR_Minimum]
    WHERE [WCM_ID] = @pk_WCM_ID
END

