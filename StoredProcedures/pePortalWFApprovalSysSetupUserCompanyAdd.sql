if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUserCompanyAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUserCompanyAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[SysSetupUserCompany] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupUserCompanyAdd
    @p_SSUC_SSU_UserName char(15),
    @p_SSUC_SSC_CompanyID smallint,
    @p_SSUC_APP_ID int,
    @p_SSUC_isDefault bit,
    @p_SSUC_SSUA_RowID int,
    @p_SSUC_RowID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[SysSetupUserCompany]
        (
            [SSUC_SSU_UserName],
            [SSUC_SSC_CompanyID],
            [SSUC_APP_ID],
            [SSUC_isDefault],
            [SSUC_SSUA_RowID]
        )
    VALUES
        (
             @p_SSUC_SSU_UserName,
             @p_SSUC_SSC_CompanyID,
             @p_SSUC_APP_ID,
             @p_SSUC_isDefault,
             @p_SSUC_SSUA_RowID
        )

    SET @p_SSUC_RowID_out = SCOPE_IDENTITY()

END

