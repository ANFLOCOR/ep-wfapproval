' This class is "generated" and will be overwritten.
' Your customizations should be made in WCanvass_PO_Map_TempRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ePortalWFApproval.Data

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WCanvass_PO_Map_TempTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named DatabaseANFLO-WF%dbo.WCanvass_PO_Map_Temp.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="WCanvass_PO_Map_TempTable.Instance">WCanvass_PO_Map_TempTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="WCanvass_PO_Map_TempTable"></seealso>

<Serializable()> Public Class BaseWCanvass_PO_Map_TempTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = WCanvass_PO_Map_TempDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.WCanvass_PO_Map_TempTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.WCanvass_PO_Map_TempRecord")
        Me.ApplicationName = "App_Code"
        Me.DataAdapter = New WCanvass_PO_Map_TempSqlTable()
        Directcast(Me.DataAdapter, WCanvass_PO_Map_TempSqlTable).ConnectionName = Me.ConnectionName
        
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        Temp_IDColumn.CodeName = "Temp_ID"
        WCDI_IDColumn.CodeName = "WCDI_ID"
        WCDI_WCI_IDColumn.CodeName = "WCDI_WCI_ID"
        WCDI_WPRL_IDColumn.CodeName = "WCDI_WPRL_ID"
        WCDI_StatusColumn.CodeName = "WCDI_Status"
        WCDI_Audit_CommentColumn.CodeName = "WCDI_Audit_Comment"
        WCDI_CommentColumn.CodeName = "WCDI_Comment"
        WCDI_PM00200_VendorColumn.CodeName = "WCDI_PM00200_Vendor"
        WCDI_QtyColumn.CodeName = "WCDI_Qty"
        WCDI_BidColumn.CodeName = "WCDI_Bid"
        WCDI_AwardColumn.CodeName = "WCDI_Award"
        WPRL_WPRD_IDColumn.CodeName = "WPRL_WPRD_ID"
        ItemColumn.CodeName = "Item"
        ItemDescriptionColumn.CodeName = "ItemDescription"
        UnitOfMeasureColumn.CodeName = "UnitOfMeasure"
        Site0Column.CodeName = "Site0"
        UnitPriceColumn.CodeName = "UnitPrice"
        WPRL_QtyColumn.CodeName = "WPRL_Qty"
        WPRL_Ext_PriceColumn.CodeName = "WPRL_Ext_Price"
        WCI_C_IDColumn.CodeName = "WCI_C_ID"
        WCI_StatusColumn.CodeName = "WCI_Status"
        WCI_U_IDColumn.CodeName = "WCI_U_ID"
        WCI_WClass_IDColumn.CodeName = "WCI_WClass_ID"
        WPRD_CreatedColumn.CodeName = "WPRD_Created"
        WCI_DateColumn.CodeName = "WCI_Date"
        Offered_QtyColumn.CodeName = "Offered_Qty"
        Balance_QtyColumn.CodeName = "Balance_Qty"
        WCDI_VatColumn.CodeName = "WCDI_Vat"
        WCDI_NetColumn.CodeName = "WCDI_Net"
        WCDI_WCur_IDColumn.CodeName = "WCDI_WCur_ID"
        WPRD_ContractColumn.CodeName = "WPRD_Contract"
        WCI_Contract_DoneColumn.CodeName = "WCI_Contract_Done"
        WCI_Contract_ClosedColumn.CodeName = "WCI_Contract_Closed"
        WCI_Contract_U_IDColumn.CodeName = "WCI_Contract_U_ID"
        Col_MarkerColumn.CodeName = "Col_Marker"
        StatusColumn.CodeName = "Status"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.Temp_ID column object.
    ''' </summary>
    Public ReadOnly Property Temp_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.Temp_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property Temp_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.Temp_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_ID column object.
    ''' </summary>
    Public ReadOnly Property WCDI_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCDI_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_WCI_ID column object.
    ''' </summary>
    Public ReadOnly Property WCDI_WCI_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_WCI_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_WCI_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCDI_WCI_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_WPRL_ID column object.
    ''' </summary>
    Public ReadOnly Property WCDI_WPRL_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_WPRL_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_WPRL_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCDI_WPRL_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_Status column object.
    ''' </summary>
    Public ReadOnly Property WCDI_StatusColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_Status column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Status() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCDI_StatusColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_Audit_Comment column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Audit_CommentColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_Audit_Comment column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Audit_Comment() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCDI_Audit_CommentColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_Comment column object.
    ''' </summary>
    Public ReadOnly Property WCDI_CommentColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_Comment column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Comment() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCDI_CommentColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_PM00200_Vendor column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PM00200_VendorColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_PM00200_Vendor column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PM00200_Vendor() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCDI_PM00200_VendorColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_Qty column object.
    ''' </summary>
    Public ReadOnly Property WCDI_QtyColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_Qty column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Qty() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCDI_QtyColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_Bid column object.
    ''' </summary>
    Public ReadOnly Property WCDI_BidColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_Bid column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Bid() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCDI_BidColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_Award column object.
    ''' </summary>
    Public ReadOnly Property WCDI_AwardColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_Award column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Award() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCDI_AwardColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WPRL_WPRD_ID column object.
    ''' </summary>
    Public ReadOnly Property WPRL_WPRD_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WPRL_WPRD_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_WPRD_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WPRL_WPRD_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.Item column object.
    ''' </summary>
    Public ReadOnly Property ItemColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.Item column object.
    ''' </summary>
    Public Shared ReadOnly Property Item() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.ItemColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.ItemDescription column object.
    ''' </summary>
    Public ReadOnly Property ItemDescriptionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.ItemDescription column object.
    ''' </summary>
    Public Shared ReadOnly Property ItemDescription() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.ItemDescriptionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.UnitOfMeasure column object.
    ''' </summary>
    Public ReadOnly Property UnitOfMeasureColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.UnitOfMeasure column object.
    ''' </summary>
    Public Shared ReadOnly Property UnitOfMeasure() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.UnitOfMeasureColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.Site column object.
    ''' </summary>
    Public ReadOnly Property Site0Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.Site column object.
    ''' </summary>
    Public Shared ReadOnly Property Site0() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.Site0Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.UnitPrice column object.
    ''' </summary>
    Public ReadOnly Property UnitPriceColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.UnitPrice column object.
    ''' </summary>
    Public Shared ReadOnly Property UnitPrice() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.UnitPriceColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WPRL_Qty column object.
    ''' </summary>
    Public ReadOnly Property WPRL_QtyColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WPRL_Qty column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_Qty() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WPRL_QtyColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WPRL_Ext_Price column object.
    ''' </summary>
    Public ReadOnly Property WPRL_Ext_PriceColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WPRL_Ext_Price column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRL_Ext_Price() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WPRL_Ext_PriceColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCI_C_ID column object.
    ''' </summary>
    Public ReadOnly Property WCI_C_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCI_C_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WCI_C_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCI_C_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCI_Status column object.
    ''' </summary>
    Public ReadOnly Property WCI_StatusColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCI_Status column object.
    ''' </summary>
    Public Shared ReadOnly Property WCI_Status() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCI_StatusColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCI_U_ID column object.
    ''' </summary>
    Public ReadOnly Property WCI_U_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCI_U_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WCI_U_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCI_U_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCI_WClass_ID column object.
    ''' </summary>
    Public ReadOnly Property WCI_WClass_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCI_WClass_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WCI_WClass_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCI_WClass_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WPRD_Created column object.
    ''' </summary>
    Public ReadOnly Property WPRD_CreatedColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(23), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WPRD_Created column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRD_Created() As BaseClasses.Data.DateColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WPRD_CreatedColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCI_Date column object.
    ''' </summary>
    Public ReadOnly Property WCI_DateColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(24), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCI_Date column object.
    ''' </summary>
    Public Shared ReadOnly Property WCI_Date() As BaseClasses.Data.DateColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCI_DateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.Offered_Qty column object.
    ''' </summary>
    Public ReadOnly Property Offered_QtyColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(25), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.Offered_Qty column object.
    ''' </summary>
    Public Shared ReadOnly Property Offered_Qty() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.Offered_QtyColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.Balance_Qty column object.
    ''' </summary>
    Public ReadOnly Property Balance_QtyColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(26), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.Balance_Qty column object.
    ''' </summary>
    Public Shared ReadOnly Property Balance_Qty() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.Balance_QtyColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_Vat column object.
    ''' </summary>
    Public ReadOnly Property WCDI_VatColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(27), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_Vat column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Vat() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCDI_VatColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_Net column object.
    ''' </summary>
    Public ReadOnly Property WCDI_NetColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(28), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_Net column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Net() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCDI_NetColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_WCur_ID column object.
    ''' </summary>
    Public ReadOnly Property WCDI_WCur_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(29), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCDI_WCur_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_WCur_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCDI_WCur_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WPRD_Contract column object.
    ''' </summary>
    Public ReadOnly Property WPRD_ContractColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(30), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WPRD_Contract column object.
    ''' </summary>
    Public Shared ReadOnly Property WPRD_Contract() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WPRD_ContractColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCI_Contract_Done column object.
    ''' </summary>
    Public ReadOnly Property WCI_Contract_DoneColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(31), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCI_Contract_Done column object.
    ''' </summary>
    Public Shared ReadOnly Property WCI_Contract_Done() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCI_Contract_DoneColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCI_Contract_Closed column object.
    ''' </summary>
    Public ReadOnly Property WCI_Contract_ClosedColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(32), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCI_Contract_Closed column object.
    ''' </summary>
    Public Shared ReadOnly Property WCI_Contract_Closed() As BaseClasses.Data.DateColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCI_Contract_ClosedColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCI_Contract_U_ID column object.
    ''' </summary>
    Public ReadOnly Property WCI_Contract_U_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(33), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.WCI_Contract_U_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WCI_Contract_U_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.WCI_Contract_U_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.Col_Marker column object.
    ''' </summary>
    Public ReadOnly Property Col_MarkerColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(34), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.Col_Marker column object.
    ''' </summary>
    Public Shared ReadOnly Property Col_Marker() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.Col_MarkerColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.Status column object.
    ''' </summary>
    Public ReadOnly Property StatusColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(35), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_PO_Map_Temp_.Status column object.
    ''' </summary>
    Public Shared ReadOnly Property Status() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_PO_Map_TempTable.Instance.StatusColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCanvass_PO_Map_TempRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As WCanvass_PO_Map_TempRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCanvass_PO_Map_TempRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As WCanvass_PO_Map_TempRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCanvass_PO_Map_TempRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WCanvass_PO_Map_TempRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCanvass_PO_Map_TempRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WCanvass_PO_Map_TempRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCanvass_PO_Map_TempRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WCanvass_PO_Map_TempRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  WCanvass_PO_Map_TempTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WCanvass_PO_Map_TempRecord)), WCanvass_PO_Map_TempRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCanvass_PO_Map_TempRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WCanvass_PO_Map_TempRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  WCanvass_PO_Map_TempTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WCanvass_PO_Map_TempRecord)), WCanvass_PO_Map_TempRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WCanvass_PO_Map_TempRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WCanvass_PO_Map_TempTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WCanvass_PO_Map_TempRecord)), WCanvass_PO_Map_TempRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WCanvass_PO_Map_TempRecord()

        Dim recList As ArrayList = WCanvass_PO_Map_TempTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WCanvass_PO_Map_TempRecord)), WCanvass_PO_Map_TempRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As WCanvass_PO_Map_TempRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WCanvass_PO_Map_TempTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WCanvass_PO_Map_TempRecord)), WCanvass_PO_Map_TempRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As WCanvass_PO_Map_TempRecord()

        Dim recList As ArrayList = WCanvass_PO_Map_TempTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WCanvass_PO_Map_TempRecord)), WCanvass_PO_Map_TempRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function PostGetRecordCount(ByVal selectCols As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal finalFilter As BaseFilter) As Integer
	      Return CInt(WCanvass_PO_Map_TempTable.Instance.GetCountResponseForPost(WCanvass_PO_Map_TempTable.Instance.TableDefinition, selectCols, join, finalFilter))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCanvass_PO_Map_TempRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function PostGetRecordList(ByVal requestedSelection As SqlBuilderColumnSelection, ByVal workingSelection As SqlBuilderColumnSelection, _
		ByVal distinctSelection As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal filter As BaseFilter, ByVal groupBy As GroupBy, _
	    ByVal sortOrder As OrderBy, ByVal startIndex As Integer, ByVal count As Integer, ByRef totalCount As Integer, ByVal fromDataSource As [Boolean], _
	    Optional ByVal table As KeylessVirtualTable = Nothing, Optional isGetColumnValues As Boolean = False) As ArrayList
	      
		Dim recList As ArrayList = Nothing
		If IsNothing(table) Then
			recList = WCanvass_PO_Map_TempTable.Instance.GetRecordListResponseForPost(WCanvass_PO_Map_TempTable.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection, join, filter, _
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

        Return CInt(WCanvass_PO_Map_TempTable.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(WCanvass_PO_Map_TempTable.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(WCanvass_PO_Map_TempTable.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(WCanvass_PO_Map_TempTable.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WCanvass_PO_Map_TempRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As WCanvass_PO_Map_TempRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WCanvass_PO_Map_TempRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As WCanvass_PO_Map_TempRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WCanvass_PO_Map_TempRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WCanvass_PO_Map_TempRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WCanvass_PO_Map_TempTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As WCanvass_PO_Map_TempRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), WCanvass_PO_Map_TempRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WCanvass_PO_Map_TempRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WCanvass_PO_Map_TempRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = WCanvass_PO_Map_TempTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As WCanvass_PO_Map_TempRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), WCanvass_PO_Map_TempRecord)
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

        Return WCanvass_PO_Map_TempTable.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return WCanvass_PO_Map_TempTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As WCanvass_PO_Map_TempRecord = GetRecords(where)
        Return WCanvass_PO_Map_TempTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As WCanvass_PO_Map_TempRecord = GetRecords(join, where)
        Return WCanvass_PO_Map_TempTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As WCanvass_PO_Map_TempRecord = GetRecords(where, orderBy)
        Return WCanvass_PO_Map_TempTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As WCanvass_PO_Map_TempRecord = GetRecords(join, where, orderBy)
        Return WCanvass_PO_Map_TempTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As WCanvass_PO_Map_TempRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return WCanvass_PO_Map_TempTable.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As WCanvass_PO_Map_TempRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return WCanvass_PO_Map_TempTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        WCanvass_PO_Map_TempTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return WCanvass_PO_Map_TempTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return WCanvass_PO_Map_TempTable.Instance.ExportRecordData(whereFilter)
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

        Return WCanvass_PO_Map_TempTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WCanvass_PO_Map_TempTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WCanvass_PO_Map_TempTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WCanvass_PO_Map_TempTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return WCanvass_PO_Map_TempTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return WCanvass_PO_Map_TempTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return WCanvass_PO_Map_TempTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return WCanvass_PO_Map_TempTable.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = WCanvass_PO_Map_TempTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     


    ''' <summary>
    ''' This method gets the specified column.
    ''' </summary>
    ''' <param name="name">name of the column to fetch.</param>
    Public Shared Function GetColumnByName(ByVal name As String) As BaseColumn
        Dim column As BaseColumn = WCanvass_PO_Map_TempTable.Instance.TableDefinition.ColumnList.GetByInternalName(name)
        Return column
    End Function       
        

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As WCanvass_PO_Map_TempRecord
        Return CType(WCanvass_PO_Map_TempTable.Instance.GetRecordData(id, bMutable), WCanvass_PO_Map_TempRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As WCanvass_PO_Map_TempRecord
        Return CType(WCanvass_PO_Map_TempTable.Instance.GetRecordData(id, bMutable), WCanvass_PO_Map_TempRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal WCDI_IDValue As String, _
        ByVal WCDI_WCI_IDValue As String, _
        ByVal WCDI_WPRL_IDValue As String, _
        ByVal WCDI_StatusValue As String, _
        ByVal WCDI_Audit_CommentValue As String, _
        ByVal WCDI_CommentValue As String, _
        ByVal WCDI_PM00200_VendorValue As String, _
        ByVal WCDI_QtyValue As String, _
        ByVal WCDI_BidValue As String, _
        ByVal WCDI_AwardValue As String, _
        ByVal WPRL_WPRD_IDValue As String, _
        ByVal ItemValue As String, _
        ByVal ItemDescriptionValue As String, _
        ByVal UnitOfMeasureValue As String, _
        ByVal Site0Value As String, _
        ByVal UnitPriceValue As String, _
        ByVal WPRL_QtyValue As String, _
        ByVal WPRL_Ext_PriceValue As String, _
        ByVal WCI_C_IDValue As String, _
        ByVal WCI_StatusValue As String, _
        ByVal WCI_U_IDValue As String, _
        ByVal WCI_WClass_IDValue As String, _
        ByVal WPRD_CreatedValue As String, _
        ByVal WCI_DateValue As String, _
        ByVal Offered_QtyValue As String, _
        ByVal Balance_QtyValue As String, _
        ByVal WCDI_VatValue As String, _
        ByVal WCDI_NetValue As String, _
        ByVal WCDI_WCur_IDValue As String, _
        ByVal WPRD_ContractValue As String, _
        ByVal WCI_Contract_DoneValue As String, _
        ByVal WCI_Contract_ClosedValue As String, _
        ByVal WCI_Contract_U_IDValue As String, _
        ByVal Col_MarkerValue As String, _
        ByVal StatusValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(WCDI_IDValue, WCDI_IDColumn)
        rec.SetString(WCDI_WCI_IDValue, WCDI_WCI_IDColumn)
        rec.SetString(WCDI_WPRL_IDValue, WCDI_WPRL_IDColumn)
        rec.SetString(WCDI_StatusValue, WCDI_StatusColumn)
        rec.SetString(WCDI_Audit_CommentValue, WCDI_Audit_CommentColumn)
        rec.SetString(WCDI_CommentValue, WCDI_CommentColumn)
        rec.SetString(WCDI_PM00200_VendorValue, WCDI_PM00200_VendorColumn)
        rec.SetString(WCDI_QtyValue, WCDI_QtyColumn)
        rec.SetString(WCDI_BidValue, WCDI_BidColumn)
        rec.SetString(WCDI_AwardValue, WCDI_AwardColumn)
        rec.SetString(WPRL_WPRD_IDValue, WPRL_WPRD_IDColumn)
        rec.SetString(ItemValue, ItemColumn)
        rec.SetString(ItemDescriptionValue, ItemDescriptionColumn)
        rec.SetString(UnitOfMeasureValue, UnitOfMeasureColumn)
        rec.SetString(Site0Value, Site0Column)
        rec.SetString(UnitPriceValue, UnitPriceColumn)
        rec.SetString(WPRL_QtyValue, WPRL_QtyColumn)
        rec.SetString(WPRL_Ext_PriceValue, WPRL_Ext_PriceColumn)
        rec.SetString(WCI_C_IDValue, WCI_C_IDColumn)
        rec.SetString(WCI_StatusValue, WCI_StatusColumn)
        rec.SetString(WCI_U_IDValue, WCI_U_IDColumn)
        rec.SetString(WCI_WClass_IDValue, WCI_WClass_IDColumn)
        rec.SetString(WPRD_CreatedValue, WPRD_CreatedColumn)
        rec.SetString(WCI_DateValue, WCI_DateColumn)
        rec.SetString(Offered_QtyValue, Offered_QtyColumn)
        rec.SetString(Balance_QtyValue, Balance_QtyColumn)
        rec.SetString(WCDI_VatValue, WCDI_VatColumn)
        rec.SetString(WCDI_NetValue, WCDI_NetColumn)
        rec.SetString(WCDI_WCur_IDValue, WCDI_WCur_IDColumn)
        rec.SetString(WPRD_ContractValue, WPRD_ContractColumn)
        rec.SetString(WCI_Contract_DoneValue, WCI_Contract_DoneColumn)
        rec.SetString(WCI_Contract_ClosedValue, WCI_Contract_ClosedColumn)
        rec.SetString(WCI_Contract_U_IDValue, WCI_Contract_U_IDColumn)
        rec.SetString(Col_MarkerValue, Col_MarkerColumn)
        rec.SetString(StatusValue, StatusColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        WCanvass_PO_Map_TempTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            WCanvass_PO_Map_TempTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(WCanvass_PO_Map_TempTable.Instance.TableDefinition.PrimaryKey)) Then
            Return WCanvass_PO_Map_TempTable.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(WCanvass_PO_Map_TempTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = WCanvass_PO_Map_TempTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = WCanvass_PO_Map_TempTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (WCanvass_PO_Map_TempTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = WCanvass_PO_Map_TempTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = WCanvass_PO_Map_TempTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = WCanvass_PO_Map_TempTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
