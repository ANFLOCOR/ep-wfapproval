if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalView_WCPO_CanvassUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalView_WCPO_CanvassUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[view_WCPO_Canvass] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalView_WCPO_CanvassUpdate
    @p_CompanyID smallint,
    @p_PONo char(17),
    @p_PRID int,
    @p_CanvassDate smalldatetime,
    @p_Vendors smallint,
    @p_WCI_Submit bit,
    @p_WCI_Status varchar(20),
    @p_Classification int,
    @p_Buyer int,
    @p_WCI_ID int,
    @pk_WCI_ID int,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[view_WCPO_Canvass] WHERE [WCI_ID] = @pk_WCI_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[view_WCPO_Canvass]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[view_WCPO_Canvass]
            SET 
            [CompanyID] = @p_CompanyID,
            [PONo] = @p_PONo,
            [PRID] = @p_PRID,
            [CanvassDate] = @p_CanvassDate,
            [Vendors] = @p_Vendors,
            [WCI_Submit] = @p_WCI_Submit,
            [WCI_Status] = @p_WCI_Status,
            [Classification] = @p_Classification,
            [Buyer] = @p_Buyer,
            [WCI_ID] = @p_WCI_ID
            WHERE [WCI_ID] = @pk_WCI_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([CompanyID],[PONo],[PRID],[CanvassDate],[Vendors],[WCI_Submit],[WCI_Status],[Classification],[Buyer],[WCI_ID]) AS nvarchar(max)) 
            FROM [dbo].[view_WCPO_Canvass] with (rowlock, holdlock)
            WHERE [WCI_ID] = @pk_WCI_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[view_WCPO_Canvass]
                    SET 
                    [CompanyID] = @p_CompanyID,
                    [PONo] = @p_PONo,
                    [PRID] = @p_PRID,
                    [CanvassDate] = @p_CanvassDate,
                    [Vendors] = @p_Vendors,
                    [WCI_Submit] = @p_WCI_Submit,
                    [WCI_Status] = @p_WCI_Status,
                    [Classification] = @p_Classification,
                    [Buyer] = @p_Buyer,
                    [WCI_ID] = @p_WCI_ID
                    WHERE [WCI_ID] = @pk_WCI_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[view_WCPO_Canvass]', 16, 1)

        END
END

