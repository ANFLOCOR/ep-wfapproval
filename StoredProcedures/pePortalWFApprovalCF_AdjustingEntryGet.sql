if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalCF_AdjustingEntryGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalCF_AdjustingEntryGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[CF_AdjustingEntry] table.
CREATE PROCEDURE pePortalWFApprovalCF_AdjustingEntryGet
        @pk_AdjustID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[CF_AdjustingEntry]
    WHERE [AdjustID] =@pk_AdjustID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [AdjustID],
        [WFRCH_ID],
        [Year],
        [PeriodID],
        [CFCat_Increase],
        [CFCat_Decrease],
        [Amount_Adjust],
        [CreatedBy],
        [DateCreated],
        [ModifiedBy],
        [DateModified],
        CAST(BINARY_CHECKSUM([AdjustID],[WFRCH_ID],[Year],[PeriodID],[CFCat_Increase],[CFCat_Decrease],[Amount_Adjust],[CreatedBy],[DateCreated],[ModifiedBy],[DateModified]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[CF_AdjustingEntry]
    WHERE [AdjustID] =@pk_AdjustID
    SET NOCOUNT OFF
END

