﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WCanvass_Detail_Internal_WPR_LineGetList') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WCanvass_Detail_Internal_WPR_LineGetList 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a query resultset from table [dbo].[sel_WCanvass_Detail_Internal_WPR_Line]
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
CREATE PROCEDURE pePortalWFApprovalSel_WCanvass_Detail_Internal_WPR_LineGetList
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
    @l_temp_colsWithAlias1 nvarchar(max),
    @l_temp_colsWithAlias2 nvarchar(max),
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
    SET @l_from_str = '[dbo].[sel_WCanvass_Detail_Internal_WPR_Line] sel_WCanvass_Detail_Internal_WPR_Line_'

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

        -- Create a table variable to keep row numbering
        SET @l_temp_table = 'DECLARE @IS_TEMP_T_GETLIST TABLE
        (
        IS_ROWNUM_COL int identity(1,1),
                [WPRL_WPRD_ID] int,
    [WCDI_WCI_ID] int,
    [WCDI_ID] int,
    [Item] char(31) COLLATE Latin1_General_BIN,
    [ItemDescription] varchar(500) COLLATE Latin1_General_BIN,
    [UnitOfMeasure] varchar(20) COLLATE Latin1_General_BIN,
    [Site] char(11) COLLATE Latin1_General_BIN,
    [UnitPrice] numeric(18,5),
    [WPRL_Qty] numeric(18,5),
    [WPRL_Ext_Price] numeric(18,5),
    [WCDI_PM00200_Vendor_ID1] char(15) COLLATE Latin1_General_BIN,
    [WCDI_Bid1] numeric(18,5),
    [WCDI_Award1] bit,
    [WCDI_PM00200_Vendor_ID2] char(15) COLLATE Latin1_General_BIN,
    [WCDI_Bid2] numeric(18,5),
    [WCDI_Award2] bit,
    [WCDI_PM00200_Vendor_ID3] char(15) COLLATE Latin1_General_BIN,
    [WCDI_Bid3] numeric(18,5),
    [WCDI_Award3] bit,
    [WCDI_PM00200_Vendor_ID4] char(15) COLLATE Latin1_General_BIN,
    [WCDI_Bid4] numeric(18,5),
    [WCDI_Award4] bit,
    [WCDI_PM00200_Vendor_ID5] char(15) COLLATE Latin1_General_BIN,
    [WCDI_Bid5] numeric(18,5),
    [WCDI_Award5] bit,
    [WCDI_PM00200_Vendor_ID6] char(15) COLLATE Latin1_General_BIN,
    [WCDI_Bid6] numeric(18,5),
    [WCDI_Award6] bit,
    [WCDI_Status] varchar(20) COLLATE Latin1_General_BIN,
    [WCDI_Audit_Comment] varchar(500) COLLATE Latin1_General_BIN,
    [WCDI_Comment] varchar(500) COLLATE Latin1_General_BIN,
    [WPRL_ID] int,
    [WCDI_PM00200_Vendor_ID7] char(15) COLLATE Latin1_General_BIN,
    [WCDI_Bid7] numeric(18,5),
    [WCDI_Award7] bit,
    [WCDI_PM00200_Vendor_ID8] char(15) COLLATE Latin1_General_BIN,
    [WCDI_Bid8] numeric(18,5),
    [WCDI_Award8] bit,
    [WCDI_PM00200_Vendor_ID9] char(15) COLLATE Latin1_General_BIN,
    [WCDI_Bid9] numeric(18,5),
    [WCDI_Award9] bit,
    [WCDI_PM00200_Vendor_ID10] char(15) COLLATE Latin1_General_BIN,
    [WCDI_Bid10] numeric(18,5),
    [WCDI_Award10] bit,
    [WPRL_WClass_ID] int,
    [WCI_ID] int,
    [WCDI_Qty1] numeric(18,4),
    [WCDI_Qty2] numeric(18,4),
    [WCDI_Qty3] numeric(18,4),
    [WCDI_Qty4] numeric(18,4),
    [WCDI_Qty5] numeric(18,4),
    [WCDI_Qty6] numeric(18,4),
    [WCDI_Qty7] numeric(18,4),
    [WCDI_Qty8] numeric(18,4),
    [WCDI_Qty9] numeric(18,4),
    [WCDI_Qty10] numeric(18,4),
    [WCDI_Aw1] bit,
    [WCDI_Aw2] bit,
    [WCDI_Aw3] bit,
    [WCDI_Aw4] bit,
    [WCDI_Aw5] bit,
    [WCDI_Aw6] bit,
    [WCDI_Aw7] bit,
    [WCDI_Aw8] bit,
    [WCDI_Aw9] bit,
    [WCDI_Aw10] bit,
    [WCDI_PO1] bit,
    [WCDI_PO2] bit,
    [WCDI_PO3] bit,
    [WCDI_PO4] bit,
    [WCDI_PO5] bit,
    [WCDI_PO6] bit,
    [WCDI_PO7] bit,
    [WCDI_PO8] bit,
    [WCDI_PO9] bit,
    [WCDI_PO10] bit,
    [WCDI_Vat1] bit,
    [WCDI_Vat2] bit,
    [WCDI_Vat3] bit,
    [WCDI_Vat4] bit,
    [WCDI_Vat5] bit,
    [WCDI_Vat6] bit,
    [WCDI_Vat7] bit,
    [WCDI_Vat8] bit,
    [WCDI_Vat9] bit,
    [WCDI_Vat10] bit,
    [WCDI_Net1] numeric(18,5),
    [WCDI_Net2] numeric(18,5),
    [WCDI_Net3] numeric(18,5),
    [WCDI_Net4] numeric(18,5),
    [WCDI_Net5] numeric(18,5),
    [WCDI_Net6] numeric(18,5),
    [WCDI_Net7] numeric(18,5),
    [WCDI_Net8] numeric(18,5),
    [WCDI_Net9] numeric(18,5),
    [WCDI_Net10] numeric(18,5),
    [WCDI_WCur_ID1] smallint,
    [WCDI_WCur_ID2] smallint,
    [WCDI_WCur_ID3] smallint,
    [WCDI_WCur_ID4] smallint,
    [WCDI_WCur_ID5] smallint,
    [WCDI_WCur_ID6] smallint,
    [WCDI_WCur_ID7] smallint,
    [WCDI_WCur_ID8] smallint,
    [WCDI_WCur_ID9] smallint,
    [WCDI_WCur_ID10] smallint,
    [WPRL_Line_Seq_No] int,
    [CURRCOST] numeric(19,5)
        ); '

        -- Copy column data into table variable
        SET @l_temp_insert = 
            'INSERT INTO @IS_TEMP_T_GETLIST ('
        SET @l_temp_cols = 
            N'[WPRL_WPRD_ID],
            [WCDI_WCI_ID],
            [WCDI_ID],
            [Item],
            [ItemDescription],
            [UnitOfMeasure],
            [Site],
            [UnitPrice],
            [WPRL_Qty],
            [WPRL_Ext_Price],
            [WCDI_PM00200_Vendor_ID1],
            [WCDI_Bid1],
            [WCDI_Award1],
            [WCDI_PM00200_Vendor_ID2],
            [WCDI_Bid2],
            [WCDI_Award2],
            [WCDI_PM00200_Vendor_ID3],
            [WCDI_Bid3],
            [WCDI_Award3],
            [WCDI_PM00200_Vendor_ID4],
            [WCDI_Bid4],
            [WCDI_Award4],
            [WCDI_PM00200_Vendor_ID5],
            [WCDI_Bid5],
            [WCDI_Award5],
            [WCDI_PM00200_Vendor_ID6],
            [WCDI_Bid6],
            [WCDI_Award6],
            [WCDI_Status],
            [WCDI_Audit_Comment],
            [WCDI_Comment],
            [WPRL_ID],
            [WCDI_PM00200_Vendor_ID7],
            [WCDI_Bid7],
            [WCDI_Award7],
            [WCDI_PM00200_Vendor_ID8],
            [WCDI_Bid8],
            [WCDI_Award8],
            [WCDI_PM00200_Vendor_ID9],
            [WCDI_Bid9],
            [WCDI_Award9],
            [WCDI_PM00200_Vendor_ID10],
            [WCDI_Bid10],
            [WCDI_Award10],
            [WPRL_WClass_ID],
            [WCI_ID],
            [WCDI_Qty1],
            [WCDI_Qty2],
            [WCDI_Qty3],
            [WCDI_Qty4],
            [WCDI_Qty5],
            [WCDI_Qty6],
            [WCDI_Qty7],
            [WCDI_Qty8],
            [WCDI_Qty9],
            [WCDI_Qty10],
            [WCDI_Aw1],
            [WCDI_Aw2],
            [WCDI_Aw3],
            [WCDI_Aw4],
            [WCDI_Aw5],
            [WCDI_Aw6],
            [WCDI_Aw7],
            [WCDI_Aw8],
            [WCDI_Aw9],
            [WCDI_Aw10],
            [WCDI_PO1],
            [WCDI_PO2],
            [WCDI_PO3],
            [WCDI_PO4],
            [WCDI_PO5],
            [WCDI_PO6],
            [WCDI_PO7],
            [WCDI_PO8],
            [WCDI_PO9],
            [WCDI_PO10],
            [WCDI_Vat1],
            [WCDI_Vat2],
            [WCDI_Vat3],
            [WCDI_Vat4],
            [WCDI_Vat5],
            [WCDI_Vat6],
            [WCDI_Vat7],
            [WCDI_Vat8],
            [WCDI_Vat9],
            [WCDI_Vat10],
            [WCDI_Net1],
            [WCDI_Net2],
            [WCDI_Net3],
            [WCDI_Net4],
            [WCDI_Net5],
            [WCDI_Net6],
            [WCDI_Net7],
            [WCDI_Net8],
            [WCDI_Net9],
            [WCDI_Net10],
            [WCDI_WCur_ID1],
            [WCDI_WCur_ID2],
            [WCDI_WCur_ID3],
            [WCDI_WCur_ID4],
            [WCDI_WCur_ID5],
            [WCDI_WCur_ID6],
            [WCDI_WCur_ID7],
            [WCDI_WCur_ID8],
            [WCDI_WCur_ID9],
            [WCDI_WCur_ID10],
            [WPRL_Line_Seq_No],
            [CURRCOST]'
        SET @l_temp_select = 
            ') ' + 
            'SELECT ' + 
            'TOP ' + convert(varchar, @l_end_gen_row_num) + ' '
        SET @l_temp_colsWithAlias1 = 
            N'sel_WCanvass_Detail_Internal_WPR_Line_.[WPRL_WPRD_ID],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCI_ID],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_ID],
            sel_WCanvass_Detail_Internal_WPR_Line_.[Item],
            sel_WCanvass_Detail_Internal_WPR_Line_.[ItemDescription],
            sel_WCanvass_Detail_Internal_WPR_Line_.[UnitOfMeasure],
            sel_WCanvass_Detail_Internal_WPR_Line_.[Site],
            sel_WCanvass_Detail_Internal_WPR_Line_.[UnitPrice],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WPRL_Qty],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WPRL_Ext_Price],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID1],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid1],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award1],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID2],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid2],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award2],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID3],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid3],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award3],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID4],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid4],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award4],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID5],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid5],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award5],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID6],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid6],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award6],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Status],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Audit_Comment],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Comment],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WPRL_ID],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID7],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid7],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award7],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID8],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid8],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award8],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID9],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid9],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award9],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID10],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid10],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award10],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WPRL_WClass_ID],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCI_ID],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty1],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty2],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty3],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty4],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty5],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty6],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty7],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty8],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty9],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty10],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw1],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw2],'
        SET @l_temp_colsWithAlias2 = 
            N'            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw3],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw4],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw5],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw6],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw7],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw8],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw9],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw10],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO1],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO2],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO3],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO4],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO5],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO6],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO7],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO8],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO9],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO10],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat1],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat2],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat3],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat4],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat5],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat6],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat7],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat8],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat9],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat10],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net1],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net2],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net3],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net4],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net5],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net6],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net7],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net8],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net9],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net10],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID1],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID2],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID3],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID4],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID5],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID6],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID7],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID8],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID9],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID10],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WPRL_Line_Seq_No],
            sel_WCanvass_Detail_Internal_WPR_Line_.[CURRCOST]'
        SET @l_temp_from = 
            ' FROM ' + @l_from_str + ' ' + @l_join_str + ' ' + 
            @l_where_str + ' ' + 
            @l_sort_str

        -- Construct the main query
        SET @l_query_select = 'SELECT '
        SET @l_query_cols = 
            N'[WPRL_WPRD_ID],
            [WCDI_WCI_ID],
            [WCDI_ID],
            [Item],
            [ItemDescription],
            [UnitOfMeasure],
            [Site],
            [UnitPrice],
            [WPRL_Qty],
            [WPRL_Ext_Price],
            [WCDI_PM00200_Vendor_ID1],
            [WCDI_Bid1],
            [WCDI_Award1],
            [WCDI_PM00200_Vendor_ID2],
            [WCDI_Bid2],
            [WCDI_Award2],
            [WCDI_PM00200_Vendor_ID3],
            [WCDI_Bid3],
            [WCDI_Award3],
            [WCDI_PM00200_Vendor_ID4],
            [WCDI_Bid4],
            [WCDI_Award4],
            [WCDI_PM00200_Vendor_ID5],
            [WCDI_Bid5],
            [WCDI_Award5],
            [WCDI_PM00200_Vendor_ID6],
            [WCDI_Bid6],
            [WCDI_Award6],
            [WCDI_Status],
            [WCDI_Audit_Comment],
            [WCDI_Comment],
            [WPRL_ID],
            [WCDI_PM00200_Vendor_ID7],
            [WCDI_Bid7],
            [WCDI_Award7],
            [WCDI_PM00200_Vendor_ID8],
            [WCDI_Bid8],
            [WCDI_Award8],
            [WCDI_PM00200_Vendor_ID9],
            [WCDI_Bid9],
            [WCDI_Award9],
            [WCDI_PM00200_Vendor_ID10],
            [WCDI_Bid10],
            [WCDI_Award10],
            [WPRL_WClass_ID],
            [WCI_ID],
            [WCDI_Qty1],
            [WCDI_Qty2],
            [WCDI_Qty3],
            [WCDI_Qty4],
            [WCDI_Qty5],
            [WCDI_Qty6],
            [WCDI_Qty7],
            [WCDI_Qty8],
            [WCDI_Qty9],
            [WCDI_Qty10],
            [WCDI_Aw1],
            [WCDI_Aw2],
            [WCDI_Aw3],
            [WCDI_Aw4],
            [WCDI_Aw5],
            [WCDI_Aw6],
            [WCDI_Aw7],
            [WCDI_Aw8],
            [WCDI_Aw9],
            [WCDI_Aw10],
            [WCDI_PO1],
            [WCDI_PO2],
            [WCDI_PO3],
            [WCDI_PO4],
            [WCDI_PO5],
            [WCDI_PO6],
            [WCDI_PO7],
            [WCDI_PO8],
            [WCDI_PO9],
            [WCDI_PO10],
            [WCDI_Vat1],
            [WCDI_Vat2],
            [WCDI_Vat3],
            [WCDI_Vat4],
            [WCDI_Vat5],
            [WCDI_Vat6],
            [WCDI_Vat7],
            [WCDI_Vat8],
            [WCDI_Vat9],
            [WCDI_Vat10],
            [WCDI_Net1],
            [WCDI_Net2],
            [WCDI_Net3],
            [WCDI_Net4],
            [WCDI_Net5],
            [WCDI_Net6],
            [WCDI_Net7],
            [WCDI_Net8],
            [WCDI_Net9],
            [WCDI_Net10],
            [WCDI_WCur_ID1],
            [WCDI_WCur_ID2],
            [WCDI_WCur_ID3],
            [WCDI_WCur_ID4],
            [WCDI_WCur_ID5],
            [WCDI_WCur_ID6],
            [WCDI_WCur_ID7],
            [WCDI_WCur_ID8],
            [WCDI_WCur_ID9],
            [WCDI_WCur_ID10],
            [WPRL_Line_Seq_No],
            [CURRCOST]'

        SET @l_query_from = 
            'FROM @IS_TEMP_T_GETLIST ' +
            'WHERE IS_ROWNUM_COL >= '+ convert(varchar, @l_start_gen_row_num) 

        SET @l_final_sort = 'ORDER BY IS_ROWNUM_COL Asc '

        -- Run the query
        EXECUTE (@l_temp_table + @l_temp_insert + @l_temp_cols + @l_temp_select + @l_temp_colsWithAlias1 + @l_temp_colsWithAlias2 + @l_temp_from + '; ' + @l_query_select + @l_query_cols + @l_query_from + @l_query_where + @l_final_sort)

    END
    ELSE
    BEGIN
        -- If page number and batch size are not valid numbers return an empty result set
        SET @l_query_select = 'SELECT '
        SET @l_query_cols = 
            N'sel_WCanvass_Detail_Internal_WPR_Line_.[WPRL_WPRD_ID],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCI_ID],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_ID],
            sel_WCanvass_Detail_Internal_WPR_Line_.[Item],
            sel_WCanvass_Detail_Internal_WPR_Line_.[ItemDescription],
            sel_WCanvass_Detail_Internal_WPR_Line_.[UnitOfMeasure],
            sel_WCanvass_Detail_Internal_WPR_Line_.[Site],
            sel_WCanvass_Detail_Internal_WPR_Line_.[UnitPrice],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WPRL_Qty],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WPRL_Ext_Price],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID1],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid1],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award1],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID2],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid2],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award2],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID3],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid3],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award3],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID4],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid4],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award4],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID5],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid5],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award5],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID6],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid6],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award6],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Status],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Audit_Comment],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Comment],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WPRL_ID],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID7],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid7],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award7],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID8],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid8],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award8],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID9],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid9],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award9],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID10],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid10],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award10],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WPRL_WClass_ID],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCI_ID],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty1],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty2],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty3],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty4],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty5],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty6],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty7],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty8],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty9],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty10],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw1],
            sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw2],'
        SET @l_query_from = 
            ' FROM [dbo].[sel_WCanvass_Detail_Internal_WPR_Line] sel_WCanvass_Detail_Internal_WPR_Line_ ' + 
            'WHERE 1=2;'
        EXECUTE (@l_query_select + @l_query_cols + @l_query_from);
    END

    SET NOCOUNT OFF

END

