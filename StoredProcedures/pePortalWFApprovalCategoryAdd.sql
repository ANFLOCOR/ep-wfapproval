if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalCategoryAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalCategoryAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[Category] table.
CREATE PROCEDURE pePortalWFApprovalCategoryAdd
    @p_Accatnum int,
    @p_Accatdesc varchar(1000),
    @p_TypicalBalance int,
    @p_Orderno int,
    @p_Orderno1 int,
    @p_ReportID int,
    @p_LevelNo int,
    @p_Level1 varchar(500),
    @p_Level1_Ord int,
    @p_Level2 varchar(500),
    @p_Level2_Ord int,
    @p_Indent int,
    @p_CreatedBy int,
    @p_DateCreated datetime,
    @p_ModifiedBy int,
    @p_DateModified datetime,
    @p_IsPrimary bit,
    @p_TotalOf varchar(1000),
    @p_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[Category]
        (
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
            [TotalOf]
        )
    VALUES
        (
             @p_Accatdesc,
             @p_TypicalBalance,
             @p_Orderno,
             @p_Orderno1,
             @p_ReportID,
             @p_LevelNo,
             @p_Level1,
             @p_Level1_Ord,
             @p_Level2,
             @p_Level2_Ord,
             @p_Indent,
             @p_CreatedBy,
             @p_DateCreated,
             @p_ModifiedBy,
             @p_DateModified,
             @p_IsPrimary,
             @p_TotalOf
        )

    SET @p_ID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_Accatnum IS NOT NULL
        UPDATE [dbo].[Category] SET [Accatnum] = @p_Accatnum WHERE [ID] = @p_ID_out

END

