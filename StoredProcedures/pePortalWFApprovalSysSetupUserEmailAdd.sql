if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUserEmailAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUserEmailAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[SysSetupUserEmail] table.
CREATE PROCEDURE pePortalWFApprovalSysSetupUserEmailAdd
    @p_SSUE_UserName char(15),
    @p_SSUE_Email varchar(50),
    @p_SSUE_RowID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[SysSetupUserEmail]
        (
            [SSUE_UserName],
            [SSUE_Email]
        )
    VALUES
        (
             @p_SSUE_UserName,
             @p_SSUE_Email
        )

    SET @p_SSUE_RowID_out = SCOPE_IDENTITY()

END

