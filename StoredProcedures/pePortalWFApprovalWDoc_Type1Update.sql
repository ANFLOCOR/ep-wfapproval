if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWDoc_Type1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWDoc_Type1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WDoc_Type] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWDoc_Type1Update
    @pk_WDT_ID int,
    @p_WDT_C_ID smallint,
    @p_WDT_Name varchar(100),
    @p_WDT_Desc varchar(250),
    @p_WDT_Type varchar(5),
    @p_WDT_Limit numeric(18,2),
    @p_WDT_Minimum numeric(18,2),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WDoc_Type] WHERE [WDT_ID] = @pk_WDT_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WDoc_Type]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WDoc_Type]
            SET 
            [WDT_C_ID] = @p_WDT_C_ID,
            [WDT_Name] = @p_WDT_Name,
            [WDT_Desc] = @p_WDT_Desc,
            [WDT_Type] = @p_WDT_Type,
            [WDT_Limit] = @p_WDT_Limit,
            [WDT_Minimum] = @p_WDT_Minimum
            WHERE [WDT_ID] = @pk_WDT_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WDT_ID],[WDT_C_ID],[WDT_Name],[WDT_Desc],[WDT_Type],[WDT_Limit],[WDT_Minimum]) AS nvarchar(max)) 
            FROM [dbo].[WDoc_Type] with (rowlock, holdlock)
            WHERE [WDT_ID] = @pk_WDT_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WDoc_Type]
                    SET 
                    [WDT_C_ID] = @p_WDT_C_ID,
                    [WDT_Name] = @p_WDT_Name,
                    [WDT_Desc] = @p_WDT_Desc,
                    [WDT_Type] = @p_WDT_Type,
                    [WDT_Limit] = @p_WDT_Limit,
                    [WDT_Minimum] = @p_WDT_Minimum
                    WHERE [WDT_ID] = @pk_WDT_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WDoc_Type]', 16, 1)

        END
END

