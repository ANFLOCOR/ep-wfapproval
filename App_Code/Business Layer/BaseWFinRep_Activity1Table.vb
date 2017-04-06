﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRep_Activity1Record.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ePortalWFApproval.Data

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WFinRep_Activity1Table"></see> class.
''' Provides access to the schema information and record data of a database table or view named DatabaseANFLO-WFN%dbo.WFinRep_Activity.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="WFinRep_Activity1Table.Instance">WFinRep_Activity1Table.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="WFinRep_Activity1Table"></seealso>

<Serializable()> Public Class BaseWFinRep_Activity1Table
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = WFinRep_Activity1Definition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.WFinRep_Activity1Table")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.WFinRep_Activity1Record")
        Me.ApplicationName = "App_Code"
        Me.DataAdapter = New WFinRep_Activity1SqlTable()
        Directcast(Me.DataAdapter, WFinRep_Activity1SqlTable).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, WFinRep_Activity1SqlTable).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        AFIN_IDColumn.CodeName = "AFIN_ID"
        AFIN_WS_IDColumn.CodeName = "AFIN_WS_ID"
        AFIN_WSD_IDColumn.CodeName = "AFIN_WSD_ID"
        AFIN_WDT_IDColumn.CodeName = "AFIN_WDT_ID"
        AFIN_W_U_IDColumn.CodeName = "AFIN_W_U_ID"
        AFIN_W_U_ID_DelegateColumn.CodeName = "AFIN_W_U_ID_Delegate"
        AFIN_StatusColumn.CodeName = "AFIN_Status"
        AFIN_Date_AssignColumn.CodeName = "AFIN_Date_Assign"
        AFIN_Date_ActionColumn.CodeName = "AFIN_Date_Action"
        AFIN_RemarkColumn.CodeName = "AFIN_Remark"
        AFIN_Is_DoneColumn.CodeName = "AFIN_Is_Done"
        AFIN_CodeColumn.CodeName = "AFIN_Code"
        AFIN_FinIDColumn.CodeName = "AFIN_FinID"
        AFIN_HFIN_IDColumn.CodeName = "AFIN_HFIN_ID"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_ID column object.
    ''' </summary>
    Public ReadOnly Property AFIN_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property AFIN_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRep_Activity1Table.Instance.AFIN_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_WS_ID column object.
    ''' </summary>
    Public ReadOnly Property AFIN_WS_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_WS_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property AFIN_WS_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRep_Activity1Table.Instance.AFIN_WS_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_WSD_ID column object.
    ''' </summary>
    Public ReadOnly Property AFIN_WSD_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_WSD_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property AFIN_WSD_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRep_Activity1Table.Instance.AFIN_WSD_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_WDT_ID column object.
    ''' </summary>
    Public ReadOnly Property AFIN_WDT_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_WDT_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property AFIN_WDT_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRep_Activity1Table.Instance.AFIN_WDT_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_W_U_ID column object.
    ''' </summary>
    Public ReadOnly Property AFIN_W_U_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_W_U_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property AFIN_W_U_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRep_Activity1Table.Instance.AFIN_W_U_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_W_U_ID_Delegate column object.
    ''' </summary>
    Public ReadOnly Property AFIN_W_U_ID_DelegateColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_W_U_ID_Delegate column object.
    ''' </summary>
    Public Shared ReadOnly Property AFIN_W_U_ID_Delegate() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRep_Activity1Table.Instance.AFIN_W_U_ID_DelegateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_Status column object.
    ''' </summary>
    Public ReadOnly Property AFIN_StatusColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_Status column object.
    ''' </summary>
    Public Shared ReadOnly Property AFIN_Status() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRep_Activity1Table.Instance.AFIN_StatusColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_Date_Assign column object.
    ''' </summary>
    Public ReadOnly Property AFIN_Date_AssignColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_Date_Assign column object.
    ''' </summary>
    Public Shared ReadOnly Property AFIN_Date_Assign() As BaseClasses.Data.DateColumn
        Get
            Return WFinRep_Activity1Table.Instance.AFIN_Date_AssignColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_Date_Action column object.
    ''' </summary>
    Public ReadOnly Property AFIN_Date_ActionColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_Date_Action column object.
    ''' </summary>
    Public Shared ReadOnly Property AFIN_Date_Action() As BaseClasses.Data.DateColumn
        Get
            Return WFinRep_Activity1Table.Instance.AFIN_Date_ActionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_Remark column object.
    ''' </summary>
    Public ReadOnly Property AFIN_RemarkColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_Remark column object.
    ''' </summary>
    Public Shared ReadOnly Property AFIN_Remark() As BaseClasses.Data.StringColumn
        Get
            Return WFinRep_Activity1Table.Instance.AFIN_RemarkColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_Is_Done column object.
    ''' </summary>
    Public ReadOnly Property AFIN_Is_DoneColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_Is_Done column object.
    ''' </summary>
    Public Shared ReadOnly Property AFIN_Is_Done() As BaseClasses.Data.BooleanColumn
        Get
            Return WFinRep_Activity1Table.Instance.AFIN_Is_DoneColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_Code column object.
    ''' </summary>
    Public ReadOnly Property AFIN_CodeColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_Code column object.
    ''' </summary>
    Public Shared ReadOnly Property AFIN_Code() As BaseClasses.Data.StringColumn
        Get
            Return WFinRep_Activity1Table.Instance.AFIN_CodeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_FinID column object.
    ''' </summary>
    Public ReadOnly Property AFIN_FinIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_FinID column object.
    ''' </summary>
    Public Shared ReadOnly Property AFIN_FinID() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRep_Activity1Table.Instance.AFIN_FinIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_HFIN_ID column object.
    ''' </summary>
    Public ReadOnly Property AFIN_HFIN_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRep_Activity_.AFIN_HFIN_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property AFIN_HFIN_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRep_Activity1Table.Instance.AFIN_HFIN_IDColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRep_Activity1Record records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As WFinRep_Activity1Record()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRep_Activity1Record records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As WFinRep_Activity1Record()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRep_Activity1Record records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WFinRep_Activity1Record()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRep_Activity1Record records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WFinRep_Activity1Record()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRep_Activity1Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WFinRep_Activity1Record()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  WFinRep_Activity1Table.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WFinRep_Activity1Record)), WFinRep_Activity1Record())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRep_Activity1Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WFinRep_Activity1Record()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  WFinRep_Activity1Table.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WFinRep_Activity1Record)), WFinRep_Activity1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WFinRep_Activity1Record()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WFinRep_Activity1Table.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WFinRep_Activity1Record)), WFinRep_Activity1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WFinRep_Activity1Record()

        Dim recList As ArrayList = WFinRep_Activity1Table.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WFinRep_Activity1Record)), WFinRep_Activity1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As WFinRep_Activity1Record()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WFinRep_Activity1Table.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WFinRep_Activity1Record)), WFinRep_Activity1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As WFinRep_Activity1Record()

        Dim recList As ArrayList = WFinRep_Activity1Table.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WFinRep_Activity1Record)), WFinRep_Activity1Record())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function PostGetRecordCount(ByVal selectCols As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal finalFilter As BaseFilter) As Integer
	      Return CInt(WFinRep_Activity1Table.Instance.GetCountResponseForPost(WFinRep_Activity1Table.Instance.TableDefinition, selectCols, join, finalFilter))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRep_Activity1Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function PostGetRecordList(ByVal requestedSelection As SqlBuilderColumnSelection, ByVal workingSelection As SqlBuilderColumnSelection, _
		ByVal distinctSelection As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal filter As BaseFilter, ByVal groupBy As GroupBy, _
	    ByVal sortOrder As OrderBy, ByVal startIndex As Integer, ByVal count As Integer, ByRef totalCount As Integer, ByVal fromDataSource As [Boolean], _
	    Optional ByVal table As KeylessVirtualTable = Nothing, Optional isGetColumnValues As Boolean = False) As ArrayList
	      
		Dim recList As ArrayList = Nothing
		If IsNothing(table) Then
			recList = WFinRep_Activity1Table.Instance.GetRecordListResponseForPost(WFinRep_Activity1Table.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection, join, filter, _
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

        Return CInt(WFinRep_Activity1Table.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(WFinRep_Activity1Table.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(WFinRep_Activity1Table.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(WFinRep_Activity1Table.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WFinRep_Activity1Record record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As WFinRep_Activity1Record
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WFinRep_Activity1Record record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As WFinRep_Activity1Record
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WFinRep_Activity1Record record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WFinRep_Activity1Record

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WFinRep_Activity1Table.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As WFinRep_Activity1Record = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), WFinRep_Activity1Record)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WFinRep_Activity1Record record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WFinRep_Activity1Record

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = WFinRep_Activity1Table.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As WFinRep_Activity1Record = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), WFinRep_Activity1Record)
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

        Return WFinRep_Activity1Table.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return WFinRep_Activity1Table.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As WFinRep_Activity1Record = GetRecords(where)
        Return WFinRep_Activity1Table.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As WFinRep_Activity1Record = GetRecords(join, where)
        Return WFinRep_Activity1Table.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As WFinRep_Activity1Record = GetRecords(where, orderBy)
        Return WFinRep_Activity1Table.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As WFinRep_Activity1Record = GetRecords(join, where, orderBy)
        Return WFinRep_Activity1Table.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As WFinRep_Activity1Record = GetRecords(where, orderBy, pageIndex, pageSize)
        Return WFinRep_Activity1Table.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As WFinRep_Activity1Record = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return WFinRep_Activity1Table.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        WFinRep_Activity1Table.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return WFinRep_Activity1Table.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return WFinRep_Activity1Table.Instance.ExportRecordData(whereFilter)
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

        Return WFinRep_Activity1Table.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WFinRep_Activity1Table.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WFinRep_Activity1Table.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WFinRep_Activity1Table.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return WFinRep_Activity1Table.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return WFinRep_Activity1Table.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return WFinRep_Activity1Table.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return WFinRep_Activity1Table.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = WFinRep_Activity1Table.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     


    ''' <summary>
    ''' This method gets the specified column.
    ''' </summary>
    ''' <param name="name">name of the column to fetch.</param>
    Public Shared Function GetColumnByName(ByVal name As String) As BaseColumn
        Dim column As BaseColumn = WFinRep_Activity1Table.Instance.TableDefinition.ColumnList.GetByInternalName(name)
        Return column
    End Function       
        

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As WFinRep_Activity1Record
        Return CType(WFinRep_Activity1Table.Instance.GetRecordData(id, bMutable), WFinRep_Activity1Record)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As WFinRep_Activity1Record
        Return CType(WFinRep_Activity1Table.Instance.GetRecordData(id, bMutable), WFinRep_Activity1Record)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal AFIN_WS_IDValue As String, _
        ByVal AFIN_WSD_IDValue As String, _
        ByVal AFIN_WDT_IDValue As String, _
        ByVal AFIN_W_U_IDValue As String, _
        ByVal AFIN_W_U_ID_DelegateValue As String, _
        ByVal AFIN_StatusValue As String, _
        ByVal AFIN_Date_AssignValue As String, _
        ByVal AFIN_Date_ActionValue As String, _
        ByVal AFIN_RemarkValue As String, _
        ByVal AFIN_Is_DoneValue As String, _
        ByVal AFIN_CodeValue As String, _
        ByVal AFIN_FinIDValue As String, _
        ByVal AFIN_HFIN_IDValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(AFIN_WS_IDValue, AFIN_WS_IDColumn)
        rec.SetString(AFIN_WSD_IDValue, AFIN_WSD_IDColumn)
        rec.SetString(AFIN_WDT_IDValue, AFIN_WDT_IDColumn)
        rec.SetString(AFIN_W_U_IDValue, AFIN_W_U_IDColumn)
        rec.SetString(AFIN_W_U_ID_DelegateValue, AFIN_W_U_ID_DelegateColumn)
        rec.SetString(AFIN_StatusValue, AFIN_StatusColumn)
        rec.SetString(AFIN_Date_AssignValue, AFIN_Date_AssignColumn)
        rec.SetString(AFIN_Date_ActionValue, AFIN_Date_ActionColumn)
        rec.SetString(AFIN_RemarkValue, AFIN_RemarkColumn)
        rec.SetString(AFIN_Is_DoneValue, AFIN_Is_DoneColumn)
        rec.SetString(AFIN_CodeValue, AFIN_CodeColumn)
        rec.SetString(AFIN_FinIDValue, AFIN_FinIDColumn)
        rec.SetString(AFIN_HFIN_IDValue, AFIN_HFIN_IDColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        WFinRep_Activity1Table.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            WFinRep_Activity1Table.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(WFinRep_Activity1Table.Instance.TableDefinition.PrimaryKey)) Then
            Return WFinRep_Activity1Table.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(WFinRep_Activity1Table.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = WFinRep_Activity1Table.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = WFinRep_Activity1Table.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (WFinRep_Activity1Table.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = WFinRep_Activity1Table.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = WFinRep_Activity1Table.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = WFinRep_Activity1Table.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
