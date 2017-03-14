if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysPages1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysPages1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[SysPages] table.
CREATE PROCEDURE pePortalWFApprovalSysPages1Delete
        @pk_PageID int
AS
BEGIN
    DELETE [dbo].[SysPages]
    WHERE [PageID] = @pk_PageID
END

