if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFin_ApprovalStatusGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFin_ApprovalStatusGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WFin_ApprovalStatus] table.
CREATE PROCEDURE pePortalWFApprovalWFin_ApprovalStatusGet
        @pk_WPO_STAT_CD int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WFin_ApprovalStatus]
    WHERE [WPO_STAT_CD] =@pk_WPO_STAT_CD

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WPO_STAT_CD],
        [WPO_STAT_DESC],
        CAST(BINARY_CHECKSUM([WPO_STAT_CD],[WPO_STAT_DESC]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WFin_ApprovalStatus]
    WHERE [WPO_STAT_CD] =@pk_WPO_STAT_CD
    SET NOCOUNT OFF
END

