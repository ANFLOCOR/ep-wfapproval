if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUserEmailDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUserEmailDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[SysSetupUserEmail] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupUserEmailDelete
        @pk_SSUE_RowID int
AS
BEGIN
    DELETE [dbo].[SysSetupUserEmail]
    WHERE [SSUE_RowID] = @pk_SSUE_RowID
END

