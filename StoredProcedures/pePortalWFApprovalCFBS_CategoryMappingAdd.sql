if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalCFBS_CategoryMappingAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalCFBS_CategoryMappingAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[CFBS_CategoryMapping] table.
CREATE PROCEDURE pePortalWFApprovalCFBS_CategoryMappingAdd
    @p_IsPrimary bit,
    @p_BS_OrderNo int,
    @p_CF_OrderNo int,
    @p_Ref_BS_OrderNo int,
    @p_ActIndx int,
    @p_CreatedBy varchar(20),
    @p_DateCreated datetime,
    @p_ModifiedBy varchar(20),
    @p_DateModified datetime,
    @p_MapID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[CFBS_CategoryMapping]
        (
            [BS_OrderNo],
            [CF_OrderNo],
            [Ref_BS_OrderNo],
            [ActIndx],
            [CreatedBy],
            [DateCreated],
            [ModifiedBy],
            [DateModified]
        )
    VALUES
        (
             @p_BS_OrderNo,
             @p_CF_OrderNo,
             @p_Ref_BS_OrderNo,
             @p_ActIndx,
             @p_CreatedBy,
             @p_DateCreated,
             @p_ModifiedBy,
             @p_DateModified
        )

    SET @p_MapID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_IsPrimary IS NOT NULL
        UPDATE [dbo].[CFBS_CategoryMapping] SET [IsPrimary] = @p_IsPrimary WHERE [MapID] = @p_MapID_out

END

