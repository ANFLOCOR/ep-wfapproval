if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_PRNo_QDetails1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_PRNo_QDetails1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WPO_PRNo_QDetails] table.
CREATE PROCEDURE pePortalWFApprovalWPO_PRNo_QDetails1Add
    @p_CompanyID smallint,
    @p_PRNo varchar(50),
    @p_WPRD_Title varchar(250),
    @p_WPRD_Created smalldatetime,
    @p_WPRD_Total numeric(15,2),
    @p_Comment varchar(500),
    @p_PONo char(30),
    @p_WPRD_ID int
AS
BEGIN
    INSERT
    INTO [dbo].[WPO_PRNo_QDetails]
        (
            [CompanyID],
            [PRNo],
            [WPRD_Title],
            [WPRD_Created],
            [WPRD_Total],
            [Comment],
            [PONo],
            [WPRD_ID]
        )
    VALUES
        (
             @p_CompanyID,
             @p_PRNo,
             @p_WPRD_Title,
             @p_WPRD_Created,
             @p_WPRD_Total,
             @p_Comment,
             @p_PONo,
             @p_WPRD_ID
        )

END

