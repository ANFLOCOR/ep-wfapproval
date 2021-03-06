﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_PO_Map1GetList') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_PO_Map1GetList 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a query resultset from table [dbo].[WCanvass_PO_Map]
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
CREATE PROCEDURE pePortalWFApprovalWCanvass_PO_Map1GetList
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
    SET @l_from_str = '[dbo].[WCanvass_PO_Map] WCanvass_PO_Map_'

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
            SET @l_sort_str = N'ORDER BY WCanvass_PO_Map_.[WCPOM_ID] asc '

        -- Calculate the rows to be included in the list
        SET @l_end_gen_row_num = @p_page_number * @p_batch_size;
        SET @l_start_gen_row_num = @l_end_gen_row_num - (@p_batch_size-1);

        -- Create a table variable to keep row numbering
        SET @l_temp_table = 'DECLARE @IS_TEMP_T_GETLIST TABLE
        (
        IS_ROWNUM_COL int identity(1,1),
                [WCPOM_ID] int
        ); '

        -- Copy column data into table variable
        SET @l_temp_insert = 
            'INSERT INTO @IS_TEMP_T_GETLIST ('
        SET @l_temp_cols = 
            N'[WCPOM_ID]'
        SET @l_temp_select = 
            ') ' + 
            'SELECT ' + 
            'TOP ' + convert(varchar, @l_end_gen_row_num) + ' '
        SET @l_temp_colsWithAlias = 
            N'WCanvass_PO_Map_.[WCPOM_ID]'
        SET @l_temp_from = 
            ' FROM ' + @l_from_str + ' ' + @l_join_str + ' ' + 
            @l_where_str + ' ' + 
            @l_sort_str

        -- Construct the main query
        SET @l_query_select = 'SELECT '
        SET @l_query_cols = 
            N'WCanvass_PO_Map_.[WCPOM_ID],
            WCanvass_PO_Map_.[WCPOM_C_ID],
            WCanvass_PO_Map_.[WCPOM_WCDI_ID],
            WCanvass_PO_Map_.[WCPOM_WPRD_ID],
            WCanvass_PO_Map_.[WCPOM_WPRL_ID],
            WCanvass_PO_Map_.[WCPOM_U_ID],
            WCanvass_PO_Map_.[WCPOM_PO_No],
            WCanvass_PO_Map_.[WCPOM_Date],
            WCanvass_PO_Map_.[WCPOM_PM00200_Vendor],
            WCanvass_PO_Map_.[WCPOM_Bid],
            WCanvass_PO_Map_.[WCPOM_Qty],
            WCanvass_PO_Map_.[WCPOM_PO_Line],
            WCanvass_PO_Map_.[WCPOM_Col_Marker],
            CAST(BINARY_CHECKSUM(WCanvass_PO_Map_.[WCPOM_ID],WCanvass_PO_Map_.[WCPOM_C_ID],WCanvass_PO_Map_.[WCPOM_WCDI_ID],WCanvass_PO_Map_.[WCPOM_WPRD_ID],WCanvass_PO_Map_.[WCPOM_WPRL_ID],WCanvass_PO_Map_.[WCPOM_U_ID],WCanvass_PO_Map_.[WCPOM_PO_No],WCanvass_PO_Map_.[WCPOM_Date],WCanvass_PO_Map_.[WCPOM_PM00200_Vendor],WCanvass_PO_Map_.[WCPOM_Bid],WCanvass_PO_Map_.[WCPOM_Qty],WCanvass_PO_Map_.[WCPOM_PO_Line],WCanvass_PO_Map_.[WCPOM_Col_Marker]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345'
        SET @l_query_from = 
            ' FROM ( ' +
                N'SELECT TOP 100 PERCENT IS_ROWNUM_COL, [WCPOM_ID] from @IS_TEMP_T_GETLIST ' +
                'WHERE IS_ROWNUM_COL >= '+ convert(varchar, @l_start_gen_row_num) + 
                ') IS_ALIAS LEFT JOIN ' +
                @l_from_str + ' ';

        SET @l_query_where = 
            N'ON WCanvass_PO_Map_.[WCPOM_ID] = IS_ALIAS.[WCPOM_ID] ' 

        SET @l_final_sort = 'ORDER BY IS_ROWNUM_COL Asc '

        -- Run the query
        EXECUTE (@l_temp_table + @l_temp_insert + @l_temp_cols + @l_temp_select + @l_temp_colsWithAlias + @l_temp_from + '; ' + @l_query_select + @l_query_cols + @l_query_from + @l_query_where + @l_final_sort)

    END
    ELSE
    BEGIN
        -- If page number and batch size are not valid numbers return an empty result set
        SET @l_query_select = 'SELECT '
        SET @l_query_cols = 
            N'WCanvass_PO_Map_.[WCPOM_ID],
            WCanvass_PO_Map_.[WCPOM_C_ID],
            WCanvass_PO_Map_.[WCPOM_WCDI_ID],
            WCanvass_PO_Map_.[WCPOM_WPRD_ID],
            WCanvass_PO_Map_.[WCPOM_WPRL_ID],
            WCanvass_PO_Map_.[WCPOM_U_ID],
            WCanvass_PO_Map_.[WCPOM_PO_No],
            WCanvass_PO_Map_.[WCPOM_Date],
            WCanvass_PO_Map_.[WCPOM_PM00200_Vendor],
            WCanvass_PO_Map_.[WCPOM_Bid],
            WCanvass_PO_Map_.[WCPOM_Qty],
            WCanvass_PO_Map_.[WCPOM_PO_Line],
            WCanvass_PO_Map_.[WCPOM_Col_Marker],
            CAST(BINARY_CHECKSUM(WCanvass_PO_Map_.[WCPOM_ID],WCanvass_PO_Map_.[WCPOM_C_ID],WCanvass_PO_Map_.[WCPOM_WCDI_ID],WCanvass_PO_Map_.[WCPOM_WPRD_ID],WCanvass_PO_Map_.[WCPOM_WPRL_ID],WCanvass_PO_Map_.[WCPOM_U_ID],WCanvass_PO_Map_.[WCPOM_PO_No],WCanvass_PO_Map_.[WCPOM_Date],WCanvass_PO_Map_.[WCPOM_PM00200_Vendor],WCanvass_PO_Map_.[WCPOM_Bid],WCanvass_PO_Map_.[WCPOM_Qty],WCanvass_PO_Map_.[WCPOM_PO_Line],WCanvass_PO_Map_.[WCPOM_Col_Marker]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345'
        SET @l_query_from = 
            ' FROM [dbo].[WCanvass_PO_Map] WCanvass_PO_Map_ ' + 
            'WHERE 1=2;'
        EXECUTE (@l_query_select + @l_query_cols + @l_query_from);
    END

    SET NOCOUNT OFF

END

