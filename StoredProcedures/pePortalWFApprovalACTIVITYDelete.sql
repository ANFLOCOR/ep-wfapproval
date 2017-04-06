if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalACTIVITYDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalACTIVITYDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[ACTIVITY] table.
CREATE PROCEDURE pePortalWFApprovalACTIVITYDelete
        @pk_USERID char(15),
    @pk_CMPNYNAM char(65)
AS
BEGIN
    DELETE [dbo].[ACTIVITY]
    WHERE [USERID] = @pk_USERID
    AND [CMPNYNAM] = @pk_CMPNYNAM
END

