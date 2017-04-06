' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRepNGP_HeadRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WFinRepNGP_HeadRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WFinRepNGP_HeadTable"></see> class.
''' </remarks>
''' <seealso cref="WFinRepNGP_HeadTable"></seealso>
''' <seealso cref="WFinRepNGP_HeadRecord"></seealso>

<Serializable()> Public Class BaseWFinRepNGP_HeadRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WFinRepNGP_HeadTable = WFinRepNGP_HeadTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WFinRepNGP_HeadRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WFinRepNGP_HeadRec As WFinRepNGP_HeadRecord = CType(sender,WFinRepNGP_HeadRecord)
        Validate_Inserting()
        If Not WFinRepNGP_HeadRec Is Nothing AndAlso Not WFinRepNGP_HeadRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WFinRepNGP_HeadRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WFinRepNGP_HeadRec As WFinRepNGP_HeadRecord = CType(sender,WFinRepNGP_HeadRecord)
        Validate_Updating()
        If Not WFinRepNGP_HeadRec Is Nothing AndAlso Not WFinRepNGP_HeadRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WFinRepNGP_HeadRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WFinRepNGP_HeadRec As WFinRepNGP_HeadRecord = CType(sender,WFinRepNGP_HeadRecord)
        If Not WFinRepNGP_HeadRec Is Nothing AndAlso Not WFinRepNGP_HeadRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_ID field.
	''' </summary>
	Public Function GetWFRCHNGP_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHNGP_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_ID field.
	''' </summary>
	Public Function GetWFRCHNGP_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCHNGP_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Year field.
	''' </summary>
	Public Function GetWFRCHNGP_YearValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHNGP_YearColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Year field.
	''' </summary>
	Public Function GetWFRCHNGP_YearFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCHNGP_YearColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Year field.
	''' </summary>
	Public Sub SetWFRCHNGP_YearFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCHNGP_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Year field.
	''' </summary>
	Public Sub SetWFRCHNGP_YearFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCHNGP_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Year field.
	''' </summary>
	Public Sub SetWFRCHNGP_YearFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Year field.
	''' </summary>
	Public Sub SetWFRCHNGP_YearFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Year field.
	''' </summary>
	Public Sub SetWFRCHNGP_YearFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_YearColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Month field.
	''' </summary>
	Public Function GetWFRCHNGP_MonthValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHNGP_MonthColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Month field.
	''' </summary>
	Public Function GetWFRCHNGP_MonthFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCHNGP_MonthColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Month field.
	''' </summary>
	Public Sub SetWFRCHNGP_MonthFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCHNGP_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Month field.
	''' </summary>
	Public Sub SetWFRCHNGP_MonthFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCHNGP_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Month field.
	''' </summary>
	Public Sub SetWFRCHNGP_MonthFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Month field.
	''' </summary>
	Public Sub SetWFRCHNGP_MonthFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Month field.
	''' </summary>
	Public Sub SetWFRCHNGP_MonthFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_MonthColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_DT_ID field.
	''' </summary>
	Public Function GetWFRCHNGP_DT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHNGP_DT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_DT_ID field.
	''' </summary>
	Public Function GetWFRCHNGP_DT_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCHNGP_DT_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_DT_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_DT_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCHNGP_DT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_DT_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_DT_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCHNGP_DT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_DT_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_DT_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_DT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_DT_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_DT_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_DT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_DT_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_DT_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_DT_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Code field.
	''' </summary>
	Public Function GetWFRCHNGP_CodeValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHNGP_CodeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Code field.
	''' </summary>
	Public Function GetWFRCHNGP_CodeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRCHNGP_CodeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Code field.
	''' </summary>
	Public Sub SetWFRCHNGP_CodeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCHNGP_CodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Code field.
	''' </summary>
	Public Sub SetWFRCHNGP_CodeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_CodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Submit field.
	''' </summary>
	Public Function GetWFRCHNGP_SubmitValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHNGP_SubmitColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Submit field.
	''' </summary>
	Public Function GetWFRCHNGP_SubmitFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WFRCHNGP_SubmitColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Submit field.
	''' </summary>
	Public Sub SetWFRCHNGP_SubmitFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCHNGP_SubmitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Submit field.
	''' </summary>
	Public Sub SetWFRCHNGP_SubmitFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCHNGP_SubmitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Submit field.
	''' </summary>
	Public Sub SetWFRCHNGP_SubmitFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_SubmitColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Status field.
	''' </summary>
	Public Function GetWFRCHNGP_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHNGP_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Status field.
	''' </summary>
	Public Function GetWFRCHNGP_StatusFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCHNGP_StatusColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Status field.
	''' </summary>
	Public Sub SetWFRCHNGP_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCHNGP_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Status field.
	''' </summary>
	Public Sub SetWFRCHNGP_StatusFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCHNGP_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Status field.
	''' </summary>
	Public Sub SetWFRCHNGP_StatusFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Status field.
	''' </summary>
	Public Sub SetWFRCHNGP_StatusFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Status field.
	''' </summary>
	Public Sub SetWFRCHNGP_StatusFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_StatusColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_C_ID field.
	''' </summary>
	Public Function GetWFRCHNGP_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHNGP_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_C_ID field.
	''' </summary>
	Public Function GetWFRCHNGP_C_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCHNGP_C_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_C_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCHNGP_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_C_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCHNGP_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_C_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_C_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_C_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_U_ID field.
	''' </summary>
	Public Function GetWFRCHNGP_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHNGP_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_U_ID field.
	''' </summary>
	Public Function GetWFRCHNGP_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCHNGP_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_U_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCHNGP_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_U_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCHNGP_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_U_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_U_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_U_ID field.
	''' </summary>
	Public Sub SetWFRCHNGP_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Remark field.
	''' </summary>
	Public Function GetWFRCHNGP_RemarkValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHNGP_RemarkColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Remark field.
	''' </summary>
	Public Function GetWFRCHNGP_RemarkFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRCHNGP_RemarkColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Remark field.
	''' </summary>
	Public Sub SetWFRCHNGP_RemarkFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCHNGP_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Remark field.
	''' </summary>
	Public Sub SetWFRCHNGP_RemarkFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_PRTCNT field.
	''' </summary>
	Public Function GetWFRCHNGP_PRTCNTValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHNGP_PRTCNTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_PRTCNT field.
	''' </summary>
	Public Function GetWFRCHNGP_PRTCNTFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCHNGP_PRTCNTColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_PRTCNT field.
	''' </summary>
	Public Sub SetWFRCHNGP_PRTCNTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCHNGP_PRTCNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_PRTCNT field.
	''' </summary>
	Public Sub SetWFRCHNGP_PRTCNTFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCHNGP_PRTCNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_PRTCNT field.
	''' </summary>
	Public Sub SetWFRCHNGP_PRTCNTFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_PRTCNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_PRTCNT field.
	''' </summary>
	Public Sub SetWFRCHNGP_PRTCNTFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_PRTCNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_PRTCNT field.
	''' </summary>
	Public Sub SetWFRCHNGP_PRTCNTFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_PRTCNTColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_FinID field.
	''' </summary>
	Public Function GetWFRCHNGP_FinIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHNGP_FinIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_FinID field.
	''' </summary>
	Public Function GetWFRCHNGP_FinIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCHNGP_FinIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_FinID field.
	''' </summary>
	Public Sub SetWFRCHNGP_FinIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCHNGP_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_FinID field.
	''' </summary>
	Public Sub SetWFRCHNGP_FinIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCHNGP_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_FinID field.
	''' </summary>
	Public Sub SetWFRCHNGP_FinIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_FinID field.
	''' </summary>
	Public Sub SetWFRCHNGP_FinIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_FinIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_FinID field.
	''' </summary>
	Public Sub SetWFRCHNGP_FinIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_FinIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_RptCount field.
	''' </summary>
	Public Function GetWFRCHNGP_RptCountValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHNGP_RptCountColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_RptCount field.
	''' </summary>
	Public Function GetWFRCHNGP_RptCountFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCHNGP_RptCountColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_RptCount field.
	''' </summary>
	Public Sub SetWFRCHNGP_RptCountFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCHNGP_RptCountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_RptCount field.
	''' </summary>
	Public Sub SetWFRCHNGP_RptCountFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCHNGP_RptCountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_RptCount field.
	''' </summary>
	Public Sub SetWFRCHNGP_RptCountFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_RptCountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_RptCount field.
	''' </summary>
	Public Sub SetWFRCHNGP_RptCountFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_RptCountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_RptCount field.
	''' </summary>
	Public Sub SetWFRCHNGP_RptCountFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_RptCountColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Description field.
	''' </summary>
	Public Function GetWFRCHNGP_DescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHNGP_DescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Description field.
	''' </summary>
	Public Function GetWFRCHNGP_DescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRCHNGP_DescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Description field.
	''' </summary>
	Public Sub SetWFRCHNGP_DescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCHNGP_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_Description field.
	''' </summary>
	Public Sub SetWFRCHNGP_DescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_File field.
	''' </summary>
	Public Function GetWFRCHNGP_FileValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHNGP_FileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_File field.
	''' </summary>
	Public Function GetWFRCHNGP_FileFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.WFRCHNGP_FileColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_File field.
	''' </summary>
	Public Sub SetWFRCHNGP_FileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCHNGP_FileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_File field.
	''' </summary>
	Public Sub SetWFRCHNGP_FileFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCHNGP_FileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Head_.WFRCHNGP_File field.
	''' </summary>
	Public Sub SetWFRCHNGP_FileFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHNGP_FileColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_ID field.
	''' </summary>
	Public Property WFRCHNGP_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHNGP_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCHNGP_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHNGP_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHNGP_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHNGP_IDDefault() As String
        Get
            Return TableUtils.WFRCHNGP_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Year field.
	''' </summary>
	Public Property WFRCHNGP_Year() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHNGP_YearColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCHNGP_YearColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHNGP_YearSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHNGP_YearColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHNGP_YearDefault() As String
        Get
            Return TableUtils.WFRCHNGP_YearColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Month field.
	''' </summary>
	Public Property WFRCHNGP_Month() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHNGP_MonthColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCHNGP_MonthColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHNGP_MonthSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHNGP_MonthColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHNGP_MonthDefault() As String
        Get
            Return TableUtils.WFRCHNGP_MonthColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_DT_ID field.
	''' </summary>
	Public Property WFRCHNGP_DT_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHNGP_DT_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCHNGP_DT_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHNGP_DT_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHNGP_DT_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHNGP_DT_IDDefault() As String
        Get
            Return TableUtils.WFRCHNGP_DT_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Code field.
	''' </summary>
	Public Property WFRCHNGP_Code() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHNGP_CodeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WFRCHNGP_CodeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHNGP_CodeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHNGP_CodeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHNGP_CodeDefault() As String
        Get
            Return TableUtils.WFRCHNGP_CodeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Submit field.
	''' </summary>
	Public Property WFRCHNGP_Submit() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHNGP_SubmitColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCHNGP_SubmitColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHNGP_SubmitSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHNGP_SubmitColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHNGP_SubmitDefault() As String
        Get
            Return TableUtils.WFRCHNGP_SubmitColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Status field.
	''' </summary>
	Public Property WFRCHNGP_Status() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHNGP_StatusColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCHNGP_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHNGP_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHNGP_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHNGP_StatusDefault() As String
        Get
            Return TableUtils.WFRCHNGP_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_C_ID field.
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
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_U_ID field.
	''' </summary>
	Public Property WFRCHNGP_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHNGP_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCHNGP_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHNGP_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHNGP_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHNGP_U_IDDefault() As String
        Get
            Return TableUtils.WFRCHNGP_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Remark field.
	''' </summary>
	Public Property WFRCHNGP_Remark() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHNGP_RemarkColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WFRCHNGP_RemarkColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHNGP_RemarkSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHNGP_RemarkColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHNGP_RemarkDefault() As String
        Get
            Return TableUtils.WFRCHNGP_RemarkColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_PRTCNT field.
	''' </summary>
	Public Property WFRCHNGP_PRTCNT() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHNGP_PRTCNTColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCHNGP_PRTCNTColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHNGP_PRTCNTSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHNGP_PRTCNTColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHNGP_PRTCNTDefault() As String
        Get
            Return TableUtils.WFRCHNGP_PRTCNTColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_FinID field.
	''' </summary>
	Public Property WFRCHNGP_FinID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHNGP_FinIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCHNGP_FinIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHNGP_FinIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHNGP_FinIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHNGP_FinIDDefault() As String
        Get
            Return TableUtils.WFRCHNGP_FinIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_RptCount field.
	''' </summary>
	Public Property WFRCHNGP_RptCount() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHNGP_RptCountColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCHNGP_RptCountColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHNGP_RptCountSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHNGP_RptCountColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHNGP_RptCountDefault() As String
        Get
            Return TableUtils.WFRCHNGP_RptCountColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_Description field.
	''' </summary>
	Public Property WFRCHNGP_Description() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHNGP_DescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WFRCHNGP_DescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHNGP_DescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHNGP_DescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHNGP_DescriptionDefault() As String
        Get
            Return TableUtils.WFRCHNGP_DescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Head_.WFRCHNGP_File field.
	''' </summary>
	Public Property WFRCHNGP_File() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHNGP_FileColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCHNGP_FileColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHNGP_FileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHNGP_FileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHNGP_FileDefault() As String
        Get
            Return TableUtils.WFRCHNGP_FileColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
