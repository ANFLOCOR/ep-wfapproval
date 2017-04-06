﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_ActivityDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_ActivityDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WFinRep_Activity] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_ActivityDelete
        @pk_AFIN_ID int
AS
BEGIN
    DELETE [dbo].[WFinRep_Activity]
    WHERE [AFIN_ID] = @pk_AFIN_ID
END

