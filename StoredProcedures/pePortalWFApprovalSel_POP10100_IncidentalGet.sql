if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_POP10100_IncidentalGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_POP10100_IncidentalGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[sel_POP10100_Incidental] table.
CREATE PROCEDURE pePortalWFApprovalSel_POP10100_IncidentalGet
        @pk_PONUMBER char(17),    @pk_Company_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[sel_POP10100_Incidental]
    WHERE [PONUMBER] =@pk_PONUMBER and [Company_ID] =@pk_Company_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [PONUMBER],
        [POSTATUS],
        [DOCDATE],
        [SUBTOTAL],
        [VENDORID],
        [VENDNAME],
        [Company_ID],
        [PRMDATE],
        [SHIPMTHD],
        [TAXAMNT],
        [PYMTRMID],
        [COMMNTID],
        CAST(BINARY_CHECKSUM([PONUMBER],[POSTATUS],[DOCDATE],[SUBTOTAL],[VENDORID],[VENDNAME],[Company_ID],[PRMDATE],[SHIPMTHD],[TAXAMNT],[PYMTRMID],[COMMNTID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[sel_POP10100_Incidental]
    WHERE [PONUMBER] =@pk_PONUMBER and [Company_ID] =@pk_Company_ID
    SET NOCOUNT OFF
END

