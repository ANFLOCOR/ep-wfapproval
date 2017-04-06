if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWStep_DetailUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWStep_DetailUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WStep_Detail] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWStep_DetailUpdate
    @pk_WSD_ID int,
    @p_WSD_WS_ID int,
    @p_WSD_W_U_ID int,
    @p_WSD_Desc varchar(50),
    @p_WSD_Status varchar(50),
    @p_WSD_Variable_Ref int,
    @p_WSD_Variable_SQL varchar(100),
    @p_WSD_Expire smallint,
    @p_WSD_W_U_ID_Delegate int,
    @p_WSD_Is_Escalate bit,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WStep_Detail] WHERE [WSD_ID] = @pk_WSD_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WStep_Detail]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WStep_Detail]
            SET 
            [WSD_WS_ID] = @p_WSD_WS_ID,
            [WSD_W_U_ID] = @p_WSD_W_U_ID,
            [WSD_Desc] = @p_WSD_Desc,
            [WSD_Status] = @p_WSD_Status,
            [WSD_Variable_Ref] = @p_WSD_Variable_Ref,
            [WSD_Variable_SQL] = @p_WSD_Variable_SQL,
            [WSD_Expire] = @p_WSD_Expire,
            [WSD_W_U_ID_Delegate] = @p_WSD_W_U_ID_Delegate,
            [WSD_Is_Escalate] = @p_WSD_Is_Escalate
            WHERE [WSD_ID] = @pk_WSD_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WSD_ID],[WSD_WS_ID],[WSD_W_U_ID],[WSD_Desc],[WSD_Status],[WSD_Variable_Ref],[WSD_Variable_SQL],[WSD_Expire],[WSD_W_U_ID_Delegate],[WSD_Is_Escalate]) AS nvarchar(max)) 
            FROM [dbo].[WStep_Detail] with (rowlock, holdlock)
            WHERE [WSD_ID] = @pk_WSD_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WStep_Detail]
                    SET 
                    [WSD_WS_ID] = @p_WSD_WS_ID,
                    [WSD_W_U_ID] = @p_WSD_W_U_ID,
                    [WSD_Desc] = @p_WSD_Desc,
                    [WSD_Status] = @p_WSD_Status,
                    [WSD_Variable_Ref] = @p_WSD_Variable_Ref,
                    [WSD_Variable_SQL] = @p_WSD_Variable_SQL,
                    [WSD_Expire] = @p_WSD_Expire,
                    [WSD_W_U_ID_Delegate] = @p_WSD_W_U_ID_Delegate,
                    [WSD_Is_Escalate] = @p_WSD_Is_Escalate
                    WHERE [WSD_ID] = @pk_WSD_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WStep_Detail]', 16, 1)

        END
END

