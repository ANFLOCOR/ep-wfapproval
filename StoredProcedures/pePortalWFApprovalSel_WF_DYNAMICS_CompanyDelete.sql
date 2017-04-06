if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WF_DYNAMICS_CompanyDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WF_DYNAMICS_CompanyDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_WF_DYNAMICS_Company] table.
CREATE PROCEDURE pePortalWFApprovalSel_WF_DYNAMICS_CompanyDelete
        @pk_Company_ID smallint
AS
BEGIN
    DELETE [dbo].[sel_WF_DYNAMICS_Company]
    WHERE [Company_ID] = @pk_Company_ID
END

