if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUsers2Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUsers2Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[SysSetupUsers] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupUsers2Add
    @p_SSU_UserName char(15),
    @p_SSU_FullName varchar(50),
    @p_SSU_Password varchar(50),
    @p_SSU_EmpID int,
    @p_SSU_SSC_CompanyID smallint,
    @p_SSU_IsActive bit,
    @p_SSU_DateCreated datetime,
    @p_SSU_DateModified datetime,
    @p_SSU_GPUsername varchar(20),
    @p_SSU_Designation varchar(250)
AS
BEGIN
    INSERT
    INTO [dbo].[SysSetupUsers]
        (
            [SSU_UserName],
            [SSU_FullName],
            [SSU_Password],
            [SSU_EmpID],
            [SSU_SSC_CompanyID],
            [SSU_GPUsername],
            [SSU_Designation]
        )
    VALUES
        (
             @p_SSU_UserName,
             @p_SSU_FullName,
             @p_SSU_Password,
             @p_SSU_EmpID,
             @p_SSU_SSC_CompanyID,
             @p_SSU_GPUsername,
             @p_SSU_Designation
        )

    -- Call UPDATE for fields that have database defaults
    IF @p_SSU_IsActive IS NOT NULL
        UPDATE [dbo].[SysSetupUsers] SET [SSU_IsActive] = @p_SSU_IsActive WHERE [SSU_UserName] = @p_SSU_UserName

    IF @p_SSU_DateCreated IS NOT NULL
        UPDATE [dbo].[SysSetupUsers] SET [SSU_DateCreated] = @p_SSU_DateCreated WHERE [SSU_UserName] = @p_SSU_UserName

    IF @p_SSU_DateModified IS NOT NULL
        UPDATE [dbo].[SysSetupUsers] SET [SSU_DateModified] = @p_SSU_DateModified WHERE [SSU_UserName] = @p_SSU_UserName

END

