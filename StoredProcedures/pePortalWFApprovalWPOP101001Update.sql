if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPOP101001Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPOP101001Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WPOP10100] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWPOP101001Update
    @pk_WPOP_ID int,
    @p_WPOP_DT_ID int,
    @p_WPOP_PONMBR nvarchar(20),
    @p_WPOP_Submit bit,
    @p_WPOP_Status int,
    @p_WPOP_C_ID int,
    @p_WPOP_U_ID int,
    @p_WPOP_Remark nvarchar(max),
    @p_WPOP_PRTCNT int,
    @p_WPOP_WCur_ID smallint,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WPOP10100] WHERE [WPOP_ID] = @pk_WPOP_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WPOP10100]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WPOP10100]
            SET 
            [WPOP_DT_ID] = @p_WPOP_DT_ID,
            [WPOP_PONMBR] = @p_WPOP_PONMBR,
            [WPOP_Submit] = @p_WPOP_Submit,
            [WPOP_Status] = @p_WPOP_Status,
            [WPOP_C_ID] = @p_WPOP_C_ID,
            [WPOP_U_ID] = @p_WPOP_U_ID,
            [WPOP_Remark] = @p_WPOP_Remark,
            [WPOP_PRTCNT] = @p_WPOP_PRTCNT,
            [WPOP_WCur_ID] = @p_WPOP_WCur_ID
            WHERE [WPOP_ID] = @pk_WPOP_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WPOP_ID],[WPOP_DT_ID],[WPOP_PONMBR],[WPOP_Submit],[WPOP_Status],[WPOP_C_ID],[WPOP_U_ID],[WPOP_Remark],[WPOP_PRTCNT],[WPOP_WCur_ID]) AS nvarchar(max)) 
            FROM [dbo].[WPOP10100] with (rowlock, holdlock)
            WHERE [WPOP_ID] = @pk_WPOP_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WPOP10100]
                    SET 
                    [WPOP_DT_ID] = @p_WPOP_DT_ID,
                    [WPOP_PONMBR] = @p_WPOP_PONMBR,
                    [WPOP_Submit] = @p_WPOP_Submit,
                    [WPOP_Status] = @p_WPOP_Status,
                    [WPOP_C_ID] = @p_WPOP_C_ID,
                    [WPOP_U_ID] = @p_WPOP_U_ID,
                    [WPOP_Remark] = @p_WPOP_Remark,
                    [WPOP_PRTCNT] = @p_WPOP_PRTCNT,
                    [WPOP_WCur_ID] = @p_WPOP_WCur_ID
                    WHERE [WPOP_ID] = @pk_WPOP_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WPOP10100]', 16, 1)

        END
END

