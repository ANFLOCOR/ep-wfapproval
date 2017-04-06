if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WCAR_Activity_WCAR_DocUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WCAR_Activity_WCAR_DocUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[sel_WCAR_Activity_WCAR_Doc] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSel_WCAR_Activity_WCAR_DocUpdate
    @p_WCA_ID int,
    @pk_WCA_ID int,
    @p_WCA_WS_ID int,
    @p_WCA_WSD_ID int,
    @p_WCA_WDT_ID int,
    @p_WCA_W_U_ID int,
    @p_WCA_WCD_ID int,
    @p_WCA_Status varchar(50),
    @p_WCA_Date_Assign smalldatetime,
    @p_WCA_Date_Action smalldatetime,
    @p_WCA_Remark varchar(250),
    @p_WCD_No varchar(50),
    @p_WCD_Project_Title varchar(max),
    @p_WCD_Exp_Total numeric(18,2),
    @p_WCA_Is_Done bit,
    @p_WCD_U_ID int,
    @p_WCD_Remark varchar(max),
    @p_WCD_WCur_ID smallint,
    @p_WCD_Request_Date smalldatetime,
    @p_WCD_C_ID smallint,
    @p_SSC_CompanyID smallint,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[sel_WCAR_Activity_WCAR_Doc] WHERE [WCA_ID] = @pk_WCA_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[sel_WCAR_Activity_WCAR_Doc]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[sel_WCAR_Activity_WCAR_Doc]
            SET 
            [WCA_ID] = @p_WCA_ID,
            [WCA_WS_ID] = @p_WCA_WS_ID,
            [WCA_WSD_ID] = @p_WCA_WSD_ID,
            [WCA_WDT_ID] = @p_WCA_WDT_ID,
            [WCA_W_U_ID] = @p_WCA_W_U_ID,
            [WCA_WCD_ID] = @p_WCA_WCD_ID,
            [WCA_Status] = @p_WCA_Status,
            [WCA_Date_Assign] = @p_WCA_Date_Assign,
            [WCA_Date_Action] = @p_WCA_Date_Action,
            [WCA_Remark] = @p_WCA_Remark,
            [WCD_No] = @p_WCD_No,
            [WCD_Project_Title] = @p_WCD_Project_Title,
            [WCD_Exp_Total] = @p_WCD_Exp_Total,
            [WCA_Is_Done] = @p_WCA_Is_Done,
            [WCD_U_ID] = @p_WCD_U_ID,
            [WCD_Remark] = @p_WCD_Remark,
            [WCD_WCur_ID] = @p_WCD_WCur_ID,
            [WCD_Request_Date] = @p_WCD_Request_Date,
            [WCD_C_ID] = @p_WCD_C_ID,
            [SSC_CompanyID] = @p_SSC_CompanyID
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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WCA_ID],[WCA_WS_ID],[WCA_WSD_ID],[WCA_WDT_ID],[WCA_W_U_ID],[WCA_WCD_ID],[WCA_Status],[WCA_Date_Assign],[WCA_Date_Action],[WCA_Remark],[WCD_No],[WCD_Project_Title],[WCD_Exp_Total],[WCA_Is_Done],[WCD_U_ID],[WCD_Remark],[WCD_WCur_ID],[WCD_Request_Date],[WCD_C_ID],[SSC_CompanyID]) AS nvarchar(max)) 
            FROM [dbo].[sel_WCAR_Activity_WCAR_Doc] with (rowlock, holdlock)
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

                    UPDATE [dbo].[sel_WCAR_Activity_WCAR_Doc]
                    SET 
                    [WCA_ID] = @p_WCA_ID,
                    [WCA_WS_ID] = @p_WCA_WS_ID,
                    [WCA_WSD_ID] = @p_WCA_WSD_ID,
                    [WCA_WDT_ID] = @p_WCA_WDT_ID,
                    [WCA_W_U_ID] = @p_WCA_W_U_ID,
                    [WCA_WCD_ID] = @p_WCA_WCD_ID,
                    [WCA_Status] = @p_WCA_Status,
                    [WCA_Date_Assign] = @p_WCA_Date_Assign,
                    [WCA_Date_Action] = @p_WCA_Date_Action,
                    [WCA_Remark] = @p_WCA_Remark,
                    [WCD_No] = @p_WCD_No,
                    [WCD_Project_Title] = @p_WCD_Project_Title,
                    [WCD_Exp_Total] = @p_WCD_Exp_Total,
                    [WCA_Is_Done] = @p_WCA_Is_Done,
                    [WCD_U_ID] = @p_WCD_U_ID,
                    [WCD_Remark] = @p_WCD_Remark,
                    [WCD_WCur_ID] = @p_WCD_WCur_ID,
                    [WCD_Request_Date] = @p_WCD_Request_Date,
                    [WCD_C_ID] = @p_WCD_C_ID,
                    [SSC_CompanyID] = @p_SSC_CompanyID
                    WHERE [WCA_ID] = @pk_WCA_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[sel_WCAR_Activity_WCAR_Doc]', 16, 1)

        END
END

