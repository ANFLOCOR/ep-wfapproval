if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCAR_Activity1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCAR_Activity1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WCAR_Activity] table.
CREATE PROCEDURE pePortalWFApprovalWCAR_Activity1Delete
        @pk_WCA_ID int
AS
BEGIN
    DELETE [dbo].[WCAR_Activity]
    WHERE [WCA_ID] = @pk_WCA_ID
END

