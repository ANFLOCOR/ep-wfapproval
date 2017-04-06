if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_CAR_Rpt_ActivityRemGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_CAR_Rpt_ActivityRemGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[sel_CAR_Rpt_ActivityRem] table.
CREATE PROCEDURE pePortalWFApprovalSel_CAR_Rpt_ActivityRemGet
        @pk_WCA_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[sel_CAR_Rpt_ActivityRem]
    WHERE [WCA_ID] =@pk_WCA_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WCD_No],
        [WCD_C_ID],
        [WCA_Remark],
        [WCA_ID],
        [WCA_Status],
        CAST(BINARY_CHECKSUM([WCD_No],[WCD_C_ID],[WCA_Remark],[WCA_ID],[WCA_Status]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[sel_CAR_Rpt_ActivityRem]
    WHERE [WCA_ID] =@pk_WCA_ID
    SET NOCOUNT OFF
END

