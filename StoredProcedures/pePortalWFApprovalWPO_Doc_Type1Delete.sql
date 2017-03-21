if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_Doc_Type1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_Doc_Type1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WPO_Doc_Type] table.
CREATE PROCEDURE pePortalWFApprovalWPO_Doc_Type1Delete
        @pk_WPO_DT_ID int
AS
BEGIN
    DELETE [dbo].[WPO_Doc_Type]
    WHERE [WPO_DT_ID] = @pk_WPO_DT_ID
END

