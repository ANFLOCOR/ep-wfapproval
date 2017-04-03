' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRepNGP_ActivityRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ePortalWFApproval.Data

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WFinRepNGP_ActivityTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named DatabaseANFLO-WF%dbo.WFinRepNGP_Activity.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="WFinRepNGP_ActivityTable.Instance">WFinRepNGP_ActivityTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="WFinRepNGP_ActivityTable"></seealso>

<Serializable()> Public Class BaseWFinRepNGP_ActivityTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = WFinRepNGP_ActivityDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.WFinRepNGP_ActivityTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.WFinRepNGP_ActivityRecord")
        Me.ApplicationName = "App_Code"
        Me.DataAdapter = New WFinRepNGP_ActivitySqlTable()
        Directcast(Me.DataAdapter, WFinRepNGP_ActivitySqlTable).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, WFinRepNGP_ActivitySqlTable).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        WFRNGPA_IDColumn.CodeName = "WFRNGPA_ID"
        WFRNGPA_WS_IDColumn.CodeName = "WFRNGPA_WS_ID"
        WFRNGPA_WSD_IDColumn.CodeName = "WFRNGPA_WSD_ID"
        WFRNGPA_WDT_IDColumn.CodeName = "WFRNGPA_WDT_ID"
        WFRNGPA_W_U_IDColumn.CodeName = "WFRNGPA_W_U_ID"
        WFRNGPA_W_U_ID_DelegateColumn.CodeName = "WFRNGPA_W_U_ID_Delegate"
        WFRNGPA_StatusColumn.CodeName = "WFRNGPA_Status"
        WFRNGPA_Date_AssignColumn.CodeName = "WFRNGPA_Date_Assign"
        WFRNGPA_Date_ActionColumn.CodeName = "WFRNGPA_Date_Action"
        WFRNGPA_RemarkColumn.CodeName = "WFRNGPA_Remark"
        WFRNGPA_Is_DoneColumn.CodeName = "WFRNGPA_Is_Done"
        WFRNGPA_CodeColumn.CodeName = "WFRNGPA_Code"
        WFRNGPA_FinIDColumn.CodeName = "WFRNGPA_FinID"
        WFRNGPA_WFRCHNGP_IDColumn.CodeName = "WFRNGPA_WFRCHNGP_ID"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_ID column object.
    ''' </summary>
    Public ReadOnly Property WFRNGPA_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRNGPA_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRepNGP_ActivityTable.Instance.WFRNGPA_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_WS_ID column object.
    ''' </summary>
    Public ReadOnly Property WFRNGPA_WS_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_WS_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRNGPA_WS_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRepNGP_ActivityTable.Instance.WFRNGPA_WS_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_WSD_ID column object.
    ''' </summary>
    Public ReadOnly Property WFRNGPA_WSD_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_WSD_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRNGPA_WSD_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRepNGP_ActivityTable.Instance.WFRNGPA_WSD_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_WDT_ID column object.
    ''' </summary>
    Public ReadOnly Property WFRNGPA_WDT_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_WDT_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRNGPA_WDT_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRepNGP_ActivityTable.Instance.WFRNGPA_WDT_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_W_U_ID column object.
    ''' </summary>
    Public ReadOnly Property WFRNGPA_W_U_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_W_U_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRNGPA_W_U_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRepNGP_ActivityTable.Instance.WFRNGPA_W_U_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_W_U_ID_Delegate column object.
    ''' </summary>
    Public ReadOnly Property WFRNGPA_W_U_ID_DelegateColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_W_U_ID_Delegate column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRNGPA_W_U_ID_Delegate() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRepNGP_ActivityTable.Instance.WFRNGPA_W_U_ID_DelegateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_Status column object.
    ''' </summary>
    Public ReadOnly Property WFRNGPA_StatusColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_Status column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRNGPA_Status() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRepNGP_ActivityTable.Instance.WFRNGPA_StatusColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_Date_Assign column object.
    ''' </summary>
    Public ReadOnly Property WFRNGPA_Date_AssignColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_Date_Assign column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRNGPA_Date_Assign() As BaseClasses.Data.DateColumn
        Get
            Return WFinRepNGP_ActivityTable.Instance.WFRNGPA_Date_AssignColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_Date_Action column object.
    ''' </summary>
    Public ReadOnly Property WFRNGPA_Date_ActionColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_Date_Action column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRNGPA_Date_Action() As BaseClasses.Data.DateColumn
        Get
            Return WFinRepNGP_ActivityTable.Instance.WFRNGPA_Date_ActionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_Remark column object.
    ''' </summary>
    Public ReadOnly Property WFRNGPA_RemarkColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_Remark column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRNGPA_Remark() As BaseClasses.Data.StringColumn
        Get
            Return WFinRepNGP_ActivityTable.Instance.WFRNGPA_RemarkColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_Is_Done column object.
    ''' </summary>
    Public ReadOnly Property WFRNGPA_Is_DoneColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_Is_Done column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRNGPA_Is_Done() As BaseClasses.Data.BooleanColumn
        Get
            Return WFinRepNGP_ActivityTable.Instance.WFRNGPA_Is_DoneColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_Code column object.
    ''' </summary>
    Public ReadOnly Property WFRNGPA_CodeColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_Code column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRNGPA_Code() As BaseClasses.Data.StringColumn
        Get
            Return WFinRepNGP_ActivityTable.Instance.WFRNGPA_CodeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_FinID column object.
    ''' </summary>
    Public ReadOnly Property WFRNGPA_FinIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_FinID column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRNGPA_FinID() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRepNGP_ActivityTable.Instance.WFRNGPA_FinIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_WFRCHNGP_ID column object.
    ''' </summary>
    Public ReadOnly Property WFRNGPA_WFRCHNGP_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Activity_.WFRNGPA_WFRCHNGP_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRNGPA_WFRCHNGP_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRepNGP_ActivityTable.Instance.WFRNGPA_WFRCHNGP_IDColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRepNGP_ActivityRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As WFinRepNGP_ActivityRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRepNGP_ActivityRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As WFinRepNGP_ActivityRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRepNGP_ActivityRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WFinRepNGP_ActivityRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRepNGP_ActivityRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WFinRepNGP_ActivityRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRepNGP_ActivityRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WFinRepNGP_ActivityRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  WFinRepNGP_ActivityTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WFinRepNGP_ActivityRecord)), WFinRepNGP_ActivityRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRepNGP_ActivityRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WFinRepNGP_ActivityRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  WFinRepNGP_ActivityTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WFinRepNGP_ActivityRecord)), WFinRepNGP_ActivityRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WFinRepNGP_ActivityRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WFinRepNGP_ActivityTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WFinRepNGP_ActivityRecord)), WFinRepNGP_ActivityRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WFinRepNGP_ActivityRecord()

        Dim recList As ArrayList = WFinRepNGP_ActivityTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WFinRepNGP_ActivityRecord)), WFinRepNGP_ActivityRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As WFinRepNGP_ActivityRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WFinRepNGP_ActivityTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WFinRepNGP_ActivityRecord)), WFinRepNGP_ActivityRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As WFinRepNGP_ActivityRecord()

        Dim recList As ArrayList = WFinRepNGP_ActivityTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WFinRepNGP_ActivityRecord)), WFinRepNGP_ActivityRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function PostGetRecordCount(ByVal selectCols As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal finalFilter As BaseFilter) As Integer
	      Return CInt(WFinRepNGP_ActivityTable.Instance.GetCountResponseForPost(WFinRepNGP_ActivityTable.Instance.TableDefinition, selectCols, join, finalFilter))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRepNGP_ActivityRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function PostGetRecordList(ByVal requestedSelection As SqlBuilderColumnSelection, ByVal workingSelection As SqlBuilderColumnSelection, _
		ByVal distinctSelection As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal filter As BaseFilter, ByVal groupBy As GroupBy, _
	    ByVal sortOrder As OrderBy, ByVal startIndex As Integer, ByVal count As Integer, ByRef totalCount As Integer, ByVal fromDataSource As [Boolean], _
	    Optional ByVal table As KeylessVirtualTable = Nothing, Optional isGetColumnValues As Boolean = False) As ArrayList
	      
		Dim recList As ArrayList = Nothing
		If IsNothing(table) Then
			recList = WFinRepNGP_ActivityTable.Instance.GetRecordListResponseForPost(WFinRepNGP_ActivityTable.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection, join, filter, _
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

        Return CInt(WFinRepNGP_ActivityTable.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(WFinRepNGP_ActivityTable.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(WFinRepNGP_ActivityTable.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(WFinRepNGP_ActivityTable.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WFinRepNGP_ActivityRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As WFinRepNGP_ActivityRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WFinRepNGP_ActivityRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As WFinRepNGP_ActivityRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WFinRepNGP_ActivityRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WFinRepNGP_ActivityRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WFinRepNGP_ActivityTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As WFinRepNGP_ActivityRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), WFinRepNGP_ActivityRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WFinRepNGP_ActivityRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WFinRepNGP_ActivityRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = WFinRepNGP_ActivityTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As WFinRepNGP_ActivityRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), WFinRepNGP_ActivityRecord)
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

        Return WFinRepNGP_ActivityTable.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return WFinRepNGP_ActivityTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As WFinRepNGP_ActivityRecord = GetRecords(where)
        Return WFinRepNGP_ActivityTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As WFinRepNGP_ActivityRecord = GetRecords(join, where)
        Return WFinRepNGP_ActivityTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As WFinRepNGP_ActivityRecord = GetRecords(where, orderBy)
        Return WFinRepNGP_ActivityTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As WFinRepNGP_ActivityRecord = GetRecords(join, where, orderBy)
        Return WFinRepNGP_ActivityTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As WFinRepNGP_ActivityRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return WFinRepNGP_ActivityTable.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As WFinRepNGP_ActivityRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return WFinRepNGP_ActivityTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        WFinRepNGP_ActivityTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return WFinRepNGP_ActivityTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return WFinRepNGP_ActivityTable.Instance.ExportRecordData(whereFilter)
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

        Return WFinRepNGP_ActivityTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WFinRepNGP_ActivityTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WFinRepNGP_ActivityTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WFinRepNGP_ActivityTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return WFinRepNGP_ActivityTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return WFinRepNGP_ActivityTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return WFinRepNGP_ActivityTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return WFinRepNGP_ActivityTable.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = WFinRepNGP_ActivityTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     


    ''' <summary>
    ''' This method gets the specified column.
    ''' </summary>
    ''' <param name="name">name of the column to fetch.</param>
    Public Shared Function GetColumnByName(ByVal name As String) As BaseColumn
        Dim column As BaseColumn = WFinRepNGP_ActivityTable.Instance.TableDefinition.ColumnList.GetByInternalName(name)
        Return column
    End Function       
        

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As WFinRepNGP_ActivityRecord
        Return CType(WFinRepNGP_ActivityTable.Instance.GetRecordData(id, bMutable), WFinRepNGP_ActivityRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As WFinRepNGP_ActivityRecord
        Return CType(WFinRepNGP_ActivityTable.Instance.GetRecordData(id, bMutable), WFinRepNGP_ActivityRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal WFRNGPA_WS_IDValue As String, _
        ByVal WFRNGPA_WSD_IDValue As String, _
        ByVal WFRNGPA_WDT_IDValue As String, _
        ByVal WFRNGPA_W_U_IDValue As String, _
        ByVal WFRNGPA_W_U_ID_DelegateValue As String, _
        ByVal WFRNGPA_StatusValue As String, _
        ByVal WFRNGPA_Date_AssignValue As String, _
        ByVal WFRNGPA_Date_ActionValue As String, _
        ByVal WFRNGPA_RemarkValue As String, _
        ByVal WFRNGPA_Is_DoneValue As String, _
        ByVal WFRNGPA_CodeValue As String, _
        ByVal WFRNGPA_FinIDValue As String, _
        ByVal WFRNGPA_WFRCHNGP_IDValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(WFRNGPA_WS_IDValue, WFRNGPA_WS_IDColumn)
        rec.SetString(WFRNGPA_WSD_IDValue, WFRNGPA_WSD_IDColumn)
        rec.SetString(WFRNGPA_WDT_IDValue, WFRNGPA_WDT_IDColumn)
        rec.SetString(WFRNGPA_W_U_IDValue, WFRNGPA_W_U_IDColumn)
        rec.SetString(WFRNGPA_W_U_ID_DelegateValue, WFRNGPA_W_U_ID_DelegateColumn)
        rec.SetString(WFRNGPA_StatusValue, WFRNGPA_StatusColumn)
        rec.SetString(WFRNGPA_Date_AssignValue, WFRNGPA_Date_AssignColumn)
        rec.SetString(WFRNGPA_Date_ActionValue, WFRNGPA_Date_ActionColumn)
        rec.SetString(WFRNGPA_RemarkValue, WFRNGPA_RemarkColumn)
        rec.SetString(WFRNGPA_Is_DoneValue, WFRNGPA_Is_DoneColumn)
        rec.SetString(WFRNGPA_CodeValue, WFRNGPA_CodeColumn)
        rec.SetString(WFRNGPA_FinIDValue, WFRNGPA_FinIDColumn)
        rec.SetString(WFRNGPA_WFRCHNGP_IDValue, WFRNGPA_WFRCHNGP_IDColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        WFinRepNGP_ActivityTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            WFinRepNGP_ActivityTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(WFinRepNGP_ActivityTable.Instance.TableDefinition.PrimaryKey)) Then
            Return WFinRepNGP_ActivityTable.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(WFinRepNGP_ActivityTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = WFinRepNGP_ActivityTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = WFinRepNGP_ActivityTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (WFinRepNGP_ActivityTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = WFinRepNGP_ActivityTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = WFinRepNGP_ActivityTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = WFinRepNGP_ActivityTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
