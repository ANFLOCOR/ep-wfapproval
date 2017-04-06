if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepNGP_Head1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepNGP_Head1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WFinRepNGP_Head] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWFinRepNGP_Head1Update
    @pk_WFRCHNGP_ID int,
    @p_WFRCHNGP_Year int,
    @p_WFRCHNGP_Month int,
    @p_WFRCHNGP_DT_ID int,
    @p_WFRCHNGP_Code nvarchar(20),
    @p_WFRCHNGP_Submit bit,
    @p_WFRCHNGP_Status int,
    @p_WFRCHNGP_C_ID int,
    @p_WFRCHNGP_U_ID int,
    @p_WFRCHNGP_Remark nvarchar(max),
    @p_WFRCHNGP_PRTCNT int,
    @p_WFRCHNGP_FinID int,
    @p_WFRCHNGP_RptCount int,
    @p_WFRCHNGP_Description varchar(250),
    @p_WFRCHNGP_File image,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WFinRepNGP_Head] WHERE [WFRCHNGP_ID] = @pk_WFRCHNGP_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WFinRepNGP_Head]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WFinRepNGP_Head]
            SET 
            [WFRCHNGP_Year] = @p_WFRCHNGP_Year,
            [WFRCHNGP_Month] = @p_WFRCHNGP_Month,
            [WFRCHNGP_DT_ID] = @p_WFRCHNGP_DT_ID,
            [WFRCHNGP_Code] = @p_WFRCHNGP_Code,
            [WFRCHNGP_Submit] = @p_WFRCHNGP_Submit,
            [WFRCHNGP_Status] = @p_WFRCHNGP_Status,
            [WFRCHNGP_C_ID] = @p_WFRCHNGP_C_ID,
            [WFRCHNGP_U_ID] = @p_WFRCHNGP_U_ID,
            [WFRCHNGP_Remark] = @p_WFRCHNGP_Remark,
            [WFRCHNGP_PRTCNT] = @p_WFRCHNGP_PRTCNT,
            [WFRCHNGP_FinID] = @p_WFRCHNGP_FinID,
            [WFRCHNGP_RptCount] = @p_WFRCHNGP_RptCount,
            [WFRCHNGP_Description] = @p_WFRCHNGP_Description,
            [WFRCHNGP_File] = @p_WFRCHNGP_File
            WHERE [WFRCHNGP_ID] = @pk_WFRCHNGP_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WFRCHNGP_ID],[WFRCHNGP_Year],[WFRCHNGP_Month],[WFRCHNGP_DT_ID],[WFRCHNGP_Code],[WFRCHNGP_Submit],[WFRCHNGP_Status],[WFRCHNGP_C_ID],[WFRCHNGP_U_ID],[WFRCHNGP_Remark],[WFRCHNGP_PRTCNT],[WFRCHNGP_FinID],[WFRCHNGP_RptCount],[WFRCHNGP_Description],[WFRCHNGP_File]) AS nvarchar(max)) 
            FROM [dbo].[WFinRepNGP_Head] with (rowlock, holdlock)
            WHERE [WFRCHNGP_ID] = @pk_WFRCHNGP_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WFinRepNGP_Head]
                    SET 
                    [WFRCHNGP_Year] = @p_WFRCHNGP_Year,
                    [WFRCHNGP_Month] = @p_WFRCHNGP_Month,
                    [WFRCHNGP_DT_ID] = @p_WFRCHNGP_DT_ID,
                    [WFRCHNGP_Code] = @p_WFRCHNGP_Code,
                    [WFRCHNGP_Submit] = @p_WFRCHNGP_Submit,
                    [WFRCHNGP_Status] = @p_WFRCHNGP_Status,
                    [WFRCHNGP_C_ID] = @p_WFRCHNGP_C_ID,
                    [WFRCHNGP_U_ID] = @p_WFRCHNGP_U_ID,
                    [WFRCHNGP_Remark] = @p_WFRCHNGP_Remark,
                    [WFRCHNGP_PRTCNT] = @p_WFRCHNGP_PRTCNT,
                    [WFRCHNGP_FinID] = @p_WFRCHNGP_FinID,
                    [WFRCHNGP_RptCount] = @p_WFRCHNGP_RptCount,
                    [WFRCHNGP_Description] = @p_WFRCHNGP_Description,
                    [WFRCHNGP_File] = @p_WFRCHNGP_File
                    WHERE [WFRCHNGP_ID] = @pk_WFRCHNGP_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WFinRepNGP_Head]', 16, 1)

        END
END

