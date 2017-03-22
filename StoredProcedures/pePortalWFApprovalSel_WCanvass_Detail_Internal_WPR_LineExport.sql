if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WCanvass_Detail_Internal_WPR_LineExport') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WCanvass_Detail_Internal_WPR_LineExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pePortalWFApprovalSel_WCanvass_Detail_Internal_WPR_LineExport
        @p_separator_str nvarchar(15),
        @p_title_str nvarchar(max),
        @p_select_str nvarchar(max),
        @p_join_str nvarchar(max),
        @p_where_str nvarchar(max),
        @p_num_exported int output
    AS
    DECLARE
        @l_title_str1 nvarchar(max),
        @l_title_str2 nvarchar(max),
        @l_select_str1 nvarchar(max),
        @l_select_str2 nvarchar(max),
        @l_select_str3 nvarchar(max),
        @l_select_str4 nvarchar(max),
        @l_select_str5 nvarchar(max),
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
        SET @l_title_str1 = @p_title_str + char(13)
        SET @l_title_str2 = ''
        IF @p_title_str IS NULL
            BEGIN
            SET @l_title_str1 = 
                N'"WPRL_WPRD_ID"' + @p_separator_str +
                N'"WCDI_WCI_ID"' + @p_separator_str +
                N'"WCDI_ID"' + @p_separator_str +
                N'"Item"' + @p_separator_str +
                N'"ItemDescription"' + @p_separator_str +
                N'"UnitOfMeasure"' + @p_separator_str +
                N'"Site"' + @p_separator_str +
                N'"UnitPrice"' + @p_separator_str +
                N'"WPRL_Qty"' + @p_separator_str +
                N'"WPRL_Ext_Price"' + @p_separator_str +
                N'"WCDI_PM00200_Vendor_ID1"' + @p_separator_str +
                N'"WCDI_Bid1"' + @p_separator_str +
                N'"WCDI_Award1"' + @p_separator_str +
                N'"WCDI_PM00200_Vendor_ID2"' + @p_separator_str +
                N'"WCDI_Bid2"' + @p_separator_str +
                N'"WCDI_Award2"' + @p_separator_str +
                N'"WCDI_PM00200_Vendor_ID3"' + @p_separator_str +
                N'"WCDI_Bid3"' + @p_separator_str +
                N'"WCDI_Award3"' + @p_separator_str +
                N'"WCDI_PM00200_Vendor_ID4"' + @p_separator_str +
                N'"WCDI_Bid4"' + @p_separator_str +
                N'"WCDI_Award4"' + @p_separator_str +
                N'"WCDI_PM00200_Vendor_ID5"' + @p_separator_str +
                N'"WCDI_Bid5"' + @p_separator_str +
                N'"WCDI_Award5"' + @p_separator_str +
                N'"WCDI_PM00200_Vendor_ID6"' + @p_separator_str +
                N'"WCDI_Bid6"' + @p_separator_str +
                N'"WCDI_Award6"' + @p_separator_str +
                N'"WCDI_Status"' + @p_separator_str +
                N'"WCDI_Audit_Comment"' + @p_separator_str +
                N'"WCDI_Comment"' + @p_separator_str +
                N'"WPRL_ID"' + @p_separator_str +
                N'"WCDI_PM00200_Vendor_ID7"' + @p_separator_str +
                N'"WCDI_Bid7"' + @p_separator_str +
                N'"WCDI_Award7"' + @p_separator_str +
                N'"WCDI_PM00200_Vendor_ID8"' + @p_separator_str +
                N'"WCDI_Bid8"' + @p_separator_str +
                N'"WCDI_Award8"' + @p_separator_str +
                N'"WCDI_PM00200_Vendor_ID9"' + @p_separator_str +
                N'"WCDI_Bid9"' + @p_separator_str +
                N'"WCDI_Award9"' + @p_separator_str +
                N'"WCDI_PM00200_Vendor_ID10"' + @p_separator_str +
                N'"WCDI_Bid10"' + @p_separator_str +
                N'"WCDI_Award10"' + @p_separator_str +
                N'"WPRL_WClass_ID"' + @p_separator_str +
                N'"WCI_ID"' + @p_separator_str +
                N'"WCDI_Qty1"' + @p_separator_str +
                N'"WCDI_Qty2"' + @p_separator_str +
                N'"WCDI_Qty3"' + @p_separator_str +
                N'"WCDI_Qty4"' + @p_separator_str +
                N'"WCDI_Qty5"' + @p_separator_str +
                N'"WCDI_Qty6"' + @p_separator_str +
                N'"WCDI_Qty7"' + @p_separator_str +
                N'"WCDI_Qty8"' + @p_separator_str +
                N'"WCDI_Qty9"' + @p_separator_str +
                N'"WCDI_Qty10"' + @p_separator_str +
                N'"WCDI_Aw1"' + @p_separator_str +
                N'"WCDI_Aw2"' + @p_separator_str +
                N'"WCDI_Aw3"' + @p_separator_str +
                N'"WCDI_Aw4"' + @p_separator_str +
                N'"WCDI_Aw5"' + @p_separator_str +
                N'"WCDI_Aw6"' + @p_separator_str +
                N'"WCDI_Aw7"' + @p_separator_str +
                N'"WCDI_Aw8"' + @p_separator_str +
                N'"WCDI_Aw9"' + @p_separator_str +
                N'"WCDI_Aw10"' + @p_separator_str +
                N'"WCDI_PO1"' + @p_separator_str +
                N'"WCDI_PO2"' + @p_separator_str +
                N'"WCDI_PO3"' + @p_separator_str +
                N'"WCDI_PO4"' + @p_separator_str +
                N'"WCDI_PO5"' + @p_separator_str +
                N'"WCDI_PO6"' + @p_separator_str 
            SET @l_title_str2 = 
                N'"WCDI_PO7"' + @p_separator_str +
                N'"WCDI_PO8"' + @p_separator_str +
                N'"WCDI_PO9"' + @p_separator_str +
                N'"WCDI_PO10"' + @p_separator_str +
                N'"WCDI_Vat1"' + @p_separator_str +
                N'"WCDI_Vat2"' + @p_separator_str +
                N'"WCDI_Vat3"' + @p_separator_str +
                N'"WCDI_Vat4"' + @p_separator_str +
                N'"WCDI_Vat5"' + @p_separator_str +
                N'"WCDI_Vat6"' + @p_separator_str +
                N'"WCDI_Vat7"' + @p_separator_str +
                N'"WCDI_Vat8"' + @p_separator_str +
                N'"WCDI_Vat9"' + @p_separator_str +
                N'"WCDI_Vat10"' + @p_separator_str +
                N'"WCDI_Net1"' + @p_separator_str +
                N'"WCDI_Net2"' + @p_separator_str +
                N'"WCDI_Net3"' + @p_separator_str +
                N'"WCDI_Net4"' + @p_separator_str +
                N'"WCDI_Net5"' + @p_separator_str +
                N'"WCDI_Net6"' + @p_separator_str +
                N'"WCDI_Net7"' + @p_separator_str +
                N'"WCDI_Net8"' + @p_separator_str +
                N'"WCDI_Net9"' + @p_separator_str +
                N'"WCDI_Net10"' + @p_separator_str +
                N'"WCDI_WCur_ID1"' + @p_separator_str +
                N'"WCDI_WCur_ID2"' + @p_separator_str +
                N'"WCDI_WCur_ID3"' + @p_separator_str +
                N'"WCDI_WCur_ID4"' + @p_separator_str +
                N'"WCDI_WCur_ID5"' + @p_separator_str +
                N'"WCDI_WCur_ID6"' + @p_separator_str +
                N'"WCDI_WCur_ID7"' + @p_separator_str +
                N'"WCDI_WCur_ID8"' + @p_separator_str +
                N'"WCDI_WCur_ID9"' + @p_separator_str +
                N'"WCDI_WCur_ID10"' + @p_separator_str +
                N'"WPRL_Line_Seq_No"' + @p_separator_str +
                N'"CURRCOST"' + ' ';
            END
        ELSE IF SUBSTRING(@l_title_str1, 1, 2) = 'ID'
            SET @l_title_str1 = 
                '"' + 
                SUBSTRING(@l_title_str1, 1, PATINDEX('%,%', @l_title_str1)-1) + 
                '"' + 
                SUBSTRING(@l_title_str1, PATINDEX('%,%', @l_title_str1), LEN(@l_title_str1)); 

        -- Set up the select string
        SET @l_select_str1 = @p_select_str
        SET @l_select_str2 = @p_select_str
        SET @l_select_str3 = @p_select_str
        SET @l_select_str4 = @p_select_str
        SET @l_select_str5 = @p_select_str
        IF @p_select_str IS NULL
            BEGIN
            SET @l_select_str1 = 
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WPRL_WPRD_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCI_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WCanvass_Detail_Internal_WPR_Line_.[Item], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WCanvass_Detail_Internal_WPR_Line_.[ItemDescription], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WCanvass_Detail_Internal_WPR_Line_.[UnitOfMeasure], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WCanvass_Detail_Internal_WPR_Line_.[Site], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[UnitPrice]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WPRL_Qty]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WPRL_Ext_Price]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID1], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid1]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award1]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID2], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid2]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award2]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID3], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid3]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award3]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID4], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid4]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award4]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID5], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid5]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award5]), '''') + N''"'' + ''' + @p_separator_str + ''' +' 
            SET @l_select_str2 = 
                N'N''"'' + REPLACE(IsNULL(sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID6], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid6]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award6]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Status], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Audit_Comment], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Comment], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WPRL_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID7], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid7]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award7]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID8], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid8]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award8]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID9], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid9]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award9]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PM00200_Vendor_ID10], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Bid10]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Award10]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WPRL_WClass_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCI_ID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty1]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty2]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty3]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty4]), '''') + ''' + @p_separator_str + ''' +' 
            SET @l_select_str3 = 
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty5]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty6]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty7]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty8]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty9]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Qty10]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw1]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw2]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw3]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw4]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw5]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw6]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw7]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw8]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw9]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Aw10]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO1]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO2]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO3]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO4]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO5]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO6]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO7]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO8]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO9]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_PO10]), '''') + N''"'' + ''' + @p_separator_str + ''' +' 
            SET @l_select_str4 = 
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat1]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat2]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat3]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat4]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat5]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat6]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat7]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat8]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat9]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Vat10]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net1]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net2]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net3]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net4]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net5]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net6]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net7]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net8]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net9]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_Net10]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID1]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID2]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID3]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID4]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID5]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID6]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID7]), '''') + ''' + @p_separator_str + ''' +' 
            SET @l_select_str5 = 
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID8]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID9]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WCDI_WCur_ID10]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[WPRL_Line_Seq_No]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WCanvass_Detail_Internal_WPR_Line_.[CURRCOST]), '''') + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[sel_WCanvass_Detail_Internal_WPR_Line] sel_WCanvass_Detail_Internal_WPR_Line_';

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
        EXECUTE (@l_query_select + @l_title_str1 + @l_title_str2 + @l_query_union + @l_select_str1 + @l_select_str2 + @l_select_str3 + @l_select_str4 + @l_select_str5+ @l_query_from)

        -- Return the total number of rows of the query
        SELECT @p_num_exported = @@rowcount
    END

