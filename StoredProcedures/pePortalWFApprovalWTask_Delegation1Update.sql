if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWTask_Delegation1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWTask_Delegation1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WTask_Delegation] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWTask_Delegation1Update
    @pk_WTD_ID int,
    @p_WTD_W_U_ID int,
    @p_WTD_W_U_ID_Delegate int,
    @p_WTD_WDT_Type varchar(5),
    @p_WTD_From smalldatetime,
    @p_WTD_To smalldatetime,
    @p_WTD_C_ID smallint,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WTask_Delegation] WHERE [WTD_ID] = @pk_WTD_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WTask_Delegation]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WTask_Delegation]
            SET 
            [WTD_W_U_ID] = @p_WTD_W_U_ID,
            [WTD_W_U_ID_Delegate] = @p_WTD_W_U_ID_Delegate,
            [WTD_WDT_Type] = @p_WTD_WDT_Type,
            [WTD_From] = @p_WTD_From,
            [WTD_To] = @p_WTD_To,
            [WTD_C_ID] = @p_WTD_C_ID
            WHERE [WTD_ID] = @pk_WTD_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WTD_ID],[WTD_W_U_ID],[WTD_W_U_ID_Delegate],[WTD_WDT_Type],[WTD_From],[WTD_To],[WTD_C_ID]) AS nvarchar(max)) 
            FROM [dbo].[WTask_Delegation] with (rowlock, holdlock)
            WHERE [WTD_ID] = @pk_WTD_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WTask_Delegation]
                    SET 
                    [WTD_W_U_ID] = @p_WTD_W_U_ID,
                    [WTD_W_U_ID_Delegate] = @p_WTD_W_U_ID_Delegate,
                    [WTD_WDT_Type] = @p_WTD_WDT_Type,
                    [WTD_From] = @p_WTD_From,
                    [WTD_To] = @p_WTD_To,
                    [WTD_C_ID] = @p_WTD_C_ID
                    WHERE [WTD_ID] = @pk_WTD_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WTask_Delegation]', 16, 1)

        END
END

