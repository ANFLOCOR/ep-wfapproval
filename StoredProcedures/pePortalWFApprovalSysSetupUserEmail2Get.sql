if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUserEmail2Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUserEmail2Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[SysSetupUserEmail] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupUserEmail2Get
        @pk_SSUE_RowID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[SysSetupUserEmail]
    WHERE [SSUE_RowID] =@pk_SSUE_RowID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [SSUE_UserName],
        [SSUE_Email],
        [SSUE_RowID],
        CAST(BINARY_CHECKSUM([SSUE_UserName],[SSUE_Email],[SSUE_RowID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[SysSetupUserEmail]
    WHERE [SSUE_RowID] =@pk_SSUE_RowID
    SET NOCOUNT OFF
END

