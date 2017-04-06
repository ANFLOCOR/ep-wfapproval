if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWAttach_Type1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWAttach_Type1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WAttach_Type] table.
CREATE PROCEDURE pePortalWFApprovalWAttach_Type1Delete
        @pk_WAT_ID smallint
AS
BEGIN
    DELETE [dbo].[WAttach_Type]
    WHERE [WAT_ID] = @pk_WAT_ID
END

