if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_ShowSubmitApproval2Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_ShowSubmitApproval2Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_ShowSubmitApproval] table.
CREATE PROCEDURE pePortalWFApprovalSel_ShowSubmitApproval2Delete
        @pk_PONUMBER char(17)
AS
BEGIN
    DELETE [dbo].[sel_ShowSubmitApproval]
    WHERE [PONUMBER] = @pk_PONUMBER
END

