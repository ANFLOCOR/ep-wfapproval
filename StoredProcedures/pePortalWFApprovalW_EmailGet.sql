if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_EmailGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_EmailGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[W_Email] table.
CREATE PROCEDURE pePortalWFApprovalW_EmailGet
        @pk_WE_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[W_Email]
    WHERE [WE_ID] =@pk_WE_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WE_ID],
        [WE_U_ID],
        [WE_Directory],
        [WE_Site],
        [WE_Template],
        CAST(BINARY_CHECKSUM([WE_ID],[WE_U_ID],[WE_Directory],[WE_Site],[WE_Template]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[W_Email]
    WHERE [WE_ID] =@pk_WE_ID
    SET NOCOUNT OFF
END

