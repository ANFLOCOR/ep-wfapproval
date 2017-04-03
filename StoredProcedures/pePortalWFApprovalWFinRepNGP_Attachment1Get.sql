if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepNGP_Attachment1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepNGP_Attachment1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WFinRepNGP_Attachment] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepNGP_Attachment1Get
        @pk_WFRNGPAt_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WFinRepNGP_Attachment]
    WHERE [WFRNGPAt_ID] =@pk_WFRNGPAt_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WFRNGPAt_ID],
        [WFRNGPAt_WFRCHNGP_ID],
        [WFRNGPAt_Desc],
        [WFRNGPAt_Doc],
        CAST(BINARY_CHECKSUM([WFRNGPAt_ID],[WFRNGPAt_WFRCHNGP_ID],[WFRNGPAt_Desc],[WFRNGPAt_Doc]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WFinRepNGP_Attachment]
    WHERE [WFRNGPAt_ID] =@pk_WFRNGPAt_ID
    SET NOCOUNT OFF
END

