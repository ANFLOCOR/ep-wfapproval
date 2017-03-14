if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_ApprovalStatusAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_ApprovalStatusAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WPO_ApprovalStatus] table.
CREATE PROCEDURE pePortalWFApprovalWPO_ApprovalStatusAdd
    @p_WPO_STAT_DESC nvarchar(20),
    @p_WPO_STAT_CD_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WPO_ApprovalStatus]
        (
            [WPO_STAT_DESC]
        )
    VALUES
        (
             @p_WPO_STAT_DESC
        )

    SET @p_WPO_STAT_CD_out = SCOPE_IDENTITY()

END

