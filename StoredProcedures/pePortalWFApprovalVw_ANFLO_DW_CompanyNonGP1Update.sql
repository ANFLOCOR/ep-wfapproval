if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_ANFLO_DW_CompanyNonGP1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_ANFLO_DW_CompanyNonGP1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[vw_ANFLO_DW_CompanyNonGP] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalVw_ANFLO_DW_CompanyNonGP1Update
    @p_Name varchar(150),
    @p_ShortName varchar(50),
    @p_INTERID varchar(50),
    @p_DWCompanyID int,
    @pk_DWCompanyID int,
    @p_DynamicsCompanyID int,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[vw_ANFLO_DW_CompanyNonGP] WHERE [DWCompanyID] = @pk_DWCompanyID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[vw_ANFLO_DW_CompanyNonGP]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[vw_ANFLO_DW_CompanyNonGP]
            SET 
            [Name] = @p_Name,
            [ShortName] = @p_ShortName,
            [INTERID] = @p_INTERID,
            [DWCompanyID] = @p_DWCompanyID,
            [DynamicsCompanyID] = @p_DynamicsCompanyID
            WHERE [DWCompanyID] = @pk_DWCompanyID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([Name],[ShortName],[INTERID],[DWCompanyID],[DynamicsCompanyID]) AS nvarchar(max)) 
            FROM [dbo].[vw_ANFLO_DW_CompanyNonGP] with (rowlock, holdlock)
            WHERE [DWCompanyID] = @pk_DWCompanyID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[vw_ANFLO_DW_CompanyNonGP]
                    SET 
                    [Name] = @p_Name,
                    [ShortName] = @p_ShortName,
                    [INTERID] = @p_INTERID,
                    [DWCompanyID] = @p_DWCompanyID,
                    [DynamicsCompanyID] = @p_DynamicsCompanyID
                    WHERE [DWCompanyID] = @pk_DWCompanyID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[vw_ANFLO_DW_CompanyNonGP]', 16, 1)

        END
END

