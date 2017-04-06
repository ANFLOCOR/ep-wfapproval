if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WASP_WF_Approver2Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WASP_WF_Approver2Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_WASP_WF_Approver] table.
CREATE PROCEDURE pePortalWFApprovalSel_WASP_WF_Approver2Add
    @p_W_U_ID int,
    @p_W_U_User_Name varchar(20),
    @p_W_U_Full_Name varchar(125),
    @p_W_R_ID int,
    @p_W_R_Name varchar(125)
AS
BEGIN
    INSERT
    INTO [dbo].[sel_WASP_WF_Approver]
        (
            [W_U_ID],
            [W_U_User_Name],
            [W_U_Full_Name],
            [W_R_ID],
            [W_R_Name]
        )
    VALUES
        (
             @p_W_U_ID,
             @p_W_U_User_Name,
             @p_W_U_Full_Name,
             @p_W_R_ID,
             @p_W_R_Name
        )

END

