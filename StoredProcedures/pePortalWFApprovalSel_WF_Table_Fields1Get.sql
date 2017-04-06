if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WF_Table_Fields1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WF_Table_Fields1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[sel_WF_Table_Fields] table.
CREATE PROCEDURE pePortalWFApprovalSel_WF_Table_Fields1Get
        @pk_Row bigint
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[sel_WF_Table_Fields]
    WHERE [Row] =@pk_Row

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [Row],
        [TABLE_NAME],
        [COLUMN_NAME],
        [IS_NULLABLE],
        [DATA_TYPE],
        CAST(BINARY_CHECKSUM([Row],[TABLE_NAME],[COLUMN_NAME],[IS_NULLABLE],[DATA_TYPE]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[sel_WF_Table_Fields]
    WHERE [Row] =@pk_Row
    SET NOCOUNT OFF
END

