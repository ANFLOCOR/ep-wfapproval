if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_Attachment1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_Attachment1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WFinRep_Attachment] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_Attachment1Get
        @pk_WFRA_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WFinRep_Attachment]
    WHERE [WFRA_ID] =@pk_WFRA_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WFRA_ID],
        [WFRA_FIN_ID],
        [WFRA_Desc],
        [WFRA_Doc],
        CAST(BINARY_CHECKSUM([WFRA_ID],[WFRA_FIN_ID],[WFRA_Desc],[WFRA_Doc]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WFinRep_Attachment]
    WHERE [WFRA_ID] =@pk_WFRA_ID
    SET NOCOUNT OFF
END

