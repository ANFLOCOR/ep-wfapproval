if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_UserAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_UserAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[W_User] table.
CREATE PROCEDURE pePortalWFApprovalW_UserAdd
    @p_W_U_User_Name varchar(20),
    @p_W_U_Password varchar(20),
    @p_W_U_Full_Name varchar(125),
    @p_W_U_Email varchar(40),
    @p_W_U_GP_User_Name varchar(20),
    @p_W_U_Designation varchar(250),
    @p_W_U_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[W_User]
        (
            [W_U_User_Name],
            [W_U_Password],
            [W_U_Full_Name],
            [W_U_Email],
            [W_U_GP_User_Name],
            [W_U_Designation]
        )
    VALUES
        (
             @p_W_U_User_Name,
             @p_W_U_Password,
             @p_W_U_Full_Name,
             @p_W_U_Email,
             @p_W_U_GP_User_Name,
             @p_W_U_Designation
        )

    SET @p_W_U_ID_out = SCOPE_IDENTITY()

END

