if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupCompanyGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupCompanyGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[SysSetupCompany] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupCompanyGet
        @pk_SSC_CompanyID smallint
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[SysSetupCompany]
    WHERE [SSC_CompanyID] =@pk_SSC_CompanyID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [SSC_CompanyID],
        [SSC_CompanyName],
        [SSC_Description],
        [SSC_Checked],
        [SSC_DateCreated],
        [SSC_DateModified],
        CAST(BINARY_CHECKSUM([SSC_CompanyID],[SSC_CompanyName],[SSC_Description],[SSC_Checked],[SSC_DateCreated],[SSC_DateModified]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[SysSetupCompany]
    WHERE [SSC_CompanyID] =@pk_SSC_CompanyID
    SET NOCOUNT OFF
END

