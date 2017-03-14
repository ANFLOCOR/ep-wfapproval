' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WCAR_Doc_Creator_Approver1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_WCAR_Doc_Creator_Approver1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WCAR_Doc_Creator_Approver1View"></see> class.
''' </remarks>
''' <seealso cref="Sel_WCAR_Doc_Creator_Approver1View"></seealso>
''' <seealso cref="Sel_WCAR_Doc_Creator_Approver1Record"></seealso>

<Serializable()> Public Class BaseSel_WCAR_Doc_Creator_Approver1Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_WCAR_Doc_Creator_Approver1View = Sel_WCAR_Doc_Creator_Approver1View.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_WCAR_Doc_Creator_Approver1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_WCAR_Doc_Creator_Approver1Rec As Sel_WCAR_Doc_Creator_Approver1Record = CType(sender,Sel_WCAR_Doc_Creator_Approver1Record)
        Validate_Inserting()
        If Not Sel_WCAR_Doc_Creator_Approver1Rec Is Nothing AndAlso Not Sel_WCAR_Doc_Creator_Approver1Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub Sel_WCAR_Doc_Creator_Approver1Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim Sel_WCAR_Doc_Creator_Approver1Rec As Sel_WCAR_Doc_Creator_Approver1Record = CType(sender,Sel_WCAR_Doc_Creator_Approver1Record)
        Validate_Updating()
        If Not Sel_WCAR_Doc_Creator_Approver1Rec Is Nothing AndAlso Not Sel_WCAR_Doc_Creator_Approver1Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_WCAR_Doc_Creator_Approver1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_WCAR_Doc_Creator_Approver1Rec As Sel_WCAR_Doc_Creator_Approver1Record = CType(sender,Sel_WCAR_Doc_Creator_Approver1Record)
        If Not Sel_WCAR_Doc_Creator_Approver1Rec Is Nothing AndAlso Not Sel_WCAR_Doc_Creator_Approver1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_ID field.
	''' </summary>
	Public Function GetWCD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_ID field.
	''' </summary>
	Public Function GetWCD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_ID field.
	''' </summary>
	Public Sub SetWCD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_ID field.
	''' </summary>
	Public Sub SetWCD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_ID field.
	''' </summary>
	Public Sub SetWCD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_ID field.
	''' </summary>
	Public Sub SetWCD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_ID field.
	''' </summary>
	Public Sub SetWCD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_WDT_ID field.
	''' </summary>
	Public Function GetWCD_WDT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_WDT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_WDT_ID field.
	''' </summary>
	Public Function GetWCD_WDT_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCD_WDT_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_WDT_ID field.
	''' </summary>
	Public Sub SetWCD_WDT_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_WDT_ID field.
	''' </summary>
	Public Sub SetWCD_WDT_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_WDT_ID field.
	''' </summary>
	Public Sub SetWCD_WDT_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_WDT_ID field.
	''' </summary>
	Public Sub SetWCD_WDT_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_WDT_ID field.
	''' </summary>
	Public Sub SetWCD_WDT_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_WDT_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_No field.
	''' </summary>
	Public Function GetWCD_NoValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_NoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_No field.
	''' </summary>
	Public Function GetWCD_NoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCD_NoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_No field.
	''' </summary>
	Public Sub SetWCD_NoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_No field.
	''' </summary>
	Public Sub SetWCD_NoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Submit field.
	''' </summary>
	Public Function GetWCD_SubmitValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_SubmitColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Submit field.
	''' </summary>
	Public Function GetWCD_SubmitFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCD_SubmitColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Submit field.
	''' </summary>
	Public Sub SetWCD_SubmitFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_SubmitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Submit field.
	''' </summary>
	Public Sub SetWCD_SubmitFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_SubmitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Submit field.
	''' </summary>
	Public Sub SetWCD_SubmitFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_SubmitColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Status field.
	''' </summary>
	Public Function GetWCD_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Status field.
	''' </summary>
	Public Function GetWCD_StatusFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCD_StatusColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Status field.
	''' </summary>
	Public Sub SetWCD_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Status field.
	''' </summary>
	Public Sub SetWCD_StatusFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Remark field.
	''' </summary>
	Public Function GetWCD_RemarkValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_RemarkColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Remark field.
	''' </summary>
	Public Function GetWCD_RemarkFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCD_RemarkColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Remark field.
	''' </summary>
	Public Sub SetWCD_RemarkFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Remark field.
	''' </summary>
	Public Sub SetWCD_RemarkFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Unit_Location field.
	''' </summary>
	Public Function GetWCD_Unit_LocationValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Unit_LocationColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Unit_Location field.
	''' </summary>
	Public Function GetWCD_Unit_LocationFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCD_Unit_LocationColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Unit_Location field.
	''' </summary>
	Public Sub SetWCD_Unit_LocationFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Unit_LocationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Unit_Location field.
	''' </summary>
	Public Sub SetWCD_Unit_LocationFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Unit_LocationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Project_Title field.
	''' </summary>
	Public Function GetWCD_Project_TitleValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Project_TitleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Project_Title field.
	''' </summary>
	Public Function GetWCD_Project_TitleFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCD_Project_TitleColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Project_Title field.
	''' </summary>
	Public Sub SetWCD_Project_TitleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Project_TitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Project_Title field.
	''' </summary>
	Public Sub SetWCD_Project_TitleFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Project_TitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Project_No field.
	''' </summary>
	Public Function GetWCD_Project_NoValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Project_NoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Project_No field.
	''' </summary>
	Public Function GetWCD_Project_NoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCD_Project_NoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Project_No field.
	''' </summary>
	Public Sub SetWCD_Project_NoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Project_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Project_No field.
	''' </summary>
	Public Sub SetWCD_Project_NoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Project_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Request_Date field.
	''' </summary>
	Public Function GetWCD_Request_DateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Request_DateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Request_Date field.
	''' </summary>
	Public Function GetWCD_Request_DateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WCD_Request_DateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Request_Date field.
	''' </summary>
	Public Sub SetWCD_Request_DateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Request_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Request_Date field.
	''' </summary>
	Public Sub SetWCD_Request_DateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_Request_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Request_Date field.
	''' </summary>
	Public Sub SetWCD_Request_DateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Request_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Proj_Inc_ACB field.
	''' </summary>
	Public Function GetWCD_Proj_Inc_ACBValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Proj_Inc_ACBColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Proj_Inc_ACB field.
	''' </summary>
	Public Function GetWCD_Proj_Inc_ACBFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCD_Proj_Inc_ACBColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Proj_Inc_ACB field.
	''' </summary>
	Public Sub SetWCD_Proj_Inc_ACBFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Proj_Inc_ACBColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Proj_Inc_ACB field.
	''' </summary>
	Public Sub SetWCD_Proj_Inc_ACBFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_Proj_Inc_ACBColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Proj_Inc_ACB field.
	''' </summary>
	Public Sub SetWCD_Proj_Inc_ACBFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Proj_Inc_ACBColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Total field.
	''' </summary>
	Public Function GetWCD_Exp_TotalValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Exp_TotalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Total field.
	''' </summary>
	Public Function GetWCD_Exp_TotalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCD_Exp_TotalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Exp_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_Exp_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_TotalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Prev_Total field.
	''' </summary>
	Public Function GetWCD_Exp_Prev_TotalValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Exp_Prev_TotalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Prev_Total field.
	''' </summary>
	Public Function GetWCD_Exp_Prev_TotalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCD_Exp_Prev_TotalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Prev_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_Prev_TotalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Exp_Prev_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Prev_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_Prev_TotalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_Exp_Prev_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Prev_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_Prev_TotalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_Prev_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Prev_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_Prev_TotalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_Prev_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Prev_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_Prev_TotalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_Prev_TotalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Budget field.
	''' </summary>
	Public Function GetWCD_Exp_BudgetValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Exp_BudgetColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Budget field.
	''' </summary>
	Public Function GetWCD_Exp_BudgetFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCD_Exp_BudgetColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Budget field.
	''' </summary>
	Public Sub SetWCD_Exp_BudgetFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Exp_BudgetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Budget field.
	''' </summary>
	Public Sub SetWCD_Exp_BudgetFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_Exp_BudgetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Budget field.
	''' </summary>
	Public Sub SetWCD_Exp_BudgetFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_BudgetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Budget field.
	''' </summary>
	Public Sub SetWCD_Exp_BudgetFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_BudgetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Budget field.
	''' </summary>
	Public Sub SetWCD_Exp_BudgetFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_BudgetColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Under_Over_Budget field.
	''' </summary>
	Public Function GetWCD_Exp_Under_Over_BudgetValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Exp_Under_Over_BudgetColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Under_Over_Budget field.
	''' </summary>
	Public Function GetWCD_Exp_Under_Over_BudgetFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCD_Exp_Under_Over_BudgetColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Under_Over_Budget field.
	''' </summary>
	Public Sub SetWCD_Exp_Under_Over_BudgetFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Exp_Under_Over_BudgetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Under_Over_Budget field.
	''' </summary>
	Public Sub SetWCD_Exp_Under_Over_BudgetFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_Exp_Under_Over_BudgetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Under_Over_Budget field.
	''' </summary>
	Public Sub SetWCD_Exp_Under_Over_BudgetFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_Under_Over_BudgetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Under_Over_Budget field.
	''' </summary>
	Public Sub SetWCD_Exp_Under_Over_BudgetFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_Under_Over_BudgetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Under_Over_Budget field.
	''' </summary>
	Public Sub SetWCD_Exp_Under_Over_BudgetFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_Under_Over_BudgetColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Cur_Yr field.
	''' </summary>
	Public Function GetWCD_Exp_Cur_YrValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Exp_Cur_YrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Cur_Yr field.
	''' </summary>
	Public Function GetWCD_Exp_Cur_YrFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCD_Exp_Cur_YrColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Cur_Yr field.
	''' </summary>
	Public Sub SetWCD_Exp_Cur_YrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Exp_Cur_YrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Cur_Yr field.
	''' </summary>
	Public Sub SetWCD_Exp_Cur_YrFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_Exp_Cur_YrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Cur_Yr field.
	''' </summary>
	Public Sub SetWCD_Exp_Cur_YrFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_Cur_YrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Cur_Yr field.
	''' </summary>
	Public Sub SetWCD_Exp_Cur_YrFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_Cur_YrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Cur_Yr field.
	''' </summary>
	Public Sub SetWCD_Exp_Cur_YrFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_Cur_YrColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Nxt_Yr field.
	''' </summary>
	Public Function GetWCD_Exp_Nxt_YrValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Exp_Nxt_YrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Nxt_Yr field.
	''' </summary>
	Public Function GetWCD_Exp_Nxt_YrFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCD_Exp_Nxt_YrColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Nxt_Yr field.
	''' </summary>
	Public Sub SetWCD_Exp_Nxt_YrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Exp_Nxt_YrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Nxt_Yr field.
	''' </summary>
	Public Sub SetWCD_Exp_Nxt_YrFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_Exp_Nxt_YrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Nxt_Yr field.
	''' </summary>
	Public Sub SetWCD_Exp_Nxt_YrFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_Nxt_YrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Nxt_Yr field.
	''' </summary>
	Public Sub SetWCD_Exp_Nxt_YrFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_Nxt_YrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Nxt_Yr field.
	''' </summary>
	Public Sub SetWCD_Exp_Nxt_YrFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_Nxt_YrColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Sub_Yr field.
	''' </summary>
	Public Function GetWCD_Exp_Sub_YrValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Exp_Sub_YrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Sub_Yr field.
	''' </summary>
	Public Function GetWCD_Exp_Sub_YrFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCD_Exp_Sub_YrColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Sub_Yr field.
	''' </summary>
	Public Sub SetWCD_Exp_Sub_YrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Exp_Sub_YrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Sub_Yr field.
	''' </summary>
	Public Sub SetWCD_Exp_Sub_YrFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_Exp_Sub_YrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Sub_Yr field.
	''' </summary>
	Public Sub SetWCD_Exp_Sub_YrFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_Sub_YrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Sub_Yr field.
	''' </summary>
	Public Sub SetWCD_Exp_Sub_YrFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_Sub_YrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Sub_Yr field.
	''' </summary>
	Public Sub SetWCD_Exp_Sub_YrFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_Sub_YrColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_C_ID field.
	''' </summary>
	Public Function GetWCD_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_C_ID field.
	''' </summary>
	Public Function GetWCD_C_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCD_C_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_U_ID field.
	''' </summary>
	Public Function GetWCD_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_U_ID field.
	''' </summary>
	Public Function GetWCD_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCD_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_U_ID field.
	''' </summary>
	Public Sub SetWCD_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_U_ID field.
	''' </summary>
	Public Sub SetWCD_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_U_ID field.
	''' </summary>
	Public Sub SetWCD_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_U_ID field.
	''' </summary>
	Public Sub SetWCD_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_U_ID field.
	''' </summary>
	Public Sub SetWCD_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Created field.
	''' </summary>
	Public Function GetWCD_CreatedValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_CreatedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Created field.
	''' </summary>
	Public Function GetWCD_CreatedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WCD_CreatedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Created field.
	''' </summary>
	Public Sub SetWCD_CreatedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_CreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Created field.
	''' </summary>
	Public Sub SetWCD_CreatedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_CreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Created field.
	''' </summary>
	Public Sub SetWCD_CreatedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_CreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_WCur_ID field.
	''' </summary>
	Public Function GetWCD_WCur_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_WCur_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_WCur_ID field.
	''' </summary>
	Public Function GetWCD_WCur_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCD_WCur_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_WCur_ID field.
	''' </summary>
	Public Sub SetWCD_WCur_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_WCur_ID field.
	''' </summary>
	Public Sub SetWCD_WCur_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_WCur_ID field.
	''' </summary>
	Public Sub SetWCD_WCur_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_WCur_ID field.
	''' </summary>
	Public Sub SetWCD_WCur_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_WCur_ID field.
	''' </summary>
	Public Sub SetWCD_WCur_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_WCur_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Supplementary field.
	''' </summary>
	Public Function GetWCD_SupplementaryValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_SupplementaryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Supplementary field.
	''' </summary>
	Public Function GetWCD_SupplementaryFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCD_SupplementaryColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Supplementary field.
	''' </summary>
	Public Sub SetWCD_SupplementaryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_SupplementaryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Supplementary field.
	''' </summary>
	Public Sub SetWCD_SupplementaryFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_SupplementaryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Supplementary field.
	''' </summary>
	Public Sub SetWCD_SupplementaryFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_SupplementaryColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Supplementary_WCD_ID field.
	''' </summary>
	Public Function GetWCD_Supplementary_WCD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Supplementary_WCD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Supplementary_WCD_ID field.
	''' </summary>
	Public Function GetWCD_Supplementary_WCD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCD_Supplementary_WCD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Supplementary_WCD_ID field.
	''' </summary>
	Public Sub SetWCD_Supplementary_WCD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Supplementary_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Supplementary_WCD_ID field.
	''' </summary>
	Public Sub SetWCD_Supplementary_WCD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_Supplementary_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Supplementary_WCD_ID field.
	''' </summary>
	Public Sub SetWCD_Supplementary_WCD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Supplementary_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Supplementary_WCD_ID field.
	''' </summary>
	Public Sub SetWCD_Supplementary_WCD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Supplementary_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Supplementary_WCD_ID field.
	''' </summary>
	Public Sub SetWCD_Supplementary_WCD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Supplementary_WCD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Supplementary_Manual field.
	''' </summary>
	Public Function GetWCD_Supplementary_ManualValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Supplementary_ManualColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Supplementary_Manual field.
	''' </summary>
	Public Function GetWCD_Supplementary_ManualFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCD_Supplementary_ManualColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Supplementary_Manual field.
	''' </summary>
	Public Sub SetWCD_Supplementary_ManualFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Supplementary_ManualColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Supplementary_Manual field.
	''' </summary>
	Public Sub SetWCD_Supplementary_ManualFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Supplementary_ManualColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.User_ID field.
	''' </summary>
	Public Function GetUser_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.User_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.User_ID field.
	''' </summary>
	Public Function GetUser_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.User_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.User_ID field.
	''' </summary>
	Public Sub SetUser_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.User_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.User_ID field.
	''' </summary>
	Public Sub SetUser_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.User_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.User_ID field.
	''' </summary>
	Public Sub SetUser_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.User_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.User_ID field.
	''' </summary>
	Public Sub SetUser_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.User_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.User_ID field.
	''' </summary>
	Public Sub SetUser_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.User_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.Row field.
	''' </summary>
	Public Function GetRowValue() As ColumnValue
		Return Me.GetValue(TableUtils.RowColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.Row field.
	''' </summary>
	Public Function GetRowFieldValue() As Int64
		Return CType(Me.GetValue(TableUtils.RowColumn).ToInt64(), Int64)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.Row field.
	''' </summary>
	Public Sub SetRowFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RowColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.Row field.
	''' </summary>
	Public Sub SetRowFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RowColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.Row field.
	''' </summary>
	Public Sub SetRowFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RowColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.Row field.
	''' </summary>
	Public Sub SetRowFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RowColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Creator_Approver_.Row field.
	''' </summary>
	Public Sub SetRowFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RowColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_ID field.
	''' </summary>
	Public Property WCD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_IDDefault() As String
        Get
            Return TableUtils.WCD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_WDT_ID field.
	''' </summary>
	Public Property WCD_WDT_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_WDT_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_WDT_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_WDT_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_WDT_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_WDT_IDDefault() As String
        Get
            Return TableUtils.WCD_WDT_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_No field.
	''' </summary>
	Public Property WCD_No() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_NoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCD_NoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_NoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_NoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_NoDefault() As String
        Get
            Return TableUtils.WCD_NoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Submit field.
	''' </summary>
	Public Property WCD_Submit() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_SubmitColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_SubmitColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_SubmitSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_SubmitColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_SubmitDefault() As String
        Get
            Return TableUtils.WCD_SubmitColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Status field.
	''' </summary>
	Public Property WCD_Status() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_StatusColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCD_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_StatusDefault() As String
        Get
            Return TableUtils.WCD_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Remark field.
	''' </summary>
	Public Property WCD_Remark() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_RemarkColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCD_RemarkColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_RemarkSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_RemarkColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_RemarkDefault() As String
        Get
            Return TableUtils.WCD_RemarkColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Unit_Location field.
	''' </summary>
	Public Property WCD_Unit_Location() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Unit_LocationColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCD_Unit_LocationColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Unit_LocationSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Unit_LocationColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Unit_LocationDefault() As String
        Get
            Return TableUtils.WCD_Unit_LocationColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Project_Title field.
	''' </summary>
	Public Property WCD_Project_Title() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Project_TitleColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCD_Project_TitleColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Project_TitleSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Project_TitleColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Project_TitleDefault() As String
        Get
            Return TableUtils.WCD_Project_TitleColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Project_No field.
	''' </summary>
	Public Property WCD_Project_No() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Project_NoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCD_Project_NoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Project_NoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Project_NoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Project_NoDefault() As String
        Get
            Return TableUtils.WCD_Project_NoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Request_Date field.
	''' </summary>
	Public Property WCD_Request_Date() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Request_DateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_Request_DateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Request_DateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Request_DateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Request_DateDefault() As String
        Get
            Return TableUtils.WCD_Request_DateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Proj_Inc_ACB field.
	''' </summary>
	Public Property WCD_Proj_Inc_ACB() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Proj_Inc_ACBColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_Proj_Inc_ACBColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Proj_Inc_ACBSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Proj_Inc_ACBColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Proj_Inc_ACBDefault() As String
        Get
            Return TableUtils.WCD_Proj_Inc_ACBColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Total field.
	''' </summary>
	Public Property WCD_Exp_Total() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Exp_TotalColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_Exp_TotalColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Exp_TotalSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Exp_TotalColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Exp_TotalDefault() As String
        Get
            Return TableUtils.WCD_Exp_TotalColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Prev_Total field.
	''' </summary>
	Public Property WCD_Exp_Prev_Total() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Exp_Prev_TotalColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_Exp_Prev_TotalColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Exp_Prev_TotalSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Exp_Prev_TotalColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Exp_Prev_TotalDefault() As String
        Get
            Return TableUtils.WCD_Exp_Prev_TotalColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Budget field.
	''' </summary>
	Public Property WCD_Exp_Budget() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Exp_BudgetColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_Exp_BudgetColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Exp_BudgetSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Exp_BudgetColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Exp_BudgetDefault() As String
        Get
            Return TableUtils.WCD_Exp_BudgetColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Under_Over_Budget field.
	''' </summary>
	Public Property WCD_Exp_Under_Over_Budget() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Exp_Under_Over_BudgetColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_Exp_Under_Over_BudgetColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Exp_Under_Over_BudgetSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Exp_Under_Over_BudgetColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Exp_Under_Over_BudgetDefault() As String
        Get
            Return TableUtils.WCD_Exp_Under_Over_BudgetColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Cur_Yr field.
	''' </summary>
	Public Property WCD_Exp_Cur_Yr() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Exp_Cur_YrColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_Exp_Cur_YrColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Exp_Cur_YrSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Exp_Cur_YrColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Exp_Cur_YrDefault() As String
        Get
            Return TableUtils.WCD_Exp_Cur_YrColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Nxt_Yr field.
	''' </summary>
	Public Property WCD_Exp_Nxt_Yr() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Exp_Nxt_YrColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_Exp_Nxt_YrColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Exp_Nxt_YrSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Exp_Nxt_YrColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Exp_Nxt_YrDefault() As String
        Get
            Return TableUtils.WCD_Exp_Nxt_YrColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Exp_Sub_Yr field.
	''' </summary>
	Public Property WCD_Exp_Sub_Yr() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Exp_Sub_YrColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_Exp_Sub_YrColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Exp_Sub_YrSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Exp_Sub_YrColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Exp_Sub_YrDefault() As String
        Get
            Return TableUtils.WCD_Exp_Sub_YrColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_C_ID field.
	''' </summary>
	Public Property WCD_C_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_C_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_C_IDDefault() As String
        Get
            Return TableUtils.WCD_C_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_U_ID field.
	''' </summary>
	Public Property WCD_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_U_IDDefault() As String
        Get
            Return TableUtils.WCD_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Created field.
	''' </summary>
	Public Property WCD_Created() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_CreatedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_CreatedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_CreatedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_CreatedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_CreatedDefault() As String
        Get
            Return TableUtils.WCD_CreatedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_WCur_ID field.
	''' </summary>
	Public Property WCD_WCur_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_WCur_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_WCur_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_WCur_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_WCur_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_WCur_IDDefault() As String
        Get
            Return TableUtils.WCD_WCur_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Supplementary field.
	''' </summary>
	Public Property WCD_Supplementary() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_SupplementaryColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_SupplementaryColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_SupplementarySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_SupplementaryColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_SupplementaryDefault() As String
        Get
            Return TableUtils.WCD_SupplementaryColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Supplementary_WCD_ID field.
	''' </summary>
	Public Property WCD_Supplementary_WCD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Supplementary_WCD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_Supplementary_WCD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Supplementary_WCD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Supplementary_WCD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Supplementary_WCD_IDDefault() As String
        Get
            Return TableUtils.WCD_Supplementary_WCD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.WCD_Supplementary_Manual field.
	''' </summary>
	Public Property WCD_Supplementary_Manual() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Supplementary_ManualColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCD_Supplementary_ManualColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Supplementary_ManualSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Supplementary_ManualColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Supplementary_ManualDefault() As String
        Get
            Return TableUtils.WCD_Supplementary_ManualColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.User_ID field.
	''' </summary>
	Public Property User_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.User_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.User_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property User_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.User_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property User_IDDefault() As String
        Get
            Return TableUtils.User_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Creator_Approver_.Row field.
	''' </summary>
	Public Property Row() As Int64
		Get 
			Return CType(Me.GetValue(TableUtils.RowColumn).ToInt64(), Int64)
		End Get
		Set (ByVal val As Int64) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RowColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RowSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RowColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RowDefault() As String
        Get
            Return TableUtils.RowColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
