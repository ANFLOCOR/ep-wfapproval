' This class is "generated" and will be overwritten.
' Your customizations should be made in WCanvass_Detail_InternalRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ePortalWFApproval.Data

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WCanvass_Detail_InternalTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named DatabaseANFLO-WF%dbo.WCanvass_Detail_Internal.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="WCanvass_Detail_InternalTable.Instance">WCanvass_Detail_InternalTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="WCanvass_Detail_InternalTable"></seealso>

<Serializable()> Public Class BaseWCanvass_Detail_InternalTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = WCanvass_Detail_InternalDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.WCanvass_Detail_InternalTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.WCanvass_Detail_InternalRecord")
        Me.ApplicationName = "App_Code"
        Me.DataAdapter = New WCanvass_Detail_InternalSqlTable()
        Directcast(Me.DataAdapter, WCanvass_Detail_InternalSqlTable).ConnectionName = Me.ConnectionName
        
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        WCDI_IDColumn.CodeName = "WCDI_ID"
        WCDI_WCI_IDColumn.CodeName = "WCDI_WCI_ID"
        WCDI_WPRL_IDColumn.CodeName = "WCDI_WPRL_ID"
        WCDI_PM00200_Vendor_ID1Column.CodeName = "WCDI_PM00200_Vendor_ID1"
        WCDI_PM00200_Vendor_ID2Column.CodeName = "WCDI_PM00200_Vendor_ID2"
        WCDI_PM00200_Vendor_ID3Column.CodeName = "WCDI_PM00200_Vendor_ID3"
        WCDI_PM00200_Vendor_ID4Column.CodeName = "WCDI_PM00200_Vendor_ID4"
        WCDI_PM00200_Vendor_ID5Column.CodeName = "WCDI_PM00200_Vendor_ID5"
        WCDI_PM00200_Vendor_ID6Column.CodeName = "WCDI_PM00200_Vendor_ID6"
        WCDI_Bid1Column.CodeName = "WCDI_Bid1"
        WCDI_Bid2Column.CodeName = "WCDI_Bid2"
        WCDI_Bid3Column.CodeName = "WCDI_Bid3"
        WCDI_Bid4Column.CodeName = "WCDI_Bid4"
        WCDI_Bid5Column.CodeName = "WCDI_Bid5"
        WCDI_Bid6Column.CodeName = "WCDI_Bid6"
        WCDI_Award1Column.CodeName = "WCDI_Award1"
        WCDI_Award2Column.CodeName = "WCDI_Award2"
        WCDI_Award3Column.CodeName = "WCDI_Award3"
        WCDI_Award4Column.CodeName = "WCDI_Award4"
        WCDI_Award5Column.CodeName = "WCDI_Award5"
        WCDI_Award6Column.CodeName = "WCDI_Award6"
        WCDI_StatusColumn.CodeName = "WCDI_Status"
        WCDI_Audit_CommentColumn.CodeName = "WCDI_Audit_Comment"
        WCDI_CommentColumn.CodeName = "WCDI_Comment"
        WCDI_PM00200_Vendor_ID7Column.CodeName = "WCDI_PM00200_Vendor_ID7"
        WCDI_PM00200_Vendor_ID8Column.CodeName = "WCDI_PM00200_Vendor_ID8"
        WCDI_PM00200_Vendor_ID9Column.CodeName = "WCDI_PM00200_Vendor_ID9"
        WCDI_PM00200_Vendor_ID10Column.CodeName = "WCDI_PM00200_Vendor_ID10"
        WCDI_Bid7Column.CodeName = "WCDI_Bid7"
        WCDI_Bid8Column.CodeName = "WCDI_Bid8"
        WCDI_Bid9Column.CodeName = "WCDI_Bid9"
        WCDI_Bid10Column.CodeName = "WCDI_Bid10"
        WCDI_Award7Column.CodeName = "WCDI_Award7"
        WCDI_Award8Column.CodeName = "WCDI_Award8"
        WCDI_Award9Column.CodeName = "WCDI_Award9"
        WCDI_Award10Column.CodeName = "WCDI_Award10"
        WCDI_Qty1Column.CodeName = "WCDI_Qty1"
        WCDI_Qty2Column.CodeName = "WCDI_Qty2"
        WCDI_Qty3Column.CodeName = "WCDI_Qty3"
        WCDI_Qty4Column.CodeName = "WCDI_Qty4"
        WCDI_Qty5Column.CodeName = "WCDI_Qty5"
        WCDI_Qty6Column.CodeName = "WCDI_Qty6"
        WCDI_Qty7Column.CodeName = "WCDI_Qty7"
        WCDI_Qty8Column.CodeName = "WCDI_Qty8"
        WCDI_Qty9Column.CodeName = "WCDI_Qty9"
        WCDI_Qty10Column.CodeName = "WCDI_Qty10"
        WCDI_PO1Column.CodeName = "WCDI_PO1"
        WCDI_PO2Column.CodeName = "WCDI_PO2"
        WCDI_PO3Column.CodeName = "WCDI_PO3"
        WCDI_PO4Column.CodeName = "WCDI_PO4"
        WCDI_PO5Column.CodeName = "WCDI_PO5"
        WCDI_PO6Column.CodeName = "WCDI_PO6"
        WCDI_PO7Column.CodeName = "WCDI_PO7"
        WCDI_PO8Column.CodeName = "WCDI_PO8"
        WCDI_PO9Column.CodeName = "WCDI_PO9"
        WCDI_PO10Column.CodeName = "WCDI_PO10"
        WCDI_Aw1Column.CodeName = "WCDI_Aw1"
        WCDI_Aw2Column.CodeName = "WCDI_Aw2"
        WCDI_Aw3Column.CodeName = "WCDI_Aw3"
        WCDI_Aw4Column.CodeName = "WCDI_Aw4"
        WCDI_Aw5Column.CodeName = "WCDI_Aw5"
        WCDI_Aw6Column.CodeName = "WCDI_Aw6"
        WCDI_Aw7Column.CodeName = "WCDI_Aw7"
        WCDI_Aw8Column.CodeName = "WCDI_Aw8"
        WCDI_Aw9Column.CodeName = "WCDI_Aw9"
        WCDI_Aw10Column.CodeName = "WCDI_Aw10"
        WCDI_Vat1Column.CodeName = "WCDI_Vat1"
        WCDI_Vat2Column.CodeName = "WCDI_Vat2"
        WCDI_Vat3Column.CodeName = "WCDI_Vat3"
        WCDI_Vat4Column.CodeName = "WCDI_Vat4"
        WCDI_Vat5Column.CodeName = "WCDI_Vat5"
        WCDI_Vat6Column.CodeName = "WCDI_Vat6"
        WCDI_Vat7Column.CodeName = "WCDI_Vat7"
        WCDI_Vat8Column.CodeName = "WCDI_Vat8"
        WCDI_Vat9Column.CodeName = "WCDI_Vat9"
        WCDI_Vat10Column.CodeName = "WCDI_Vat10"
        WCDI_Net1Column.CodeName = "WCDI_Net1"
        WCDI_Net2Column.CodeName = "WCDI_Net2"
        WCDI_Net3Column.CodeName = "WCDI_Net3"
        WCDI_Net4Column.CodeName = "WCDI_Net4"
        WCDI_Net5Column.CodeName = "WCDI_Net5"
        WCDI_Net6Column.CodeName = "WCDI_Net6"
        WCDI_Net7Column.CodeName = "WCDI_Net7"
        WCDI_Net8Column.CodeName = "WCDI_Net8"
        WCDI_Net9Column.CodeName = "WCDI_Net9"
        WCDI_Net10Column.CodeName = "WCDI_Net10"
        WCDI_WCur_ID1Column.CodeName = "WCDI_WCur_ID1"
        WCDI_WCur_ID2Column.CodeName = "WCDI_WCur_ID2"
        WCDI_WCur_ID3Column.CodeName = "WCDI_WCur_ID3"
        WCDI_WCur_ID4Column.CodeName = "WCDI_WCur_ID4"
        WCDI_WCur_ID5Column.CodeName = "WCDI_WCur_ID5"
        WCDI_WCur_ID6Column.CodeName = "WCDI_WCur_ID6"
        WCDI_WCur_ID7Column.CodeName = "WCDI_WCur_ID7"
        WCDI_WCur_ID8Column.CodeName = "WCDI_WCur_ID8"
        WCDI_WCur_ID9Column.CodeName = "WCDI_WCur_ID9"
        WCDI_WCur_ID10Column.CodeName = "WCDI_WCur_ID10"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_ID column object.
    ''' </summary>
    Public ReadOnly Property WCDI_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCI_ID column object.
    ''' </summary>
    Public ReadOnly Property WCDI_WCI_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCI_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_WCI_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_WCI_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WPRL_ID column object.
    ''' </summary>
    Public ReadOnly Property WCDI_WPRL_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WPRL_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_WPRL_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_WPRL_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID1 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID1Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID1 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PM00200_Vendor_ID1() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PM00200_Vendor_ID1Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID2 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID2Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID2 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PM00200_Vendor_ID2() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PM00200_Vendor_ID2Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID3 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID3Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID3 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PM00200_Vendor_ID3() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PM00200_Vendor_ID3Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID4 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID4Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID4 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PM00200_Vendor_ID4() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PM00200_Vendor_ID4Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID5 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID5Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID5 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PM00200_Vendor_ID5() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PM00200_Vendor_ID5Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID6 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID6Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID6 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PM00200_Vendor_ID6() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PM00200_Vendor_ID6Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid1 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Bid1Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid1 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Bid1() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Bid1Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid2 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Bid2Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid2 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Bid2() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Bid2Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid3 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Bid3Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid3 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Bid3() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Bid3Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid4 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Bid4Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid4 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Bid4() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Bid4Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid5 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Bid5Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid5 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Bid5() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Bid5Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid6 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Bid6Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid6 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Bid6() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Bid6Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award1 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Award1Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award1 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Award1() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Award1Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award2 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Award2Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award2 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Award2() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Award2Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award3 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Award3Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award3 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Award3() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Award3Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award4 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Award4Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award4 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Award4() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Award4Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award5 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Award5Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award5 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Award5() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Award5Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award6 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Award6Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award6 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Award6() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Award6Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Status column object.
    ''' </summary>
    Public ReadOnly Property WCDI_StatusColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Status column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Status() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_StatusColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Audit_Comment column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Audit_CommentColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Audit_Comment column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Audit_Comment() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Audit_CommentColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Comment column object.
    ''' </summary>
    Public ReadOnly Property WCDI_CommentColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(23), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Comment column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Comment() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_CommentColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID7 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID7Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(24), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID7 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PM00200_Vendor_ID7() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PM00200_Vendor_ID7Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID8 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID8Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(25), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID8 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PM00200_Vendor_ID8() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PM00200_Vendor_ID8Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID9 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID9Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(26), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID9 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PM00200_Vendor_ID9() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PM00200_Vendor_ID9Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID10 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID10Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(27), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID10 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PM00200_Vendor_ID10() As BaseClasses.Data.StringColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PM00200_Vendor_ID10Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid7 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Bid7Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(28), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid7 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Bid7() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Bid7Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid8 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Bid8Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(29), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid8 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Bid8() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Bid8Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid9 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Bid9Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(30), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid9 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Bid9() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Bid9Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid10 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Bid10Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(31), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Bid10 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Bid10() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Bid10Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award7 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Award7Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(32), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award7 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Award7() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Award7Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award8 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Award8Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(33), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award8 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Award8() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Award8Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award9 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Award9Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(34), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award9 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Award9() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Award9Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award10 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Award10Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(35), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Award10 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Award10() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Award10Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty1 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Qty1Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(36), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty1 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Qty1() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Qty1Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty2 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Qty2Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(37), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty2 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Qty2() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Qty2Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty3 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Qty3Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(38), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty3 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Qty3() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Qty3Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty4 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Qty4Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(39), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty4 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Qty4() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Qty4Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty5 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Qty5Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(40), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty5 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Qty5() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Qty5Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty6 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Qty6Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(41), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty6 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Qty6() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Qty6Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty7 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Qty7Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(42), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty7 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Qty7() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Qty7Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty8 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Qty8Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(43), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty8 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Qty8() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Qty8Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty9 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Qty9Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(44), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty9 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Qty9() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Qty9Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty10 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Qty10Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(45), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Qty10 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Qty10() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Qty10Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO1 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PO1Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(46), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO1 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PO1() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PO1Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO2 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PO2Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(47), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO2 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PO2() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PO2Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO3 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PO3Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(48), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO3 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PO3() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PO3Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO4 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PO4Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(49), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO4 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PO4() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PO4Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO5 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PO5Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(50), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO5 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PO5() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PO5Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO6 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PO6Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(51), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO6 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PO6() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PO6Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO7 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PO7Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(52), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO7 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PO7() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PO7Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO8 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PO8Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(53), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO8 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PO8() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PO8Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO9 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PO9Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(54), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO9 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PO9() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PO9Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO10 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_PO10Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(55), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_PO10 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_PO10() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_PO10Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw1 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Aw1Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(56), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw1 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Aw1() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Aw1Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw2 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Aw2Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(57), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw2 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Aw2() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Aw2Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw3 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Aw3Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(58), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw3 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Aw3() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Aw3Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw4 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Aw4Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(59), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw4 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Aw4() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Aw4Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw5 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Aw5Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(60), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw5 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Aw5() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Aw5Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw6 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Aw6Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(61), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw6 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Aw6() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Aw6Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw7 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Aw7Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(62), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw7 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Aw7() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Aw7Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw8 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Aw8Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(63), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw8 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Aw8() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Aw8Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw9 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Aw9Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(64), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw9 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Aw9() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Aw9Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw10 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Aw10Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(65), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Aw10 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Aw10() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Aw10Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat1 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Vat1Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(66), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat1 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Vat1() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Vat1Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat2 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Vat2Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(67), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat2 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Vat2() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Vat2Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat3 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Vat3Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(68), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat3 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Vat3() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Vat3Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat4 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Vat4Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(69), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat4 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Vat4() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Vat4Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat5 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Vat5Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(70), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat5 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Vat5() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Vat5Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat6 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Vat6Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(71), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat6 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Vat6() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Vat6Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat7 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Vat7Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(72), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat7 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Vat7() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Vat7Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat8 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Vat8Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(73), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat8 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Vat8() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Vat8Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat9 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Vat9Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(74), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat9 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Vat9() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Vat9Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat10 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Vat10Column() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(75), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Vat10 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Vat10() As BaseClasses.Data.BooleanColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Vat10Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net1 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Net1Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(76), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net1 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Net1() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Net1Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net2 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Net2Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(77), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net2 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Net2() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Net2Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net3 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Net3Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(78), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net3 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Net3() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Net3Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net4 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Net4Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(79), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net4 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Net4() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Net4Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net5 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Net5Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(80), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net5 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Net5() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Net5Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net6 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Net6Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(81), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net6 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Net6() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Net6Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net7 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Net7Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(82), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net7 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Net7() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Net7Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net8 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Net8Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(83), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net8 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Net8() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Net8Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net9 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Net9Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(84), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net9 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Net9() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Net9Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net10 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_Net10Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(85), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_Net10 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_Net10() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_Net10Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID1 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_WCur_ID1Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(86), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID1 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_WCur_ID1() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_WCur_ID1Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID2 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_WCur_ID2Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(87), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID2 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_WCur_ID2() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_WCur_ID2Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID3 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_WCur_ID3Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(88), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID3 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_WCur_ID3() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_WCur_ID3Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID4 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_WCur_ID4Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(89), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID4 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_WCur_ID4() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_WCur_ID4Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID5 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_WCur_ID5Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(90), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID5 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_WCur_ID5() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_WCur_ID5Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID6 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_WCur_ID6Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(91), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID6 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_WCur_ID6() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_WCur_ID6Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID7 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_WCur_ID7Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(92), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID7 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_WCur_ID7() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_WCur_ID7Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID8 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_WCur_ID8Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(93), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID8 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_WCur_ID8() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_WCur_ID8Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID9 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_WCur_ID9Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(94), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID9 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_WCur_ID9() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_WCur_ID9Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID10 column object.
    ''' </summary>
    Public ReadOnly Property WCDI_WCur_ID10Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(95), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCanvass_Detail_Internal_.WCDI_WCur_ID10 column object.
    ''' </summary>
    Public Shared ReadOnly Property WCDI_WCur_ID10() As BaseClasses.Data.NumberColumn
        Get
            Return WCanvass_Detail_InternalTable.Instance.WCDI_WCur_ID10Column
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCanvass_Detail_InternalRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As WCanvass_Detail_InternalRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCanvass_Detail_InternalRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As WCanvass_Detail_InternalRecord()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCanvass_Detail_InternalRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WCanvass_Detail_InternalRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCanvass_Detail_InternalRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WCanvass_Detail_InternalRecord()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCanvass_Detail_InternalRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WCanvass_Detail_InternalRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  WCanvass_Detail_InternalTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WCanvass_Detail_InternalRecord)), WCanvass_Detail_InternalRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCanvass_Detail_InternalRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WCanvass_Detail_InternalRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  WCanvass_Detail_InternalTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WCanvass_Detail_InternalRecord)), WCanvass_Detail_InternalRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WCanvass_Detail_InternalRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WCanvass_Detail_InternalTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WCanvass_Detail_InternalRecord)), WCanvass_Detail_InternalRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WCanvass_Detail_InternalRecord()

        Dim recList As ArrayList = WCanvass_Detail_InternalTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WCanvass_Detail_InternalRecord)), WCanvass_Detail_InternalRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As WCanvass_Detail_InternalRecord()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WCanvass_Detail_InternalTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WCanvass_Detail_InternalRecord)), WCanvass_Detail_InternalRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As WCanvass_Detail_InternalRecord()

        Dim recList As ArrayList = WCanvass_Detail_InternalTable.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WCanvass_Detail_InternalRecord)), WCanvass_Detail_InternalRecord())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function PostGetRecordCount(ByVal selectCols As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal finalFilter As BaseFilter) As Integer
	      Return CInt(WCanvass_Detail_InternalTable.Instance.GetCountResponseForPost(WCanvass_Detail_InternalTable.Instance.TableDefinition, selectCols, join, finalFilter))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCanvass_Detail_InternalRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function PostGetRecordList(ByVal requestedSelection As SqlBuilderColumnSelection, ByVal workingSelection As SqlBuilderColumnSelection, _
		ByVal distinctSelection As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal filter As BaseFilter, ByVal groupBy As GroupBy, _
	    ByVal sortOrder As OrderBy, ByVal startIndex As Integer, ByVal count As Integer, ByRef totalCount As Integer, ByVal fromDataSource As [Boolean], _
	    Optional ByVal table As KeylessVirtualTable = Nothing, Optional isGetColumnValues As Boolean = False) As ArrayList
	      
		Dim recList As ArrayList = Nothing
		If IsNothing(table) Then
			recList = WCanvass_Detail_InternalTable.Instance.GetRecordListResponseForPost(WCanvass_Detail_InternalTable.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection, join, filter, _
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

        Return CInt(WCanvass_Detail_InternalTable.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(WCanvass_Detail_InternalTable.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(WCanvass_Detail_InternalTable.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(WCanvass_Detail_InternalTable.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WCanvass_Detail_InternalRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As WCanvass_Detail_InternalRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WCanvass_Detail_InternalRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As WCanvass_Detail_InternalRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WCanvass_Detail_InternalRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WCanvass_Detail_InternalRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WCanvass_Detail_InternalTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As WCanvass_Detail_InternalRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), WCanvass_Detail_InternalRecord)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WCanvass_Detail_InternalRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WCanvass_Detail_InternalRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = WCanvass_Detail_InternalTable.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As WCanvass_Detail_InternalRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), WCanvass_Detail_InternalRecord)
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

        Return WCanvass_Detail_InternalTable.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return WCanvass_Detail_InternalTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As WCanvass_Detail_InternalRecord = GetRecords(where)
        Return WCanvass_Detail_InternalTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As WCanvass_Detail_InternalRecord = GetRecords(join, where)
        Return WCanvass_Detail_InternalTable.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As WCanvass_Detail_InternalRecord = GetRecords(where, orderBy)
        Return WCanvass_Detail_InternalTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As WCanvass_Detail_InternalRecord = GetRecords(join, where, orderBy)
        Return WCanvass_Detail_InternalTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As WCanvass_Detail_InternalRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return WCanvass_Detail_InternalTable.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As WCanvass_Detail_InternalRecord = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return WCanvass_Detail_InternalTable.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        WCanvass_Detail_InternalTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return WCanvass_Detail_InternalTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return WCanvass_Detail_InternalTable.Instance.ExportRecordData(whereFilter)
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

        Return WCanvass_Detail_InternalTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WCanvass_Detail_InternalTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WCanvass_Detail_InternalTable.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WCanvass_Detail_InternalTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return WCanvass_Detail_InternalTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return WCanvass_Detail_InternalTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return WCanvass_Detail_InternalTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return WCanvass_Detail_InternalTable.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = WCanvass_Detail_InternalTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     


    ''' <summary>
    ''' This method gets the specified column.
    ''' </summary>
    ''' <param name="name">name of the column to fetch.</param>
    Public Shared Function GetColumnByName(ByVal name As String) As BaseColumn
        Dim column As BaseColumn = WCanvass_Detail_InternalTable.Instance.TableDefinition.ColumnList.GetByInternalName(name)
        Return column
    End Function       
        

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As WCanvass_Detail_InternalRecord
        Return CType(WCanvass_Detail_InternalTable.Instance.GetRecordData(id, bMutable), WCanvass_Detail_InternalRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As WCanvass_Detail_InternalRecord
        Return CType(WCanvass_Detail_InternalTable.Instance.GetRecordData(id, bMutable), WCanvass_Detail_InternalRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal WCDI_WCI_IDValue As String, _
        ByVal WCDI_WPRL_IDValue As String, _
        ByVal WCDI_PM00200_Vendor_ID1Value As String, _
        ByVal WCDI_PM00200_Vendor_ID2Value As String, _
        ByVal WCDI_PM00200_Vendor_ID3Value As String, _
        ByVal WCDI_PM00200_Vendor_ID4Value As String, _
        ByVal WCDI_PM00200_Vendor_ID5Value As String, _
        ByVal WCDI_PM00200_Vendor_ID6Value As String, _
        ByVal WCDI_Bid1Value As String, _
        ByVal WCDI_Bid2Value As String, _
        ByVal WCDI_Bid3Value As String, _
        ByVal WCDI_Bid4Value As String, _
        ByVal WCDI_Bid5Value As String, _
        ByVal WCDI_Bid6Value As String, _
        ByVal WCDI_Award1Value As String, _
        ByVal WCDI_Award2Value As String, _
        ByVal WCDI_Award3Value As String, _
        ByVal WCDI_Award4Value As String, _
        ByVal WCDI_Award5Value As String, _
        ByVal WCDI_Award6Value As String, _
        ByVal WCDI_StatusValue As String, _
        ByVal WCDI_Audit_CommentValue As String, _
        ByVal WCDI_CommentValue As String, _
        ByVal WCDI_PM00200_Vendor_ID7Value As String, _
        ByVal WCDI_PM00200_Vendor_ID8Value As String, _
        ByVal WCDI_PM00200_Vendor_ID9Value As String, _
        ByVal WCDI_PM00200_Vendor_ID10Value As String, _
        ByVal WCDI_Bid7Value As String, _
        ByVal WCDI_Bid8Value As String, _
        ByVal WCDI_Bid9Value As String, _
        ByVal WCDI_Bid10Value As String, _
        ByVal WCDI_Award7Value As String, _
        ByVal WCDI_Award8Value As String, _
        ByVal WCDI_Award9Value As String, _
        ByVal WCDI_Award10Value As String, _
        ByVal WCDI_Qty1Value As String, _
        ByVal WCDI_Qty2Value As String, _
        ByVal WCDI_Qty3Value As String, _
        ByVal WCDI_Qty4Value As String, _
        ByVal WCDI_Qty5Value As String, _
        ByVal WCDI_Qty6Value As String, _
        ByVal WCDI_Qty7Value As String, _
        ByVal WCDI_Qty8Value As String, _
        ByVal WCDI_Qty9Value As String, _
        ByVal WCDI_Qty10Value As String, _
        ByVal WCDI_PO1Value As String, _
        ByVal WCDI_PO2Value As String, _
        ByVal WCDI_PO3Value As String, _
        ByVal WCDI_PO4Value As String, _
        ByVal WCDI_PO5Value As String, _
        ByVal WCDI_PO6Value As String, _
        ByVal WCDI_PO7Value As String, _
        ByVal WCDI_PO8Value As String, _
        ByVal WCDI_PO9Value As String, _
        ByVal WCDI_PO10Value As String, _
        ByVal WCDI_Aw1Value As String, _
        ByVal WCDI_Aw2Value As String, _
        ByVal WCDI_Aw3Value As String, _
        ByVal WCDI_Aw4Value As String, _
        ByVal WCDI_Aw5Value As String, _
        ByVal WCDI_Aw6Value As String, _
        ByVal WCDI_Aw7Value As String, _
        ByVal WCDI_Aw8Value As String, _
        ByVal WCDI_Aw9Value As String, _
        ByVal WCDI_Aw10Value As String, _
        ByVal WCDI_Vat1Value As String, _
        ByVal WCDI_Vat2Value As String, _
        ByVal WCDI_Vat3Value As String, _
        ByVal WCDI_Vat4Value As String, _
        ByVal WCDI_Vat5Value As String, _
        ByVal WCDI_Vat6Value As String, _
        ByVal WCDI_Vat7Value As String, _
        ByVal WCDI_Vat8Value As String, _
        ByVal WCDI_Vat9Value As String, _
        ByVal WCDI_Vat10Value As String, _
        ByVal WCDI_Net1Value As String, _
        ByVal WCDI_Net2Value As String, _
        ByVal WCDI_Net3Value As String, _
        ByVal WCDI_Net4Value As String, _
        ByVal WCDI_Net5Value As String, _
        ByVal WCDI_Net6Value As String, _
        ByVal WCDI_Net7Value As String, _
        ByVal WCDI_Net8Value As String, _
        ByVal WCDI_Net9Value As String, _
        ByVal WCDI_Net10Value As String, _
        ByVal WCDI_WCur_ID1Value As String, _
        ByVal WCDI_WCur_ID2Value As String, _
        ByVal WCDI_WCur_ID3Value As String, _
        ByVal WCDI_WCur_ID4Value As String, _
        ByVal WCDI_WCur_ID5Value As String, _
        ByVal WCDI_WCur_ID6Value As String, _
        ByVal WCDI_WCur_ID7Value As String, _
        ByVal WCDI_WCur_ID8Value As String, _
        ByVal WCDI_WCur_ID9Value As String, _
        ByVal WCDI_WCur_ID10Value As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(WCDI_WCI_IDValue, WCDI_WCI_IDColumn)
        rec.SetString(WCDI_WPRL_IDValue, WCDI_WPRL_IDColumn)
        rec.SetString(WCDI_PM00200_Vendor_ID1Value, WCDI_PM00200_Vendor_ID1Column)
        rec.SetString(WCDI_PM00200_Vendor_ID2Value, WCDI_PM00200_Vendor_ID2Column)
        rec.SetString(WCDI_PM00200_Vendor_ID3Value, WCDI_PM00200_Vendor_ID3Column)
        rec.SetString(WCDI_PM00200_Vendor_ID4Value, WCDI_PM00200_Vendor_ID4Column)
        rec.SetString(WCDI_PM00200_Vendor_ID5Value, WCDI_PM00200_Vendor_ID5Column)
        rec.SetString(WCDI_PM00200_Vendor_ID6Value, WCDI_PM00200_Vendor_ID6Column)
        rec.SetString(WCDI_Bid1Value, WCDI_Bid1Column)
        rec.SetString(WCDI_Bid2Value, WCDI_Bid2Column)
        rec.SetString(WCDI_Bid3Value, WCDI_Bid3Column)
        rec.SetString(WCDI_Bid4Value, WCDI_Bid4Column)
        rec.SetString(WCDI_Bid5Value, WCDI_Bid5Column)
        rec.SetString(WCDI_Bid6Value, WCDI_Bid6Column)
        rec.SetString(WCDI_Award1Value, WCDI_Award1Column)
        rec.SetString(WCDI_Award2Value, WCDI_Award2Column)
        rec.SetString(WCDI_Award3Value, WCDI_Award3Column)
        rec.SetString(WCDI_Award4Value, WCDI_Award4Column)
        rec.SetString(WCDI_Award5Value, WCDI_Award5Column)
        rec.SetString(WCDI_Award6Value, WCDI_Award6Column)
        rec.SetString(WCDI_StatusValue, WCDI_StatusColumn)
        rec.SetString(WCDI_Audit_CommentValue, WCDI_Audit_CommentColumn)
        rec.SetString(WCDI_CommentValue, WCDI_CommentColumn)
        rec.SetString(WCDI_PM00200_Vendor_ID7Value, WCDI_PM00200_Vendor_ID7Column)
        rec.SetString(WCDI_PM00200_Vendor_ID8Value, WCDI_PM00200_Vendor_ID8Column)
        rec.SetString(WCDI_PM00200_Vendor_ID9Value, WCDI_PM00200_Vendor_ID9Column)
        rec.SetString(WCDI_PM00200_Vendor_ID10Value, WCDI_PM00200_Vendor_ID10Column)
        rec.SetString(WCDI_Bid7Value, WCDI_Bid7Column)
        rec.SetString(WCDI_Bid8Value, WCDI_Bid8Column)
        rec.SetString(WCDI_Bid9Value, WCDI_Bid9Column)
        rec.SetString(WCDI_Bid10Value, WCDI_Bid10Column)
        rec.SetString(WCDI_Award7Value, WCDI_Award7Column)
        rec.SetString(WCDI_Award8Value, WCDI_Award8Column)
        rec.SetString(WCDI_Award9Value, WCDI_Award9Column)
        rec.SetString(WCDI_Award10Value, WCDI_Award10Column)
        rec.SetString(WCDI_Qty1Value, WCDI_Qty1Column)
        rec.SetString(WCDI_Qty2Value, WCDI_Qty2Column)
        rec.SetString(WCDI_Qty3Value, WCDI_Qty3Column)
        rec.SetString(WCDI_Qty4Value, WCDI_Qty4Column)
        rec.SetString(WCDI_Qty5Value, WCDI_Qty5Column)
        rec.SetString(WCDI_Qty6Value, WCDI_Qty6Column)
        rec.SetString(WCDI_Qty7Value, WCDI_Qty7Column)
        rec.SetString(WCDI_Qty8Value, WCDI_Qty8Column)
        rec.SetString(WCDI_Qty9Value, WCDI_Qty9Column)
        rec.SetString(WCDI_Qty10Value, WCDI_Qty10Column)
        rec.SetString(WCDI_PO1Value, WCDI_PO1Column)
        rec.SetString(WCDI_PO2Value, WCDI_PO2Column)
        rec.SetString(WCDI_PO3Value, WCDI_PO3Column)
        rec.SetString(WCDI_PO4Value, WCDI_PO4Column)
        rec.SetString(WCDI_PO5Value, WCDI_PO5Column)
        rec.SetString(WCDI_PO6Value, WCDI_PO6Column)
        rec.SetString(WCDI_PO7Value, WCDI_PO7Column)
        rec.SetString(WCDI_PO8Value, WCDI_PO8Column)
        rec.SetString(WCDI_PO9Value, WCDI_PO9Column)
        rec.SetString(WCDI_PO10Value, WCDI_PO10Column)
        rec.SetString(WCDI_Aw1Value, WCDI_Aw1Column)
        rec.SetString(WCDI_Aw2Value, WCDI_Aw2Column)
        rec.SetString(WCDI_Aw3Value, WCDI_Aw3Column)
        rec.SetString(WCDI_Aw4Value, WCDI_Aw4Column)
        rec.SetString(WCDI_Aw5Value, WCDI_Aw5Column)
        rec.SetString(WCDI_Aw6Value, WCDI_Aw6Column)
        rec.SetString(WCDI_Aw7Value, WCDI_Aw7Column)
        rec.SetString(WCDI_Aw8Value, WCDI_Aw8Column)
        rec.SetString(WCDI_Aw9Value, WCDI_Aw9Column)
        rec.SetString(WCDI_Aw10Value, WCDI_Aw10Column)
        rec.SetString(WCDI_Vat1Value, WCDI_Vat1Column)
        rec.SetString(WCDI_Vat2Value, WCDI_Vat2Column)
        rec.SetString(WCDI_Vat3Value, WCDI_Vat3Column)
        rec.SetString(WCDI_Vat4Value, WCDI_Vat4Column)
        rec.SetString(WCDI_Vat5Value, WCDI_Vat5Column)
        rec.SetString(WCDI_Vat6Value, WCDI_Vat6Column)
        rec.SetString(WCDI_Vat7Value, WCDI_Vat7Column)
        rec.SetString(WCDI_Vat8Value, WCDI_Vat8Column)
        rec.SetString(WCDI_Vat9Value, WCDI_Vat9Column)
        rec.SetString(WCDI_Vat10Value, WCDI_Vat10Column)
        rec.SetString(WCDI_Net1Value, WCDI_Net1Column)
        rec.SetString(WCDI_Net2Value, WCDI_Net2Column)
        rec.SetString(WCDI_Net3Value, WCDI_Net3Column)
        rec.SetString(WCDI_Net4Value, WCDI_Net4Column)
        rec.SetString(WCDI_Net5Value, WCDI_Net5Column)
        rec.SetString(WCDI_Net6Value, WCDI_Net6Column)
        rec.SetString(WCDI_Net7Value, WCDI_Net7Column)
        rec.SetString(WCDI_Net8Value, WCDI_Net8Column)
        rec.SetString(WCDI_Net9Value, WCDI_Net9Column)
        rec.SetString(WCDI_Net10Value, WCDI_Net10Column)
        rec.SetString(WCDI_WCur_ID1Value, WCDI_WCur_ID1Column)
        rec.SetString(WCDI_WCur_ID2Value, WCDI_WCur_ID2Column)
        rec.SetString(WCDI_WCur_ID3Value, WCDI_WCur_ID3Column)
        rec.SetString(WCDI_WCur_ID4Value, WCDI_WCur_ID4Column)
        rec.SetString(WCDI_WCur_ID5Value, WCDI_WCur_ID5Column)
        rec.SetString(WCDI_WCur_ID6Value, WCDI_WCur_ID6Column)
        rec.SetString(WCDI_WCur_ID7Value, WCDI_WCur_ID7Column)
        rec.SetString(WCDI_WCur_ID8Value, WCDI_WCur_ID8Column)
        rec.SetString(WCDI_WCur_ID9Value, WCDI_WCur_ID9Column)
        rec.SetString(WCDI_WCur_ID10Value, WCDI_WCur_ID10Column)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        WCanvass_Detail_InternalTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            WCanvass_Detail_InternalTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(WCanvass_Detail_InternalTable.Instance.TableDefinition.PrimaryKey)) Then
            Return WCanvass_Detail_InternalTable.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(WCanvass_Detail_InternalTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = WCanvass_Detail_InternalTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = WCanvass_Detail_InternalTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (WCanvass_Detail_InternalTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = WCanvass_Detail_InternalTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = WCanvass_Detail_InternalTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = WCanvass_Detail_InternalTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
