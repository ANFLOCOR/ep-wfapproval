if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_InternalGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_InternalGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WCanvass_Internal] table.
CREATE PROCEDURE pePortalWFApprovalWCanvass_InternalGet
        @pk_WCI_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WCanvass_Internal]
    WHERE [WCI_ID] =@pk_WCI_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WCI_ID],
        [WCI_C_ID],
        [WCI_WPRD_ID],
        [WCI_Date],
        [WCI_Submit],
        [WCI_Status],
        [WCI_Vendors],
        [WCI_U_ID],
        [WCI_WClass_ID],
        [WCI_Contract_Done],
        [WCI_Contract_Closed],
        [WCI_Contract_U_ID],
        CAST(BINARY_CHECKSUM([WCI_ID],[WCI_C_ID],[WCI_WPRD_ID],[WCI_Date],[WCI_Submit],[WCI_Status],[WCI_Vendors],[WCI_U_ID],[WCI_WClass_ID],[WCI_Contract_Done],[WCI_Contract_Closed],[WCI_Contract_U_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WCanvass_Internal]
    WHERE [WCI_ID] =@pk_WCI_ID
    SET NOCOUNT OFF
END

