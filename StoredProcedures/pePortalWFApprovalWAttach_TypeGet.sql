if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWAttach_TypeGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWAttach_TypeGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WAttach_Type] table.
CREATE PROCEDURE pePortalWFApprovalWAttach_TypeGet
        @pk_WAT_ID smallint
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WAttach_Type]
    WHERE [WAT_ID] =@pk_WAT_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WAT_ID],
        [WAT_Name],
        [WAT_Operation],
        [WAT_Order],
        CAST(BINARY_CHECKSUM([WAT_ID],[WAT_Name],[WAT_Operation],[WAT_Order]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WAttach_Type]
    WHERE [WAT_ID] =@pk_WAT_ID
    SET NOCOUNT OFF
END

