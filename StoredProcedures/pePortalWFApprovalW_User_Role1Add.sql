if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_User_Role1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_User_Role1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[W_User_Role] table.
CREATE PROCEDURE pePortalWFApprovalW_User_Role1Add
    @p_W_UR_U_ID int,
    @p_W_UR_R_ID int,
    @p_W_UR_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[W_User_Role]
        (
            [W_UR_U_ID],
            [W_UR_R_ID]
        )
    VALUES
        (
             @p_W_UR_U_ID,
             @p_W_UR_R_ID
        )

    SET @p_W_UR_ID_out = SCOPE_IDENTITY()

END

