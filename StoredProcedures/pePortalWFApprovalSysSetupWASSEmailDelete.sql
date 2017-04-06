if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupWASSEmailDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupWASSEmailDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[SysSetupWASSEmail] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupWASSEmailDelete
        @pk_WE_ID int
AS
BEGIN
    DELETE [dbo].[SysSetupWASSEmail]
    WHERE [WE_ID] = @pk_WE_ID
END

