if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepCon_HeadUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepCon_HeadUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WFinRepCon_Head] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWFinRepCon_HeadUpdate
    @pk_WFRCH_ID int,
    @p_WFRCH_Year int,
    @p_WFRCH_Month int,
    @p_WFRCH_DT_ID int,
    @p_WFRCH_Code nvarchar(20),
    @p_WFRCH_Submit bit,
    @p_WFRCH_Status int,
    @p_WFRCH_C_ID int,
    @p_WFRCH_U_ID int,
    @p_WFRCH_Remark nvarchar(max),
    @p_WFRCH_PRTCNT int,
    @p_WFRCH_FinID int,
    @p_WFRCH_RptCount int,
    @p_WFRCH_Description varchar(250),
    @p_WFRCH_File image,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WFinRepCon_Head] WHERE [WFRCH_ID] = @pk_WFRCH_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WFinRepCon_Head]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WFinRepCon_Head]
            SET 
            [WFRCH_Year] = @p_WFRCH_Year,
            [WFRCH_Month] = @p_WFRCH_Month,
            [WFRCH_DT_ID] = @p_WFRCH_DT_ID,
            [WFRCH_Code] = @p_WFRCH_Code,
            [WFRCH_Submit] = @p_WFRCH_Submit,
            [WFRCH_Status] = @p_WFRCH_Status,
            [WFRCH_C_ID] = @p_WFRCH_C_ID,
            [WFRCH_U_ID] = @p_WFRCH_U_ID,
            [WFRCH_Remark] = @p_WFRCH_Remark,
            [WFRCH_PRTCNT] = @p_WFRCH_PRTCNT,
            [WFRCH_FinID] = @p_WFRCH_FinID,
            [WFRCH_RptCount] = @p_WFRCH_RptCount,
            [WFRCH_Description] = @p_WFRCH_Description,
            [WFRCH_File] = @p_WFRCH_File
            WHERE [WFRCH_ID] = @pk_WFRCH_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WFRCH_ID],[WFRCH_Year],[WFRCH_Month],[WFRCH_DT_ID],[WFRCH_Code],[WFRCH_Submit],[WFRCH_Status],[WFRCH_C_ID],[WFRCH_U_ID],[WFRCH_Remark],[WFRCH_PRTCNT],[WFRCH_FinID],[WFRCH_RptCount],[WFRCH_Description],[WFRCH_File]) AS nvarchar(max)) 
            FROM [dbo].[WFinRepCon_Head] with (rowlock, holdlock)
            WHERE [WFRCH_ID] = @pk_WFRCH_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WFinRepCon_Head]
                    SET 
                    [WFRCH_Year] = @p_WFRCH_Year,
                    [WFRCH_Month] = @p_WFRCH_Month,
                    [WFRCH_DT_ID] = @p_WFRCH_DT_ID,
                    [WFRCH_Code] = @p_WFRCH_Code,
                    [WFRCH_Submit] = @p_WFRCH_Submit,
                    [WFRCH_Status] = @p_WFRCH_Status,
                    [WFRCH_C_ID] = @p_WFRCH_C_ID,
                    [WFRCH_U_ID] = @p_WFRCH_U_ID,
                    [WFRCH_Remark] = @p_WFRCH_Remark,
                    [WFRCH_PRTCNT] = @p_WFRCH_PRTCNT,
                    [WFRCH_FinID] = @p_WFRCH_FinID,
                    [WFRCH_RptCount] = @p_WFRCH_RptCount,
                    [WFRCH_Description] = @p_WFRCH_Description,
                    [WFRCH_File] = @p_WFRCH_File
                    WHERE [WFRCH_ID] = @pk_WFRCH_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WFinRepCon_Head]', 16, 1)

        END
END

