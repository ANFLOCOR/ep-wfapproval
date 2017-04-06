if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFin_ApprovalStatus1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFin_ApprovalStatus1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WFin_ApprovalStatus] table.
CREATE PROCEDURE pePortalWFApprovalWFin_ApprovalStatus1Add
    @p_WPO_STAT_CD int,
    @p_WPO_STAT_DESC nvarchar(20)
AS
BEGIN
    INSERT
    INTO [dbo].[WFin_ApprovalStatus]
        (
            [WPO_STAT_CD],
            [WPO_STAT_DESC]
        )
    VALUES
        (
             @p_WPO_STAT_CD,
             @p_WPO_STAT_DESC
        )

END

