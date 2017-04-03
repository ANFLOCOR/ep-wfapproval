if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalCompanyGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalCompanyGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[Company] table.
CREATE PROCEDURE pePortalWFApprovalCompanyGet
        @pk_CompanyID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[Company]
    WHERE [CompanyID] =@pk_CompanyID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [CompanyID],
        [Name],
        [ShortName],
        [GroupID],
        [IsNonGP],
        [DynamicsCompanyID],
        [CreatedBy],
        [DateCreated],
        [ModifiedBy],
        [DateModified],
        [GPInterID],
        [IsConso],
        CAST(BINARY_CHECKSUM([CompanyID],[Name],[ShortName],[GroupID],[IsNonGP],[DynamicsCompanyID],[CreatedBy],[DateCreated],[ModifiedBy],[DateModified],[GPInterID],[IsConso]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[Company]
    WHERE [CompanyID] =@pk_CompanyID
    SET NOCOUNT OFF
END

