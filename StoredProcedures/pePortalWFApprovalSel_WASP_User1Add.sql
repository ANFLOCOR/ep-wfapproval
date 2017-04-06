if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WASP_User1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WASP_User1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_WASP_User] table.
CREATE PROCEDURE pePortalWFApprovalSel_WASP_User1Add
    @p_W_U_User_Name varchar(20),
    @p_W_U_Password varchar(20),
    @p_W_U_Full_Name varchar(125),
    @p_W_U_Designation varchar(250),
    @p_W_U_GP_User_Name varchar(20),
    @p_W_U_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[sel_WASP_User]
        (
            [W_U_User_Name],
            [W_U_Password],
            [W_U_Full_Name],
            [W_U_Designation],
            [W_U_GP_User_Name]
        )
    VALUES
        (
             @p_W_U_User_Name,
             @p_W_U_Password,
             @p_W_U_Full_Name,
             @p_W_U_Designation,
             @p_W_U_GP_User_Name
        )

    SET @p_W_U_ID_out = SCOPE_IDENTITY()

END

