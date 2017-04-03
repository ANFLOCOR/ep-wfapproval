if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepNGP_HeadDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepNGP_HeadDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WFinRepNGP_Head] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepNGP_HeadDelete
        @pk_WFRCHNGP_ID int
AS
BEGIN
    DELETE [dbo].[WFinRepNGP_Head]
    WHERE [WFRCHNGP_ID] = @pk_WFRCHNGP_ID
END

