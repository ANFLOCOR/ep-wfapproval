if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupCompanyUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupCompanyUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[SysSetupCompany] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSysSetupCompanyUpdate
    @pk_SSC_CompanyID smallint,
    @p_SSC_CompanyName varchar(50),
    @p_SSC_Description varchar(100),
    @p_SSC_Checked bit,
    @p_SSC_DateCreated datetime,
    @p_SSC_DateModified datetime,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[SysSetupCompany] WHERE [SSC_CompanyID] = @pk_SSC_CompanyID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[SysSetupCompany]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[SysSetupCompany]
            SET 
            [SSC_CompanyName] = @p_SSC_CompanyName,
            [SSC_Description] = @p_SSC_Description,
            [SSC_Checked] = @p_SSC_Checked,
            [SSC_DateCreated] = @p_SSC_DateCreated,
            [SSC_DateModified] = @p_SSC_DateModified
            WHERE [SSC_CompanyID] = @pk_SSC_CompanyID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([SSC_CompanyID],[SSC_CompanyName],[SSC_Description],[SSC_Checked],[SSC_DateCreated],[SSC_DateModified]) AS nvarchar(max)) 
            FROM [dbo].[SysSetupCompany] with (rowlock, holdlock)
            WHERE [SSC_CompanyID] = @pk_SSC_CompanyID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[SysSetupCompany]
                    SET 
                    [SSC_CompanyName] = @p_SSC_CompanyName,
                    [SSC_Description] = @p_SSC_Description,
                    [SSC_Checked] = @p_SSC_Checked,
                    [SSC_DateCreated] = @p_SSC_DateCreated,
                    [SSC_DateModified] = @p_SSC_DateModified
                    WHERE [SSC_CompanyID] = @pk_SSC_CompanyID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[SysSetupCompany]', 16, 1)

        END
END

