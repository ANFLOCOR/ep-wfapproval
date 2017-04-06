' This class is "generated" and will be overwritten.
' Your customizations should be made in WFin_ApprovalStatusRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WFin_ApprovalStatusRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WFin_ApprovalStatusTable"></see> class.
''' </remarks>
''' <seealso cref="WFin_ApprovalStatusTable"></seealso>
''' <seealso cref="WFin_ApprovalStatusRecord"></seealso>

<Serializable()> Public Class BaseWFin_ApprovalStatusRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WFin_ApprovalStatusTable = WFin_ApprovalStatusTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WFin_ApprovalStatusRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WFin_ApprovalStatusRec As WFin_ApprovalStatusRecord = CType(sender,WFin_ApprovalStatusRecord)
        Validate_Inserting()
        If Not WFin_ApprovalStatusRec Is Nothing AndAlso Not WFin_ApprovalStatusRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WFin_ApprovalStatusRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WFin_ApprovalStatusRec As WFin_ApprovalStatusRecord = CType(sender,WFin_ApprovalStatusRecord)
        Validate_Updating()
        If Not WFin_ApprovalStatusRec Is Nothing AndAlso Not WFin_ApprovalStatusRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WFin_ApprovalStatusRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WFin_ApprovalStatusRec As WFin_ApprovalStatusRecord = CType(sender,WFin_ApprovalStatusRecord)
        If Not WFin_ApprovalStatusRec Is Nothing AndAlso Not WFin_ApprovalStatusRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WFin_ApprovalStatus_.WPO_STAT_CD field.
	''' </summary>
	Public Function GetWPO_STAT_CDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_STAT_CDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFin_ApprovalStatus_.WPO_STAT_CD field.
	''' </summary>
	Public Function GetWPO_STAT_CDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPO_STAT_CDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFin_ApprovalStatus_.WPO_STAT_CD field.
	''' </summary>
	Public Sub SetWPO_STAT_CDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_STAT_CDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFin_ApprovalStatus_.WPO_STAT_CD field.
	''' </summary>
	Public Sub SetWPO_STAT_CDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_STAT_CDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFin_ApprovalStatus_.WPO_STAT_CD field.
	''' </summary>
	Public Sub SetWPO_STAT_CDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_STAT_CDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFin_ApprovalStatus_.WPO_STAT_CD field.
	''' </summary>
	Public Sub SetWPO_STAT_CDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_STAT_CDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFin_ApprovalStatus_.WPO_STAT_CD field.
	''' </summary>
	Public Sub SetWPO_STAT_CDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_STAT_CDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFin_ApprovalStatus_.WPO_STAT_DESC field.
	''' </summary>
	Public Function GetWPO_STAT_DESCValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_STAT_DESCColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFin_ApprovalStatus_.WPO_STAT_DESC field.
	''' </summary>
	Public Function GetWPO_STAT_DESCFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPO_STAT_DESCColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFin_ApprovalStatus_.WPO_STAT_DESC field.
	''' </summary>
	Public Sub SetWPO_STAT_DESCFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_STAT_DESCColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFin_ApprovalStatus_.WPO_STAT_DESC field.
	''' </summary>
	Public Sub SetWPO_STAT_DESCFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_STAT_DESCColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFin_ApprovalStatus_.WPO_STAT_CD field.
	''' </summary>
	Public Property WPO_STAT_CD() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_STAT_CDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_STAT_CDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_STAT_CDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_STAT_CDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_STAT_CDDefault() As String
        Get
            Return TableUtils.WPO_STAT_CDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFin_ApprovalStatus_.WPO_STAT_DESC field.
	''' </summary>
	Public Property WPO_STAT_DESC() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_STAT_DESCColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPO_STAT_DESCColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_STAT_DESCSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_STAT_DESCColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_STAT_DESCDefault() As String
        Get
            Return TableUtils.WPO_STAT_DESCColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
