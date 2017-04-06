if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepNGP_AttachmentUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepNGP_AttachmentUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WFinRepNGP_Attachment] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWFinRepNGP_AttachmentUpdate
    @pk_WFRNGPAt_ID int,
    @p_WFRNGPAt_WFRCHNGP_ID int,
    @p_WFRNGPAt_Desc varchar(150),
    @p_WFRNGPAt_Doc image,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WFinRepNGP_Attachment] WHERE [WFRNGPAt_ID] = @pk_WFRNGPAt_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WFinRepNGP_Attachment]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WFinRepNGP_Attachment]
            SET 
            [WFRNGPAt_WFRCHNGP_ID] = @p_WFRNGPAt_WFRCHNGP_ID,
            [WFRNGPAt_Desc] = @p_WFRNGPAt_Desc,
            [WFRNGPAt_Doc] = @p_WFRNGPAt_Doc
            WHERE [WFRNGPAt_ID] = @pk_WFRNGPAt_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WFRNGPAt_ID],[WFRNGPAt_WFRCHNGP_ID],[WFRNGPAt_Desc],[WFRNGPAt_Doc]) AS nvarchar(max)) 
            FROM [dbo].[WFinRepNGP_Attachment] with (rowlock, holdlock)
            WHERE [WFRNGPAt_ID] = @pk_WFRNGPAt_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WFinRepNGP_Attachment]
                    SET 
                    [WFRNGPAt_WFRCHNGP_ID] = @p_WFRNGPAt_WFRCHNGP_ID,
                    [WFRNGPAt_Desc] = @p_WFRNGPAt_Desc,
                    [WFRNGPAt_Doc] = @p_WFRNGPAt_Doc
                    WHERE [WFRNGPAt_ID] = @pk_WFRNGPAt_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WFinRepNGP_Attachment]', 16, 1)

        END
END

