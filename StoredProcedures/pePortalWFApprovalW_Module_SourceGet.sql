﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_Module_SourceGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_Module_SourceGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[W_Module_Source] table.
CREATE PROCEDURE pePortalWFApprovalW_Module_SourceGet
        @pk_W_MS_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[W_Module_Source]
    WHERE [W_MS_ID] =@pk_W_MS_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [W_MS_ID],
        [W_MS_A_ID],
        [W_MS_Name],
        [W_MS_Desc],
        CAST(BINARY_CHECKSUM([W_MS_ID],[W_MS_A_ID],[W_MS_Name],[W_MS_Desc]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[W_Module_Source]
    WHERE [W_MS_ID] =@pk_W_MS_ID
    SET NOCOUNT OFF
END

