if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_ANFLO_DW_CompanyNonGP1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_ANFLO_DW_CompanyNonGP1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[vw_ANFLO_DW_CompanyNonGP] table.
CREATE PROCEDURE pePortalWFApprovalVw_ANFLO_DW_CompanyNonGP1Add
    @p_Name varchar(150),
    @p_ShortName varchar(50),
    @p_INTERID varchar(50),
    @p_DWCompanyID int,
    @p_DynamicsCompanyID int
AS
BEGIN
    INSERT
    INTO [dbo].[vw_ANFLO_DW_CompanyNonGP]
        (
            [Name],
            [ShortName],
            [INTERID],
            [DWCompanyID],
            [DynamicsCompanyID]
        )
    VALUES
        (
             @p_Name,
             @p_ShortName,
             @p_INTERID,
             @p_DWCompanyID,
             @p_DynamicsCompanyID
        )

END

