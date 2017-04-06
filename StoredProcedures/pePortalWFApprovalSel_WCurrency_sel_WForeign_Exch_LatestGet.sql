if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WCurrency_sel_WForeign_Exch_LatestGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WCurrency_sel_WForeign_Exch_LatestGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


