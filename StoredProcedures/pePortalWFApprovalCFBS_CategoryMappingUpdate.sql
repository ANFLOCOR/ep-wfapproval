if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalCFBS_CategoryMappingUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalCFBS_CategoryMappingUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[CFBS_CategoryMapping] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalCFBS_CategoryMappingUpdate
    @pk_MapID int,
    @p_IsPrimary bit,
    @p_BS_OrderNo int,
    @p_CF_OrderNo int,
    @p_Ref_BS_OrderNo int,
    @p_ActIndx int,
    @p_CreatedBy varchar(20),
    @p_DateCreated datetime,
    @p_ModifiedBy varchar(20),
    @p_DateModified datetime,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[CFBS_CategoryMapping] WHERE [MapID] = @pk_MapID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[CFBS_CategoryMapping]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[CFBS_CategoryMapping]
            SET 
            [IsPrimary] = @p_IsPrimary,
            [BS_OrderNo] = @p_BS_OrderNo,
            [CF_OrderNo] = @p_CF_OrderNo,
            [Ref_BS_OrderNo] = @p_Ref_BS_OrderNo,
            [ActIndx] = @p_ActIndx,
            [CreatedBy] = @p_CreatedBy,
            [DateCreated] = @p_DateCreated,
            [ModifiedBy] = @p_ModifiedBy,
            [DateModified] = @p_DateModified
            WHERE [MapID] = @pk_MapID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([MapID],[IsPrimary],[BS_OrderNo],[CF_OrderNo],[Ref_BS_OrderNo],[ActIndx],[CreatedBy],[DateCreated],[ModifiedBy],[DateModified]) AS nvarchar(max)) 
            FROM [dbo].[CFBS_CategoryMapping] with (rowlock, holdlock)
            WHERE [MapID] = @pk_MapID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[CFBS_CategoryMapping]
                    SET 
                    [IsPrimary] = @p_IsPrimary,
                    [BS_OrderNo] = @p_BS_OrderNo,
                    [CF_OrderNo] = @p_CF_OrderNo,
                    [Ref_BS_OrderNo] = @p_Ref_BS_OrderNo,
                    [ActIndx] = @p_ActIndx,
                    [CreatedBy] = @p_CreatedBy,
                    [DateCreated] = @p_DateCreated,
                    [ModifiedBy] = @p_ModifiedBy,
                    [DateModified] = @p_DateModified
                    WHERE [MapID] = @pk_MapID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[CFBS_CategoryMapping]', 16, 1)

        END
END

