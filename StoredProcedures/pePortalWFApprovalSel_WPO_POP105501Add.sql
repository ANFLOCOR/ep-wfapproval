if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WPO_POP105501Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WPO_POP105501Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_WPO_POP10550] table.
CREATE PROCEDURE pePortalWFApprovalSel_WPO_POP105501Add
    @p_DOCTYPE smallint,
    @p_POPNUMBE char(17),
    @p_ORD int,
    @p_COMMENTS varchar(204),
    @p_CompanyID int
AS
BEGIN
    INSERT
    INTO [dbo].[sel_WPO_POP10550]
        (
            [DOCTYPE],
            [POPNUMBE],
            [ORD],
            [COMMENTS],
            [CompanyID]
        )
    VALUES
        (
             @p_DOCTYPE,
             @p_POPNUMBE,
             @p_ORD,
             @p_COMMENTS,
             @p_CompanyID
        )

END

