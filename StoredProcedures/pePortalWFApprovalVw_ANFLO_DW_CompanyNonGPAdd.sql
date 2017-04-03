if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_ANFLO_DW_CompanyNonGPAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_ANFLO_DW_CompanyNonGPAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[vw_ANFLO_DW_CompanyNonGP] table.
CREATE PROCEDURE pePortalWFApprovalVw_ANFLO_DW_CompanyNonGPAdd
    @p_CompanyID smallint,
    @p_Name varchar(150),
    @p_ShortName varchar(50),
    @p_INTERID varchar(50),
    @p_FULLADDRESS varchar(79),
    @p_DWCompanyID int
AS
BEGIN
    INSERT
    INTO [dbo].[vw_ANFLO_DW_CompanyNonGP]
        (
            [CompanyID],
            [Name],
            [ShortName],
            [INTERID],
            [FULLADDRESS],
            [DWCompanyID]
        )
    VALUES
        (
             @p_CompanyID,
             @p_Name,
             @p_ShortName,
             @p_INTERID,
             @p_FULLADDRESS,
             @p_DWCompanyID
        )

END

