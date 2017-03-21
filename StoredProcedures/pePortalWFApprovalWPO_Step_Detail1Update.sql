if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_Step_Detail1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_Step_Detail1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WPO_Step_Detail] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWPO_Step_Detail1Update
    @pk_WPO_SD_ID int,
    @p_WPO_SD_S_ID int,
    @p_WPO_SD_W_U_ID int,
    @p_WPO_SD_Desc varchar(50),
    @p_WPO_SD_Status varchar(50),
    @p_WPO_SD_Variable_Ref int,
    @p_WPO_SD_Variable_SQL varchar(100),
    @p_WPO_SD_Expire smallint,
    @p_WPO_SD_W_U_ID_Delegate int,
    @p_WPO_SD_Is_Escalate bit,
    @p_WPO_SD_Is_FAP bit,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WPO_Step_Detail] WHERE [WPO_SD_ID] = @pk_WPO_SD_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WPO_Step_Detail]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WPO_Step_Detail]
            SET 
            [WPO_SD_S_ID] = @p_WPO_SD_S_ID,
            [WPO_SD_W_U_ID] = @p_WPO_SD_W_U_ID,
            [WPO_SD_Desc] = @p_WPO_SD_Desc,
            [WPO_SD_Status] = @p_WPO_SD_Status,
            [WPO_SD_Variable_Ref] = @p_WPO_SD_Variable_Ref,
            [WPO_SD_Variable_SQL] = @p_WPO_SD_Variable_SQL,
            [WPO_SD_Expire] = @p_WPO_SD_Expire,
            [WPO_SD_W_U_ID_Delegate] = @p_WPO_SD_W_U_ID_Delegate,
            [WPO_SD_Is_Escalate] = @p_WPO_SD_Is_Escalate,
            [WPO_SD_Is_FAP] = @p_WPO_SD_Is_FAP
            WHERE [WPO_SD_ID] = @pk_WPO_SD_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WPO_SD_ID],[WPO_SD_S_ID],[WPO_SD_W_U_ID],[WPO_SD_Desc],[WPO_SD_Status],[WPO_SD_Variable_Ref],[WPO_SD_Variable_SQL],[WPO_SD_Expire],[WPO_SD_W_U_ID_Delegate],[WPO_SD_Is_Escalate],[WPO_SD_Is_FAP]) AS nvarchar(max)) 
            FROM [dbo].[WPO_Step_Detail] with (rowlock, holdlock)
            WHERE [WPO_SD_ID] = @pk_WPO_SD_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WPO_Step_Detail]
                    SET 
                    [WPO_SD_S_ID] = @p_WPO_SD_S_ID,
                    [WPO_SD_W_U_ID] = @p_WPO_SD_W_U_ID,
                    [WPO_SD_Desc] = @p_WPO_SD_Desc,
                    [WPO_SD_Status] = @p_WPO_SD_Status,
                    [WPO_SD_Variable_Ref] = @p_WPO_SD_Variable_Ref,
                    [WPO_SD_Variable_SQL] = @p_WPO_SD_Variable_SQL,
                    [WPO_SD_Expire] = @p_WPO_SD_Expire,
                    [WPO_SD_W_U_ID_Delegate] = @p_WPO_SD_W_U_ID_Delegate,
                    [WPO_SD_Is_Escalate] = @p_WPO_SD_Is_Escalate,
                    [WPO_SD_Is_FAP] = @p_WPO_SD_Is_FAP
                    WHERE [WPO_SD_ID] = @pk_WPO_SD_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WPO_Step_Detail]', 16, 1)

        END
END

