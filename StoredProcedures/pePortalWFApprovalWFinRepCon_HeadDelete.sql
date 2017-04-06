if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepCon_HeadDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepCon_HeadDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WFinRepCon_Head] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepCon_HeadDelete
        @pk_WFRCH_ID int
AS
BEGIN
    DELETE [dbo].[WFinRepCon_Head]
    WHERE [WFRCH_ID] = @pk_WFRCH_ID
END

