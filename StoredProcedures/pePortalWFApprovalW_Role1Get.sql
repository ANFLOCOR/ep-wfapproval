if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_Role1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_Role1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[W_Role] table.
CREATE PROCEDURE pePortalWFApprovalW_Role1Get
        @pk_W_R_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[W_Role]
    WHERE [W_R_ID] =@pk_W_R_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [W_R_ID],
        [W_R_A_ID],
        [W_R_Name],
        [W_R_Desc],
        CAST(BINARY_CHECKSUM([W_R_ID],[W_R_A_ID],[W_R_Name],[W_R_Desc]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[W_Role]
    WHERE [W_R_ID] =@pk_W_R_ID
    SET NOCOUNT OFF
END

