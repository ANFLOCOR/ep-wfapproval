if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_PO_Map_Temp1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_PO_Map_Temp1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WCanvass_PO_Map_Temp] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWCanvass_PO_Map_Temp1Update
    @pk_Temp_ID int,
    @p_WCDI_ID int,
    @p_WCDI_WCI_ID int,
    @p_WCDI_WPRL_ID int,
    @p_WCDI_Status varchar(20),
    @p_WCDI_Audit_Comment varchar(500),
    @p_WCDI_Comment varchar(500),
    @p_WCDI_PM00200_Vendor char(15),
    @p_WCDI_Qty numeric(18,4),
    @p_WCDI_Bid numeric(18,5),
    @p_WCDI_Award bit,
    @p_WPRL_WPRD_ID int,
    @p_Item char(31),
    @p_ItemDescription varchar(500),
    @p_UnitOfMeasure varchar(20),
    @p_Site char(11),
    @p_UnitPrice numeric(18,5),
    @p_WPRL_Qty numeric(18,5),
    @p_WPRL_Ext_Price numeric(18,5),
    @p_WCI_C_ID smallint,
    @p_WCI_Status varchar(20),
    @p_WCI_U_ID int,
    @p_WCI_WClass_ID int,
    @p_WPRD_Created smalldatetime,
    @p_WCI_Date smalldatetime,
    @p_Offered_Qty numeric(38,9),
    @p_Balance_Qty numeric(38,9),
    @p_WCDI_Vat bit,
    @p_WCDI_Net numeric(18,5),
    @p_WCDI_WCur_ID smallint,
    @p_WPRD_Contract bit,
    @p_WCI_Contract_Done bit,
    @p_WCI_Contract_Closed smalldatetime,
    @p_WCI_Contract_U_ID int,
    @p_Col_Marker int,
    @p_Status varchar(7),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WCanvass_PO_Map_Temp] WHERE [Temp_ID] = @pk_Temp_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WCanvass_PO_Map_Temp]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WCanvass_PO_Map_Temp]
            SET 
            [WCDI_ID] = @p_WCDI_ID,
            [WCDI_WCI_ID] = @p_WCDI_WCI_ID,
            [WCDI_WPRL_ID] = @p_WCDI_WPRL_ID,
            [WCDI_Status] = @p_WCDI_Status,
            [WCDI_Audit_Comment] = @p_WCDI_Audit_Comment,
            [WCDI_Comment] = @p_WCDI_Comment,
            [WCDI_PM00200_Vendor] = @p_WCDI_PM00200_Vendor,
            [WCDI_Qty] = @p_WCDI_Qty,
            [WCDI_Bid] = @p_WCDI_Bid,
            [WCDI_Award] = @p_WCDI_Award,
            [WPRL_WPRD_ID] = @p_WPRL_WPRD_ID,
            [Item] = @p_Item,
            [ItemDescription] = @p_ItemDescription,
            [UnitOfMeasure] = @p_UnitOfMeasure,
            [Site] = @p_Site,
            [UnitPrice] = @p_UnitPrice,
            [WPRL_Qty] = @p_WPRL_Qty,
            [WPRL_Ext_Price] = @p_WPRL_Ext_Price,
            [WCI_C_ID] = @p_WCI_C_ID,
            [WCI_Status] = @p_WCI_Status,
            [WCI_U_ID] = @p_WCI_U_ID,
            [WCI_WClass_ID] = @p_WCI_WClass_ID,
            [WPRD_Created] = @p_WPRD_Created,
            [WCI_Date] = @p_WCI_Date,
            [Offered_Qty] = @p_Offered_Qty,
            [Balance_Qty] = @p_Balance_Qty,
            [WCDI_Vat] = @p_WCDI_Vat,
            [WCDI_Net] = @p_WCDI_Net,
            [WCDI_WCur_ID] = @p_WCDI_WCur_ID,
            [WPRD_Contract] = @p_WPRD_Contract,
            [WCI_Contract_Done] = @p_WCI_Contract_Done,
            [WCI_Contract_Closed] = @p_WCI_Contract_Closed,
            [WCI_Contract_U_ID] = @p_WCI_Contract_U_ID,
            [Col_Marker] = @p_Col_Marker,
            [Status] = @p_Status
            WHERE [Temp_ID] = @pk_Temp_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([Temp_ID],[WCDI_ID],[WCDI_WCI_ID],[WCDI_WPRL_ID],[WCDI_Status],[WCDI_Audit_Comment],[WCDI_Comment],[WCDI_PM00200_Vendor],[WCDI_Qty],[WCDI_Bid],[WCDI_Award],[WPRL_WPRD_ID],[Item],[ItemDescription],[UnitOfMeasure],[Site],[UnitPrice],[WPRL_Qty],[WPRL_Ext_Price],[WCI_C_ID],[WCI_Status],[WCI_U_ID],[WCI_WClass_ID],[WPRD_Created],[WCI_Date],[Offered_Qty],[Balance_Qty],[WCDI_Vat],[WCDI_Net],[WCDI_WCur_ID],[WPRD_Contract],[WCI_Contract_Done],[WCI_Contract_Closed],[WCI_Contract_U_ID],[Col_Marker],[Status]) AS nvarchar(max)) 
            FROM [dbo].[WCanvass_PO_Map_Temp] with (rowlock, holdlock)
            WHERE [Temp_ID] = @pk_Temp_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WCanvass_PO_Map_Temp]
                    SET 
                    [WCDI_ID] = @p_WCDI_ID,
                    [WCDI_WCI_ID] = @p_WCDI_WCI_ID,
                    [WCDI_WPRL_ID] = @p_WCDI_WPRL_ID,
                    [WCDI_Status] = @p_WCDI_Status,
                    [WCDI_Audit_Comment] = @p_WCDI_Audit_Comment,
                    [WCDI_Comment] = @p_WCDI_Comment,
                    [WCDI_PM00200_Vendor] = @p_WCDI_PM00200_Vendor,
                    [WCDI_Qty] = @p_WCDI_Qty,
                    [WCDI_Bid] = @p_WCDI_Bid,
                    [WCDI_Award] = @p_WCDI_Award,
                    [WPRL_WPRD_ID] = @p_WPRL_WPRD_ID,
                    [Item] = @p_Item,
                    [ItemDescription] = @p_ItemDescription,
                    [UnitOfMeasure] = @p_UnitOfMeasure,
                    [Site] = @p_Site,
                    [UnitPrice] = @p_UnitPrice,
                    [WPRL_Qty] = @p_WPRL_Qty,
                    [WPRL_Ext_Price] = @p_WPRL_Ext_Price,
                    [WCI_C_ID] = @p_WCI_C_ID,
                    [WCI_Status] = @p_WCI_Status,
                    [WCI_U_ID] = @p_WCI_U_ID,
                    [WCI_WClass_ID] = @p_WCI_WClass_ID,
                    [WPRD_Created] = @p_WPRD_Created,
                    [WCI_Date] = @p_WCI_Date,
                    [Offered_Qty] = @p_Offered_Qty,
                    [Balance_Qty] = @p_Balance_Qty,
                    [WCDI_Vat] = @p_WCDI_Vat,
                    [WCDI_Net] = @p_WCDI_Net,
                    [WCDI_WCur_ID] = @p_WCDI_WCur_ID,
                    [WPRD_Contract] = @p_WPRD_Contract,
                    [WCI_Contract_Done] = @p_WCI_Contract_Done,
                    [WCI_Contract_Closed] = @p_WCI_Contract_Closed,
                    [WCI_Contract_U_ID] = @p_WCI_Contract_U_ID,
                    [Col_Marker] = @p_Col_Marker,
                    [Status] = @p_Status
                    WHERE [Temp_ID] = @pk_Temp_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WCanvass_PO_Map_Temp]', 16, 1)

        END
END

