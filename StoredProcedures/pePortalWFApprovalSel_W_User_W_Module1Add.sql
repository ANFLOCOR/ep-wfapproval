if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_W_User_W_Module1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_W_User_W_Module1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_W_User_W_Module] table.
CREATE PROCEDURE pePortalWFApprovalSel_W_User_W_Module1Add
    @p_W_U_ID int,
    @p_W_MS_ID int
AS
BEGIN
    INSERT
    INTO [dbo].[sel_W_User_W_Module]
        (
            [W_U_ID],
            [W_MS_ID]
        )
    VALUES
        (
             @p_W_U_ID,
             @p_W_MS_ID
        )

END

