if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupWASSEmail1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupWASSEmail1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[SysSetupWASSEmail] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupWASSEmail1Add
    @p_WE_U_ID int,
    @p_WE_Directory varchar(250),
    @p_WE_Site varchar(250),
    @p_WE_Template text,
    @p_WE_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[SysSetupWASSEmail]
        (
            [WE_U_ID],
            [WE_Directory],
            [WE_Site],
            [WE_Template]
        )
    VALUES
        (
             @p_WE_U_ID,
             @p_WE_Directory,
             @p_WE_Site,
             @p_WE_Template
        )

    SET @p_WE_ID_out = SCOPE_IDENTITY()

END

