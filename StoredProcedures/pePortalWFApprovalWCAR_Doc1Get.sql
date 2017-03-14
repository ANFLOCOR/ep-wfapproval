if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCAR_Doc1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCAR_Doc1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WCAR_Doc] table.
CREATE PROCEDURE pePortalWFApprovalWCAR_Doc1Get
        @pk_WCD_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WCAR_Doc]
    WHERE [WCD_ID] =@pk_WCD_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WCD_ID],
        [WCD_WDT_ID],
        [WCD_No],
        [WCD_Submit],
        [WCD_Status],
        [WCD_Remark],
        [WCD_Unit_Location],
        [WCD_Project_Title],
        [WCD_Project_No],
        [WCD_Request_Date],
        [WCD_Proj_Inc_ACB],
        [WCD_Exp_Total],
        [WCD_Exp_Prev_Total],
        [WCD_Exp_Budget],
        [WCD_Exp_Under_Over_Budget],
        [WCD_Exp_Cur_Yr],
        [WCD_Exp_Nxt_Yr],
        [WCD_Exp_Sub_Yr],
        [WCD_C_ID],
        [WCD_U_ID],
        [WCD_Created],
        [WCD_WCur_ID],
        [WCD_Supplementary],
        [WCD_Supplementary_WCD_ID],
        [WCD_Supplementary_Manual],
        CAST(BINARY_CHECKSUM([WCD_ID],[WCD_WDT_ID],[WCD_No],[WCD_Submit],[WCD_Status],[WCD_Remark],[WCD_Unit_Location],[WCD_Project_Title],[WCD_Project_No],[WCD_Request_Date],[WCD_Proj_Inc_ACB],[WCD_Exp_Total],[WCD_Exp_Prev_Total],[WCD_Exp_Budget],[WCD_Exp_Under_Over_Budget],[WCD_Exp_Cur_Yr],[WCD_Exp_Nxt_Yr],[WCD_Exp_Sub_Yr],[WCD_C_ID],[WCD_U_ID],[WCD_Created],[WCD_WCur_ID],[WCD_Supplementary],[WCD_Supplementary_WCD_ID],[WCD_Supplementary_Manual]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WCAR_Doc]
    WHERE [WCD_ID] =@pk_WCD_ID
    SET NOCOUNT OFF
END

