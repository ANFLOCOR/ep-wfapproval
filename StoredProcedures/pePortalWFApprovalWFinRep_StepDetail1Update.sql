if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_StepDetail1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_StepDetail1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WFinRep_StepDetail] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWFinRep_StepDetail1Update
    @pk_WFIN_SD_ID int,
    @p_WFIN_SD_S_ID int,
    @p_WFIN_SD_W_U_ID int,
    @p_WFIN_SD_Desc varchar(50),
    @p_WFIN_SD_Status varchar(50),
    @p_WFIN_SD_Variable_Ref int,
    @p_WFIN_SD_Variable_SQL varchar(100),
    @p_WFIN_SD_Expire smallint,
    @p_WFIN_SD_W_U_ID_Delegate int,
    @p_WFIN_SD_Is_Escalate bit,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WFinRep_StepDetail] WHERE [WFIN_SD_ID] = @pk_WFIN_SD_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WFinRep_StepDetail]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WFinRep_StepDetail]
            SET 
            [WFIN_SD_S_ID] = @p_WFIN_SD_S_ID,
            [WFIN_SD_W_U_ID] = @p_WFIN_SD_W_U_ID,
            [WFIN_SD_Desc] = @p_WFIN_SD_Desc,
            [WFIN_SD_Status] = @p_WFIN_SD_Status,
            [WFIN_SD_Variable_Ref] = @p_WFIN_SD_Variable_Ref,
            [WFIN_SD_Variable_SQL] = @p_WFIN_SD_Variable_SQL,
            [WFIN_SD_Expire] = @p_WFIN_SD_Expire,
            [WFIN_SD_W_U_ID_Delegate] = @p_WFIN_SD_W_U_ID_Delegate,
            [WFIN_SD_Is_Escalate] = @p_WFIN_SD_Is_Escalate
            WHERE [WFIN_SD_ID] = @pk_WFIN_SD_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WFIN_SD_ID],[WFIN_SD_S_ID],[WFIN_SD_W_U_ID],[WFIN_SD_Desc],[WFIN_SD_Status],[WFIN_SD_Variable_Ref],[WFIN_SD_Variable_SQL],[WFIN_SD_Expire],[WFIN_SD_W_U_ID_Delegate],[WFIN_SD_Is_Escalate]) AS nvarchar(max)) 
            FROM [dbo].[WFinRep_StepDetail] with (rowlock, holdlock)
            WHERE [WFIN_SD_ID] = @pk_WFIN_SD_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WFinRep_StepDetail]
                    SET 
                    [WFIN_SD_S_ID] = @p_WFIN_SD_S_ID,
                    [WFIN_SD_W_U_ID] = @p_WFIN_SD_W_U_ID,
                    [WFIN_SD_Desc] = @p_WFIN_SD_Desc,
                    [WFIN_SD_Status] = @p_WFIN_SD_Status,
                    [WFIN_SD_Variable_Ref] = @p_WFIN_SD_Variable_Ref,
                    [WFIN_SD_Variable_SQL] = @p_WFIN_SD_Variable_SQL,
                    [WFIN_SD_Expire] = @p_WFIN_SD_Expire,
                    [WFIN_SD_W_U_ID_Delegate] = @p_WFIN_SD_W_U_ID_Delegate,
                    [WFIN_SD_Is_Escalate] = @p_WFIN_SD_Is_Escalate
                    WHERE [WFIN_SD_ID] = @pk_WFIN_SD_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WFinRep_StepDetail]', 16, 1)

        END
END

