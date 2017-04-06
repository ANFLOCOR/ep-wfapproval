﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WPO_InquireDetails_2GetList') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WPO_InquireDetails_2GetList 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a query resultset from table [dbo].[sel_WPO_InquireDetails_2]
-- given the search criteria and sorting condition.
-- It will return a subset of the data based
-- on the current page number and batch size.  Table joins can
-- be performed if the join clause is specified.
-- 
-- If the resultset is not empty, it will return:
--    1) The total number of rows which match the condition;
--    2) The resultset in the current page
-- If nothing matches the search condition, it will return:
--    1) count is 0 ;
--    2) empty resultset.
CREATE PROCEDURE pePortalWFApprovalSel_WPO_InquireDetails_2GetList
        @p_join_str nvarchar(max),
        @p_where_str nvarchar(max),
        @p_sort_str nvarchar(max),
        @p_page_number int,
        @p_batch_size int
AS
DECLARE
    @l_temp_table nvarchar(max),
    @l_temp_insert nvarchar(max),
    @l_temp_select nvarchar(max),
    @l_temp_from nvarchar(max),
    @l_final_sort nvarchar(max),
    @l_temp_cols nvarchar(max),
    @l_temp_colsWithAlias nvarchar(max),
    @l_query_select nvarchar(max),
    @l_query_select2 nvarchar(max),
    @l_query_rownum nvarchar(max),
    @l_query_from nvarchar(max),
    @l_query_where nvarchar(max),
    @l_query_cols nvarchar(max),
    @l_from_str nvarchar(max),
    @l_join_str nvarchar(max),
    @l_sort_str nvarchar(max),
    @l_where_str nvarchar(max),
    @l_count_query nvarchar(max),
    @l_end_gen_row_num integer,
    @l_start_gen_row_num integer
BEGIN
    SET NOCOUNT ON

    -- Set up the from string as the base table
    SET @l_from_str = '[dbo].[sel_WPO_InquireDetails_2] sel_WPO_InquireDetails_2_'

    -- Set up the join string
    SET @l_join_str = @p_join_str
    IF @p_join_str is null
        SET @l_join_str = ' '

    -- Set up the where string
    SET @l_where_str = ' '
        IF @p_where_str is not null
        SET @l_where_str = 'WHERE ' + @p_where_str

    -- Get the total count of rows the query will return
    IF @p_page_number > 0 and @p_batch_size >= 0
    BEGIN
        SET @l_count_query = 
            'SELECT count(*) ' +
            'FROM ' + @l_from_str + ' ' + @l_join_str + ' ' +
            @l_where_str + ' '

        -- Run the count query
        EXECUTE (@l_count_query)
    END

    -- Get the list
    IF @p_page_number > 0 AND @p_batch_size > 0
    BEGIN
        -- If the caller did not pass a sort string, use a default value
        IF @p_sort_str IS NOT NULL
            SET @l_sort_str = 'ORDER BY ' + @p_sort_str
        ELSE
            SET @l_sort_str = ' '

        -- Calculate the rows to be included in the list
        SET @l_end_gen_row_num = @p_page_number * @p_batch_size;
        SET @l_start_gen_row_num = @l_end_gen_row_num - (@p_batch_size-1);

        -- Construct the main query
        SET @l_query_select = 'WITH sel_WPO_InquireDetails_2_ AS ( SELECT  '
        SET @l_query_rownum = 'ROW_NUMBER() OVER(' + @l_sort_str + ') AS IS_ROWNUM_COL,'
        SET @l_query_cols = 
            N'sel_WPO_InquireDetails_2_.[CompanyID],
            sel_WPO_InquireDetails_2_.[PONUMBER],
            sel_WPO_InquireDetails_2_.[LineNumber],
            sel_WPO_InquireDetails_2_.[ITEMNMBR],
            sel_WPO_InquireDetails_2_.[ITEMDESC],
            sel_WPO_InquireDetails_2_.[UOFM],
            sel_WPO_InquireDetails_2_.[UNITCOST],
            sel_WPO_InquireDetails_2_.[QTYORDER],
            sel_WPO_InquireDetails_2_.[EXTDCOST],
            sel_WPO_InquireDetails_2_.[DOCDATE],
            sel_WPO_InquireDetails_2_.[REQSTDBY],
            sel_WPO_InquireDetails_2_.[ORD],
            sel_WPO_InquireDetails_2_.[COMMENTS],
            sel_WPO_InquireDetails_2_.[COMMENT_4],
            sel_WPO_InquireDetails_2_.[VENDORID],
            sel_WPO_InquireDetails_2_.[VENDNAME]'

        SET @l_query_from = 'FROM ' + @l_from_str + ' ' + @l_join_str + + ' ' + @l_where_str + ') '
        SET @l_query_select2 = 'SELECT * FROM sel_WPO_InquireDetails_2_ '
        SET @l_query_where = 'WHERE IS_ROWNUM_COL BETWEEN ' + convert(varchar, @l_start_gen_row_num) + ' AND ' + convert(varchar, @l_end_gen_row_num) +  ';'

        -- Run the query
        EXECUTE (@l_query_select + @l_query_rownum + @l_query_cols + @l_query_from + @l_query_select2 + @l_query_where)

    END
    ELSE
    BEGIN
        -- If page number and batch size are not valid numbers return an empty result set
        SET @l_query_select = 'SELECT '
        SET @l_query_cols = 
            N'sel_WPO_InquireDetails_2_.[CompanyID],
            sel_WPO_InquireDetails_2_.[PONUMBER],
            sel_WPO_InquireDetails_2_.[LineNumber],
            sel_WPO_InquireDetails_2_.[ITEMNMBR],
            sel_WPO_InquireDetails_2_.[ITEMDESC],
            sel_WPO_InquireDetails_2_.[UOFM],
            sel_WPO_InquireDetails_2_.[UNITCOST],
            sel_WPO_InquireDetails_2_.[QTYORDER],
            sel_WPO_InquireDetails_2_.[EXTDCOST],
            sel_WPO_InquireDetails_2_.[DOCDATE],
            sel_WPO_InquireDetails_2_.[REQSTDBY],
            sel_WPO_InquireDetails_2_.[ORD],
            sel_WPO_InquireDetails_2_.[COMMENTS],
            sel_WPO_InquireDetails_2_.[COMMENT_4],
            sel_WPO_InquireDetails_2_.[VENDORID],
            sel_WPO_InquireDetails_2_.[VENDNAME]'
        SET @l_query_from = 
            ' FROM [dbo].[sel_WPO_InquireDetails_2] sel_WPO_InquireDetails_2_ ' + 
            'WHERE 1=2;'
        EXECUTE (@l_query_select + @l_query_cols + @l_query_from);
    END

    SET NOCOUNT OFF

END

