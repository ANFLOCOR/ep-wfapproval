if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_PRNo_QWFUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_PRNo_QWFUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WPO_PRNo_QWF] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWPO_PRNo_QWFUpdate
    @p_CompanyID smallint,
    @pk_CompanyID smallint,
    @p_PRNo varchar(50),
    @pk_PRNo varchar(50),
    @p_WPRD_Title varchar(250),
    @p_WPRD_Created smalldatetime,
    @p_WPRD_Total numeric(15,2),
    @p_Comment varchar(500),
    @p_PONo char(30),
    @pk_PONo char(30),
    @p_WPRD_ID int,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WPO_PRNo_QWF] WHERE [CompanyID] = @pk_CompanyID and [PRNo] = @pk_PRNo and [PONo] = @pk_PONo)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WPO_PRNo_QWF]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WPO_PRNo_QWF]
            SET 
            [CompanyID] = @p_CompanyID,
            [PRNo] = @p_PRNo,
            [WPRD_Title] = @p_WPRD_Title,
            [WPRD_Created] = @p_WPRD_Created,
            [WPRD_Total] = @p_WPRD_Total,
            [Comment] = @p_Comment,
            [PONo] = @p_PONo,
            [WPRD_ID] = @p_WPRD_ID
            WHERE [CompanyID] = @pk_CompanyID and [PRNo] = @pk_PRNo and [PONo] = @pk_PONo

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([CompanyID],[PRNo],[WPRD_Title],[WPRD_Created],[WPRD_Total],[Comment],[PONo],[WPRD_ID]) AS nvarchar(max)) 
            FROM [dbo].[WPO_PRNo_QWF] with (rowlock, holdlock)
            WHERE [CompanyID] = @pk_CompanyID and [PRNo] = @pk_PRNo and [PONo] = @pk_PONo


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WPO_PRNo_QWF]
                    SET 
                    [CompanyID] = @p_CompanyID,
                    [PRNo] = @p_PRNo,
                    [WPRD_Title] = @p_WPRD_Title,
                    [WPRD_Created] = @p_WPRD_Created,
                    [WPRD_Total] = @p_WPRD_Total,
                    [Comment] = @p_Comment,
                    [PONo] = @p_PONo,
                    [WPRD_ID] = @p_WPRD_ID
                    WHERE [CompanyID] = @pk_CompanyID and [PRNo] = @pk_PRNo and [PONo] = @pk_PONo

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WPO_PRNo_QWF]', 16, 1)

        END
END

