if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_User_DYNAMICS_Company1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_User_DYNAMICS_Company1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[W_User_DYNAMICS_Company] table.
CREATE PROCEDURE pePortalWFApprovalW_User_DYNAMICS_Company1Get
        @pk_W_UDC_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[W_User_DYNAMICS_Company]
    WHERE [W_UDC_ID] =@pk_W_UDC_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [W_UDC_ID],
        [W_UDC_U_ID],
        [W_UDC_C_ID],
        CAST(BINARY_CHECKSUM([W_UDC_ID],[W_UDC_U_ID],[W_UDC_C_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[W_User_DYNAMICS_Company]
    WHERE [W_UDC_ID] =@pk_W_UDC_ID
    SET NOCOUNT OFF
END

