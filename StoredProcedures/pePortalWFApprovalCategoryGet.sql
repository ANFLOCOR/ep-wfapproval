if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalCategoryGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalCategoryGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[Category] table.
CREATE PROCEDURE pePortalWFApprovalCategoryGet
        @pk_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[Category]
    WHERE [ID] =@pk_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [ID],
        [Accatnum],
        [Accatdesc],
        [TypicalBalance],
        [Orderno],
        [Orderno1],
        [ReportID],
        [LevelNo],
        [Level1],
        [Level1_Ord],
        [Level2],
        [Level2_Ord],
        [Indent],
        [CreatedBy],
        [DateCreated],
        [ModifiedBy],
        [DateModified],
        [IsPrimary],
        [TotalOf],
        CAST(BINARY_CHECKSUM([ID],[Accatnum],[Accatdesc],[TypicalBalance],[Orderno],[Orderno1],[ReportID],[LevelNo],[Level1],[Level1_Ord],[Level2],[Level2_Ord],[Indent],[CreatedBy],[DateCreated],[ModifiedBy],[DateModified],[IsPrimary],[TotalOf]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[Category]
    WHERE [ID] =@pk_ID
    SET NOCOUNT OFF
END

