' This class is "generated" and will be overwritten.
' Your customizations should be made in WPR_LineRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ePortalWFApproval.Data

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WPR_LineTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named DatabaseANFLO-WF%dbo.WPR_Line.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="WPR_LineTable.Instance">WPR_LineTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="WPR_LineTable"></seealso>

<Serializable()> Public Class BaseWPR_LineTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = WPR_LineDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.WPR_LineTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.WPR_LineRecord")
        Me.ApplicationName = "App_Code"
        Me.DataAdapter = New WPR_LineSqlTable()
        Directcast(Me.DataAdapter, WPR_LineSqlTable).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, WPR_LineSqlTable).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        WPRL_IDColumn.CodeName = "WPRL_ID"
        WPRL_WPRD_IDColumn.CodeName = "WPRL_WPRD_ID"
        WPRL_IV00101_Item_NoColumn.CodeName = "WPRL_IV00101_Item_No"
        WPRL_IV40700_Locn_CodeColumn.CodeName = "WPRL_IV40700_Locn_Code"
        WPRL_PM00200_Vendor_IDColumn.CodeName = "WPRL_PM00200_Vendor_ID"
        WPRL_GL00101_Acct_IndxColumn.CodeName = "WPRL_GL00101_Acct_Indx"
        WPRL_IV00101_Prchs_UOMColumn.CodeName = "WPRL_IV00101_Prchs_UOM"
        WPRL_Line_Seq_NoColumn.CodeName = "WPRL_Line_Seq_No"
        WPRL_Item_CommentColumn.CodeName = "WPRL_Item_Comment"
        WPRL_Item_TextColumn.CodeName = "WPRL_Item_Text"
        WPRL_Item_DescColumn.CodeName = "WPRL_Item_Desc"
        WPRL_Item_Non_InvColumn.CodeName = "WPRL_Item_Non_Inv"
        WPRL_Required_DateColumn.CodeName = "WPRL_Required_Date"
        WPRL_Unit_PriceColumn.CodeName = "WPRL_Unit_Price"
        WPRL_QtyColumn.CodeName = "WPRL_Qty"
        WPRL_Ext_PriceColumn.CodeName = "WPRL_Ext_Price"
        WPRL_WPRLS_IDColumn.CodeName = "WPRL_WPRLS_ID"
        WPRL_PO_NoColumn.CodeName = "WPRL_PO_No"
        WPRL_PO_Line_Seq_NoColumn.CodeName = "WPRL_PO_Line_Seq_No"
        WPRL_Item_Non_Inv_UOMColumn.CodeName = "WPRL_Item_Non_Inv_UOM"
        WPRL_Vendor_NameColumn.CodeName = "WPRL_Vendor_Name"
        WPRL_AccountColumn.CodeName = "WPRL_Account"
        WPRL_WClass_IDColumn.CodeName = "WPRL_WClass_ID"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_ID column object.
    ''' </summary>
    Public ReadOnly Property WPRL_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WPR_LineTable.Instance.WPRL_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_WPRD_ID column object.
    ''' </summary>
    Public ReadOnly Property WPRL_WPRD_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_WPRD_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_WPRD_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WPR_LineTable.Instance.WPRL_WPRD_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_IV00101_Item_No column object.
    ''' </summary>
    Public ReadOnly Property WPRL_IV00101_Item_NoColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_IV00101_Item_No column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_IV00101_Item_No() As BaseClasses.Data.StringColumn
        Get
            Return WPR_LineTable.Instance.WPRL_IV00101_Item_NoColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_IV40700_Locn_Code column object.
    ''' </summary>
    Public ReadOnly Property WPRL_IV40700_Locn_CodeColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_IV40700_Locn_Code column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_IV40700_Locn_Code() As BaseClasses.Data.StringColumn
        Get
            Return WPR_LineTable.Instance.WPRL_IV40700_Locn_CodeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_PM00200_Vendor_ID column object.
    ''' </summary>
    Public ReadOnly Property WPRL_PM00200_Vendor_IDColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_PM00200_Vendor_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_PM00200_Vendor_ID() As BaseClasses.Data.StringColumn
        Get
            Return WPR_LineTable.Instance.WPRL_PM00200_Vendor_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_GL00101_Acct_Indx column object.
    ''' </summary>
    Public ReadOnly Property WPRL_GL00101_Acct_IndxColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_GL00101_Acct_Indx column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_GL00101_Acct_Indx() As BaseClasses.Data.NumberColumn
        Get
            Return WPR_LineTable.Instance.WPRL_GL00101_Acct_IndxColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_IV00101_Prchs_UOM column object.
    ''' </summary>
    Public ReadOnly Property WPRL_IV00101_Prchs_UOMColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_IV00101_Prchs_UOM column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_IV00101_Prchs_UOM() As BaseClasses.Data.StringColumn
        Get
            Return WPR_LineTable.Instance.WPRL_IV00101_Prchs_UOMColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Line_Seq_No column object.
    ''' </summary>
    Public ReadOnly Property WPRL_Line_Seq_NoColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Line_Seq_No column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_Line_Seq_No() As BaseClasses.Data.NumberColumn
        Get
            Return WPR_LineTable.Instance.WPRL_Line_Seq_NoColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Item_Comment column object.
    ''' </summary>
    Public ReadOnly Property WPRL_Item_CommentColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Item_Comment column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_Item_Comment() As BaseClasses.Data.StringColumn
        Get
            Return WPR_LineTable.Instance.WPRL_Item_CommentColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Item_Text column object.
    ''' </summary>
    Public ReadOnly Property WPRL_Item_TextColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Item_Text column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_Item_Text() As BaseClasses.Data.StringColumn
        Get
            Return WPR_LineTable.Instance.WPRL_Item_TextColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Item_Desc column object.
    ''' </summary>
    Public ReadOnly Property WPRL_Item_DescColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Item_Desc column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_Item_Desc() As BaseClasses.Data.StringColumn
        Get
            Return WPR_LineTable.Instance.WPRL_Item_DescColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Item_Non_Inv column object.
    ''' </summary>
    Public ReadOnly Property WPRL_Item_Non_InvColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Item_Non_Inv column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_Item_Non_Inv() As BaseClasses.Data.StringColumn
        Get
            Return WPR_LineTable.Instance.WPRL_Item_Non_InvColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Required_Date column object.
    ''' </summary>
    Public ReadOnly Property WPRL_Required_DateColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Required_Date column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_Required_Date() As BaseClasses.Data.DateColumn
        Get
            Return WPR_LineTable.Instance.WPRL_Required_DateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Unit_Price column object.
    ''' </summary>
    Public ReadOnly Property WPRL_Unit_PriceColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Unit_Price column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_Unit_Price() As BaseClasses.Data.NumberColumn
        Get
            Return WPR_LineTable.Instance.WPRL_Unit_PriceColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Qty column object.
    ''' </summary>
    Public ReadOnly Property WPRL_QtyColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Qty column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_Qty() As BaseClasses.Data.NumberColumn
        Get
            Return WPR_LineTable.Instance.WPRL_QtyColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Ext_Price column object.
    ''' </summary>
    Public ReadOnly Property WPRL_Ext_PriceColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Ext_Price column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_Ext_Price() As BaseClasses.Data.NumberColumn
        Get
            Return WPR_LineTable.Instance.WPRL_Ext_PriceColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_WPRLS_ID column object.
    ''' </summary>
    Public ReadOnly Property WPRL_WPRLS_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_WPRLS_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_WPRLS_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WPR_LineTable.Instance.WPRL_WPRLS_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_PO_No column object.
    ''' </summary>
    Public ReadOnly Property WPRL_PO_NoColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_PO_No column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_PO_No() As BaseClasses.Data.StringColumn
        Get
            Return WPR_LineTable.Instance.WPRL_PO_NoColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_PO_Line_Seq_No column object.
    ''' </summary>
    Public ReadOnly Property WPRL_PO_Line_Seq_NoColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_PO_Line_Seq_No column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_PO_Line_Seq_No() As BaseClasses.Data.NumberColumn
        Get
            Return WPR_LineTable.Instance.WPRL_PO_Line_Seq_NoColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Item_Non_Inv_UOM column object.
    ''' </summary>
    Public ReadOnly Property WPRL_Item_Non_Inv_UOMColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Item_Non_Inv_UOM column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_Item_Non_Inv_UOM() As BaseClasses.Data.StringColumn
        Get
            Return WPR_LineTable.Instance.WPRL_Item_Non_Inv_UOMColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Vendor_Name column object.
    ''' </summary>
    Public ReadOnly Property WPRL_Vendor_NameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Vendor_Name column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_Vendor_Name() As BaseClasses.Data.StringColumn
        Get
            Return WPR_LineTable.Instance.WPRL_Vendor_NameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Account column object.
    ''' </summary>
    Public ReadOnly Property WPRL_AccountColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_Account column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_Account() As BaseClasses.Data.StringColumn
        Get
            Return WPR_LineTable.Instance.WPRL_AccountColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_WClass_ID column object.
    ''' </summary>
    Public ReadOnly Property WPRL_WClass_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WPR_Line_.WPRL_WClass_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_WClass_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WPR_LineTable.Instance.WPRL_WClass_IDColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WPR_LineRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As WPR_LineRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of WPR_LineRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As WPR_LineRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WPR_LineRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WPR_LineRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WPR_LineRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WPR_LineRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of WPR_LineRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WPR_LineRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  WPR_LineTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WPR_LineRecord)), WPR_LineRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WPR_LineRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WPR_LineRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  WPR_LineTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WPR_LineRecord)), WPR_LineRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WPR_LineRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WPR_LineTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WPR_LineRecord)), WPR_LineRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WPR_LineRecord()

        Dim recList As ArrayList = WPR_LineTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WPR_LineRecord)), WPR_LineRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As WPR_LineRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WPR_LineTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WPR_LineRecord)), WPR_LineRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As WPR_LineRecord()

        Dim recList As ArrayList = WPR_LineTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WPR_LineRecord)), WPR_LineRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function PostGetRecordCount(ByVal selectCols As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal finalFilter As BaseFilter) As Integer
	      Return CInt(WPR_LineTable.Instance.GetCountResponseForPost(WPR_LineTable.Instance.TableDefinition, selectCols, join, finalFilter))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WPR_LineRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function PostGetRecordList(ByVal requestedSelection As SqlBuilderColumnSelection, ByVal workingSelection As SqlBuilderColumnSelection, _
		ByVal distinctSelection As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal filter As BaseFilter, ByVal groupBy As GroupBy, _
	    ByVal sortOrder As OrderBy, ByVal startIndex As Integer, ByVal count As Integer, ByRef totalCount As Integer, ByVal fromDataSource As [Boolean], _
	    Optional ByVal table As KeylessVirtualTable = Nothing, Optional isGetColumnValues As Boolean = False) As ArrayList
	      
		Dim recList As ArrayList = Nothing
		If IsNothing(table) Then
			recList = WPR_LineTable.Instance.GetRecordListResponseForPost(WPR_LineTable.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection, join, filter, _
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

        Return CInt(WPR_LineTable.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(WPR_LineTable.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(WPR_LineTable.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(WPR_LineTable.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WPR_LineRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As WPR_LineRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WPR_LineRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As WPR_LineRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WPR_LineRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WPR_LineRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WPR_LineTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As WPR_LineRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), WPR_LineRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WPR_LineRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WPR_LineRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = WPR_LineTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As WPR_LineRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), WPR_LineRecord)
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

        Return WPR_LineTable.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return WPR_LineTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As WPR_LineRecord = GetRecords(where)
        Return WPR_LineTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As WPR_LineRecord = GetRecords(join, where)
        Return WPR_LineTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As WPR_LineRecord = GetRecords(where, orderBy)
        Return WPR_LineTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As WPR_LineRecord = GetRecords(join, where, orderBy)
        Return WPR_LineTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As WPR_LineRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return WPR_LineTable.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As WPR_LineRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return WPR_LineTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        WPR_LineTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return WPR_LineTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return WPR_LineTable.Instance.ExportRecordData(whereFilter)
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

        Return WPR_LineTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WPR_LineTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WPR_LineTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WPR_LineTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return WPR_LineTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return WPR_LineTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return WPR_LineTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return WPR_LineTable.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = WPR_LineTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     


    ''' <summary>
    ''' This method gets the specified column.
    ''' </summary>
    ''' <param name="name">name of the column to fetch.</param>
    Public Shared Function GetColumnByName(ByVal name As String) As BaseColumn
        Dim column As BaseColumn = WPR_LineTable.Instance.TableDefinition.ColumnList.GetByInternalName(name)
        Return column
    End Function       
        

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As WPR_LineRecord
        Return CType(WPR_LineTable.Instance.GetRecordData(id, bMutable), WPR_LineRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As WPR_LineRecord
        Return CType(WPR_LineTable.Instance.GetRecordData(id, bMutable), WPR_LineRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal WPRL_WPRD_IDValue As String, _
        ByVal WPRL_IV00101_Item_NoValue As String, _
        ByVal WPRL_IV40700_Locn_CodeValue As String, _
        ByVal WPRL_PM00200_Vendor_IDValue As String, _
        ByVal WPRL_GL00101_Acct_IndxValue As String, _
        ByVal WPRL_IV00101_Prchs_UOMValue As String, _
        ByVal WPRL_Line_Seq_NoValue As String, _
        ByVal WPRL_Item_CommentValue As String, _
        ByVal WPRL_Item_TextValue As String, _
        ByVal WPRL_Item_DescValue As String, _
        ByVal WPRL_Item_Non_InvValue As String, _
        ByVal WPRL_Required_DateValue As String, _
        ByVal WPRL_Unit_PriceValue As String, _
        ByVal WPRL_QtyValue As String, _
        ByVal WPRL_Ext_PriceValue As String, _
        ByVal WPRL_WPRLS_IDValue As String, _
        ByVal WPRL_PO_NoValue As String, _
        ByVal WPRL_PO_Line_Seq_NoValue As String, _
        ByVal WPRL_Item_Non_Inv_UOMValue As String, _
        ByVal WPRL_Vendor_NameValue As String, _
        ByVal WPRL_AccountValue As String, _
        ByVal WPRL_WClass_IDValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(WPRL_WPRD_IDValue, WPRL_WPRD_IDColumn)
        rec.SetString(WPRL_IV00101_Item_NoValue, WPRL_IV00101_Item_NoColumn)
        rec.SetString(WPRL_IV40700_Locn_CodeValue, WPRL_IV40700_Locn_CodeColumn)
        rec.SetString(WPRL_PM00200_Vendor_IDValue, WPRL_PM00200_Vendor_IDColumn)
        rec.SetString(WPRL_GL00101_Acct_IndxValue, WPRL_GL00101_Acct_IndxColumn)
        rec.SetString(WPRL_IV00101_Prchs_UOMValue, WPRL_IV00101_Prchs_UOMColumn)
        rec.SetString(WPRL_Line_Seq_NoValue, WPRL_Line_Seq_NoColumn)
        rec.SetString(WPRL_Item_CommentValue, WPRL_Item_CommentColumn)
        rec.SetString(WPRL_Item_TextValue, WPRL_Item_TextColumn)
        rec.SetString(WPRL_Item_DescValue, WPRL_Item_DescColumn)
        rec.SetString(WPRL_Item_Non_InvValue, WPRL_Item_Non_InvColumn)
        rec.SetString(WPRL_Required_DateValue, WPRL_Required_DateColumn)
        rec.SetString(WPRL_Unit_PriceValue, WPRL_Unit_PriceColumn)
        rec.SetString(WPRL_QtyValue, WPRL_QtyColumn)
        rec.SetString(WPRL_Ext_PriceValue, WPRL_Ext_PriceColumn)
        rec.SetString(WPRL_WPRLS_IDValue, WPRL_WPRLS_IDColumn)
        rec.SetString(WPRL_PO_NoValue, WPRL_PO_NoColumn)
        rec.SetString(WPRL_PO_Line_Seq_NoValue, WPRL_PO_Line_Seq_NoColumn)
        rec.SetString(WPRL_Item_Non_Inv_UOMValue, WPRL_Item_Non_Inv_UOMColumn)
        rec.SetString(WPRL_Vendor_NameValue, WPRL_Vendor_NameColumn)
        rec.SetString(WPRL_AccountValue, WPRL_AccountColumn)
        rec.SetString(WPRL_WClass_IDValue, WPRL_WClass_IDColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        WPR_LineTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            WPR_LineTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(WPR_LineTable.Instance.TableDefinition.PrimaryKey)) Then
            Return WPR_LineTable.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(WPR_LineTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = WPR_LineTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = WPR_LineTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (WPR_LineTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = WPR_LineTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = WPR_LineTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = WPR_LineTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
