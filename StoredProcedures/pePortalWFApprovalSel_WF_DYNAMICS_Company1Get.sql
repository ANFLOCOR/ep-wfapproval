if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WF_DYNAMICS_Company1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WF_DYNAMICS_Company1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[sel_WF_DYNAMICS_Company] table.
CREATE PROCEDURE pePortalWFApprovalSel_WF_DYNAMICS_Company1Get
        @pk_Company_ID smallint
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[sel_WF_DYNAMICS_Company]
    WHERE [Company_ID] =@pk_Company_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [Company_ID],
        [Company_Desc],
        [Company_Short_Name],
        [INTERID],
        [FULLADDRESS],
        CAST(BINARY_CHECKSUM([Company_ID],[Company_Desc],[Company_Short_Name],[INTERID],[FULLADDRESS]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[sel_WF_DYNAMICS_Company]
    WHERE [Company_ID] =@pk_Company_ID
    SET NOCOUNT OFF
END

