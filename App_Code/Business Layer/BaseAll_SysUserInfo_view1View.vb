' This class is "generated" and will be overwritten.
' Your customizations should be made in All_SysUserInfo_view1View.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ePortalWFApproval.Data

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="All_SysUserInfo_view1View"></see> class.
''' Provides access to the schema information and record data of a database table or view named DatabaseWASSN%dbo.All_SysUserInfo_view.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="All_SysUserInfo_view1View.Instance">All_SysUserInfo_view1View.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="All_SysUserInfo_view1View"></seealso>

<Serializable()> Public Class BaseAll_SysUserInfo_view1View
	Inherits KeylessTable
	

	Private ReadOnly TableDefinitionString As String = All_SysUserInfo_view1Definition.GetXMLString()







	Protected Sub New()
		MyBase.New()
		Me.Initialize()
	End Sub

	Protected Overridable Sub Initialize()
		Dim def As New XmlTableDefinition(TableDefinitionString)
		Me.TableDefinition = New TableDefinition()
		Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.All_SysUserInfo_view1View")
		def.InitializeTableDefinition(Me.TableDefinition)
		Me.ConnectionName = def.GetConnectionName()
		Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.All_SysUserInfo_view1Record")
		Me.ApplicationName = "App_Code"
		Me.DataAdapter = New All_SysUserInfo_view1SqlView()
		Directcast(Me.DataAdapter, All_SysUserInfo_view1SqlView).ConnectionName = Me.ConnectionName
		Directcast(Me.DataAdapter, All_SysUserInfo_view1SqlView).ApplicationName = Me.ApplicationName
		Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        SSU_UserNameColumn.CodeName = "SSU_UserName"
        SSU_FullNameColumn.CodeName = "SSU_FullName"
        SSU_PasswordColumn.CodeName = "SSU_Password"
        SSU_EmpIDColumn.CodeName = "SSU_EmpID"
        SSU_SSC_CompanyIDColumn.CodeName = "SSU_SSC_CompanyID"
        SSU_IsActiveColumn.CodeName = "SSU_IsActive"
        SSU_DateCreatedColumn.CodeName = "SSU_DateCreated"
        SSU_DateModifiedColumn.CodeName = "SSU_DateModified"
        SSU_RowIDColumn.CodeName = "SSU_RowID"
        SSUA_App_IDColumn.CodeName = "SSUA_App_ID"
        SSUA_DateCreatedColumn.CodeName = "SSUA_DateCreated"
        App_NameColumn.CodeName = "App_Name"
        App_DescriptionColumn.CodeName = "App_Description"
        SSUC_SSC_CompanyIDColumn.CodeName = "SSUC_SSC_CompanyID"
        SSUC_isDefaultColumn.CodeName = "SSUC_isDefault"
        SSC_CompanyNameColumn.CodeName = "SSC_CompanyName"
        SSC_DescriptionColumn.CodeName = "SSC_Description"
        SSUP_SSR_RoleIDColumn.CodeName = "SSUP_SSR_RoleID"
        SSUP_PermissionColumn.CodeName = "SSUP_Permission"
        SSR_RoleNameColumn.CodeName = "SSR_RoleName"
        SSUE_EmailColumn.CodeName = "SSUE_Email"
		
	End Sub
	
#Region "Overriden methods"
    
#End Region
	
#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSU_UserName column object.
    ''' </summary>
    Public ReadOnly Property SSU_UserNameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSU_UserName column object.
    ''' </summary>
    Public Shared ReadOnly Property SSU_UserName() As BaseClasses.Data.StringColumn
        Get
            Return All_SysUserInfo_view1View.Instance.SSU_UserNameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSU_FullName column object.
    ''' </summary>
    Public ReadOnly Property SSU_FullNameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSU_FullName column object.
    ''' </summary>
    Public Shared ReadOnly Property SSU_FullName() As BaseClasses.Data.StringColumn
        Get
            Return All_SysUserInfo_view1View.Instance.SSU_FullNameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSU_Password column object.
    ''' </summary>
    Public ReadOnly Property SSU_PasswordColumn() As BaseClasses.Data.PasswordColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.PasswordColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSU_Password column object.
    ''' </summary>
    Public Shared ReadOnly Property SSU_Password() As BaseClasses.Data.PasswordColumn
        Get
            Return All_SysUserInfo_view1View.Instance.SSU_PasswordColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSU_EmpID column object.
    ''' </summary>
    Public ReadOnly Property SSU_EmpIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSU_EmpID column object.
    ''' </summary>
    Public Shared ReadOnly Property SSU_EmpID() As BaseClasses.Data.NumberColumn
        Get
            Return All_SysUserInfo_view1View.Instance.SSU_EmpIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSU_SSC_CompanyID column object.
    ''' </summary>
    Public ReadOnly Property SSU_SSC_CompanyIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSU_SSC_CompanyID column object.
    ''' </summary>
    Public Shared ReadOnly Property SSU_SSC_CompanyID() As BaseClasses.Data.NumberColumn
        Get
            Return All_SysUserInfo_view1View.Instance.SSU_SSC_CompanyIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSU_IsActive column object.
    ''' </summary>
    Public ReadOnly Property SSU_IsActiveColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSU_IsActive column object.
    ''' </summary>
    Public Shared ReadOnly Property SSU_IsActive() As BaseClasses.Data.BooleanColumn
        Get
            Return All_SysUserInfo_view1View.Instance.SSU_IsActiveColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSU_DateCreated column object.
    ''' </summary>
    Public ReadOnly Property SSU_DateCreatedColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSU_DateCreated column object.
    ''' </summary>
    Public Shared ReadOnly Property SSU_DateCreated() As BaseClasses.Data.DateColumn
        Get
            Return All_SysUserInfo_view1View.Instance.SSU_DateCreatedColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSU_DateModified column object.
    ''' </summary>
    Public ReadOnly Property SSU_DateModifiedColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSU_DateModified column object.
    ''' </summary>
    Public Shared ReadOnly Property SSU_DateModified() As BaseClasses.Data.DateColumn
        Get
            Return All_SysUserInfo_view1View.Instance.SSU_DateModifiedColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSU_RowID column object.
    ''' </summary>
    Public ReadOnly Property SSU_RowIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSU_RowID column object.
    ''' </summary>
    Public Shared ReadOnly Property SSU_RowID() As BaseClasses.Data.NumberColumn
        Get
            Return All_SysUserInfo_view1View.Instance.SSU_RowIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSUA_App_ID column object.
    ''' </summary>
    Public ReadOnly Property SSUA_App_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSUA_App_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property SSUA_App_ID() As BaseClasses.Data.NumberColumn
        Get
            Return All_SysUserInfo_view1View.Instance.SSUA_App_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSUA_DateCreated column object.
    ''' </summary>
    Public ReadOnly Property SSUA_DateCreatedColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSUA_DateCreated column object.
    ''' </summary>
    Public Shared ReadOnly Property SSUA_DateCreated() As BaseClasses.Data.DateColumn
        Get
            Return All_SysUserInfo_view1View.Instance.SSUA_DateCreatedColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.App_Name column object.
    ''' </summary>
    Public ReadOnly Property App_NameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.App_Name column object.
    ''' </summary>
    Public Shared ReadOnly Property App_Name() As BaseClasses.Data.StringColumn
        Get
            Return All_SysUserInfo_view1View.Instance.App_NameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.App_Description column object.
    ''' </summary>
    Public ReadOnly Property App_DescriptionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.App_Description column object.
    ''' </summary>
    Public Shared ReadOnly Property App_Description() As BaseClasses.Data.StringColumn
        Get
            Return All_SysUserInfo_view1View.Instance.App_DescriptionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSUC_SSC_CompanyID column object.
    ''' </summary>
    Public ReadOnly Property SSUC_SSC_CompanyIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSUC_SSC_CompanyID column object.
    ''' </summary>
    Public Shared ReadOnly Property SSUC_SSC_CompanyID() As BaseClasses.Data.NumberColumn
        Get
            Return All_SysUserInfo_view1View.Instance.SSUC_SSC_CompanyIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSUC_isDefault column object.
    ''' </summary>
    Public ReadOnly Property SSUC_isDefaultColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSUC_isDefault column object.
    ''' </summary>
    Public Shared ReadOnly Property SSUC_isDefault() As BaseClasses.Data.BooleanColumn
        Get
            Return All_SysUserInfo_view1View.Instance.SSUC_isDefaultColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSC_CompanyName column object.
    ''' </summary>
    Public ReadOnly Property SSC_CompanyNameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSC_CompanyName column object.
    ''' </summary>
    Public Shared ReadOnly Property SSC_CompanyName() As BaseClasses.Data.StringColumn
        Get
            Return All_SysUserInfo_view1View.Instance.SSC_CompanyNameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSC_Description column object.
    ''' </summary>
    Public ReadOnly Property SSC_DescriptionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSC_Description column object.
    ''' </summary>
    Public Shared ReadOnly Property SSC_Description() As BaseClasses.Data.StringColumn
        Get
            Return All_SysUserInfo_view1View.Instance.SSC_DescriptionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSUP_SSR_RoleID column object.
    ''' </summary>
    Public ReadOnly Property SSUP_SSR_RoleIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSUP_SSR_RoleID column object.
    ''' </summary>
    Public Shared ReadOnly Property SSUP_SSR_RoleID() As BaseClasses.Data.NumberColumn
        Get
            Return All_SysUserInfo_view1View.Instance.SSUP_SSR_RoleIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSUP_Permission column object.
    ''' </summary>
    Public ReadOnly Property SSUP_PermissionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSUP_Permission column object.
    ''' </summary>
    Public Shared ReadOnly Property SSUP_Permission() As BaseClasses.Data.StringColumn
        Get
            Return All_SysUserInfo_view1View.Instance.SSUP_PermissionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSR_RoleName column object.
    ''' </summary>
    Public ReadOnly Property SSR_RoleNameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSR_RoleName column object.
    ''' </summary>
    Public Shared ReadOnly Property SSR_RoleName() As BaseClasses.Data.StringColumn
        Get
            Return All_SysUserInfo_view1View.Instance.SSR_RoleNameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSUE_Email column object.
    ''' </summary>
    Public ReadOnly Property SSUE_EmailColumn() As BaseClasses.Data.EmailColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.EmailColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's All_SysUserInfo_view_.SSUE_Email column object.
    ''' </summary>
    Public Shared ReadOnly Property SSUE_Email() As BaseClasses.Data.EmailColumn
        Get
            Return All_SysUserInfo_view1View.Instance.SSUE_EmailColumn
        End Get
    End Property


