if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_Conso_BSCategoriesGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_Conso_BSCategoriesGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


