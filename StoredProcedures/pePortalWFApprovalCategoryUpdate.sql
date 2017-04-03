if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalCategoryUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalCategoryUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[Category] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalCategoryUpdate
    @pk_ID int,
    @p_Accatnum int,
    @p_Accatdesc varchar(1000),
    @p_TypicalBalance int,
    @p_Orderno int,
    @p_Orderno1 int,
    @p_ReportID int,
    @p_LevelNo int,
    @p_Level1 varchar(500),
    @p_Level1_Ord int,
    @p_Level2 varchar(500),
    @p_Level2_Ord int,
    @p_Indent int,
    @p_CreatedBy int,
    @p_DateCreated datetime,
    @p_ModifiedBy int,
    @p_DateModified datetime,
    @p_IsPrimary bit,
    @p_TotalOf varchar(1000),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[Category] WHERE [ID] = @pk_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[Category]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[Category]
            SET 
            [Accatnum] = @p_Accatnum,
            [Accatdesc] = @p_Accatdesc,
            [TypicalBalance] = @p_TypicalBalance,
            [Orderno] = @p_Orderno,
            [Orderno1] = @p_Orderno1,
            [ReportID] = @p_ReportID,
            [LevelNo] = @p_LevelNo,
            [Level1] = @p_Level1,
            [Level1_Ord] = @p_Level1_Ord,
            [Level2] = @p_Level2,
            [Level2_Ord] = @p_Level2_Ord,
            [Indent] = @p_Indent,
            [CreatedBy] = @p_CreatedBy,
            [DateCreated] = @p_DateCreated,
            [ModifiedBy] = @p_ModifiedBy,
            [DateModified] = @p_DateModified,
            [IsPrimary] = @p_IsPrimary,
            [TotalOf] = @p_TotalOf
            WHERE [ID] = @pk_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([ID],[Accatnum],[Accatdesc],[TypicalBalance],[Orderno],[Orderno1],[ReportID],[LevelNo],[Level1],[Level1_Ord],[Level2],[Level2_Ord],[Indent],[CreatedBy],[DateCreated],[ModifiedBy],[DateModified],[IsPrimary],[TotalOf]) AS nvarchar(max)) 
            FROM [dbo].[Category] with (rowlock, holdlock)
            WHERE [ID] = @pk_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[Category]
                    SET 
                    [Accatnum] = @p_Accatnum,
                    [Accatdesc] = @p_Accatdesc,
                    [TypicalBalance] = @p_TypicalBalance,
                    [Orderno] = @p_Orderno,
                    [Orderno1] = @p_Orderno1,
                    [ReportID] = @p_ReportID,
                    [LevelNo] = @p_LevelNo,
                    [Level1] = @p_Level1,
                    [Level1_Ord] = @p_Level1_Ord,
                    [Level2] = @p_Level2,
                    [Level2_Ord] = @p_Level2_Ord,
                    [Indent] = @p_Indent,
                    [CreatedBy] = @p_CreatedBy,
                    [DateCreated] = @p_DateCreated,
                    [ModifiedBy] = @p_ModifiedBy,
                    [DateModified] = @p_DateModified,
                    [IsPrimary] = @p_IsPrimary,
                    [TotalOf] = @p_TotalOf
                    WHERE [ID] = @pk_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[Category]', 16, 1)

        END
END

