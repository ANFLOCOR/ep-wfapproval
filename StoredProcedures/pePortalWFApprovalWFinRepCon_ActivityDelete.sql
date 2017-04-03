if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepCon_ActivityDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepCon_ActivityDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WFinRepCon_Activity] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepCon_ActivityDelete
        @pk_WFRCA_ID int
AS
BEGIN
    DELETE [dbo].[WFinRepCon_Activity]
    WHERE [WFRCA_ID] = @pk_WFRCA_ID
END

