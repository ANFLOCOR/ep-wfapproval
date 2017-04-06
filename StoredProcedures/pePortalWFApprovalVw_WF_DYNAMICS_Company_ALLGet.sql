if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_WF_DYNAMICS_Company_ALLGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_WF_DYNAMICS_Company_ALLGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


