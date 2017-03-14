if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_StepGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_StepGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WPO_Step] table.
CREATE PROCEDURE pePortalWFApprovalWPO_StepGet
        @pk_WPO_S_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WPO_Step]
    WHERE [WPO_S_ID] =@pk_WPO_S_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WPO_S_ID],
        [WPO_S_WDT_ID],
        [WPO_S_ID_Next],
        [WPO_S_Step_Type],
        [WPO_S_Desc],
        [WPO_S_Approval_Needed],
        [WPO_S_C_ID],
        CAST(BINARY_CHECKSUM([WPO_S_ID],[WPO_S_WDT_ID],[WPO_S_ID_Next],[WPO_S_Step_Type],[WPO_S_Desc],[WPO_S_Approval_Needed],[WPO_S_C_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WPO_Step]
    WHERE [WPO_S_ID] =@pk_WPO_S_ID
    SET NOCOUNT OFF
END

