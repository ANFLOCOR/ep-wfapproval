﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_DocTypeDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_DocTypeDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WFinRep_DocType] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_DocTypeDelete
        @pk_WFIN_DT_ID int
AS
BEGIN
    DELETE [dbo].[WFinRep_DocType]
    WHERE [WFIN_DT_ID] = @pk_WFIN_DT_ID
END

