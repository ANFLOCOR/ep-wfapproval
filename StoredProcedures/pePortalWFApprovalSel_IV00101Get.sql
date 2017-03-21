if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_IV00101Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_IV00101Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[sel_IV00101] table.
CREATE PROCEDURE pePortalWFApprovalSel_IV00101Get
        @pk_ITEMNMBR char(31),    @pk_Company_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[sel_IV00101]
    WHERE [ITEMNMBR] =@pk_ITEMNMBR and [Company_ID] =@pk_Company_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [ITEMNMBR],
        [ITEMDESC],
        [CURRCOST],
        [IVIVOFIX],
        [IVIVINDX],
        [LOCNCODE],
        [PRCHSUOM],
        [Company_ID],
        [Account],
        [ITMSHNAM],
        CAST(BINARY_CHECKSUM([ITEMNMBR],[ITEMDESC],[CURRCOST],[IVIVOFIX],[IVIVINDX],[LOCNCODE],[PRCHSUOM],[Company_ID],[Account],[ITMSHNAM]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[sel_IV00101]
    WHERE [ITEMNMBR] =@pk_ITEMNMBR and [Company_ID] =@pk_Company_ID
    SET NOCOUNT OFF
END

