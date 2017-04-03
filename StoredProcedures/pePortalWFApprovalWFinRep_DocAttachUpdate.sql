if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_DocAttachUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_DocAttachUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WFinRep_DocAttach] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWFinRep_DocAttachUpdate
    @pk_FIN_ID int,
    @p_FIN_Year int,
    @p_FIN_Month int,
    @p_FIN_Type nvarchar(10),
    @p_FIn_Description nvarchar(250),
    @p_FIN_File image,
    @p_FIN_Company smallint,
    @p_FIN_Status int,
    @p_FIN_File1 nvarchar(100),
    @p_FIN_RptID int,
    @p_FIN_Post bit,
    @p_FIN_RWRem nvarchar(50),
    @p_FIN_HFIN_ID int,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WFinRep_DocAttach] WHERE [FIN_ID] = @pk_FIN_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WFinRep_DocAttach]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WFinRep_DocAttach]
            SET 
            [FIN_Year] = @p_FIN_Year,
            [FIN_Month] = @p_FIN_Month,
            [FIN_Type] = @p_FIN_Type,
            [FIn_Description] = @p_FIn_Description,
            [FIN_File] = @p_FIN_File,
            [FIN_Company] = @p_FIN_Company,
            [FIN_Status] = @p_FIN_Status,
            [FIN_File1] = @p_FIN_File1,
            [FIN_RptID] = @p_FIN_RptID,
            [FIN_Post] = @p_FIN_Post,
            [FIN_RWRem] = @p_FIN_RWRem,
            [FIN_HFIN_ID] = @p_FIN_HFIN_ID
            WHERE [FIN_ID] = @pk_FIN_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([FIN_ID],[FIN_Year],[FIN_Month],[FIN_Type],[FIn_Description],[FIN_File],[FIN_Company],[FIN_Status],[FIN_File1],[FIN_RptID],[FIN_Post],[FIN_RWRem],[FIN_HFIN_ID]) AS nvarchar(max)) 
            FROM [dbo].[WFinRep_DocAttach] with (rowlock, holdlock)
            WHERE [FIN_ID] = @pk_FIN_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WFinRep_DocAttach]
                    SET 
                    [FIN_Year] = @p_FIN_Year,
                    [FIN_Month] = @p_FIN_Month,
                    [FIN_Type] = @p_FIN_Type,
                    [FIn_Description] = @p_FIn_Description,
                    [FIN_File] = @p_FIN_File,
                    [FIN_Company] = @p_FIN_Company,
                    [FIN_Status] = @p_FIN_Status,
                    [FIN_File1] = @p_FIN_File1,
                    [FIN_RptID] = @p_FIN_RptID,
                    [FIN_Post] = @p_FIN_Post,
                    [FIN_RWRem] = @p_FIN_RWRem,
                    [FIN_HFIN_ID] = @p_FIN_HFIN_ID
                    WHERE [FIN_ID] = @pk_FIN_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WFinRep_DocAttach]', 16, 1)

        END
END

