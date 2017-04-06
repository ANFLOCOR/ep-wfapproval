if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWAttach_TypeUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWAttach_TypeUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WAttach_Type] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWAttach_TypeUpdate
    @pk_WAT_ID smallint,
    @p_WAT_Name varchar(50),
    @p_WAT_Operation varchar(10),
    @p_WAT_Order smallint,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WAttach_Type] WHERE [WAT_ID] = @pk_WAT_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WAttach_Type]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WAttach_Type]
            SET 
            [WAT_Name] = @p_WAT_Name,
            [WAT_Operation] = @p_WAT_Operation,
            [WAT_Order] = @p_WAT_Order
            WHERE [WAT_ID] = @pk_WAT_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WAT_ID],[WAT_Name],[WAT_Operation],[WAT_Order]) AS nvarchar(max)) 
            FROM [dbo].[WAttach_Type] with (rowlock, holdlock)
            WHERE [WAT_ID] = @pk_WAT_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WAttach_Type]
                    SET 
                    [WAT_Name] = @p_WAT_Name,
                    [WAT_Operation] = @p_WAT_Operation,
                    [WAT_Order] = @p_WAT_Order
                    WHERE [WAT_ID] = @pk_WAT_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WAttach_Type]', 16, 1)

        END
END

