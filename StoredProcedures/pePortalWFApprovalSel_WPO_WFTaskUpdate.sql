if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WPO_WFTaskUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WPO_WFTaskUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[sel_WPO_WFTask] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSel_WPO_WFTaskUpdate
    @p_PONUMBER char(17),
    @pk_PONUMBER char(17),
    @p_POSTATUS smallint,
    @p_DOCDATE datetime,
    @p_TOTAL numeric(15,2),
    @p_VENDORID char(15),
    @p_VENDNAME char(65),
    @p_BUYERID char(15),
    @p_Workflow_Approval_Status smallint,
    @p_CompanyID int,
    @pk_CompanyID int,
    @p_COMMENTS varchar(204),
    @p_SUBTOTAL numeric(19,5),
    @p_TRDISAMT numeric(19,5),
    @p_FRTAMNT numeric(19,5),
    @p_MSCCHAMT numeric(19,5),
    @p_TAXAMNT numeric(19,5),
    @p_isINC varchar(9),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[sel_WPO_WFTask] WHERE [PONUMBER] = @pk_PONUMBER and [CompanyID] = @pk_CompanyID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[sel_WPO_WFTask]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[sel_WPO_WFTask]
            SET 
            [PONUMBER] = @p_PONUMBER,
            [POSTATUS] = @p_POSTATUS,
            [DOCDATE] = @p_DOCDATE,
            [TOTAL] = @p_TOTAL,
            [VENDORID] = @p_VENDORID,
            [VENDNAME] = @p_VENDNAME,
            [BUYERID] = @p_BUYERID,
            [Workflow_Approval_Status] = @p_Workflow_Approval_Status,
            [CompanyID] = @p_CompanyID,
            [COMMENTS] = @p_COMMENTS,
            [SUBTOTAL] = @p_SUBTOTAL,
            [TRDISAMT] = @p_TRDISAMT,
            [FRTAMNT] = @p_FRTAMNT,
            [MSCCHAMT] = @p_MSCCHAMT,
            [TAXAMNT] = @p_TAXAMNT,
            [isINC] = @p_isINC
            WHERE [PONUMBER] = @pk_PONUMBER and [CompanyID] = @pk_CompanyID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([PONUMBER],[POSTATUS],[DOCDATE],[TOTAL],[VENDORID],[VENDNAME],[BUYERID],[Workflow_Approval_Status],[CompanyID],[COMMENTS],[SUBTOTAL],[TRDISAMT],[FRTAMNT],[MSCCHAMT],[TAXAMNT],[isINC]) AS nvarchar(max)) 
            FROM [dbo].[sel_WPO_WFTask] with (rowlock, holdlock)
            WHERE [PONUMBER] = @pk_PONUMBER and [CompanyID] = @pk_CompanyID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[sel_WPO_WFTask]
                    SET 
                    [PONUMBER] = @p_PONUMBER,
                    [POSTATUS] = @p_POSTATUS,
                    [DOCDATE] = @p_DOCDATE,
                    [TOTAL] = @p_TOTAL,
                    [VENDORID] = @p_VENDORID,
                    [VENDNAME] = @p_VENDNAME,
                    [BUYERID] = @p_BUYERID,
                    [Workflow_Approval_Status] = @p_Workflow_Approval_Status,
                    [CompanyID] = @p_CompanyID,
                    [COMMENTS] = @p_COMMENTS,
                    [SUBTOTAL] = @p_SUBTOTAL,
                    [TRDISAMT] = @p_TRDISAMT,
                    [FRTAMNT] = @p_FRTAMNT,
                    [MSCCHAMT] = @p_MSCCHAMT,
                    [TAXAMNT] = @p_TAXAMNT,
                    [isINC] = @p_isINC
                    WHERE [PONUMBER] = @pk_PONUMBER and [CompanyID] = @pk_CompanyID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[sel_WPO_WFTask]', 16, 1)

        END
END

