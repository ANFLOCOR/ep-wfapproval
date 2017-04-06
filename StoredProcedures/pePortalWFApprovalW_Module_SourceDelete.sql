if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_Module_SourceDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_Module_SourceDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[W_Module_Source] table.
CREATE PROCEDURE pePortalWFApprovalW_Module_SourceDelete
        @pk_W_MS_ID int
AS
BEGIN
    DELETE [dbo].[W_Module_Source]
    WHERE [W_MS_ID] = @pk_W_MS_ID
END

