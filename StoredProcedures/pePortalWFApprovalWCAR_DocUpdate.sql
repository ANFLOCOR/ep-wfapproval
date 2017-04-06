if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCAR_DocUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCAR_DocUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WCAR_Doc] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWCAR_DocUpdate
    @pk_WCD_ID int,
    @p_WCD_WDT_ID int,
    @p_WCD_No varchar(50),
    @p_WCD_Submit bit,
    @p_WCD_Status varchar(50),
    @p_WCD_Remark varchar(max),
    @p_WCD_Unit_Location varchar(50),
    @p_WCD_Project_Title varchar(max),
    @p_WCD_Project_No varchar(50),
    @p_WCD_Request_Date smalldatetime,
    @p_WCD_Proj_Inc_ACB bit,
    @p_WCD_Exp_Total numeric(18,2),
    @p_WCD_Exp_Prev_Total numeric(18,2),
    @p_WCD_Exp_Budget numeric(18,2),
    @p_WCD_Exp_Under_Over_Budget numeric(18,2),
    @p_WCD_Exp_Cur_Yr numeric(18,2),
    @p_WCD_Exp_Nxt_Yr numeric(18,2),
    @p_WCD_Exp_Sub_Yr numeric(18,2),
    @p_WCD_C_ID smallint,
    @p_WCD_U_ID int,
    @p_WCD_Created smalldatetime,
    @p_WCD_WCur_ID smallint,
    @p_WCD_Supplementary bit,
    @p_WCD_Supplementary_WCD_ID int,
    @p_WCD_Supplementary_Manual varchar(50),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WCAR_Doc] WHERE [WCD_ID] = @pk_WCD_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WCAR_Doc]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WCAR_Doc]
            SET 
            [WCD_WDT_ID] = @p_WCD_WDT_ID,
            [WCD_No] = @p_WCD_No,
            [WCD_Submit] = @p_WCD_Submit,
            [WCD_Status] = @p_WCD_Status,
            [WCD_Remark] = @p_WCD_Remark,
            [WCD_Unit_Location] = @p_WCD_Unit_Location,
            [WCD_Project_Title] = @p_WCD_Project_Title,
            [WCD_Project_No] = @p_WCD_Project_No,
            [WCD_Request_Date] = @p_WCD_Request_Date,
            [WCD_Proj_Inc_ACB] = @p_WCD_Proj_Inc_ACB,
            [WCD_Exp_Total] = @p_WCD_Exp_Total,
            [WCD_Exp_Prev_Total] = @p_WCD_Exp_Prev_Total,
            [WCD_Exp_Budget] = @p_WCD_Exp_Budget,
            [WCD_Exp_Under_Over_Budget] = @p_WCD_Exp_Under_Over_Budget,
            [WCD_Exp_Cur_Yr] = @p_WCD_Exp_Cur_Yr,
            [WCD_Exp_Nxt_Yr] = @p_WCD_Exp_Nxt_Yr,
            [WCD_Exp_Sub_Yr] = @p_WCD_Exp_Sub_Yr,
            [WCD_C_ID] = @p_WCD_C_ID,
            [WCD_U_ID] = @p_WCD_U_ID,
            [WCD_Created] = @p_WCD_Created,
            [WCD_WCur_ID] = @p_WCD_WCur_ID,
            [WCD_Supplementary] = @p_WCD_Supplementary,
            [WCD_Supplementary_WCD_ID] = @p_WCD_Supplementary_WCD_ID,
            [WCD_Supplementary_Manual] = @p_WCD_Supplementary_Manual
            WHERE [WCD_ID] = @pk_WCD_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WCD_ID],[WCD_WDT_ID],[WCD_No],[WCD_Submit],[WCD_Status],[WCD_Remark],[WCD_Unit_Location],[WCD_Project_Title],[WCD_Project_No],[WCD_Request_Date],[WCD_Proj_Inc_ACB],[WCD_Exp_Total],[WCD_Exp_Prev_Total],[WCD_Exp_Budget],[WCD_Exp_Under_Over_Budget],[WCD_Exp_Cur_Yr],[WCD_Exp_Nxt_Yr],[WCD_Exp_Sub_Yr],[WCD_C_ID],[WCD_U_ID],[WCD_Created],[WCD_WCur_ID],[WCD_Supplementary],[WCD_Supplementary_WCD_ID],[WCD_Supplementary_Manual]) AS nvarchar(max)) 
            FROM [dbo].[WCAR_Doc] with (rowlock, holdlock)
            WHERE [WCD_ID] = @pk_WCD_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WCAR_Doc]
                    SET 
                    [WCD_WDT_ID] = @p_WCD_WDT_ID,
                    [WCD_No] = @p_WCD_No,
                    [WCD_Submit] = @p_WCD_Submit,
                    [WCD_Status] = @p_WCD_Status,
                    [WCD_Remark] = @p_WCD_Remark,
                    [WCD_Unit_Location] = @p_WCD_Unit_Location,
                    [WCD_Project_Title] = @p_WCD_Project_Title,
                    [WCD_Project_No] = @p_WCD_Project_No,
                    [WCD_Request_Date] = @p_WCD_Request_Date,
                    [WCD_Proj_Inc_ACB] = @p_WCD_Proj_Inc_ACB,
                    [WCD_Exp_Total] = @p_WCD_Exp_Total,
                    [WCD_Exp_Prev_Total] = @p_WCD_Exp_Prev_Total,
                    [WCD_Exp_Budget] = @p_WCD_Exp_Budget,
                    [WCD_Exp_Under_Over_Budget] = @p_WCD_Exp_Under_Over_Budget,
                    [WCD_Exp_Cur_Yr] = @p_WCD_Exp_Cur_Yr,
                    [WCD_Exp_Nxt_Yr] = @p_WCD_Exp_Nxt_Yr,
                    [WCD_Exp_Sub_Yr] = @p_WCD_Exp_Sub_Yr,
                    [WCD_C_ID] = @p_WCD_C_ID,
                    [WCD_U_ID] = @p_WCD_U_ID,
                    [WCD_Created] = @p_WCD_Created,
                    [WCD_WCur_ID] = @p_WCD_WCur_ID,
                    [WCD_Supplementary] = @p_WCD_Supplementary,
                    [WCD_Supplementary_WCD_ID] = @p_WCD_Supplementary_WCD_ID,
                    [WCD_Supplementary_Manual] = @p_WCD_Supplementary_Manual
                    WHERE [WCD_ID] = @pk_WCD_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WCAR_Doc]', 16, 1)

        END
END

