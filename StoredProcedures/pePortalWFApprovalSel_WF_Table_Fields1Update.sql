if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WF_Table_Fields1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WF_Table_Fields1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[sel_WF_Table_Fields] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSel_WF_Table_Fields1Update
    @p_Row bigint,
    @pk_Row bigint,
    @p_TABLE_NAME nvarchar(128),
    @p_COLUMN_NAME nvarchar(128),
    @p_IS_NULLABLE varchar(3),
    @p_DATA_TYPE nvarchar(128),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[sel_WF_Table_Fields] WHERE [Row] = @pk_Row)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[sel_WF_Table_Fields]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[sel_WF_Table_Fields]
            SET 
            [Row] = @p_Row,
            [TABLE_NAME] = @p_TABLE_NAME,
            [COLUMN_NAME] = @p_COLUMN_NAME,
            [IS_NULLABLE] = @p_IS_NULLABLE,
            [DATA_TYPE] = @p_DATA_TYPE
            WHERE [Row] = @pk_Row

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([Row],[TABLE_NAME],[COLUMN_NAME],[IS_NULLABLE],[DATA_TYPE]) AS nvarchar(max)) 
            FROM [dbo].[sel_WF_Table_Fields] with (rowlock, holdlock)
            WHERE [Row] = @pk_Row


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[sel_WF_Table_Fields]
                    SET 
                    [Row] = @p_Row,
                    [TABLE_NAME] = @p_TABLE_NAME,
                    [COLUMN_NAME] = @p_COLUMN_NAME,
                    [IS_NULLABLE] = @p_IS_NULLABLE,
                    [DATA_TYPE] = @p_DATA_TYPE
                    WHERE [Row] = @pk_Row

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[sel_WF_Table_Fields]', 16, 1)

        END
END

