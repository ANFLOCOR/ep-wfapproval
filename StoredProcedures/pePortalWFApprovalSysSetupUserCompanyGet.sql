if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUserCompanyGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUserCompanyGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[SysSetupUserCompany] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupUserCompanyGet
        @pk_SSUC_RowID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[SysSetupUserCompany]
    WHERE [SSUC_RowID] =@pk_SSUC_RowID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [SSUC_SSU_UserName],
        [SSUC_SSC_CompanyID],
        [SSUC_APP_ID],
        [SSUC_isDefault],
        [SSUC_SSUA_RowID],
        [SSUC_RowID],
        CAST(BINARY_CHECKSUM([SSUC_SSU_UserName],[SSUC_SSC_CompanyID],[SSUC_APP_ID],[SSUC_isDefault],[SSUC_SSUA_RowID],[SSUC_RowID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[SysSetupUserCompany]
    WHERE [SSUC_RowID] =@pk_SSUC_RowID
    SET NOCOUNT OFF
END

