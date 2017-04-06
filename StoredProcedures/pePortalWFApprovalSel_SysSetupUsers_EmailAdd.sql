if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_SysSetupUsers_EmailAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_SysSetupUsers_EmailAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_SysSetupUsers_Email] table.
CREATE PROCEDURE pePortalWFApprovalSel_SysSetupUsers_EmailAdd
    @p_SSU_UserName char(15),
    @p_SSU_FullName varchar(50),
    @p_SSU_Password varchar(50),
    @p_SSU_EmpID int,
    @p_SSU_SSC_CompanyID smallint,
    @p_SSU_IsActive bit,
    @p_SSU_DateCreated datetime,
    @p_SSU_DateModified datetime,
    @p_SSU_RowID int,
    @p_SSU_GPUsername varchar(20),
    @p_SSU_Designation varchar(250),
    @p_SSUE_Email varchar(50)
AS
BEGIN
    INSERT
    INTO [dbo].[sel_SysSetupUsers_Email]
        (
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
            [SSUE_Email]
        )
    VALUES
        (
             @p_SSU_UserName,
             @p_SSU_FullName,
             @p_SSU_Password,
             @p_SSU_EmpID,
             @p_SSU_SSC_CompanyID,
             @p_SSU_IsActive,
             @p_SSU_DateCreated,
             @p_SSU_DateModified,
             @p_SSU_RowID,
             @p_SSU_GPUsername,
             @p_SSU_Designation,
             @p_SSUE_Email
        )

END

