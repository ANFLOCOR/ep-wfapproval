if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WPO_WFTaskDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WPO_WFTaskDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_WPO_WFTask] table.
CREATE PROCEDURE pePortalWFApprovalSel_WPO_WFTaskDelete
        @pk_PONUMBER char(17),
    @pk_CompanyID int
AS
BEGIN
    DELETE [dbo].[sel_WPO_WFTask]
    WHERE [PONUMBER] = @pk_PONUMBER
    AND [CompanyID] = @pk_CompanyID
END

