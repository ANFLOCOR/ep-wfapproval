' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WFinRepNGP_ApproverPageRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_WFinRepNGP_ApproverPageRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WFinRepNGP_ApproverPageView"></see> class.
''' </remarks>
''' <seealso cref="Sel_WFinRepNGP_ApproverPageView"></seealso>
''' <seealso cref="Sel_WFinRepNGP_ApproverPageRecord"></seealso>

<Serializable()> Public Class BaseSel_WFinRepNGP_ApproverPageRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_WFinRepNGP_ApproverPageView = Sel_WFinRepNGP_ApproverPageView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_WFinRepNGP_ApproverPageRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_WFinRepNGP_ApproverPageRec As Sel_WFinRepNGP_ApproverPageRecord = CType(sender,Sel_WFinRepNGP_ApproverPageRecord)
        If Not Sel_WFinRepNGP_ApproverPageRec Is Nothing AndAlso Not Sel_WFinRepNGP_ApproverPageRec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_WFinRepNGP_ApproverPageRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_WFinRepNGP_ApproverPageRec As Sel_WFinRepNGP_ApproverPageRecord = CType(sender,Sel_WFinRepNGP_ApproverPageRecord)
        Validate_Inserting()
        If Not Sel_WFinRepNGP_ApproverPageRec Is Nothing AndAlso Not Sel_WFinRepNGP_ApproverPageRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_ID field.
	''' </summary>
	Public Function GetWFRNGPA_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_ID field.
	''' </summary>
	Public Function GetWFRNGPA_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRNGPA_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WS_ID field.
	''' </summary>
	Public Function GetWFRNGPA_WS_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_WS_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WS_ID field.
	''' </summary>
	Public Function GetWFRNGPA_WS_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRNGPA_WS_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WS_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WS_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WS_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WS_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WS_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WS_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WS_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WS_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WS_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WS_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WS_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WSD_ID field.
	''' </summary>
	Public Function GetWFRNGPA_WSD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_WSD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WSD_ID field.
	''' </summary>
	Public Function GetWFRNGPA_WSD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRNGPA_WSD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WSD_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WSD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WSD_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WSD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WSD_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WSD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WSD_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WSD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WSD_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WSD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WSD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WDT_ID field.
	''' </summary>
	Public Function GetWFRNGPA_WDT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_WDT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WDT_ID field.
	''' </summary>
	Public Function GetWFRNGPA_WDT_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRNGPA_WDT_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WDT_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WDT_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WDT_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WDT_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WDT_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WDT_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WDT_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WDT_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WDT_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WDT_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WDT_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_W_U_ID field.
	''' </summary>
	Public Function GetWFRNGPA_W_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_W_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_W_U_ID field.
	''' </summary>
	Public Function GetWFRNGPA_W_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRNGPA_W_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_W_U_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_W_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_W_U_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_W_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_W_U_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_W_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_W_U_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_W_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_W_U_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_W_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_W_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Status field.
	''' </summary>
	Public Function GetWFRNGPA_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Status field.
	''' </summary>
	Public Function GetWFRNGPA_StatusFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRNGPA_StatusColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Status field.
	''' </summary>
	Public Sub SetWFRNGPA_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Status field.
	''' </summary>
	Public Sub SetWFRNGPA_StatusFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Status field.
	''' </summary>
	Public Sub SetWFRNGPA_StatusFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Status field.
	''' </summary>
	Public Sub SetWFRNGPA_StatusFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Status field.
	''' </summary>
	Public Sub SetWFRNGPA_StatusFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_StatusColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Date_Assign field.
	''' </summary>
	Public Function GetWFRNGPA_Date_AssignValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_Date_AssignColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Date_Assign field.
	''' </summary>
	Public Function GetWFRNGPA_Date_AssignFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WFRNGPA_Date_AssignColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Date_Assign field.
	''' </summary>
	Public Sub SetWFRNGPA_Date_AssignFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Date_Assign field.
	''' </summary>
	Public Sub SetWFRNGPA_Date_AssignFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Date_Assign field.
	''' </summary>
	Public Sub SetWFRNGPA_Date_AssignFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Date_Action field.
	''' </summary>
	Public Function GetWFRNGPA_Date_ActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_Date_ActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Date_Action field.
	''' </summary>
	Public Function GetWFRNGPA_Date_ActionFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WFRNGPA_Date_ActionColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Date_Action field.
	''' </summary>
	Public Sub SetWFRNGPA_Date_ActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Date_Action field.
	''' </summary>
	Public Sub SetWFRNGPA_Date_ActionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Date_Action field.
	''' </summary>
	Public Sub SetWFRNGPA_Date_ActionFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Remark field.
	''' </summary>
	Public Function GetWFRNGPA_RemarkValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_RemarkColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Remark field.
	''' </summary>
	Public Function GetWFRNGPA_RemarkFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRNGPA_RemarkColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Remark field.
	''' </summary>
	Public Sub SetWFRNGPA_RemarkFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Remark field.
	''' </summary>
	Public Sub SetWFRNGPA_RemarkFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Is_Done field.
	''' </summary>
	Public Function GetWFRNGPA_Is_DoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_Is_DoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Is_Done field.
	''' </summary>
	Public Function GetWFRNGPA_Is_DoneFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WFRNGPA_Is_DoneColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Is_Done field.
	''' </summary>
	Public Sub SetWFRNGPA_Is_DoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_Is_DoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Is_Done field.
	''' </summary>
	Public Sub SetWFRNGPA_Is_DoneFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_Is_DoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Is_Done field.
	''' </summary>
	Public Sub SetWFRNGPA_Is_DoneFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_Is_DoneColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_FinID field.
	''' </summary>
	Public Function GetWFRNGPA_FinIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_FinIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_FinID field.
	''' </summary>
	Public Function GetWFRNGPA_FinIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRNGPA_FinIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_FinID field.
	''' </summary>
	Public Sub SetWFRNGPA_FinIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_FinID field.
	''' </summary>
	Public Sub SetWFRNGPA_FinIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_FinID field.
	''' </summary>
	Public Sub SetWFRNGPA_FinIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_FinID field.
	''' </summary>
	Public Sub SetWFRNGPA_FinIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_FinID field.
	''' </summary>
	Public Sub SetWFRNGPA_FinIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_FinIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRCHNGP_C_ID field.
	''' </summary>
	Public Function GetWFRCHNGP_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHNGP_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRCHNGP_C_ID field.
	''' </summary>
	Public Function GetWFRCHNGP_C_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCHNGP_C_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRCHNGP_C_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCHNGP_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRCHNGP_C_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCHNGP_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRCHNGP_C_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRCHNGP_C_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRCHNGP_C_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.FIN_Year field.
	''' </summary>
	Public Function GetFIN_YearValue() As ColumnValue
		Return Me.GetValue(TableUtils.FIN_YearColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.FIN_Year field.
	''' </summary>
	Public Function GetFIN_YearFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FIN_YearColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.FIN_Year field.
	''' </summary>
	Public Sub SetFIN_YearFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FIN_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.FIN_Year field.
	''' </summary>
	Public Sub SetFIN_YearFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FIN_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.FIN_Year field.
	''' </summary>
	Public Sub SetFIN_YearFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.FIN_Year field.
	''' </summary>
	Public Sub SetFIN_YearFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.FIN_Year field.
	''' </summary>
	Public Sub SetFIN_YearFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_YearColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.FIN_Month field.
	''' </summary>
	Public Function GetFIN_MonthValue() As ColumnValue
		Return Me.GetValue(TableUtils.FIN_MonthColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.FIN_Month field.
	''' </summary>
	Public Function GetFIN_MonthFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FIN_MonthColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.FIN_Month field.
	''' </summary>
	Public Sub SetFIN_MonthFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FIN_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.FIN_Month field.
	''' </summary>
	Public Sub SetFIN_MonthFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FIN_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.FIN_Month field.
	''' </summary>
	Public Sub SetFIN_MonthFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.FIN_Month field.
	''' </summary>
	Public Sub SetFIN_MonthFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.FIN_Month field.
	''' </summary>
	Public Sub SetFIN_MonthFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_MonthColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.FIn_Description field.
	''' </summary>
	Public Function GetFIn_DescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.FIn_DescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.FIn_Description field.
	''' </summary>
	Public Function GetFIn_DescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FIn_DescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.FIn_Description field.
	''' </summary>
	Public Sub SetFIn_DescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FIn_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.FIn_Description field.
	''' </summary>
	Public Sub SetFIn_DescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIn_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WFRCHNGP_ID field.
	''' </summary>
	Public Function GetWFRNGPA_WFRCHNGP_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPA_WFRCHNGP_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WFRCHNGP_ID field.
	''' </summary>
	Public Function GetWFRNGPA_WFRCHNGP_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRNGPA_WFRCHNGP_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WFRCHNGP_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPA_WFRCHNGP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WFRCHNGP_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPA_WFRCHNGP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WFRCHNGP_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WFRCHNGP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WFRCHNGP_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WFRCHNGP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRNGPA_WFRCHNGP_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPA_WFRCHNGP_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_ID field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WS_ID field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WSD_ID field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WDT_ID field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_W_U_ID field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Status field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Date_Assign field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Date_Action field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Remark field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_Is_Done field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_FinID field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRCHNGP_C_ID field.
	''' </summary>
	Public Property WFRCHNGP_C_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHNGP_C_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCHNGP_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHNGP_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHNGP_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHNGP_C_IDDefault() As String
        Get
            Return TableUtils.WFRCHNGP_C_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.FIN_Year field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.FIN_Month field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.FIn_Description field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_WFinRepNGP_ApproverPage_.WFRNGPA_WFRCHNGP_ID field.
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
