if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_PRNo_QWF1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_PRNo_QWF1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WPO_PRNo_QWF] table.
CREATE PROCEDURE pePortalWFApprovalWPO_PRNo_QWF1Get
        @pk_CompanyID smallint,    @pk_PRNo varchar(50),    @pk_PONo char(30)
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WPO_PRNo_QWF]
    WHERE [CompanyID] =@pk_CompanyID and [PRNo] =@pk_PRNo and [PONo] =@pk_PONo

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [CompanyID],
        [PRNo],
        [WPRD_Title],
        [WPRD_Created],
        [WPRD_Total],
        [Comment],
        [PONo],
        [WPRD_ID],
        CAST(BINARY_CHECKSUM([CompanyID],[PRNo],[WPRD_Title],[WPRD_Created],[WPRD_Total],[Comment],[PONo],[WPRD_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WPO_PRNo_QWF]
    WHERE [CompanyID] =@pk_CompanyID and [PRNo] =@pk_PRNo and [PONo] =@pk_PONo
    SET NOCOUNT OFF
END

