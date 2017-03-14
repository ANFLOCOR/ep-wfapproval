if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalACTIVITYUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalACTIVITYUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[ACTIVITY] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalACTIVITYUpdate
    @p_USERID char(15),
    @pk_USERID char(15),
    @p_CMPNYNAM char(65),
    @pk_CMPNYNAM char(65),
    @p_LOGINDAT datetime,
    @p_LOGINTIM datetime,
    @p_SQLSESID int,
    @p_Language_ID smallint,
    @p_IsWebClient tinyint,
    @p_IsOffline tinyint,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[ACTIVITY] WHERE [USERID] = @pk_USERID and [CMPNYNAM] = @pk_CMPNYNAM)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[ACTIVITY]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[ACTIVITY]
            SET 
            [USERID] = @p_USERID,
            [CMPNYNAM] = @p_CMPNYNAM,
            [LOGINDAT] = @p_LOGINDAT,
            [LOGINTIM] = @p_LOGINTIM,
            [SQLSESID] = @p_SQLSESID,
            [Language_ID] = @p_Language_ID,
            [IsWebClient] = @p_IsWebClient,
            [IsOffline] = @p_IsOffline
            WHERE [USERID] = @pk_USERID and [CMPNYNAM] = @pk_CMPNYNAM

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([USERID],[CMPNYNAM],[LOGINDAT],[LOGINTIM],[SQLSESID],[Language_ID],[IsWebClient],[IsOffline],[DEX_ROW_ID]) AS nvarchar(max)) 
            FROM [dbo].[ACTIVITY] with (rowlock, holdlock)
            WHERE [USERID] = @pk_USERID and [CMPNYNAM] = @pk_CMPNYNAM


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[ACTIVITY]
                    SET 
                    [USERID] = @p_USERID,
                    [CMPNYNAM] = @p_CMPNYNAM,
                    [LOGINDAT] = @p_LOGINDAT,
                    [LOGINTIM] = @p_LOGINTIM,
                    [SQLSESID] = @p_SQLSESID,
                    [Language_ID] = @p_Language_ID,
                    [IsWebClient] = @p_IsWebClient,
                    [IsOffline] = @p_IsOffline
                    WHERE [USERID] = @pk_USERID and [CMPNYNAM] = @pk_CMPNYNAM

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[ACTIVITY]', 16, 1)

        END
END

