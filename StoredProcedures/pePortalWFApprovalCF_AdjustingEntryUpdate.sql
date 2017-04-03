if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalCF_AdjustingEntryUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalCF_AdjustingEntryUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[CF_AdjustingEntry] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalCF_AdjustingEntryUpdate
    @pk_AdjustID int,
    @p_WFRCH_ID int,
    @p_Year int,
    @p_PeriodID int,
    @p_CFCat_Increase int,
    @p_CFCat_Decrease int,
    @p_Amount_Adjust numeric(19,5),
    @p_CreatedBy varchar(20),
    @p_DateCreated datetime,
    @p_ModifiedBy varchar(20),
    @p_DateModified datetime,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[CF_AdjustingEntry] WHERE [AdjustID] = @pk_AdjustID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[CF_AdjustingEntry]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[CF_AdjustingEntry]
            SET 
            [WFRCH_ID] = @p_WFRCH_ID,
            [Year] = @p_Year,
            [PeriodID] = @p_PeriodID,
            [CFCat_Increase] = @p_CFCat_Increase,
            [CFCat_Decrease] = @p_CFCat_Decrease,
            [Amount_Adjust] = @p_Amount_Adjust,
            [CreatedBy] = @p_CreatedBy,
            [DateCreated] = @p_DateCreated,
            [ModifiedBy] = @p_ModifiedBy,
            [DateModified] = @p_DateModified
            WHERE [AdjustID] = @pk_AdjustID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([AdjustID],[WFRCH_ID],[Year],[PeriodID],[CFCat_Increase],[CFCat_Decrease],[Amount_Adjust],[CreatedBy],[DateCreated],[ModifiedBy],[DateModified]) AS nvarchar(max)) 
            FROM [dbo].[CF_AdjustingEntry] with (rowlock, holdlock)
            WHERE [AdjustID] = @pk_AdjustID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[CF_AdjustingEntry]
                    SET 
                    [WFRCH_ID] = @p_WFRCH_ID,
                    [Year] = @p_Year,
                    [PeriodID] = @p_PeriodID,
                    [CFCat_Increase] = @p_CFCat_Increase,
                    [CFCat_Decrease] = @p_CFCat_Decrease,
                    [Amount_Adjust] = @p_Amount_Adjust,
                    [CreatedBy] = @p_CreatedBy,
                    [DateCreated] = @p_DateCreated,
                    [ModifiedBy] = @p_ModifiedBy,
                    [DateModified] = @p_DateModified
                    WHERE [AdjustID] = @pk_AdjustID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[CF_AdjustingEntry]', 16, 1)

        END
END

