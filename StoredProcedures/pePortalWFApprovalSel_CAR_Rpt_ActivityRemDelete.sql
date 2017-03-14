if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_CAR_Rpt_ActivityRemDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_CAR_Rpt_ActivityRemDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_CAR_Rpt_ActivityRem] table.
CREATE PROCEDURE pePortalWFApprovalSel_CAR_Rpt_ActivityRemDelete
        @pk_WCA_ID int
AS
BEGIN
    DELETE [dbo].[sel_CAR_Rpt_ActivityRem]
    WHERE [WCA_ID] = @pk_WCA_ID
END

