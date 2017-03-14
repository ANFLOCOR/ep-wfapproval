﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCAR_ActivityExport') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCAR_ActivityExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pePortalWFApprovalWCAR_ActivityExport
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
                N'"WCA_ID"' + @p_separator_str +
                N'"WCA_WS_ID"' + @p_separator_str +
                N'"""WCA_WS_ID"" WS_Desc"' + @p_separator_str +
                N'"WCA_WSD_ID"' + @p_separator_str +
                N'"""WCA_WSD_ID"" WSD_Desc"' + @p_separator_str +
                N'"WCA_WDT_ID"' + @p_separator_str +
                N'"""WCA_WDT_ID"" WDT_Name"' + @p_separator_str +
                N'"WCA_W_U_ID"' + @p_separator_str +
                N'"WCA_W_U_ID_Delegate"' + @p_separator_str +
                N'"WCA_WCD_ID"' + @p_separator_str +
                N'"""WCA_WCD_ID"" WCD_No"' + @p_separator_str +
                N'"WCA_Status"' + @p_separator_str +
                N'"WCA_Date_Assign"' + @p_separator_str +
                N'"WCA_Date_Action"' + @p_separator_str +
                N'"WCA_Remark"' + @p_separator_str +
                N'"WCA_Is_Done"' + ' ';
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
                N'IsNULL(Convert(nvarchar, WCAR_Activity_.[WCA_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCAR_Activity_.[WCA_WS_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[WS_Desc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCAR_Activity_.[WCA_WSD_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t1.[WSD_Desc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCAR_Activity_.[WCA_WDT_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t2.[WDT_Name], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCAR_Activity_.[WCA_W_U_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCAR_Activity_.[WCA_W_U_ID_Delegate]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCAR_Activity_.[WCA_WCD_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t5.[WCD_No], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WCAR_Activity_.[WCA_Status], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCAR_Activity_.[WCA_Date_Assign], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCAR_Activity_.[WCA_Date_Action], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WCAR_Activity_.[WCA_Remark], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, WCAR_Activity_.[WCA_Is_Done]), '''') + N''"'' + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[WCAR_Activity] WCAR_Activity_ LEFT OUTER JOIN [dbo].[WStep] t0 ON (WCAR_Activity_.[WCA_WS_ID] =  t0.[WS_ID]) LEFT OUTER JOIN [dbo].[WStep_Detail] t1 ON (WCAR_Activity_.[WCA_WSD_ID] =  t1.[WSD_ID]) LEFT OUTER JOIN [dbo].[WDoc_Type] t2 ON (WCAR_Activity_.[WCA_WDT_ID] =  t2.[WDT_ID]) LEFT OUTER JOIN [dbo].[WCAR_Doc] t5 ON (WCAR_Activity_.[WCA_WCD_ID] =  t5.[WCD_ID])';

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

