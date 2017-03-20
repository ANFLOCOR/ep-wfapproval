' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WPO_WFTaskActivity_RemarksRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_WPO_WFTaskActivity_RemarksRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WPO_WFTaskActivity_RemarksView"></see> class.
''' </remarks>
''' <seealso cref="Sel_WPO_WFTaskActivity_RemarksView"></seealso>
''' <seealso cref="Sel_WPO_WFTaskActivity_RemarksRecord"></seealso>

<Serializable()> Public Class BaseSel_WPO_WFTaskActivity_RemarksRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_WPO_WFTaskActivity_RemarksView = Sel_WPO_WFTaskActivity_RemarksView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_WPO_WFTaskActivity_RemarksRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_WPO_WFTaskActivity_RemarksRec As Sel_WPO_WFTaskActivity_RemarksRecord = CType(sender,Sel_WPO_WFTaskActivity_RemarksRecord)
        Validate_Inserting()
        If Not Sel_WPO_WFTaskActivity_RemarksRec Is Nothing AndAlso Not Sel_WPO_WFTaskActivity_RemarksRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub Sel_WPO_WFTaskActivity_RemarksRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim Sel_WPO_WFTaskActivity_RemarksRec As Sel_WPO_WFTaskActivity_RemarksRecord = CType(sender,Sel_WPO_WFTaskActivity_RemarksRecord)
        Validate_Updating()
        If Not Sel_WPO_WFTaskActivity_RemarksRec Is Nothing AndAlso Not Sel_WPO_WFTaskActivity_RemarksRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_WPO_WFTaskActivity_RemarksRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_WPO_WFTaskActivity_RemarksRec As Sel_WPO_WFTaskActivity_RemarksRecord = CType(sender,Sel_WPO_WFTaskActivity_RemarksRecord)
        If Not Sel_WPO_WFTaskActivity_RemarksRec Is Nothing AndAlso Not Sel_WPO_WFTaskActivity_RemarksRec.IsReadOnly Then
                End If
    End Sub
    
   'Evaluates Validate when->Inserting formulas specified at the data access layer
   Public Overridable Sub Validate_Inserting ()
		Dim fullValidationMessage As String = ""
		Dim validationMessage As String = ""

		dim formula as String = ""


		If validationMessage <> "" AndAlso validationMessage.ToLower() <> "true" Then
			fullValidationMessage &= validationMessage & vbCrLf
		End If

		If fullValidationMessage <> "" Then
			Throw New Exception(fullValidationMessage)
		End If 
	End Sub
	
	'Evaluates Validate when->Updating formulas specified at the data access layer
   Public Overridable Sub Validate_Updating ()
		Dim fullValidationMessage As String = ""
		Dim validationMessage As String = ""

		dim formula as String = ""


		If validationMessage <> "" AndAlso validationMessage.ToLower() <> "true" Then
			fullValidationMessage &= validationMessage & vbCrLf
		End If

		If fullValidationMessage <> "" Then
			Throw New Exception(fullValidationMessage)
		End If 
	End Sub
 
	Public Overridable Function EvaluateFormula(ByVal formula As String, Optional ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord = Nothing, Optional ByVal format As String = Nothing) As String

		Dim e As Data.BaseFormulaEvaluator = New Data.BaseFormulaEvaluator()

            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If
        	Return resultObj.ToString()
	End Function







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WPO_WFTaskActivi792457005_.WPOP_PONMBR field.
	''' </summary>
	Public Function GetWPOP_PONMBRValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPOP_PONMBRColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WPO_WFTaskActivi792457005_.WPOP_PONMBR field.
	''' </summary>
	Public Function GetWPOP_PONMBRFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPOP_PONMBRColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WPO_WFTaskActivi792457005_.WPOP_PONMBR field.
	''' </summary>
	Public Sub SetWPOP_PONMBRFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPOP_PONMBRColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WPO_WFTaskActivi792457005_.WPOP_PONMBR field.
	''' </summary>
	Public Sub SetWPOP_PONMBRFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_PONMBRColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WPO_WFTaskActivi792457005_.WPOP_C_ID field.
	''' </summary>
	Public Function GetWPOP_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPOP_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WPO_WFTaskActivi792457005_.WPOP_C_ID field.
	''' </summary>
	Public Function GetWPOP_C_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPOP_C_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WPO_WFTaskActivi792457005_.WPOP_C_ID field.
	''' </summary>
	Public Sub SetWPOP_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPOP_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WPO_WFTaskActivi792457005_.WPOP_C_ID field.
	''' </summary>
	Public Sub SetWPOP_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPOP_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WPO_WFTaskActivi792457005_.WPOP_C_ID field.
	''' </summary>
	Public Sub SetWPOP_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WPO_WFTaskActivi792457005_.WPOP_C_ID field.
	''' </summary>
	Public Sub SetWPOP_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WPO_WFTaskActivi792457005_.WPOP_C_ID field.
	''' </summary>
	Public Sub SetWPOP_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WPO_WFTaskActivi792457005_.WPO_Remark field.
	''' </summary>
	Public Function GetWPO_RemarkValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_RemarkColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WPO_WFTaskActivi792457005_.WPO_Remark field.
	''' </summary>
	Public Function GetWPO_RemarkFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPO_RemarkColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WPO_WFTaskActivi792457005_.WPO_Remark field.
	''' </summary>
	Public Sub SetWPO_RemarkFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WPO_WFTaskActivi792457005_.WPO_Remark field.
	''' </summary>
	Public Sub SetWPO_RemarkFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_RemarkColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Sel_WPO_WFTaskActivi792457005_.WPOP_PONMBR field.
	''' </summary>
	Public Property WPOP_PONMBR() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPOP_PONMBRColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPOP_PONMBRColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPOP_PONMBRSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPOP_PONMBRColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPOP_PONMBRDefault() As String
        Get
            Return TableUtils.WPOP_PONMBRColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Sel_WPO_WFTaskActivi792457005_.WPOP_C_ID field.
	''' </summary>
	Public Property WPOP_C_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPOP_C_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPOP_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPOP_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPOP_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPOP_C_IDDefault() As String
        Get
            Return TableUtils.WPOP_C_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Sel_WPO_WFTaskActivi792457005_.WPO_Remark field.
	''' </summary>
	Public Property WPO_Remark() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_RemarkColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPO_RemarkColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_RemarkSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_RemarkColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_RemarkDefault() As String
        Get
            Return TableUtils.WPO_RemarkColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
