if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCAR_Doc_AttachGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCAR_Doc_AttachGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WCAR_Doc_Attach] table.
CREATE PROCEDURE pePortalWFApprovalWCAR_Doc_AttachGet
        @pk_WCDA_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WCAR_Doc_Attach]
    WHERE [WCDA_ID] =@pk_WCDA_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WCDA_ID],
        [WCDA_WCD_ID],
        [WCDA_Desc],
        [WCDA_File],
        [WCDA_WAT_ID],
        CAST(BINARY_CHECKSUM([WCDA_ID],[WCDA_WCD_ID],[WCDA_Desc],[WCDA_File],[WCDA_WAT_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WCAR_Doc_Attach]
    WHERE [WCDA_ID] =@pk_WCDA_ID
    SET NOCOUNT OFF
END

