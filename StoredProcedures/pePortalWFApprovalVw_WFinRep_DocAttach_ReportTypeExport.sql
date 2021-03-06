﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_WFinRep_DocAttach_ReportTypeExport') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_WFinRep_DocAttach_ReportTypeExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pePortalWFApprovalVw_WFinRep_DocAttach_ReportTypeExport
        @p_separator_str nvarchar(15),
        @p_title_str nvarchar(max),
        @p_select_str nvarchar(max),
        @p_join_str nvarchar(max),
        @p_where_str nvarchar(max),
        @p_num_exported int output
    AS
    DECLARE
        @l_title_str nvarchar(max),
        @l_select_str nvarchar(max),
        @l_from_str nvarchar(max),
        @l_join_str nvarchar(max),
        @l_where_str nvarchar(max),
        @l_query_select nvarchar(max),
        @l_query_union nvarchar(max),
        @l_query_from nvarchar(max)
    BEGIN
        -- Set up the title string from the column names.  Excel 
        -- will complain if the first column value is ID. So wrap
        -- the value with "".
        SET @l_title_str = @p_title_str + char(13)
        IF @p_title_str IS NULL
            BEGIN
            SET @l_title_str = 
                N'"FIN_ID"' + @p_separator_str +
                N'"FIN_Year"' + @p_separator_str +
                N'"FIN_Month"' + @p_separator_str +
                N'"FIN_Type"' + @p_separator_str +
                N'"FIn_Description"' + @p_separator_str +
                N'"FIN_Company"' + @p_separator_str +
                N'"FIN_Status"' + @p_separator_str +
                N'"FIN_File1"' + @p_separator_str +
                N'"FIN_RptID"' + @p_separator_str +
                N'"FIN_Post"' + @p_separator_str +
                N'"FIN_RWRem"' + @p_separator_str +
                N'"FIN_HFIN_ID"' + @p_separator_str +
                N'"WFRT_SortOrder"' + @p_separator_str +
                N'"WFRT_Description"' + ' ';
            END
        ELSE IF SUBSTRING(@l_title_str, 1, 2) = 'ID'
            SET @l_title_str = 
                '"' + 
                SUBSTRING(@l_title_str, 1, PATINDEX('%,%', @l_title_str)-1) + 
                '"' + 
                SUBSTRING(@l_title_str, PATINDEX('%,%', @l_title_str), LEN(@l_title_str)); 

        -- Set up the select string
        SET @l_select_str = @p_select_str
        IF @p_select_str IS NULL
            BEGIN
            SET @l_select_str = 
                N'IsNULL(Convert(nvarchar, vw_WFinRep_DocAttach_ReportType_.[FIN_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, vw_WFinRep_DocAttach_ReportType_.[FIN_Year]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, vw_WFinRep_DocAttach_ReportType_.[FIN_Month]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(vw_WFinRep_DocAttach_ReportType_.[FIN_Type], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(vw_WFinRep_DocAttach_ReportType_.[FIn_Description], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, vw_WFinRep_DocAttach_ReportType_.[FIN_Company]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, vw_WFinRep_DocAttach_ReportType_.[FIN_Status]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(vw_WFinRep_DocAttach_ReportType_.[FIN_File1], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, vw_WFinRep_DocAttach_ReportType_.[FIN_RptID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, vw_WFinRep_DocAttach_ReportType_.[FIN_Post]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(vw_WFinRep_DocAttach_ReportType_.[FIN_RWRem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, vw_WFinRep_DocAttach_ReportType_.[FIN_HFIN_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, vw_WFinRep_DocAttach_ReportType_.[WFRT_SortOrder]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(vw_WFinRep_DocAttach_ReportType_.[WFRT_Description], ''''), N''"'', N''""'') + N''"''  + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[vw_WFinRep_DocAttach_ReportType] vw_WFinRep_DocAttach_ReportType_';

        SET @l_join_str = @p_join_str
        if @p_join_str is null
            SET @l_join_str = ' ';

        -- Set up the where string
        SET @l_where_str = ' ';
        IF @p_where_str IS NOT NULL
            SET @l_where_str = @l_where_str + 'WHERE ' + @p_where_str;

        -- Construct the query string.  Append the result set with the title.
        SET @l_query_select = 
                'SELECT '''
        SET @l_query_union = 
                ''' UNION ALL ' +
                'SELECT '
        SET @l_query_from = 
                ' FROM ' + @l_from_str + ' ' + @l_join_str + ' ' +
                @l_where_str;

        -- Run the query
        EXECUTE (@l_query_select + @l_title_str + @l_query_union + @l_select_str+ @l_query_from)

        -- Return the total number of rows of the query
        SELECT @p_num_exported = @@rowcount
    END

