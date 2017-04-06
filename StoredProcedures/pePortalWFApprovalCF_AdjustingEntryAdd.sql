if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalCF_AdjustingEntryAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalCF_AdjustingEntryAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[CF_AdjustingEntry] table.
CREATE PROCEDURE pePortalWFApprovalCF_AdjustingEntryAdd
    @p_WFRCH_ID int,
    @p_Year int,
    @p_PeriodID int,
    @p_CFCat_Increase int,
    @p_CFCat_Decrease int,
    @p_Amount_Adjust numeric(19,5),
    @p_CreatedBy varchar(20),
    @p_DateCreated datetime,
    @p_ModifiedBy varchar(20),
    @p_DateModified datetime,
    @p_AdjustID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[CF_AdjustingEntry]
        (
            [WFRCH_ID],
            [Year],
            [PeriodID],
            [CFCat_Increase],
            [CFCat_Decrease],
            [Amount_Adjust],
            [CreatedBy],
            [DateCreated],
            [ModifiedBy],
            [DateModified]
        )
    VALUES
        (
             @p_WFRCH_ID,
             @p_Year,
             @p_PeriodID,
             @p_CFCat_Increase,
             @p_CFCat_Decrease,
             @p_Amount_Adjust,
             @p_CreatedBy,
             @p_DateCreated,
             @p_ModifiedBy,
             @p_DateModified
        )

    SET @p_AdjustID_out = SCOPE_IDENTITY()

END

