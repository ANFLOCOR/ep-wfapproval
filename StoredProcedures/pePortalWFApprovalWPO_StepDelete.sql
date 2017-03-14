if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_StepDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_StepDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WPO_Step] table.
CREATE PROCEDURE pePortalWFApprovalWPO_StepDelete
        @pk_WPO_S_ID int
AS
BEGIN
    DELETE [dbo].[WPO_Step]
    WHERE [WPO_S_ID] = @pk_WPO_S_ID
END

