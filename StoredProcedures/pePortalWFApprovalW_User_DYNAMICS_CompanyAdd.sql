if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_User_DYNAMICS_CompanyAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_User_DYNAMICS_CompanyAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[W_User_DYNAMICS_Company] table.
CREATE PROCEDURE pePortalWFApprovalW_User_DYNAMICS_CompanyAdd
    @p_W_UDC_U_ID int,
    @p_W_UDC_C_ID smallint,
    @p_W_UDC_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[W_User_DYNAMICS_Company]
        (
            [W_UDC_U_ID],
            [W_UDC_C_ID]
        )
    VALUES
        (
             @p_W_UDC_U_ID,
             @p_W_UDC_C_ID
        )

    SET @p_W_UDC_ID_out = SCOPE_IDENTITY()

END

