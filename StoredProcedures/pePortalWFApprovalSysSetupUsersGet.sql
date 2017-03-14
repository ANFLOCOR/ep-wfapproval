if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUsersGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUsersGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[SysSetupUsers] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupUsersGet
        @pk_SSU_UserName char(15)
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[SysSetupUsers]
    WHERE [SSU_UserName] =@pk_SSU_UserName

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [SSU_UserName],
        [SSU_FullName],
        [SSU_Password],
        [SSU_EmpID],
        [SSU_SSC_CompanyID],
        [SSU_IsActive],
        [SSU_DateCreated],
        [SSU_DateModified],
        [SSU_RowID],
        [SSU_GPUsername],
        [SSU_Designation],
        CAST(BINARY_CHECKSUM([SSU_UserName],[SSU_FullName],[SSU_Password],[SSU_EmpID],[SSU_SSC_CompanyID],[SSU_IsActive],[SSU_DateCreated],[SSU_DateModified],[SSU_RowID],[SSU_GPUsername],[SSU_Designation]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[SysSetupUsers]
    WHERE [SSU_UserName] =@pk_SSU_UserName
    SET NOCOUNT OFF
END

