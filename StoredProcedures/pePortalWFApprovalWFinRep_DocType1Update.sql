if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_DocType1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_DocType1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WFinRep_DocType] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWFinRep_DocType1Update
    @pk_WFIN_DT_ID int,
    @p_WFIN_DT_C_ID smallint,
    @p_WFIN_DT_Name varchar(100),
    @p_WFIN_DT_Desc varchar(250),
    @p_WFIN_DT_Type varchar(50),
    @p_WFIN_DT_Minimum numeric(18,2),
    @p_WFIN_DT_Maximum numeric(18,2),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WFinRep_DocType] WHERE [WFIN_DT_ID] = @pk_WFIN_DT_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WFinRep_DocType]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WFinRep_DocType]
            SET 
            [WFIN_DT_C_ID] = @p_WFIN_DT_C_ID,
            [WFIN_DT_Name] = @p_WFIN_DT_Name,
            [WFIN_DT_Desc] = @p_WFIN_DT_Desc,
            [WFIN_DT_Type] = @p_WFIN_DT_Type,
            [WFIN_DT_Minimum] = @p_WFIN_DT_Minimum,
            [WFIN_DT_Maximum] = @p_WFIN_DT_Maximum
            WHERE [WFIN_DT_ID] = @pk_WFIN_DT_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WFIN_DT_ID],[WFIN_DT_C_ID],[WFIN_DT_Name],[WFIN_DT_Desc],[WFIN_DT_Type],[WFIN_DT_Minimum],[WFIN_DT_Maximum]) AS nvarchar(max)) 
            FROM [dbo].[WFinRep_DocType] with (rowlock, holdlock)
            WHERE [WFIN_DT_ID] = @pk_WFIN_DT_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WFinRep_DocType]
                    SET 
                    [WFIN_DT_C_ID] = @p_WFIN_DT_C_ID,
                    [WFIN_DT_Name] = @p_WFIN_DT_Name,
                    [WFIN_DT_Desc] = @p_WFIN_DT_Desc,
                    [WFIN_DT_Type] = @p_WFIN_DT_Type,
                    [WFIN_DT_Minimum] = @p_WFIN_DT_Minimum,
                    [WFIN_DT_Maximum] = @p_WFIN_DT_Maximum
                    WHERE [WFIN_DT_ID] = @pk_WFIN_DT_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WFinRep_DocType]', 16, 1)

        END
END

