if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WCAR_Activity_WCAR_DocGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WCAR_Activity_WCAR_DocGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[sel_WCAR_Activity_WCAR_Doc] table.
CREATE PROCEDURE pePortalWFApprovalSel_WCAR_Activity_WCAR_DocGet
        @pk_WCA_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[sel_WCAR_Activity_WCAR_Doc]
    WHERE [WCA_ID] =@pk_WCA_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WCA_ID],
        [WCA_WS_ID],
        [WCA_WSD_ID],
        [WCA_WDT_ID],
        [WCA_W_U_ID],
        [WCA_WCD_ID],
        [WCA_Status],
        [WCA_Date_Assign],
        [WCA_Date_Action],
        [WCA_Remark],
        [WCD_No],
        [WCD_Project_Title],
        [WCD_Exp_Total],
        [WCA_Is_Done],
        [WCD_U_ID],
        [WCD_Remark],
        [WCD_WCur_ID],
        [WCD_Request_Date],
        [WCD_C_ID],
        [SSC_CompanyID],
        CAST(BINARY_CHECKSUM([WCA_ID],[WCA_WS_ID],[WCA_WSD_ID],[WCA_WDT_ID],[WCA_W_U_ID],[WCA_WCD_ID],[WCA_Status],[WCA_Date_Assign],[WCA_Date_Action],[WCA_Remark],[WCD_No],[WCD_Project_Title],[WCD_Exp_Total],[WCA_Is_Done],[WCD_U_ID],[WCD_Remark],[WCD_WCur_ID],[WCD_Request_Date],[WCD_C_ID],[SSC_CompanyID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[sel_WCAR_Activity_WCAR_Doc]
    WHERE [WCA_ID] =@pk_WCA_ID
    SET NOCOUNT OFF
END

