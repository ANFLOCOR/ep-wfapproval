if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WASP_WF_Approver_PO2Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WASP_WF_Approver_PO2Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[sel_WASP_WF_Approver_PO] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSel_WASP_WF_Approver_PO2Update
    @p_W_U_ID int,
    @pk_W_U_ID int,
    @p_W_U_User_Name varchar(20),
    @p_W_U_Full_Name varchar(125),
    @p_W_R_ID int,
    @p_W_R_Name varchar(125),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[sel_WASP_WF_Approver_PO] WHERE [W_U_ID] = @pk_W_U_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[sel_WASP_WF_Approver_PO]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[sel_WASP_WF_Approver_PO]
            SET 
            [W_U_ID] = @p_W_U_ID,
            [W_U_User_Name] = @p_W_U_User_Name,
            [W_U_Full_Name] = @p_W_U_Full_Name,
            [W_R_ID] = @p_W_R_ID,
            [W_R_Name] = @p_W_R_Name
            WHERE [W_U_ID] = @pk_W_U_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([W_U_ID],[W_U_User_Name],[W_U_Full_Name],[W_R_ID],[W_R_Name]) AS nvarchar(max)) 
            FROM [dbo].[sel_WASP_WF_Approver_PO] with (rowlock, holdlock)
            WHERE [W_U_ID] = @pk_W_U_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[sel_WASP_WF_Approver_PO]
                    SET 
                    [W_U_ID] = @p_W_U_ID,
                    [W_U_User_Name] = @p_W_U_User_Name,
                    [W_U_Full_Name] = @p_W_U_Full_Name,
                    [W_R_ID] = @p_W_R_ID,
                    [W_R_Name] = @p_W_R_Name
                    WHERE [W_U_ID] = @pk_W_U_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[sel_WASP_WF_Approver_PO]', 16, 1)

        END
END

