if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_Line_Status1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_Line_Status1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WPR_Line_Status] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWPR_Line_Status1Update
    @pk_WPRLS_ID smallint,
    @p_WPRLS_Desc varchar(150),
    @p_WPRLS_Value smallint,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WPR_Line_Status] WHERE [WPRLS_ID] = @pk_WPRLS_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WPR_Line_Status]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WPR_Line_Status]
            SET 
            [WPRLS_Desc] = @p_WPRLS_Desc,
            [WPRLS_Value] = @p_WPRLS_Value
            WHERE [WPRLS_ID] = @pk_WPRLS_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WPRLS_ID],[WPRLS_Desc],[WPRLS_Value]) AS nvarchar(max)) 
            FROM [dbo].[WPR_Line_Status] with (rowlock, holdlock)
            WHERE [WPRLS_ID] = @pk_WPRLS_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WPR_Line_Status]
                    SET 
                    [WPRLS_Desc] = @p_WPRLS_Desc,
                    [WPRLS_Value] = @p_WPRLS_Value
                    WHERE [WPRLS_ID] = @pk_WPRLS_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WPR_Line_Status]', 16, 1)

        END
END

