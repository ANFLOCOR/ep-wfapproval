if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_PM00200Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_PM00200Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[sel_PM00200] table.
CREATE PROCEDURE pePortalWFApprovalSel_PM00200Get
        @pk_VENDORID char(15)
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[sel_PM00200]
    WHERE [VENDORID] =@pk_VENDORID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [VENDORID],
        [VENDNAME],
        [Company_ID],
        CAST(BINARY_CHECKSUM([VENDORID],[VENDNAME],[Company_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[sel_PM00200]
    WHERE [VENDORID] =@pk_VENDORID
    SET NOCOUNT OFF
END

