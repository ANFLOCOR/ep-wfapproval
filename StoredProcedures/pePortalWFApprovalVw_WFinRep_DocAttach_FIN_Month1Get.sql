if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_WFinRep_DocAttach_FIN_Month1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_WFinRep_DocAttach_FIN_Month1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[vw_WFinRep_DocAttach_FIN_Month] table.
CREATE PROCEDURE pePortalWFApprovalVw_WFinRep_DocAttach_FIN_Month1Get
        @pk_Mo int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[vw_WFinRep_DocAttach_FIN_Month]
    WHERE [Mo] =@pk_Mo

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [Mo],
        [MoName],
        CAST(BINARY_CHECKSUM([Mo],[MoName]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[vw_WFinRep_DocAttach_FIN_Month]
    WHERE [Mo] =@pk_Mo
    SET NOCOUNT OFF
END

