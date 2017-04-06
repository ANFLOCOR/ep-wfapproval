if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_Doc_Attach1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_Doc_Attach1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WPO_Doc_Attach] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWPO_Doc_Attach1Update
    @pk_WPODA_ID int,
    @p_WPODA_PONo nvarchar(20),
    @p_WPODA_Desc varchar(50),
    @p_WPODA_File image,
    @p_WPODA_CMPNY smallint,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WPO_Doc_Attach] WHERE [WPODA_ID] = @pk_WPODA_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WPO_Doc_Attach]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WPO_Doc_Attach]
            SET 
            [WPODA_PONo] = @p_WPODA_PONo,
            [WPODA_Desc] = @p_WPODA_Desc,
            [WPODA_File] = @p_WPODA_File,
            [WPODA_CMPNY] = @p_WPODA_CMPNY
            WHERE [WPODA_ID] = @pk_WPODA_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WPODA_ID],[WPODA_PONo],[WPODA_Desc],[WPODA_File],[WPODA_CMPNY]) AS nvarchar(max)) 
            FROM [dbo].[WPO_Doc_Attach] with (rowlock, holdlock)
            WHERE [WPODA_ID] = @pk_WPODA_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WPO_Doc_Attach]
                    SET 
                    [WPODA_PONo] = @p_WPODA_PONo,
                    [WPODA_Desc] = @p_WPODA_Desc,
                    [WPODA_File] = @p_WPODA_File,
                    [WPODA_CMPNY] = @p_WPODA_CMPNY
                    WHERE [WPODA_ID] = @pk_WPODA_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WPO_Doc_Attach]', 16, 1)

        END
END

