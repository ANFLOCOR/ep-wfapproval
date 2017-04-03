if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalView_FS_StatusAllCompanyGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalView_FS_StatusAllCompanyGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


