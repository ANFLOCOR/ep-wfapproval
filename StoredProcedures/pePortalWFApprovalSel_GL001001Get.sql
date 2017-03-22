if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_GL001001Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_GL001001Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[sel_GL00100] table.
CREATE PROCEDURE pePortalWFApprovalSel_GL001001Get
        @pk_ACTINDX int,    @pk_Company_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[sel_GL00100]
    WHERE [ACTINDX] =@pk_ACTINDX and [Company_ID] =@pk_Company_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [ACTINDX],
        [ACTNUMBR_1],
        [ACTNUMBR_2],
        [ACTNUMBR_3],
        [ACTNUMBR_4],
        [ACTNUMBR_5],
        [ACTNUMBR_6],
        [Company_ID],
        [ACTDESCR],
        [AcctCode],
        CAST(BINARY_CHECKSUM([ACTINDX],[ACTNUMBR_1],[ACTNUMBR_2],[ACTNUMBR_3],[ACTNUMBR_4],[ACTNUMBR_5],[ACTNUMBR_6],[Company_ID],[ACTDESCR],[AcctCode]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[sel_GL00100]
    WHERE [ACTINDX] =@pk_ACTINDX and [Company_ID] =@pk_Company_ID
    SET NOCOUNT OFF
END

