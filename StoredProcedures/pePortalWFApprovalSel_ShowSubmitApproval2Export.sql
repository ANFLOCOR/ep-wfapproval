﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_ShowSubmitApproval2Export') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_ShowSubmitApproval2Export 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pePortalWFApprovalSel_ShowSubmitApproval2Export
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
                N'"PONUMBER"' + @p_separator_str +
                N'"POSTATUS"' + @p_separator_str +
                N'"DOCDATE"' + @p_separator_str +
                N'"SUBTOTAL"' + @p_separator_str +
                N'"TRDISAMT"' + @p_separator_str +
                N'"FRTAMNT"' + @p_separator_str +
                N'"MSCCHAMT"' + @p_separator_str +
                N'"TAXAMNT"' + @p_separator_str +
                N'"VENDORID"' + @p_separator_str +
                N'"VENDNAME"' + @p_separator_str +
                N'"CMPANYID"' + @p_separator_str +
                N'"COMMNTID"' + @p_separator_str +
                N'"BUYERID"' + @p_separator_str +
                N'"Workflow_Approval_Status"' + @p_separator_str +
                N'"CompanyID"' + @p_separator_str +
                N'"WPOP_PONMBR"' + @p_separator_str +
                N'"REMARKS"' + @p_separator_str +
                N'"POTOTAL"' + @p_separator_str +
                N'"POP_Status"' + ' ';
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
                N'N''"'' + REPLACE(IsNULL(sel_ShowSubmitApproval_.[PONUMBER], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_ShowSubmitApproval_.[POSTATUS]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_ShowSubmitApproval_.[DOCDATE], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_ShowSubmitApproval_.[SUBTOTAL]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_ShowSubmitApproval_.[TRDISAMT]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_ShowSubmitApproval_.[FRTAMNT]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_ShowSubmitApproval_.[MSCCHAMT]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_ShowSubmitApproval_.[TAXAMNT]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_ShowSubmitApproval_.[VENDORID], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_ShowSubmitApproval_.[VENDNAME], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_ShowSubmitApproval_.[CMPANYID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_ShowSubmitApproval_.[COMMNTID], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_ShowSubmitApproval_.[BUYERID], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_ShowSubmitApproval_.[Workflow_Approval_Status]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_ShowSubmitApproval_.[CompanyID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_ShowSubmitApproval_.[WPOP_PONMBR], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_ShowSubmitApproval_.[REMARKS], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_ShowSubmitApproval_.[POTOTAL]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_ShowSubmitApproval_.[POP_Status]), '''') + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[sel_ShowSubmitApproval] sel_ShowSubmitApproval_';

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

