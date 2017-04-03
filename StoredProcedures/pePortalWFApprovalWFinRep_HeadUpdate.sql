if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_HeadUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_HeadUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WFinRep_Head] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWFinRep_HeadUpdate
    @pk_HFIN_ID int,
    @p_HFIN_Year int,
    @p_HFIN_Month int,
    @p_HFIN_DT_ID int,
    @p_HFIN_Code nvarchar(20),
    @p_HFIN_Submit bit,
    @p_HFIN_Status int,
    @p_HFIN_C_ID int,
    @p_HFIN_U_ID int,
    @p_HFIN_Remark nvarchar(max),
    @p_HFIN_PRTCNT int,
    @p_HFIN_FinID int,
    @p_HFIN_RptCount int,
    @p_HFIN_Description varchar(250),
    @p_HFIN_File image,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WFinRep_Head] WHERE [HFIN_ID] = @pk_HFIN_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WFinRep_Head]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WFinRep_Head]
            SET 
            [HFIN_Year] = @p_HFIN_Year,
            [HFIN_Month] = @p_HFIN_Month,
            [HFIN_DT_ID] = @p_HFIN_DT_ID,
            [HFIN_Code] = @p_HFIN_Code,
            [HFIN_Submit] = @p_HFIN_Submit,
            [HFIN_Status] = @p_HFIN_Status,
            [HFIN_C_ID] = @p_HFIN_C_ID,
            [HFIN_U_ID] = @p_HFIN_U_ID,
            [HFIN_Remark] = @p_HFIN_Remark,
            [HFIN_PRTCNT] = @p_HFIN_PRTCNT,
            [HFIN_FinID] = @p_HFIN_FinID,
            [HFIN_RptCount] = @p_HFIN_RptCount,
            [HFIN_Description] = @p_HFIN_Description,
            [HFIN_File] = @p_HFIN_File
            WHERE [HFIN_ID] = @pk_HFIN_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([HFIN_ID],[HFIN_Year],[HFIN_Month],[HFIN_DT_ID],[HFIN_Code],[HFIN_Submit],[HFIN_Status],[HFIN_C_ID],[HFIN_U_ID],[HFIN_Remark],[HFIN_PRTCNT],[HFIN_FinID],[HFIN_RptCount],[HFIN_Description],[HFIN_File]) AS nvarchar(max)) 
            FROM [dbo].[WFinRep_Head] with (rowlock, holdlock)
            WHERE [HFIN_ID] = @pk_HFIN_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WFinRep_Head]
                    SET 
                    [HFIN_Year] = @p_HFIN_Year,
                    [HFIN_Month] = @p_HFIN_Month,
                    [HFIN_DT_ID] = @p_HFIN_DT_ID,
                    [HFIN_Code] = @p_HFIN_Code,
                    [HFIN_Submit] = @p_HFIN_Submit,
                    [HFIN_Status] = @p_HFIN_Status,
                    [HFIN_C_ID] = @p_HFIN_C_ID,
                    [HFIN_U_ID] = @p_HFIN_U_ID,
                    [HFIN_Remark] = @p_HFIN_Remark,
                    [HFIN_PRTCNT] = @p_HFIN_PRTCNT,
                    [HFIN_FinID] = @p_HFIN_FinID,
                    [HFIN_RptCount] = @p_HFIN_RptCount,
                    [HFIN_Description] = @p_HFIN_Description,
                    [HFIN_File] = @p_HFIN_File
                    WHERE [HFIN_ID] = @pk_HFIN_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WFinRep_Head]', 16, 1)

        END
END

