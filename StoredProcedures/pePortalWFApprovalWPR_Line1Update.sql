if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_Line1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_Line1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WPR_Line] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWPR_Line1Update
    @pk_WPRL_ID int,
    @p_WPRL_WPRD_ID int,
    @p_WPRL_IV00101_Item_No char(31),
    @p_WPRL_IV40700_Locn_Code char(11),
    @p_WPRL_PM00200_Vendor_ID char(15),
    @p_WPRL_GL00101_Acct_Indx int,
    @p_WPRL_IV00101_Prchs_UOM char(10),
    @p_WPRL_Line_Seq_No int,
    @p_WPRL_Item_Comment varchar(500),
    @p_WPRL_Item_Text varchar(500),
    @p_WPRL_Item_Desc varchar(500),
    @p_WPRL_Item_Non_Inv varchar(500),
    @p_WPRL_Required_Date smalldatetime,
    @p_WPRL_Unit_Price numeric(18,5),
    @p_WPRL_Qty numeric(18,5),
    @p_WPRL_Ext_Price numeric(18,5),
    @p_WPRL_WPRLS_ID smallint,
    @p_WPRL_PO_No varchar(30),
    @p_WPRL_PO_Line_Seq_No int,
    @p_WPRL_Item_Non_Inv_UOM varchar(20),
    @p_WPRL_Vendor_Name varchar(250),
    @p_WPRL_Account varchar(50),
    @p_WPRL_WClass_ID int,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WPR_Line] WHERE [WPRL_ID] = @pk_WPRL_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WPR_Line]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WPR_Line]
            SET 
            [WPRL_WPRD_ID] = @p_WPRL_WPRD_ID,
            [WPRL_IV00101_Item_No] = @p_WPRL_IV00101_Item_No,
            [WPRL_IV40700_Locn_Code] = @p_WPRL_IV40700_Locn_Code,
            [WPRL_PM00200_Vendor_ID] = @p_WPRL_PM00200_Vendor_ID,
            [WPRL_GL00101_Acct_Indx] = @p_WPRL_GL00101_Acct_Indx,
            [WPRL_IV00101_Prchs_UOM] = @p_WPRL_IV00101_Prchs_UOM,
            [WPRL_Line_Seq_No] = @p_WPRL_Line_Seq_No,
            [WPRL_Item_Comment] = @p_WPRL_Item_Comment,
            [WPRL_Item_Text] = @p_WPRL_Item_Text,
            [WPRL_Item_Desc] = @p_WPRL_Item_Desc,
            [WPRL_Item_Non_Inv] = @p_WPRL_Item_Non_Inv,
            [WPRL_Required_Date] = @p_WPRL_Required_Date,
            [WPRL_Unit_Price] = @p_WPRL_Unit_Price,
            [WPRL_Qty] = @p_WPRL_Qty,
            [WPRL_Ext_Price] = @p_WPRL_Ext_Price,
            [WPRL_WPRLS_ID] = @p_WPRL_WPRLS_ID,
            [WPRL_PO_No] = @p_WPRL_PO_No,
            [WPRL_PO_Line_Seq_No] = @p_WPRL_PO_Line_Seq_No,
            [WPRL_Item_Non_Inv_UOM] = @p_WPRL_Item_Non_Inv_UOM,
            [WPRL_Vendor_Name] = @p_WPRL_Vendor_Name,
            [WPRL_Account] = @p_WPRL_Account,
            [WPRL_WClass_ID] = @p_WPRL_WClass_ID
            WHERE [WPRL_ID] = @pk_WPRL_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WPRL_ID],[WPRL_WPRD_ID],[WPRL_IV00101_Item_No],[WPRL_IV40700_Locn_Code],[WPRL_PM00200_Vendor_ID],[WPRL_GL00101_Acct_Indx],[WPRL_IV00101_Prchs_UOM],[WPRL_Line_Seq_No],[WPRL_Item_Comment],[WPRL_Item_Text],[WPRL_Item_Desc],[WPRL_Item_Non_Inv],[WPRL_Required_Date],[WPRL_Unit_Price],[WPRL_Qty],[WPRL_Ext_Price],[WPRL_WPRLS_ID],[WPRL_PO_No],[WPRL_PO_Line_Seq_No],[WPRL_Item_Non_Inv_UOM],[WPRL_Vendor_Name],[WPRL_Account],[WPRL_WClass_ID]) AS nvarchar(max)) 
            FROM [dbo].[WPR_Line] with (rowlock, holdlock)
            WHERE [WPRL_ID] = @pk_WPRL_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WPR_Line]
                    SET 
                    [WPRL_WPRD_ID] = @p_WPRL_WPRD_ID,
                    [WPRL_IV00101_Item_No] = @p_WPRL_IV00101_Item_No,
                    [WPRL_IV40700_Locn_Code] = @p_WPRL_IV40700_Locn_Code,
                    [WPRL_PM00200_Vendor_ID] = @p_WPRL_PM00200_Vendor_ID,
                    [WPRL_GL00101_Acct_Indx] = @p_WPRL_GL00101_Acct_Indx,
                    [WPRL_IV00101_Prchs_UOM] = @p_WPRL_IV00101_Prchs_UOM,
                    [WPRL_Line_Seq_No] = @p_WPRL_Line_Seq_No,
                    [WPRL_Item_Comment] = @p_WPRL_Item_Comment,
                    [WPRL_Item_Text] = @p_WPRL_Item_Text,
                    [WPRL_Item_Desc] = @p_WPRL_Item_Desc,
                    [WPRL_Item_Non_Inv] = @p_WPRL_Item_Non_Inv,
                    [WPRL_Required_Date] = @p_WPRL_Required_Date,
                    [WPRL_Unit_Price] = @p_WPRL_Unit_Price,
                    [WPRL_Qty] = @p_WPRL_Qty,
                    [WPRL_Ext_Price] = @p_WPRL_Ext_Price,
                    [WPRL_WPRLS_ID] = @p_WPRL_WPRLS_ID,
                    [WPRL_PO_No] = @p_WPRL_PO_No,
                    [WPRL_PO_Line_Seq_No] = @p_WPRL_PO_Line_Seq_No,
                    [WPRL_Item_Non_Inv_UOM] = @p_WPRL_Item_Non_Inv_UOM,
                    [WPRL_Vendor_Name] = @p_WPRL_Vendor_Name,
                    [WPRL_Account] = @p_WPRL_Account,
                    [WPRL_WClass_ID] = @p_WPRL_WClass_ID
                    WHERE [WPRL_ID] = @pk_WPRL_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WPR_Line]', 16, 1)

        END
END

