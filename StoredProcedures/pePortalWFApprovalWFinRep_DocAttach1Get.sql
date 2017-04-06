if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_DocAttach1Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_DocAttach1Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WFinRep_DocAttach] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_DocAttach1Get
        @pk_FIN_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WFinRep_DocAttach]
    WHERE [FIN_ID] =@pk_FIN_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [FIN_ID],
        [FIN_Year],
        [FIN_Month],
        [FIN_Type],
        [FIn_Description],
        [FIN_File],
        [FIN_Company],
        [FIN_Status],
        [FIN_File1],
        [FIN_RptID],
        [FIN_Post],
        [FIN_RWRem],
        [FIN_HFIN_ID],
        CAST(BINARY_CHECKSUM([FIN_ID],[FIN_Year],[FIN_Month],[FIN_Type],[FIn_Description],[FIN_File],[FIN_Company],[FIN_Status],[FIN_File1],[FIN_RptID],[FIN_Post],[FIN_RWRem],[FIN_HFIN_ID]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WFinRep_DocAttach]
    WHERE [FIN_ID] =@pk_FIN_ID
    SET NOCOUNT OFF
END

