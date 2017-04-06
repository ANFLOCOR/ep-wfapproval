if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_Quotation_Internal1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_Quotation_Internal1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WCanvass_Quotation_Internal] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWCanvass_Quotation_Internal1Update
    @pk_WCQI_ID int,
    @p_WCQI_WCI_ID int,
    @p_WCQI_Desc varchar(250),
    @p_WCQI_File image,
    @p_WCQI_PM00200_Vendor_ID char(15),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WCanvass_Quotation_Internal] WHERE [WCQI_ID] = @pk_WCQI_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WCanvass_Quotation_Internal]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WCanvass_Quotation_Internal]
            SET 
            [WCQI_WCI_ID] = @p_WCQI_WCI_ID,
            [WCQI_Desc] = @p_WCQI_Desc,
            [WCQI_File] = @p_WCQI_File,
            [WCQI_PM00200_Vendor_ID] = @p_WCQI_PM00200_Vendor_ID
            WHERE [WCQI_ID] = @pk_WCQI_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WCQI_ID],[WCQI_WCI_ID],[WCQI_Desc],[WCQI_File],[WCQI_PM00200_Vendor_ID]) AS nvarchar(max)) 
            FROM [dbo].[WCanvass_Quotation_Internal] with (rowlock, holdlock)
            WHERE [WCQI_ID] = @pk_WCQI_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WCanvass_Quotation_Internal]
                    SET 
                    [WCQI_WCI_ID] = @p_WCQI_WCI_ID,
                    [WCQI_Desc] = @p_WCQI_Desc,
                    [WCQI_File] = @p_WCQI_File,
                    [WCQI_PM00200_Vendor_ID] = @p_WCQI_PM00200_Vendor_ID
                    WHERE [WCQI_ID] = @pk_WCQI_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WCanvass_Quotation_Internal]', 16, 1)

        END
END

