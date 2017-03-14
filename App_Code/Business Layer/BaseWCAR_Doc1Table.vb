' This class is "generated" and will be overwritten.
' Your customizations should be made in WCAR_Doc1Record.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ePortalWFApproval.Data

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WCAR_Doc1Table"></see> class.
''' Provides access to the schema information and record data of a database table or view named DatabaseANFLO-WFN%dbo.WCAR_Doc.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="WCAR_Doc1Table.Instance">WCAR_Doc1Table.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="WCAR_Doc1Table"></seealso>

<Serializable()> Public Class BaseWCAR_Doc1Table
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = WCAR_Doc1Definition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.WCAR_Doc1Table")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.WCAR_Doc1Record")
        Me.ApplicationName = "App_Code"
        Me.DataAdapter = New WCAR_Doc1SqlTable()
        Directcast(Me.DataAdapter, WCAR_Doc1SqlTable).ConnectionName = Me.ConnectionName
        Directcast(Me.DataAdapter, WCAR_Doc1SqlTable).ApplicationName = Me.ApplicationName
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        WCD_IDColumn.CodeName = "WCD_ID"
        WCD_WDT_IDColumn.CodeName = "WCD_WDT_ID"
        WCD_NoColumn.CodeName = "WCD_No"
        WCD_SubmitColumn.CodeName = "WCD_Submit"
        WCD_StatusColumn.CodeName = "WCD_Status"
        WCD_RemarkColumn.CodeName = "WCD_Remark"
        WCD_Unit_LocationColumn.CodeName = "WCD_Unit_Location"
        WCD_Project_TitleColumn.CodeName = "WCD_Project_Title"
        WCD_Project_NoColumn.CodeName = "WCD_Project_No"
        WCD_Request_DateColumn.CodeName = "WCD_Request_Date"
        WCD_Proj_Inc_ACBColumn.CodeName = "WCD_Proj_Inc_ACB"
        WCD_Exp_TotalColumn.CodeName = "WCD_Exp_Total"
        WCD_Exp_Prev_TotalColumn.CodeName = "WCD_Exp_Prev_Total"
        WCD_Exp_BudgetColumn.CodeName = "WCD_Exp_Budget"
        WCD_Exp_Under_Over_BudgetColumn.CodeName = "WCD_Exp_Under_Over_Budget"
        WCD_Exp_Cur_YrColumn.CodeName = "WCD_Exp_Cur_Yr"
        WCD_Exp_Nxt_YrColumn.CodeName = "WCD_Exp_Nxt_Yr"
        WCD_Exp_Sub_YrColumn.CodeName = "WCD_Exp_Sub_Yr"
        WCD_C_IDColumn.CodeName = "WCD_C_ID"
        WCD_U_IDColumn.CodeName = "WCD_U_ID"
        WCD_CreatedColumn.CodeName = "WCD_Created"
        WCD_WCur_IDColumn.CodeName = "WCD_WCur_ID"
        WCD_SupplementaryColumn.CodeName = "WCD_Supplementary"
        WCD_Supplementary_WCD_IDColumn.CodeName = "WCD_Supplementary_WCD_ID"
        WCD_Supplementary_ManualColumn.CodeName = "WCD_Supplementary_Manual"
        
    End Sub

#Region "Overriden methods"

    
#End Region

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_ID column object.
    ''' </summary>
    Public ReadOnly Property WCD_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_WDT_ID column object.
    ''' </summary>
    Public ReadOnly Property WCD_WDT_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_WDT_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_WDT_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_WDT_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_No column object.
    ''' </summary>
    Public ReadOnly Property WCD_NoColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_No column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_No() As BaseClasses.Data.StringColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_NoColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Submit column object.
    ''' </summary>
    Public ReadOnly Property WCD_SubmitColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Submit column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_Submit() As BaseClasses.Data.BooleanColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_SubmitColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Status column object.
    ''' </summary>
    Public ReadOnly Property WCD_StatusColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Status column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_Status() As BaseClasses.Data.StringColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_StatusColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Remark column object.
    ''' </summary>
    Public ReadOnly Property WCD_RemarkColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Remark column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_Remark() As BaseClasses.Data.ClobColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_RemarkColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Unit_Location column object.
    ''' </summary>
    Public ReadOnly Property WCD_Unit_LocationColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Unit_Location column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_Unit_Location() As BaseClasses.Data.StringColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_Unit_LocationColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Project_Title column object.
    ''' </summary>
    Public ReadOnly Property WCD_Project_TitleColumn() As BaseClasses.Data.ClobColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.ClobColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Project_Title column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_Project_Title() As BaseClasses.Data.ClobColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_Project_TitleColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Project_No column object.
    ''' </summary>
    Public ReadOnly Property WCD_Project_NoColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Project_No column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_Project_No() As BaseClasses.Data.StringColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_Project_NoColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Request_Date column object.
    ''' </summary>
    Public ReadOnly Property WCD_Request_DateColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Request_Date column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_Request_Date() As BaseClasses.Data.DateColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_Request_DateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Proj_Inc_ACB column object.
    ''' </summary>
    Public ReadOnly Property WCD_Proj_Inc_ACBColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Proj_Inc_ACB column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_Proj_Inc_ACB() As BaseClasses.Data.BooleanColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_Proj_Inc_ACBColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Exp_Total column object.
    ''' </summary>
    Public ReadOnly Property WCD_Exp_TotalColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Exp_Total column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_Exp_Total() As BaseClasses.Data.NumberColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_Exp_TotalColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Exp_Prev_Total column object.
    ''' </summary>
    Public ReadOnly Property WCD_Exp_Prev_TotalColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Exp_Prev_Total column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_Exp_Prev_Total() As BaseClasses.Data.NumberColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_Exp_Prev_TotalColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Exp_Budget column object.
    ''' </summary>
    Public ReadOnly Property WCD_Exp_BudgetColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Exp_Budget column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_Exp_Budget() As BaseClasses.Data.NumberColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_Exp_BudgetColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Exp_Under_Over_Budget column object.
    ''' </summary>
    Public ReadOnly Property WCD_Exp_Under_Over_BudgetColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Exp_Under_Over_Budget column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_Exp_Under_Over_Budget() As BaseClasses.Data.NumberColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_Exp_Under_Over_BudgetColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Exp_Cur_Yr column object.
    ''' </summary>
    Public ReadOnly Property WCD_Exp_Cur_YrColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Exp_Cur_Yr column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_Exp_Cur_Yr() As BaseClasses.Data.NumberColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_Exp_Cur_YrColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Exp_Nxt_Yr column object.
    ''' </summary>
    Public ReadOnly Property WCD_Exp_Nxt_YrColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Exp_Nxt_Yr column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_Exp_Nxt_Yr() As BaseClasses.Data.NumberColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_Exp_Nxt_YrColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Exp_Sub_Yr column object.
    ''' </summary>
    Public ReadOnly Property WCD_Exp_Sub_YrColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Exp_Sub_Yr column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_Exp_Sub_Yr() As BaseClasses.Data.NumberColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_Exp_Sub_YrColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_C_ID column object.
    ''' </summary>
    Public ReadOnly Property WCD_C_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_C_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_C_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_C_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_U_ID column object.
    ''' </summary>
    Public ReadOnly Property WCD_U_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_U_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_U_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_U_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Created column object.
    ''' </summary>
    Public ReadOnly Property WCD_CreatedColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Created column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_Created() As BaseClasses.Data.DateColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_CreatedColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_WCur_ID column object.
    ''' </summary>
    Public ReadOnly Property WCD_WCur_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_WCur_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_WCur_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_WCur_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Supplementary column object.
    ''' </summary>
    Public ReadOnly Property WCD_SupplementaryColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Supplementary column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_Supplementary() As BaseClasses.Data.BooleanColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_SupplementaryColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Supplementary_WCD_ID column object.
    ''' </summary>
    Public ReadOnly Property WCD_Supplementary_WCD_IDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(23), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Supplementary_WCD_ID column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_Supplementary_WCD_ID() As BaseClasses.Data.NumberColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_Supplementary_WCD_IDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Supplementary_Manual column object.
    ''' </summary>
    Public ReadOnly Property WCD_Supplementary_ManualColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(24), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's WCAR_Doc_.WCD_Supplementary_Manual column object.
    ''' </summary>
    Public Shared ReadOnly Property WCD_Supplementary_Manual() As BaseClasses.Data.StringColumn
        Get
            Return WCAR_Doc1Table.Instance.WCD_Supplementary_ManualColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCAR_Doc1Record records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As WCAR_Doc1Record()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCAR_Doc1Record records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As WCAR_Doc1Record()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCAR_Doc1Record records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WCAR_Doc1Record()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCAR_Doc1Record records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WCAR_Doc1Record()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCAR_Doc1Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WCAR_Doc1Record()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  WCAR_Doc1Table.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WCAR_Doc1Record)), WCAR_Doc1Record())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCAR_Doc1Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WCAR_Doc1Record()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  WCAR_Doc1Table.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WCAR_Doc1Record)), WCAR_Doc1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WCAR_Doc1Record()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WCAR_Doc1Table.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WCAR_Doc1Record)), WCAR_Doc1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As WCAR_Doc1Record()

        Dim recList As ArrayList = WCAR_Doc1Table.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WCAR_Doc1Record)), WCAR_Doc1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As WCAR_Doc1Record()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WCAR_Doc1Table.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WCAR_Doc1Record)), WCAR_Doc1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As WCAR_Doc1Record()

        Dim recList As ArrayList = WCAR_Doc1Table.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.WCAR_Doc1Record)), WCAR_Doc1Record())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function PostGetRecordCount(ByVal selectCols As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal finalFilter As BaseFilter) As Integer
	      Return CInt(WCAR_Doc1Table.Instance.GetCountResponseForPost(WCAR_Doc1Table.Instance.TableDefinition, selectCols, join, finalFilter))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of WCAR_Doc1Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function PostGetRecordList(ByVal requestedSelection As SqlBuilderColumnSelection, ByVal workingSelection As SqlBuilderColumnSelection, _
		ByVal distinctSelection As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal filter As BaseFilter, ByVal groupBy As GroupBy, _
	    ByVal sortOrder As OrderBy, ByVal startIndex As Integer, ByVal count As Integer, ByRef totalCount As Integer, ByVal fromDataSource As [Boolean], _
	    Optional ByVal table As KeylessVirtualTable = Nothing, Optional isGetColumnValues As Boolean = False) As ArrayList
	      
		Dim recList As ArrayList = Nothing
		If IsNothing(table) Then
			recList = WCAR_Doc1Table.Instance.GetRecordListResponseForPost(WCAR_Doc1Table.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection, join, filter, _
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

        Return CInt(WCAR_Doc1Table.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(WCAR_Doc1Table.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(WCAR_Doc1Table.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(WCAR_Doc1Table.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WCAR_Doc1Record record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As WCAR_Doc1Record
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WCAR_Doc1Record record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As WCAR_Doc1Record
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WCAR_Doc1Record record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WCAR_Doc1Record

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = WCAR_Doc1Table.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As WCAR_Doc1Record = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), WCAR_Doc1Record)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a WCAR_Doc1Record record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As WCAR_Doc1Record

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = WCAR_Doc1Table.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As WCAR_Doc1Record = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), WCAR_Doc1Record)
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

        Return WCAR_Doc1Table.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

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

        Return WCAR_Doc1Table.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As WCAR_Doc1Record = GetRecords(where)
        Return WCAR_Doc1Table.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As WCAR_Doc1Record = GetRecords(join, where)
        Return WCAR_Doc1Table.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As WCAR_Doc1Record = GetRecords(where, orderBy)
        Return WCAR_Doc1Table.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As WCAR_Doc1Record = GetRecords(join, where, orderBy)
        Return WCAR_Doc1Table.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As WCAR_Doc1Record = GetRecords(where, orderBy, pageIndex, pageSize)
        Return WCAR_Doc1Table.Instance.CreateDataTable(recs, Nothing)
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

        Dim recs() As WCAR_Doc1Record = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return WCAR_Doc1Table.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        WCAR_Doc1Table.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return WCAR_Doc1Table.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return WCAR_Doc1Table.Instance.ExportRecordData(whereFilter)
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

        Return WCAR_Doc1Table.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WCAR_Doc1Table.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WCAR_Doc1Table.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

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

        Return WCAR_Doc1Table.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return WCAR_Doc1Table.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return WCAR_Doc1Table.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return WCAR_Doc1Table.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return WCAR_Doc1Table.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = WCAR_Doc1Table.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     


    ''' <summary>
    ''' This method gets the specified column.
    ''' </summary>
    ''' <param name="name">name of the column to fetch.</param>
    Public Shared Function GetColumnByName(ByVal name As String) As BaseColumn
        Dim column As BaseColumn = WCAR_Doc1Table.Instance.TableDefinition.ColumnList.GetByInternalName(name)
        Return column
    End Function       
        

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As WCAR_Doc1Record
        Return CType(WCAR_Doc1Table.Instance.GetRecordData(id, bMutable), WCAR_Doc1Record)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As WCAR_Doc1Record
        Return CType(WCAR_Doc1Table.Instance.GetRecordData(id, bMutable), WCAR_Doc1Record)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal WCD_WDT_IDValue As String, _
        ByVal WCD_NoValue As String, _
        ByVal WCD_SubmitValue As String, _
        ByVal WCD_StatusValue As String, _
        ByVal WCD_RemarkValue As String, _
        ByVal WCD_Unit_LocationValue As String, _
        ByVal WCD_Project_TitleValue As String, _
        ByVal WCD_Project_NoValue As String, _
        ByVal WCD_Request_DateValue As String, _
        ByVal WCD_Proj_Inc_ACBValue As String, _
        ByVal WCD_Exp_TotalValue As String, _
        ByVal WCD_Exp_Prev_TotalValue As String, _
        ByVal WCD_Exp_BudgetValue As String, _
        ByVal WCD_Exp_Under_Over_BudgetValue As String, _
        ByVal WCD_Exp_Cur_YrValue As String, _
        ByVal WCD_Exp_Nxt_YrValue As String, _
        ByVal WCD_Exp_Sub_YrValue As String, _
        ByVal WCD_C_IDValue As String, _
        ByVal WCD_U_IDValue As String, _
        ByVal WCD_CreatedValue As String, _
        ByVal WCD_WCur_IDValue As String, _
        ByVal WCD_SupplementaryValue As String, _
        ByVal WCD_Supplementary_WCD_IDValue As String, _
        ByVal WCD_Supplementary_ManualValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(WCD_WDT_IDValue, WCD_WDT_IDColumn)
        rec.SetString(WCD_NoValue, WCD_NoColumn)
        rec.SetString(WCD_SubmitValue, WCD_SubmitColumn)
        rec.SetString(WCD_StatusValue, WCD_StatusColumn)
        rec.SetString(WCD_RemarkValue, WCD_RemarkColumn)
        rec.SetString(WCD_Unit_LocationValue, WCD_Unit_LocationColumn)
        rec.SetString(WCD_Project_TitleValue, WCD_Project_TitleColumn)
        rec.SetString(WCD_Project_NoValue, WCD_Project_NoColumn)
        rec.SetString(WCD_Request_DateValue, WCD_Request_DateColumn)
        rec.SetString(WCD_Proj_Inc_ACBValue, WCD_Proj_Inc_ACBColumn)
        rec.SetString(WCD_Exp_TotalValue, WCD_Exp_TotalColumn)
        rec.SetString(WCD_Exp_Prev_TotalValue, WCD_Exp_Prev_TotalColumn)
        rec.SetString(WCD_Exp_BudgetValue, WCD_Exp_BudgetColumn)
        rec.SetString(WCD_Exp_Under_Over_BudgetValue, WCD_Exp_Under_Over_BudgetColumn)
        rec.SetString(WCD_Exp_Cur_YrValue, WCD_Exp_Cur_YrColumn)
        rec.SetString(WCD_Exp_Nxt_YrValue, WCD_Exp_Nxt_YrColumn)
        rec.SetString(WCD_Exp_Sub_YrValue, WCD_Exp_Sub_YrColumn)
        rec.SetString(WCD_C_IDValue, WCD_C_IDColumn)
        rec.SetString(WCD_U_IDValue, WCD_U_IDColumn)
        rec.SetString(WCD_CreatedValue, WCD_CreatedColumn)
        rec.SetString(WCD_WCur_IDValue, WCD_WCur_IDColumn)
        rec.SetString(WCD_SupplementaryValue, WCD_SupplementaryColumn)
        rec.SetString(WCD_Supplementary_WCD_IDValue, WCD_Supplementary_WCD_IDColumn)
        rec.SetString(WCD_Supplementary_ManualValue, WCD_Supplementary_ManualColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        WCAR_Doc1Table.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            WCAR_Doc1Table.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(WCAR_Doc1Table.Instance.TableDefinition.PrimaryKey)) Then
            Return WCAR_Doc1Table.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(WCAR_Doc1Table.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = WCAR_Doc1Table.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = WCAR_Doc1Table.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (WCAR_Doc1Table.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = WCAR_Doc1Table.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = WCAR_Doc1Table.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
	    Dim fkColumn As ForeignKey = WCAR_Doc1Table.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
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
