if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_CARNo_QDetailsGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_CARNo_QDetailsGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WPO_CARNo_QDetails] table.
CREATE PROCEDURE pePortalWFApprovalWPO_CARNo_QDetailsGet
        @pk_PONum char(30),    @pk_PRNum varchar(50)
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WPO_CARNo_QDetails]
    WHERE [PONum] =@pk_PONum and [PRNum] =@pk_PRNum

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [CompanyID],
        [PONum],
        [PRNum],
        [Comment],
        [CARID],
        [WCD_No],
        [WCD_Remark],
        [WCD_Project_Title],
        [WCD_Exp_Total],
        [WCD_ID],
        CAST(BINARY_CHECKSUM([CompanyID],[PONum],[PRNum],[Comment],[CARID],[WCD_No],[WCD_Remark],[WCD_Project_Title],[WCD_Exp_Total],[WCD_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WPO_CARNo_QDetails]
    WHERE [PONum] =@pk_PONum and [PRNum] =@pk_PRNum
    SET NOCOUNT OFF
END

