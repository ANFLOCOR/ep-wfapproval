if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWDoc_TypeDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWDoc_TypeDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WDoc_Type] table.
CREATE PROCEDURE pePortalWFApprovalWDoc_TypeDelete
        @pk_WDT_ID int
AS
BEGIN
    DELETE [dbo].[WDoc_Type]
    WHERE [WDT_ID] = @pk_WDT_ID
END

