if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_Activity1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_Activity1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WFinRep_Activity] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWFinRep_Activity1Update
    @pk_AFIN_ID int,
    @p_AFIN_WS_ID int,
    @p_AFIN_WSD_ID int,
    @p_AFIN_WDT_ID int,
    @p_AFIN_W_U_ID int,
    @p_AFIN_W_U_ID_Delegate int,
    @p_AFIN_Status int,
    @p_AFIN_Date_Assign smalldatetime,
    @p_AFIN_Date_Action smalldatetime,
    @p_AFIN_Remark nvarchar(500),
    @p_AFIN_Is_Done bit,
    @p_AFIN_Code nvarchar(20),
    @p_AFIN_FinID int,
    @p_AFIN_HFIN_ID int,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WFinRep_Activity] WHERE [AFIN_ID] = @pk_AFIN_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WFinRep_Activity]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WFinRep_Activity]
            SET 
            [AFIN_WS_ID] = @p_AFIN_WS_ID,
            [AFIN_WSD_ID] = @p_AFIN_WSD_ID,
            [AFIN_WDT_ID] = @p_AFIN_WDT_ID,
            [AFIN_W_U_ID] = @p_AFIN_W_U_ID,
            [AFIN_W_U_ID_Delegate] = @p_AFIN_W_U_ID_Delegate,
            [AFIN_Status] = @p_AFIN_Status,
            [AFIN_Date_Assign] = @p_AFIN_Date_Assign,
            [AFIN_Date_Action] = @p_AFIN_Date_Action,
            [AFIN_Remark] = @p_AFIN_Remark,
            [AFIN_Is_Done] = @p_AFIN_Is_Done,
            [AFIN_Code] = @p_AFIN_Code,
            [AFIN_FinID] = @p_AFIN_FinID,
            [AFIN_HFIN_ID] = @p_AFIN_HFIN_ID
            WHERE [AFIN_ID] = @pk_AFIN_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([AFIN_ID],[AFIN_WS_ID],[AFIN_WSD_ID],[AFIN_WDT_ID],[AFIN_W_U_ID],[AFIN_W_U_ID_Delegate],[AFIN_Status],[AFIN_Date_Assign],[AFIN_Date_Action],[AFIN_Remark],[AFIN_Is_Done],[AFIN_Code],[AFIN_FinID],[AFIN_HFIN_ID]) AS nvarchar(max)) 
            FROM [dbo].[WFinRep_Activity] with (rowlock, holdlock)
            WHERE [AFIN_ID] = @pk_AFIN_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WFinRep_Activity]
                    SET 
                    [AFIN_WS_ID] = @p_AFIN_WS_ID,
                    [AFIN_WSD_ID] = @p_AFIN_WSD_ID,
                    [AFIN_WDT_ID] = @p_AFIN_WDT_ID,
                    [AFIN_W_U_ID] = @p_AFIN_W_U_ID,
                    [AFIN_W_U_ID_Delegate] = @p_AFIN_W_U_ID_Delegate,
                    [AFIN_Status] = @p_AFIN_Status,
                    [AFIN_Date_Assign] = @p_AFIN_Date_Assign,
                    [AFIN_Date_Action] = @p_AFIN_Date_Action,
                    [AFIN_Remark] = @p_AFIN_Remark,
                    [AFIN_Is_Done] = @p_AFIN_Is_Done,
                    [AFIN_Code] = @p_AFIN_Code,
                    [AFIN_FinID] = @p_AFIN_FinID,
                    [AFIN_HFIN_ID] = @p_AFIN_HFIN_ID
                    WHERE [AFIN_ID] = @pk_AFIN_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WFinRep_Activity]', 16, 1)

        END
END

