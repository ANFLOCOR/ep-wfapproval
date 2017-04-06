if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupCompanyAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupCompanyAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[SysSetupCompany] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupCompanyAdd
    @p_SSC_CompanyName varchar(50),
    @p_SSC_Description varchar(100),
    @p_SSC_Checked bit,
    @p_SSC_DateCreated datetime,
    @p_SSC_DateModified datetime,
    @p_SSC_CompanyID_out smallint output
AS
BEGIN
    INSERT
    INTO [dbo].[SysSetupCompany]
        (
            [SSC_CompanyName],
            [SSC_Description],
            [SSC_Checked],
            [SSC_DateModified]
        )
    VALUES
        (
             @p_SSC_CompanyName,
             @p_SSC_Description,
             @p_SSC_Checked,
             @p_SSC_DateModified
        )

    SET @p_SSC_CompanyID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_SSC_DateCreated IS NOT NULL
        UPDATE [dbo].[SysSetupCompany] SET [SSC_DateCreated] = @p_SSC_DateCreated WHERE [SSC_CompanyID] = @p_SSC_CompanyID_out

END

