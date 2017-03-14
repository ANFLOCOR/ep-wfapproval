﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WCAR_Doc_Creator_ApproverGetList') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WCAR_Doc_Creator_ApproverGetList 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a query resultset from table [dbo].[sel_WCAR_Doc_Creator_Approver]
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
CREATE PROCEDURE pePortalWFApprovalSel_WCAR_Doc_Creator_ApproverGetList
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
    SET @l_from_str = '[dbo].[sel_WCAR_Doc_Creator_Approver] sel_WCAR_Doc_Creator_Approver_'

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
            SET @l_sort_str = N'ORDER BY sel_WCAR_Doc_Creator_Approver_.[Row] asc '

        -- Calculate the rows to be included in the list
        SET @l_end_gen_row_num = @p_page_number * @p_batch_size;
        SET @l_start_gen_row_num = @l_end_gen_row_num - (@p_batch_size-1);

        -- Construct the main query
        SET @l_query_select = 'WITH sel_WCAR_Doc_Creator_Approver_ AS ( SELECT  '
        SET @l_query_rownum = 'ROW_NUMBER() OVER(' + @l_sort_str + ') AS IS_ROWNUM_COL,'
        SET @l_query_cols = 
            N'sel_WCAR_Doc_Creator_Approver_.[WCD_ID],
            sel_WCAR_Doc_Creator_Approver_.[WCD_WDT_ID],
            sel_WCAR_Doc_Creator_Approver_.[WCD_No],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Submit],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Status],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Remark],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Unit_Location],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Project_Title],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Project_No],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Request_Date],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Proj_Inc_ACB],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Total],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Prev_Total],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Budget],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Under_Over_Budget],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Cur_Yr],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Nxt_Yr],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Sub_Yr],
            sel_WCAR_Doc_Creator_Approver_.[WCD_C_ID],
            sel_WCAR_Doc_Creator_Approver_.[WCD_U_ID],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Created],
            sel_WCAR_Doc_Creator_Approver_.[WCD_WCur_ID],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Supplementary],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Supplementary_WCD_ID],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Supplementary_Manual],
            sel_WCAR_Doc_Creator_Approver_.[User_ID],
            sel_WCAR_Doc_Creator_Approver_.[Row],
            CAST(BINARY_CHECKSUM(sel_WCAR_Doc_Creator_Approver_.[WCD_ID],sel_WCAR_Doc_Creator_Approver_.[WCD_WDT_ID],sel_WCAR_Doc_Creator_Approver_.[WCD_No],sel_WCAR_Doc_Creator_Approver_.[WCD_Submit],sel_WCAR_Doc_Creator_Approver_.[WCD_Status],sel_WCAR_Doc_Creator_Approver_.[WCD_Remark],sel_WCAR_Doc_Creator_Approver_.[WCD_Unit_Location],sel_WCAR_Doc_Creator_Approver_.[WCD_Project_Title],sel_WCAR_Doc_Creator_Approver_.[WCD_Project_No],sel_WCAR_Doc_Creator_Approver_.[WCD_Request_Date],sel_WCAR_Doc_Creator_Approver_.[WCD_Proj_Inc_ACB],sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Total],sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Prev_Total],sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Budget],sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Under_Over_Budget],sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Cur_Yr],sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Nxt_Yr],sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Sub_Yr],sel_WCAR_Doc_Creator_Approver_.[WCD_C_ID],sel_WCAR_Doc_Creator_Approver_.[WCD_U_ID],sel_WCAR_Doc_Creator_Approver_.[WCD_Created],sel_WCAR_Doc_Creator_Approver_.[WCD_WCur_ID],sel_WCAR_Doc_Creator_Approver_.[WCD_Supplementary],sel_WCAR_Doc_Creator_Approver_.[WCD_Supplementary_WCD_ID],sel_WCAR_Doc_Creator_Approver_.[WCD_Supplementary_Manual],sel_WCAR_Doc_Creator_Approver_.[User_ID],sel_WCAR_Doc_Creator_Approver_.[Row]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345'
        SET @l_query_from = ' FROM ' + @l_from_str + ' ' + @l_join_str + ' ' + @l_where_str + ') '
        SET @l_query_select2 = 'SELECT * FROM sel_WCAR_Doc_Creator_Approver_ '
        SET @l_query_where = 'WHERE IS_ROWNUM_COL BETWEEN ' + convert(varchar, @l_start_gen_row_num) + ' AND ' + convert(varchar, @l_end_gen_row_num) +  ';'

        -- Run the query
        EXECUTE (@l_query_select + @l_query_rownum + @l_query_cols + @l_query_from + @l_query_select2 + @l_query_where)

    END
    ELSE
    BEGIN
        -- If page number and batch size are not valid numbers return an empty result set
        SET @l_query_select = 'SELECT '
        SET @l_query_cols = 
            N'sel_WCAR_Doc_Creator_Approver_.[WCD_ID],
            sel_WCAR_Doc_Creator_Approver_.[WCD_WDT_ID],
            sel_WCAR_Doc_Creator_Approver_.[WCD_No],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Submit],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Status],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Remark],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Unit_Location],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Project_Title],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Project_No],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Request_Date],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Proj_Inc_ACB],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Total],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Prev_Total],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Budget],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Under_Over_Budget],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Cur_Yr],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Nxt_Yr],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Sub_Yr],
            sel_WCAR_Doc_Creator_Approver_.[WCD_C_ID],
            sel_WCAR_Doc_Creator_Approver_.[WCD_U_ID],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Created],
            sel_WCAR_Doc_Creator_Approver_.[WCD_WCur_ID],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Supplementary],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Supplementary_WCD_ID],
            sel_WCAR_Doc_Creator_Approver_.[WCD_Supplementary_Manual],
            sel_WCAR_Doc_Creator_Approver_.[User_ID],
            sel_WCAR_Doc_Creator_Approver_.[Row],
            CAST(BINARY_CHECKSUM(sel_WCAR_Doc_Creator_Approver_.[WCD_ID],sel_WCAR_Doc_Creator_Approver_.[WCD_WDT_ID],sel_WCAR_Doc_Creator_Approver_.[WCD_No],sel_WCAR_Doc_Creator_Approver_.[WCD_Submit],sel_WCAR_Doc_Creator_Approver_.[WCD_Status],sel_WCAR_Doc_Creator_Approver_.[WCD_Remark],sel_WCAR_Doc_Creator_Approver_.[WCD_Unit_Location],sel_WCAR_Doc_Creator_Approver_.[WCD_Project_Title],sel_WCAR_Doc_Creator_Approver_.[WCD_Project_No],sel_WCAR_Doc_Creator_Approver_.[WCD_Request_Date],sel_WCAR_Doc_Creator_Approver_.[WCD_Proj_Inc_ACB],sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Total],sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Prev_Total],sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Budget],sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Under_Over_Budget],sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Cur_Yr],sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Nxt_Yr],sel_WCAR_Doc_Creator_Approver_.[WCD_Exp_Sub_Yr],sel_WCAR_Doc_Creator_Approver_.[WCD_C_ID],sel_WCAR_Doc_Creator_Approver_.[WCD_U_ID],sel_WCAR_Doc_Creator_Approver_.[WCD_Created],sel_WCAR_Doc_Creator_Approver_.[WCD_WCur_ID],sel_WCAR_Doc_Creator_Approver_.[WCD_Supplementary],sel_WCAR_Doc_Creator_Approver_.[WCD_Supplementary_WCD_ID],sel_WCAR_Doc_Creator_Approver_.[WCD_Supplementary_Manual],sel_WCAR_Doc_Creator_Approver_.[User_ID],sel_WCAR_Doc_Creator_Approver_.[Row]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345'
        SET @l_query_from = 
            ' FROM [dbo].[sel_WCAR_Doc_Creator_Approver] sel_WCAR_Doc_Creator_Approver_ ' + 
            'WHERE 1=2;'
        EXECUTE (@l_query_select + @l_query_cols + @l_query_from);
    END

    SET NOCOUNT OFF

END

