﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in POP10100_HEADER_ALL2Record.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ePortalWFApproval.Data

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="POP10100_HEADER_ALL2View"></see> class.
''' Provides access to the schema information and record data of a database table or view named DatabaseANFLO-WFN%dbo.POP10100_HEADER_ALL.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="POP10100_HEADER_ALL2View.Instance">POP10100_HEADER_ALL2View.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="POP10100_HEADER_ALL2View"></seealso>

<Serializable()> Public Class BasePOP10100_HEADER_ALL2View
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = POP10100_HEADER_ALL2Definition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.POP10100_HEADER_ALL2View")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.POP10100_HEADER_ALL2Record")
        Me.ApplicationName = "App_Code"
        Me.DataAdapter = New POP10100_HEADER_ALL2SqlView()
        Directcast(Me.DataAdapter, POP10100_HEADER_ALL2SqlView).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, POP10100_HEADER_ALL2SqlView).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        PONUMBERColumn.CodeName = "PONUMBER"
        POSTATUSColumn.CodeName = "POSTATUS"
        DOCDATEColumn.CodeName = "DOCDATE"
        SUBTOTALColumn.CodeName = "SUBTOTAL"
        TRDISAMTColumn.CodeName = "TRDISAMT"
        FRTAMNTColumn.CodeName = "FRTAMNT"
        MSCCHAMTColumn.CodeName = "MSCCHAMT"
        TAXAMNTColumn.CodeName = "TAXAMNT"
        VENDORIDColumn.CodeName = "VENDORID"
        VENDNAMEColumn.CodeName = "VENDNAME"
        CMPANYIDColumn.CodeName = "CMPANYID"
        COMMNTIDColumn.CodeName = "COMMNTID"
        BUYERIDColumn.CodeName = "BUYERID"
        Workflow_Approval_StatusColumn.CodeName = "Workflow_Approval_Status"
        CompanyIDColumn.CodeName = "CompanyID"
        CMMTTEXTColumn.CodeName = "CMMTTEXT"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.PONUMBER column object.
    ''' </summary>
    Public ReadOnly Property PONUMBERColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.PONUMBER column object.
    ''' </summary>
    Public Shared ReadOnly Property PONUMBER() As BaseClasses.Data.StringColumn
        Get
            Return POP10100_HEADER_ALL2View.Instance.PONUMBERColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.POSTATUS column object.
    ''' </summary>
    Public ReadOnly Property POSTATUSColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.POSTATUS column object.
    ''' </summary>
    Public Shared ReadOnly Property POSTATUS() As BaseClasses.Data.NumberColumn
        Get
            Return POP10100_HEADER_ALL2View.Instance.POSTATUSColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.DOCDATE column object.
    ''' </summary>
    Public ReadOnly Property DOCDATEColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.DOCDATE column object.
    ''' </summary>
    Public Shared ReadOnly Property DOCDATE() As BaseClasses.Data.DateColumn
        Get
            Return POP10100_HEADER_ALL2View.Instance.DOCDATEColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.SUBTOTAL column object.
    ''' </summary>
    Public ReadOnly Property SUBTOTALColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.SUBTOTAL column object.
    ''' </summary>
    Public Shared ReadOnly Property SUBTOTAL() As BaseClasses.Data.NumberColumn
        Get
            Return POP10100_HEADER_ALL2View.Instance.SUBTOTALColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.TRDISAMT column object.
    ''' </summary>
    Public ReadOnly Property TRDISAMTColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.TRDISAMT column object.
    ''' </summary>
    Public Shared ReadOnly Property TRDISAMT() As BaseClasses.Data.NumberColumn
        Get
            Return POP10100_HEADER_ALL2View.Instance.TRDISAMTColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.FRTAMNT column object.
    ''' </summary>
    Public ReadOnly Property FRTAMNTColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.FRTAMNT column object.
    ''' </summary>
    Public Shared ReadOnly Property FRTAMNT() As BaseClasses.Data.NumberColumn
        Get
            Return POP10100_HEADER_ALL2View.Instance.FRTAMNTColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.MSCCHAMT column object.
    ''' </summary>
    Public ReadOnly Property MSCCHAMTColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.MSCCHAMT column object.
    ''' </summary>
    Public Shared ReadOnly Property MSCCHAMT() As BaseClasses.Data.NumberColumn
        Get
            Return POP10100_HEADER_ALL2View.Instance.MSCCHAMTColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.TAXAMNT column object.
    ''' </summary>
    Public ReadOnly Property TAXAMNTColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.TAXAMNT column object.
    ''' </summary>
    Public Shared ReadOnly Property TAXAMNT() As BaseClasses.Data.NumberColumn
        Get
            Return POP10100_HEADER_ALL2View.Instance.TAXAMNTColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.VENDORID column object.
    ''' </summary>
    Public ReadOnly Property VENDORIDColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.VENDORID column object.
    ''' </summary>
    Public Shared ReadOnly Property VENDORID() As BaseClasses.Data.StringColumn
        Get
            Return POP10100_HEADER_ALL2View.Instance.VENDORIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.VENDNAME column object.
    ''' </summary>
    Public ReadOnly Property VENDNAMEColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.VENDNAME column object.
    ''' </summary>
    Public Shared ReadOnly Property VENDNAME() As BaseClasses.Data.StringColumn
        Get
            Return POP10100_HEADER_ALL2View.Instance.VENDNAMEColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.CMPANYID column object.
    ''' </summary>
    Public ReadOnly Property CMPANYIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.CMPANYID column object.
    ''' </summary>
    Public Shared ReadOnly Property CMPANYID() As BaseClasses.Data.NumberColumn
        Get
            Return POP10100_HEADER_ALL2View.Instance.CMPANYIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.COMMNTID column object.
    ''' </summary>
    Public ReadOnly Property COMMNTIDColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.COMMNTID column object.
    ''' </summary>
    Public Shared ReadOnly Property COMMNTID() As BaseClasses.Data.StringColumn
        Get
            Return POP10100_HEADER_ALL2View.Instance.COMMNTIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.BUYERID column object.
    ''' </summary>
    Public ReadOnly Property BUYERIDColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.BUYERID column object.
    ''' </summary>
    Public Shared ReadOnly Property BUYERID() As BaseClasses.Data.StringColumn
        Get
            Return POP10100_HEADER_ALL2View.Instance.BUYERIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.Workflow_Approval_Status column object.
    ''' </summary>
    Public ReadOnly Property Workflow_Approval_StatusColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.Workflow_Approval_Status column object.
    ''' </summary>
    Public Shared ReadOnly Property Workflow_Approval_Status() As BaseClasses.Data.NumberColumn
        Get
            Return POP10100_HEADER_ALL2View.Instance.Workflow_Approval_StatusColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.CompanyID column object.
    ''' </summary>
    Public ReadOnly Property CompanyIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.CompanyID column object.
    ''' </summary>
    Public Shared ReadOnly Property CompanyID() As BaseClasses.Data.NumberColumn
        Get
            Return POP10100_HEADER_ALL2View.Instance.CompanyIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.CMMTTEXT column object.
    ''' </summary>
    Public ReadOnly Property CMMTTEXTColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's POP10100_HEADER_ALL_.CMMTTEXT column object.
    ''' </summary>
    Public Shared ReadOnly Property CMMTTEXT() As BaseClasses.Data.ClobColumn
        Get
            Return POP10100_HEADER_ALL2View.Instance.CMMTTEXTColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of POP10100_HEADER_ALL2Record records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As POP10100_HEADER_ALL2Record()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of POP10100_HEADER_ALL2Record records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As POP10100_HEADER_ALL2Record()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of POP10100_HEADER_ALL2Record records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As POP10100_HEADER_ALL2Record()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of POP10100_HEADER_ALL2Record records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As POP10100_HEADER_ALL2Record()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of POP10100_HEADER_ALL2Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As POP10100_HEADER_ALL2Record()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  POP10100_HEADER_ALL2View.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.POP10100_HEADER_ALL2Record)), POP10100_HEADER_ALL2Record())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of POP10100_HEADER_ALL2Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As POP10100_HEADER_ALL2Record()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  POP10100_HEADER_ALL2View.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.POP10100_HEADER_ALL2Record)), POP10100_HEADER_ALL2Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As POP10100_HEADER_ALL2Record()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = POP10100_HEADER_ALL2View.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.POP10100_HEADER_ALL2Record)), POP10100_HEADER_ALL2Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As POP10100_HEADER_ALL2Record()

        Dim recList As ArrayList = POP10100_HEADER_ALL2View.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.POP10100_HEADER_ALL2Record)), POP10100_HEADER_ALL2Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As POP10100_HEADER_ALL2Record()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = POP10100_HEADER_ALL2View.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.POP10100_HEADER_ALL2Record)), POP10100_HEADER_ALL2Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As POP10100_HEADER_ALL2Record()

        Dim recList As ArrayList = POP10100_HEADER_ALL2View.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.POP10100_HEADER_ALL2Record)), POP10100_HEADER_ALL2Record())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function PostGetRecordCount(ByVal selectCols As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal finalFilter As BaseFilter) As Integer
	      Return CInt(POP10100_HEADER_ALL2View.Instance.GetCountResponseForPost(POP10100_HEADER_ALL2View.Instance.TableDefinition, selectCols, join, finalFilter))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of POP10100_HEADER_ALL2Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function PostGetRecordList(ByVal requestedSelection As SqlBuilderColumnSelection, ByVal workingSelection As SqlBuilderColumnSelection, _
		ByVal distinctSelection As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal filter As BaseFilter, ByVal groupBy As GroupBy, _
	    ByVal sortOrder As OrderBy, ByVal startIndex As Integer, ByVal count As Integer, ByRef totalCount As Integer, ByVal fromDataSource As [Boolean], _
	    Optional ByVal table As KeylessVirtualTable = Nothing, Optional isGetColumnValues As Boolean = False) As ArrayList
	      
		Dim recList As ArrayList = Nothing
		If IsNothing(table) Then
			recList = POP10100_HEADER_ALL2View.Instance.GetRecordListResponseForPost(POP10100_HEADER_ALL2View.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection, join, filter, _
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

        Return CInt(POP10100_HEADER_ALL2View.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(POP10100_HEADER_ALL2View.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(POP10100_HEADER_ALL2View.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(POP10100_HEADER_ALL2View.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a POP10100_HEADER_ALL2Record record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As POP10100_HEADER_ALL2Record
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a POP10100_HEADER_ALL2Record record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As POP10100_HEADER_ALL2Record
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a POP10100_HEADER_ALL2Record record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As POP10100_HEADER_ALL2Record

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = POP10100_HEADER_ALL2View.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As POP10100_HEADER_ALL2Record = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), POP10100_HEADER_ALL2Record)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a POP10100_HEADER_ALL2Record record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As POP10100_HEADER_ALL2Record

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = POP10100_HEADER_ALL2View.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As POP10100_HEADER_ALL2Record = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), POP10100_HEADER_ALL2Record)
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

        Return POP10100_HEADER_ALL2View.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return POP10100_HEADER_ALL2View.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As POP10100_HEADER_ALL2Record = GetRecords(where)
        Return POP10100_HEADER_ALL2View.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As POP10100_HEADER_ALL2Record = GetRecords(join, where)
        Return POP10100_HEADER_ALL2View.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As POP10100_HEADER_ALL2Record = GetRecords(where, orderBy)
        Return POP10100_HEADER_ALL2View.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As POP10100_HEADER_ALL2Record = GetRecords(join, where, orderBy)
        Return POP10100_HEADER_ALL2View.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As POP10100_HEADER_ALL2Record = GetRecords(where, orderBy, pageIndex, pageSize)
        Return POP10100_HEADER_ALL2View.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As POP10100_HEADER_ALL2Record = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return POP10100_HEADER_ALL2View.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        POP10100_HEADER_ALL2View.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return POP10100_HEADER_ALL2View.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return POP10100_HEADER_ALL2View.Instance.ExportRecordData(whereFilter)
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

        Return POP10100_HEADER_ALL2View.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return POP10100_HEADER_ALL2View.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return POP10100_HEADER_ALL2View.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return POP10100_HEADER_ALL2View.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return POP10100_HEADER_ALL2View.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return POP10100_HEADER_ALL2View.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return POP10100_HEADER_ALL2View.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return POP10100_HEADER_ALL2View.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = POP10100_HEADER_ALL2View.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     


    ''' <summary>
    ''' This method gets the specified column.
    ''' </summary>
    ''' <param name="name">name of the column to fetch.</param>
    Public Shared Function GetColumnByName(ByVal name As String) As BaseColumn
        Dim column As BaseColumn = POP10100_HEADER_ALL2View.Instance.TableDefinition.ColumnList.GetByInternalName(name)
        Return column
    End Function       
        

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As POP10100_HEADER_ALL2Record
        Return CType(POP10100_HEADER_ALL2View.Instance.GetRecordData(id, bMutable), POP10100_HEADER_ALL2Record)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As POP10100_HEADER_ALL2Record
        Return CType(POP10100_HEADER_ALL2View.Instance.GetRecordData(id, bMutable), POP10100_HEADER_ALL2Record)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal PONUMBERValue As String, _
        ByVal POSTATUSValue As String, _
        ByVal DOCDATEValue As String, _
        ByVal SUBTOTALValue As String, _
        ByVal TRDISAMTValue As String, _
        ByVal FRTAMNTValue As String, _
        ByVal MSCCHAMTValue As String, _
        ByVal TAXAMNTValue As String, _
        ByVal VENDORIDValue As String, _
        ByVal VENDNAMEValue As String, _
        ByVal CMPANYIDValue As String, _
        ByVal COMMNTIDValue As String, _
        ByVal BUYERIDValue As String, _
        ByVal Workflow_Approval_StatusValue As String, _
        ByVal CompanyIDValue As String, _
        ByVal CMMTTEXTValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(PONUMBERValue, PONUMBERColumn)
        rec.SetString(POSTATUSValue, POSTATUSColumn)
        rec.SetString(DOCDATEValue, DOCDATEColumn)
        rec.SetString(SUBTOTALValue, SUBTOTALColumn)
        rec.SetString(TRDISAMTValue, TRDISAMTColumn)
        rec.SetString(FRTAMNTValue, FRTAMNTColumn)
        rec.SetString(MSCCHAMTValue, MSCCHAMTColumn)
        rec.SetString(TAXAMNTValue, TAXAMNTColumn)
        rec.SetString(VENDORIDValue, VENDORIDColumn)
        rec.SetString(VENDNAMEValue, VENDNAMEColumn)
        rec.SetString(CMPANYIDValue, CMPANYIDColumn)
        rec.SetString(COMMNTIDValue, COMMNTIDColumn)
        rec.SetString(BUYERIDValue, BUYERIDColumn)
        rec.SetString(Workflow_Approval_StatusValue, Workflow_Approval_StatusColumn)
        rec.SetString(CompanyIDValue, CompanyIDColumn)
        rec.SetString(CMMTTEXTValue, CMMTTEXTColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        POP10100_HEADER_ALL2View.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            POP10100_HEADER_ALL2View.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(POP10100_HEADER_ALL2View.Instance.TableDefinition.PrimaryKey)) Then
            Return POP10100_HEADER_ALL2View.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(POP10100_HEADER_ALL2View.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = POP10100_HEADER_ALL2View.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = POP10100_HEADER_ALL2View.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (POP10100_HEADER_ALL2View.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = POP10100_HEADER_ALL2View.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = POP10100_HEADER_ALL2View.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = POP10100_HEADER_ALL2View.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
