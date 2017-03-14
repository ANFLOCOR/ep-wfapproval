if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCAR_ActivityUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCAR_ActivityUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WCAR_Activity] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWCAR_ActivityUpdate
    @pk_WCA_ID int,
    @p_WCA_WS_ID int,
    @p_WCA_WSD_ID int,
    @p_WCA_WDT_ID int,
    @p_WCA_W_U_ID int,
    @p_WCA_W_U_ID_Delegate int,
    @p_WCA_WCD_ID int,
    @p_WCA_Status varchar(50),
    @p_WCA_Date_Assign smalldatetime,
    @p_WCA_Date_Action smalldatetime,
    @p_WCA_Remark varchar(250),
    @p_WCA_Is_Done bit,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WCAR_Activity] WHERE [WCA_ID] = @pk_WCA_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WCAR_Activity]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WCAR_Activity]
            SET 
            [WCA_WS_ID] = @p_WCA_WS_ID,
            [WCA_WSD_ID] = @p_WCA_WSD_ID,
            [WCA_WDT_ID] = @p_WCA_WDT_ID,
            [WCA_W_U_ID] = @p_WCA_W_U_ID,
            [WCA_W_U_ID_Delegate] = @p_WCA_W_U_ID_Delegate,
            [WCA_WCD_ID] = @p_WCA_WCD_ID,
            [WCA_Status] = @p_WCA_Status,
            [WCA_Date_Assign] = @p_WCA_Date_Assign,
            [WCA_Date_Action] = @p_WCA_Date_Action,
            [WCA_Remark] = @p_WCA_Remark,
            [WCA_Is_Done] = @p_WCA_Is_Done
            WHERE [WCA_ID] = @pk_WCA_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WCA_ID],[WCA_WS_ID],[WCA_WSD_ID],[WCA_WDT_ID],[WCA_W_U_ID],[WCA_W_U_ID_Delegate],[WCA_WCD_ID],[WCA_Status],[WCA_Date_Assign],[WCA_Date_Action],[WCA_Remark],[WCA_Is_Done]) AS nvarchar(max)) 
            FROM [dbo].[WCAR_Activity] with (rowlock, holdlock)
            WHERE [WCA_ID] = @pk_WCA_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WCAR_Activity]
                    SET 
                    [WCA_WS_ID] = @p_WCA_WS_ID,
                    [WCA_WSD_ID] = @p_WCA_WSD_ID,
                    [WCA_WDT_ID] = @p_WCA_WDT_ID,
                    [WCA_W_U_ID] = @p_WCA_W_U_ID,
                    [WCA_W_U_ID_Delegate] = @p_WCA_W_U_ID_Delegate,
                    [WCA_WCD_ID] = @p_WCA_WCD_ID,
                    [WCA_Status] = @p_WCA_Status,
                    [WCA_Date_Assign] = @p_WCA_Date_Assign,
                    [WCA_Date_Action] = @p_WCA_Date_Action,
                    [WCA_Remark] = @p_WCA_Remark,
                    [WCA_Is_Done] = @p_WCA_Is_Done
                    WHERE [WCA_ID] = @pk_WCA_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WCAR_Activity]', 16, 1)

        END
END

