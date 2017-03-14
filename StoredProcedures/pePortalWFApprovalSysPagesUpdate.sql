if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysPagesUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysPagesUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[SysPages] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSysPagesUpdate
    @pk_PageID int,
    @p_PageName varchar(100),
    @p_ParentID int,
    @p_Level int,
    @p_URL varchar(500),
    @p_DateCreated datetime,
    @p_Sorting varchar(50),
    @p_isDisplay bit,
    @p_Checked bit,
    @p_SystemID int,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[SysPages] WHERE [PageID] = @pk_PageID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[SysPages]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[SysPages]
            SET 
            [PageName] = @p_PageName,
            [ParentID] = @p_ParentID,
            [Level] = @p_Level,
            [URL] = @p_URL,
            [DateCreated] = @p_DateCreated,
            [Sorting] = @p_Sorting,
            [isDisplay] = @p_isDisplay,
            [Checked] = @p_Checked,
            [SystemID] = @p_SystemID
            WHERE [PageID] = @pk_PageID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([PageID],[PageName],[ParentID],[Level],[URL],[DateCreated],[Sorting],[isDisplay],[Checked],[SystemID]) AS nvarchar(max)) 
            FROM [dbo].[SysPages] with (rowlock, holdlock)
            WHERE [PageID] = @pk_PageID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[SysPages]
                    SET 
                    [PageName] = @p_PageName,
                    [ParentID] = @p_ParentID,
                    [Level] = @p_Level,
                    [URL] = @p_URL,
                    [DateCreated] = @p_DateCreated,
                    [Sorting] = @p_Sorting,
                    [isDisplay] = @p_isDisplay,
                    [Checked] = @p_Checked,
                    [SystemID] = @p_SystemID
                    WHERE [PageID] = @pk_PageID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[SysPages]', 16, 1)

        END
END

