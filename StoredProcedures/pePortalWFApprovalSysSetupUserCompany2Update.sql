﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUserCompany2Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUserCompany2Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[SysSetupUserCompany] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSysSetupUserCompany2Update
    @p_SSUC_SSU_UserName char(15),
    @p_SSUC_SSC_CompanyID smallint,
    @p_SSUC_APP_ID int,
    @p_SSUC_isDefault bit,
    @p_SSUC_SSUA_RowID int,
    @pk_SSUC_RowID int,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[SysSetupUserCompany] WHERE [SSUC_RowID] = @pk_SSUC_RowID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[SysSetupUserCompany]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[SysSetupUserCompany]
            SET 
            [SSUC_SSU_UserName] = @p_SSUC_SSU_UserName,
            [SSUC_SSC_CompanyID] = @p_SSUC_SSC_CompanyID,
            [SSUC_APP_ID] = @p_SSUC_APP_ID,
            [SSUC_isDefault] = @p_SSUC_isDefault,
            [SSUC_SSUA_RowID] = @p_SSUC_SSUA_RowID
            WHERE [SSUC_RowID] = @pk_SSUC_RowID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([SSUC_SSU_UserName],[SSUC_SSC_CompanyID],[SSUC_APP_ID],[SSUC_isDefault],[SSUC_SSUA_RowID],[SSUC_RowID]) AS nvarchar(max)) 
            FROM [dbo].[SysSetupUserCompany] with (rowlock, holdlock)
            WHERE [SSUC_RowID] = @pk_SSUC_RowID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[SysSetupUserCompany]
                    SET 
                    [SSUC_SSU_UserName] = @p_SSUC_SSU_UserName,
                    [SSUC_SSC_CompanyID] = @p_SSUC_SSC_CompanyID,
                    [SSUC_APP_ID] = @p_SSUC_APP_ID,
                    [SSUC_isDefault] = @p_SSUC_isDefault,
                    [SSUC_SSUA_RowID] = @p_SSUC_SSUA_RowID
                    WHERE [SSUC_RowID] = @pk_SSUC_RowID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[SysSetupUserCompany]', 16, 1)

        END
END

