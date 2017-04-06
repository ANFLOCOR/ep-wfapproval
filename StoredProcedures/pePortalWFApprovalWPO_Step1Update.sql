if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_Step1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_Step1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WPO_Step] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWPO_Step1Update
    @pk_WPO_S_ID int,
    @p_WPO_S_WDT_ID int,
    @p_WPO_S_ID_Next int,
    @p_WPO_S_Step_Type varchar(20),
    @p_WPO_S_Desc varchar(100),
    @p_WPO_S_Approval_Needed smallint,
    @p_WPO_S_C_ID smallint,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WPO_Step] WHERE [WPO_S_ID] = @pk_WPO_S_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WPO_Step]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WPO_Step]
            SET 
            [WPO_S_WDT_ID] = @p_WPO_S_WDT_ID,
            [WPO_S_ID_Next] = @p_WPO_S_ID_Next,
            [WPO_S_Step_Type] = @p_WPO_S_Step_Type,
            [WPO_S_Desc] = @p_WPO_S_Desc,
            [WPO_S_Approval_Needed] = @p_WPO_S_Approval_Needed,
            [WPO_S_C_ID] = @p_WPO_S_C_ID
            WHERE [WPO_S_ID] = @pk_WPO_S_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WPO_S_ID],[WPO_S_WDT_ID],[WPO_S_ID_Next],[WPO_S_Step_Type],[WPO_S_Desc],[WPO_S_Approval_Needed],[WPO_S_C_ID]) AS nvarchar(max)) 
            FROM [dbo].[WPO_Step] with (rowlock, holdlock)
            WHERE [WPO_S_ID] = @pk_WPO_S_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WPO_Step]
                    SET 
                    [WPO_S_WDT_ID] = @p_WPO_S_WDT_ID,
                    [WPO_S_ID_Next] = @p_WPO_S_ID_Next,
                    [WPO_S_Step_Type] = @p_WPO_S_Step_Type,
                    [WPO_S_Desc] = @p_WPO_S_Desc,
                    [WPO_S_Approval_Needed] = @p_WPO_S_Approval_Needed,
                    [WPO_S_C_ID] = @p_WPO_S_C_ID
                    WHERE [WPO_S_ID] = @pk_WPO_S_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WPO_Step]', 16, 1)

        END
END

