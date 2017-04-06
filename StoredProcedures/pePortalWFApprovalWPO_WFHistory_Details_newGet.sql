if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_WFHistory_Details_newGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_WFHistory_Details_newGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


