if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_PM00200Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_PM00200Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[sel_PM00200] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSel_PM00200Update
    @p_VENDORID char(15),
    @pk_VENDORID char(15),
    @p_VENDNAME char(65),
    @p_Company_ID int,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[sel_PM00200] WHERE [VENDORID] = @pk_VENDORID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[sel_PM00200]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[sel_PM00200]
            SET 
            [VENDORID] = @p_VENDORID,
            [VENDNAME] = @p_VENDNAME,
            [Company_ID] = @p_Company_ID
            WHERE [VENDORID] = @pk_VENDORID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([VENDORID],[VENDNAME],[Company_ID]) AS nvarchar(max)) 
            FROM [dbo].[sel_PM00200] with (rowlock, holdlock)
            WHERE [VENDORID] = @pk_VENDORID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[sel_PM00200]
                    SET 
                    [VENDORID] = @p_VENDORID,
                    [VENDNAME] = @p_VENDNAME,
                    [Company_ID] = @p_Company_ID
                    WHERE [VENDORID] = @pk_VENDORID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[sel_PM00200]', 16, 1)

        END
END

