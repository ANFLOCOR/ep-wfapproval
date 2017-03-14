if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WPO_InquireDetailsUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WPO_InquireDetailsUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[sel_WPO_InquireDetails] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSel_WPO_InquireDetailsUpdate
    @p_CompanyID int,
    @pk_CompanyID int,
    @p_PONUMBER char(17),
    @pk_PONUMBER char(17),
    @p_LineNumber smallint,
    @pk_LineNumber smallint,
    @p_ITEMNMBR char(31),
    @pk_ITEMNMBR char(31),
    @p_ITEMDESC char(101),
    @p_UOFM char(9),
    @p_UNITCOST numeric(19,5),
    @p_QTYORDER numeric(20,5),
    @p_EXTDCOST numeric(19,5),
    @p_DOCDATE datetime,
    @p_REQSTDBY char(21),
    @p_ORD int,
    @p_COMMENTS varchar(103),
    @p_COMMENT_4 char(51),
    @p_WPOFR_Unit_Cost numeric(19,5),
    @p_WCur_Short varchar(5),
    @p_WPOFR_Rate numeric(18,5),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[sel_WPO_InquireDetails] WHERE [CompanyID] = @pk_CompanyID and [PONUMBER] = @pk_PONUMBER and [LineNumber] = @pk_LineNumber and [ITEMNMBR] = @pk_ITEMNMBR)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[sel_WPO_InquireDetails]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[sel_WPO_InquireDetails]
            SET 
            [CompanyID] = @p_CompanyID,
            [PONUMBER] = @p_PONUMBER,
            [LineNumber] = @p_LineNumber,
            [ITEMNMBR] = @p_ITEMNMBR,
            [ITEMDESC] = @p_ITEMDESC,
            [UOFM] = @p_UOFM,
            [UNITCOST] = @p_UNITCOST,
            [QTYORDER] = @p_QTYORDER,
            [EXTDCOST] = @p_EXTDCOST,
            [DOCDATE] = @p_DOCDATE,
            [REQSTDBY] = @p_REQSTDBY,
            [ORD] = @p_ORD,
            [COMMENTS] = @p_COMMENTS,
            [COMMENT_4] = @p_COMMENT_4,
            [WPOFR_Unit_Cost] = @p_WPOFR_Unit_Cost,
            [WCur_Short] = @p_WCur_Short,
            [WPOFR_Rate] = @p_WPOFR_Rate
            WHERE [CompanyID] = @pk_CompanyID and [PONUMBER] = @pk_PONUMBER and [LineNumber] = @pk_LineNumber and [ITEMNMBR] = @pk_ITEMNMBR

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([CompanyID],[PONUMBER],[LineNumber],[ITEMNMBR],[ITEMDESC],[UOFM],[UNITCOST],[QTYORDER],[EXTDCOST],[DOCDATE],[REQSTDBY],[ORD],[COMMENTS],[COMMENT_4],[WPOFR_Unit_Cost],[WCur_Short],[WPOFR_Rate]) AS nvarchar(max)) 
            FROM [dbo].[sel_WPO_InquireDetails] with (rowlock, holdlock)
            WHERE [CompanyID] = @pk_CompanyID and [PONUMBER] = @pk_PONUMBER and [LineNumber] = @pk_LineNumber and [ITEMNMBR] = @pk_ITEMNMBR


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[sel_WPO_InquireDetails]
                    SET 
                    [CompanyID] = @p_CompanyID,
                    [PONUMBER] = @p_PONUMBER,
                    [LineNumber] = @p_LineNumber,
                    [ITEMNMBR] = @p_ITEMNMBR,
                    [ITEMDESC] = @p_ITEMDESC,
                    [UOFM] = @p_UOFM,
                    [UNITCOST] = @p_UNITCOST,
                    [QTYORDER] = @p_QTYORDER,
                    [EXTDCOST] = @p_EXTDCOST,
                    [DOCDATE] = @p_DOCDATE,
                    [REQSTDBY] = @p_REQSTDBY,
                    [ORD] = @p_ORD,
                    [COMMENTS] = @p_COMMENTS,
                    [COMMENT_4] = @p_COMMENT_4,
                    [WPOFR_Unit_Cost] = @p_WPOFR_Unit_Cost,
                    [WCur_Short] = @p_WCur_Short,
                    [WPOFR_Rate] = @p_WPOFR_Rate
                    WHERE [CompanyID] = @pk_CompanyID and [PONUMBER] = @pk_PONUMBER and [LineNumber] = @pk_LineNumber and [ITEMNMBR] = @pk_ITEMNMBR

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[sel_WPO_InquireDetails]', 16, 1)

        END
END

