if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WStep_WStep_DetailUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WStep_WStep_DetailUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[sel_WStep_WStep_Detail] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSel_WStep_WStep_DetailUpdate
    @p_WSD_ID int,
    @pk_WSD_ID int,
    @p_WS_ID int,
    @p_WS_WDT_ID int,
    @p_WS_ID_Next int,
    @p_WS_Step_Type varchar(20),
    @p_WS_Approval_Needed smallint,
    @p_WSD_W_U_ID int,
    @p_WSD_Variable_Ref int,
    @p_WSD_Variable_SQL varchar(100),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[sel_WStep_WStep_Detail] WHERE [WSD_ID] = @pk_WSD_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[sel_WStep_WStep_Detail]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[sel_WStep_WStep_Detail]
            SET 
            [WSD_ID] = @p_WSD_ID,
            [WS_ID] = @p_WS_ID,
            [WS_WDT_ID] = @p_WS_WDT_ID,
            [WS_ID_Next] = @p_WS_ID_Next,
            [WS_Step_Type] = @p_WS_Step_Type,
            [WS_Approval_Needed] = @p_WS_Approval_Needed,
            [WSD_W_U_ID] = @p_WSD_W_U_ID,
            [WSD_Variable_Ref] = @p_WSD_Variable_Ref,
            [WSD_Variable_SQL] = @p_WSD_Variable_SQL
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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WSD_ID],[WS_ID],[WS_WDT_ID],[WS_ID_Next],[WS_Step_Type],[WS_Approval_Needed],[WSD_W_U_ID],[WSD_Variable_Ref],[WSD_Variable_SQL]) AS nvarchar(max)) 
            FROM [dbo].[sel_WStep_WStep_Detail] with (rowlock, holdlock)
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

                    UPDATE [dbo].[sel_WStep_WStep_Detail]
                    SET 
                    [WSD_ID] = @p_WSD_ID,
                    [WS_ID] = @p_WS_ID,
                    [WS_WDT_ID] = @p_WS_WDT_ID,
                    [WS_ID_Next] = @p_WS_ID_Next,
                    [WS_Step_Type] = @p_WS_Step_Type,
                    [WS_Approval_Needed] = @p_WS_Approval_Needed,
                    [WSD_W_U_ID] = @p_WSD_W_U_ID,
                    [WSD_Variable_Ref] = @p_WSD_Variable_Ref,
                    [WSD_Variable_SQL] = @p_WSD_Variable_SQL
                    WHERE [WSD_ID] = @pk_WSD_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[sel_WStep_WStep_Detail]', 16, 1)

        END
END

