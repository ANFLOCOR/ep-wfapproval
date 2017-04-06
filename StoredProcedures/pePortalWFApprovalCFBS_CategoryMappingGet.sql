if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalCFBS_CategoryMappingGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalCFBS_CategoryMappingGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[CFBS_CategoryMapping] table.
CREATE PROCEDURE pePortalWFApprovalCFBS_CategoryMappingGet
        @pk_MapID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[CFBS_CategoryMapping]
    WHERE [MapID] =@pk_MapID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [MapID],
        [IsPrimary],
        [BS_OrderNo],
        [CF_OrderNo],
        [Ref_BS_OrderNo],
        [ActIndx],
        [CreatedBy],
        [DateCreated],
        [ModifiedBy],
        [DateModified],
        CAST(BINARY_CHECKSUM([MapID],[IsPrimary],[BS_OrderNo],[CF_OrderNo],[Ref_BS_OrderNo],[ActIndx],[CreatedBy],[DateCreated],[ModifiedBy],[DateModified]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[CFBS_CategoryMapping]
    WHERE [MapID] =@pk_MapID
    SET NOCOUNT OFF
END

