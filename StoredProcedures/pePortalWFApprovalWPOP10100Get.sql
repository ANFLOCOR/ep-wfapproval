if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPOP10100Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPOP10100Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WPOP10100] table.
CREATE PROCEDURE pePortalWFApprovalWPOP10100Get
        @pk_WPOP_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WPOP10100]
    WHERE [WPOP_ID] =@pk_WPOP_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WPOP_ID],
        [WPOP_DT_ID],
        [WPOP_PONMBR],
        [WPOP_Submit],
        [WPOP_Status],
        [WPOP_C_ID],
        [WPOP_U_ID],
        [WPOP_Remark],
        [WPOP_PRTCNT],
        [WPOP_WCur_ID],
        CAST(BINARY_CHECKSUM([WPOP_ID],[WPOP_DT_ID],[WPOP_PONMBR],[WPOP_Submit],[WPOP_Status],[WPOP_C_ID],[WPOP_U_ID],[WPOP_Remark],[WPOP_PRTCNT],[WPOP_WCur_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WPOP10100]
    WHERE [WPOP_ID] =@pk_WPOP_ID
    SET NOCOUNT OFF
END

