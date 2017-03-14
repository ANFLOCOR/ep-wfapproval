if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWASS_Dynamics_Comp_EqDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWASS_Dynamics_Comp_EqDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WASS_Dynamics_Comp_Eq] table.
CREATE PROCEDURE pePortalWFApprovalWASS_Dynamics_Comp_EqDelete
        @pk_WDCE_ID int
AS
BEGIN
    DELETE [dbo].[WASS_Dynamics_Comp_Eq]
    WHERE [WDCE_ID] = @pk_WDCE_ID
END

