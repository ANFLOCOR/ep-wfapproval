if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WF_DYNAMICS_CompanyUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WF_DYNAMICS_CompanyUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[sel_WF_DYNAMICS_Company] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSel_WF_DYNAMICS_CompanyUpdate
    @p_Company_ID smallint,
    @pk_Company_ID smallint,
    @p_Company_Desc varchar(250),
    @p_Company_Short_Name varchar(10),
    @p_INTERID varchar(10),
    @p_FULLADDRESS varchar(224),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[sel_WF_DYNAMICS_Company] WHERE [Company_ID] = @pk_Company_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[sel_WF_DYNAMICS_Company]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[sel_WF_DYNAMICS_Company]
            SET 
            [Company_ID] = @p_Company_ID,
            [Company_Desc] = @p_Company_Desc,
            [Company_Short_Name] = @p_Company_Short_Name,
            [INTERID] = @p_INTERID,
            [FULLADDRESS] = @p_FULLADDRESS
            WHERE [Company_ID] = @pk_Company_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([Company_ID],[Company_Desc],[Company_Short_Name],[INTERID],[FULLADDRESS]) AS nvarchar(max)) 
            FROM [dbo].[sel_WF_DYNAMICS_Company] with (rowlock, holdlock)
            WHERE [Company_ID] = @pk_Company_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[sel_WF_DYNAMICS_Company]
                    SET 
                    [Company_ID] = @p_Company_ID,
                    [Company_Desc] = @p_Company_Desc,
                    [Company_Short_Name] = @p_Company_Short_Name,
                    [INTERID] = @p_INTERID,
                    [FULLADDRESS] = @p_FULLADDRESS
                    WHERE [Company_ID] = @pk_Company_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[sel_WF_DYNAMICS_Company]', 16, 1)

        END
END

