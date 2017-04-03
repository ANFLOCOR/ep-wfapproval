if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepNGP_DocAttachGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepNGP_DocAttachGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WFinRepNGP_DocAttach] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepNGP_DocAttachGet
        @pk_WFRCDNGP_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WFinRepNGP_DocAttach]
    WHERE [WFRCDNGP_ID] =@pk_WFRCDNGP_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WFRCDNGP_ID],
        [WFRCDNGP_Year],
        [WFRCDNGP_Month],
        [WFRCDNGP_Type],
        [WFRCDNGP_Description],
        [WFRCDNGP_File],
        [WFRCDNGP_Company],
        [WFRCDNGP_Status],
        [WFRCDNGP_File1],
        [WFRCDNGP_RptID],
        [WFRCDNGP_Post],
        [WFRCDNGP_RWRem],
        [WFRCDNGP_WFRCHNGP_ID],
        CAST(BINARY_CHECKSUM([WFRCDNGP_ID],[WFRCDNGP_Year],[WFRCDNGP_Month],[WFRCDNGP_Type],[WFRCDNGP_Description],[WFRCDNGP_File],[WFRCDNGP_Company],[WFRCDNGP_Status],[WFRCDNGP_File1],[WFRCDNGP_RptID],[WFRCDNGP_Post],[WFRCDNGP_RWRem],[WFRCDNGP_WFRCHNGP_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WFinRepNGP_DocAttach]
    WHERE [WFRCDNGP_ID] =@pk_WFRCDNGP_ID
    SET NOCOUNT OFF
END

