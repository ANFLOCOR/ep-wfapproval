' This class is "generated" and will be overwritten.
' Your customizations should be made in Vw_WFinRep_DocAttach_ReportTypeView.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ePortalWFApproval.Data

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Vw_WFinRep_DocAttach_ReportTypeView"></see> class.
''' Provides access to the schema information and record data of a database table or view named DatabaseANFLO-WF%dbo.vw_WFinRep_DocAttach_ReportType.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="Vw_WFinRep_DocAttach_ReportTypeView.Instance">Vw_WFinRep_DocAttach_ReportTypeView.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="Vw_WFinRep_DocAttach_ReportTypeView"></seealso>

<Serializable()> Public Class BaseVw_WFinRep_DocAttach_ReportTypeView
	Inherits KeylessTable
	

	Private ReadOnly TableDefinitionString As String = Vw_WFinRep_DocAttach_ReportTypeDefinition.GetXMLString()







	Protected Sub New()
		MyBase.New()
		Me.Initialize()
	End Sub

	Protected Overridable Sub Initialize()
		Dim def As New XmlTableDefinition(TableDefinitionString)
		Me.TableDefinition = New TableDefinition()
		Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.Vw_WFinRep_DocAttach_ReportTypeView")
		def.InitializeTableDefinition(Me.TableDefinition)
		Me.ConnectionName = def.GetConnectionName()
		Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.Vw_WFinRep_DocAttach_ReportTypeRecord")
		Me.ApplicationName = "App_Code"
		Me.DataAdapter = New Vw_WFinRep_DocAttach_ReportTypeSqlView()
		Directcast(Me.DataAdapter, Vw_WFinRep_DocAttach_ReportTypeSqlView).ConnectionName = Me.ConnectionName
		Directcast(Me.DataAdapter, Vw_WFinRep_DocAttach_ReportTypeSqlView).ApplicationName = Me.ApplicationName
		Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        FIN_IDColumn.CodeName = "FIN_ID"
        FIN_YearColumn.CodeName = "FIN_Year"
        FIN_MonthColumn.CodeName = "FIN_Month"
        FIN_TypeColumn.CodeName = "FIN_Type"
        FIn_DescriptionColumn.CodeName = "FIn_Description"
        FIN_FileColumn.CodeName = "FIN_File"
        FIN_CompanyColumn.CodeName = "FIN_Company"
        FIN_StatusColumn.CodeName = "FIN_Status"
        FIN_File1Column.CodeName = "FIN_File1"
        FIN_RptIDColumn.CodeName = "FIN_RptID"
        FIN_PostColumn.CodeName = "FIN_Post"
        FIN_RWRemColumn.CodeName = "FIN_RWRem"
        FIN_HFIN_IDColumn.CodeName = "FIN_HFIN_ID"
        WFRT_SortOrderColumn.CodeName = "WFRT_SortOrder"
        WFRT_DescriptionColumn.CodeName = "WFRT_Description"
		
	End Sub
	
#Region "Overriden methods"
    
#End Region
	
#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_ID column object.
    ''' </summary>
    Public ReadOnly Property FIN_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property FIN_ID() As BaseClasses.Data.NumberColumn
        Get
            Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.FIN_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_Year column object.
    ''' </summary>
    Public ReadOnly Property FIN_YearColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_Year column object.
    ''' </summary>
    Public Shared ReadOnly Property FIN_Year() As BaseClasses.Data.NumberColumn
        Get
            Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.FIN_YearColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_Month column object.
    ''' </summary>
    Public ReadOnly Property FIN_MonthColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_Month column object.
    ''' </summary>
    Public Shared ReadOnly Property FIN_Month() As BaseClasses.Data.NumberColumn
        Get
            Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.FIN_MonthColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_Type column object.
    ''' </summary>
    Public ReadOnly Property FIN_TypeColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_Type column object.
    ''' </summary>
    Public Shared ReadOnly Property FIN_Type() As BaseClasses.Data.StringColumn
        Get
            Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.FIN_TypeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIn_Description column object.
    ''' </summary>
    Public ReadOnly Property FIn_DescriptionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIn_Description column object.
    ''' </summary>
    Public Shared ReadOnly Property FIn_Description() As BaseClasses.Data.StringColumn
        Get
            Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.FIn_DescriptionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_File column object.
    ''' </summary>
    Public ReadOnly Property FIN_FileColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_File column object.
    ''' </summary>
    Public Shared ReadOnly Property FIN_File() As BaseClasses.Data.ImageColumn
        Get
            Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.FIN_FileColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_Company column object.
    ''' </summary>
    Public ReadOnly Property FIN_CompanyColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_Company column object.
    ''' </summary>
    Public Shared ReadOnly Property FIN_Company() As BaseClasses.Data.NumberColumn
        Get
            Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.FIN_CompanyColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_Status column object.
    ''' </summary>
    Public ReadOnly Property FIN_StatusColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_Status column object.
    ''' </summary>
    Public Shared ReadOnly Property FIN_Status() As BaseClasses.Data.NumberColumn
        Get
            Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.FIN_StatusColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_File1 column object.
    ''' </summary>
    Public ReadOnly Property FIN_File1Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_File1 column object.
    ''' </summary>
    Public Shared ReadOnly Property FIN_File1() As BaseClasses.Data.StringColumn
        Get
            Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.FIN_File1Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_RptID column object.
    ''' </summary>
    Public ReadOnly Property FIN_RptIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_RptID column object.
    ''' </summary>
    Public Shared ReadOnly Property FIN_RptID() As BaseClasses.Data.NumberColumn
        Get
            Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.FIN_RptIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_Post column object.
    ''' </summary>
    Public ReadOnly Property FIN_PostColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_Post column object.
    ''' </summary>
    Public Shared ReadOnly Property FIN_Post() As BaseClasses.Data.BooleanColumn
        Get
            Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.FIN_PostColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_RWRem column object.
    ''' </summary>
    Public ReadOnly Property FIN_RWRemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_RWRem column object.
    ''' </summary>
    Public Shared ReadOnly Property FIN_RWRem() As BaseClasses.Data.StringColumn
        Get
            Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.FIN_RWRemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_HFIN_ID column object.
    ''' </summary>
    Public ReadOnly Property FIN_HFIN_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.FIN_HFIN_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property FIN_HFIN_ID() As BaseClasses.Data.NumberColumn
        Get
            Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.FIN_HFIN_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.WFRT_SortOrder column object.
    ''' </summary>
    Public ReadOnly Property WFRT_SortOrderColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.WFRT_SortOrder column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRT_SortOrder() As BaseClasses.Data.NumberColumn
        Get
            Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.WFRT_SortOrderColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.WFRT_Description column object.
    ''' </summary>
    Public ReadOnly Property WFRT_DescriptionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's vw_WFinRep_DocAttach_ReportType_.WFRT_Description column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRT_Description() As BaseClasses.Data.StringColumn
        Get
            Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.WFRT_DescriptionColumn
        End Get
    End Property


#End Region

#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Vw_WFinRep_DocAttach_ReportTypeRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As Vw_WFinRep_DocAttach_ReportTypeRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of Vw_WFinRep_DocAttach_ReportTypeRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As Vw_WFinRep_DocAttach_ReportTypeRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Vw_WFinRep_DocAttach_ReportTypeRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As Vw_WFinRep_DocAttach_ReportTypeRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Vw_WFinRep_DocAttach_ReportTypeRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As Vw_WFinRep_DocAttach_ReportTypeRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of Vw_WFinRep_DocAttach_ReportTypeRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As Vw_WFinRep_DocAttach_ReportTypeRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.Vw_WFinRep_DocAttach_ReportTypeRecord)), Vw_WFinRep_DocAttach_ReportTypeRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Vw_WFinRep_DocAttach_ReportTypeRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As Vw_WFinRep_DocAttach_ReportTypeRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.Vw_WFinRep_DocAttach_ReportTypeRecord)), Vw_WFinRep_DocAttach_ReportTypeRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As Vw_WFinRep_DocAttach_ReportTypeRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.Vw_WFinRep_DocAttach_ReportTypeRecord)), Vw_WFinRep_DocAttach_ReportTypeRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As Vw_WFinRep_DocAttach_ReportTypeRecord()

        Dim recList As ArrayList = Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.Vw_WFinRep_DocAttach_ReportTypeRecord)), Vw_WFinRep_DocAttach_ReportTypeRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As Vw_WFinRep_DocAttach_ReportTypeRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.Vw_WFinRep_DocAttach_ReportTypeRecord)), Vw_WFinRep_DocAttach_ReportTypeRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As Vw_WFinRep_DocAttach_ReportTypeRecord()

        Dim recList As ArrayList = Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.Vw_WFinRep_DocAttach_ReportTypeRecord)), Vw_WFinRep_DocAttach_ReportTypeRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function PostGetRecordCount(ByVal selectCols As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal finalFilter As BaseFilter) As Integer
	      Return CInt(Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetCountResponseForPost(Vw_WFinRep_DocAttach_ReportTypeView.Instance.TableDefinition, selectCols, join, finalFilter))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Vw_WFinRep_DocAttach_ReportTypeRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function PostGetRecordList(ByVal requestedSelection As SqlBuilderColumnSelection, ByVal workingSelection As SqlBuilderColumnSelection, _
		ByVal distinctSelection As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal filter As BaseFilter, ByVal groupBy As GroupBy, _
	    ByVal sortOrder As OrderBy, ByVal startIndex As Integer, ByVal count As Integer, ByRef totalCount As Integer, ByVal fromDataSource As [Boolean], _
	    Optional ByVal table As KeylessVirtualTable = Nothing, Optional isGetColumnValues As Boolean = False) As ArrayList
	      
		Dim recList As ArrayList = Nothing
		If IsNothing(table) Then
			recList = Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetRecordListResponseForPost(Vw_WFinRep_DocAttach_ReportTypeView.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection, join, filter, _
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

        Return CInt(Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a Vw_WFinRep_DocAttach_ReportTypeRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As Vw_WFinRep_DocAttach_ReportTypeRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a Vw_WFinRep_DocAttach_ReportTypeRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As Vw_WFinRep_DocAttach_ReportTypeRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a Vw_WFinRep_DocAttach_ReportTypeRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As Vw_WFinRep_DocAttach_ReportTypeRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As Vw_WFinRep_DocAttach_ReportTypeRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), Vw_WFinRep_DocAttach_ReportTypeRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a Vw_WFinRep_DocAttach_ReportTypeRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As Vw_WFinRep_DocAttach_ReportTypeRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As Vw_WFinRep_DocAttach_ReportTypeRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), Vw_WFinRep_DocAttach_ReportTypeRecord)
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

        Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As Vw_WFinRep_DocAttach_ReportTypeRecord = GetRecords(where)
        Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As Vw_WFinRep_DocAttach_ReportTypeRecord = GetRecords(join, where)
        Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As Vw_WFinRep_DocAttach_ReportTypeRecord = GetRecords(where, orderBy)
        Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As Vw_WFinRep_DocAttach_ReportTypeRecord = GetRecords(join, where, orderBy)
        Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As Vw_WFinRep_DocAttach_ReportTypeRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As Vw_WFinRep_DocAttach_ReportTypeRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        Vw_WFinRep_DocAttach_ReportTypeView.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.ExportRecordData(whereFilter)
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

        Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return Vw_WFinRep_DocAttach_ReportTypeView.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = Vw_WFinRep_DocAttach_ReportTypeView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     


    ''' <summary>
    ''' This method gets the specified column.
    ''' </summary>
    ''' <param name="name">name of the column to fetch.</param>
    Public Shared Function GetColumnByName(ByVal name As String) As BaseColumn
        Dim column As BaseColumn = Vw_WFinRep_DocAttach_ReportTypeView.Instance.TableDefinition.ColumnList.GetByInternalName(name)
        Return column
    End Function       
        

	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = Vw_WFinRep_DocAttach_ReportTypeView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = Vw_WFinRep_DocAttach_ReportTypeView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
