if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCAR_Minimum1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCAR_Minimum1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WCAR_Minimum] table.
CREATE PROCEDURE pePortalWFApprovalWCAR_Minimum1Get
        @pk_WCM_ID smallint
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WCAR_Minimum]
    WHERE [WCM_ID] =@pk_WCM_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WCM_ID],
        [WCM_C_ID],
        [WCM_Min],
        [WCM_WCur_ID],
        CAST(BINARY_CHECKSUM([WCM_ID],[WCM_C_ID],[WCM_Min],[WCM_WCur_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WCAR_Minimum]
    WHERE [WCM_ID] =@pk_WCM_ID
    SET NOCOUNT OFF
END

