if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WPO_WFTaskGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WPO_WFTaskGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[sel_WPO_WFTask] table.
CREATE PROCEDURE pePortalWFApprovalSel_WPO_WFTaskGet
        @pk_PONUMBER char(17),    @pk_CompanyID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[sel_WPO_WFTask]
    WHERE [PONUMBER] =@pk_PONUMBER and [CompanyID] =@pk_CompanyID

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
        [TOTAL],
        [VENDORID],
        [VENDNAME],
        [BUYERID],
        [Workflow_Approval_Status],
        [CompanyID],
        [COMMENTS],
        [SUBTOTAL],
        [TRDISAMT],
        [FRTAMNT],
        [MSCCHAMT],
        [TAXAMNT],
        [isINC],
        CAST(BINARY_CHECKSUM([PONUMBER],[POSTATUS],[DOCDATE],[TOTAL],[VENDORID],[VENDNAME],[BUYERID],[Workflow_Approval_Status],[CompanyID],[COMMENTS],[SUBTOTAL],[TRDISAMT],[FRTAMNT],[MSCCHAMT],[TAXAMNT],[isINC]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[sel_WPO_WFTask]
    WHERE [PONUMBER] =@pk_PONUMBER and [CompanyID] =@pk_CompanyID
    SET NOCOUNT OFF
END

