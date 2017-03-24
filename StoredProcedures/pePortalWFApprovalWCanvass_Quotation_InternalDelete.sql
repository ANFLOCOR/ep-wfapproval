if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_Quotation_InternalDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_Quotation_InternalDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WCanvass_Quotation_Internal] table.
CREATE PROCEDURE pePortalWFApprovalWCanvass_Quotation_InternalDelete
        @pk_WCQI_ID int
AS
BEGIN
    DELETE [dbo].[WCanvass_Quotation_Internal]
    WHERE [WCQI_ID] = @pk_WCQI_ID
END

