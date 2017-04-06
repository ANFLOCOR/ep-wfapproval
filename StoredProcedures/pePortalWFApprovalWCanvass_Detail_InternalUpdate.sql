if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_Detail_InternalUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_Detail_InternalUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WCanvass_Detail_Internal] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWCanvass_Detail_InternalUpdate
    @pk_WCDI_ID int,
    @p_WCDI_WCI_ID int,
    @p_WCDI_WPRL_ID int,
    @p_WCDI_PM00200_Vendor_ID1 char(15),
    @p_WCDI_PM00200_Vendor_ID2 char(15),
    @p_WCDI_PM00200_Vendor_ID3 char(15),
    @p_WCDI_PM00200_Vendor_ID4 char(15),
    @p_WCDI_PM00200_Vendor_ID5 char(15),
    @p_WCDI_PM00200_Vendor_ID6 char(15),
    @p_WCDI_Bid1 numeric(18,5),
    @p_WCDI_Bid2 numeric(18,5),
    @p_WCDI_Bid3 numeric(18,5),
    @p_WCDI_Bid4 numeric(18,5),
    @p_WCDI_Bid5 numeric(18,5),
    @p_WCDI_Bid6 numeric(18,5),
    @p_WCDI_Award1 bit,
    @p_WCDI_Award2 bit,
    @p_WCDI_Award3 bit,
    @p_WCDI_Award4 bit,
    @p_WCDI_Award5 bit,
    @p_WCDI_Award6 bit,
    @p_WCDI_Status varchar(20),
    @p_WCDI_Audit_Comment varchar(500),
    @p_WCDI_Comment varchar(500),
    @p_WCDI_PM00200_Vendor_ID7 char(15),
    @p_WCDI_PM00200_Vendor_ID8 char(15),
    @p_WCDI_PM00200_Vendor_ID9 char(15),
    @p_WCDI_PM00200_Vendor_ID10 char(15),
    @p_WCDI_Bid7 numeric(18,5),
    @p_WCDI_Bid8 numeric(18,5),
    @p_WCDI_Bid9 numeric(18,5),
    @p_WCDI_Bid10 numeric(18,5),
    @p_WCDI_Award7 bit,
    @p_WCDI_Award8 bit,
    @p_WCDI_Award9 bit,
    @p_WCDI_Award10 bit,
    @p_WCDI_Qty1 numeric(18,4),
    @p_WCDI_Qty2 numeric(18,4),
    @p_WCDI_Qty3 numeric(18,4),
    @p_WCDI_Qty4 numeric(18,4),
    @p_WCDI_Qty5 numeric(18,4),
    @p_WCDI_Qty6 numeric(18,4),
    @p_WCDI_Qty7 numeric(18,4),
    @p_WCDI_Qty8 numeric(18,4),
    @p_WCDI_Qty9 numeric(18,4),
    @p_WCDI_Qty10 numeric(18,4),
    @p_WCDI_PO1 bit,
    @p_WCDI_PO2 bit,
    @p_WCDI_PO3 bit,
    @p_WCDI_PO4 bit,
    @p_WCDI_PO5 bit,
    @p_WCDI_PO6 bit,
    @p_WCDI_PO7 bit,
    @p_WCDI_PO8 bit,
    @p_WCDI_PO9 bit,
    @p_WCDI_PO10 bit,
    @p_WCDI_Aw1 bit,
    @p_WCDI_Aw2 bit,
    @p_WCDI_Aw3 bit,
    @p_WCDI_Aw4 bit,
    @p_WCDI_Aw5 bit,
    @p_WCDI_Aw6 bit,
    @p_WCDI_Aw7 bit,
    @p_WCDI_Aw8 bit,
    @p_WCDI_Aw9 bit,
    @p_WCDI_Aw10 bit,
    @p_WCDI_Vat1 bit,
    @p_WCDI_Vat2 bit,
    @p_WCDI_Vat3 bit,
    @p_WCDI_Vat4 bit,
    @p_WCDI_Vat5 bit,
    @p_WCDI_Vat6 bit,
    @p_WCDI_Vat7 bit,
    @p_WCDI_Vat8 bit,
    @p_WCDI_Vat9 bit,
    @p_WCDI_Vat10 bit,
    @p_WCDI_Net1 numeric(18,5),
    @p_WCDI_Net2 numeric(18,5),
    @p_WCDI_Net3 numeric(18,5),
    @p_WCDI_Net4 numeric(18,5),
    @p_WCDI_Net5 numeric(18,5),
    @p_WCDI_Net6 numeric(18,5),
    @p_WCDI_Net7 numeric(18,5),
    @p_WCDI_Net8 numeric(18,5),
    @p_WCDI_Net9 numeric(18,5),
    @p_WCDI_Net10 numeric(18,5),
    @p_WCDI_WCur_ID1 smallint,
    @p_WCDI_WCur_ID2 smallint,
    @p_WCDI_WCur_ID3 smallint,
    @p_WCDI_WCur_ID4 smallint,
    @p_WCDI_WCur_ID5 smallint,
    @p_WCDI_WCur_ID6 smallint,
    @p_WCDI_WCur_ID7 smallint,
    @p_WCDI_WCur_ID8 smallint,
    @p_WCDI_WCur_ID9 smallint,
    @p_WCDI_WCur_ID10 smallint,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WCanvass_Detail_Internal] WHERE [WCDI_ID] = @pk_WCDI_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WCanvass_Detail_Internal]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WCanvass_Detail_Internal]
            SET 
            [WCDI_WCI_ID] = @p_WCDI_WCI_ID,
            [WCDI_WPRL_ID] = @p_WCDI_WPRL_ID,
            [WCDI_PM00200_Vendor_ID1] = @p_WCDI_PM00200_Vendor_ID1,
            [WCDI_PM00200_Vendor_ID2] = @p_WCDI_PM00200_Vendor_ID2,
            [WCDI_PM00200_Vendor_ID3] = @p_WCDI_PM00200_Vendor_ID3,
            [WCDI_PM00200_Vendor_ID4] = @p_WCDI_PM00200_Vendor_ID4,
            [WCDI_PM00200_Vendor_ID5] = @p_WCDI_PM00200_Vendor_ID5,
            [WCDI_PM00200_Vendor_ID6] = @p_WCDI_PM00200_Vendor_ID6,
            [WCDI_Bid1] = @p_WCDI_Bid1,
            [WCDI_Bid2] = @p_WCDI_Bid2,
            [WCDI_Bid3] = @p_WCDI_Bid3,
            [WCDI_Bid4] = @p_WCDI_Bid4,
            [WCDI_Bid5] = @p_WCDI_Bid5,
            [WCDI_Bid6] = @p_WCDI_Bid6,
            [WCDI_Award1] = @p_WCDI_Award1,
            [WCDI_Award2] = @p_WCDI_Award2,
            [WCDI_Award3] = @p_WCDI_Award3,
            [WCDI_Award4] = @p_WCDI_Award4,
            [WCDI_Award5] = @p_WCDI_Award5,
            [WCDI_Award6] = @p_WCDI_Award6,
            [WCDI_Status] = @p_WCDI_Status,
            [WCDI_Audit_Comment] = @p_WCDI_Audit_Comment,
            [WCDI_Comment] = @p_WCDI_Comment,
            [WCDI_PM00200_Vendor_ID7] = @p_WCDI_PM00200_Vendor_ID7,
            [WCDI_PM00200_Vendor_ID8] = @p_WCDI_PM00200_Vendor_ID8,
            [WCDI_PM00200_Vendor_ID9] = @p_WCDI_PM00200_Vendor_ID9,
            [WCDI_PM00200_Vendor_ID10] = @p_WCDI_PM00200_Vendor_ID10,
            [WCDI_Bid7] = @p_WCDI_Bid7,
            [WCDI_Bid8] = @p_WCDI_Bid8,
            [WCDI_Bid9] = @p_WCDI_Bid9,
            [WCDI_Bid10] = @p_WCDI_Bid10,
            [WCDI_Award7] = @p_WCDI_Award7,
            [WCDI_Award8] = @p_WCDI_Award8,
            [WCDI_Award9] = @p_WCDI_Award9,
            [WCDI_Award10] = @p_WCDI_Award10,
            [WCDI_Qty1] = @p_WCDI_Qty1,
            [WCDI_Qty2] = @p_WCDI_Qty2,
            [WCDI_Qty3] = @p_WCDI_Qty3,
            [WCDI_Qty4] = @p_WCDI_Qty4,
            [WCDI_Qty5] = @p_WCDI_Qty5,
            [WCDI_Qty6] = @p_WCDI_Qty6,
            [WCDI_Qty7] = @p_WCDI_Qty7,
            [WCDI_Qty8] = @p_WCDI_Qty8,
            [WCDI_Qty9] = @p_WCDI_Qty9,
            [WCDI_Qty10] = @p_WCDI_Qty10,
            [WCDI_PO1] = @p_WCDI_PO1,
            [WCDI_PO2] = @p_WCDI_PO2,
            [WCDI_PO3] = @p_WCDI_PO3,
            [WCDI_PO4] = @p_WCDI_PO4,
            [WCDI_PO5] = @p_WCDI_PO5,
            [WCDI_PO6] = @p_WCDI_PO6,
            [WCDI_PO7] = @p_WCDI_PO7,
            [WCDI_PO8] = @p_WCDI_PO8,
            [WCDI_PO9] = @p_WCDI_PO9,
            [WCDI_PO10] = @p_WCDI_PO10,
            [WCDI_Aw1] = @p_WCDI_Aw1,
            [WCDI_Aw2] = @p_WCDI_Aw2,
            [WCDI_Aw3] = @p_WCDI_Aw3,
            [WCDI_Aw4] = @p_WCDI_Aw4,
            [WCDI_Aw5] = @p_WCDI_Aw5,
            [WCDI_Aw6] = @p_WCDI_Aw6,
            [WCDI_Aw7] = @p_WCDI_Aw7,
            [WCDI_Aw8] = @p_WCDI_Aw8,
            [WCDI_Aw9] = @p_WCDI_Aw9,
            [WCDI_Aw10] = @p_WCDI_Aw10,
            [WCDI_Vat1] = @p_WCDI_Vat1,
            [WCDI_Vat2] = @p_WCDI_Vat2,
            [WCDI_Vat3] = @p_WCDI_Vat3,
            [WCDI_Vat4] = @p_WCDI_Vat4,
            [WCDI_Vat5] = @p_WCDI_Vat5,
            [WCDI_Vat6] = @p_WCDI_Vat6,
            [WCDI_Vat7] = @p_WCDI_Vat7,
            [WCDI_Vat8] = @p_WCDI_Vat8,
            [WCDI_Vat9] = @p_WCDI_Vat9,
            [WCDI_Vat10] = @p_WCDI_Vat10,
            [WCDI_Net1] = @p_WCDI_Net1,
            [WCDI_Net2] = @p_WCDI_Net2,
            [WCDI_Net3] = @p_WCDI_Net3,
            [WCDI_Net4] = @p_WCDI_Net4,
            [WCDI_Net5] = @p_WCDI_Net5,
            [WCDI_Net6] = @p_WCDI_Net6,
            [WCDI_Net7] = @p_WCDI_Net7,
            [WCDI_Net8] = @p_WCDI_Net8,
            [WCDI_Net9] = @p_WCDI_Net9,
            [WCDI_Net10] = @p_WCDI_Net10,
            [WCDI_WCur_ID1] = @p_WCDI_WCur_ID1,
            [WCDI_WCur_ID2] = @p_WCDI_WCur_ID2,
            [WCDI_WCur_ID3] = @p_WCDI_WCur_ID3,
            [WCDI_WCur_ID4] = @p_WCDI_WCur_ID4,
            [WCDI_WCur_ID5] = @p_WCDI_WCur_ID5,
            [WCDI_WCur_ID6] = @p_WCDI_WCur_ID6,
            [WCDI_WCur_ID7] = @p_WCDI_WCur_ID7,
            [WCDI_WCur_ID8] = @p_WCDI_WCur_ID8,
            [WCDI_WCur_ID9] = @p_WCDI_WCur_ID9,
            [WCDI_WCur_ID10] = @p_WCDI_WCur_ID10
            WHERE [WCDI_ID] = @pk_WCDI_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WCDI_ID],[WCDI_WCI_ID],[WCDI_WPRL_ID],[WCDI_PM00200_Vendor_ID1],[WCDI_PM00200_Vendor_ID2],[WCDI_PM00200_Vendor_ID3],[WCDI_PM00200_Vendor_ID4],[WCDI_PM00200_Vendor_ID5],[WCDI_PM00200_Vendor_ID6],[WCDI_Bid1],[WCDI_Bid2],[WCDI_Bid3],[WCDI_Bid4],[WCDI_Bid5],[WCDI_Bid6],[WCDI_Award1],[WCDI_Award2],[WCDI_Award3],[WCDI_Award4],[WCDI_Award5],[WCDI_Award6],[WCDI_Status],[WCDI_Audit_Comment],[WCDI_Comment],[WCDI_PM00200_Vendor_ID7],[WCDI_PM00200_Vendor_ID8],[WCDI_PM00200_Vendor_ID9],[WCDI_PM00200_Vendor_ID10],[WCDI_Bid7],[WCDI_Bid8],[WCDI_Bid9],[WCDI_Bid10],[WCDI_Award7],[WCDI_Award8],[WCDI_Award9],[WCDI_Award10],[WCDI_Qty1],[WCDI_Qty2],[WCDI_Qty3],[WCDI_Qty4],[WCDI_Qty5],[WCDI_Qty6],[WCDI_Qty7],[WCDI_Qty8],[WCDI_Qty9],[WCDI_Qty10],[WCDI_PO1],[WCDI_PO2],[WCDI_PO3],[WCDI_PO4],[WCDI_PO5],[WCDI_PO6],[WCDI_PO7],[WCDI_PO8],[WCDI_PO9],[WCDI_PO10],[WCDI_Aw1],[WCDI_Aw2],[WCDI_Aw3],[WCDI_Aw4],[WCDI_Aw5],[WCDI_Aw6],[WCDI_Aw7],[WCDI_Aw8],[WCDI_Aw9],[WCDI_Aw10],[WCDI_Vat1],[WCDI_Vat2],[WCDI_Vat3],[WCDI_Vat4],[WCDI_Vat5],[WCDI_Vat6],[WCDI_Vat7],[WCDI_Vat8],[WCDI_Vat9],[WCDI_Vat10],[WCDI_Net1],[WCDI_Net2],[WCDI_Net3],[WCDI_Net4],[WCDI_Net5],[WCDI_Net6],[WCDI_Net7],[WCDI_Net8],[WCDI_Net9],[WCDI_Net10],[WCDI_WCur_ID1],[WCDI_WCur_ID2],[WCDI_WCur_ID3],[WCDI_WCur_ID4],[WCDI_WCur_ID5],[WCDI_WCur_ID6],[WCDI_WCur_ID7],[WCDI_WCur_ID8],[WCDI_WCur_ID9],[WCDI_WCur_ID10]) AS nvarchar(max)) 
            FROM [dbo].[WCanvass_Detail_Internal] with (rowlock, holdlock)
            WHERE [WCDI_ID] = @pk_WCDI_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WCanvass_Detail_Internal]
                    SET 
                    [WCDI_WCI_ID] = @p_WCDI_WCI_ID,
                    [WCDI_WPRL_ID] = @p_WCDI_WPRL_ID,
                    [WCDI_PM00200_Vendor_ID1] = @p_WCDI_PM00200_Vendor_ID1,
                    [WCDI_PM00200_Vendor_ID2] = @p_WCDI_PM00200_Vendor_ID2,
                    [WCDI_PM00200_Vendor_ID3] = @p_WCDI_PM00200_Vendor_ID3,
                    [WCDI_PM00200_Vendor_ID4] = @p_WCDI_PM00200_Vendor_ID4,
                    [WCDI_PM00200_Vendor_ID5] = @p_WCDI_PM00200_Vendor_ID5,
                    [WCDI_PM00200_Vendor_ID6] = @p_WCDI_PM00200_Vendor_ID6,
                    [WCDI_Bid1] = @p_WCDI_Bid1,
                    [WCDI_Bid2] = @p_WCDI_Bid2,
                    [WCDI_Bid3] = @p_WCDI_Bid3,
                    [WCDI_Bid4] = @p_WCDI_Bid4,
                    [WCDI_Bid5] = @p_WCDI_Bid5,
                    [WCDI_Bid6] = @p_WCDI_Bid6,
                    [WCDI_Award1] = @p_WCDI_Award1,
                    [WCDI_Award2] = @p_WCDI_Award2,
                    [WCDI_Award3] = @p_WCDI_Award3,
                    [WCDI_Award4] = @p_WCDI_Award4,
                    [WCDI_Award5] = @p_WCDI_Award5,
                    [WCDI_Award6] = @p_WCDI_Award6,
                    [WCDI_Status] = @p_WCDI_Status,
                    [WCDI_Audit_Comment] = @p_WCDI_Audit_Comment,
                    [WCDI_Comment] = @p_WCDI_Comment,
                    [WCDI_PM00200_Vendor_ID7] = @p_WCDI_PM00200_Vendor_ID7,
                    [WCDI_PM00200_Vendor_ID8] = @p_WCDI_PM00200_Vendor_ID8,
                    [WCDI_PM00200_Vendor_ID9] = @p_WCDI_PM00200_Vendor_ID9,
                    [WCDI_PM00200_Vendor_ID10] = @p_WCDI_PM00200_Vendor_ID10,
                    [WCDI_Bid7] = @p_WCDI_Bid7,
                    [WCDI_Bid8] = @p_WCDI_Bid8,
                    [WCDI_Bid9] = @p_WCDI_Bid9,
                    [WCDI_Bid10] = @p_WCDI_Bid10,
                    [WCDI_Award7] = @p_WCDI_Award7,
                    [WCDI_Award8] = @p_WCDI_Award8,
                    [WCDI_Award9] = @p_WCDI_Award9,
                    [WCDI_Award10] = @p_WCDI_Award10,
                    [WCDI_Qty1] = @p_WCDI_Qty1,
                    [WCDI_Qty2] = @p_WCDI_Qty2,
                    [WCDI_Qty3] = @p_WCDI_Qty3,
                    [WCDI_Qty4] = @p_WCDI_Qty4,
                    [WCDI_Qty5] = @p_WCDI_Qty5,
                    [WCDI_Qty6] = @p_WCDI_Qty6,
                    [WCDI_Qty7] = @p_WCDI_Qty7,
                    [WCDI_Qty8] = @p_WCDI_Qty8,
                    [WCDI_Qty9] = @p_WCDI_Qty9,
                    [WCDI_Qty10] = @p_WCDI_Qty10,
                    [WCDI_PO1] = @p_WCDI_PO1,
                    [WCDI_PO2] = @p_WCDI_PO2,
                    [WCDI_PO3] = @p_WCDI_PO3,
                    [WCDI_PO4] = @p_WCDI_PO4,
                    [WCDI_PO5] = @p_WCDI_PO5,
                    [WCDI_PO6] = @p_WCDI_PO6,
                    [WCDI_PO7] = @p_WCDI_PO7,
                    [WCDI_PO8] = @p_WCDI_PO8,
                    [WCDI_PO9] = @p_WCDI_PO9,
                    [WCDI_PO10] = @p_WCDI_PO10,
                    [WCDI_Aw1] = @p_WCDI_Aw1,
                    [WCDI_Aw2] = @p_WCDI_Aw2,
                    [WCDI_Aw3] = @p_WCDI_Aw3,
                    [WCDI_Aw4] = @p_WCDI_Aw4,
                    [WCDI_Aw5] = @p_WCDI_Aw5,
                    [WCDI_Aw6] = @p_WCDI_Aw6,
                    [WCDI_Aw7] = @p_WCDI_Aw7,
                    [WCDI_Aw8] = @p_WCDI_Aw8,
                    [WCDI_Aw9] = @p_WCDI_Aw9,
                    [WCDI_Aw10] = @p_WCDI_Aw10,
                    [WCDI_Vat1] = @p_WCDI_Vat1,
                    [WCDI_Vat2] = @p_WCDI_Vat2,
                    [WCDI_Vat3] = @p_WCDI_Vat3,
                    [WCDI_Vat4] = @p_WCDI_Vat4,
                    [WCDI_Vat5] = @p_WCDI_Vat5,
                    [WCDI_Vat6] = @p_WCDI_Vat6,
                    [WCDI_Vat7] = @p_WCDI_Vat7,
                    [WCDI_Vat8] = @p_WCDI_Vat8,
                    [WCDI_Vat9] = @p_WCDI_Vat9,
                    [WCDI_Vat10] = @p_WCDI_Vat10,
                    [WCDI_Net1] = @p_WCDI_Net1,
                    [WCDI_Net2] = @p_WCDI_Net2,
                    [WCDI_Net3] = @p_WCDI_Net3,
                    [WCDI_Net4] = @p_WCDI_Net4,
                    [WCDI_Net5] = @p_WCDI_Net5,
                    [WCDI_Net6] = @p_WCDI_Net6,
                    [WCDI_Net7] = @p_WCDI_Net7,
                    [WCDI_Net8] = @p_WCDI_Net8,
                    [WCDI_Net9] = @p_WCDI_Net9,
                    [WCDI_Net10] = @p_WCDI_Net10,
                    [WCDI_WCur_ID1] = @p_WCDI_WCur_ID1,
                    [WCDI_WCur_ID2] = @p_WCDI_WCur_ID2,
                    [WCDI_WCur_ID3] = @p_WCDI_WCur_ID3,
                    [WCDI_WCur_ID4] = @p_WCDI_WCur_ID4,
                    [WCDI_WCur_ID5] = @p_WCDI_WCur_ID5,
                    [WCDI_WCur_ID6] = @p_WCDI_WCur_ID6,
                    [WCDI_WCur_ID7] = @p_WCDI_WCur_ID7,
                    [WCDI_WCur_ID8] = @p_WCDI_WCur_ID8,
                    [WCDI_WCur_ID9] = @p_WCDI_WCur_ID9,
                    [WCDI_WCur_ID10] = @p_WCDI_WCur_ID10
                    WHERE [WCDI_ID] = @pk_WCDI_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WCanvass_Detail_Internal]', 16, 1)

        END
END

