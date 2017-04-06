' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRepCon_HeadRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WFinRepCon_HeadRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WFinRepCon_HeadTable"></see> class.
''' </remarks>
''' <seealso cref="WFinRepCon_HeadTable"></seealso>
''' <seealso cref="WFinRepCon_HeadRecord"></seealso>

<Serializable()> Public Class BaseWFinRepCon_HeadRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WFinRepCon_HeadTable = WFinRepCon_HeadTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WFinRepCon_HeadRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WFinRepCon_HeadRec As WFinRepCon_HeadRecord = CType(sender,WFinRepCon_HeadRecord)
        Validate_Inserting()
        If Not WFinRepCon_HeadRec Is Nothing AndAlso Not WFinRepCon_HeadRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WFinRepCon_HeadRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WFinRepCon_HeadRec As WFinRepCon_HeadRecord = CType(sender,WFinRepCon_HeadRecord)
        Validate_Updating()
        If Not WFinRepCon_HeadRec Is Nothing AndAlso Not WFinRepCon_HeadRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WFinRepCon_HeadRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WFinRepCon_HeadRec As WFinRepCon_HeadRecord = CType(sender,WFinRepCon_HeadRecord)
        If Not WFinRepCon_HeadRec Is Nothing AndAlso Not WFinRepCon_HeadRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_ID field.
	''' </summary>
	Public Function GetWFRCH_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCH_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_ID field.
	''' </summary>
	Public Function GetWFRCH_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCH_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Year field.
	''' </summary>
	Public Function GetWFRCH_YearValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCH_YearColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Year field.
	''' </summary>
	Public Function GetWFRCH_YearFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCH_YearColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Year field.
	''' </summary>
	Public Sub SetWFRCH_YearFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCH_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Year field.
	''' </summary>
	Public Sub SetWFRCH_YearFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCH_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Year field.
	''' </summary>
	Public Sub SetWFRCH_YearFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Year field.
	''' </summary>
	Public Sub SetWFRCH_YearFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Year field.
	''' </summary>
	Public Sub SetWFRCH_YearFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_YearColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Month field.
	''' </summary>
	Public Function GetWFRCH_MonthValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCH_MonthColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Month field.
	''' </summary>
	Public Function GetWFRCH_MonthFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCH_MonthColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Month field.
	''' </summary>
	Public Sub SetWFRCH_MonthFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCH_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Month field.
	''' </summary>
	Public Sub SetWFRCH_MonthFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCH_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Month field.
	''' </summary>
	Public Sub SetWFRCH_MonthFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Month field.
	''' </summary>
	Public Sub SetWFRCH_MonthFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Month field.
	''' </summary>
	Public Sub SetWFRCH_MonthFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_MonthColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_DT_ID field.
	''' </summary>
	Public Function GetWFRCH_DT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCH_DT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_DT_ID field.
	''' </summary>
	Public Function GetWFRCH_DT_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCH_DT_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_DT_ID field.
	''' </summary>
	Public Sub SetWFRCH_DT_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCH_DT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_DT_ID field.
	''' </summary>
	Public Sub SetWFRCH_DT_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCH_DT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_DT_ID field.
	''' </summary>
	Public Sub SetWFRCH_DT_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_DT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_DT_ID field.
	''' </summary>
	Public Sub SetWFRCH_DT_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_DT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_DT_ID field.
	''' </summary>
	Public Sub SetWFRCH_DT_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_DT_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Code field.
	''' </summary>
	Public Function GetWFRCH_CodeValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCH_CodeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Code field.
	''' </summary>
	Public Function GetWFRCH_CodeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRCH_CodeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Code field.
	''' </summary>
	Public Sub SetWFRCH_CodeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCH_CodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Code field.
	''' </summary>
	Public Sub SetWFRCH_CodeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_CodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Submit field.
	''' </summary>
	Public Function GetWFRCH_SubmitValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCH_SubmitColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Submit field.
	''' </summary>
	Public Function GetWFRCH_SubmitFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WFRCH_SubmitColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Submit field.
	''' </summary>
	Public Sub SetWFRCH_SubmitFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCH_SubmitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Submit field.
	''' </summary>
	Public Sub SetWFRCH_SubmitFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCH_SubmitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Submit field.
	''' </summary>
	Public Sub SetWFRCH_SubmitFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_SubmitColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Status field.
	''' </summary>
	Public Function GetWFRCH_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCH_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Status field.
	''' </summary>
	Public Function GetWFRCH_StatusFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCH_StatusColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Status field.
	''' </summary>
	Public Sub SetWFRCH_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCH_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Status field.
	''' </summary>
	Public Sub SetWFRCH_StatusFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCH_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Status field.
	''' </summary>
	Public Sub SetWFRCH_StatusFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Status field.
	''' </summary>
	Public Sub SetWFRCH_StatusFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Status field.
	''' </summary>
	Public Sub SetWFRCH_StatusFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_StatusColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_C_ID field.
	''' </summary>
	Public Function GetWFRCH_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCH_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_C_ID field.
	''' </summary>
	Public Function GetWFRCH_C_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCH_C_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_C_ID field.
	''' </summary>
	Public Sub SetWFRCH_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCH_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_C_ID field.
	''' </summary>
	Public Sub SetWFRCH_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCH_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_C_ID field.
	''' </summary>
	Public Sub SetWFRCH_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_C_ID field.
	''' </summary>
	Public Sub SetWFRCH_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_C_ID field.
	''' </summary>
	Public Sub SetWFRCH_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_U_ID field.
	''' </summary>
	Public Function GetWFRCH_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCH_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_U_ID field.
	''' </summary>
	Public Function GetWFRCH_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCH_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_U_ID field.
	''' </summary>
	Public Sub SetWFRCH_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCH_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_U_ID field.
	''' </summary>
	Public Sub SetWFRCH_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCH_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_U_ID field.
	''' </summary>
	Public Sub SetWFRCH_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_U_ID field.
	''' </summary>
	Public Sub SetWFRCH_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_U_ID field.
	''' </summary>
	Public Sub SetWFRCH_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Remark field.
	''' </summary>
	Public Function GetWFRCH_RemarkValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCH_RemarkColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Remark field.
	''' </summary>
	Public Function GetWFRCH_RemarkFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRCH_RemarkColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Remark field.
	''' </summary>
	Public Sub SetWFRCH_RemarkFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCH_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Remark field.
	''' </summary>
	Public Sub SetWFRCH_RemarkFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_PRTCNT field.
	''' </summary>
	Public Function GetWFRCH_PRTCNTValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCH_PRTCNTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_PRTCNT field.
	''' </summary>
	Public Function GetWFRCH_PRTCNTFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCH_PRTCNTColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_PRTCNT field.
	''' </summary>
	Public Sub SetWFRCH_PRTCNTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCH_PRTCNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_PRTCNT field.
	''' </summary>
	Public Sub SetWFRCH_PRTCNTFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCH_PRTCNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_PRTCNT field.
	''' </summary>
	Public Sub SetWFRCH_PRTCNTFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_PRTCNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_PRTCNT field.
	''' </summary>
	Public Sub SetWFRCH_PRTCNTFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_PRTCNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_PRTCNT field.
	''' </summary>
	Public Sub SetWFRCH_PRTCNTFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_PRTCNTColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_FinID field.
	''' </summary>
	Public Function GetWFRCH_FinIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCH_FinIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_FinID field.
	''' </summary>
	Public Function GetWFRCH_FinIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCH_FinIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_FinID field.
	''' </summary>
	Public Sub SetWFRCH_FinIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCH_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_FinID field.
	''' </summary>
	Public Sub SetWFRCH_FinIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCH_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_FinID field.
	''' </summary>
	Public Sub SetWFRCH_FinIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_FinID field.
	''' </summary>
	Public Sub SetWFRCH_FinIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_FinID field.
	''' </summary>
	Public Sub SetWFRCH_FinIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_FinIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_RptCount field.
	''' </summary>
	Public Function GetWFRCH_RptCountValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCH_RptCountColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_RptCount field.
	''' </summary>
	Public Function GetWFRCH_RptCountFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCH_RptCountColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_RptCount field.
	''' </summary>
	Public Sub SetWFRCH_RptCountFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCH_RptCountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_RptCount field.
	''' </summary>
	Public Sub SetWFRCH_RptCountFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCH_RptCountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_RptCount field.
	''' </summary>
	Public Sub SetWFRCH_RptCountFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_RptCountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_RptCount field.
	''' </summary>
	Public Sub SetWFRCH_RptCountFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_RptCountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_RptCount field.
	''' </summary>
	Public Sub SetWFRCH_RptCountFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_RptCountColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Description field.
	''' </summary>
	Public Function GetWFRCH_DescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCH_DescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Description field.
	''' </summary>
	Public Function GetWFRCH_DescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRCH_DescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Description field.
	''' </summary>
	Public Sub SetWFRCH_DescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCH_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_Description field.
	''' </summary>
	Public Sub SetWFRCH_DescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_File field.
	''' </summary>
	Public Function GetWFRCH_FileValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCH_FileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_File field.
	''' </summary>
	Public Function GetWFRCH_FileFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.WFRCH_FileColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_File field.
	''' </summary>
	Public Sub SetWFRCH_FileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCH_FileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_File field.
	''' </summary>
	Public Sub SetWFRCH_FileFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCH_FileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_Head_.WFRCH_File field.
	''' </summary>
	Public Sub SetWFRCH_FileFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_FileColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_ID field.
	''' </summary>
	Public Property WFRCH_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCH_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCH_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCH_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCH_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCH_IDDefault() As String
        Get
            Return TableUtils.WFRCH_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Year field.
	''' </summary>
	Public Property WFRCH_Year() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCH_YearColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCH_YearColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCH_YearSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCH_YearColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCH_YearDefault() As String
        Get
            Return TableUtils.WFRCH_YearColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Month field.
	''' </summary>
	Public Property WFRCH_Month() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCH_MonthColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCH_MonthColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCH_MonthSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCH_MonthColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCH_MonthDefault() As String
        Get
            Return TableUtils.WFRCH_MonthColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_DT_ID field.
	''' </summary>
	Public Property WFRCH_DT_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCH_DT_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCH_DT_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCH_DT_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCH_DT_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCH_DT_IDDefault() As String
        Get
            Return TableUtils.WFRCH_DT_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Code field.
	''' </summary>
	Public Property WFRCH_Code() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCH_CodeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WFRCH_CodeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCH_CodeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCH_CodeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCH_CodeDefault() As String
        Get
            Return TableUtils.WFRCH_CodeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Submit field.
	''' </summary>
	Public Property WFRCH_Submit() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCH_SubmitColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCH_SubmitColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCH_SubmitSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCH_SubmitColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCH_SubmitDefault() As String
        Get
            Return TableUtils.WFRCH_SubmitColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Status field.
	''' </summary>
	Public Property WFRCH_Status() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCH_StatusColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCH_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCH_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCH_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCH_StatusDefault() As String
        Get
            Return TableUtils.WFRCH_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_C_ID field.
	''' </summary>
	Public Property WFRCH_C_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCH_C_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCH_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCH_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCH_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCH_C_IDDefault() As String
        Get
            Return TableUtils.WFRCH_C_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_U_ID field.
	''' </summary>
	Public Property WFRCH_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCH_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCH_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCH_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCH_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCH_U_IDDefault() As String
        Get
            Return TableUtils.WFRCH_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Remark field.
	''' </summary>
	Public Property WFRCH_Remark() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCH_RemarkColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WFRCH_RemarkColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCH_RemarkSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCH_RemarkColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCH_RemarkDefault() As String
        Get
            Return TableUtils.WFRCH_RemarkColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_PRTCNT field.
	''' </summary>
	Public Property WFRCH_PRTCNT() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCH_PRTCNTColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCH_PRTCNTColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCH_PRTCNTSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCH_PRTCNTColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCH_PRTCNTDefault() As String
        Get
            Return TableUtils.WFRCH_PRTCNTColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_FinID field.
	''' </summary>
	Public Property WFRCH_FinID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCH_FinIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCH_FinIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCH_FinIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCH_FinIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCH_FinIDDefault() As String
        Get
            Return TableUtils.WFRCH_FinIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_RptCount field.
	''' </summary>
	Public Property WFRCH_RptCount() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCH_RptCountColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCH_RptCountColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCH_RptCountSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCH_RptCountColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCH_RptCountDefault() As String
        Get
            Return TableUtils.WFRCH_RptCountColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_Description field.
	''' </summary>
	Public Property WFRCH_Description() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCH_DescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WFRCH_DescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCH_DescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCH_DescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCH_DescriptionDefault() As String
        Get
            Return TableUtils.WFRCH_DescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_Head_.WFRCH_File field.
	''' </summary>
	Public Property WFRCH_File() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCH_FileColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCH_FileColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCH_FileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCH_FileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCH_FileDefault() As String
        Get
            Return TableUtils.WFRCH_FileColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
