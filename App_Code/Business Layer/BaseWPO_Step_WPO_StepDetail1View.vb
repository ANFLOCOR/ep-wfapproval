' This class is "generated" and will be overwritten.
' Your customizations should be made in WPO_Step_WPO_StepDetail1Record.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ePortalWFApproval.Data

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WPO_Step_WPO_StepDetail1View"></see> class.
''' Provides access to the schema information and record data of a database table or view named DatabaseANFLO-WFN%dbo.WPO_Step_WPO_StepDetail.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="WPO_Step_WPO_StepDetail1View.Instance">WPO_Step_WPO_StepDetail1View.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="WPO_Step_WPO_StepDetail1View"></seealso>

<Serializable()> Public Class BaseWPO_Step_WPO_StepDetail1View
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = WPO_Step_WPO_StepDetail1Definition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.WPO_Step_WPO_StepDetail1View")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.WPO_Step_WPO_StepDetail1Record")
        Me.ApplicationName = "App_Code"
        Me.DataAdapter = New WPO_Step_WPO_StepDetail1SqlView()
        Directcast(Me.DataAdapter, WPO_Step_WPO_StepDetail1SqlView).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, WPO_Step_WPO_StepDetail1SqlView).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        W_U_Full_NameColumn.CodeName = "W_U_Full_Name"
        WPO_S_IDColumn.CodeName = "WPO_S_ID"
        WPO_S_WDT_IDColumn.CodeName = "WPO_S_WDT_ID"
        WPO_S_ID_NextColumn.CodeName = "WPO_S_ID_Next"
        WPO_S_Step_TypeColumn.CodeName = "WPO_S_Step_Type"
        WPO_S_Approval_NeededColumn.CodeName = "WPO_S_Approval_Needed"
        WPO_SD_IDColumn.CodeName = "WPO_SD_ID"
        WPO_SD_W_U_IDColumn.CodeName = "WPO_SD_W_U_ID"
        SSU_FullNameColumn.CodeName = "SSU_FullName"
        WPO_SD_Is_FAPColumn.CodeName = "WPO_SD_Is_FAP"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.W_U_Full_Name column object.
    ''' </summary>
    Public ReadOnly Property W_U_Full_NameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.W_U_Full_Name column object.
    ''' </summary>
    Public Shared ReadOnly Property W_U_Full_Name() As BaseClasses.Data.StringColumn
        Get
            Return WPO_Step_WPO_StepDetail1View.Instance.W_U_Full_NameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.WPO_S_ID column object.
    ''' </summary>
    Public ReadOnly Property WPO_S_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.WPO_S_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WPO_S_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WPO_Step_WPO_StepDetail1View.Instance.WPO_S_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.WPO_S_WDT_ID column object.
    ''' </summary>
    Public ReadOnly Property WPO_S_WDT_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.WPO_S_WDT_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WPO_S_WDT_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WPO_Step_WPO_StepDetail1View.Instance.WPO_S_WDT_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.WPO_S_ID_Next column object.
    ''' </summary>
    Public ReadOnly Property WPO_S_ID_NextColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.WPO_S_ID_Next column object.
    ''' </summary>
    Public Shared ReadOnly Property WPO_S_ID_Next() As BaseClasses.Data.NumberColumn
        Get
            Return WPO_Step_WPO_StepDetail1View.Instance.WPO_S_ID_NextColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.WPO_S_Step_Type column object.
    ''' </summary>
    Public ReadOnly Property WPO_S_Step_TypeColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.WPO_S_Step_Type column object.
    ''' </summary>
    Public Shared ReadOnly Property WPO_S_Step_Type() As BaseClasses.Data.StringColumn
        Get
            Return WPO_Step_WPO_StepDetail1View.Instance.WPO_S_Step_TypeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.WPO_S_Approval_Needed column object.
    ''' </summary>
    Public ReadOnly Property WPO_S_Approval_NeededColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.WPO_S_Approval_Needed column object.
    ''' </summary>
    Public Shared ReadOnly Property WPO_S_Approval_Needed() As BaseClasses.Data.NumberColumn
        Get
            Return WPO_Step_WPO_StepDetail1View.Instance.WPO_S_Approval_NeededColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.WPO_SD_ID column object.
    ''' </summary>
    Public ReadOnly Property WPO_SD_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.WPO_SD_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WPO_SD_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WPO_Step_WPO_StepDetail1View.Instance.WPO_SD_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.WPO_SD_W_U_ID column object.
    ''' </summary>
    Public ReadOnly Property WPO_SD_W_U_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.WPO_SD_W_U_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WPO_SD_W_U_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WPO_Step_WPO_StepDetail1View.Instance.WPO_SD_W_U_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.SSU_FullName column object.
    ''' </summary>
    Public ReadOnly Property SSU_FullNameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.SSU_FullName column object.
    ''' </summary>
    Public Shared ReadOnly Property SSU_FullName() As BaseClasses.Data.StringColumn
        Get
            Return WPO_Step_WPO_StepDetail1View.Instance.SSU_FullNameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.WPO_SD_Is_FAP column object.
    ''' </summary>
    Public ReadOnly Property WPO_SD_Is_FAPColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPO_Step_WPO_StepDetail_.WPO_SD_Is_FAP column object.
    ''' </summary>
    Public Shared ReadOnly Property WPO_SD_Is_FAP() As BaseClasses.Data.BooleanColumn
        Get
            Return WPO_Step_WPO_StepDetail1View.Instance.WPO_SD_Is_FAPColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WPO_Step_WPO_StepDetail1Record records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As WPO_Step_WPO_StepDetail1Record()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of WPO_Step_WPO_StepDetail1Record records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As WPO_Step_WPO_StepDetail1Record()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WPO_Step_WPO_StepDetail1Record records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WPO_Step_WPO_StepDetail1Record()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WPO_Step_WPO_StepDetail1Record records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WPO_Step_WPO_StepDetail1Record()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of WPO_Step_WPO_StepDetail1Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WPO_Step_WPO_StepDetail1Record()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  WPO_Step_WPO_StepDetail1View.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WPO_Step_WPO_StepDetail1Record)), WPO_Step_WPO_StepDetail1Record())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WPO_Step_WPO_StepDetail1Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WPO_Step_WPO_StepDetail1Record()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  WPO_Step_WPO_StepDetail1View.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WPO_Step_WPO_StepDetail1Record)), WPO_Step_WPO_StepDetail1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WPO_Step_WPO_StepDetail1Record()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WPO_Step_WPO_StepDetail1View.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WPO_Step_WPO_StepDetail1Record)), WPO_Step_WPO_StepDetail1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WPO_Step_WPO_StepDetail1Record()

        Dim recList As ArrayList = WPO_Step_WPO_StepDetail1View.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WPO_Step_WPO_StepDetail1Record)), WPO_Step_WPO_StepDetail1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As WPO_Step_WPO_StepDetail1Record()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WPO_Step_WPO_StepDetail1View.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WPO_Step_WPO_StepDetail1Record)), WPO_Step_WPO_StepDetail1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As WPO_Step_WPO_StepDetail1Record()

        Dim recList As ArrayList = WPO_Step_WPO_StepDetail1View.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WPO_Step_WPO_StepDetail1Record)), WPO_Step_WPO_StepDetail1Record())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function PostGetRecordCount(ByVal selectCols As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal finalFilter As BaseFilter) As Integer
	      Return CInt(WPO_Step_WPO_StepDetail1View.Instance.GetCountResponseForPost(WPO_Step_WPO_StepDetail1View.Instance.TableDefinition, selectCols, join, finalFilter))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WPO_Step_WPO_StepDetail1Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function PostGetRecordList(ByVal requestedSelection As SqlBuilderColumnSelection, ByVal workingSelection As SqlBuilderColumnSelection, _
		ByVal distinctSelection As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal filter As BaseFilter, ByVal groupBy As GroupBy, _
	    ByVal sortOrder As OrderBy, ByVal startIndex As Integer, ByVal count As Integer, ByRef totalCount As Integer, ByVal fromDataSource As [Boolean], _
	    Optional ByVal table As KeylessVirtualTable = Nothing, Optional isGetColumnValues As Boolean = False) As ArrayList
	      
		Dim recList As ArrayList = Nothing
		If IsNothing(table) Then
			recList = WPO_Step_WPO_StepDetail1View.Instance.GetRecordListResponseForPost(WPO_Step_WPO_StepDetail1View.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection, join, filter, _
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

        Return CInt(WPO_Step_WPO_StepDetail1View.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(WPO_Step_WPO_StepDetail1View.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(WPO_Step_WPO_StepDetail1View.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(WPO_Step_WPO_StepDetail1View.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WPO_Step_WPO_StepDetail1Record record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As WPO_Step_WPO_StepDetail1Record
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WPO_Step_WPO_StepDetail1Record record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As WPO_Step_WPO_StepDetail1Record
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WPO_Step_WPO_StepDetail1Record record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WPO_Step_WPO_StepDetail1Record

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WPO_Step_WPO_StepDetail1View.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As WPO_Step_WPO_StepDetail1Record = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), WPO_Step_WPO_StepDetail1Record)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WPO_Step_WPO_StepDetail1Record record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WPO_Step_WPO_StepDetail1Record

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = WPO_Step_WPO_StepDetail1View.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As WPO_Step_WPO_StepDetail1Record = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), WPO_Step_WPO_StepDetail1Record)
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

        Return WPO_Step_WPO_StepDetail1View.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return WPO_Step_WPO_StepDetail1View.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As WPO_Step_WPO_StepDetail1Record = GetRecords(where)
        Return WPO_Step_WPO_StepDetail1View.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As WPO_Step_WPO_StepDetail1Record = GetRecords(join, where)
        Return WPO_Step_WPO_StepDetail1View.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As WPO_Step_WPO_StepDetail1Record = GetRecords(where, orderBy)
        Return WPO_Step_WPO_StepDetail1View.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As WPO_Step_WPO_StepDetail1Record = GetRecords(join, where, orderBy)
        Return WPO_Step_WPO_StepDetail1View.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As WPO_Step_WPO_StepDetail1Record = GetRecords(where, orderBy, pageIndex, pageSize)
        Return WPO_Step_WPO_StepDetail1View.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As WPO_Step_WPO_StepDetail1Record = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return WPO_Step_WPO_StepDetail1View.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        WPO_Step_WPO_StepDetail1View.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return WPO_Step_WPO_StepDetail1View.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return WPO_Step_WPO_StepDetail1View.Instance.ExportRecordData(whereFilter)
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

        Return WPO_Step_WPO_StepDetail1View.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WPO_Step_WPO_StepDetail1View.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WPO_Step_WPO_StepDetail1View.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WPO_Step_WPO_StepDetail1View.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return WPO_Step_WPO_StepDetail1View.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return WPO_Step_WPO_StepDetail1View.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return WPO_Step_WPO_StepDetail1View.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return WPO_Step_WPO_StepDetail1View.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = WPO_Step_WPO_StepDetail1View.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     


    ''' <summary>
    ''' This method gets the specified column.
    ''' </summary>
    ''' <param name="name">name of the column to fetch.</param>
    Public Shared Function GetColumnByName(ByVal name As String) As BaseColumn
        Dim column As BaseColumn = WPO_Step_WPO_StepDetail1View.Instance.TableDefinition.ColumnList.GetByInternalName(name)
        Return column
    End Function       
        

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As WPO_Step_WPO_StepDetail1Record
        Return CType(WPO_Step_WPO_StepDetail1View.Instance.GetRecordData(id, bMutable), WPO_Step_WPO_StepDetail1Record)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As WPO_Step_WPO_StepDetail1Record
        Return CType(WPO_Step_WPO_StepDetail1View.Instance.GetRecordData(id, bMutable), WPO_Step_WPO_StepDetail1Record)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal W_U_Full_NameValue As String, _
        ByVal WPO_S_IDValue As String, _
        ByVal WPO_S_WDT_IDValue As String, _
        ByVal WPO_S_ID_NextValue As String, _
        ByVal WPO_S_Step_TypeValue As String, _
        ByVal WPO_S_Approval_NeededValue As String, _
        ByVal WPO_SD_IDValue As String, _
        ByVal WPO_SD_W_U_IDValue As String, _
        ByVal SSU_FullNameValue As String, _
        ByVal WPO_SD_Is_FAPValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(W_U_Full_NameValue, W_U_Full_NameColumn)
        rec.SetString(WPO_S_IDValue, WPO_S_IDColumn)
        rec.SetString(WPO_S_WDT_IDValue, WPO_S_WDT_IDColumn)
        rec.SetString(WPO_S_ID_NextValue, WPO_S_ID_NextColumn)
        rec.SetString(WPO_S_Step_TypeValue, WPO_S_Step_TypeColumn)
        rec.SetString(WPO_S_Approval_NeededValue, WPO_S_Approval_NeededColumn)
        rec.SetString(WPO_SD_IDValue, WPO_SD_IDColumn)
        rec.SetString(WPO_SD_W_U_IDValue, WPO_SD_W_U_IDColumn)
        rec.SetString(SSU_FullNameValue, SSU_FullNameColumn)
        rec.SetString(WPO_SD_Is_FAPValue, WPO_SD_Is_FAPColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        WPO_Step_WPO_StepDetail1View.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            WPO_Step_WPO_StepDetail1View.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(WPO_Step_WPO_StepDetail1View.Instance.TableDefinition.PrimaryKey)) Then
            Return WPO_Step_WPO_StepDetail1View.Instance.TableDefinition.PrimaryKey.Columns
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' This method takes a key and returns a keyvalue.
    ''' </summary>
    ''' <param name="key">key could be array of primary key values in case of composite primary key or a string containing single primary key value in case of non-composite primary key.</param>
    Public Shared Function GetKeyValue(ByVal key As Object) As KeyValue
        Dim kv As KeyValue = Nothing

        If (Not (IsNothing(WPO_Step_WPO_StepDetail1View.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = WPO_Step_WPO_StepDetail1View.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = WPO_Step_WPO_StepDetail1View.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (WPO_Step_WPO_StepDetail1View.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = WPO_Step_WPO_StepDetail1View.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = WPO_Step_WPO_StepDetail1View.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = WPO_Step_WPO_StepDetail1View.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
