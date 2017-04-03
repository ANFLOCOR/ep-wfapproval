' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRepCon_ActivityRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WFinRepCon_ActivityRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WFinRepCon_ActivityTable"></see> class.
''' </remarks>
''' <seealso cref="WFinRepCon_ActivityTable"></seealso>
''' <seealso cref="WFinRepCon_ActivityRecord"></seealso>

<Serializable()> Public Class BaseWFinRepCon_ActivityRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WFinRepCon_ActivityTable = WFinRepCon_ActivityTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WFinRepCon_ActivityRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WFinRepCon_ActivityRec As WFinRepCon_ActivityRecord = CType(sender,WFinRepCon_ActivityRecord)
        Validate_Inserting()
        If Not WFinRepCon_ActivityRec Is Nothing AndAlso Not WFinRepCon_ActivityRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WFinRepCon_ActivityRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WFinRepCon_ActivityRec As WFinRepCon_ActivityRecord = CType(sender,WFinRepCon_ActivityRecord)
        Validate_Updating()
        If Not WFinRepCon_ActivityRec Is Nothing AndAlso Not WFinRepCon_ActivityRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WFinRepCon_ActivityRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WFinRepCon_ActivityRec As WFinRepCon_ActivityRecord = CType(sender,WFinRepCon_ActivityRecord)
        If Not WFinRepCon_ActivityRec Is Nothing AndAlso Not WFinRepCon_ActivityRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_ID field.
	''' </summary>
	Public Function GetWFRCA_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCA_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_ID field.
	''' </summary>
	Public Function GetWFRCA_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCA_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_WS_ID field.
	''' </summary>
	Public Function GetWFRCA_WS_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCA_WS_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_WS_ID field.
	''' </summary>
	Public Function GetWFRCA_WS_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCA_WS_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WS_ID field.
	''' </summary>
	Public Sub SetWFRCA_WS_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WS_ID field.
	''' </summary>
	Public Sub SetWFRCA_WS_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WS_ID field.
	''' </summary>
	Public Sub SetWFRCA_WS_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WS_ID field.
	''' </summary>
	Public Sub SetWFRCA_WS_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WS_ID field.
	''' </summary>
	Public Sub SetWFRCA_WS_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_WS_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_WSD_ID field.
	''' </summary>
	Public Function GetWFRCA_WSD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCA_WSD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_WSD_ID field.
	''' </summary>
	Public Function GetWFRCA_WSD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCA_WSD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WSD_ID field.
	''' </summary>
	Public Sub SetWFRCA_WSD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WSD_ID field.
	''' </summary>
	Public Sub SetWFRCA_WSD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WSD_ID field.
	''' </summary>
	Public Sub SetWFRCA_WSD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WSD_ID field.
	''' </summary>
	Public Sub SetWFRCA_WSD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WSD_ID field.
	''' </summary>
	Public Sub SetWFRCA_WSD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_WSD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_WDT_ID field.
	''' </summary>
	Public Function GetWFRCA_WDT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCA_WDT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_WDT_ID field.
	''' </summary>
	Public Function GetWFRCA_WDT_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCA_WDT_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WDT_ID field.
	''' </summary>
	Public Sub SetWFRCA_WDT_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WDT_ID field.
	''' </summary>
	Public Sub SetWFRCA_WDT_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WDT_ID field.
	''' </summary>
	Public Sub SetWFRCA_WDT_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WDT_ID field.
	''' </summary>
	Public Sub SetWFRCA_WDT_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WDT_ID field.
	''' </summary>
	Public Sub SetWFRCA_WDT_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_WDT_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_W_U_ID field.
	''' </summary>
	Public Function GetWFRCA_W_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCA_W_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_W_U_ID field.
	''' </summary>
	Public Function GetWFRCA_W_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCA_W_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_W_U_ID field.
	''' </summary>
	Public Sub SetWFRCA_W_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_W_U_ID field.
	''' </summary>
	Public Sub SetWFRCA_W_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_W_U_ID field.
	''' </summary>
	Public Sub SetWFRCA_W_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_W_U_ID field.
	''' </summary>
	Public Sub SetWFRCA_W_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_W_U_ID field.
	''' </summary>
	Public Sub SetWFRCA_W_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_W_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_W_U_ID_Delegate field.
	''' </summary>
	Public Function GetWFRCA_W_U_ID_DelegateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCA_W_U_ID_DelegateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_W_U_ID_Delegate field.
	''' </summary>
	Public Function GetWFRCA_W_U_ID_DelegateFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCA_W_U_ID_DelegateColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWFRCA_W_U_ID_DelegateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCA_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWFRCA_W_U_ID_DelegateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCA_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWFRCA_W_U_ID_DelegateFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWFRCA_W_U_ID_DelegateFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWFRCA_W_U_ID_DelegateFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_W_U_ID_DelegateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_Status field.
	''' </summary>
	Public Function GetWFRCA_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCA_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_Status field.
	''' </summary>
	Public Function GetWFRCA_StatusFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCA_StatusColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_Status field.
	''' </summary>
	Public Sub SetWFRCA_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCA_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_Status field.
	''' </summary>
	Public Sub SetWFRCA_StatusFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCA_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_Status field.
	''' </summary>
	Public Sub SetWFRCA_StatusFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_Status field.
	''' </summary>
	Public Sub SetWFRCA_StatusFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_Status field.
	''' </summary>
	Public Sub SetWFRCA_StatusFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_StatusColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_Date_Assign field.
	''' </summary>
	Public Function GetWFRCA_Date_AssignValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCA_Date_AssignColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_Date_Assign field.
	''' </summary>
	Public Function GetWFRCA_Date_AssignFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WFRCA_Date_AssignColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_Date_Assign field.
	''' </summary>
	Public Sub SetWFRCA_Date_AssignFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCA_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_Date_Assign field.
	''' </summary>
	Public Sub SetWFRCA_Date_AssignFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCA_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_Date_Assign field.
	''' </summary>
	Public Sub SetWFRCA_Date_AssignFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_Date_Action field.
	''' </summary>
	Public Function GetWFRCA_Date_ActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCA_Date_ActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_Date_Action field.
	''' </summary>
	Public Function GetWFRCA_Date_ActionFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WFRCA_Date_ActionColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_Date_Action field.
	''' </summary>
	Public Sub SetWFRCA_Date_ActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCA_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_Date_Action field.
	''' </summary>
	Public Sub SetWFRCA_Date_ActionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCA_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_Date_Action field.
	''' </summary>
	Public Sub SetWFRCA_Date_ActionFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_Remark field.
	''' </summary>
	Public Function GetWFRCA_RemarkValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCA_RemarkColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_Remark field.
	''' </summary>
	Public Function GetWFRCA_RemarkFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRCA_RemarkColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_Remark field.
	''' </summary>
	Public Sub SetWFRCA_RemarkFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCA_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_Remark field.
	''' </summary>
	Public Sub SetWFRCA_RemarkFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_Is_Done field.
	''' </summary>
	Public Function GetWFRCA_Is_DoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCA_Is_DoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_Is_Done field.
	''' </summary>
	Public Function GetWFRCA_Is_DoneFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WFRCA_Is_DoneColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_Is_Done field.
	''' </summary>
	Public Sub SetWFRCA_Is_DoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCA_Is_DoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_Is_Done field.
	''' </summary>
	Public Sub SetWFRCA_Is_DoneFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCA_Is_DoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_Is_Done field.
	''' </summary>
	Public Sub SetWFRCA_Is_DoneFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_Is_DoneColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_Code field.
	''' </summary>
	Public Function GetWFRCA_CodeValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCA_CodeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_Code field.
	''' </summary>
	Public Function GetWFRCA_CodeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRCA_CodeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_Code field.
	''' </summary>
	Public Sub SetWFRCA_CodeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCA_CodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_Code field.
	''' </summary>
	Public Sub SetWFRCA_CodeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_CodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_FinID field.
	''' </summary>
	Public Function GetWFRCA_FinIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCA_FinIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_FinID field.
	''' </summary>
	Public Function GetWFRCA_FinIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCA_FinIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_FinID field.
	''' </summary>
	Public Sub SetWFRCA_FinIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCA_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_FinID field.
	''' </summary>
	Public Sub SetWFRCA_FinIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCA_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_FinID field.
	''' </summary>
	Public Sub SetWFRCA_FinIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_FinID field.
	''' </summary>
	Public Sub SetWFRCA_FinIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_FinID field.
	''' </summary>
	Public Sub SetWFRCA_FinIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_FinIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_WFRCH_ID field.
	''' </summary>
	Public Function GetWFRCA_WFRCH_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCA_WFRCH_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_WFRCH_ID field.
	''' </summary>
	Public Function GetWFRCA_WFRCH_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCA_WFRCH_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WFRCH_ID field.
	''' </summary>
	Public Sub SetWFRCA_WFRCH_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCA_WFRCH_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WFRCH_ID field.
	''' </summary>
	Public Sub SetWFRCA_WFRCH_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCA_WFRCH_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WFRCH_ID field.
	''' </summary>
	Public Sub SetWFRCA_WFRCH_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_WFRCH_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WFRCH_ID field.
	''' </summary>
	Public Sub SetWFRCA_WFRCH_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_WFRCH_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Activity_.WFRCA_WFRCH_ID field.
	''' </summary>
	Public Sub SetWFRCA_WFRCH_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCA_WFRCH_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_ID field.
	''' </summary>
	Public Property WFRCA_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCA_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCA_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCA_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCA_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCA_IDDefault() As String
        Get
            Return TableUtils.WFRCA_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_WS_ID field.
	''' </summary>
	Public Property WFRCA_WS_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCA_WS_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCA_WS_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCA_WS_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCA_WS_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCA_WS_IDDefault() As String
        Get
            Return TableUtils.WFRCA_WS_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_WSD_ID field.
	''' </summary>
	Public Property WFRCA_WSD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCA_WSD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCA_WSD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCA_WSD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCA_WSD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCA_WSD_IDDefault() As String
        Get
            Return TableUtils.WFRCA_WSD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_WDT_ID field.
	''' </summary>
	Public Property WFRCA_WDT_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCA_WDT_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCA_WDT_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCA_WDT_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCA_WDT_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCA_WDT_IDDefault() As String
        Get
            Return TableUtils.WFRCA_WDT_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_W_U_ID field.
	''' </summary>
	Public Property WFRCA_W_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCA_W_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCA_W_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCA_W_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCA_W_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCA_W_U_IDDefault() As String
        Get
            Return TableUtils.WFRCA_W_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_W_U_ID_Delegate field.
	''' </summary>
	Public Property WFRCA_W_U_ID_Delegate() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCA_W_U_ID_DelegateColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCA_W_U_ID_DelegateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCA_W_U_ID_DelegateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCA_W_U_ID_DelegateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCA_W_U_ID_DelegateDefault() As String
        Get
            Return TableUtils.WFRCA_W_U_ID_DelegateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_Status field.
	''' </summary>
	Public Property WFRCA_Status() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCA_StatusColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCA_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCA_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCA_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCA_StatusDefault() As String
        Get
            Return TableUtils.WFRCA_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_Date_Assign field.
	''' </summary>
	Public Property WFRCA_Date_Assign() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCA_Date_AssignColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCA_Date_AssignColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCA_Date_AssignSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCA_Date_AssignColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCA_Date_AssignDefault() As String
        Get
            Return TableUtils.WFRCA_Date_AssignColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_Date_Action field.
	''' </summary>
	Public Property WFRCA_Date_Action() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCA_Date_ActionColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCA_Date_ActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCA_Date_ActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCA_Date_ActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCA_Date_ActionDefault() As String
        Get
            Return TableUtils.WFRCA_Date_ActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_Remark field.
	''' </summary>
	Public Property WFRCA_Remark() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCA_RemarkColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WFRCA_RemarkColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCA_RemarkSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCA_RemarkColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCA_RemarkDefault() As String
        Get
            Return TableUtils.WFRCA_RemarkColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_Is_Done field.
	''' </summary>
	Public Property WFRCA_Is_Done() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCA_Is_DoneColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCA_Is_DoneColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCA_Is_DoneSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCA_Is_DoneColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCA_Is_DoneDefault() As String
        Get
            Return TableUtils.WFRCA_Is_DoneColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_Code field.
	''' </summary>
	Public Property WFRCA_Code() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCA_CodeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WFRCA_CodeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCA_CodeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCA_CodeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCA_CodeDefault() As String
        Get
            Return TableUtils.WFRCA_CodeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_FinID field.
	''' </summary>
	Public Property WFRCA_FinID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCA_FinIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCA_FinIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCA_FinIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCA_FinIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCA_FinIDDefault() As String
        Get
            Return TableUtils.WFRCA_FinIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Activity_.WFRCA_WFRCH_ID field.
	''' </summary>
	Public Property WFRCA_WFRCH_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCA_WFRCH_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCA_WFRCH_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCA_WFRCH_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCA_WFRCH_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCA_WFRCH_IDDefault() As String
        Get
            Return TableUtils.WFRCA_WFRCH_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
