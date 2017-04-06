if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCanvass_Detail_InternalGetList') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCanvass_Detail_InternalGetList 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a query resultset from table [dbo].[WCanvass_Detail_Internal]
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
CREATE PROCEDURE pePortalWFApprovalWCanvass_Detail_InternalGetList
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
    @l_query_cols1 nvarchar(max),
    @l_query_cols2 nvarchar(max),
    @l_query_cols3 nvarchar(max),
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
    SET @l_from_str = '[dbo].[WCanvass_Detail_Internal] WCanvass_Detail_Internal_'

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
            SET @l_sort_str = N'ORDER BY WCanvass_Detail_Internal_.[WCDI_ID] asc '

        -- Calculate the rows to be included in the list
        SET @l_end_gen_row_num = @p_page_number * @p_batch_size;
        SET @l_start_gen_row_num = @l_end_gen_row_num - (@p_batch_size-1);

        -- Create a table variable to keep row numbering
        SET @l_temp_table = 'DECLARE @IS_TEMP_T_GETLIST TABLE
        (
        IS_ROWNUM_COL int identity(1,1),
                [WCDI_ID] int
        ); '

        -- Copy column data into table variable
        SET @l_temp_insert = 
            'INSERT INTO @IS_TEMP_T_GETLIST ('
        SET @l_temp_cols = 
            N'[WCDI_ID]'
        SET @l_temp_select = 
            ') ' + 
            'SELECT ' + 
            'TOP ' + convert(varchar, @l_end_gen_row_num) + ' '
        SET @l_temp_colsWithAlias = 
            N'WCanvass_Detail_Internal_.[WCDI_ID]'
        SET @l_temp_from = 
            ' FROM ' + @l_from_str + ' ' + @l_join_str + ' ' + 
            @l_where_str + ' ' + 
            @l_sort_str

        -- Construct the main query
        SET @l_query_select = 'SELECT '
        SET @l_query_cols1 = 
            N'WCanvass_Detail_Internal_.[WCDI_ID],
            WCanvass_Detail_Internal_.[WCDI_WCI_ID],
            WCanvass_Detail_Internal_.[WCDI_WPRL_ID],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID1],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID2],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID3],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID4],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID5],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID6],
            WCanvass_Detail_Internal_.[WCDI_Bid1],
            WCanvass_Detail_Internal_.[WCDI_Bid2],
            WCanvass_Detail_Internal_.[WCDI_Bid3],
            WCanvass_Detail_Internal_.[WCDI_Bid4],
            WCanvass_Detail_Internal_.[WCDI_Bid5],
            WCanvass_Detail_Internal_.[WCDI_Bid6],
            WCanvass_Detail_Internal_.[WCDI_Award1],
            WCanvass_Detail_Internal_.[WCDI_Award2],
            WCanvass_Detail_Internal_.[WCDI_Award3],
            WCanvass_Detail_Internal_.[WCDI_Award4],
            WCanvass_Detail_Internal_.[WCDI_Award5],
            WCanvass_Detail_Internal_.[WCDI_Award6],
            WCanvass_Detail_Internal_.[WCDI_Status],
            WCanvass_Detail_Internal_.[WCDI_Audit_Comment],
            WCanvass_Detail_Internal_.[WCDI_Comment],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID7],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID8],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID9],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID10],
            WCanvass_Detail_Internal_.[WCDI_Bid7],
            WCanvass_Detail_Internal_.[WCDI_Bid8],
            WCanvass_Detail_Internal_.[WCDI_Bid9],
            WCanvass_Detail_Internal_.[WCDI_Bid10],
            WCanvass_Detail_Internal_.[WCDI_Award7],
            WCanvass_Detail_Internal_.[WCDI_Award8],
            WCanvass_Detail_Internal_.[WCDI_Award9],
            WCanvass_Detail_Internal_.[WCDI_Award10],
            WCanvass_Detail_Internal_.[WCDI_Qty1],
            WCanvass_Detail_Internal_.[WCDI_Qty2],
            WCanvass_Detail_Internal_.[WCDI_Qty3],
            WCanvass_Detail_Internal_.[WCDI_Qty4],
            WCanvass_Detail_Internal_.[WCDI_Qty5],
            WCanvass_Detail_Internal_.[WCDI_Qty6],
            WCanvass_Detail_Internal_.[WCDI_Qty7],
            WCanvass_Detail_Internal_.[WCDI_Qty8],
            WCanvass_Detail_Internal_.[WCDI_Qty9],
            WCanvass_Detail_Internal_.[WCDI_Qty10],
            WCanvass_Detail_Internal_.[WCDI_PO1],
            WCanvass_Detail_Internal_.[WCDI_PO2],
            WCanvass_Detail_Internal_.[WCDI_PO3],
            WCanvass_Detail_Internal_.[WCDI_PO4],
            WCanvass_Detail_Internal_.[WCDI_PO5],
            WCanvass_Detail_Internal_.[WCDI_PO6],
            WCanvass_Detail_Internal_.[WCDI_PO7],
            WCanvass_Detail_Internal_.[WCDI_PO8],
            WCanvass_Detail_Internal_.[WCDI_PO9],
            WCanvass_Detail_Internal_.[WCDI_PO10],
            WCanvass_Detail_Internal_.[WCDI_Aw1],
            WCanvass_Detail_Internal_.[WCDI_Aw2],
            WCanvass_Detail_Internal_.[WCDI_Aw3],
            WCanvass_Detail_Internal_.[WCDI_Aw4],
            WCanvass_Detail_Internal_.[WCDI_Aw5],
            WCanvass_Detail_Internal_.[WCDI_Aw6],
            WCanvass_Detail_Internal_.[WCDI_Aw7],
            WCanvass_Detail_Internal_.[WCDI_Aw8],
            WCanvass_Detail_Internal_.[WCDI_Aw9],
            WCanvass_Detail_Internal_.[WCDI_Aw10],
            WCanvass_Detail_Internal_.[WCDI_Vat1],
            WCanvass_Detail_Internal_.[WCDI_Vat2],
            WCanvass_Detail_Internal_.[WCDI_Vat3],
            WCanvass_Detail_Internal_.[WCDI_Vat4],
            WCanvass_Detail_Internal_.[WCDI_Vat5],
            WCanvass_Detail_Internal_.[WCDI_Vat6],
            WCanvass_Detail_Internal_.[WCDI_Vat7],
            WCanvass_Detail_Internal_.[WCDI_Vat8],'
        SET @l_query_cols2 = 
            N'            WCanvass_Detail_Internal_.[WCDI_Vat9],
            WCanvass_Detail_Internal_.[WCDI_Vat10],
            WCanvass_Detail_Internal_.[WCDI_Net1],
            WCanvass_Detail_Internal_.[WCDI_Net2],
            WCanvass_Detail_Internal_.[WCDI_Net3],
            WCanvass_Detail_Internal_.[WCDI_Net4],
            WCanvass_Detail_Internal_.[WCDI_Net5],
            WCanvass_Detail_Internal_.[WCDI_Net6],
            WCanvass_Detail_Internal_.[WCDI_Net7],
            WCanvass_Detail_Internal_.[WCDI_Net8],
            WCanvass_Detail_Internal_.[WCDI_Net9],
            WCanvass_Detail_Internal_.[WCDI_Net10],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID1],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID2],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID3],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID4],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID5],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID6],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID7],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID8],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID9],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID10],'
        SET @l_query_cols3 = 
            N'            CAST(BINARY_CHECKSUM(WCanvass_Detail_Internal_.[WCDI_ID],WCanvass_Detail_Internal_.[WCDI_WCI_ID],WCanvass_Detail_Internal_.[WCDI_WPRL_ID],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID1],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID2],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID3],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID4],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID5],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID6],WCanvass_Detail_Internal_.[WCDI_Bid1],WCanvass_Detail_Internal_.[WCDI_Bid2],WCanvass_Detail_Internal_.[WCDI_Bid3],WCanvass_Detail_Internal_.[WCDI_Bid4],WCanvass_Detail_Internal_.[WCDI_Bid5],WCanvass_Detail_Internal_.[WCDI_Bid6],WCanvass_Detail_Internal_.[WCDI_Award1],WCanvass_Detail_Internal_.[WCDI_Award2],WCanvass_Detail_Internal_.[WCDI_Award3],WCanvass_Detail_Internal_.[WCDI_Award4],WCanvass_Detail_Internal_.[WCDI_Award5],WCanvass_Detail_Internal_.[WCDI_Award6],WCanvass_Detail_Internal_.[WCDI_Status],WCanvass_Detail_Internal_.[WCDI_Audit_Comment],WCanvass_Detail_Internal_.[WCDI_Comment],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID7],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID8],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID9],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID10],WCanvass_Detail_Internal_.[WCDI_Bid7],WCanvass_Detail_Internal_.[WCDI_Bid8],WCanvass_Detail_Internal_.[WCDI_Bid9],WCanvass_Detail_Internal_.[WCDI_Bid10],WCanvass_Detail_Internal_.[WCDI_Award7],WCanvass_Detail_Internal_.[WCDI_Award8],WCanvass_Detail_Internal_.[WCDI_Award9],WCanvass_Detail_Internal_.[WCDI_Award10],WCanvass_Detail_Internal_.[WCDI_Qty1],WCanvass_Detail_Internal_.[WCDI_Qty2],WCanvass_Detail_Internal_.[WCDI_Qty3],WCanvass_Detail_Internal_.[WCDI_Qty4],WCanvass_Detail_Internal_.[WCDI_Qty5],WCanvass_Detail_Internal_.[WCDI_Qty6],WCanvass_Detail_Internal_.[WCDI_Qty7],WCanvass_Detail_Internal_.[WCDI_Qty8],WCanvass_Detail_Internal_.[WCDI_Qty9],WCanvass_Detail_Internal_.[WCDI_Qty10],WCanvass_Detail_Internal_.[WCDI_PO1],WCanvass_Detail_Internal_.[WCDI_PO2],WCanvass_Detail_Internal_.[WCDI_PO3],WCanvass_Detail_Internal_.[WCDI_PO4],WCanvass_Detail_Internal_.[WCDI_PO5],WCanvass_Detail_Internal_.[WCDI_PO6],WCanvass_Detail_Internal_.[WCDI_PO7],WCanvass_Detail_Internal_.[WCDI_PO8],WCanvass_Detail_Internal_.[WCDI_PO9],WCanvass_Detail_Internal_.[WCDI_PO10],WCanvass_Detail_Internal_.[WCDI_Aw1],WCanvass_Detail_Internal_.[WCDI_Aw2],WCanvass_Detail_Internal_.[WCDI_Aw3],WCanvass_Detail_Internal_.[WCDI_Aw4],WCanvass_Detail_Internal_.[WCDI_Aw5],WCanvass_Detail_Internal_.[WCDI_Aw6],WCanvass_Detail_Internal_.[WCDI_Aw7],WCanvass_Detail_Internal_.[WCDI_Aw8],WCanvass_Detail_Internal_.[WCDI_Aw9],WCanvass_Detail_Internal_.[WCDI_Aw10],WCanvass_Detail_Internal_.[WCDI_Vat1],WCanvass_Detail_Internal_.[WCDI_Vat2],WCanvass_Detail_Internal_.[WCDI_Vat3],WCanvass_Detail_Internal_.[WCDI_Vat4],WCanvass_Detail_Internal_.[WCDI_Vat5],WCanvass_Detail_Internal_.[WCDI_Vat6],WCanvass_Detail_Internal_.[WCDI_Vat7],WCanvass_Detail_Internal_.[WCDI_Vat8],WCanvass_Detail_Internal_.[WCDI_Vat9],WCanvass_Detail_Internal_.[WCDI_Vat10],WCanvass_Detail_Internal_.[WCDI_Net1],WCanvass_Detail_Internal_.[WCDI_Net2],WCanvass_Detail_Internal_.[WCDI_Net3],WCanvass_Detail_Internal_.[WCDI_Net4],WCanvass_Detail_Internal_.[WCDI_Net5],WCanvass_Detail_Internal_.[WCDI_Net6],WCanvass_Detail_Internal_.[WCDI_Net7],WCanvass_Detail_Internal_.[WCDI_Net8],WCanvass_Detail_Internal_.[WCDI_Net9],WCanvass_Detail_Internal_.[WCDI_Net10],WCanvass_Detail_Internal_.[WCDI_WCur_ID1],WCanvass_Detail_Internal_.[WCDI_WCur_ID2],WCanvass_Detail_Internal_.[WCDI_WCur_ID3],WCanvass_Detail_Internal_.[WCDI_WCur_ID4],WCanvass_Detail_Internal_.[WCDI_WCur_ID5],WCanvass_Detail_Internal_.[WCDI_WCur_ID6],WCanvass_Detail_Internal_.[WCDI_WCur_ID7],WCanvass_Detail_Internal_.[WCDI_WCur_ID8],WCanvass_Detail_Internal_.[WCDI_WCur_ID9],WCanvass_Detail_Internal_.[WCDI_WCur_ID10]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345'
        SET @l_query_from = 
            ' FROM ( ' +
                N'SELECT TOP 100 PERCENT IS_ROWNUM_COL, [WCDI_ID] from @IS_TEMP_T_GETLIST ' +
                'WHERE IS_ROWNUM_COL >= '+ convert(varchar, @l_start_gen_row_num) + 
                ') IS_ALIAS LEFT JOIN ' +
                @l_from_str + ' ';

        SET @l_query_where = 
            N'ON WCanvass_Detail_Internal_.[WCDI_ID] = IS_ALIAS.[WCDI_ID] ' 

        SET @l_final_sort = 'ORDER BY IS_ROWNUM_COL Asc '

        -- Run the query
        EXECUTE (@l_temp_table + @l_temp_insert + @l_temp_cols + @l_temp_select + @l_temp_colsWithAlias + @l_temp_from + '; ' + @l_query_select + @l_query_cols1 + @l_query_cols2 + @l_query_cols3 + @l_query_from + @l_query_where + @l_final_sort)

    END
    ELSE
    BEGIN
        -- If page number and batch size are not valid numbers return an empty result set
        SET @l_query_select = 'SELECT '
        SET @l_query_cols1 = 
            N'WCanvass_Detail_Internal_.[WCDI_ID],
            WCanvass_Detail_Internal_.[WCDI_WCI_ID],
            WCanvass_Detail_Internal_.[WCDI_WPRL_ID],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID1],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID2],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID3],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID4],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID5],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID6],
            WCanvass_Detail_Internal_.[WCDI_Bid1],
            WCanvass_Detail_Internal_.[WCDI_Bid2],
            WCanvass_Detail_Internal_.[WCDI_Bid3],
            WCanvass_Detail_Internal_.[WCDI_Bid4],
            WCanvass_Detail_Internal_.[WCDI_Bid5],
            WCanvass_Detail_Internal_.[WCDI_Bid6],
            WCanvass_Detail_Internal_.[WCDI_Award1],
            WCanvass_Detail_Internal_.[WCDI_Award2],
            WCanvass_Detail_Internal_.[WCDI_Award3],
            WCanvass_Detail_Internal_.[WCDI_Award4],
            WCanvass_Detail_Internal_.[WCDI_Award5],
            WCanvass_Detail_Internal_.[WCDI_Award6],
            WCanvass_Detail_Internal_.[WCDI_Status],
            WCanvass_Detail_Internal_.[WCDI_Audit_Comment],
            WCanvass_Detail_Internal_.[WCDI_Comment],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID7],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID8],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID9],
            WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID10],
            WCanvass_Detail_Internal_.[WCDI_Bid7],
            WCanvass_Detail_Internal_.[WCDI_Bid8],
            WCanvass_Detail_Internal_.[WCDI_Bid9],
            WCanvass_Detail_Internal_.[WCDI_Bid10],
            WCanvass_Detail_Internal_.[WCDI_Award7],
            WCanvass_Detail_Internal_.[WCDI_Award8],
            WCanvass_Detail_Internal_.[WCDI_Award9],
            WCanvass_Detail_Internal_.[WCDI_Award10],
            WCanvass_Detail_Internal_.[WCDI_Qty1],
            WCanvass_Detail_Internal_.[WCDI_Qty2],
            WCanvass_Detail_Internal_.[WCDI_Qty3],
            WCanvass_Detail_Internal_.[WCDI_Qty4],
            WCanvass_Detail_Internal_.[WCDI_Qty5],
            WCanvass_Detail_Internal_.[WCDI_Qty6],
            WCanvass_Detail_Internal_.[WCDI_Qty7],
            WCanvass_Detail_Internal_.[WCDI_Qty8],
            WCanvass_Detail_Internal_.[WCDI_Qty9],
            WCanvass_Detail_Internal_.[WCDI_Qty10],
            WCanvass_Detail_Internal_.[WCDI_PO1],
            WCanvass_Detail_Internal_.[WCDI_PO2],
            WCanvass_Detail_Internal_.[WCDI_PO3],
            WCanvass_Detail_Internal_.[WCDI_PO4],
            WCanvass_Detail_Internal_.[WCDI_PO5],
            WCanvass_Detail_Internal_.[WCDI_PO6],
            WCanvass_Detail_Internal_.[WCDI_PO7],
            WCanvass_Detail_Internal_.[WCDI_PO8],
            WCanvass_Detail_Internal_.[WCDI_PO9],
            WCanvass_Detail_Internal_.[WCDI_PO10],
            WCanvass_Detail_Internal_.[WCDI_Aw1],
            WCanvass_Detail_Internal_.[WCDI_Aw2],
            WCanvass_Detail_Internal_.[WCDI_Aw3],
            WCanvass_Detail_Internal_.[WCDI_Aw4],
            WCanvass_Detail_Internal_.[WCDI_Aw5],
            WCanvass_Detail_Internal_.[WCDI_Aw6],
            WCanvass_Detail_Internal_.[WCDI_Aw7],
            WCanvass_Detail_Internal_.[WCDI_Aw8],
            WCanvass_Detail_Internal_.[WCDI_Aw9],
            WCanvass_Detail_Internal_.[WCDI_Aw10],
            WCanvass_Detail_Internal_.[WCDI_Vat1],
            WCanvass_Detail_Internal_.[WCDI_Vat2],
            WCanvass_Detail_Internal_.[WCDI_Vat3],
            WCanvass_Detail_Internal_.[WCDI_Vat4],
            WCanvass_Detail_Internal_.[WCDI_Vat5],
            WCanvass_Detail_Internal_.[WCDI_Vat6],
            WCanvass_Detail_Internal_.[WCDI_Vat7],
            WCanvass_Detail_Internal_.[WCDI_Vat8],'
        SET @l_query_cols2 = 
            N'            WCanvass_Detail_Internal_.[WCDI_Vat9],
            WCanvass_Detail_Internal_.[WCDI_Vat10],
            WCanvass_Detail_Internal_.[WCDI_Net1],
            WCanvass_Detail_Internal_.[WCDI_Net2],
            WCanvass_Detail_Internal_.[WCDI_Net3],
            WCanvass_Detail_Internal_.[WCDI_Net4],
            WCanvass_Detail_Internal_.[WCDI_Net5],
            WCanvass_Detail_Internal_.[WCDI_Net6],
            WCanvass_Detail_Internal_.[WCDI_Net7],
            WCanvass_Detail_Internal_.[WCDI_Net8],
            WCanvass_Detail_Internal_.[WCDI_Net9],
            WCanvass_Detail_Internal_.[WCDI_Net10],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID1],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID2],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID3],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID4],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID5],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID6],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID7],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID8],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID9],
            WCanvass_Detail_Internal_.[WCDI_WCur_ID10],'
        SET @l_query_cols3 = 
            N'            CAST(BINARY_CHECKSUM(WCanvass_Detail_Internal_.[WCDI_ID],WCanvass_Detail_Internal_.[WCDI_WCI_ID],WCanvass_Detail_Internal_.[WCDI_WPRL_ID],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID1],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID2],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID3],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID4],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID5],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID6],WCanvass_Detail_Internal_.[WCDI_Bid1],WCanvass_Detail_Internal_.[WCDI_Bid2],WCanvass_Detail_Internal_.[WCDI_Bid3],WCanvass_Detail_Internal_.[WCDI_Bid4],WCanvass_Detail_Internal_.[WCDI_Bid5],WCanvass_Detail_Internal_.[WCDI_Bid6],WCanvass_Detail_Internal_.[WCDI_Award1],WCanvass_Detail_Internal_.[WCDI_Award2],WCanvass_Detail_Internal_.[WCDI_Award3],WCanvass_Detail_Internal_.[WCDI_Award4],WCanvass_Detail_Internal_.[WCDI_Award5],WCanvass_Detail_Internal_.[WCDI_Award6],WCanvass_Detail_Internal_.[WCDI_Status],WCanvass_Detail_Internal_.[WCDI_Audit_Comment],WCanvass_Detail_Internal_.[WCDI_Comment],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID7],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID8],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID9],WCanvass_Detail_Internal_.[WCDI_PM00200_Vendor_ID10],WCanvass_Detail_Internal_.[WCDI_Bid7],WCanvass_Detail_Internal_.[WCDI_Bid8],WCanvass_Detail_Internal_.[WCDI_Bid9],WCanvass_Detail_Internal_.[WCDI_Bid10],WCanvass_Detail_Internal_.[WCDI_Award7],WCanvass_Detail_Internal_.[WCDI_Award8],WCanvass_Detail_Internal_.[WCDI_Award9],WCanvass_Detail_Internal_.[WCDI_Award10],WCanvass_Detail_Internal_.[WCDI_Qty1],WCanvass_Detail_Internal_.[WCDI_Qty2],WCanvass_Detail_Internal_.[WCDI_Qty3],WCanvass_Detail_Internal_.[WCDI_Qty4],WCanvass_Detail_Internal_.[WCDI_Qty5],WCanvass_Detail_Internal_.[WCDI_Qty6],WCanvass_Detail_Internal_.[WCDI_Qty7],WCanvass_Detail_Internal_.[WCDI_Qty8],WCanvass_Detail_Internal_.[WCDI_Qty9],WCanvass_Detail_Internal_.[WCDI_Qty10],WCanvass_Detail_Internal_.[WCDI_PO1],WCanvass_Detail_Internal_.[WCDI_PO2],WCanvass_Detail_Internal_.[WCDI_PO3],WCanvass_Detail_Internal_.[WCDI_PO4],WCanvass_Detail_Internal_.[WCDI_PO5],WCanvass_Detail_Internal_.[WCDI_PO6],WCanvass_Detail_Internal_.[WCDI_PO7],WCanvass_Detail_Internal_.[WCDI_PO8],WCanvass_Detail_Internal_.[WCDI_PO9],WCanvass_Detail_Internal_.[WCDI_PO10],WCanvass_Detail_Internal_.[WCDI_Aw1],WCanvass_Detail_Internal_.[WCDI_Aw2],WCanvass_Detail_Internal_.[WCDI_Aw3],WCanvass_Detail_Internal_.[WCDI_Aw4],WCanvass_Detail_Internal_.[WCDI_Aw5],WCanvass_Detail_Internal_.[WCDI_Aw6],WCanvass_Detail_Internal_.[WCDI_Aw7],WCanvass_Detail_Internal_.[WCDI_Aw8],WCanvass_Detail_Internal_.[WCDI_Aw9],WCanvass_Detail_Internal_.[WCDI_Aw10],WCanvass_Detail_Internal_.[WCDI_Vat1],WCanvass_Detail_Internal_.[WCDI_Vat2],WCanvass_Detail_Internal_.[WCDI_Vat3],WCanvass_Detail_Internal_.[WCDI_Vat4],WCanvass_Detail_Internal_.[WCDI_Vat5],WCanvass_Detail_Internal_.[WCDI_Vat6],WCanvass_Detail_Internal_.[WCDI_Vat7],WCanvass_Detail_Internal_.[WCDI_Vat8],WCanvass_Detail_Internal_.[WCDI_Vat9],WCanvass_Detail_Internal_.[WCDI_Vat10],WCanvass_Detail_Internal_.[WCDI_Net1],WCanvass_Detail_Internal_.[WCDI_Net2],WCanvass_Detail_Internal_.[WCDI_Net3],WCanvass_Detail_Internal_.[WCDI_Net4],WCanvass_Detail_Internal_.[WCDI_Net5],WCanvass_Detail_Internal_.[WCDI_Net6],WCanvass_Detail_Internal_.[WCDI_Net7],WCanvass_Detail_Internal_.[WCDI_Net8],WCanvass_Detail_Internal_.[WCDI_Net9],WCanvass_Detail_Internal_.[WCDI_Net10],WCanvass_Detail_Internal_.[WCDI_WCur_ID1],WCanvass_Detail_Internal_.[WCDI_WCur_ID2],WCanvass_Detail_Internal_.[WCDI_WCur_ID3],WCanvass_Detail_Internal_.[WCDI_WCur_ID4],WCanvass_Detail_Internal_.[WCDI_WCur_ID5],WCanvass_Detail_Internal_.[WCDI_WCur_ID6],WCanvass_Detail_Internal_.[WCDI_WCur_ID7],WCanvass_Detail_Internal_.[WCDI_WCur_ID8],WCanvass_Detail_Internal_.[WCDI_WCur_ID9],WCanvass_Detail_Internal_.[WCDI_WCur_ID10]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345'
        SET @l_query_from = 
            ' FROM [dbo].[WCanvass_Detail_Internal] WCanvass_Detail_Internal_ ' + 
            'WHERE 1=2;'
        EXECUTE (@l_query_select + @l_query_cols1 + @l_query_cols2 + @l_query_cols3 + @l_query_from);
    END

    SET NOCOUNT OFF

END

