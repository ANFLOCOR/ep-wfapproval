if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WASP_UserGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WASP_UserGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[sel_WASP_User] table.
CREATE PROCEDURE pePortalWFApprovalSel_WASP_UserGet
        @pk_W_U_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[sel_WASP_User]
    WHERE [W_U_ID] =@pk_W_U_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [W_U_ID],
        [W_U_User_Name],
        [W_U_Password],
        [W_U_Full_Name],
        [W_U_Designation],
        [W_U_GP_User_Name],
        CAST(BINARY_CHECKSUM([W_U_ID],[W_U_User_Name],[W_U_Password],[W_U_Full_Name],[W_U_Designation],[W_U_GP_User_Name]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[sel_WASP_User]
    WHERE [W_U_ID] =@pk_W_U_ID
    SET NOCOUNT OFF
END

