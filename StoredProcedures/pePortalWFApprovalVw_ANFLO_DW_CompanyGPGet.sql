if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_ANFLO_DW_CompanyGPGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_ANFLO_DW_CompanyGPGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[vw_ANFLO_DW_CompanyGP] table.
CREATE PROCEDURE pePortalWFApprovalVw_ANFLO_DW_CompanyGPGet
        @pk_CompanyID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[vw_ANFLO_DW_CompanyGP]
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
        [DynamicsCompanyID],
        CAST(BINARY_CHECKSUM([CompanyID],[Name],[ShortName],[GroupID],[DynamicsCompanyID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[vw_ANFLO_DW_CompanyGP]
    WHERE [CompanyID] =@pk_CompanyID
    SET NOCOUNT OFF
END

