' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRepNGP_Head1Record.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ePortalWFApproval.Data

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WFinRepNGP_Head1Table"></see> class.
''' Provides access to the schema information and record data of a database table or view named DatabaseANFLO-WFN%dbo.WFinRepNGP_Head.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="WFinRepNGP_Head1Table.Instance">WFinRepNGP_Head1Table.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="WFinRepNGP_Head1Table"></seealso>

<Serializable()> Public Class BaseWFinRepNGP_Head1Table
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = WFinRepNGP_Head1Definition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.WFinRepNGP_Head1Table")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.WFinRepNGP_Head1Record")
        Me.ApplicationName = "App_Code"
        Me.DataAdapter = New WFinRepNGP_Head1SqlTable()
        Directcast(Me.DataAdapter, WFinRepNGP_Head1SqlTable).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, WFinRepNGP_Head1SqlTable).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        WFRCHNGP_IDColumn.CodeName = "WFRCHNGP_ID"
        WFRCHNGP_YearColumn.CodeName = "WFRCHNGP_Year"
        WFRCHNGP_MonthColumn.CodeName = "WFRCHNGP_Month"
        WFRCHNGP_DT_IDColumn.CodeName = "WFRCHNGP_DT_ID"
        WFRCHNGP_CodeColumn.CodeName = "WFRCHNGP_Code"
        WFRCHNGP_SubmitColumn.CodeName = "WFRCHNGP_Submit"
        WFRCHNGP_StatusColumn.CodeName = "WFRCHNGP_Status"
        WFRCHNGP_C_IDColumn.CodeName = "WFRCHNGP_C_ID"
        WFRCHNGP_U_IDColumn.CodeName = "WFRCHNGP_U_ID"
        WFRCHNGP_RemarkColumn.CodeName = "WFRCHNGP_Remark"
        WFRCHNGP_PRTCNTColumn.CodeName = "WFRCHNGP_PRTCNT"
        WFRCHNGP_FinIDColumn.CodeName = "WFRCHNGP_FinID"
        WFRCHNGP_RptCountColumn.CodeName = "WFRCHNGP_RptCount"
        WFRCHNGP_DescriptionColumn.CodeName = "WFRCHNGP_Description"
        WFRCHNGP_FileColumn.CodeName = "WFRCHNGP_File"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_ID column object.
    ''' </summary>
    Public ReadOnly Property WFRCHNGP_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRCHNGP_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRepNGP_Head1Table.Instance.WFRCHNGP_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_Year column object.
    ''' </summary>
    Public ReadOnly Property WFRCHNGP_YearColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_Year column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRCHNGP_Year() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRepNGP_Head1Table.Instance.WFRCHNGP_YearColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_Month column object.
    ''' </summary>
    Public ReadOnly Property WFRCHNGP_MonthColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_Month column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRCHNGP_Month() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRepNGP_Head1Table.Instance.WFRCHNGP_MonthColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_DT_ID column object.
    ''' </summary>
    Public ReadOnly Property WFRCHNGP_DT_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_DT_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRCHNGP_DT_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRepNGP_Head1Table.Instance.WFRCHNGP_DT_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_Code column object.
    ''' </summary>
    Public ReadOnly Property WFRCHNGP_CodeColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_Code column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRCHNGP_Code() As BaseClasses.Data.StringColumn
        Get
            Return WFinRepNGP_Head1Table.Instance.WFRCHNGP_CodeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_Submit column object.
    ''' </summary>
    Public ReadOnly Property WFRCHNGP_SubmitColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_Submit column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRCHNGP_Submit() As BaseClasses.Data.BooleanColumn
        Get
            Return WFinRepNGP_Head1Table.Instance.WFRCHNGP_SubmitColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_Status column object.
    ''' </summary>
    Public ReadOnly Property WFRCHNGP_StatusColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_Status column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRCHNGP_Status() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRepNGP_Head1Table.Instance.WFRCHNGP_StatusColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_C_ID column object.
    ''' </summary>
    Public ReadOnly Property WFRCHNGP_C_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_C_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRCHNGP_C_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRepNGP_Head1Table.Instance.WFRCHNGP_C_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_U_ID column object.
    ''' </summary>
    Public ReadOnly Property WFRCHNGP_U_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_U_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRCHNGP_U_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRepNGP_Head1Table.Instance.WFRCHNGP_U_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_Remark column object.
    ''' </summary>
    Public ReadOnly Property WFRCHNGP_RemarkColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_Remark column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRCHNGP_Remark() As BaseClasses.Data.ClobColumn
        Get
            Return WFinRepNGP_Head1Table.Instance.WFRCHNGP_RemarkColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_PRTCNT column object.
    ''' </summary>
    Public ReadOnly Property WFRCHNGP_PRTCNTColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_PRTCNT column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRCHNGP_PRTCNT() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRepNGP_Head1Table.Instance.WFRCHNGP_PRTCNTColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_FinID column object.
    ''' </summary>
    Public ReadOnly Property WFRCHNGP_FinIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_FinID column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRCHNGP_FinID() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRepNGP_Head1Table.Instance.WFRCHNGP_FinIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_RptCount column object.
    ''' </summary>
    Public ReadOnly Property WFRCHNGP_RptCountColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_RptCount column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRCHNGP_RptCount() As BaseClasses.Data.NumberColumn
        Get
            Return WFinRepNGP_Head1Table.Instance.WFRCHNGP_RptCountColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_Description column object.
    ''' </summary>
    Public ReadOnly Property WFRCHNGP_DescriptionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_Description column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRCHNGP_Description() As BaseClasses.Data.StringColumn
        Get
            Return WFinRepNGP_Head1Table.Instance.WFRCHNGP_DescriptionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_File column object.
    ''' </summary>
    Public ReadOnly Property WFRCHNGP_FileColumn() As BaseClasses.Data.ImageColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.ImageColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WFinRepNGP_Head_.WFRCHNGP_File column object.
    ''' </summary>
    Public Shared ReadOnly Property WFRCHNGP_File() As BaseClasses.Data.ImageColumn
        Get
            Return WFinRepNGP_Head1Table.Instance.WFRCHNGP_FileColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRepNGP_Head1Record records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As WFinRepNGP_Head1Record()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRepNGP_Head1Record records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As WFinRepNGP_Head1Record()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRepNGP_Head1Record records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WFinRepNGP_Head1Record()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRepNGP_Head1Record records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WFinRepNGP_Head1Record()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRepNGP_Head1Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WFinRepNGP_Head1Record()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  WFinRepNGP_Head1Table.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WFinRepNGP_Head1Record)), WFinRepNGP_Head1Record())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRepNGP_Head1Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WFinRepNGP_Head1Record()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  WFinRepNGP_Head1Table.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WFinRepNGP_Head1Record)), WFinRepNGP_Head1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WFinRepNGP_Head1Record()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WFinRepNGP_Head1Table.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WFinRepNGP_Head1Record)), WFinRepNGP_Head1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WFinRepNGP_Head1Record()

        Dim recList As ArrayList = WFinRepNGP_Head1Table.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WFinRepNGP_Head1Record)), WFinRepNGP_Head1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As WFinRepNGP_Head1Record()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WFinRepNGP_Head1Table.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WFinRepNGP_Head1Record)), WFinRepNGP_Head1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As WFinRepNGP_Head1Record()

        Dim recList As ArrayList = WFinRepNGP_Head1Table.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WFinRepNGP_Head1Record)), WFinRepNGP_Head1Record())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function PostGetRecordCount(ByVal selectCols As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal finalFilter As BaseFilter) As Integer
	      Return CInt(WFinRepNGP_Head1Table.Instance.GetCountResponseForPost(WFinRepNGP_Head1Table.Instance.TableDefinition, selectCols, join, finalFilter))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WFinRepNGP_Head1Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function PostGetRecordList(ByVal requestedSelection As SqlBuilderColumnSelection, ByVal workingSelection As SqlBuilderColumnSelection, _
		ByVal distinctSelection As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal filter As BaseFilter, ByVal groupBy As GroupBy, _
	    ByVal sortOrder As OrderBy, ByVal startIndex As Integer, ByVal count As Integer, ByRef totalCount As Integer, ByVal fromDataSource As [Boolean], _
	    Optional ByVal table As KeylessVirtualTable = Nothing, Optional isGetColumnValues As Boolean = False) As ArrayList
	      
		Dim recList As ArrayList = Nothing
		If IsNothing(table) Then
			recList = WFinRepNGP_Head1Table.Instance.GetRecordListResponseForPost(WFinRepNGP_Head1Table.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection, join, filter, _
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

        Return CInt(WFinRepNGP_Head1Table.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(WFinRepNGP_Head1Table.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(WFinRepNGP_Head1Table.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(WFinRepNGP_Head1Table.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WFinRepNGP_Head1Record record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As WFinRepNGP_Head1Record
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WFinRepNGP_Head1Record record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As WFinRepNGP_Head1Record
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WFinRepNGP_Head1Record record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WFinRepNGP_Head1Record

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WFinRepNGP_Head1Table.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As WFinRepNGP_Head1Record = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), WFinRepNGP_Head1Record)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WFinRepNGP_Head1Record record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WFinRepNGP_Head1Record

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = WFinRepNGP_Head1Table.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As WFinRepNGP_Head1Record = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), WFinRepNGP_Head1Record)
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

        Return WFinRepNGP_Head1Table.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return WFinRepNGP_Head1Table.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As WFinRepNGP_Head1Record = GetRecords(where)
        Return WFinRepNGP_Head1Table.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As WFinRepNGP_Head1Record = GetRecords(join, where)
        Return WFinRepNGP_Head1Table.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As WFinRepNGP_Head1Record = GetRecords(where, orderBy)
        Return WFinRepNGP_Head1Table.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As WFinRepNGP_Head1Record = GetRecords(join, where, orderBy)
        Return WFinRepNGP_Head1Table.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As WFinRepNGP_Head1Record = GetRecords(where, orderBy, pageIndex, pageSize)
        Return WFinRepNGP_Head1Table.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As WFinRepNGP_Head1Record = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return WFinRepNGP_Head1Table.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        WFinRepNGP_Head1Table.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return WFinRepNGP_Head1Table.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return WFinRepNGP_Head1Table.Instance.ExportRecordData(whereFilter)
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

        Return WFinRepNGP_Head1Table.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WFinRepNGP_Head1Table.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WFinRepNGP_Head1Table.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WFinRepNGP_Head1Table.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return WFinRepNGP_Head1Table.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return WFinRepNGP_Head1Table.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return WFinRepNGP_Head1Table.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return WFinRepNGP_Head1Table.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = WFinRepNGP_Head1Table.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     


    ''' <summary>
    ''' This method gets the specified column.
    ''' </summary>
    ''' <param name="name">name of the column to fetch.</param>
    Public Shared Function GetColumnByName(ByVal name As String) As BaseColumn
        Dim column As BaseColumn = WFinRepNGP_Head1Table.Instance.TableDefinition.ColumnList.GetByInternalName(name)
        Return column
    End Function       
        

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As WFinRepNGP_Head1Record
        Return CType(WFinRepNGP_Head1Table.Instance.GetRecordData(id, bMutable), WFinRepNGP_Head1Record)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As WFinRepNGP_Head1Record
        Return CType(WFinRepNGP_Head1Table.Instance.GetRecordData(id, bMutable), WFinRepNGP_Head1Record)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal WFRCHNGP_YearValue As String, _
        ByVal WFRCHNGP_MonthValue As String, _
        ByVal WFRCHNGP_DT_IDValue As String, _
        ByVal WFRCHNGP_CodeValue As String, _
        ByVal WFRCHNGP_SubmitValue As String, _
        ByVal WFRCHNGP_StatusValue As String, _
        ByVal WFRCHNGP_C_IDValue As String, _
        ByVal WFRCHNGP_U_IDValue As String, _
        ByVal WFRCHNGP_RemarkValue As String, _
        ByVal WFRCHNGP_PRTCNTValue As String, _
        ByVal WFRCHNGP_FinIDValue As String, _
        ByVal WFRCHNGP_RptCountValue As String, _
        ByVal WFRCHNGP_DescriptionValue As String, _
        ByVal WFRCHNGP_FileValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(WFRCHNGP_YearValue, WFRCHNGP_YearColumn)
        rec.SetString(WFRCHNGP_MonthValue, WFRCHNGP_MonthColumn)
        rec.SetString(WFRCHNGP_DT_IDValue, WFRCHNGP_DT_IDColumn)
        rec.SetString(WFRCHNGP_CodeValue, WFRCHNGP_CodeColumn)
        rec.SetString(WFRCHNGP_SubmitValue, WFRCHNGP_SubmitColumn)
        rec.SetString(WFRCHNGP_StatusValue, WFRCHNGP_StatusColumn)
        rec.SetString(WFRCHNGP_C_IDValue, WFRCHNGP_C_IDColumn)
        rec.SetString(WFRCHNGP_U_IDValue, WFRCHNGP_U_IDColumn)
        rec.SetString(WFRCHNGP_RemarkValue, WFRCHNGP_RemarkColumn)
        rec.SetString(WFRCHNGP_PRTCNTValue, WFRCHNGP_PRTCNTColumn)
        rec.SetString(WFRCHNGP_FinIDValue, WFRCHNGP_FinIDColumn)
        rec.SetString(WFRCHNGP_RptCountValue, WFRCHNGP_RptCountColumn)
        rec.SetString(WFRCHNGP_DescriptionValue, WFRCHNGP_DescriptionColumn)
        rec.SetString(WFRCHNGP_FileValue, WFRCHNGP_FileColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        WFinRepNGP_Head1Table.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            WFinRepNGP_Head1Table.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(WFinRepNGP_Head1Table.Instance.TableDefinition.PrimaryKey)) Then
            Return WFinRepNGP_Head1Table.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(WFinRepNGP_Head1Table.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = WFinRepNGP_Head1Table.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = WFinRepNGP_Head1Table.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (WFinRepNGP_Head1Table.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = WFinRepNGP_Head1Table.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = WFinRepNGP_Head1Table.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = WFinRepNGP_Head1Table.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
