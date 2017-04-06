if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_PM00200Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_PM00200Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_PM00200] table.
CREATE PROCEDURE pePortalWFApprovalSel_PM00200Add
    @p_VENDORID char(15),
    @p_VENDNAME char(65),
    @p_Company_ID int
AS
BEGIN
    INSERT
    INTO [dbo].[sel_PM00200]
        (
            [VENDORID],
            [VENDNAME],
            [Company_ID]
        )
    VALUES
        (
             @p_VENDORID,
             @p_VENDNAME,
             @p_Company_ID
        )

END

