if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepCon_HeadGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepCon_HeadGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WFinRepCon_Head] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepCon_HeadGet
        @pk_WFRCH_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WFinRepCon_Head]
    WHERE [WFRCH_ID] =@pk_WFRCH_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WFRCH_ID],
        [WFRCH_Year],
        [WFRCH_Month],
        [WFRCH_DT_ID],
        [WFRCH_Code],
        [WFRCH_Submit],
        [WFRCH_Status],
        [WFRCH_C_ID],
        [WFRCH_U_ID],
        [WFRCH_Remark],
        [WFRCH_PRTCNT],
        [WFRCH_FinID],
        [WFRCH_RptCount],
        [WFRCH_Description],
        [WFRCH_File],
        CAST(BINARY_CHECKSUM([WFRCH_ID],[WFRCH_Year],[WFRCH_Month],[WFRCH_DT_ID],[WFRCH_Code],[WFRCH_Submit],[WFRCH_Status],[WFRCH_C_ID],[WFRCH_U_ID],[WFRCH_Remark],[WFRCH_PRTCNT],[WFRCH_FinID],[WFRCH_RptCount],[WFRCH_Description],[WFRCH_File]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WFinRepCon_Head]
    WHERE [WFRCH_ID] =@pk_WFRCH_ID
    SET NOCOUNT OFF
END

