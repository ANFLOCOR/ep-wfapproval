if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_InternalUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_InternalUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WCanvass_Internal] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWCanvass_InternalUpdate
    @pk_WCI_ID int,
    @p_WCI_C_ID smallint,
    @p_WCI_WPRD_ID int,
    @p_WCI_Date smalldatetime,
    @p_WCI_Submit bit,
    @p_WCI_Status varchar(20),
    @p_WCI_Vendors smallint,
    @p_WCI_U_ID int,
    @p_WCI_WClass_ID int,
    @p_WCI_Contract_Done bit,
    @p_WCI_Contract_Closed smalldatetime,
    @p_WCI_Contract_U_ID int,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WCanvass_Internal] WHERE [WCI_ID] = @pk_WCI_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WCanvass_Internal]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WCanvass_Internal]
            SET 
            [WCI_C_ID] = @p_WCI_C_ID,
            [WCI_WPRD_ID] = @p_WCI_WPRD_ID,
            [WCI_Date] = @p_WCI_Date,
            [WCI_Submit] = @p_WCI_Submit,
            [WCI_Status] = @p_WCI_Status,
            [WCI_Vendors] = @p_WCI_Vendors,
            [WCI_U_ID] = @p_WCI_U_ID,
            [WCI_WClass_ID] = @p_WCI_WClass_ID,
            [WCI_Contract_Done] = @p_WCI_Contract_Done,
            [WCI_Contract_Closed] = @p_WCI_Contract_Closed,
            [WCI_Contract_U_ID] = @p_WCI_Contract_U_ID
            WHERE [WCI_ID] = @pk_WCI_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WCI_ID],[WCI_C_ID],[WCI_WPRD_ID],[WCI_Date],[WCI_Submit],[WCI_Status],[WCI_Vendors],[WCI_U_ID],[WCI_WClass_ID],[WCI_Contract_Done],[WCI_Contract_Closed],[WCI_Contract_U_ID]) AS nvarchar(max)) 
            FROM [dbo].[WCanvass_Internal] with (rowlock, holdlock)
            WHERE [WCI_ID] = @pk_WCI_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WCanvass_Internal]
                    SET 
                    [WCI_C_ID] = @p_WCI_C_ID,
                    [WCI_WPRD_ID] = @p_WCI_WPRD_ID,
                    [WCI_Date] = @p_WCI_Date,
                    [WCI_Submit] = @p_WCI_Submit,
                    [WCI_Status] = @p_WCI_Status,
                    [WCI_Vendors] = @p_WCI_Vendors,
                    [WCI_U_ID] = @p_WCI_U_ID,
                    [WCI_WClass_ID] = @p_WCI_WClass_ID,
                    [WCI_Contract_Done] = @p_WCI_Contract_Done,
                    [WCI_Contract_Closed] = @p_WCI_Contract_Closed,
                    [WCI_Contract_U_ID] = @p_WCI_Contract_U_ID
                    WHERE [WCI_ID] = @pk_WCI_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WCanvass_Internal]', 16, 1)

        END
END

