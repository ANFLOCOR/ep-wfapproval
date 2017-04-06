if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_IV001011Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_IV001011Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[sel_IV00101] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSel_IV001011Update
    @p_ITEMNMBR char(31),
    @pk_ITEMNMBR char(31),
    @p_ITEMDESC varchar(101),
    @p_CURRCOST numeric(19,5),
    @p_IVIVOFIX int,
    @p_IVIVINDX int,
    @p_LOCNCODE char(11),
    @p_PRCHSUOM char(9),
    @p_Company_ID int,
    @pk_Company_ID int,
    @p_Account varchar(39),
    @p_ITMSHNAM char(15),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[sel_IV00101] WHERE [ITEMNMBR] = @pk_ITEMNMBR and [Company_ID] = @pk_Company_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[sel_IV00101]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[sel_IV00101]
            SET 
            [ITEMNMBR] = @p_ITEMNMBR,
            [ITEMDESC] = @p_ITEMDESC,
            [CURRCOST] = @p_CURRCOST,
            [IVIVOFIX] = @p_IVIVOFIX,
            [IVIVINDX] = @p_IVIVINDX,
            [LOCNCODE] = @p_LOCNCODE,
            [PRCHSUOM] = @p_PRCHSUOM,
            [Company_ID] = @p_Company_ID,
            [Account] = @p_Account,
            [ITMSHNAM] = @p_ITMSHNAM
            WHERE [ITEMNMBR] = @pk_ITEMNMBR and [Company_ID] = @pk_Company_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([ITEMNMBR],[ITEMDESC],[CURRCOST],[IVIVOFIX],[IVIVINDX],[LOCNCODE],[PRCHSUOM],[Company_ID],[Account],[ITMSHNAM]) AS nvarchar(max)) 
            FROM [dbo].[sel_IV00101] with (rowlock, holdlock)
            WHERE [ITEMNMBR] = @pk_ITEMNMBR and [Company_ID] = @pk_Company_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[sel_IV00101]
                    SET 
                    [ITEMNMBR] = @p_ITEMNMBR,
                    [ITEMDESC] = @p_ITEMDESC,
                    [CURRCOST] = @p_CURRCOST,
                    [IVIVOFIX] = @p_IVIVOFIX,
                    [IVIVINDX] = @p_IVIVINDX,
                    [LOCNCODE] = @p_LOCNCODE,
                    [PRCHSUOM] = @p_PRCHSUOM,
                    [Company_ID] = @p_Company_ID,
                    [Account] = @p_Account,
                    [ITMSHNAM] = @p_ITMSHNAM
                    WHERE [ITEMNMBR] = @pk_ITEMNMBR and [Company_ID] = @pk_Company_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[sel_IV00101]', 16, 1)

        END
END

