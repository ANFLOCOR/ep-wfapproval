﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_Step_StepDetail1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_Step_StepDetail1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WFinRep_Step_StepDetail] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_Step_StepDetail1Get
        @pk_WFIN_SD_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WFinRep_Step_StepDetail]
    WHERE [WFIN_SD_ID] =@pk_WFIN_SD_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WFIN_S_ID],
        [WFIN_S_WDT_ID],
        [WFIN_S_ID_Next],
        [WFIN_S_Step_Type],
        [WFIN_S_Approval_Needed],
        [WFIN_SD_ID],
        [WFIN_SD_W_U_ID],
        [W_U_Full_Name],
        CAST(BINARY_CHECKSUM([WFIN_S_ID],[WFIN_S_WDT_ID],[WFIN_S_ID_Next],[WFIN_S_Step_Type],[WFIN_S_Approval_Needed],[WFIN_SD_ID],[WFIN_SD_W_U_ID],[W_U_Full_Name]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WFinRep_Step_StepDetail]
    WHERE [WFIN_SD_ID] =@pk_WFIN_SD_ID
    SET NOCOUNT OFF
END

