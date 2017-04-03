' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WFIN_ApproverPage1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_WFIN_ApproverPage1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WFIN_ApproverPage1View"></see> class.
''' </remarks>
''' <seealso cref="Sel_WFIN_ApproverPage1View"></seealso>
''' <seealso cref="Sel_WFIN_ApproverPage1Record"></seealso>

<Serializable()> Public Class BaseSel_WFIN_ApproverPage1Record
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_WFIN_ApproverPage1View = Sel_WFIN_ApproverPage1View.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_WFIN_ApproverPage1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_WFIN_ApproverPage1Rec As Sel_WFIN_ApproverPage1Record = CType(sender,Sel_WFIN_ApproverPage1Record)
        If Not Sel_WFIN_ApproverPage1Rec Is Nothing AndAlso Not Sel_WFIN_ApproverPage1Rec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_WFIN_ApproverPage1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_WFIN_ApproverPage1Rec As Sel_WFIN_ApproverPage1Record = CType(sender,Sel_WFIN_ApproverPage1Record)
        Validate_Inserting()
        If Not Sel_WFIN_ApproverPage1Rec Is Nothing AndAlso Not Sel_WFIN_ApproverPage1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_ID field.
	''' </summary>
	Public Function GetAFIN_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AFIN_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_ID field.
	''' </summary>
	Public Function GetAFIN_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AFIN_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_ID field.
	''' </summary>
	Public Sub SetAFIN_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AFIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_ID field.
	''' </summary>
	Public Sub SetAFIN_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AFIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_ID field.
	''' </summary>
	Public Sub SetAFIN_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_ID field.
	''' </summary>
	Public Sub SetAFIN_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_ID field.
	''' </summary>
	Public Sub SetAFIN_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_WS_ID field.
	''' </summary>
	Public Function GetAFIN_WS_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AFIN_WS_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_WS_ID field.
	''' </summary>
	Public Function GetAFIN_WS_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AFIN_WS_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_WS_ID field.
	''' </summary>
	Public Sub SetAFIN_WS_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AFIN_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_WS_ID field.
	''' </summary>
	Public Sub SetAFIN_WS_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AFIN_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_WS_ID field.
	''' </summary>
	Public Sub SetAFIN_WS_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_WS_ID field.
	''' </summary>
	Public Sub SetAFIN_WS_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_WS_ID field.
	''' </summary>
	Public Sub SetAFIN_WS_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_WS_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_WSD_ID field.
	''' </summary>
	Public Function GetAFIN_WSD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AFIN_WSD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_WSD_ID field.
	''' </summary>
	Public Function GetAFIN_WSD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AFIN_WSD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_WSD_ID field.
	''' </summary>
	Public Sub SetAFIN_WSD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AFIN_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_WSD_ID field.
	''' </summary>
	Public Sub SetAFIN_WSD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AFIN_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_WSD_ID field.
	''' </summary>
	Public Sub SetAFIN_WSD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_WSD_ID field.
	''' </summary>
	Public Sub SetAFIN_WSD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_WSD_ID field.
	''' </summary>
	Public Sub SetAFIN_WSD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_WSD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_WDT_ID field.
	''' </summary>
	Public Function GetAFIN_WDT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AFIN_WDT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_WDT_ID field.
	''' </summary>
	Public Function GetAFIN_WDT_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AFIN_WDT_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_WDT_ID field.
	''' </summary>
	Public Sub SetAFIN_WDT_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AFIN_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_WDT_ID field.
	''' </summary>
	Public Sub SetAFIN_WDT_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AFIN_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_WDT_ID field.
	''' </summary>
	Public Sub SetAFIN_WDT_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_WDT_ID field.
	''' </summary>
	Public Sub SetAFIN_WDT_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_WDT_ID field.
	''' </summary>
	Public Sub SetAFIN_WDT_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_WDT_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_W_U_ID field.
	''' </summary>
	Public Function GetAFIN_W_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AFIN_W_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_W_U_ID field.
	''' </summary>
	Public Function GetAFIN_W_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AFIN_W_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_W_U_ID field.
	''' </summary>
	Public Sub SetAFIN_W_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AFIN_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_W_U_ID field.
	''' </summary>
	Public Sub SetAFIN_W_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AFIN_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_W_U_ID field.
	''' </summary>
	Public Sub SetAFIN_W_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_W_U_ID field.
	''' </summary>
	Public Sub SetAFIN_W_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_W_U_ID field.
	''' </summary>
	Public Sub SetAFIN_W_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_W_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_Status field.
	''' </summary>
	Public Function GetAFIN_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.AFIN_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_Status field.
	''' </summary>
	Public Function GetAFIN_StatusFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AFIN_StatusColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_Status field.
	''' </summary>
	Public Sub SetAFIN_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AFIN_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_Status field.
	''' </summary>
	Public Sub SetAFIN_StatusFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AFIN_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_Status field.
	''' </summary>
	Public Sub SetAFIN_StatusFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_Status field.
	''' </summary>
	Public Sub SetAFIN_StatusFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_Status field.
	''' </summary>
	Public Sub SetAFIN_StatusFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_StatusColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_Date_Assign field.
	''' </summary>
	Public Function GetAFIN_Date_AssignValue() As ColumnValue
		Return Me.GetValue(TableUtils.AFIN_Date_AssignColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_Date_Assign field.
	''' </summary>
	Public Function GetAFIN_Date_AssignFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.AFIN_Date_AssignColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_Date_Assign field.
	''' </summary>
	Public Sub SetAFIN_Date_AssignFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AFIN_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_Date_Assign field.
	''' </summary>
	Public Sub SetAFIN_Date_AssignFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AFIN_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_Date_Assign field.
	''' </summary>
	Public Sub SetAFIN_Date_AssignFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_Date_Action field.
	''' </summary>
	Public Function GetAFIN_Date_ActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.AFIN_Date_ActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_Date_Action field.
	''' </summary>
	Public Function GetAFIN_Date_ActionFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.AFIN_Date_ActionColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_Date_Action field.
	''' </summary>
	Public Sub SetAFIN_Date_ActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AFIN_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_Date_Action field.
	''' </summary>
	Public Sub SetAFIN_Date_ActionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AFIN_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_Date_Action field.
	''' </summary>
	Public Sub SetAFIN_Date_ActionFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_Remark field.
	''' </summary>
	Public Function GetAFIN_RemarkValue() As ColumnValue
		Return Me.GetValue(TableUtils.AFIN_RemarkColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_Remark field.
	''' </summary>
	Public Function GetAFIN_RemarkFieldValue() As String
		Return CType(Me.GetValue(TableUtils.AFIN_RemarkColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_Remark field.
	''' </summary>
	Public Sub SetAFIN_RemarkFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AFIN_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_Remark field.
	''' </summary>
	Public Sub SetAFIN_RemarkFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_Is_Done field.
	''' </summary>
	Public Function GetAFIN_Is_DoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.AFIN_Is_DoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_Is_Done field.
	''' </summary>
	Public Function GetAFIN_Is_DoneFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.AFIN_Is_DoneColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_Is_Done field.
	''' </summary>
	Public Sub SetAFIN_Is_DoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AFIN_Is_DoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_Is_Done field.
	''' </summary>
	Public Sub SetAFIN_Is_DoneFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AFIN_Is_DoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_Is_Done field.
	''' </summary>
	Public Sub SetAFIN_Is_DoneFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_Is_DoneColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_FinID field.
	''' </summary>
	Public Function GetAFIN_FinIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AFIN_FinIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_FinID field.
	''' </summary>
	Public Function GetAFIN_FinIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AFIN_FinIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_FinID field.
	''' </summary>
	Public Sub SetAFIN_FinIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AFIN_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_FinID field.
	''' </summary>
	Public Sub SetAFIN_FinIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AFIN_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_FinID field.
	''' </summary>
	Public Sub SetAFIN_FinIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_FinID field.
	''' </summary>
	Public Sub SetAFIN_FinIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.AFIN_FinID field.
	''' </summary>
	Public Sub SetAFIN_FinIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AFIN_FinIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.HFIN_C_ID field.
	''' </summary>
	Public Function GetHFIN_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.HFIN_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.HFIN_C_ID field.
	''' </summary>
	Public Function GetHFIN_C_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HFIN_C_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.HFIN_C_ID field.
	''' </summary>
	Public Sub SetHFIN_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HFIN_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.HFIN_C_ID field.
	''' </summary>
	Public Sub SetHFIN_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HFIN_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.HFIN_C_ID field.
	''' </summary>
	Public Sub SetHFIN_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.HFIN_C_ID field.
	''' </summary>
	Public Sub SetHFIN_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.HFIN_C_ID field.
	''' </summary>
	Public Sub SetHFIN_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.FIN_Year field.
	''' </summary>
	Public Function GetFIN_YearValue() As ColumnValue
		Return Me.GetValue(TableUtils.FIN_YearColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.FIN_Year field.
	''' </summary>
	Public Function GetFIN_YearFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FIN_YearColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.FIN_Year field.
	''' </summary>
	Public Sub SetFIN_YearFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FIN_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.FIN_Year field.
	''' </summary>
	Public Sub SetFIN_YearFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FIN_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.FIN_Year field.
	''' </summary>
	Public Sub SetFIN_YearFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.FIN_Year field.
	''' </summary>
	Public Sub SetFIN_YearFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.FIN_Year field.
	''' </summary>
	Public Sub SetFIN_YearFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_YearColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.FIN_Month field.
	''' </summary>
	Public Function GetFIN_MonthValue() As ColumnValue
		Return Me.GetValue(TableUtils.FIN_MonthColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.FIN_Month field.
	''' </summary>
	Public Function GetFIN_MonthFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FIN_MonthColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.FIN_Month field.
	''' </summary>
	Public Sub SetFIN_MonthFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FIN_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.FIN_Month field.
	''' </summary>
	Public Sub SetFIN_MonthFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FIN_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.FIN_Month field.
	''' </summary>
	Public Sub SetFIN_MonthFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.FIN_Month field.
	''' </summary>
	Public Sub SetFIN_MonthFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.FIN_Month field.
	''' </summary>
	Public Sub SetFIN_MonthFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_MonthColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.FIn_Description field.
	''' </summary>
	Public Function GetFIn_DescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.FIn_DescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.FIn_Description field.
	''' </summary>
	Public Function GetFIn_DescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FIn_DescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.FIn_Description field.
	''' </summary>
	Public Sub SetFIn_DescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FIn_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.FIn_Description field.
	''' </summary>
	Public Sub SetFIn_DescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIn_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.HFIN_ID field.
	''' </summary>
	Public Function GetHFIN_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.HFIN_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFIN_ApproverPage_.HFIN_ID field.
	''' </summary>
	Public Function GetHFIN_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HFIN_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.HFIN_ID field.
	''' </summary>
	Public Sub SetHFIN_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HFIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.HFIN_ID field.
	''' </summary>
	Public Sub SetHFIN_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HFIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.HFIN_ID field.
	''' </summary>
	Public Sub SetHFIN_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.HFIN_ID field.
	''' </summary>
	Public Sub SetHFIN_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFIN_ApproverPage_.HFIN_ID field.
	''' </summary>
	Public Sub SetHFIN_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_ID field.
	''' </summary>
	Public Property AFIN_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AFIN_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AFIN_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AFIN_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AFIN_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AFIN_IDDefault() As String
        Get
            Return TableUtils.AFIN_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_WS_ID field.
	''' </summary>
	Public Property AFIN_WS_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AFIN_WS_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AFIN_WS_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AFIN_WS_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AFIN_WS_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AFIN_WS_IDDefault() As String
        Get
            Return TableUtils.AFIN_WS_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_WSD_ID field.
	''' </summary>
	Public Property AFIN_WSD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AFIN_WSD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AFIN_WSD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AFIN_WSD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AFIN_WSD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AFIN_WSD_IDDefault() As String
        Get
            Return TableUtils.AFIN_WSD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_WDT_ID field.
	''' </summary>
	Public Property AFIN_WDT_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AFIN_WDT_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AFIN_WDT_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AFIN_WDT_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AFIN_WDT_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AFIN_WDT_IDDefault() As String
        Get
            Return TableUtils.AFIN_WDT_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_W_U_ID field.
	''' </summary>
	Public Property AFIN_W_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AFIN_W_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AFIN_W_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AFIN_W_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AFIN_W_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AFIN_W_U_IDDefault() As String
        Get
            Return TableUtils.AFIN_W_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_Status field.
	''' </summary>
	Public Property AFIN_Status() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AFIN_StatusColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AFIN_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AFIN_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AFIN_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AFIN_StatusDefault() As String
        Get
            Return TableUtils.AFIN_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_Date_Assign field.
	''' </summary>
	Public Property AFIN_Date_Assign() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.AFIN_Date_AssignColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AFIN_Date_AssignColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AFIN_Date_AssignSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AFIN_Date_AssignColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AFIN_Date_AssignDefault() As String
        Get
            Return TableUtils.AFIN_Date_AssignColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_Date_Action field.
	''' </summary>
	Public Property AFIN_Date_Action() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.AFIN_Date_ActionColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AFIN_Date_ActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AFIN_Date_ActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AFIN_Date_ActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AFIN_Date_ActionDefault() As String
        Get
            Return TableUtils.AFIN_Date_ActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_Remark field.
	''' </summary>
	Public Property AFIN_Remark() As String
		Get 
			Return CType(Me.GetValue(TableUtils.AFIN_RemarkColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.AFIN_RemarkColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AFIN_RemarkSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AFIN_RemarkColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AFIN_RemarkDefault() As String
        Get
            Return TableUtils.AFIN_RemarkColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_Is_Done field.
	''' </summary>
	Public Property AFIN_Is_Done() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.AFIN_Is_DoneColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AFIN_Is_DoneColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AFIN_Is_DoneSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AFIN_Is_DoneColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AFIN_Is_DoneDefault() As String
        Get
            Return TableUtils.AFIN_Is_DoneColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WFIN_ApproverPage_.AFIN_FinID field.
	''' </summary>
	Public Property AFIN_FinID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AFIN_FinIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AFIN_FinIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AFIN_FinIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AFIN_FinIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AFIN_FinIDDefault() As String
        Get
            Return TableUtils.AFIN_FinIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WFIN_ApproverPage_.HFIN_C_ID field.
	''' </summary>
	Public Property HFIN_C_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.HFIN_C_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HFIN_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HFIN_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HFIN_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HFIN_C_IDDefault() As String
        Get
            Return TableUtils.HFIN_C_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WFIN_ApproverPage_.FIN_Year field.
	''' </summary>
	Public Property FIN_Year() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FIN_YearColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FIN_YearColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FIN_YearSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FIN_YearColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FIN_YearDefault() As String
        Get
            Return TableUtils.FIN_YearColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WFIN_ApproverPage_.FIN_Month field.
	''' </summary>
	Public Property FIN_Month() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FIN_MonthColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FIN_MonthColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FIN_MonthSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FIN_MonthColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FIN_MonthDefault() As String
        Get
            Return TableUtils.FIN_MonthColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WFIN_ApproverPage_.FIn_Description field.
	''' </summary>
	Public Property FIn_Description() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FIn_DescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FIn_DescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FIn_DescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FIn_DescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FIn_DescriptionDefault() As String
        Get
            Return TableUtils.FIn_DescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WFIN_ApproverPage_.HFIN_ID field.
	''' </summary>
	Public Property HFIN_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.HFIN_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HFIN_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HFIN_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HFIN_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HFIN_IDDefault() As String
        Get
            Return TableUtils.HFIN_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
