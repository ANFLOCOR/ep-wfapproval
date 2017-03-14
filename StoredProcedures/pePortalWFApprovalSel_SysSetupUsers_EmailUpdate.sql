if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_SysSetupUsers_EmailUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_SysSetupUsers_EmailUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[sel_SysSetupUsers_Email] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSel_SysSetupUsers_EmailUpdate
    @p_SSU_UserName char(15),
    @p_SSU_FullName varchar(50),
    @p_SSU_Password varchar(50),
    @p_SSU_EmpID int,
    @p_SSU_SSC_CompanyID smallint,
    @p_SSU_IsActive bit,
    @p_SSU_DateCreated datetime,
    @p_SSU_DateModified datetime,
    @p_SSU_RowID int,
    @pk_SSU_RowID int,
    @p_SSU_GPUsername varchar(20),
    @p_SSU_Designation varchar(250),
    @p_SSUE_Email varchar(50),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[sel_SysSetupUsers_Email] WHERE [SSU_RowID] = @pk_SSU_RowID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[sel_SysSetupUsers_Email]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[sel_SysSetupUsers_Email]
            SET 
            [SSU_UserName] = @p_SSU_UserName,
            [SSU_FullName] = @p_SSU_FullName,
            [SSU_Password] = @p_SSU_Password,
            [SSU_EmpID] = @p_SSU_EmpID,
            [SSU_SSC_CompanyID] = @p_SSU_SSC_CompanyID,
            [SSU_IsActive] = @p_SSU_IsActive,
            [SSU_DateCreated] = @p_SSU_DateCreated,
            [SSU_DateModified] = @p_SSU_DateModified,
            [SSU_RowID] = @p_SSU_RowID,
            [SSU_GPUsername] = @p_SSU_GPUsername,
            [SSU_Designation] = @p_SSU_Designation,
            [SSUE_Email] = @p_SSUE_Email
            WHERE [SSU_RowID] = @pk_SSU_RowID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([SSU_UserName],[SSU_FullName],[SSU_Password],[SSU_EmpID],[SSU_SSC_CompanyID],[SSU_IsActive],[SSU_DateCreated],[SSU_DateModified],[SSU_RowID],[SSU_GPUsername],[SSU_Designation],[SSUE_Email]) AS nvarchar(max)) 
            FROM [dbo].[sel_SysSetupUsers_Email] with (rowlock, holdlock)
            WHERE [SSU_RowID] = @pk_SSU_RowID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[sel_SysSetupUsers_Email]
                    SET 
                    [SSU_UserName] = @p_SSU_UserName,
                    [SSU_FullName] = @p_SSU_FullName,
                    [SSU_Password] = @p_SSU_Password,
                    [SSU_EmpID] = @p_SSU_EmpID,
                    [SSU_SSC_CompanyID] = @p_SSU_SSC_CompanyID,
                    [SSU_IsActive] = @p_SSU_IsActive,
                    [SSU_DateCreated] = @p_SSU_DateCreated,
                    [SSU_DateModified] = @p_SSU_DateModified,
                    [SSU_RowID] = @p_SSU_RowID,
                    [SSU_GPUsername] = @p_SSU_GPUsername,
                    [SSU_Designation] = @p_SSU_Designation,
                    [SSUE_Email] = @p_SSUE_Email
                    WHERE [SSU_RowID] = @pk_SSU_RowID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[sel_SysSetupUsers_Email]', 16, 1)

        END
END

