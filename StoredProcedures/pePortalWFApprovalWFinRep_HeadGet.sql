if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_HeadGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_HeadGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WFinRep_Head] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_HeadGet
        @pk_HFIN_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WFinRep_Head]
    WHERE [HFIN_ID] =@pk_HFIN_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [HFIN_ID],
        [HFIN_Year],
        [HFIN_Month],
        [HFIN_DT_ID],
        [HFIN_Code],
        [HFIN_Submit],
        [HFIN_Status],
        [HFIN_C_ID],
        [HFIN_U_ID],
        [HFIN_Remark],
        [HFIN_PRTCNT],
        [HFIN_FinID],
        [HFIN_RptCount],
        [HFIN_Description],
        [HFIN_File],
        CAST(BINARY_CHECKSUM([HFIN_ID],[HFIN_Year],[HFIN_Month],[HFIN_DT_ID],[HFIN_Code],[HFIN_Submit],[HFIN_Status],[HFIN_C_ID],[HFIN_U_ID],[HFIN_Remark],[HFIN_PRTCNT],[HFIN_FinID],[HFIN_RptCount],[HFIN_Description],[HFIN_File]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WFinRep_Head]
    WHERE [HFIN_ID] =@pk_HFIN_ID
    SET NOCOUNT OFF
END

