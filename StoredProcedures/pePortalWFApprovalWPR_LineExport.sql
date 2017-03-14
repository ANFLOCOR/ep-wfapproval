if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_LineExport') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_LineExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pePortalWFApprovalWPR_LineExport
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
                N'"WPRL_ID"' + @p_separator_str +
                N'"WPRL_WPRD_ID"' + @p_separator_str +
                N'"""WPRL_WPRD_ID"" WPRD_No"' + @p_separator_str +
                N'"WPRL_IV00101_Item_No"' + @p_separator_str +
                N'"WPRL_IV40700_Locn_Code"' + @p_separator_str +
                N'"WPRL_PM00200_Vendor_ID"' + @p_separator_str +
                N'"WPRL_GL00101_Acct_Indx"' + @p_separator_str +
                N'"WPRL_IV00101_Prchs_UOM"' + @p_separator_str +
                N'"WPRL_Line_Seq_No"' + @p_separator_str +
                N'"WPRL_Item_Comment"' + @p_separator_str +
                N'"WPRL_Item_Text"' + @p_separator_str +
                N'"WPRL_Item_Desc"' + @p_separator_str +
                N'"WPRL_Item_Non_Inv"' + @p_separator_str +
                N'"WPRL_Required_Date"' + @p_separator_str +
                N'"WPRL_Unit_Price"' + @p_separator_str +
                N'"WPRL_Qty"' + @p_separator_str +
                N'"WPRL_Ext_Price"' + @p_separator_str +
                N'"WPRL_WPRLS_ID"' + @p_separator_str +
                N'"""WPRL_WPRLS_ID"" WPRLS_Desc"' + @p_separator_str +
                N'"WPRL_PO_No"' + @p_separator_str +
                N'"WPRL_PO_Line_Seq_No"' + @p_separator_str +
                N'"WPRL_Item_Non_Inv_UOM"' + @p_separator_str +
                N'"WPRL_Vendor_Name"' + @p_separator_str +
                N'"WPRL_Account"' + @p_separator_str +
                N'"WPRL_WClass_ID"' + ' ';
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
                N'IsNULL(Convert(nvarchar, WPR_Line_.[WPRL_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WPR_Line_.[WPRL_WPRD_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[WPRD_No], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WPR_Line_.[WPRL_IV00101_Item_No], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WPR_Line_.[WPRL_IV40700_Locn_Code], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WPR_Line_.[WPRL_PM00200_Vendor_ID], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WPR_Line_.[WPRL_GL00101_Acct_Indx]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WPR_Line_.[WPRL_IV00101_Prchs_UOM], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WPR_Line_.[WPRL_Line_Seq_No]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WPR_Line_.[WPRL_Item_Comment], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WPR_Line_.[WPRL_Item_Text], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WPR_Line_.[WPRL_Item_Desc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WPR_Line_.[WPRL_Item_Non_Inv], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WPR_Line_.[WPRL_Required_Date], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WPR_Line_.[WPRL_Unit_Price]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WPR_Line_.[WPRL_Qty]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WPR_Line_.[WPRL_Ext_Price]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WPR_Line_.[WPRL_WPRLS_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t1.[WPRLS_Desc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WPR_Line_.[WPRL_PO_No], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WPR_Line_.[WPRL_PO_Line_Seq_No]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WPR_Line_.[WPRL_Item_Non_Inv_UOM], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WPR_Line_.[WPRL_Vendor_Name], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(WPR_Line_.[WPRL_Account], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, WPR_Line_.[WPRL_WClass_ID]), '''') + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[WPR_Line] WPR_Line_ LEFT OUTER JOIN [dbo].[WPR_Doc] t0 ON (WPR_Line_.[WPRL_WPRD_ID] =  t0.[WPRD_ID]) LEFT OUTER JOIN [dbo].[WPR_Line_Status] t1 ON (WPR_Line_.[WPRL_WPRLS_ID] =  t1.[WPRLS_ID])';

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

