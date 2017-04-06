if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_Step_StepDetail1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_Step_StepDetail1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WFinRep_Step_StepDetail] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWFinRep_Step_StepDetail1Update
    @p_WFIN_S_ID int,
    @p_WFIN_S_WDT_ID int,
    @p_WFIN_S_ID_Next int,
    @p_WFIN_S_Step_Type varchar(20),
    @p_WFIN_S_Approval_Needed smallint,
    @p_WFIN_SD_ID int,
    @pk_WFIN_SD_ID int,
    @p_WFIN_SD_W_U_ID int,
    @p_W_U_Full_Name varchar(125),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WFinRep_Step_StepDetail] WHERE [WFIN_SD_ID] = @pk_WFIN_SD_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WFinRep_Step_StepDetail]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WFinRep_Step_StepDetail]
            SET 
            [WFIN_S_ID] = @p_WFIN_S_ID,
            [WFIN_S_WDT_ID] = @p_WFIN_S_WDT_ID,
            [WFIN_S_ID_Next] = @p_WFIN_S_ID_Next,
            [WFIN_S_Step_Type] = @p_WFIN_S_Step_Type,
            [WFIN_S_Approval_Needed] = @p_WFIN_S_Approval_Needed,
            [WFIN_SD_ID] = @p_WFIN_SD_ID,
            [WFIN_SD_W_U_ID] = @p_WFIN_SD_W_U_ID,
            [W_U_Full_Name] = @p_W_U_Full_Name
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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WFIN_S_ID],[WFIN_S_WDT_ID],[WFIN_S_ID_Next],[WFIN_S_Step_Type],[WFIN_S_Approval_Needed],[WFIN_SD_ID],[WFIN_SD_W_U_ID],[W_U_Full_Name]) AS nvarchar(max)) 
            FROM [dbo].[WFinRep_Step_StepDetail] with (rowlock, holdlock)
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

                    UPDATE [dbo].[WFinRep_Step_StepDetail]
                    SET 
                    [WFIN_S_ID] = @p_WFIN_S_ID,
                    [WFIN_S_WDT_ID] = @p_WFIN_S_WDT_ID,
                    [WFIN_S_ID_Next] = @p_WFIN_S_ID_Next,
                    [WFIN_S_Step_Type] = @p_WFIN_S_Step_Type,
                    [WFIN_S_Approval_Needed] = @p_WFIN_S_Approval_Needed,
                    [WFIN_SD_ID] = @p_WFIN_SD_ID,
                    [WFIN_SD_W_U_ID] = @p_WFIN_SD_W_U_ID,
                    [W_U_Full_Name] = @p_W_U_Full_Name
                    WHERE [WFIN_SD_ID] = @pk_WFIN_SD_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WFinRep_Step_StepDetail]', 16, 1)

        END
END

