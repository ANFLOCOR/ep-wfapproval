if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalView_WCPO_CanvassAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalView_WCPO_CanvassAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[view_WCPO_Canvass] table.
CREATE PROCEDURE pePortalWFApprovalView_WCPO_CanvassAdd
    @p_CompanyID smallint,
    @p_PONo char(17),
    @p_PRID int,
    @p_CanvassDate smalldatetime,
    @p_Vendors smallint,
    @p_WCI_Submit bit,
    @p_WCI_Status varchar(20),
    @p_Classification int,
    @p_Buyer int,
    @p_WCI_ID int
AS
BEGIN
    INSERT
    INTO [dbo].[view_WCPO_Canvass]
        (
            [CompanyID],
            [PONo],
            [PRID],
            [CanvassDate],
            [Vendors],
            [WCI_Submit],
            [WCI_Status],
            [Classification],
            [Buyer],
            [WCI_ID]
        )
    VALUES
        (
             @p_CompanyID,
             @p_PONo,
             @p_PRID,
             @p_CanvassDate,
             @p_Vendors,
             @p_WCI_Submit,
             @p_WCI_Status,
             @p_Classification,
             @p_Buyer,
             @p_WCI_ID
        )

END

