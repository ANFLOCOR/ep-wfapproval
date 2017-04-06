' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRep_HeadRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WFinRep_HeadRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WFinRep_HeadTable"></see> class.
''' </remarks>
''' <seealso cref="WFinRep_HeadTable"></seealso>
''' <seealso cref="WFinRep_HeadRecord"></seealso>

<Serializable()> Public Class BaseWFinRep_HeadRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WFinRep_HeadTable = WFinRep_HeadTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WFinRep_HeadRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WFinRep_HeadRec As WFinRep_HeadRecord = CType(sender,WFinRep_HeadRecord)
        Validate_Inserting()
        If Not WFinRep_HeadRec Is Nothing AndAlso Not WFinRep_HeadRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WFinRep_HeadRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WFinRep_HeadRec As WFinRep_HeadRecord = CType(sender,WFinRep_HeadRecord)
        Validate_Updating()
        If Not WFinRep_HeadRec Is Nothing AndAlso Not WFinRep_HeadRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WFinRep_HeadRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WFinRep_HeadRec As WFinRep_HeadRecord = CType(sender,WFinRep_HeadRecord)
        If Not WFinRep_HeadRec Is Nothing AndAlso Not WFinRep_HeadRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_ID field.
	''' </summary>
	Public Function GetHFIN_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.HFIN_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_ID field.
	''' </summary>
	Public Function GetHFIN_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HFIN_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_Year field.
	''' </summary>
	Public Function GetHFIN_YearValue() As ColumnValue
		Return Me.GetValue(TableUtils.HFIN_YearColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_Year field.
	''' </summary>
	Public Function GetHFIN_YearFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HFIN_YearColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Year field.
	''' </summary>
	Public Sub SetHFIN_YearFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HFIN_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Year field.
	''' </summary>
	Public Sub SetHFIN_YearFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HFIN_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Year field.
	''' </summary>
	Public Sub SetHFIN_YearFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Year field.
	''' </summary>
	Public Sub SetHFIN_YearFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Year field.
	''' </summary>
	Public Sub SetHFIN_YearFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_YearColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_Month field.
	''' </summary>
	Public Function GetHFIN_MonthValue() As ColumnValue
		Return Me.GetValue(TableUtils.HFIN_MonthColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_Month field.
	''' </summary>
	Public Function GetHFIN_MonthFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HFIN_MonthColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Month field.
	''' </summary>
	Public Sub SetHFIN_MonthFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HFIN_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Month field.
	''' </summary>
	Public Sub SetHFIN_MonthFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HFIN_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Month field.
	''' </summary>
	Public Sub SetHFIN_MonthFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Month field.
	''' </summary>
	Public Sub SetHFIN_MonthFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Month field.
	''' </summary>
	Public Sub SetHFIN_MonthFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_MonthColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_DT_ID field.
	''' </summary>
	Public Function GetHFIN_DT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.HFIN_DT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_DT_ID field.
	''' </summary>
	Public Function GetHFIN_DT_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HFIN_DT_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_DT_ID field.
	''' </summary>
	Public Sub SetHFIN_DT_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HFIN_DT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_DT_ID field.
	''' </summary>
	Public Sub SetHFIN_DT_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HFIN_DT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_DT_ID field.
	''' </summary>
	Public Sub SetHFIN_DT_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_DT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_DT_ID field.
	''' </summary>
	Public Sub SetHFIN_DT_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_DT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_DT_ID field.
	''' </summary>
	Public Sub SetHFIN_DT_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_DT_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_Code field.
	''' </summary>
	Public Function GetHFIN_CodeValue() As ColumnValue
		Return Me.GetValue(TableUtils.HFIN_CodeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_Code field.
	''' </summary>
	Public Function GetHFIN_CodeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.HFIN_CodeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Code field.
	''' </summary>
	Public Sub SetHFIN_CodeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HFIN_CodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Code field.
	''' </summary>
	Public Sub SetHFIN_CodeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_CodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_Submit field.
	''' </summary>
	Public Function GetHFIN_SubmitValue() As ColumnValue
		Return Me.GetValue(TableUtils.HFIN_SubmitColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_Submit field.
	''' </summary>
	Public Function GetHFIN_SubmitFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.HFIN_SubmitColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Submit field.
	''' </summary>
	Public Sub SetHFIN_SubmitFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HFIN_SubmitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Submit field.
	''' </summary>
	Public Sub SetHFIN_SubmitFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HFIN_SubmitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Submit field.
	''' </summary>
	Public Sub SetHFIN_SubmitFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_SubmitColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_Status field.
	''' </summary>
	Public Function GetHFIN_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.HFIN_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_Status field.
	''' </summary>
	Public Function GetHFIN_StatusFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HFIN_StatusColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Status field.
	''' </summary>
	Public Sub SetHFIN_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HFIN_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Status field.
	''' </summary>
	Public Sub SetHFIN_StatusFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HFIN_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Status field.
	''' </summary>
	Public Sub SetHFIN_StatusFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Status field.
	''' </summary>
	Public Sub SetHFIN_StatusFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Status field.
	''' </summary>
	Public Sub SetHFIN_StatusFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_StatusColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_C_ID field.
	''' </summary>
	Public Function GetHFIN_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.HFIN_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_C_ID field.
	''' </summary>
	Public Function GetHFIN_C_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HFIN_C_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_C_ID field.
	''' </summary>
	Public Sub SetHFIN_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HFIN_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_C_ID field.
	''' </summary>
	Public Sub SetHFIN_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HFIN_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_C_ID field.
	''' </summary>
	Public Sub SetHFIN_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_C_ID field.
	''' </summary>
	Public Sub SetHFIN_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_C_ID field.
	''' </summary>
	Public Sub SetHFIN_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_U_ID field.
	''' </summary>
	Public Function GetHFIN_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.HFIN_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_U_ID field.
	''' </summary>
	Public Function GetHFIN_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HFIN_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_U_ID field.
	''' </summary>
	Public Sub SetHFIN_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HFIN_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_U_ID field.
	''' </summary>
	Public Sub SetHFIN_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HFIN_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_U_ID field.
	''' </summary>
	Public Sub SetHFIN_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_U_ID field.
	''' </summary>
	Public Sub SetHFIN_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_U_ID field.
	''' </summary>
	Public Sub SetHFIN_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_Remark field.
	''' </summary>
	Public Function GetHFIN_RemarkValue() As ColumnValue
		Return Me.GetValue(TableUtils.HFIN_RemarkColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_Remark field.
	''' </summary>
	Public Function GetHFIN_RemarkFieldValue() As String
		Return CType(Me.GetValue(TableUtils.HFIN_RemarkColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Remark field.
	''' </summary>
	Public Sub SetHFIN_RemarkFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HFIN_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Remark field.
	''' </summary>
	Public Sub SetHFIN_RemarkFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_PRTCNT field.
	''' </summary>
	Public Function GetHFIN_PRTCNTValue() As ColumnValue
		Return Me.GetValue(TableUtils.HFIN_PRTCNTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_PRTCNT field.
	''' </summary>
	Public Function GetHFIN_PRTCNTFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HFIN_PRTCNTColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_PRTCNT field.
	''' </summary>
	Public Sub SetHFIN_PRTCNTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HFIN_PRTCNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_PRTCNT field.
	''' </summary>
	Public Sub SetHFIN_PRTCNTFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HFIN_PRTCNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_PRTCNT field.
	''' </summary>
	Public Sub SetHFIN_PRTCNTFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_PRTCNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_PRTCNT field.
	''' </summary>
	Public Sub SetHFIN_PRTCNTFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_PRTCNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_PRTCNT field.
	''' </summary>
	Public Sub SetHFIN_PRTCNTFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_PRTCNTColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_FinID field.
	''' </summary>
	Public Function GetHFIN_FinIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.HFIN_FinIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_FinID field.
	''' </summary>
	Public Function GetHFIN_FinIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HFIN_FinIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_FinID field.
	''' </summary>
	Public Sub SetHFIN_FinIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HFIN_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_FinID field.
	''' </summary>
	Public Sub SetHFIN_FinIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HFIN_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_FinID field.
	''' </summary>
	Public Sub SetHFIN_FinIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_FinID field.
	''' </summary>
	Public Sub SetHFIN_FinIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_FinID field.
	''' </summary>
	Public Sub SetHFIN_FinIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_FinIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_RptCount field.
	''' </summary>
	Public Function GetHFIN_RptCountValue() As ColumnValue
		Return Me.GetValue(TableUtils.HFIN_RptCountColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_RptCount field.
	''' </summary>
	Public Function GetHFIN_RptCountFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.HFIN_RptCountColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_RptCount field.
	''' </summary>
	Public Sub SetHFIN_RptCountFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HFIN_RptCountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_RptCount field.
	''' </summary>
	Public Sub SetHFIN_RptCountFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HFIN_RptCountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_RptCount field.
	''' </summary>
	Public Sub SetHFIN_RptCountFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_RptCountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_RptCount field.
	''' </summary>
	Public Sub SetHFIN_RptCountFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_RptCountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_RptCount field.
	''' </summary>
	Public Sub SetHFIN_RptCountFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_RptCountColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_Description field.
	''' </summary>
	Public Function GetHFIN_DescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.HFIN_DescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_Description field.
	''' </summary>
	Public Function GetHFIN_DescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.HFIN_DescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Description field.
	''' </summary>
	Public Sub SetHFIN_DescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HFIN_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_Description field.
	''' </summary>
	Public Sub SetHFIN_DescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_File field.
	''' </summary>
	Public Function GetHFIN_FileValue() As ColumnValue
		Return Me.GetValue(TableUtils.HFIN_FileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_Head_.HFIN_File field.
	''' </summary>
	Public Function GetHFIN_FileFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.HFIN_FileColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_File field.
	''' </summary>
	Public Sub SetHFIN_FileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.HFIN_FileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_File field.
	''' </summary>
	Public Sub SetHFIN_FileFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.HFIN_FileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_Head_.HFIN_File field.
	''' </summary>
	Public Sub SetHFIN_FileFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.HFIN_FileColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_Head_.HFIN_ID field.
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_Head_.HFIN_Year field.
	''' </summary>
	Public Property HFIN_Year() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.HFIN_YearColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HFIN_YearColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HFIN_YearSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HFIN_YearColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HFIN_YearDefault() As String
        Get
            Return TableUtils.HFIN_YearColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_Head_.HFIN_Month field.
	''' </summary>
	Public Property HFIN_Month() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.HFIN_MonthColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HFIN_MonthColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HFIN_MonthSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HFIN_MonthColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HFIN_MonthDefault() As String
        Get
            Return TableUtils.HFIN_MonthColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_Head_.HFIN_DT_ID field.
	''' </summary>
	Public Property HFIN_DT_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.HFIN_DT_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HFIN_DT_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HFIN_DT_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HFIN_DT_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HFIN_DT_IDDefault() As String
        Get
            Return TableUtils.HFIN_DT_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_Head_.HFIN_Code field.
	''' </summary>
	Public Property HFIN_Code() As String
		Get 
			Return CType(Me.GetValue(TableUtils.HFIN_CodeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.HFIN_CodeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HFIN_CodeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HFIN_CodeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HFIN_CodeDefault() As String
        Get
            Return TableUtils.HFIN_CodeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_Head_.HFIN_Submit field.
	''' </summary>
	Public Property HFIN_Submit() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.HFIN_SubmitColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HFIN_SubmitColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HFIN_SubmitSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HFIN_SubmitColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HFIN_SubmitDefault() As String
        Get
            Return TableUtils.HFIN_SubmitColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_Head_.HFIN_Status field.
	''' </summary>
	Public Property HFIN_Status() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.HFIN_StatusColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HFIN_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HFIN_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HFIN_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HFIN_StatusDefault() As String
        Get
            Return TableUtils.HFIN_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_Head_.HFIN_C_ID field.
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
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_Head_.HFIN_U_ID field.
	''' </summary>
	Public Property HFIN_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.HFIN_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HFIN_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HFIN_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HFIN_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HFIN_U_IDDefault() As String
        Get
            Return TableUtils.HFIN_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_Head_.HFIN_Remark field.
	''' </summary>
	Public Property HFIN_Remark() As String
		Get 
			Return CType(Me.GetValue(TableUtils.HFIN_RemarkColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.HFIN_RemarkColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HFIN_RemarkSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HFIN_RemarkColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HFIN_RemarkDefault() As String
        Get
            Return TableUtils.HFIN_RemarkColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_Head_.HFIN_PRTCNT field.
	''' </summary>
	Public Property HFIN_PRTCNT() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.HFIN_PRTCNTColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HFIN_PRTCNTColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HFIN_PRTCNTSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HFIN_PRTCNTColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HFIN_PRTCNTDefault() As String
        Get
            Return TableUtils.HFIN_PRTCNTColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_Head_.HFIN_FinID field.
	''' </summary>
	Public Property HFIN_FinID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.HFIN_FinIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HFIN_FinIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HFIN_FinIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HFIN_FinIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HFIN_FinIDDefault() As String
        Get
            Return TableUtils.HFIN_FinIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_Head_.HFIN_RptCount field.
	''' </summary>
	Public Property HFIN_RptCount() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.HFIN_RptCountColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HFIN_RptCountColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HFIN_RptCountSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HFIN_RptCountColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HFIN_RptCountDefault() As String
        Get
            Return TableUtils.HFIN_RptCountColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_Head_.HFIN_Description field.
	''' </summary>
	Public Property HFIN_Description() As String
		Get 
			Return CType(Me.GetValue(TableUtils.HFIN_DescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.HFIN_DescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HFIN_DescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HFIN_DescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HFIN_DescriptionDefault() As String
        Get
            Return TableUtils.HFIN_DescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_Head_.HFIN_File field.
	''' </summary>
	Public Property HFIN_File() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.HFIN_FileColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.HFIN_FileColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property HFIN_FileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.HFIN_FileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property HFIN_FileDefault() As String
        Get
            Return TableUtils.HFIN_FileColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
