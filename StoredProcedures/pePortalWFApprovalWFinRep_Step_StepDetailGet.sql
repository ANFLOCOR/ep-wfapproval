if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_Step_StepDetailGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_Step_StepDetailGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


