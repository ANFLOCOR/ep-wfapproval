if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_CAR_Rpt_ActivityRemUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_CAR_Rpt_ActivityRemUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[sel_CAR_Rpt_ActivityRem] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSel_CAR_Rpt_ActivityRemUpdate
    @p_WCD_No varchar(50),
    @p_WCD_C_ID smallint,
    @p_WCA_Remark varchar(250),
    @p_WCA_ID int,
    @pk_WCA_ID int,
    @p_WCA_Status varchar(50),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[sel_CAR_Rpt_ActivityRem] WHERE [WCA_ID] = @pk_WCA_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[sel_CAR_Rpt_ActivityRem]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[sel_CAR_Rpt_ActivityRem]
            SET 
            [WCD_No] = @p_WCD_No,
            [WCD_C_ID] = @p_WCD_C_ID,
            [WCA_Remark] = @p_WCA_Remark,
            [WCA_ID] = @p_WCA_ID,
            [WCA_Status] = @p_WCA_Status
            WHERE [WCA_ID] = @pk_WCA_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WCD_No],[WCD_C_ID],[WCA_Remark],[WCA_ID],[WCA_Status]) AS nvarchar(max)) 
            FROM [dbo].[sel_CAR_Rpt_ActivityRem] with (rowlock, holdlock)
            WHERE [WCA_ID] = @pk_WCA_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[sel_CAR_Rpt_ActivityRem]
                    SET 
                    [WCD_No] = @p_WCD_No,
                    [WCD_C_ID] = @p_WCD_C_ID,
                    [WCA_Remark] = @p_WCA_Remark,
                    [WCA_ID] = @p_WCA_ID,
                    [WCA_Status] = @p_WCA_Status
                    WHERE [WCA_ID] = @pk_WCA_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[sel_CAR_Rpt_ActivityRem]', 16, 1)

        END
END

