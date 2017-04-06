if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WPO_POP105501Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WPO_POP105501Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[sel_WPO_POP10550] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSel_WPO_POP105501Update
    @p_DOCTYPE smallint,
    @p_POPNUMBE char(17),
    @pk_POPNUMBE char(17),
    @p_ORD int,
    @pk_ORD int,
    @p_COMMENTS varchar(204),
    @p_CompanyID int,
    @pk_CompanyID int,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[sel_WPO_POP10550] WHERE [POPNUMBE] = @pk_POPNUMBE and [ORD] = @pk_ORD and [CompanyID] = @pk_CompanyID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[sel_WPO_POP10550]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[sel_WPO_POP10550]
            SET 
            [DOCTYPE] = @p_DOCTYPE,
            [POPNUMBE] = @p_POPNUMBE,
            [ORD] = @p_ORD,
            [COMMENTS] = @p_COMMENTS,
            [CompanyID] = @p_CompanyID
            WHERE [POPNUMBE] = @pk_POPNUMBE and [ORD] = @pk_ORD and [CompanyID] = @pk_CompanyID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([DOCTYPE],[POPNUMBE],[ORD],[COMMENTS],[CompanyID]) AS nvarchar(max)) 
            FROM [dbo].[sel_WPO_POP10550] with (rowlock, holdlock)
            WHERE [POPNUMBE] = @pk_POPNUMBE and [ORD] = @pk_ORD and [CompanyID] = @pk_CompanyID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[sel_WPO_POP10550]
                    SET 
                    [DOCTYPE] = @p_DOCTYPE,
                    [POPNUMBE] = @p_POPNUMBE,
                    [ORD] = @p_ORD,
                    [COMMENTS] = @p_COMMENTS,
                    [CompanyID] = @p_CompanyID
                    WHERE [POPNUMBE] = @pk_POPNUMBE and [ORD] = @pk_ORD and [CompanyID] = @pk_CompanyID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[sel_WPO_POP10550]', 16, 1)

        END
END

