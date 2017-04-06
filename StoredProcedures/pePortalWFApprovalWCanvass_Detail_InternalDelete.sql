if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_Detail_InternalDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_Detail_InternalDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WCanvass_Detail_Internal] table.
CREATE PROCEDURE pePortalWFApprovalWCanvass_Detail_InternalDelete
        @pk_WCDI_ID int
AS
BEGIN
    DELETE [dbo].[WCanvass_Detail_Internal]
    WHERE [WCDI_ID] = @pk_WCDI_ID
END

