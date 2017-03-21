' This class is "generated" and will be overwritten.
' Your customizations should be made in WPO_Step_Detail1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WPO_Step_Detail1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WPO_Step_Detail1Table"></see> class.
''' </remarks>
''' <seealso cref="WPO_Step_Detail1Table"></seealso>
''' <seealso cref="WPO_Step_Detail1Record"></seealso>

<Serializable()> Public Class BaseWPO_Step_Detail1Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WPO_Step_Detail1Table = WPO_Step_Detail1Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WPO_Step_Detail1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WPO_Step_Detail1Rec As WPO_Step_Detail1Record = CType(sender,WPO_Step_Detail1Record)
        Validate_Inserting()
        If Not WPO_Step_Detail1Rec Is Nothing AndAlso Not WPO_Step_Detail1Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WPO_Step_Detail1Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WPO_Step_Detail1Rec As WPO_Step_Detail1Record = CType(sender,WPO_Step_Detail1Record)
        Validate_Updating()
        If Not WPO_Step_Detail1Rec Is Nothing AndAlso Not WPO_Step_Detail1Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WPO_Step_Detail1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WPO_Step_Detail1Rec As WPO_Step_Detail1Record = CType(sender,WPO_Step_Detail1Record)
        If Not WPO_Step_Detail1Rec Is Nothing AndAlso Not WPO_Step_Detail1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_ID field.
	''' </summary>
	Public Function GetWPO_SD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_SD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_ID field.
	''' </summary>
	Public Function GetWPO_SD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPO_SD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_S_ID field.
	''' </summary>
	Public Function GetWPO_SD_S_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_SD_S_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_S_ID field.
	''' </summary>
	Public Function GetWPO_SD_S_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPO_SD_S_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_S_ID field.
	''' </summary>
	Public Sub SetWPO_SD_S_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_SD_S_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_S_ID field.
	''' </summary>
	Public Sub SetWPO_SD_S_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_SD_S_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_S_ID field.
	''' </summary>
	Public Sub SetWPO_SD_S_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_S_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_S_ID field.
	''' </summary>
	Public Sub SetWPO_SD_S_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_S_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_S_ID field.
	''' </summary>
	Public Sub SetWPO_SD_S_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_S_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_W_U_ID field.
	''' </summary>
	Public Function GetWPO_SD_W_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_SD_W_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_W_U_ID field.
	''' </summary>
	Public Function GetWPO_SD_W_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPO_SD_W_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_W_U_ID field.
	''' </summary>
	Public Sub SetWPO_SD_W_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_SD_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_W_U_ID field.
	''' </summary>
	Public Sub SetWPO_SD_W_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_SD_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_W_U_ID field.
	''' </summary>
	Public Sub SetWPO_SD_W_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_W_U_ID field.
	''' </summary>
	Public Sub SetWPO_SD_W_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_W_U_ID field.
	''' </summary>
	Public Sub SetWPO_SD_W_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_W_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Desc field.
	''' </summary>
	Public Function GetWPO_SD_DescValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_SD_DescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Desc field.
	''' </summary>
	Public Function GetWPO_SD_DescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPO_SD_DescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Desc field.
	''' </summary>
	Public Sub SetWPO_SD_DescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_SD_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Desc field.
	''' </summary>
	Public Sub SetWPO_SD_DescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Status field.
	''' </summary>
	Public Function GetWPO_SD_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_SD_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Status field.
	''' </summary>
	Public Function GetWPO_SD_StatusFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPO_SD_StatusColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Status field.
	''' </summary>
	Public Sub SetWPO_SD_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_SD_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Status field.
	''' </summary>
	Public Sub SetWPO_SD_StatusFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Variable_Ref field.
	''' </summary>
	Public Function GetWPO_SD_Variable_RefValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_SD_Variable_RefColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Variable_Ref field.
	''' </summary>
	Public Function GetWPO_SD_Variable_RefFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPO_SD_Variable_RefColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Variable_Ref field.
	''' </summary>
	Public Sub SetWPO_SD_Variable_RefFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_SD_Variable_RefColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Variable_Ref field.
	''' </summary>
	Public Sub SetWPO_SD_Variable_RefFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_SD_Variable_RefColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Variable_Ref field.
	''' </summary>
	Public Sub SetWPO_SD_Variable_RefFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_Variable_RefColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Variable_Ref field.
	''' </summary>
	Public Sub SetWPO_SD_Variable_RefFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_Variable_RefColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Variable_Ref field.
	''' </summary>
	Public Sub SetWPO_SD_Variable_RefFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_Variable_RefColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Variable_SQL field.
	''' </summary>
	Public Function GetWPO_SD_Variable_SQLValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_SD_Variable_SQLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Variable_SQL field.
	''' </summary>
	Public Function GetWPO_SD_Variable_SQLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPO_SD_Variable_SQLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Variable_SQL field.
	''' </summary>
	Public Sub SetWPO_SD_Variable_SQLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_SD_Variable_SQLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Variable_SQL field.
	''' </summary>
	Public Sub SetWPO_SD_Variable_SQLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_Variable_SQLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Expire field.
	''' </summary>
	Public Function GetWPO_SD_ExpireValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_SD_ExpireColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Expire field.
	''' </summary>
	Public Function GetWPO_SD_ExpireFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WPO_SD_ExpireColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Expire field.
	''' </summary>
	Public Sub SetWPO_SD_ExpireFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_SD_ExpireColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Expire field.
	''' </summary>
	Public Sub SetWPO_SD_ExpireFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_SD_ExpireColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Expire field.
	''' </summary>
	Public Sub SetWPO_SD_ExpireFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_ExpireColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Expire field.
	''' </summary>
	Public Sub SetWPO_SD_ExpireFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_ExpireColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Expire field.
	''' </summary>
	Public Sub SetWPO_SD_ExpireFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_ExpireColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_W_U_ID_Delegate field.
	''' </summary>
	Public Function GetWPO_SD_W_U_ID_DelegateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_SD_W_U_ID_DelegateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_W_U_ID_Delegate field.
	''' </summary>
	Public Function GetWPO_SD_W_U_ID_DelegateFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPO_SD_W_U_ID_DelegateColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWPO_SD_W_U_ID_DelegateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_SD_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWPO_SD_W_U_ID_DelegateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_SD_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWPO_SD_W_U_ID_DelegateFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWPO_SD_W_U_ID_DelegateFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWPO_SD_W_U_ID_DelegateFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_W_U_ID_DelegateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Is_Escalate field.
	''' </summary>
	Public Function GetWPO_SD_Is_EscalateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_SD_Is_EscalateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Is_Escalate field.
	''' </summary>
	Public Function GetWPO_SD_Is_EscalateFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WPO_SD_Is_EscalateColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Is_Escalate field.
	''' </summary>
	Public Sub SetWPO_SD_Is_EscalateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_SD_Is_EscalateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Is_Escalate field.
	''' </summary>
	Public Sub SetWPO_SD_Is_EscalateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_SD_Is_EscalateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Is_Escalate field.
	''' </summary>
	Public Sub SetWPO_SD_Is_EscalateFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_Is_EscalateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Is_FAP field.
	''' </summary>
	Public Function GetWPO_SD_Is_FAPValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_SD_Is_FAPColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Is_FAP field.
	''' </summary>
	Public Function GetWPO_SD_Is_FAPFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WPO_SD_Is_FAPColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Is_FAP field.
	''' </summary>
	Public Sub SetWPO_SD_Is_FAPFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_SD_Is_FAPColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Is_FAP field.
	''' </summary>
	Public Sub SetWPO_SD_Is_FAPFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_SD_Is_FAPColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_Detail_.WPO_SD_Is_FAP field.
	''' </summary>
	Public Sub SetWPO_SD_Is_FAPFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_Is_FAPColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_ID field.
	''' </summary>
	Public Property WPO_SD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_SD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_SD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_SD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_SD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_SD_IDDefault() As String
        Get
            Return TableUtils.WPO_SD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_S_ID field.
	''' </summary>
	Public Property WPO_SD_S_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_SD_S_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_SD_S_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_SD_S_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_SD_S_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_SD_S_IDDefault() As String
        Get
            Return TableUtils.WPO_SD_S_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_W_U_ID field.
	''' </summary>
	Public Property WPO_SD_W_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_SD_W_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_SD_W_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_SD_W_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_SD_W_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_SD_W_U_IDDefault() As String
        Get
            Return TableUtils.WPO_SD_W_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Desc field.
	''' </summary>
	Public Property WPO_SD_Desc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_SD_DescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPO_SD_DescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_SD_DescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_SD_DescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_SD_DescDefault() As String
        Get
            Return TableUtils.WPO_SD_DescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Status field.
	''' </summary>
	Public Property WPO_SD_Status() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_SD_StatusColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPO_SD_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_SD_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_SD_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_SD_StatusDefault() As String
        Get
            Return TableUtils.WPO_SD_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Variable_Ref field.
	''' </summary>
	Public Property WPO_SD_Variable_Ref() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_SD_Variable_RefColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_SD_Variable_RefColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_SD_Variable_RefSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_SD_Variable_RefColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_SD_Variable_RefDefault() As String
        Get
            Return TableUtils.WPO_SD_Variable_RefColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Variable_SQL field.
	''' </summary>
	Public Property WPO_SD_Variable_SQL() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_SD_Variable_SQLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPO_SD_Variable_SQLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_SD_Variable_SQLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_SD_Variable_SQLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_SD_Variable_SQLDefault() As String
        Get
            Return TableUtils.WPO_SD_Variable_SQLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Expire field.
	''' </summary>
	Public Property WPO_SD_Expire() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_SD_ExpireColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_SD_ExpireColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_SD_ExpireSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_SD_ExpireColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_SD_ExpireDefault() As String
        Get
            Return TableUtils.WPO_SD_ExpireColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_W_U_ID_Delegate field.
	''' </summary>
	Public Property WPO_SD_W_U_ID_Delegate() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_SD_W_U_ID_DelegateColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_SD_W_U_ID_DelegateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_SD_W_U_ID_DelegateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_SD_W_U_ID_DelegateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_SD_W_U_ID_DelegateDefault() As String
        Get
            Return TableUtils.WPO_SD_W_U_ID_DelegateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Is_Escalate field.
	''' </summary>
	Public Property WPO_SD_Is_Escalate() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_SD_Is_EscalateColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_SD_Is_EscalateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_SD_Is_EscalateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_SD_Is_EscalateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_SD_Is_EscalateDefault() As String
        Get
            Return TableUtils.WPO_SD_Is_EscalateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_Detail_.WPO_SD_Is_FAP field.
	''' </summary>
	Public Property WPO_SD_Is_FAP() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_SD_Is_FAPColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_SD_Is_FAPColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_SD_Is_FAPSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_SD_Is_FAPColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_SD_Is_FAPDefault() As String
        Get
            Return TableUtils.WPO_SD_Is_FAPColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
