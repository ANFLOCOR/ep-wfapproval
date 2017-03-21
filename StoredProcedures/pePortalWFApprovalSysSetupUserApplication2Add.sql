if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUserApplication2Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUserApplication2Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[SysSetupUserApplication] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupUserApplication2Add
    @p_SSUA_SSU_UserName char(15),
    @p_SSUA_App_ID int,
    @p_SSUA_DateCreated datetime,
    @p_SSUA_RowID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[SysSetupUserApplication]
        (
            [SSUA_SSU_UserName],
            [SSUA_App_ID]
        )
    VALUES
        (
             @p_SSUA_SSU_UserName,
             @p_SSUA_App_ID
        )

    SET @p_SSUA_RowID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_SSUA_DateCreated IS NOT NULL
        UPDATE [dbo].[SysSetupUserApplication] SET [SSUA_DateCreated] = @p_SSUA_DateCreated WHERE [SSUA_RowID] = @p_SSUA_RowID_out

END