#End Region

#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of All_SysUserInfo_view1Record records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As All_SysUserInfo_view1Record()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of All_SysUserInfo_view1Record records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As All_SysUserInfo_view1Record()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of All_SysUserInfo_view1Record records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As All_SysUserInfo_view1Record()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of All_SysUserInfo_view1Record records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As All_SysUserInfo_view1Record()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of All_SysUserInfo_view1Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As All_SysUserInfo_view1Record()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  All_SysUserInfo_view1View.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.All_SysUserInfo_view1Record)), All_SysUserInfo_view1Record())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of All_SysUserInfo_view1Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As All_SysUserInfo_view1Record()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  All_SysUserInfo_view1View.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.All_SysUserInfo_view1Record)), All_SysUserInfo_view1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As All_SysUserInfo_view1Record()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = All_SysUserInfo_view1View.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.All_SysUserInfo_view1Record)), All_SysUserInfo_view1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As All_SysUserInfo_view1Record()

        Dim recList As ArrayList = All_SysUserInfo_view1View.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.All_SysUserInfo_view1Record)), All_SysUserInfo_view1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As All_SysUserInfo_view1Record()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = All_SysUserInfo_view1View.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.All_SysUserInfo_view1Record)), All_SysUserInfo_view1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As All_SysUserInfo_view1Record()

        Dim recList As ArrayList = All_SysUserInfo_view1View.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.All_SysUserInfo_view1Record)), All_SysUserInfo_view1Record())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function PostGetRecordCount(ByVal selectCols As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal finalFilter As BaseFilter) As Integer
	      Return CInt(All_SysUserInfo_view1View.Instance.GetCountResponseForPost(All_SysUserInfo_view1View.Instance.TableDefinition, selectCols, join, finalFilter))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of All_SysUserInfo_view1Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function PostGetRecordList(ByVal requestedSelection As SqlBuilderColumnSelection, ByVal workingSelection As SqlBuilderColumnSelection, _
		ByVal distinctSelection As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal filter As BaseFilter, ByVal groupBy As GroupBy, _
	    ByVal sortOrder As OrderBy, ByVal startIndex As Integer, ByVal count As Integer, ByRef totalCount As Integer, ByVal fromDataSource As [Boolean], _
	    Optional ByVal table As KeylessVirtualTable = Nothing, Optional isGetColumnValues As Boolean = False) As ArrayList
	      
		Dim recList As ArrayList = Nothing
		If IsNothing(table) Then
			recList = All_SysUserInfo_view1View.Instance.GetRecordListResponseForPost(All_SysUserInfo_view1View.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection, join, filter, _
			groupBy, sortOrder, startIndex, count, totalCount, fromDataSource, isGetColumnValues)
		ElseIf Not IsNothing(table) Then
			recList = table.GetDataSourceResponseForPost(requestedSelection, workingSelection, distinctSelection, join, filter, _
			groupBy, sortOrder, startIndex, count, totalCount, fromDataSource)
		End If

		Return recList
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(All_SysUserInfo_view1View.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(All_SysUserInfo_view1View.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(All_SysUserInfo_view1View.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(All_SysUserInfo_view1View.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a All_SysUserInfo_view1Record record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As All_SysUserInfo_view1Record
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a All_SysUserInfo_view1Record record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As All_SysUserInfo_view1Record
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a All_SysUserInfo_view1Record record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As All_SysUserInfo_view1Record

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = All_SysUserInfo_view1View.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As All_SysUserInfo_view1Record = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), All_SysUserInfo_view1Record)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a All_SysUserInfo_view1Record record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As All_SysUserInfo_view1Record

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = All_SysUserInfo_view1View.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As All_SysUserInfo_view1Record = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), All_SysUserInfo_view1Record)
        End If

        Return rec
    End Function


    Public Shared Function GetValues( _
        ByVal col As BaseColumn, _
         ByVal where As WhereClause, _
         ByVal orderBy As OrderBy, _
         ByVal maxItems As Integer) As String()

        ' Create the filter list.
        Dim retCol As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, True)
        retCol.AddColumn(col)

        Return All_SysUserInfo_view1View.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function

    Public Shared Function GetValues( _
         ByVal col As BaseColumn, _
         ByVal join As BaseFilter, _
         ByVal where As WhereClause, _
         ByVal orderBy As OrderBy, _
         ByVal maxItems As Integer) As String()

        ' Create the filter list.
        Dim retCol As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, True)
        retCol.AddColumn(col)

        Return All_SysUserInfo_view1View.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As All_SysUserInfo_view1Record = GetRecords(where)
        Return All_SysUserInfo_view1View.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As All_SysUserInfo_view1Record = GetRecords(join, where)
        Return All_SysUserInfo_view1View.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As All_SysUserInfo_view1Record = GetRecords(where, orderBy)
        Return All_SysUserInfo_view1View.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As All_SysUserInfo_view1Record = GetRecords(join, where, orderBy)
        Return All_SysUserInfo_view1View.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As All_SysUserInfo_view1Record = GetRecords(where, orderBy, pageIndex, pageSize)
        Return All_SysUserInfo_view1View.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal join As BaseFilter, _    
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As All_SysUserInfo_view1Record = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return All_SysUserInfo_view1View.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        All_SysUserInfo_view1View.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return All_SysUserInfo_view1View.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return All_SysUserInfo_view1View.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function GetSum( _
        ByVal col As BaseColumn, _
        ByVal where As WhereClause, _
        ByVal orderBy As OrderBy, _
        ByVal pageIndex As Integer, _
        ByVal pageSize As Integer) _
        As String

        Dim colSel As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, False)
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Sum)

        Return All_SysUserInfo_view1View.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function

    Public Shared Function GetSum( _
        ByVal col As BaseColumn, _
        ByVal join As BaseFilter, _        
        ByVal where As WhereClause, _
        ByVal orderBy As OrderBy, _
        ByVal pageIndex As Integer, _
        ByVal pageSize As Integer) _
        As String

        Dim colSel As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, False)
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Sum)

        Return All_SysUserInfo_view1View.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function

    
    Public Shared Function GetCount( _
        ByVal col As BaseColumn, _
        ByVal where As WhereClause, _
        ByVal orderBy As OrderBy, _
        ByVal pageIndex As Integer, _
        ByVal pageSize As Integer) _
        As String

        Dim colSel As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, False)
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Count)

        Return All_SysUserInfo_view1View.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function
    
    Public Shared Function GetCount( _
        ByVal col As BaseColumn, _
        ByVal join As BaseFilter, _         
        ByVal where As WhereClause, _
        ByVal orderBy As OrderBy, _
        ByVal pageIndex As Integer, _
        ByVal pageSize As Integer) _
        As String

        Dim colSel As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, False)
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Count)

        Return All_SysUserInfo_view1View.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return All_SysUserInfo_view1View.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return All_SysUserInfo_view1View.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return All_SysUserInfo_view1View.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return All_SysUserInfo_view1View.Instance.CreateRecord(tempId)
    End Function

    ''' <summary>
    ''' This method checks if column is editable.
    ''' </summary>
    ''' <param name="columnName">Name of the column to check.</param>
    Public Shared Function isReadOnlyColumn(ByVal columnName As String) As Boolean
        Dim column As BaseColumn = GetColumn(columnName)
        If (Not IsNothing(column)) Then
            Return column.IsValuesReadOnly
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' This method gets the specified column.
    ''' </summary>
    ''' <param name="uniqueColumnName">Unique name of the column to fetch.</param>
    Public Shared Function GetColumn(ByVal uniqueColumnName As String) As BaseColumn
        Dim column As BaseColumn = All_SysUserInfo_view1View.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     


    ''' <summary>
    ''' This method gets the specified column.
    ''' </summary>
    ''' <param name="name">name of the column to fetch.</param>
    Public Shared Function GetColumnByName(ByVal name As String) As BaseColumn
        Dim column As BaseColumn = All_SysUserInfo_view1View.Instance.TableDefinition.ColumnList.GetByInternalName(name)
        Return column
    End Function       
        

	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = All_SysUserInfo_view1View.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
	    If fkColumn Is Nothing Then
 			Return Nothing
		End If
        Dim _DFKA As String = fkColumn.PrimaryKeyDisplayColumns
        If (_DFKA.Trim().StartsWith("=")) Then
            ' if the formula is in the format of "= <Primary table>.<Field name>, then pull out the data from the rec object instead of doing formula evaluation 
            Dim tableCodeName As String = fkColumn.PrimaryKeyTableDefinition.TableCodeName
            Dim column As String = _DFKA.Trim("="c).Trim()
            If column.StartsWith(tableCodeName & ".", StringComparison.InvariantCultureIgnoreCase) Then
                column = column.Substring(tableCodeName.Length + 1)
            End If

            For Each c As BaseColumn In fkColumn.PrimaryKeyTableDefinition.Columns
                If column = c.CodeName Then
                    Return rec.Format(c)
                End If
            Next        
			Dim tableName As String = fkColumn.PrimaryKeyTableDefinition.TableCodeName
			Return EvaluateFormula(_DFKA, rec, Nothing, tableName)
		Else
            Return Nothing
        End If
    End Function

	''' <summary>
    ''' This method takes a keyValue and a Column and returns an evaluated value of DFKA formula.
    ''' </summary>
	Public Shared Function GetDFKA(ByVal keyValue As String, ByVal col As BaseColumn, ByVal formatPattern as String) As String
	    If keyValue Is Nothing Then
 			Return Nothing
		End If
	    Dim fkColumn As ForeignKey = All_SysUserInfo_view1View.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
	    If fkColumn Is Nothing Then
 			Return Nothing
		End If
        Dim _DFKA As String = fkColumn.PrimaryKeyDisplayColumns
        If (_DFKA.Trim().StartsWith("=")) Then
			Dim tableName As String = fkColumn.PrimaryKeyTableDefinition.TableCodeName
			Dim t As PrimaryKeyTable = CType(DatabaseObjects.GetTableObject(tableName), PrimaryKeyTable)
			Dim rec As BaseRecord = Nothing
			If Not t Is Nothing Then
				Try
					rec = CType(t.GetRecordData(keyValue, False), BaseRecord)
				Catch 
					rec = Nothing
				End Try
			End If
			If rec Is Nothing Then
				Return ""
			End If
			
            ' if the formula is in the format of "= <Primary table>.<Field name>, then pull out the data from the rec object instead of doing formula evaluation 
            Dim tableCodeName As String = fkColumn.PrimaryKeyTableDefinition.TableCodeName
            Dim column As String = _DFKA.Trim("="c).Trim()
            If column.StartsWith(tableCodeName & ".", StringComparison.InvariantCultureIgnoreCase) Then
                column = column.Substring(tableCodeName.Length + 1)
            End If

            For Each c As BaseColumn In fkColumn.PrimaryKeyTableDefinition.Columns
                If column = c.CodeName Then
                    Return rec.Format(c)
                End If
            Next			
			Return EvaluateFormula(_DFKA, rec, Nothing, tableName)
		Else
            Return Nothing
        End If
    End Function
    
	''' <summary>
    ''' Evaluates the formula
    ''' </summary>
	Public Shared Function EvaluateFormula(ByVal formula As String, Optional ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord = Nothing, Optional ByVal format As String = Nothing, Optional ByVal name As String = "") As String
		Dim e As BaseFormulaEvaluator = New BaseFormulaEvaluator()
		If Not dataSourceForEvaluate Is Nothing Then
			e.Evaluator.Variables.Add(name, dataSourceForEvaluate)
        end if
        e.DataSource = dataSourceForEvaluate

        Dim resultObj As Object = e.Evaluate(formula)
        If resultObj Is Nothing Then
	        Return ""
        End If
        If Not String.IsNullOrEmpty(format) Then
            Return BaseFormulaUtils.Format(resultObj, format)
        Else
            Return resultObj.ToString()
        End If
    End Function
#End Region	

End Class
End Namespace
