﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WPO_InquireDetailsRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ePortalWFApproval.Data

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_WPO_InquireDetailsView"></see> class.
''' Provides access to the schema information and record data of a database table or view named DatabaseANFLO-WF%dbo.sel_WPO_InquireDetails.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="Sel_WPO_InquireDetailsView.Instance">Sel_WPO_InquireDetailsView.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="Sel_WPO_InquireDetailsView"></seealso>

<Serializable()> Public Class BaseSel_WPO_InquireDetailsView
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = Sel_WPO_InquireDetailsDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.Sel_WPO_InquireDetailsView")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.Sel_WPO_InquireDetailsRecord")
        Me.ApplicationName = "App_Code"
        Me.DataAdapter = New Sel_WPO_InquireDetailsSqlView()
        Directcast(Me.DataAdapter, Sel_WPO_InquireDetailsSqlView).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, Sel_WPO_InquireDetailsSqlView).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        CompanyIDColumn.CodeName = "CompanyID"
        PONUMBERColumn.CodeName = "PONUMBER"
        LineNumberColumn.CodeName = "LineNumber"
        ITEMNMBRColumn.CodeName = "ITEMNMBR"
        ITEMDESCColumn.CodeName = "ITEMDESC"
        UOFMColumn.CodeName = "UOFM"
        UNITCOSTColumn.CodeName = "UNITCOST"
        QTYORDERColumn.CodeName = "QTYORDER"
        EXTDCOSTColumn.CodeName = "EXTDCOST"
        DOCDATEColumn.CodeName = "DOCDATE"
        REQSTDBYColumn.CodeName = "REQSTDBY"
        ORDColumn.CodeName = "ORD"
        COMMENTSColumn.CodeName = "COMMENTS"
        COMMENT_4Column.CodeName = "COMMENT_4"
        WPOFR_Unit_CostColumn.CodeName = "WPOFR_Unit_Cost"
        WCur_ShortColumn.CodeName = "WCur_Short"
        WPOFR_RateColumn.CodeName = "WPOFR_Rate"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.CompanyID column object.
    ''' </summary>
    Public ReadOnly Property CompanyIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.CompanyID column object.
    ''' </summary>
    Public Shared ReadOnly Property CompanyID() As BaseClasses.Data.NumberColumn
        Get
            Return Sel_WPO_InquireDetailsView.Instance.CompanyIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.PONUMBER column object.
    ''' </summary>
    Public ReadOnly Property PONUMBERColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.PONUMBER column object.
    ''' </summary>
    Public Shared ReadOnly Property PONUMBER() As BaseClasses.Data.StringColumn
        Get
            Return Sel_WPO_InquireDetailsView.Instance.PONUMBERColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.LineNumber column object.
    ''' </summary>
    Public ReadOnly Property LineNumberColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.LineNumber column object.
    ''' </summary>
    Public Shared ReadOnly Property LineNumber() As BaseClasses.Data.NumberColumn
        Get
            Return Sel_WPO_InquireDetailsView.Instance.LineNumberColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.ITEMNMBR column object.
    ''' </summary>
    Public ReadOnly Property ITEMNMBRColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.ITEMNMBR column object.
    ''' </summary>
    Public Shared ReadOnly Property ITEMNMBR() As BaseClasses.Data.StringColumn
        Get
            Return Sel_WPO_InquireDetailsView.Instance.ITEMNMBRColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.ITEMDESC column object.
    ''' </summary>
    Public ReadOnly Property ITEMDESCColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.ITEMDESC column object.
    ''' </summary>
    Public Shared ReadOnly Property ITEMDESC() As BaseClasses.Data.StringColumn
        Get
            Return Sel_WPO_InquireDetailsView.Instance.ITEMDESCColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.UOFM column object.
    ''' </summary>
    Public ReadOnly Property UOFMColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.UOFM column object.
    ''' </summary>
    Public Shared ReadOnly Property UOFM() As BaseClasses.Data.StringColumn
        Get
            Return Sel_WPO_InquireDetailsView.Instance.UOFMColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.UNITCOST column object.
    ''' </summary>
    Public ReadOnly Property UNITCOSTColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.UNITCOST column object.
    ''' </summary>
    Public Shared ReadOnly Property UNITCOST() As BaseClasses.Data.NumberColumn
        Get
            Return Sel_WPO_InquireDetailsView.Instance.UNITCOSTColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.QTYORDER column object.
    ''' </summary>
    Public ReadOnly Property QTYORDERColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.QTYORDER column object.
    ''' </summary>
    Public Shared ReadOnly Property QTYORDER() As BaseClasses.Data.NumberColumn
        Get
            Return Sel_WPO_InquireDetailsView.Instance.QTYORDERColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.EXTDCOST column object.
    ''' </summary>
    Public ReadOnly Property EXTDCOSTColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.EXTDCOST column object.
    ''' </summary>
    Public Shared ReadOnly Property EXTDCOST() As BaseClasses.Data.NumberColumn
        Get
            Return Sel_WPO_InquireDetailsView.Instance.EXTDCOSTColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.DOCDATE column object.
    ''' </summary>
    Public ReadOnly Property DOCDATEColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.DOCDATE column object.
    ''' </summary>
    Public Shared ReadOnly Property DOCDATE() As BaseClasses.Data.DateColumn
        Get
            Return Sel_WPO_InquireDetailsView.Instance.DOCDATEColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.REQSTDBY column object.
    ''' </summary>
    Public ReadOnly Property REQSTDBYColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.REQSTDBY column object.
    ''' </summary>
    Public Shared ReadOnly Property REQSTDBY() As BaseClasses.Data.StringColumn
        Get
            Return Sel_WPO_InquireDetailsView.Instance.REQSTDBYColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.ORD column object.
    ''' </summary>
    Public ReadOnly Property ORDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.ORD column object.
    ''' </summary>
    Public Shared ReadOnly Property ORD() As BaseClasses.Data.NumberColumn
        Get
            Return Sel_WPO_InquireDetailsView.Instance.ORDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.COMMENTS column object.
    ''' </summary>
    Public ReadOnly Property COMMENTSColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.COMMENTS column object.
    ''' </summary>
    Public Shared ReadOnly Property COMMENTS() As BaseClasses.Data.StringColumn
        Get
            Return Sel_WPO_InquireDetailsView.Instance.COMMENTSColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.COMMENT_4 column object.
    ''' </summary>
    Public ReadOnly Property COMMENT_4Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.COMMENT_4 column object.
    ''' </summary>
    Public Shared ReadOnly Property COMMENT_4() As BaseClasses.Data.StringColumn
        Get
            Return Sel_WPO_InquireDetailsView.Instance.COMMENT_4Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.WPOFR_Unit_Cost column object.
    ''' </summary>
    Public ReadOnly Property WPOFR_Unit_CostColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.WPOFR_Unit_Cost column object.
    ''' </summary>
    Public Shared ReadOnly Property WPOFR_Unit_Cost() As BaseClasses.Data.NumberColumn
        Get
            Return Sel_WPO_InquireDetailsView.Instance.WPOFR_Unit_CostColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.WCur_Short column object.
    ''' </summary>
    Public ReadOnly Property WCur_ShortColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.WCur_Short column object.
    ''' </summary>
    Public Shared ReadOnly Property WCur_Short() As BaseClasses.Data.StringColumn
        Get
            Return Sel_WPO_InquireDetailsView.Instance.WCur_ShortColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.WPOFR_Rate column object.
    ''' </summary>
    Public ReadOnly Property WPOFR_RateColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_WPO_InquireDetails_.WPOFR_Rate column object.
    ''' </summary>
    Public Shared ReadOnly Property WPOFR_Rate() As BaseClasses.Data.NumberColumn
        Get
            Return Sel_WPO_InquireDetailsView.Instance.WPOFR_RateColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Sel_WPO_InquireDetailsRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As Sel_WPO_InquireDetailsRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of Sel_WPO_InquireDetailsRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As Sel_WPO_InquireDetailsRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Sel_WPO_InquireDetailsRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As Sel_WPO_InquireDetailsRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Sel_WPO_InquireDetailsRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As Sel_WPO_InquireDetailsRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of Sel_WPO_InquireDetailsRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As Sel_WPO_InquireDetailsRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  Sel_WPO_InquireDetailsView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.Sel_WPO_InquireDetailsRecord)), Sel_WPO_InquireDetailsRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Sel_WPO_InquireDetailsRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As Sel_WPO_InquireDetailsRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  Sel_WPO_InquireDetailsView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.Sel_WPO_InquireDetailsRecord)), Sel_WPO_InquireDetailsRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As Sel_WPO_InquireDetailsRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = Sel_WPO_InquireDetailsView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.Sel_WPO_InquireDetailsRecord)), Sel_WPO_InquireDetailsRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As Sel_WPO_InquireDetailsRecord()

        Dim recList As ArrayList = Sel_WPO_InquireDetailsView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.Sel_WPO_InquireDetailsRecord)), Sel_WPO_InquireDetailsRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As Sel_WPO_InquireDetailsRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = Sel_WPO_InquireDetailsView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.Sel_WPO_InquireDetailsRecord)), Sel_WPO_InquireDetailsRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As Sel_WPO_InquireDetailsRecord()

        Dim recList As ArrayList = Sel_WPO_InquireDetailsView.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.Sel_WPO_InquireDetailsRecord)), Sel_WPO_InquireDetailsRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function PostGetRecordCount(ByVal selectCols As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal finalFilter As BaseFilter) As Integer
	      Return CInt(Sel_WPO_InquireDetailsView.Instance.GetCountResponseForPost(Sel_WPO_InquireDetailsView.Instance.TableDefinition, selectCols, join, finalFilter))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Sel_WPO_InquireDetailsRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function PostGetRecordList(ByVal requestedSelection As SqlBuilderColumnSelection, ByVal workingSelection As SqlBuilderColumnSelection, _
		ByVal distinctSelection As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal filter As BaseFilter, ByVal groupBy As GroupBy, _
	    ByVal sortOrder As OrderBy, ByVal startIndex As Integer, ByVal count As Integer, ByRef totalCount As Integer, ByVal fromDataSource As [Boolean], _
	    Optional ByVal table As KeylessVirtualTable = Nothing, Optional isGetColumnValues As Boolean = False) As ArrayList
	      
		Dim recList As ArrayList = Nothing
		If IsNothing(table) Then
			recList = Sel_WPO_InquireDetailsView.Instance.GetRecordListResponseForPost(Sel_WPO_InquireDetailsView.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection, join, filter, _
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

        Return CInt(Sel_WPO_InquireDetailsView.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(Sel_WPO_InquireDetailsView.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(Sel_WPO_InquireDetailsView.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(Sel_WPO_InquireDetailsView.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a Sel_WPO_InquireDetailsRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As Sel_WPO_InquireDetailsRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a Sel_WPO_InquireDetailsRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As Sel_WPO_InquireDetailsRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a Sel_WPO_InquireDetailsRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As Sel_WPO_InquireDetailsRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = Sel_WPO_InquireDetailsView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As Sel_WPO_InquireDetailsRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), Sel_WPO_InquireDetailsRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a Sel_WPO_InquireDetailsRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As Sel_WPO_InquireDetailsRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = Sel_WPO_InquireDetailsView.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As Sel_WPO_InquireDetailsRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), Sel_WPO_InquireDetailsRecord)
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

        Return Sel_WPO_InquireDetailsView.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return Sel_WPO_InquireDetailsView.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As Sel_WPO_InquireDetailsRecord = GetRecords(where)
        Return Sel_WPO_InquireDetailsView.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As Sel_WPO_InquireDetailsRecord = GetRecords(join, where)
        Return Sel_WPO_InquireDetailsView.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As Sel_WPO_InquireDetailsRecord = GetRecords(where, orderBy)
        Return Sel_WPO_InquireDetailsView.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As Sel_WPO_InquireDetailsRecord = GetRecords(join, where, orderBy)
        Return Sel_WPO_InquireDetailsView.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As Sel_WPO_InquireDetailsRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return Sel_WPO_InquireDetailsView.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As Sel_WPO_InquireDetailsRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return Sel_WPO_InquireDetailsView.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        Sel_WPO_InquireDetailsView.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return Sel_WPO_InquireDetailsView.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return Sel_WPO_InquireDetailsView.Instance.ExportRecordData(whereFilter)
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

        Return Sel_WPO_InquireDetailsView.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return Sel_WPO_InquireDetailsView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return Sel_WPO_InquireDetailsView.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return Sel_WPO_InquireDetailsView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return Sel_WPO_InquireDetailsView.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return Sel_WPO_InquireDetailsView.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return Sel_WPO_InquireDetailsView.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return Sel_WPO_InquireDetailsView.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = Sel_WPO_InquireDetailsView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     


    ''' <summary>
    ''' This method gets the specified column.
    ''' </summary>
    ''' <param name="name">name of the column to fetch.</param>
    Public Shared Function GetColumnByName(ByVal name As String) As BaseColumn
        Dim column As BaseColumn = Sel_WPO_InquireDetailsView.Instance.TableDefinition.ColumnList.GetByInternalName(name)
        Return column
    End Function       
        

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As Sel_WPO_InquireDetailsRecord
        Return CType(Sel_WPO_InquireDetailsView.Instance.GetRecordData(id, bMutable), Sel_WPO_InquireDetailsRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As Sel_WPO_InquireDetailsRecord
        Return CType(Sel_WPO_InquireDetailsView.Instance.GetRecordData(id, bMutable), Sel_WPO_InquireDetailsRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal CompanyIDValue As String, _
        ByVal PONUMBERValue As String, _
        ByVal LineNumberValue As String, _
        ByVal ITEMNMBRValue As String, _
        ByVal ITEMDESCValue As String, _
        ByVal UOFMValue As String, _
        ByVal UNITCOSTValue As String, _
        ByVal QTYORDERValue As String, _
        ByVal EXTDCOSTValue As String, _
        ByVal DOCDATEValue As String, _
        ByVal REQSTDBYValue As String, _
        ByVal ORDValue As String, _
        ByVal COMMENTSValue As String, _
        ByVal COMMENT_4Value As String, _
        ByVal WPOFR_Unit_CostValue As String, _
        ByVal WCur_ShortValue As String, _
        ByVal WPOFR_RateValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(CompanyIDValue, CompanyIDColumn)
        rec.SetString(PONUMBERValue, PONUMBERColumn)
        rec.SetString(LineNumberValue, LineNumberColumn)
        rec.SetString(ITEMNMBRValue, ITEMNMBRColumn)
        rec.SetString(ITEMDESCValue, ITEMDESCColumn)
        rec.SetString(UOFMValue, UOFMColumn)
        rec.SetString(UNITCOSTValue, UNITCOSTColumn)
        rec.SetString(QTYORDERValue, QTYORDERColumn)
        rec.SetString(EXTDCOSTValue, EXTDCOSTColumn)
        rec.SetString(DOCDATEValue, DOCDATEColumn)
        rec.SetString(REQSTDBYValue, REQSTDBYColumn)
        rec.SetString(ORDValue, ORDColumn)
        rec.SetString(COMMENTSValue, COMMENTSColumn)
        rec.SetString(COMMENT_4Value, COMMENT_4Column)
        rec.SetString(WPOFR_Unit_CostValue, WPOFR_Unit_CostColumn)
        rec.SetString(WCur_ShortValue, WCur_ShortColumn)
        rec.SetString(WPOFR_RateValue, WPOFR_RateColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        Sel_WPO_InquireDetailsView.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            Sel_WPO_InquireDetailsView.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(Sel_WPO_InquireDetailsView.Instance.TableDefinition.PrimaryKey)) Then
            Return Sel_WPO_InquireDetailsView.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(Sel_WPO_InquireDetailsView.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = Sel_WPO_InquireDetailsView.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = Sel_WPO_InquireDetailsView.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (Sel_WPO_InquireDetailsView.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = Sel_WPO_InquireDetailsView.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = Sel_WPO_InquireDetailsView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = Sel_WPO_InquireDetailsView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
