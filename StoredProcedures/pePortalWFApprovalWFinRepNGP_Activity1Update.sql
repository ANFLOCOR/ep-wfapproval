if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepNGP_Activity1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepNGP_Activity1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WFinRepNGP_Activity] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWFinRepNGP_Activity1Update
    @pk_WFRNGPA_ID int,
    @p_WFRNGPA_WS_ID int,
    @p_WFRNGPA_WSD_ID int,
    @p_WFRNGPA_WDT_ID int,
    @p_WFRNGPA_W_U_ID int,
    @p_WFRNGPA_W_U_ID_Delegate int,
    @p_WFRNGPA_Status int,
    @p_WFRNGPA_Date_Assign smalldatetime,
    @p_WFRNGPA_Date_Action smalldatetime,
    @p_WFRNGPA_Remark nvarchar(500),
    @p_WFRNGPA_Is_Done bit,
    @p_WFRNGPA_Code nvarchar(20),
    @p_WFRNGPA_FinID int,
    @p_WFRNGPA_WFRCHNGP_ID int,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WFinRepNGP_Activity] WHERE [WFRNGPA_ID] = @pk_WFRNGPA_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WFinRepNGP_Activity]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WFinRepNGP_Activity]
            SET 
            [WFRNGPA_WS_ID] = @p_WFRNGPA_WS_ID,
            [WFRNGPA_WSD_ID] = @p_WFRNGPA_WSD_ID,
            [WFRNGPA_WDT_ID] = @p_WFRNGPA_WDT_ID,
            [WFRNGPA_W_U_ID] = @p_WFRNGPA_W_U_ID,
            [WFRNGPA_W_U_ID_Delegate] = @p_WFRNGPA_W_U_ID_Delegate,
            [WFRNGPA_Status] = @p_WFRNGPA_Status,
            [WFRNGPA_Date_Assign] = @p_WFRNGPA_Date_Assign,
            [WFRNGPA_Date_Action] = @p_WFRNGPA_Date_Action,
            [WFRNGPA_Remark] = @p_WFRNGPA_Remark,
            [WFRNGPA_Is_Done] = @p_WFRNGPA_Is_Done,
            [WFRNGPA_Code] = @p_WFRNGPA_Code,
            [WFRNGPA_FinID] = @p_WFRNGPA_FinID,
            [WFRNGPA_WFRCHNGP_ID] = @p_WFRNGPA_WFRCHNGP_ID
            WHERE [WFRNGPA_ID] = @pk_WFRNGPA_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WFRNGPA_ID],[WFRNGPA_WS_ID],[WFRNGPA_WSD_ID],[WFRNGPA_WDT_ID],[WFRNGPA_W_U_ID],[WFRNGPA_W_U_ID_Delegate],[WFRNGPA_Status],[WFRNGPA_Date_Assign],[WFRNGPA_Date_Action],[WFRNGPA_Remark],[WFRNGPA_Is_Done],[WFRNGPA_Code],[WFRNGPA_FinID],[WFRNGPA_WFRCHNGP_ID]) AS nvarchar(max)) 
            FROM [dbo].[WFinRepNGP_Activity] with (rowlock, holdlock)
            WHERE [WFRNGPA_ID] = @pk_WFRNGPA_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WFinRepNGP_Activity]
                    SET 
                    [WFRNGPA_WS_ID] = @p_WFRNGPA_WS_ID,
                    [WFRNGPA_WSD_ID] = @p_WFRNGPA_WSD_ID,
                    [WFRNGPA_WDT_ID] = @p_WFRNGPA_WDT_ID,
                    [WFRNGPA_W_U_ID] = @p_WFRNGPA_W_U_ID,
                    [WFRNGPA_W_U_ID_Delegate] = @p_WFRNGPA_W_U_ID_Delegate,
                    [WFRNGPA_Status] = @p_WFRNGPA_Status,
                    [WFRNGPA_Date_Assign] = @p_WFRNGPA_Date_Assign,
                    [WFRNGPA_Date_Action] = @p_WFRNGPA_Date_Action,
                    [WFRNGPA_Remark] = @p_WFRNGPA_Remark,
                    [WFRNGPA_Is_Done] = @p_WFRNGPA_Is_Done,
                    [WFRNGPA_Code] = @p_WFRNGPA_Code,
                    [WFRNGPA_FinID] = @p_WFRNGPA_FinID,
                    [WFRNGPA_WFRCHNGP_ID] = @p_WFRNGPA_WFRCHNGP_ID
                    WHERE [WFRNGPA_ID] = @pk_WFRNGPA_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WFinRepNGP_Activity]', 16, 1)

        END
END

