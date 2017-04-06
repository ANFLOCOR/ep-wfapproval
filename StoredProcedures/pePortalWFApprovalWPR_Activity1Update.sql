if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_Activity1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_Activity1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WPR_Activity] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWPR_Activity1Update
    @pk_WPRA_ID int,
    @p_WPRA_WS_ID int,
    @p_WPRA_WSD_ID int,
    @p_WPRA_WDT_ID int,
    @p_WPRA_W_U_ID int,
    @p_WPRA_W_U_ID_Delegate int,
    @p_WPRA_WPRD_ID int,
    @p_WPRA_Status varchar(50),
    @p_WPRA_Date_Assign smalldatetime,
    @p_WPRA_Date_Action smalldatetime,
    @p_WPRA_Remark varchar(250),
    @p_WPRA_Is_Done bit,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WPR_Activity] WHERE [WPRA_ID] = @pk_WPRA_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WPR_Activity]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WPR_Activity]
            SET 
            [WPRA_WS_ID] = @p_WPRA_WS_ID,
            [WPRA_WSD_ID] = @p_WPRA_WSD_ID,
            [WPRA_WDT_ID] = @p_WPRA_WDT_ID,
            [WPRA_W_U_ID] = @p_WPRA_W_U_ID,
            [WPRA_W_U_ID_Delegate] = @p_WPRA_W_U_ID_Delegate,
            [WPRA_WPRD_ID] = @p_WPRA_WPRD_ID,
            [WPRA_Status] = @p_WPRA_Status,
            [WPRA_Date_Assign] = @p_WPRA_Date_Assign,
            [WPRA_Date_Action] = @p_WPRA_Date_Action,
            [WPRA_Remark] = @p_WPRA_Remark,
            [WPRA_Is_Done] = @p_WPRA_Is_Done
            WHERE [WPRA_ID] = @pk_WPRA_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WPRA_ID],[WPRA_WS_ID],[WPRA_WSD_ID],[WPRA_WDT_ID],[WPRA_W_U_ID],[WPRA_W_U_ID_Delegate],[WPRA_WPRD_ID],[WPRA_Status],[WPRA_Date_Assign],[WPRA_Date_Action],[WPRA_Remark],[WPRA_Is_Done]) AS nvarchar(max)) 
            FROM [dbo].[WPR_Activity] with (rowlock, holdlock)
            WHERE [WPRA_ID] = @pk_WPRA_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WPR_Activity]
                    SET 
                    [WPRA_WS_ID] = @p_WPRA_WS_ID,
                    [WPRA_WSD_ID] = @p_WPRA_WSD_ID,
                    [WPRA_WDT_ID] = @p_WPRA_WDT_ID,
                    [WPRA_W_U_ID] = @p_WPRA_W_U_ID,
                    [WPRA_W_U_ID_Delegate] = @p_WPRA_W_U_ID_Delegate,
                    [WPRA_WPRD_ID] = @p_WPRA_WPRD_ID,
                    [WPRA_Status] = @p_WPRA_Status,
                    [WPRA_Date_Assign] = @p_WPRA_Date_Assign,
                    [WPRA_Date_Action] = @p_WPRA_Date_Action,
                    [WPRA_Remark] = @p_WPRA_Remark,
                    [WPRA_Is_Done] = @p_WPRA_Is_Done
                    WHERE [WPRA_ID] = @pk_WPRA_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WPR_Activity]', 16, 1)

        END
END

