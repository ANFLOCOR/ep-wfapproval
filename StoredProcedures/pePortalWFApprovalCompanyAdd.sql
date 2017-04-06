if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalCompanyAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalCompanyAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[Company] table.
CREATE PROCEDURE pePortalWFApprovalCompanyAdd
    @p_Name varchar(150),
    @p_ShortName varchar(50),
    @p_GroupID smallint,
    @p_IsNonGP bit,
    @p_DynamicsCompanyID int,
    @p_CreatedBy int,
    @p_DateCreated datetime,
    @p_ModifiedBy int,
    @p_DateModified datetime,
    @p_GPInterID char(5),
    @p_IsConso bit,
    @p_CompanyID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[Company]
        (
            [Name],
            [ShortName],
            [GroupID],
            [DynamicsCompanyID],
            [CreatedBy],
            [ModifiedBy],
            [DateModified],
            [GPInterID]
        )
    VALUES
        (
             @p_Name,
             @p_ShortName,
             @p_GroupID,
             @p_DynamicsCompanyID,
             @p_CreatedBy,
             @p_ModifiedBy,
             @p_DateModified,
             @p_GPInterID
        )

    SET @p_CompanyID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_IsNonGP IS NOT NULL
        UPDATE [dbo].[Company] SET [IsNonGP] = @p_IsNonGP WHERE [CompanyID] = @p_CompanyID_out

    IF @p_DateCreated IS NOT NULL
        UPDATE [dbo].[Company] SET [DateCreated] = @p_DateCreated WHERE [CompanyID] = @p_CompanyID_out

    IF @p_IsConso IS NOT NULL
        UPDATE [dbo].[Company] SET [IsConso] = @p_IsConso WHERE [CompanyID] = @p_CompanyID_out

END

