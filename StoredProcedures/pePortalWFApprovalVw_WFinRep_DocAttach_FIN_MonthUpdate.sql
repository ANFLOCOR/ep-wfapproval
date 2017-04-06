if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_WFinRep_DocAttach_FIN_MonthUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_WFinRep_DocAttach_FIN_MonthUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[vw_WFinRep_DocAttach_FIN_Month] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalVw_WFinRep_DocAttach_FIN_MonthUpdate
    @p_Mo int,
    @pk_Mo int,
    @p_MoName nvarchar(30),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[vw_WFinRep_DocAttach_FIN_Month] WHERE [Mo] = @pk_Mo)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[vw_WFinRep_DocAttach_FIN_Month]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[vw_WFinRep_DocAttach_FIN_Month]
            SET 
            [Mo] = @p_Mo,
            [MoName] = @p_MoName
            WHERE [Mo] = @pk_Mo

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([Mo],[MoName]) AS nvarchar(max)) 
            FROM [dbo].[vw_WFinRep_DocAttach_FIN_Month] with (rowlock, holdlock)
            WHERE [Mo] = @pk_Mo


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[vw_WFinRep_DocAttach_FIN_Month]
                    SET 
                    [Mo] = @p_Mo,
                    [MoName] = @p_MoName
                    WHERE [Mo] = @pk_Mo

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[vw_WFinRep_DocAttach_FIN_Month]', 16, 1)

        END
END

