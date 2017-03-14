if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWF_Complete_Notify1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWF_Complete_Notify1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WF_Complete_Notify] table.
CREATE PROCEDURE pePortalWFApprovalWF_Complete_Notify1Delete
        @pk_WFCN_ID int
AS
BEGIN
    DELETE [dbo].[WF_Complete_Notify]
    WHERE [WFCN_ID] = @pk_WFCN_ID
END

