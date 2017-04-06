if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_Step_WPO_StepDetailGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_Step_WPO_StepDetailGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


