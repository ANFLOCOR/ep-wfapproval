if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_ActivityUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_ActivityUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WPO_Activity] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWPO_ActivityUpdate
    @pk_WPO_ID int,
    @p_WPO_WS_ID int,
    @p_WPO_WSD_ID int,
    @p_WPO_WDT_ID int,
    @p_WPO_W_U_ID int,
    @p_WPO_W_U_ID_Delegate int,
    @p_WPO_Status int,
    @p_WPO_Date_Assign smalldatetime,
    @p_WPO_Date_Action smalldatetime,
    @p_WPO_Remark nvarchar(500),
    @p_WPO_Is_Done bit,
    @p_WPO_PONum nvarchar(20),
    @p_WPO_Is_InclPrint bit,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WPO_Activity] WHERE [WPO_ID] = @pk_WPO_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WPO_Activity]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WPO_Activity]
            SET 
            [WPO_WS_ID] = @p_WPO_WS_ID,
            [WPO_WSD_ID] = @p_WPO_WSD_ID,
            [WPO_WDT_ID] = @p_WPO_WDT_ID,
            [WPO_W_U_ID] = @p_WPO_W_U_ID,
            [WPO_W_U_ID_Delegate] = @p_WPO_W_U_ID_Delegate,
            [WPO_Status] = @p_WPO_Status,
            [WPO_Date_Assign] = @p_WPO_Date_Assign,
            [WPO_Date_Action] = @p_WPO_Date_Action,
            [WPO_Remark] = @p_WPO_Remark,
            [WPO_Is_Done] = @p_WPO_Is_Done,
            [WPO_PONum] = @p_WPO_PONum,
            [WPO_Is_InclPrint] = @p_WPO_Is_InclPrint
            WHERE [WPO_ID] = @pk_WPO_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WPO_ID],[WPO_WS_ID],[WPO_WSD_ID],[WPO_WDT_ID],[WPO_W_U_ID],[WPO_W_U_ID_Delegate],[WPO_Status],[WPO_Date_Assign],[WPO_Date_Action],[WPO_Remark],[WPO_Is_Done],[WPO_PONum],[WPO_Is_InclPrint]) AS nvarchar(max)) 
            FROM [dbo].[WPO_Activity] with (rowlock, holdlock)
            WHERE [WPO_ID] = @pk_WPO_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WPO_Activity]
                    SET 
                    [WPO_WS_ID] = @p_WPO_WS_ID,
                    [WPO_WSD_ID] = @p_WPO_WSD_ID,
                    [WPO_WDT_ID] = @p_WPO_WDT_ID,
                    [WPO_W_U_ID] = @p_WPO_W_U_ID,
                    [WPO_W_U_ID_Delegate] = @p_WPO_W_U_ID_Delegate,
                    [WPO_Status] = @p_WPO_Status,
                    [WPO_Date_Assign] = @p_WPO_Date_Assign,
                    [WPO_Date_Action] = @p_WPO_Date_Action,
                    [WPO_Remark] = @p_WPO_Remark,
                    [WPO_Is_Done] = @p_WPO_Is_Done,
                    [WPO_PONum] = @p_WPO_PONum,
                    [WPO_Is_InclPrint] = @p_WPO_Is_InclPrint
                    WHERE [WPO_ID] = @pk_WPO_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WPO_Activity]', 16, 1)

        END
END

