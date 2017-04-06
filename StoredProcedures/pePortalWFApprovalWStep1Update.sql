if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWStep1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWStep1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WStep] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWStep1Update
    @pk_WS_ID int,
    @p_WS_WDT_ID int,
    @p_WS_ID_Next int,
    @p_WS_Step_Type varchar(20),
    @p_WS_Desc varchar(100),
    @p_WS_Approval_Needed smallint,
    @p_WS_C_ID smallint,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WStep] WHERE [WS_ID] = @pk_WS_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WStep]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WStep]
            SET 
            [WS_WDT_ID] = @p_WS_WDT_ID,
            [WS_ID_Next] = @p_WS_ID_Next,
            [WS_Step_Type] = @p_WS_Step_Type,
            [WS_Desc] = @p_WS_Desc,
            [WS_Approval_Needed] = @p_WS_Approval_Needed,
            [WS_C_ID] = @p_WS_C_ID
            WHERE [WS_ID] = @pk_WS_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WS_ID],[WS_WDT_ID],[WS_ID_Next],[WS_Step_Type],[WS_Desc],[WS_Approval_Needed],[WS_C_ID]) AS nvarchar(max)) 
            FROM [dbo].[WStep] with (rowlock, holdlock)
            WHERE [WS_ID] = @pk_WS_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WStep]
                    SET 
                    [WS_WDT_ID] = @p_WS_WDT_ID,
                    [WS_ID_Next] = @p_WS_ID_Next,
                    [WS_Step_Type] = @p_WS_Step_Type,
                    [WS_Desc] = @p_WS_Desc,
                    [WS_Approval_Needed] = @p_WS_Approval_Needed,
                    [WS_C_ID] = @p_WS_C_ID
                    WHERE [WS_ID] = @pk_WS_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WStep]', 16, 1)

        END
END

