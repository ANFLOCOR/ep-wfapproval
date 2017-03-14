if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCAR_Doc_Checker1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCAR_Doc_Checker1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WCAR_Doc_Checker] table.
CREATE PROCEDURE pePortalWFApprovalWCAR_Doc_Checker1Get
        @pk_WCDC_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WCAR_Doc_Checker]
    WHERE [WCDC_ID] =@pk_WCDC_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WCDC_ID],
        [WCDC_WCD_ID],
        [WCDC_U_ID],
        [WCDC_Status],
        [WCDC_Rem],
        CAST(BINARY_CHECKSUM([WCDC_ID],[WCDC_WCD_ID],[WCDC_U_ID],[WCDC_Status],[WCDC_Rem]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WCAR_Doc_Checker]
    WHERE [WCDC_ID] =@pk_WCDC_ID
    SET NOCOUNT OFF
END

