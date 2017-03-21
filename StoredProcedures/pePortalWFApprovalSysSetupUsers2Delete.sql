if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUsers2Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUsers2Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[SysSetupUsers] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupUsers2Delete
        @pk_SSU_UserName char(15)
AS
BEGIN
    DELETE [dbo].[SysSetupUsers]
    WHERE [SSU_UserName] = @pk_SSU_UserName
END

