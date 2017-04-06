if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepNGP_DocAttach1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepNGP_DocAttach1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WFinRepNGP_DocAttach] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepNGP_DocAttach1Delete
        @pk_WFRCDNGP_ID int
AS
BEGIN
    DELETE [dbo].[WFinRepNGP_DocAttach]
    WHERE [WFRCDNGP_ID] = @pk_WFRCDNGP_ID
END

