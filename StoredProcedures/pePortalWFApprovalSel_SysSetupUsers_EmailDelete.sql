if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_SysSetupUsers_EmailDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_SysSetupUsers_EmailDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_SysSetupUsers_Email] table.
CREATE PROCEDURE pePortalWFApprovalSel_SysSetupUsers_EmailDelete
        @pk_SSU_RowID int
AS
BEGIN
    DELETE [dbo].[sel_SysSetupUsers_Email]
    WHERE [SSU_RowID] = @pk_SSU_RowID
END

