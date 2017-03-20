if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_CARNo_QWF1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_CARNo_QWF1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[WPO_CARNo_QWF] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalWPO_CARNo_QWF1Update
    @p_CompanyID smallint,
    @p_PONum char(30),
    @pk_PONum char(30),
    @p_PRNum varchar(50),
    @pk_PRNum varchar(50),
    @p_Comment varchar(500),
    @p_CARID int,
    @p_WCD_No varchar(50),
    @p_WCD_Remark varchar(250),
    @p_WCD_Project_Title varchar(max),
    @p_WCD_Exp_Total numeric(18,2),
    @p_WCD_ID int,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[WPO_CARNo_QWF] WHERE [PONum] = @pk_PONum and [PRNum] = @pk_PRNum)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[WPO_CARNo_QWF]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[WPO_CARNo_QWF]
            SET 
            [CompanyID] = @p_CompanyID,
            [PONum] = @p_PONum,
            [PRNum] = @p_PRNum,
            [Comment] = @p_Comment,
            [CARID] = @p_CARID,
            [WCD_No] = @p_WCD_No,
            [WCD_Remark] = @p_WCD_Remark,
            [WCD_Project_Title] = @p_WCD_Project_Title,
            [WCD_Exp_Total] = @p_WCD_Exp_Total,
            [WCD_ID] = @p_WCD_ID
            WHERE [PONum] = @pk_PONum and [PRNum] = @pk_PRNum

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([CompanyID],[PONum],[PRNum],[Comment],[CARID],[WCD_No],[WCD_Remark],[WCD_Project_Title],[WCD_Exp_Total],[WCD_ID]) AS nvarchar(max)) 
            FROM [dbo].[WPO_CARNo_QWF] with (rowlock, holdlock)
            WHERE [PONum] = @pk_PONum and [PRNum] = @pk_PRNum


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[WPO_CARNo_QWF]
                    SET 
                    [CompanyID] = @p_CompanyID,
                    [PONum] = @p_PONum,
                    [PRNum] = @p_PRNum,
                    [Comment] = @p_Comment,
                    [CARID] = @p_CARID,
                    [WCD_No] = @p_WCD_No,
                    [WCD_Remark] = @p_WCD_Remark,
                    [WCD_Project_Title] = @p_WCD_Project_Title,
                    [WCD_Exp_Total] = @p_WCD_Exp_Total,
                    [WCD_ID] = @p_WCD_ID
                    WHERE [PONum] = @pk_PONum and [PRNum] = @pk_PRNum

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[WPO_CARNo_QWF]', 16, 1)

        END
END

