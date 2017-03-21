if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_PO_Map_Temp1Export') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_PO_Map_Temp1Export 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pePortalWFApprovalWCanvass_PO_Map_Temp1Export
        @p_separator_str nvarchar(15),
        @p_title_str nvarchar(max),
        @p_select_str nvarchar(max),
        @p_join_str nvarchar(max),
        @p_where_str nvarchar(max),
        @p_num_exported int output
    AS
    DECLARE
        @l_title_str nvarchar(max),
        @l_select_str1 nvarchar(max),
        @l_select_str2 nvarchar(max),
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
                N'"Temp_ID"' + @p_separator_str +
                N'"WCDI_ID"' + @p_separator_str +
                N'"WCDI_WCI_ID"' + @p_separator_str +
                N'"WCDI_WPRL_ID"' + @p_separator_str +
                N'"WCDI_Status"' + @p_separator_str +
                N'"WCDI_Audit_Comment"' + @p_separator_str +
                N'"WCDI_Comment"' + @p_separator_str +
                N'"WCDI_PM00200_Vendor"' + @p_separator_str +
                N'"WCDI_Qty"' + @p_separator_str +
                N'"WCDI_Bid"' + @p_separator_str +
                N'"WCDI_Award"' + @p_separator_str +
                N'"WPRL_WPRD_ID"' + @p_separator_str +
                N'"Item"' + @p_separator_str +
                N'"ItemDescription"' + @p_separator_str +
                N'"UnitOfMeasure"' + @p_separator_str +
                N'"Site"' + @p_separator_str +
                N'"UnitPrice"' + @p_separator_str +
                N'"WPRL_Qty"' + @p_separator_str +
                N'"WPRL_Ext_Price"' + @p_separator_str +
                N'"WCI_C_ID"' + @p_separator_str +
                N'"WCI_Status"' + @p_separator_str +
                N'"WCI_U_ID"' + @p_separator_str +
                N'"WCI_WClass_ID"' + @p_separator_str +
                N'"WPRD_Created"' + @p_separator_str +
                N'"WCI_Date"' + @p_separator_str +
                N'"Offered_Qty"' + @p_separator_str +
                N'"Balance_Qty"' + @p_separator_str +
                N'"WCDI_Vat"' + @p_separator_str +
                N'"WCDI_Net"' + @p_separator_str +
                N'"WCDI_WCur_ID"' + @p_separator_str +
                N'"WPRD_Contract"' + @p_separator_str +
                N'"WCI_Contract_Done"' + @p_separator_str +
                N'"WCI_Contract_Closed"' + @p_separator_str +
                N'"WCI_Contract_U_ID"' + @p_separator_str +
                N'"Col_Marker"' + @p_separator_str +
                N'"Status"' + ' ';
            END
        ELSE IF SUBSTRING(@l_title_str, 1, 2) = 'ID'
            SET @l_title_str = 
                '"' + 
                SUBSTRING(@l_title_str, 1, PATINDEX('%,%', @l_title_str)-1) + 
                '"' + 
                SUBSTRING(@l_title_str, PATINDEX('%,%', @l_title_str), LEN(@l_title_str)); 

        -- Set up the select string
        SET @l_select_str1 = @p_select_str
        SET @l_select_str2 = @p_select_str
        IF @p_select_str IS NULL
            BEGIN
            SET @l_select_str1 = 
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[Temp_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WCDI_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WCDI_WCI_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WCDI_WPRL_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WCanvass_PO_Map_Temp_.[WCDI_Status], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WCanvass_PO_Map_Temp_.[WCDI_Audit_Comment], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WCanvass_PO_Map_Temp_.[WCDI_Comment], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WCanvass_PO_Map_Temp_.[WCDI_PM00200_Vendor], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WCDI_Qty]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WCDI_Bid]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WCDI_Award]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WPRL_WPRD_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WCanvass_PO_Map_Temp_.[Item], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WCanvass_PO_Map_Temp_.[ItemDescription], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WCanvass_PO_Map_Temp_.[UnitOfMeasure], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WCanvass_PO_Map_Temp_.[Site], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[UnitPrice]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WPRL_Qty]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WPRL_Ext_Price]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WCI_C_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WCanvass_PO_Map_Temp_.[WCI_Status], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WCI_U_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WCI_WClass_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WPRD_Created], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WCI_Date], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[Offered_Qty]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[Balance_Qty]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WCDI_Vat]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WCDI_Net]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WCDI_WCur_ID]), '''') + ''' + @p_separator_str + ''' +' 
            SET @l_select_str2 = 
                N'N''"'' + IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WPRD_Contract]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WCI_Contract_Done]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WCI_Contract_Closed], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[WCI_Contract_U_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WCanvass_PO_Map_Temp_.[Col_Marker]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WCanvass_PO_Map_Temp_.[Status], ''''), N''"'', N''""'') + N''"''  + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[WCanvass_PO_Map_Temp] WCanvass_PO_Map_Temp_';

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
        EXECUTE (@l_query_select + @l_title_str + @l_query_union + @l_select_str1 + @l_select_str2+ @l_query_from)

        -- Return the total number of rows of the query
        SELECT @p_num_exported = @@rowcount
    END

