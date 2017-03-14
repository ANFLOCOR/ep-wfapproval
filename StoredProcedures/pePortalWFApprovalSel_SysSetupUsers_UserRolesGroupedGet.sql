if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_SysSetupUsers_UserRolesGroupedGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_SysSetupUsers_UserRolesGroupedGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


