if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWASS_Dynamics_Comp_EqAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWASS_Dynamics_Comp_EqAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WASS_Dynamics_Comp_Eq] table.
CREATE PROCEDURE pePortalWFApprovalWASS_Dynamics_Comp_EqAdd
    @p_WDCE_WASS_CompID int,
    @p_WDCE_Dynamics_CompID int,
    @p_WDCE_CompName varchar(50),
    @p_WDCE_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WASS_Dynamics_Comp_Eq]
        (
            [WDCE_WASS_CompID],
            [WDCE_Dynamics_CompID],
            [WDCE_CompName]
        )
    VALUES
        (
             @p_WDCE_WASS_CompID,
             @p_WDCE_Dynamics_CompID,
             @p_WDCE_CompName
        )

    SET @p_WDCE_ID_out = SCOPE_IDENTITY()

END

