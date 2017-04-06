﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_FS_WFinRep_Attachment_PerReportTypeUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_FS_WFinRep_Attachment_PerReportTypeUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[vw_FS_WFinRep_Attachment_PerReportType] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalVw_FS_WFinRep_Attachment_PerReportTypeUpdate
    @p_WFRA_ID int,
    @pk_WFRA_ID int,
    @p_WFRA_FIN_ID int,
    @p_WFRA_Desc varchar(150),
    @p_WFRA_Doc image,
    @p_WFRT_Description varchar(350),
    @p_WFRT_SortOrder int,
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
    IF NOT EXISTS (SELECT * FROM [dbo].[vw_FS_WFinRep_Attachment_PerReportType] WHERE [WFRA_ID] = @pk_WFRA_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[vw_FS_WFinRep_Attachment_PerReportType]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[vw_FS_WFinRep_Attachment_PerReportType]
            SET 
            [WFRA_ID] = @p_WFRA_ID,
            [WFRA_FIN_ID] = @p_WFRA_FIN_ID,
            [WFRA_Desc] = @p_WFRA_Desc,
            [WFRA_Doc] = @p_WFRA_Doc,
            [WFRT_Description] = @p_WFRT_Description,
            [WFRT_SortOrder] = @p_WFRT_SortOrder,
            [FIN_HFIN_ID] = @p_FIN_HFIN_ID
            WHERE [WFRA_ID] = @pk_WFRA_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([WFRA_ID],[WFRA_FIN_ID],[WFRA_Desc],[WFRA_Doc],[WFRT_Description],[WFRT_SortOrder],[FIN_HFIN_ID]) AS nvarchar(max)) 
            FROM [dbo].[vw_FS_WFinRep_Attachment_PerReportType] with (rowlock, holdlock)
            WHERE [WFRA_ID] = @pk_WFRA_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[vw_FS_WFinRep_Attachment_PerReportType]
                    SET 
                    [WFRA_ID] = @p_WFRA_ID,
                    [WFRA_FIN_ID] = @p_WFRA_FIN_ID,
                    [WFRA_Desc] = @p_WFRA_Desc,
                    [WFRA_Doc] = @p_WFRA_Doc,
                    [WFRT_Description] = @p_WFRT_Description,
                    [WFRT_SortOrder] = @p_WFRT_SortOrder,
                    [FIN_HFIN_ID] = @p_FIN_HFIN_ID
                    WHERE [WFRA_ID] = @pk_WFRA_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[vw_FS_WFinRep_Attachment_PerReportType]', 16, 1)

        END
END

