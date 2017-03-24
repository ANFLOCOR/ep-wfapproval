if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_Doc_AttachGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_Doc_AttachGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WPR_Doc_Attach] table.
CREATE PROCEDURE pePortalWFApprovalWPR_Doc_AttachGet
        @pk_WPRDA_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WPR_Doc_Attach]
    WHERE [WPRDA_ID] =@pk_WPRDA_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WPRDA_ID],
        [WPRDA_WPRD_ID],
        [WPRDA_Desc],
        [WPRDA_File],
        [WPRDA_WAT_ID],
        CAST(BINARY_CHECKSUM([WPRDA_ID],[WPRDA_WPRD_ID],[WPRDA_Desc],[WPRDA_File],[WPRDA_WAT_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WPR_Doc_Attach]
    WHERE [WPRDA_ID] =@pk_WPRDA_ID
    SET NOCOUNT OFF
END

