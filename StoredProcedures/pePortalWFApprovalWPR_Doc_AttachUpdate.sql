if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_Doc_AttachUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_Doc_AttachUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WPR_Doc_Attach] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWPR_Doc_AttachUpdate
    @pk_WPRDA_ID int,
    @p_WPRDA_WPRD_ID int,
    @p_WPRDA_Desc varchar(50),
    @p_WPRDA_File image,
    @p_WPRDA_WAT_ID smallint,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WPR_Doc_Attach] WHERE [WPRDA_ID] = @pk_WPRDA_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WPR_Doc_Attach]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WPR_Doc_Attach]
            SET 
            [WPRDA_WPRD_ID] = @p_WPRDA_WPRD_ID,
            [WPRDA_Desc] = @p_WPRDA_Desc,
            [WPRDA_File] = @p_WPRDA_File,
            [WPRDA_WAT_ID] = @p_WPRDA_WAT_ID
            WHERE [WPRDA_ID] = @pk_WPRDA_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WPRDA_ID],[WPRDA_WPRD_ID],[WPRDA_Desc],[WPRDA_File],[WPRDA_WAT_ID]) AS nvarchar(max)) 
            FROM [dbo].[WPR_Doc_Attach] with (rowlock, holdlock)
            WHERE [WPRDA_ID] = @pk_WPRDA_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WPR_Doc_Attach]
                    SET 
                    [WPRDA_WPRD_ID] = @p_WPRDA_WPRD_ID,
                    [WPRDA_Desc] = @p_WPRDA_Desc,
                    [WPRDA_File] = @p_WPRDA_File,
                    [WPRDA_WAT_ID] = @p_WPRDA_WAT_ID
                    WHERE [WPRDA_ID] = @pk_WPRDA_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WPR_Doc_Attach]', 16, 1)

        END
END

