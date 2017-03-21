if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_PO_Map1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_PO_Map1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WCanvass_PO_Map] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWCanvass_PO_Map1Update
    @pk_WCPOM_ID int,
    @p_WCPOM_C_ID smallint,
    @p_WCPOM_WCDI_ID int,
    @p_WCPOM_WPRD_ID int,
    @p_WCPOM_WPRL_ID int,
    @p_WCPOM_U_ID int,
    @p_WCPOM_PO_No char(17),
    @p_WCPOM_Date smalldatetime,
    @p_WCPOM_PM00200_Vendor char(15),
    @p_WCPOM_Bid numeric(18,5),
    @p_WCPOM_Qty numeric(18,4),
    @p_WCPOM_PO_Line smallint,
    @p_WCPOM_Col_Marker int,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WCanvass_PO_Map] WHERE [WCPOM_ID] = @pk_WCPOM_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WCanvass_PO_Map]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WCanvass_PO_Map]
            SET 
            [WCPOM_C_ID] = @p_WCPOM_C_ID,
            [WCPOM_WCDI_ID] = @p_WCPOM_WCDI_ID,
            [WCPOM_WPRD_ID] = @p_WCPOM_WPRD_ID,
            [WCPOM_WPRL_ID] = @p_WCPOM_WPRL_ID,
            [WCPOM_U_ID] = @p_WCPOM_U_ID,
            [WCPOM_PO_No] = @p_WCPOM_PO_No,
            [WCPOM_Date] = @p_WCPOM_Date,
            [WCPOM_PM00200_Vendor] = @p_WCPOM_PM00200_Vendor,
            [WCPOM_Bid] = @p_WCPOM_Bid,
            [WCPOM_Qty] = @p_WCPOM_Qty,
            [WCPOM_PO_Line] = @p_WCPOM_PO_Line,
            [WCPOM_Col_Marker] = @p_WCPOM_Col_Marker
            WHERE [WCPOM_ID] = @pk_WCPOM_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WCPOM_ID],[WCPOM_C_ID],[WCPOM_WCDI_ID],[WCPOM_WPRD_ID],[WCPOM_WPRL_ID],[WCPOM_U_ID],[WCPOM_PO_No],[WCPOM_Date],[WCPOM_PM00200_Vendor],[WCPOM_Bid],[WCPOM_Qty],[WCPOM_PO_Line],[WCPOM_Col_Marker]) AS nvarchar(max)) 
            FROM [dbo].[WCanvass_PO_Map] with (rowlock, holdlock)
            WHERE [WCPOM_ID] = @pk_WCPOM_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WCanvass_PO_Map]
                    SET 
                    [WCPOM_C_ID] = @p_WCPOM_C_ID,
                    [WCPOM_WCDI_ID] = @p_WCPOM_WCDI_ID,
                    [WCPOM_WPRD_ID] = @p_WCPOM_WPRD_ID,
                    [WCPOM_WPRL_ID] = @p_WCPOM_WPRL_ID,
                    [WCPOM_U_ID] = @p_WCPOM_U_ID,
                    [WCPOM_PO_No] = @p_WCPOM_PO_No,
                    [WCPOM_Date] = @p_WCPOM_Date,
                    [WCPOM_PM00200_Vendor] = @p_WCPOM_PM00200_Vendor,
                    [WCPOM_Bid] = @p_WCPOM_Bid,
                    [WCPOM_Qty] = @p_WCPOM_Qty,
                    [WCPOM_PO_Line] = @p_WCPOM_PO_Line,
                    [WCPOM_Col_Marker] = @p_WCPOM_Col_Marker
                    WHERE [WCPOM_ID] = @pk_WCPOM_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WCanvass_PO_Map]', 16, 1)

        END
END

