if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalACTIVITYGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalACTIVITYGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[ACTIVITY] table.
CREATE PROCEDURE pePortalWFApprovalACTIVITYGet
        @pk_USERID char(15),    @pk_CMPNYNAM char(65)
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[ACTIVITY]
    WHERE [USERID] =@pk_USERID and [CMPNYNAM] =@pk_CMPNYNAM

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [USERID],
        [CMPNYNAM],
        [LOGINDAT],
        [LOGINTIM],
        [SQLSESID],
        [Language_ID],
        [IsWebClient],
        [IsOffline],
        [DEX_ROW_ID],
        CAST(BINARY_CHECKSUM([USERID],[CMPNYNAM],[LOGINDAT],[LOGINTIM],[SQLSESID],[Language_ID],[IsWebClient],[IsOffline],[DEX_ROW_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[ACTIVITY]
    WHERE [USERID] =@pk_USERID and [CMPNYNAM] =@pk_CMPNYNAM
    SET NOCOUNT OFF
END

