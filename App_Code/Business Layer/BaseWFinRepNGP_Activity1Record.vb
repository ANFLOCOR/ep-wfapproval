' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRepNGP_Activity1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WFinRepNGP_Activity1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WFinRepNGP_Activity1Table"></see> class.
''' </remarks>
''' <seealso cref="WFinRepNGP_Activity1Table"></seealso>
''' <seealso cref="WFinRepNGP_Activity1Record"></seealso>

<Serializable()> Public Class BaseWFinRepNGP_Activity1Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WFinRepNGP_Activity1Table = WFinRepNGP_Activity1Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WFinRepNGP_Activity1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WFinRepNGP_Activity1Rec As WFinRepNGP_Activity1Record = CType(sender,WFinRepNGP_Activity1Record)
        Validate_Inserting()
        If Not WFinRepNGP_Activity1Rec Is Nothing AndAlso Not WFinRepNGP_Activity1Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WFinRepNGP_Activity1Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WFinRepNGP_Activity1Rec As WFinRepNGP_Activity1Record = CType(sender,WFinRepNGP_Activity1Record)
        Validate_Updating()
        If Not WFinRepNGP_Activity1Rec Is Nothing AndAlso Not WFinRepNGP_Activity1Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WFinRepNGP_Activity1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WFinRepNGP_Activity1Rec As WFinRepNGP_Activity1Record = CType(sender,WFinRepNGP_Activity1Record)
        If Not WFinRepNGP_Activity1Rec Is Nothing AndAlso Not WFinRepNGP_Activity1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_ID field.
	''' </summary>
	Public Function GetWFRNGPA_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_ID field.
	''' </summary>
	Public Function GetWFRNGPA_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRNGPA_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_WS_ID field.
	''' </summary>
	Public Function GetWFRNGPA_WS_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_WS_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_WS_ID field.
	''' </summary>
	Public Function GetWFRNGPA_WS_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRNGPA_WS_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WS_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WS_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WS_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WS_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WS_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WS_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WS_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WS_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WS_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WS_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WS_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_WSD_ID field.
	''' </summary>
	Public Function GetWFRNGPA_WSD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_WSD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_WSD_ID field.
	''' </summary>
	Public Function GetWFRNGPA_WSD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRNGPA_WSD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WSD_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WSD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WSD_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WSD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WSD_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WSD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WSD_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WSD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WSD_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WSD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WSD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_WDT_ID field.
	''' </summary>
	Public Function GetWFRNGPA_WDT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_WDT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_WDT_ID field.
	''' </summary>
	Public Function GetWFRNGPA_WDT_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRNGPA_WDT_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WDT_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WDT_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WDT_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WDT_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WDT_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WDT_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WDT_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WDT_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WDT_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WDT_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WDT_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_W_U_ID field.
	''' </summary>
	Public Function GetWFRNGPA_W_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_W_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_W_U_ID field.
	''' </summary>
	Public Function GetWFRNGPA_W_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRNGPA_W_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_W_U_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_W_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_W_U_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_W_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_W_U_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_W_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_W_U_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_W_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_W_U_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_W_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_W_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_W_U_ID_Delegate field.
	''' </summary>
	Public Function GetWFRNGPA_W_U_ID_DelegateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_W_U_ID_DelegateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_W_U_ID_Delegate field.
	''' </summary>
	Public Function GetWFRNGPA_W_U_ID_DelegateFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRNGPA_W_U_ID_DelegateColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWFRNGPA_W_U_ID_DelegateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWFRNGPA_W_U_ID_DelegateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWFRNGPA_W_U_ID_DelegateFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWFRNGPA_W_U_ID_DelegateFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWFRNGPA_W_U_ID_DelegateFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_W_U_ID_DelegateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_Status field.
	''' </summary>
	Public Function GetWFRNGPA_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_Status field.
	''' </summary>
	Public Function GetWFRNGPA_StatusFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRNGPA_StatusColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_Status field.
	''' </summary>
	Public Sub SetWFRNGPA_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_Status field.
	''' </summary>
	Public Sub SetWFRNGPA_StatusFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_Status field.
	''' </summary>
	Public Sub SetWFRNGPA_StatusFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_Status field.
	''' </summary>
	Public Sub SetWFRNGPA_StatusFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_Status field.
	''' </summary>
	Public Sub SetWFRNGPA_StatusFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_StatusColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_Date_Assign field.
	''' </summary>
	Public Function GetWFRNGPA_Date_AssignValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_Date_AssignColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_Date_Assign field.
	''' </summary>
	Public Function GetWFRNGPA_Date_AssignFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WFRNGPA_Date_AssignColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_Date_Assign field.
	''' </summary>
	Public Sub SetWFRNGPA_Date_AssignFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_Date_Assign field.
	''' </summary>
	Public Sub SetWFRNGPA_Date_AssignFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_Date_Assign field.
	''' </summary>
	Public Sub SetWFRNGPA_Date_AssignFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_Date_Action field.
	''' </summary>
	Public Function GetWFRNGPA_Date_ActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_Date_ActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_Date_Action field.
	''' </summary>
	Public Function GetWFRNGPA_Date_ActionFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WFRNGPA_Date_ActionColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_Date_Action field.
	''' </summary>
	Public Sub SetWFRNGPA_Date_ActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_Date_Action field.
	''' </summary>
	Public Sub SetWFRNGPA_Date_ActionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_Date_Action field.
	''' </summary>
	Public Sub SetWFRNGPA_Date_ActionFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_Remark field.
	''' </summary>
	Public Function GetWFRNGPA_RemarkValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_RemarkColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_Remark field.
	''' </summary>
	Public Function GetWFRNGPA_RemarkFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRNGPA_RemarkColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_Remark field.
	''' </summary>
	Public Sub SetWFRNGPA_RemarkFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_Remark field.
	''' </summary>
	Public Sub SetWFRNGPA_RemarkFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_Is_Done field.
	''' </summary>
	Public Function GetWFRNGPA_Is_DoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_Is_DoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_Is_Done field.
	''' </summary>
	Public Function GetWFRNGPA_Is_DoneFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WFRNGPA_Is_DoneColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_Is_Done field.
	''' </summary>
	Public Sub SetWFRNGPA_Is_DoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_Is_DoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_Is_Done field.
	''' </summary>
	Public Sub SetWFRNGPA_Is_DoneFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_Is_DoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_Is_Done field.
	''' </summary>
	Public Sub SetWFRNGPA_Is_DoneFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_Is_DoneColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_Code field.
	''' </summary>
	Public Function GetWFRNGPA_CodeValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_CodeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_Code field.
	''' </summary>
	Public Function GetWFRNGPA_CodeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRNGPA_CodeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_Code field.
	''' </summary>
	Public Sub SetWFRNGPA_CodeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_CodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_Code field.
	''' </summary>
	Public Sub SetWFRNGPA_CodeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_CodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_FinID field.
	''' </summary>
	Public Function GetWFRNGPA_FinIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_FinIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_FinID field.
	''' </summary>
	Public Function GetWFRNGPA_FinIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRNGPA_FinIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_FinID field.
	''' </summary>
	Public Sub SetWFRNGPA_FinIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_FinID field.
	''' </summary>
	Public Sub SetWFRNGPA_FinIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_FinID field.
	''' </summary>
	Public Sub SetWFRNGPA_FinIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_FinID field.
	''' </summary>
	Public Sub SetWFRNGPA_FinIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_FinID field.
	''' </summary>
	Public Sub SetWFRNGPA_FinIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_FinIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_WFRCHNGP_ID field.
	''' </summary>
	Public Function GetWFRNGPA_WFRCHNGP_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_WFRCHNGP_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_WFRCHNGP_ID field.
	''' </summary>
	Public Function GetWFRNGPA_WFRCHNGP_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRNGPA_WFRCHNGP_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WFRCHNGP_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_WFRCHNGP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WFRCHNGP_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_WFRCHNGP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WFRCHNGP_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WFRCHNGP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WFRCHNGP_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WFRCHNGP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Activity_.WFRNGPA_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WFRCHNGP_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WFRCHNGP_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_ID field.
	''' </summary>
	Public Property WFRNGPA_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRNGPA_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRNGPA_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRNGPA_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRNGPA_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRNGPA_IDDefault() As String
        Get
            Return TableUtils.WFRNGPA_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_WS_ID field.
	''' </summary>
	Public Property WFRNGPA_WS_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRNGPA_WS_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRNGPA_WS_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRNGPA_WS_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRNGPA_WS_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRNGPA_WS_IDDefault() As String
        Get
            Return TableUtils.WFRNGPA_WS_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_WSD_ID field.
	''' </summary>
	Public Property WFRNGPA_WSD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRNGPA_WSD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRNGPA_WSD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRNGPA_WSD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRNGPA_WSD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRNGPA_WSD_IDDefault() As String
        Get
            Return TableUtils.WFRNGPA_WSD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_WDT_ID field.
	''' </summary>
	Public Property WFRNGPA_WDT_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRNGPA_WDT_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRNGPA_WDT_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRNGPA_WDT_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRNGPA_WDT_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRNGPA_WDT_IDDefault() As String
        Get
            Return TableUtils.WFRNGPA_WDT_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_W_U_ID field.
	''' </summary>
	Public Property WFRNGPA_W_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRNGPA_W_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRNGPA_W_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRNGPA_W_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRNGPA_W_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRNGPA_W_U_IDDefault() As String
        Get
            Return TableUtils.WFRNGPA_W_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_W_U_ID_Delegate field.
	''' </summary>
	Public Property WFRNGPA_W_U_ID_Delegate() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRNGPA_W_U_ID_DelegateColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRNGPA_W_U_ID_DelegateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRNGPA_W_U_ID_DelegateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRNGPA_W_U_ID_DelegateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRNGPA_W_U_ID_DelegateDefault() As String
        Get
            Return TableUtils.WFRNGPA_W_U_ID_DelegateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_Status field.
	''' </summary>
	Public Property WFRNGPA_Status() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRNGPA_StatusColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRNGPA_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRNGPA_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRNGPA_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRNGPA_StatusDefault() As String
        Get
            Return TableUtils.WFRNGPA_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_Date_Assign field.
	''' </summary>
	Public Property WFRNGPA_Date_Assign() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WFRNGPA_Date_AssignColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRNGPA_Date_AssignColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRNGPA_Date_AssignSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRNGPA_Date_AssignColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRNGPA_Date_AssignDefault() As String
        Get
            Return TableUtils.WFRNGPA_Date_AssignColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_Date_Action field.
	''' </summary>
	Public Property WFRNGPA_Date_Action() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WFRNGPA_Date_ActionColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRNGPA_Date_ActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRNGPA_Date_ActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRNGPA_Date_ActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRNGPA_Date_ActionDefault() As String
        Get
            Return TableUtils.WFRNGPA_Date_ActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_Remark field.
	''' </summary>
	Public Property WFRNGPA_Remark() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WFRNGPA_RemarkColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WFRNGPA_RemarkColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRNGPA_RemarkSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRNGPA_RemarkColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRNGPA_RemarkDefault() As String
        Get
            Return TableUtils.WFRNGPA_RemarkColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_Is_Done field.
	''' </summary>
	Public Property WFRNGPA_Is_Done() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WFRNGPA_Is_DoneColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRNGPA_Is_DoneColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRNGPA_Is_DoneSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRNGPA_Is_DoneColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRNGPA_Is_DoneDefault() As String
        Get
            Return TableUtils.WFRNGPA_Is_DoneColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_Code field.
	''' </summary>
	Public Property WFRNGPA_Code() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WFRNGPA_CodeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WFRNGPA_CodeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRNGPA_CodeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRNGPA_CodeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRNGPA_CodeDefault() As String
        Get
            Return TableUtils.WFRNGPA_CodeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_FinID field.
	''' </summary>
	Public Property WFRNGPA_FinID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRNGPA_FinIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRNGPA_FinIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRNGPA_FinIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRNGPA_FinIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRNGPA_FinIDDefault() As String
        Get
            Return TableUtils.WFRNGPA_FinIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Activity_.WFRNGPA_WFRCHNGP_ID field.
	''' </summary>
	Public Property WFRNGPA_WFRCHNGP_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRNGPA_WFRCHNGP_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRNGPA_WFRCHNGP_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRNGPA_WFRCHNGP_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRNGPA_WFRCHNGP_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRNGPA_WFRCHNGP_IDDefault() As String
        Get
            Return TableUtils.WFRNGPA_WFRCHNGP_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
