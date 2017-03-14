if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_Doc_AttachGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_Doc_AttachGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WPO_Doc_Attach] table.
CREATE PROCEDURE pePortalWFApprovalWPO_Doc_AttachGet
        @pk_WPODA_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WPO_Doc_Attach]
    WHERE [WPODA_ID] =@pk_WPODA_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WPODA_ID],
        [WPODA_PONo],
        [WPODA_Desc],
        [WPODA_File],
        [WPODA_CMPNY],
        CAST(BINARY_CHECKSUM([WPODA_ID],[WPODA_PONo],[WPODA_Desc],[WPODA_File],[WPODA_CMPNY]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WPO_Doc_Attach]
    WHERE [WPODA_ID] =@pk_WPODA_ID
    SET NOCOUNT OFF
END

