if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWF_Complete_NotifyGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWF_Complete_NotifyGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WF_Complete_Notify] table.
CREATE PROCEDURE pePortalWFApprovalWF_Complete_NotifyGet
        @pk_WFCN_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WF_Complete_Notify]
    WHERE [WFCN_ID] =@pk_WFCN_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WFCN_ID],
        [WFCN_C_ID],
        [WFCN_U_ID],
        [WFCN_DocType],
        CAST(BINARY_CHECKSUM([WFCN_ID],[WFCN_C_ID],[WFCN_U_ID],[WFCN_DocType]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WF_Complete_Notify]
    WHERE [WFCN_ID] =@pk_WFCN_ID
    SET NOCOUNT OFF
END

