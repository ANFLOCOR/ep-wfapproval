if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalCF_AdjustingEntryDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalCF_AdjustingEntryDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[CF_AdjustingEntry] table.
CREATE PROCEDURE pePortalWFApprovalCF_AdjustingEntryDelete
        @pk_AdjustID int
AS
BEGIN
    DELETE [dbo].[CF_AdjustingEntry]
    WHERE [AdjustID] = @pk_AdjustID
END

