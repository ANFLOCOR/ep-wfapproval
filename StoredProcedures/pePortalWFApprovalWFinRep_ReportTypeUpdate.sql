if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_ReportTypeUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_ReportTypeUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WFinRep_ReportType] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWFinRep_ReportTypeUpdate
    @p_WFRT_Type varchar(50),
    @pk_WFRT_Type varchar(50),
    @p_WFRT_Description varchar(350),
    @p_WFRT_SortOrder int,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WFinRep_ReportType] WHERE [WFRT_Type] = @pk_WFRT_Type)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WFinRep_ReportType]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WFinRep_ReportType]
            SET 
            [WFRT_Type] = @p_WFRT_Type,
            [WFRT_Description] = @p_WFRT_Description,
            [WFRT_SortOrder] = @p_WFRT_SortOrder
            WHERE [WFRT_Type] = @pk_WFRT_Type

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WFRT_Type],[WFRT_Description],[WFRT_SortOrder]) AS nvarchar(max)) 
            FROM [dbo].[WFinRep_ReportType] with (rowlock, holdlock)
            WHERE [WFRT_Type] = @pk_WFRT_Type


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WFinRep_ReportType]
                    SET 
                    [WFRT_Type] = @p_WFRT_Type,
                    [WFRT_Description] = @p_WFRT_Description,
                    [WFRT_SortOrder] = @p_WFRT_SortOrder
                    WHERE [WFRT_Type] = @pk_WFRT_Type

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WFinRep_ReportType]', 16, 1)

        END
END

