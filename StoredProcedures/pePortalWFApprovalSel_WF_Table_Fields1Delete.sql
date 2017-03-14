if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WF_Table_Fields1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WF_Table_Fields1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_WF_Table_Fields] table.
CREATE PROCEDURE pePortalWFApprovalSel_WF_Table_Fields1Delete
        @pk_Row bigint
AS
BEGIN
    DELETE [dbo].[sel_WF_Table_Fields]
    WHERE [Row] = @pk_Row
END

