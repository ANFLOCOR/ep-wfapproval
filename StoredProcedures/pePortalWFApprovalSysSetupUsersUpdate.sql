if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUsersUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUsersUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[SysSetupUsers] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSysSetupUsersUpdate
    @p_SSU_UserName char(15),
    @pk_SSU_UserName char(15),
    @p_SSU_FullName varchar(50),
    @p_SSU_Password varchar(50),
    @p_SSU_EmpID int,
    @p_SSU_SSC_CompanyID smallint,
    @p_SSU_IsActive bit,
    @p_SSU_DateCreated datetime,
    @p_SSU_DateModified datetime,
    @p_SSU_GPUsername varchar(20),
    @p_SSU_Designation varchar(250),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[SysSetupUsers] WHERE [SSU_UserName] = @pk_SSU_UserName)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[SysSetupUsers]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[SysSetupUsers]
            SET 
            [SSU_UserName] = @p_SSU_UserName,
            [SSU_FullName] = @p_SSU_FullName,
            [SSU_Password] = @p_SSU_Password,
            [SSU_EmpID] = @p_SSU_EmpID,
            [SSU_SSC_CompanyID] = @p_SSU_SSC_CompanyID,
            [SSU_IsActive] = @p_SSU_IsActive,
            [SSU_DateCreated] = @p_SSU_DateCreated,
            [SSU_DateModified] = @p_SSU_DateModified,
            [SSU_GPUsername] = @p_SSU_GPUsername,
            [SSU_Designation] = @p_SSU_Designation
            WHERE [SSU_UserName] = @pk_SSU_UserName

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([SSU_UserName],[SSU_FullName],[SSU_Password],[SSU_EmpID],[SSU_SSC_CompanyID],[SSU_IsActive],[SSU_DateCreated],[SSU_DateModified],[SSU_RowID],[SSU_GPUsername],[SSU_Designation]) AS nvarchar(max)) 
            FROM [dbo].[SysSetupUsers] with (rowlock, holdlock)
            WHERE [SSU_UserName] = @pk_SSU_UserName


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[SysSetupUsers]
                    SET 
                    [SSU_UserName] = @p_SSU_UserName,
                    [SSU_FullName] = @p_SSU_FullName,
                    [SSU_Password] = @p_SSU_Password,
                    [SSU_EmpID] = @p_SSU_EmpID,
                    [SSU_SSC_CompanyID] = @p_SSU_SSC_CompanyID,
                    [SSU_IsActive] = @p_SSU_IsActive,
                    [SSU_DateCreated] = @p_SSU_DateCreated,
                    [SSU_DateModified] = @p_SSU_DateModified,
                    [SSU_GPUsername] = @p_SSU_GPUsername,
                    [SSU_Designation] = @p_SSU_Designation
                    WHERE [SSU_UserName] = @pk_SSU_UserName

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[SysSetupUsers]', 16, 1)

        END
END

