if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalCompanyUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalCompanyUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[Company] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalCompanyUpdate
    @pk_CompanyID int,
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
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[Company] WHERE [CompanyID] = @pk_CompanyID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[Company]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[Company]
            SET 
            [Name] = @p_Name,
            [ShortName] = @p_ShortName,
            [GroupID] = @p_GroupID,
            [IsNonGP] = @p_IsNonGP,
            [DynamicsCompanyID] = @p_DynamicsCompanyID,
            [CreatedBy] = @p_CreatedBy,
            [DateCreated] = @p_DateCreated,
            [ModifiedBy] = @p_ModifiedBy,
            [DateModified] = @p_DateModified,
            [GPInterID] = @p_GPInterID,
            [IsConso] = @p_IsConso
            WHERE [CompanyID] = @pk_CompanyID

            -- Make sure only one record is affected
            SET @l_rowcount = @@ROWCOUNT
            IF @l_rowcount = 0
                RAISERROR ('The record cannot be updated.', 16, 1)
            IF @l_rowcount > 1
                RAISERROR ('duplicate object instances.', 16, 1)

        END
    ELSE
        BEGIN
            -- Get the checksum value for the record 
            -- and put an update lock on the record to 
            -- ensure transactional integrity.  The lock
            -- will be release when the transaction is 
            -- later committed or rolled back.
            Select @l_newValue = CAST(BINARY_CHECKSUM([CompanyID],[Name],[ShortName],[GroupID],[IsNonGP],[DynamicsCompanyID],[CreatedBy],[DateCreated],[ModifiedBy],[DateModified],[GPInterID],[IsConso]) AS nvarchar(max)) 
            FROM [dbo].[Company] with (rowlock, holdlock)
            WHERE [CompanyID] = @pk_CompanyID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[Company]
                    SET 
                    [Name] = @p_Name,
                    [ShortName] = @p_ShortName,
                    [GroupID] = @p_GroupID,
                    [IsNonGP] = @p_IsNonGP,
                    [DynamicsCompanyID] = @p_DynamicsCompanyID,
                    [CreatedBy] = @p_CreatedBy,
                    [DateCreated] = @p_DateCreated,
                    [ModifiedBy] = @p_ModifiedBy,
                    [DateModified] = @p_DateModified,
                    [GPInterID] = @p_GPInterID,
                    [IsConso] = @p_IsConso
                    WHERE [CompanyID] = @pk_CompanyID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[Company]', 16, 1)

        END
END

