' This class is "generated" and will be overwritten.
' Your customizations should be made in WPR_Activity1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WPR_Activity1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WPR_Activity1Table"></see> class.
''' </remarks>
''' <seealso cref="WPR_Activity1Table"></seealso>
''' <seealso cref="WPR_Activity1Record"></seealso>

<Serializable()> Public Class BaseWPR_Activity1Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WPR_Activity1Table = WPR_Activity1Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WPR_Activity1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WPR_Activity1Rec As WPR_Activity1Record = CType(sender,WPR_Activity1Record)
        Validate_Inserting()
        If Not WPR_Activity1Rec Is Nothing AndAlso Not WPR_Activity1Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WPR_Activity1Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WPR_Activity1Rec As WPR_Activity1Record = CType(sender,WPR_Activity1Record)
        Validate_Updating()
        If Not WPR_Activity1Rec Is Nothing AndAlso Not WPR_Activity1Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WPR_Activity1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WPR_Activity1Rec As WPR_Activity1Record = CType(sender,WPR_Activity1Record)
        If Not WPR_Activity1Rec Is Nothing AndAlso Not WPR_Activity1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_ID field.
	''' </summary>
	Public Function GetWPRA_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRA_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_ID field.
	''' </summary>
	Public Function GetWPRA_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRA_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_WS_ID field.
	''' </summary>
	Public Function GetWPRA_WS_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRA_WS_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_WS_ID field.
	''' </summary>
	Public Function GetWPRA_WS_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRA_WS_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WS_ID field.
	''' </summary>
	Public Sub SetWPRA_WS_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WS_ID field.
	''' </summary>
	Public Sub SetWPRA_WS_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WS_ID field.
	''' </summary>
	Public Sub SetWPRA_WS_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WS_ID field.
	''' </summary>
	Public Sub SetWPRA_WS_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WS_ID field.
	''' </summary>
	Public Sub SetWPRA_WS_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_WS_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_WSD_ID field.
	''' </summary>
	Public Function GetWPRA_WSD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRA_WSD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_WSD_ID field.
	''' </summary>
	Public Function GetWPRA_WSD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRA_WSD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WSD_ID field.
	''' </summary>
	Public Sub SetWPRA_WSD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WSD_ID field.
	''' </summary>
	Public Sub SetWPRA_WSD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WSD_ID field.
	''' </summary>
	Public Sub SetWPRA_WSD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WSD_ID field.
	''' </summary>
	Public Sub SetWPRA_WSD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WSD_ID field.
	''' </summary>
	Public Sub SetWPRA_WSD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_WSD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_WDT_ID field.
	''' </summary>
	Public Function GetWPRA_WDT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRA_WDT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_WDT_ID field.
	''' </summary>
	Public Function GetWPRA_WDT_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRA_WDT_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WDT_ID field.
	''' </summary>
	Public Sub SetWPRA_WDT_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WDT_ID field.
	''' </summary>
	Public Sub SetWPRA_WDT_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WDT_ID field.
	''' </summary>
	Public Sub SetWPRA_WDT_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WDT_ID field.
	''' </summary>
	Public Sub SetWPRA_WDT_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WDT_ID field.
	''' </summary>
	Public Sub SetWPRA_WDT_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_WDT_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_W_U_ID field.
	''' </summary>
	Public Function GetWPRA_W_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRA_W_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_W_U_ID field.
	''' </summary>
	Public Function GetWPRA_W_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRA_W_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_W_U_ID field.
	''' </summary>
	Public Sub SetWPRA_W_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_W_U_ID field.
	''' </summary>
	Public Sub SetWPRA_W_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_W_U_ID field.
	''' </summary>
	Public Sub SetWPRA_W_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_W_U_ID field.
	''' </summary>
	Public Sub SetWPRA_W_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_W_U_ID field.
	''' </summary>
	Public Sub SetWPRA_W_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_W_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_W_U_ID_Delegate field.
	''' </summary>
	Public Function GetWPRA_W_U_ID_DelegateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRA_W_U_ID_DelegateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_W_U_ID_Delegate field.
	''' </summary>
	Public Function GetWPRA_W_U_ID_DelegateFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRA_W_U_ID_DelegateColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWPRA_W_U_ID_DelegateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRA_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWPRA_W_U_ID_DelegateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRA_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWPRA_W_U_ID_DelegateFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWPRA_W_U_ID_DelegateFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWPRA_W_U_ID_DelegateFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_W_U_ID_DelegateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_WPRD_ID field.
	''' </summary>
	Public Function GetWPRA_WPRD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRA_WPRD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_WPRD_ID field.
	''' </summary>
	Public Function GetWPRA_WPRD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRA_WPRD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRA_WPRD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRA_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRA_WPRD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRA_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRA_WPRD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRA_WPRD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRA_WPRD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_WPRD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_Status field.
	''' </summary>
	Public Function GetWPRA_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRA_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_Status field.
	''' </summary>
	Public Function GetWPRA_StatusFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRA_StatusColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_Status field.
	''' </summary>
	Public Sub SetWPRA_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRA_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_Status field.
	''' </summary>
	Public Sub SetWPRA_StatusFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_Date_Assign field.
	''' </summary>
	Public Function GetWPRA_Date_AssignValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRA_Date_AssignColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_Date_Assign field.
	''' </summary>
	Public Function GetWPRA_Date_AssignFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WPRA_Date_AssignColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_Date_Assign field.
	''' </summary>
	Public Sub SetWPRA_Date_AssignFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRA_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_Date_Assign field.
	''' </summary>
	Public Sub SetWPRA_Date_AssignFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRA_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_Date_Assign field.
	''' </summary>
	Public Sub SetWPRA_Date_AssignFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_Date_Action field.
	''' </summary>
	Public Function GetWPRA_Date_ActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRA_Date_ActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_Date_Action field.
	''' </summary>
	Public Function GetWPRA_Date_ActionFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WPRA_Date_ActionColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_Date_Action field.
	''' </summary>
	Public Sub SetWPRA_Date_ActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRA_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_Date_Action field.
	''' </summary>
	Public Sub SetWPRA_Date_ActionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRA_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_Date_Action field.
	''' </summary>
	Public Sub SetWPRA_Date_ActionFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_Remark field.
	''' </summary>
	Public Function GetWPRA_RemarkValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRA_RemarkColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_Remark field.
	''' </summary>
	Public Function GetWPRA_RemarkFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRA_RemarkColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_Remark field.
	''' </summary>
	Public Sub SetWPRA_RemarkFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRA_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_Remark field.
	''' </summary>
	Public Sub SetWPRA_RemarkFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_Is_Done field.
	''' </summary>
	Public Function GetWPRA_Is_DoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRA_Is_DoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Activity_.WPRA_Is_Done field.
	''' </summary>
	Public Function GetWPRA_Is_DoneFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WPRA_Is_DoneColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_Is_Done field.
	''' </summary>
	Public Sub SetWPRA_Is_DoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRA_Is_DoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_Is_Done field.
	''' </summary>
	Public Sub SetWPRA_Is_DoneFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRA_Is_DoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Activity_.WPRA_Is_Done field.
	''' </summary>
	Public Sub SetWPRA_Is_DoneFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRA_Is_DoneColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Activity_.WPRA_ID field.
	''' </summary>
	Public Property WPRA_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRA_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRA_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRA_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRA_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRA_IDDefault() As String
        Get
            Return TableUtils.WPRA_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Activity_.WPRA_WS_ID field.
	''' </summary>
	Public Property WPRA_WS_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRA_WS_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRA_WS_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRA_WS_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRA_WS_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRA_WS_IDDefault() As String
        Get
            Return TableUtils.WPRA_WS_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Activity_.WPRA_WSD_ID field.
	''' </summary>
	Public Property WPRA_WSD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRA_WSD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRA_WSD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRA_WSD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRA_WSD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRA_WSD_IDDefault() As String
        Get
            Return TableUtils.WPRA_WSD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Activity_.WPRA_WDT_ID field.
	''' </summary>
	Public Property WPRA_WDT_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRA_WDT_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRA_WDT_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRA_WDT_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRA_WDT_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRA_WDT_IDDefault() As String
        Get
            Return TableUtils.WPRA_WDT_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Activity_.WPRA_W_U_ID field.
	''' </summary>
	Public Property WPRA_W_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRA_W_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRA_W_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRA_W_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRA_W_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRA_W_U_IDDefault() As String
        Get
            Return TableUtils.WPRA_W_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Activity_.WPRA_W_U_ID_Delegate field.
	''' </summary>
	Public Property WPRA_W_U_ID_Delegate() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRA_W_U_ID_DelegateColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRA_W_U_ID_DelegateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRA_W_U_ID_DelegateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRA_W_U_ID_DelegateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRA_W_U_ID_DelegateDefault() As String
        Get
            Return TableUtils.WPRA_W_U_ID_DelegateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Activity_.WPRA_WPRD_ID field.
	''' </summary>
	Public Property WPRA_WPRD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRA_WPRD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRA_WPRD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRA_WPRD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRA_WPRD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRA_WPRD_IDDefault() As String
        Get
            Return TableUtils.WPRA_WPRD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Activity_.WPRA_Status field.
	''' </summary>
	Public Property WPRA_Status() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRA_StatusColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRA_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRA_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRA_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRA_StatusDefault() As String
        Get
            Return TableUtils.WPRA_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Activity_.WPRA_Date_Assign field.
	''' </summary>
	Public Property WPRA_Date_Assign() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WPRA_Date_AssignColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRA_Date_AssignColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRA_Date_AssignSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRA_Date_AssignColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRA_Date_AssignDefault() As String
        Get
            Return TableUtils.WPRA_Date_AssignColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Activity_.WPRA_Date_Action field.
	''' </summary>
	Public Property WPRA_Date_Action() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WPRA_Date_ActionColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRA_Date_ActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRA_Date_ActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRA_Date_ActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRA_Date_ActionDefault() As String
        Get
            Return TableUtils.WPRA_Date_ActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Activity_.WPRA_Remark field.
	''' </summary>
	Public Property WPRA_Remark() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRA_RemarkColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRA_RemarkColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRA_RemarkSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRA_RemarkColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRA_RemarkDefault() As String
        Get
            Return TableUtils.WPRA_RemarkColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Activity_.WPRA_Is_Done field.
	''' </summary>
	Public Property WPRA_Is_Done() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WPRA_Is_DoneColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRA_Is_DoneColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRA_Is_DoneSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRA_Is_DoneColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRA_Is_DoneDefault() As String
        Get
            Return TableUtils.WPRA_Is_DoneColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
