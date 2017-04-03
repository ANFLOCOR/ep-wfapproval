if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepNGP_DocAttachUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepNGP_DocAttachUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WFinRepNGP_DocAttach] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWFinRepNGP_DocAttachUpdate
    @pk_WFRCDNGP_ID int,
    @p_WFRCDNGP_Year int,
    @p_WFRCDNGP_Month int,
    @p_WFRCDNGP_Type nvarchar(10),
    @p_WFRCDNGP_Description nvarchar(250),
    @p_WFRCDNGP_File image,
    @p_WFRCDNGP_Company smallint,
    @p_WFRCDNGP_Status int,
    @p_WFRCDNGP_File1 nvarchar(100),
    @p_WFRCDNGP_RptID int,
    @p_WFRCDNGP_Post bit,
    @p_WFRCDNGP_RWRem nvarchar(50),
    @p_WFRCDNGP_WFRCHNGP_ID int,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WFinRepNGP_DocAttach] WHERE [WFRCDNGP_ID] = @pk_WFRCDNGP_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WFinRepNGP_DocAttach]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WFinRepNGP_DocAttach]
            SET 
            [WFRCDNGP_Year] = @p_WFRCDNGP_Year,
            [WFRCDNGP_Month] = @p_WFRCDNGP_Month,
            [WFRCDNGP_Type] = @p_WFRCDNGP_Type,
            [WFRCDNGP_Description] = @p_WFRCDNGP_Description,
            [WFRCDNGP_File] = @p_WFRCDNGP_File,
            [WFRCDNGP_Company] = @p_WFRCDNGP_Company,
            [WFRCDNGP_Status] = @p_WFRCDNGP_Status,
            [WFRCDNGP_File1] = @p_WFRCDNGP_File1,
            [WFRCDNGP_RptID] = @p_WFRCDNGP_RptID,
            [WFRCDNGP_Post] = @p_WFRCDNGP_Post,
            [WFRCDNGP_RWRem] = @p_WFRCDNGP_RWRem,
            [WFRCDNGP_WFRCHNGP_ID] = @p_WFRCDNGP_WFRCHNGP_ID
            WHERE [WFRCDNGP_ID] = @pk_WFRCDNGP_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WFRCDNGP_ID],[WFRCDNGP_Year],[WFRCDNGP_Month],[WFRCDNGP_Type],[WFRCDNGP_Description],[WFRCDNGP_File],[WFRCDNGP_Company],[WFRCDNGP_Status],[WFRCDNGP_File1],[WFRCDNGP_RptID],[WFRCDNGP_Post],[WFRCDNGP_RWRem],[WFRCDNGP_WFRCHNGP_ID]) AS nvarchar(max)) 
            FROM [dbo].[WFinRepNGP_DocAttach] with (rowlock, holdlock)
            WHERE [WFRCDNGP_ID] = @pk_WFRCDNGP_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WFinRepNGP_DocAttach]
                    SET 
                    [WFRCDNGP_Year] = @p_WFRCDNGP_Year,
                    [WFRCDNGP_Month] = @p_WFRCDNGP_Month,
                    [WFRCDNGP_Type] = @p_WFRCDNGP_Type,
                    [WFRCDNGP_Description] = @p_WFRCDNGP_Description,
                    [WFRCDNGP_File] = @p_WFRCDNGP_File,
                    [WFRCDNGP_Company] = @p_WFRCDNGP_Company,
                    [WFRCDNGP_Status] = @p_WFRCDNGP_Status,
                    [WFRCDNGP_File1] = @p_WFRCDNGP_File1,
                    [WFRCDNGP_RptID] = @p_WFRCDNGP_RptID,
                    [WFRCDNGP_Post] = @p_WFRCDNGP_Post,
                    [WFRCDNGP_RWRem] = @p_WFRCDNGP_RWRem,
                    [WFRCDNGP_WFRCHNGP_ID] = @p_WFRCDNGP_WFRCHNGP_ID
                    WHERE [WFRCDNGP_ID] = @pk_WFRCDNGP_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WFinRepNGP_DocAttach]', 16, 1)

        END
END

