if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_POP10100_IncidentalUpdate') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_POP10100_IncidentalUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[sel_POP10100_Incidental] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalSel_POP10100_IncidentalUpdate
    @p_PONUMBER char(17),
    @pk_PONUMBER char(17),
    @p_POSTATUS smallint,
    @p_DOCDATE datetime,
    @p_SUBTOTAL numeric(19,5),
    @p_VENDORID char(15),
    @p_VENDNAME char(65),
    @p_Company_ID int,
    @pk_Company_ID int,
    @p_PRMDATE datetime,
    @p_SHIPMTHD char(15),
    @p_TAXAMNT numeric(19,5),
    @p_PYMTRMID char(21),
    @p_COMMNTID char(15),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[sel_POP10100_Incidental] WHERE [PONUMBER] = @pk_PONUMBER and [Company_ID] = @pk_Company_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[sel_POP10100_Incidental]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[sel_POP10100_Incidental]
            SET 
            [PONUMBER] = @p_PONUMBER,
            [POSTATUS] = @p_POSTATUS,
            [DOCDATE] = @p_DOCDATE,
            [SUBTOTAL] = @p_SUBTOTAL,
            [VENDORID] = @p_VENDORID,
            [VENDNAME] = @p_VENDNAME,
            [Company_ID] = @p_Company_ID,
            [PRMDATE] = @p_PRMDATE,
            [SHIPMTHD] = @p_SHIPMTHD,
            [TAXAMNT] = @p_TAXAMNT,
            [PYMTRMID] = @p_PYMTRMID,
            [COMMNTID] = @p_COMMNTID
            WHERE [PONUMBER] = @pk_PONUMBER and [Company_ID] = @pk_Company_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([PONUMBER],[POSTATUS],[DOCDATE],[SUBTOTAL],[VENDORID],[VENDNAME],[Company_ID],[PRMDATE],[SHIPMTHD],[TAXAMNT],[PYMTRMID],[COMMNTID]) AS nvarchar(max)) 
            FROM [dbo].[sel_POP10100_Incidental] with (rowlock, holdlock)
            WHERE [PONUMBER] = @pk_PONUMBER and [Company_ID] = @pk_Company_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[sel_POP10100_Incidental]
                    SET 
                    [PONUMBER] = @p_PONUMBER,
                    [POSTATUS] = @p_POSTATUS,
                    [DOCDATE] = @p_DOCDATE,
                    [SUBTOTAL] = @p_SUBTOTAL,
                    [VENDORID] = @p_VENDORID,
                    [VENDNAME] = @p_VENDNAME,
                    [Company_ID] = @p_Company_ID,
                    [PRMDATE] = @p_PRMDATE,
                    [SHIPMTHD] = @p_SHIPMTHD,
                    [TAXAMNT] = @p_TAXAMNT,
                    [PYMTRMID] = @p_PYMTRMID,
                    [COMMNTID] = @p_COMMNTID
                    WHERE [PONUMBER] = @pk_PONUMBER and [Company_ID] = @pk_Company_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[sel_POP10100_Incidental]', 16, 1)

        END
END

