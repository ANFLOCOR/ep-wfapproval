if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_POP10100_IncidentalDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_POP10100_IncidentalDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[sel_POP10100_Incidental] table.
CREATE PROCEDURE pePortalWFApprovalSel_POP10100_IncidentalDelete
        @pk_PONUMBER char(17),
    @pk_Company_ID int
AS
BEGIN
    DELETE [dbo].[sel_POP10100_Incidental]
    WHERE [PONUMBER] = @pk_PONUMBER
    AND [Company_ID] = @pk_Company_ID
END

