if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalView_WCPO_Canvass11Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalView_WCPO_Canvass11Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[view_WCPO_Canvass1] table.
CREATE PROCEDURE pePortalWFApprovalView_WCPO_Canvass11Get
        @pk_CompanyID smallint,    @pk_PONo char(17),    @pk_Classification int,    @pk_WCI_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[view_WCPO_Canvass1]
    WHERE [CompanyID] =@pk_CompanyID and [PONo] =@pk_PONo and [Classification] =@pk_Classification and [WCI_ID] =@pk_WCI_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [CompanyID],
        [PONo],
        [PRID],
        [CanvassDate],
        [WCI_Submit],
        [WCI_Status],
        [Classification],
        [Buyer],
        [WCI_ID],
        CAST(BINARY_CHECKSUM([CompanyID],[PONo],[PRID],[CanvassDate],[WCI_Submit],[WCI_Status],[Classification],[Buyer],[WCI_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[view_WCPO_Canvass1]
    WHERE [CompanyID] =@pk_CompanyID and [PONo] =@pk_PONo and [Classification] =@pk_Classification and [WCI_ID] =@pk_WCI_ID
    SET NOCOUNT OFF
END

