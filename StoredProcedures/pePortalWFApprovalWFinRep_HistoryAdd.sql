if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_HistoryAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_HistoryAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WFinRep_History] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_HistoryAdd
    @p_WFRHi_WFRCH_ID int,
    @p_WFRHi_File image,
    @p_WFRHi_CreatedBy int,
    @p_WFRHi_DateCreated datetime,
    @p_WFRHi_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WFinRep_History]
        (
            [WFRHi_WFRCH_ID],
            [WFRHi_File],
            [WFRHi_CreatedBy]
        )
    VALUES
        (
             @p_WFRHi_WFRCH_ID,
             @p_WFRHi_File,
             @p_WFRHi_CreatedBy
        )

    SET @p_WFRHi_ID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_WFRHi_DateCreated IS NOT NULL
        UPDATE [dbo].[WFinRep_History] SET [WFRHi_DateCreated] = @p_WFRHi_DateCreated WHERE [WFRHi_ID] = @p_WFRHi_ID_out

END

