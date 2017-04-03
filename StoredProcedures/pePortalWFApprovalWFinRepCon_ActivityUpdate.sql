if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepCon_ActivityUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepCon_ActivityUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WFinRepCon_Activity] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWFinRepCon_ActivityUpdate
    @pk_WFRCA_ID int,
    @p_WFRCA_WS_ID int,
    @p_WFRCA_WSD_ID int,
    @p_WFRCA_WDT_ID int,
    @p_WFRCA_W_U_ID int,
    @p_WFRCA_W_U_ID_Delegate int,
    @p_WFRCA_Status int,
    @p_WFRCA_Date_Assign smalldatetime,
    @p_WFRCA_Date_Action smalldatetime,
    @p_WFRCA_Remark nvarchar(500),
    @p_WFRCA_Is_Done bit,
    @p_WFRCA_Code nvarchar(20),
    @p_WFRCA_FinID int,
    @p_WFRCA_WFRCH_ID int,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WFinRepCon_Activity] WHERE [WFRCA_ID] = @pk_WFRCA_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WFinRepCon_Activity]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WFinRepCon_Activity]
            SET 
            [WFRCA_WS_ID] = @p_WFRCA_WS_ID,
            [WFRCA_WSD_ID] = @p_WFRCA_WSD_ID,
            [WFRCA_WDT_ID] = @p_WFRCA_WDT_ID,
            [WFRCA_W_U_ID] = @p_WFRCA_W_U_ID,
            [WFRCA_W_U_ID_Delegate] = @p_WFRCA_W_U_ID_Delegate,
            [WFRCA_Status] = @p_WFRCA_Status,
            [WFRCA_Date_Assign] = @p_WFRCA_Date_Assign,
            [WFRCA_Date_Action] = @p_WFRCA_Date_Action,
            [WFRCA_Remark] = @p_WFRCA_Remark,
            [WFRCA_Is_Done] = @p_WFRCA_Is_Done,
            [WFRCA_Code] = @p_WFRCA_Code,
            [WFRCA_FinID] = @p_WFRCA_FinID,
            [WFRCA_WFRCH_ID] = @p_WFRCA_WFRCH_ID
            WHERE [WFRCA_ID] = @pk_WFRCA_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WFRCA_ID],[WFRCA_WS_ID],[WFRCA_WSD_ID],[WFRCA_WDT_ID],[WFRCA_W_U_ID],[WFRCA_W_U_ID_Delegate],[WFRCA_Status],[WFRCA_Date_Assign],[WFRCA_Date_Action],[WFRCA_Remark],[WFRCA_Is_Done],[WFRCA_Code],[WFRCA_FinID],[WFRCA_WFRCH_ID]) AS nvarchar(max)) 
            FROM [dbo].[WFinRepCon_Activity] with (rowlock, holdlock)
            WHERE [WFRCA_ID] = @pk_WFRCA_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WFinRepCon_Activity]
                    SET 
                    [WFRCA_WS_ID] = @p_WFRCA_WS_ID,
                    [WFRCA_WSD_ID] = @p_WFRCA_WSD_ID,
                    [WFRCA_WDT_ID] = @p_WFRCA_WDT_ID,
                    [WFRCA_W_U_ID] = @p_WFRCA_W_U_ID,
                    [WFRCA_W_U_ID_Delegate] = @p_WFRCA_W_U_ID_Delegate,
                    [WFRCA_Status] = @p_WFRCA_Status,
                    [WFRCA_Date_Assign] = @p_WFRCA_Date_Assign,
                    [WFRCA_Date_Action] = @p_WFRCA_Date_Action,
                    [WFRCA_Remark] = @p_WFRCA_Remark,
                    [WFRCA_Is_Done] = @p_WFRCA_Is_Done,
                    [WFRCA_Code] = @p_WFRCA_Code,
                    [WFRCA_FinID] = @p_WFRCA_FinID,
                    [WFRCA_WFRCH_ID] = @p_WFRCA_WFRCH_ID
                    WHERE [WFRCA_ID] = @pk_WFRCA_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WFinRepCon_Activity]', 16, 1)

        END
END

