if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWTask_DelegationDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWTask_DelegationDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WTask_Delegation] table.
CREATE PROCEDURE pePortalWFApprovalWTask_DelegationDelete
        @pk_WTD_ID int
AS
BEGIN
    DELETE [dbo].[WTask_Delegation]
    WHERE [WTD_ID] = @pk_WTD_ID
END

