if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalCompanyDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalCompanyDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[Company] table.
CREATE PROCEDURE pePortalWFApprovalCompanyDelete
        @pk_CompanyID int
AS
BEGIN
    DELETE [dbo].[Company]
    WHERE [CompanyID] = @pk_CompanyID
END

