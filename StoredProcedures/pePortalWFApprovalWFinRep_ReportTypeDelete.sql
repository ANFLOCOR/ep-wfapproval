﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_ReportTypeDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_ReportTypeDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WFinRep_ReportType] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_ReportTypeDelete
        @pk_WFRT_Type varchar(50)
AS
BEGIN
    DELETE [dbo].[WFinRep_ReportType]
    WHERE [WFRT_Type] = @pk_WFRT_Type
END

