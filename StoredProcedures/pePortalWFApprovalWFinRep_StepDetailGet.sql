if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_StepDetailGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_StepDetailGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WFinRep_StepDetail] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_StepDetailGet
        @pk_WFIN_SD_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WFinRep_StepDetail]
    WHERE [WFIN_SD_ID] =@pk_WFIN_SD_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WFIN_SD_ID],
        [WFIN_SD_S_ID],
        [WFIN_SD_W_U_ID],
        [WFIN_SD_Desc],
        [WFIN_SD_Status],
        [WFIN_SD_Variable_Ref],
        [WFIN_SD_Variable_SQL],
        [WFIN_SD_Expire],
        [WFIN_SD_W_U_ID_Delegate],
        [WFIN_SD_Is_Escalate],
        CAST(BINARY_CHECKSUM([WFIN_SD_ID],[WFIN_SD_S_ID],[WFIN_SD_W_U_ID],[WFIN_SD_Desc],[WFIN_SD_Status],[WFIN_SD_Variable_Ref],[WFIN_SD_Variable_SQL],[WFIN_SD_Expire],[WFIN_SD_W_U_ID_Delegate],[WFIN_SD_Is_Escalate]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WFinRep_StepDetail]
    WHERE [WFIN_SD_ID] =@pk_WFIN_SD_ID
    SET NOCOUNT OFF
END

