if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WPO_InquireDetailsGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WPO_InquireDetailsGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[sel_WPO_InquireDetails] table.
CREATE PROCEDURE pePortalWFApprovalSel_WPO_InquireDetailsGet
        @pk_CompanyID int,    @pk_PONUMBER char(17),    @pk_LineNumber smallint,    @pk_ITEMNMBR char(31)
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[sel_WPO_InquireDetails]
    WHERE [CompanyID] =@pk_CompanyID and [PONUMBER] =@pk_PONUMBER and [LineNumber] =@pk_LineNumber and [ITEMNMBR] =@pk_ITEMNMBR

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [CompanyID],
        [PONUMBER],
        [LineNumber],
        [ITEMNMBR],
        [ITEMDESC],
        [UOFM],
        [UNITCOST],
        [QTYORDER],
        [EXTDCOST],
        [DOCDATE],
        [REQSTDBY],
        [ORD],
        [COMMENTS],
        [COMMENT_4],
        [WPOFR_Unit_Cost],
        [WCur_Short],
        [WPOFR_Rate],
        CAST(BINARY_CHECKSUM([CompanyID],[PONUMBER],[LineNumber],[ITEMNMBR],[ITEMDESC],[UOFM],[UNITCOST],[QTYORDER],[EXTDCOST],[DOCDATE],[REQSTDBY],[ORD],[COMMENTS],[COMMENT_4],[WPOFR_Unit_Cost],[WCur_Short],[WPOFR_Rate]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[sel_WPO_InquireDetails]
    WHERE [CompanyID] =@pk_CompanyID and [PONUMBER] =@pk_PONUMBER and [LineNumber] =@pk_LineNumber and [ITEMNMBR] =@pk_ITEMNMBR
    SET NOCOUNT OFF
END

