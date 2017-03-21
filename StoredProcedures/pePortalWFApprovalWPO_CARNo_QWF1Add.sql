if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_CARNo_QWF1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_CARNo_QWF1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WPO_CARNo_QWF] table.
CREATE PROCEDURE pePortalWFApprovalWPO_CARNo_QWF1Add
    @p_CompanyID smallint,
    @p_PONum char(30),
    @p_PRNum varchar(50),
    @p_Comment varchar(500),
    @p_CARID int,
    @p_WCD_No varchar(50),
    @p_WCD_Remark varchar(250),
    @p_WCD_Project_Title varchar(max),
    @p_WCD_Exp_Total numeric(18,2),
    @p_WCD_ID int
AS
BEGIN
    INSERT
    INTO [dbo].[WPO_CARNo_QWF]
        (
            [CompanyID],
            [PONum],
            [PRNum],
            [Comment],
            [CARID],
            [WCD_No],
            [WCD_Remark],
            [WCD_Project_Title],
            [WCD_Exp_Total],
            [WCD_ID]
        )
    VALUES
        (
             @p_CompanyID,
             @p_PONum,
             @p_PRNum,
             @p_Comment,
             @p_CARID,
             @p_WCD_No,
             @p_WCD_Remark,
             @p_WCD_Project_Title,
             @p_WCD_Exp_Total,
             @p_WCD_ID
        )

END

