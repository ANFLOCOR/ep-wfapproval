﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_WFinRep_DocAttach_FIN_MonthDeleteRecords') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_WFinRep_DocAttach_FIN_MonthDeleteRecords 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a set of rows from the [dbo].[vw_WFinRep_DocAttach_FIN_Month] table
-- that match the specified search criteria.
-- Returns the number of rows deleted as an output parameter.
CREATE PROCEDURE pePortalWFApprovalVw_WFinRep_DocAttach_FIN_MonthDeleteRecords
        @p_where_str nvarchar(max),
        @p_num_deleted int OUTPUT
AS
DECLARE
    @l_where_str nvarchar(max),
    @l_query_str nvarchar(max)
BEGIN

    -- Initialize the where string
    SET @l_where_str = ' '
    IF @p_where_str IS NOT NULL
        SET @l_where_str = ' WHERE ' + @p_where_str;

    SET @p_num_deleted = 0;

    -- Set up the query string
    SET @l_query_str =
        'DELETE [dbo].[vw_WFinRep_DocAttach_FIN_Month] ' +
        'FROM [dbo].[vw_WFinRep_DocAttach_FIN_Month] Vw_WFinRep_DocAttac_671747064_' +
        @l_where_str + ' ';

    -- Run the query
    EXECUTE (@l_query_str)

    -- Return the number of rows affected to the output parameter
    SELECT @p_num_deleted = @@ROWCOUNT

END

