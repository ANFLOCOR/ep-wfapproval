﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUserApplication2Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUserApplication2Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[SysSetupUserApplication] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupUserApplication2Get
        @pk_SSUA_RowID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[SysSetupUserApplication]
    WHERE [SSUA_RowID] =@pk_SSUA_RowID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [SSUA_SSU_UserName],
        [SSUA_App_ID],
        [SSUA_DateCreated],
        [SSUA_RowID],
        CAST(BINARY_CHECKSUM([SSUA_SSU_UserName],[SSUA_App_ID],[SSUA_DateCreated],[SSUA_RowID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[SysSetupUserApplication]
    WHERE [SSUA_RowID] =@pk_SSUA_RowID
    SET NOCOUNT OFF
END

