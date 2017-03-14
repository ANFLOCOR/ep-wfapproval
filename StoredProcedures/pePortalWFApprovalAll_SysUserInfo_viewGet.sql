if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalAll_SysUserInfo_viewGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalAll_SysUserInfo_viewGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


