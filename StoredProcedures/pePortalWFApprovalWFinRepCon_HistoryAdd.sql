if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepCon_HistoryAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepCon_HistoryAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WFinRepCon_History] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepCon_HistoryAdd
    @p_WFRCHi_WFRCH_ID int,
    @p_WFRCHi_File image,
    @p_WFRCHi_CreatedBy int,
    @p_WFRCHi_DateCreated datetime,
    @p_WFRCHi_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WFinRepCon_History]
        (
            [WFRCHi_WFRCH_ID],
            [WFRCHi_File],
            [WFRCHi_CreatedBy]
        )
    VALUES
        (
             @p_WFRCHi_WFRCH_ID,
             @p_WFRCHi_File,
             @p_WFRCHi_CreatedBy
        )

    SET @p_WFRCHi_ID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_WFRCHi_DateCreated IS NOT NULL
        UPDATE [dbo].[WFinRepCon_History] SET [WFRCHi_DateCreated] = @p_WFRCHi_DateCreated WHERE [WFRCHi_ID] = @p_WFRCHi_ID_out

END

