if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_Step1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_Step1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WFinRep_Step] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_Step1Get
        @pk_WFIN_S_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WFinRep_Step]
    WHERE [WFIN_S_ID] =@pk_WFIN_S_ID

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
        [WFIN_S_Desc],
        [WFIN_S_Approval_Needed],
        [WFIN_S_C_ID],
        CAST(BINARY_CHECKSUM([WFIN_S_ID],[WFIN_S_WDT_ID],[WFIN_S_ID_Next],[WFIN_S_Step_Type],[WFIN_S_Desc],[WFIN_S_Approval_Needed],[WFIN_S_C_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WFinRep_Step]
    WHERE [WFIN_S_ID] =@pk_WFIN_S_ID
    SET NOCOUNT OFF
END

