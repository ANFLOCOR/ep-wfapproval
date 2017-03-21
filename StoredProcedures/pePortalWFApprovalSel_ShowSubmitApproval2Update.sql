if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_ShowSubmitApproval2Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_ShowSubmitApproval2Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[sel_ShowSubmitApproval] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSel_ShowSubmitApproval2Update
    @p_PONUMBER char(17),
    @pk_PONUMBER char(17),
    @p_POSTATUS smallint,
    @p_DOCDATE datetime,
    @p_SUBTOTAL numeric(19,5),
    @p_TRDISAMT numeric(19,5),
    @p_FRTAMNT numeric(19,5),
    @p_MSCCHAMT numeric(19,5),
    @p_TAXAMNT numeric(19,5),
    @p_VENDORID char(15),
    @p_VENDNAME char(65),
    @p_CMPANYID smallint,
    @p_COMMNTID char(15),
    @p_BUYERID char(15),
    @p_Workflow_Approval_Status smallint,
    @p_CompanyID int,
    @p_WPOP_PONMBR nvarchar(17),
    @p_REMARKS varchar(22),
    @p_POTOTAL numeric(15,2),
    @p_POP_Status int,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[sel_ShowSubmitApproval] WHERE [PONUMBER] = @pk_PONUMBER)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[sel_ShowSubmitApproval]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[sel_ShowSubmitApproval]
            SET 
            [PONUMBER] = @p_PONUMBER,
            [POSTATUS] = @p_POSTATUS,
            [DOCDATE] = @p_DOCDATE,
            [SUBTOTAL] = @p_SUBTOTAL,
            [TRDISAMT] = @p_TRDISAMT,
            [FRTAMNT] = @p_FRTAMNT,
            [MSCCHAMT] = @p_MSCCHAMT,
            [TAXAMNT] = @p_TAXAMNT,
            [VENDORID] = @p_VENDORID,
            [VENDNAME] = @p_VENDNAME,
            [CMPANYID] = @p_CMPANYID,
            [COMMNTID] = @p_COMMNTID,
            [BUYERID] = @p_BUYERID,
            [Workflow_Approval_Status] = @p_Workflow_Approval_Status,
            [CompanyID] = @p_CompanyID,
            [WPOP_PONMBR] = @p_WPOP_PONMBR,
            [REMARKS] = @p_REMARKS,
            [POTOTAL] = @p_POTOTAL,
            [POP_Status] = @p_POP_Status
            WHERE [PONUMBER] = @pk_PONUMBER

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([PONUMBER],[POSTATUS],[DOCDATE],[SUBTOTAL],[TRDISAMT],[FRTAMNT],[MSCCHAMT],[TAXAMNT],[VENDORID],[VENDNAME],[CMPANYID],[COMMNTID],[BUYERID],[Workflow_Approval_Status],[CompanyID],[WPOP_PONMBR],[REMARKS],[POTOTAL],[POP_Status]) AS nvarchar(max)) 
            FROM [dbo].[sel_ShowSubmitApproval] with (rowlock, holdlock)
            WHERE [PONUMBER] = @pk_PONUMBER


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[sel_ShowSubmitApproval]
                    SET 
                    [PONUMBER] = @p_PONUMBER,
                    [POSTATUS] = @p_POSTATUS,
                    [DOCDATE] = @p_DOCDATE,
                    [SUBTOTAL] = @p_SUBTOTAL,
                    [TRDISAMT] = @p_TRDISAMT,
                    [FRTAMNT] = @p_FRTAMNT,
                    [MSCCHAMT] = @p_MSCCHAMT,
                    [TAXAMNT] = @p_TAXAMNT,
                    [VENDORID] = @p_VENDORID,
                    [VENDNAME] = @p_VENDNAME,
                    [CMPANYID] = @p_CMPANYID,
                    [COMMNTID] = @p_COMMNTID,
                    [BUYERID] = @p_BUYERID,
                    [Workflow_Approval_Status] = @p_Workflow_Approval_Status,
                    [CompanyID] = @p_CompanyID,
                    [WPOP_PONMBR] = @p_WPOP_PONMBR,
                    [REMARKS] = @p_REMARKS,
                    [POTOTAL] = @p_POTOTAL,
                    [POP_Status] = @p_POP_Status
                    WHERE [PONUMBER] = @pk_PONUMBER

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[sel_ShowSubmitApproval]', 16, 1)

        END
END

