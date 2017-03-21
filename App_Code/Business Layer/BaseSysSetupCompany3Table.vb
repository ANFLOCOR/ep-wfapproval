' This class is "generated" and will be overwritten.
' Your customizations should be made in SysSetupCompany3Record.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ePortalWFApproval.Data

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="SysSetupCompany3Table"></see> class.
''' Provides access to the schema information and record data of a database table or view named DatabaseWASSN%dbo.SysSetupCompany.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="SysSetupCompany3Table.Instance">SysSetupCompany3Table.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="SysSetupCompany3Table"></seealso>

<Serializable()> Public Class BaseSysSetupCompany3Table
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = SysSetupCompany3Definition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.SysSetupCompany3Table")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.SysSetupCompany3Record")
        Me.ApplicationName = "App_Code"
        Me.DataAdapter = New SysSetupCompany3SqlTable()
        Directcast(Me.DataAdapter, SysSetupCompany3SqlTable).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, SysSetupCompany3SqlTable).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        SSC_CompanyIDColumn.CodeName = "SSC_CompanyID"
        SSC_CompanyNameColumn.CodeName = "SSC_CompanyName"
        SSC_DescriptionColumn.CodeName = "SSC_Description"
        SSC_CheckedColumn.CodeName = "SSC_Checked"
        SSC_DateCreatedColumn.CodeName = "SSC_DateCreated"
        SSC_DateModifiedColumn.CodeName = "SSC_DateModified"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's SysSetupCompany_.SSC_CompanyID column object.
    ''' </summary>
    Public ReadOnly Property SSC_CompanyIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's SysSetupCompany_.SSC_CompanyID column object.
    ''' </summary>
    Public Shared ReadOnly Property SSC_CompanyID() As BaseClasses.Data.NumberColumn
        Get
            Return SysSetupCompany3Table.Instance.SSC_CompanyIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's SysSetupCompany_.SSC_CompanyName column object.
    ''' </summary>
    Public ReadOnly Property SSC_CompanyNameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's SysSetupCompany_.SSC_CompanyName column object.
    ''' </summary>
    Public Shared ReadOnly Property SSC_CompanyName() As BaseClasses.Data.StringColumn
        Get
            Return SysSetupCompany3Table.Instance.SSC_CompanyNameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's SysSetupCompany_.SSC_Description column object.
    ''' </summary>
    Public ReadOnly Property SSC_DescriptionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's SysSetupCompany_.SSC_Description column object.
    ''' </summary>
    Public Shared ReadOnly Property SSC_Description() As BaseClasses.Data.StringColumn
        Get
            Return SysSetupCompany3Table.Instance.SSC_DescriptionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's SysSetupCompany_.SSC_Checked column object.
    ''' </summary>
    Public ReadOnly Property SSC_CheckedColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's SysSetupCompany_.SSC_Checked column object.
    ''' </summary>
    Public Shared ReadOnly Property SSC_Checked() As BaseClasses.Data.BooleanColumn
        Get
            Return SysSetupCompany3Table.Instance.SSC_CheckedColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's SysSetupCompany_.SSC_DateCreated column object.
    ''' </summary>
    Public ReadOnly Property SSC_DateCreatedColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's SysSetupCompany_.SSC_DateCreated column object.
    ''' </summary>
    Public Shared ReadOnly Property SSC_DateCreated() As BaseClasses.Data.DateColumn
        Get
            Return SysSetupCompany3Table.Instance.SSC_DateCreatedColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's SysSetupCompany_.SSC_DateModified column object.
    ''' </summary>
    Public ReadOnly Property SSC_DateModifiedColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's SysSetupCompany_.SSC_DateModified column object.
    ''' </summary>
    Public Shared ReadOnly Property SSC_DateModified() As BaseClasses.Data.DateColumn
        Get
            Return SysSetupCompany3Table.Instance.SSC_DateModifiedColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of SysSetupCompany3Record records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As SysSetupCompany3Record()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of SysSetupCompany3Record records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As SysSetupCompany3Record()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of SysSetupCompany3Record records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As SysSetupCompany3Record()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of SysSetupCompany3Record records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As SysSetupCompany3Record()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of SysSetupCompany3Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As SysSetupCompany3Record()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  SysSetupCompany3Table.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.SysSetupCompany3Record)), SysSetupCompany3Record())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of SysSetupCompany3Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As SysSetupCompany3Record()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  SysSetupCompany3Table.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.SysSetupCompany3Record)), SysSetupCompany3Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As SysSetupCompany3Record()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = SysSetupCompany3Table.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.SysSetupCompany3Record)), SysSetupCompany3Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As SysSetupCompany3Record()

        Dim recList As ArrayList = SysSetupCompany3Table.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.SysSetupCompany3Record)), SysSetupCompany3Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As SysSetupCompany3Record()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = SysSetupCompany3Table.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.SysSetupCompany3Record)), SysSetupCompany3Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As SysSetupCompany3Record()

        Dim recList As ArrayList = SysSetupCompany3Table.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.SysSetupCompany3Record)), SysSetupCompany3Record())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function PostGetRecordCount(ByVal selectCols As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal finalFilter As BaseFilter) As Integer
	      Return CInt(SysSetupCompany3Table.Instance.GetCountResponseForPost(SysSetupCompany3Table.Instance.TableDefinition, selectCols, join, finalFilter))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of SysSetupCompany3Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function PostGetRecordList(ByVal requestedSelection As SqlBuilderColumnSelection, ByVal workingSelection As SqlBuilderColumnSelection, _
		ByVal distinctSelection As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal filter As BaseFilter, ByVal groupBy As GroupBy, _
	    ByVal sortOrder As OrderBy, ByVal startIndex As Integer, ByVal count As Integer, ByRef totalCount As Integer, ByVal fromDataSource As [Boolean], _
	    Optional ByVal table As KeylessVirtualTable = Nothing, Optional isGetColumnValues As Boolean = False) As ArrayList
	      
		Dim recList As ArrayList = Nothing
		If IsNothing(table) Then
			recList = SysSetupCompany3Table.Instance.GetRecordListResponseForPost(SysSetupCompany3Table.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection, join, filter, _
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

        Return CInt(SysSetupCompany3Table.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(SysSetupCompany3Table.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(SysSetupCompany3Table.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(SysSetupCompany3Table.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a SysSetupCompany3Record record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As SysSetupCompany3Record
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a SysSetupCompany3Record record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As SysSetupCompany3Record
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a SysSetupCompany3Record record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As SysSetupCompany3Record

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = SysSetupCompany3Table.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As SysSetupCompany3Record = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), SysSetupCompany3Record)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a SysSetupCompany3Record record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As SysSetupCompany3Record

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = SysSetupCompany3Table.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As SysSetupCompany3Record = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), SysSetupCompany3Record)
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

        Return SysSetupCompany3Table.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return SysSetupCompany3Table.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As SysSetupCompany3Record = GetRecords(where)
        Return SysSetupCompany3Table.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As SysSetupCompany3Record = GetRecords(join, where)
        Return SysSetupCompany3Table.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As SysSetupCompany3Record = GetRecords(where, orderBy)
        Return SysSetupCompany3Table.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As SysSetupCompany3Record = GetRecords(join, where, orderBy)
        Return SysSetupCompany3Table.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As SysSetupCompany3Record = GetRecords(where, orderBy, pageIndex, pageSize)
        Return SysSetupCompany3Table.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As SysSetupCompany3Record = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return SysSetupCompany3Table.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        SysSetupCompany3Table.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return SysSetupCompany3Table.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return SysSetupCompany3Table.Instance.ExportRecordData(whereFilter)
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

        Return SysSetupCompany3Table.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return SysSetupCompany3Table.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return SysSetupCompany3Table.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return SysSetupCompany3Table.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return SysSetupCompany3Table.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return SysSetupCompany3Table.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return SysSetupCompany3Table.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return SysSetupCompany3Table.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = SysSetupCompany3Table.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     


    ''' <summary>
    ''' This method gets the specified column.
    ''' </summary>
    ''' <param name="name">name of the column to fetch.</param>
    Public Shared Function GetColumnByName(ByVal name As String) As BaseColumn
        Dim column As BaseColumn = SysSetupCompany3Table.Instance.TableDefinition.ColumnList.GetByInternalName(name)
        Return column
    End Function       
        

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As SysSetupCompany3Record
        Return CType(SysSetupCompany3Table.Instance.GetRecordData(id, bMutable), SysSetupCompany3Record)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As SysSetupCompany3Record
        Return CType(SysSetupCompany3Table.Instance.GetRecordData(id, bMutable), SysSetupCompany3Record)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal SSC_CompanyNameValue As String, _
        ByVal SSC_DescriptionValue As String, _
        ByVal SSC_CheckedValue As String, _
        ByVal SSC_DateCreatedValue As String, _
        ByVal SSC_DateModifiedValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(SSC_CompanyNameValue, SSC_CompanyNameColumn)
        rec.SetString(SSC_DescriptionValue, SSC_DescriptionColumn)
        rec.SetString(SSC_CheckedValue, SSC_CheckedColumn)
        rec.SetString(SSC_DateCreatedValue, SSC_DateCreatedColumn)
        rec.SetString(SSC_DateModifiedValue, SSC_DateModifiedColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        SysSetupCompany3Table.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            SysSetupCompany3Table.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(SysSetupCompany3Table.Instance.TableDefinition.PrimaryKey)) Then
            Return SysSetupCompany3Table.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(SysSetupCompany3Table.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = SysSetupCompany3Table.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = SysSetupCompany3Table.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (SysSetupCompany3Table.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = SysSetupCompany3Table.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = SysSetupCompany3Table.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = SysSetupCompany3Table.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
