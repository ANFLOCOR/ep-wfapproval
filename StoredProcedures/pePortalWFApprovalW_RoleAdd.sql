if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_RoleAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_RoleAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[W_Role] table.
CREATE PROCEDURE pePortalWFApprovalW_RoleAdd
    @p_W_R_A_ID smallint,
    @p_W_R_Name varchar(125),
    @p_W_R_Desc varchar(250),
    @p_W_R_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[W_Role]
        (
            [W_R_A_ID],
            [W_R_Name],
            [W_R_Desc]
        )
    VALUES
        (
             @p_W_R_A_ID,
             @p_W_R_Name,
             @p_W_R_Desc
        )

    SET @p_W_R_ID_out = SCOPE_IDENTITY()

END

