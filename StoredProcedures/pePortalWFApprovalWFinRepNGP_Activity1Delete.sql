if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepNGP_Activity1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepNGP_Activity1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WFinRepNGP_Activity] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepNGP_Activity1Delete
        @pk_WFRNGPA_ID int
AS
BEGIN
    DELETE [dbo].[WFinRepNGP_Activity]
    WHERE [WFRNGPA_ID] = @pk_WFRNGPA_ID
END

