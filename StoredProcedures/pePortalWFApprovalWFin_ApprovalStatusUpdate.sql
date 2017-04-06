if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFin_ApprovalStatusUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFin_ApprovalStatusUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WFin_ApprovalStatus] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWFin_ApprovalStatusUpdate
    @p_WPO_STAT_CD int,
    @pk_WPO_STAT_CD int,
    @p_WPO_STAT_DESC nvarchar(20),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WFin_ApprovalStatus] WHERE [WPO_STAT_CD] = @pk_WPO_STAT_CD)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WFin_ApprovalStatus]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WFin_ApprovalStatus]
            SET 
            [WPO_STAT_CD] = @p_WPO_STAT_CD,
            [WPO_STAT_DESC] = @p_WPO_STAT_DESC
            WHERE [WPO_STAT_CD] = @pk_WPO_STAT_CD

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WPO_STAT_CD],[WPO_STAT_DESC]) AS nvarchar(max)) 
            FROM [dbo].[WFin_ApprovalStatus] with (rowlock, holdlock)
            WHERE [WPO_STAT_CD] = @pk_WPO_STAT_CD


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WFin_ApprovalStatus]
                    SET 
                    [WPO_STAT_CD] = @p_WPO_STAT_CD,
                    [WPO_STAT_DESC] = @p_WPO_STAT_DESC
                    WHERE [WPO_STAT_CD] = @pk_WPO_STAT_CD

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WFin_ApprovalStatus]', 16, 1)

        END
END

