if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepNGP_Head1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepNGP_Head1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WFinRepNGP_Head] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepNGP_Head1Get
        @pk_WFRCHNGP_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WFinRepNGP_Head]
    WHERE [WFRCHNGP_ID] =@pk_WFRCHNGP_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WFRCHNGP_ID],
        [WFRCHNGP_Year],
        [WFRCHNGP_Month],
        [WFRCHNGP_DT_ID],
        [WFRCHNGP_Code],
        [WFRCHNGP_Submit],
        [WFRCHNGP_Status],
        [WFRCHNGP_C_ID],
        [WFRCHNGP_U_ID],
        [WFRCHNGP_Remark],
        [WFRCHNGP_PRTCNT],
        [WFRCHNGP_FinID],
        [WFRCHNGP_RptCount],
        [WFRCHNGP_Description],
        [WFRCHNGP_File],
        CAST(BINARY_CHECKSUM([WFRCHNGP_ID],[WFRCHNGP_Year],[WFRCHNGP_Month],[WFRCHNGP_DT_ID],[WFRCHNGP_Code],[WFRCHNGP_Submit],[WFRCHNGP_Status],[WFRCHNGP_C_ID],[WFRCHNGP_U_ID],[WFRCHNGP_Remark],[WFRCHNGP_PRTCNT],[WFRCHNGP_FinID],[WFRCHNGP_RptCount],[WFRCHNGP_Description],[WFRCHNGP_File]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WFinRepNGP_Head]
    WHERE [WFRCHNGP_ID] =@pk_WFRCHNGP_ID
    SET NOCOUNT OFF
END

