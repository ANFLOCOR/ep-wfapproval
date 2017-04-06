if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUserPermissionGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUserPermissionGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[SysSetupUserPermission] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupUserPermissionGet
        @pk_SSUP_RowID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[SysSetupUserPermission]
    WHERE [SSUP_RowID] =@pk_SSUP_RowID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [SSUP_SSU_UserName],
        [SSUP_SSR_RoleID],
        [SSUP_SSR_AppID],
        [SSUP_SSC_CompanyID],
        [SSUP_Permission],
        [SSUP_SSUC_RowID],
        [SSUP_RowID],
        [SSUP_isDefault],
        CAST(BINARY_CHECKSUM([SSUP_SSU_UserName],[SSUP_SSR_RoleID],[SSUP_SSR_AppID],[SSUP_SSC_CompanyID],[SSUP_Permission],[SSUP_SSUC_RowID],[SSUP_RowID],[SSUP_isDefault]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[SysSetupUserPermission]
    WHERE [SSUP_RowID] =@pk_SSUP_RowID
    SET NOCOUNT OFF
END

