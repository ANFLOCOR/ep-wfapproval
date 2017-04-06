if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysSetupUserPermission2Export') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysSetupUserPermission2Export 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pePortalWFApprovalSysSetupUserPermission2Export
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
                N'"SSUP_SSU_UserName"' + @p_separator_str +
                N'"""SSUP_SSU_UserName"" SSU_FullName"' + @p_separator_str +
                N'"SSUP_SSR_RoleID"' + @p_separator_str +
                N'"""SSUP_SSR_RoleID"" SSR_RoleName"' + @p_separator_str +
                N'"SSUP_SSR_AppID"' + @p_separator_str +
                N'"""SSUP_SSR_AppID"" App_Name"' + @p_separator_str +
                N'"SSUP_SSC_CompanyID"' + @p_separator_str +
                N'"""SSUP_SSC_CompanyID"" SSC_CompanyName"' + @p_separator_str +
                N'"SSUP_Permission"' + @p_separator_str +
                N'"SSUP_SSUC_RowID"' + @p_separator_str +
                N'"""SSUP_SSUC_RowID"" SSUC_SSU_UserName"' + @p_separator_str +
                N'"SSUP_RowID"' + @p_separator_str +
                N'"SSUP_isDefault"' + ' ';
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
                N'N''"'' + REPLACE(IsNULL(SysSetupUserPermission_.[SSUP_SSU_UserName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[SSU_FullName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, SysSetupUserPermission_.[SSUP_SSR_RoleID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t1.[SSR_RoleName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, SysSetupUserPermission_.[SSUP_SSR_AppID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t2.[App_Name], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, SysSetupUserPermission_.[SSUP_SSC_CompanyID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t3.[SSC_CompanyName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(SysSetupUserPermission_.[SSUP_Permission], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, SysSetupUserPermission_.[SSUP_SSUC_RowID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t4.[SSUC_SSU_UserName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, SysSetupUserPermission_.[SSUP_RowID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, SysSetupUserPermission_.[SSUP_isDefault]), '''') + N''"'' + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[SysSetupUserPermission] SysSetupUserPermission_ LEFT OUTER JOIN [dbo].[SysSetupUsers] t0 ON (SysSetupUserPermission_.[SSUP_SSU_UserName] =  t0.[SSU_UserName]) LEFT OUTER JOIN [dbo].[SysSetupRole] t1 ON (SysSetupUserPermission_.[SSUP_SSR_RoleID] =  t1.[SSR_RoleID]) LEFT OUTER JOIN [dbo].[Applications] t2 ON (SysSetupUserPermission_.[SSUP_SSR_AppID] =  t2.[App_ID]) LEFT OUTER JOIN [dbo].[SysSetupCompany] t3 ON (SysSetupUserPermission_.[SSUP_SSC_CompanyID] =  t3.[SSC_CompanyID]) LEFT OUTER JOIN [dbo].[SysSetupUserCompany] t4 ON (SysSetupUserPermission_.[SSUP_SSUC_RowID] =  t4.[SSUC_RowID])';

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

