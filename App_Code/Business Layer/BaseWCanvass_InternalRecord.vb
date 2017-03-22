' This class is "generated" and will be overwritten.
' Your customizations should be made in WCanvass_InternalRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WCanvass_InternalRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WCanvass_InternalTable"></see> class.
''' </remarks>
''' <seealso cref="WCanvass_InternalTable"></seealso>
''' <seealso cref="WCanvass_InternalRecord"></seealso>

<Serializable()> Public Class BaseWCanvass_InternalRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WCanvass_InternalTable = WCanvass_InternalTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WCanvass_InternalRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WCanvass_InternalRec As WCanvass_InternalRecord = CType(sender,WCanvass_InternalRecord)
        Validate_Inserting()
        If Not WCanvass_InternalRec Is Nothing AndAlso Not WCanvass_InternalRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WCanvass_InternalRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WCanvass_InternalRec As WCanvass_InternalRecord = CType(sender,WCanvass_InternalRecord)
        Validate_Updating()
        If Not WCanvass_InternalRec Is Nothing AndAlso Not WCanvass_InternalRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WCanvass_InternalRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WCanvass_InternalRec As WCanvass_InternalRecord = CType(sender,WCanvass_InternalRecord)
        If Not WCanvass_InternalRec Is Nothing AndAlso Not WCanvass_InternalRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_ID field.
	''' </summary>
	Public Function GetWCI_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_ID field.
	''' </summary>
	Public Function GetWCI_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCI_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_C_ID field.
	''' </summary>
	Public Function GetWCI_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_C_ID field.
	''' </summary>
	Public Function GetWCI_C_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCI_C_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_C_ID field.
	''' </summary>
	Public Sub SetWCI_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_C_ID field.
	''' </summary>
	Public Sub SetWCI_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCI_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_C_ID field.
	''' </summary>
	Public Sub SetWCI_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_C_ID field.
	''' </summary>
	Public Sub SetWCI_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_C_ID field.
	''' </summary>
	Public Sub SetWCI_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_WPRD_ID field.
	''' </summary>
	Public Function GetWCI_WPRD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_WPRD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_WPRD_ID field.
	''' </summary>
	Public Function GetWCI_WPRD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCI_WPRD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_WPRD_ID field.
	''' </summary>
	Public Sub SetWCI_WPRD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_WPRD_ID field.
	''' </summary>
	Public Sub SetWCI_WPRD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCI_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_WPRD_ID field.
	''' </summary>
	Public Sub SetWCI_WPRD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_WPRD_ID field.
	''' </summary>
	Public Sub SetWCI_WPRD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_WPRD_ID field.
	''' </summary>
	Public Sub SetWCI_WPRD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_WPRD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_Date field.
	''' </summary>
	Public Function GetWCI_DateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_DateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_Date field.
	''' </summary>
	Public Function GetWCI_DateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WCI_DateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Date field.
	''' </summary>
	Public Sub SetWCI_DateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Date field.
	''' </summary>
	Public Sub SetWCI_DateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCI_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Date field.
	''' </summary>
	Public Sub SetWCI_DateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_Submit field.
	''' </summary>
	Public Function GetWCI_SubmitValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_SubmitColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_Submit field.
	''' </summary>
	Public Function GetWCI_SubmitFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCI_SubmitColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Submit field.
	''' </summary>
	Public Sub SetWCI_SubmitFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_SubmitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Submit field.
	''' </summary>
	Public Sub SetWCI_SubmitFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCI_SubmitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Submit field.
	''' </summary>
	Public Sub SetWCI_SubmitFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_SubmitColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_Status field.
	''' </summary>
	Public Function GetWCI_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_Status field.
	''' </summary>
	Public Function GetWCI_StatusFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCI_StatusColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Status field.
	''' </summary>
	Public Sub SetWCI_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Status field.
	''' </summary>
	Public Sub SetWCI_StatusFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_Vendors field.
	''' </summary>
	Public Function GetWCI_VendorsValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_VendorsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_Vendors field.
	''' </summary>
	Public Function GetWCI_VendorsFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCI_VendorsColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Vendors field.
	''' </summary>
	Public Sub SetWCI_VendorsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_VendorsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Vendors field.
	''' </summary>
	Public Sub SetWCI_VendorsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCI_VendorsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Vendors field.
	''' </summary>
	Public Sub SetWCI_VendorsFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_VendorsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Vendors field.
	''' </summary>
	Public Sub SetWCI_VendorsFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_VendorsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Vendors field.
	''' </summary>
	Public Sub SetWCI_VendorsFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_VendorsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_U_ID field.
	''' </summary>
	Public Function GetWCI_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_U_ID field.
	''' </summary>
	Public Function GetWCI_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCI_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_U_ID field.
	''' </summary>
	Public Sub SetWCI_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_U_ID field.
	''' </summary>
	Public Sub SetWCI_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCI_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_U_ID field.
	''' </summary>
	Public Sub SetWCI_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_U_ID field.
	''' </summary>
	Public Sub SetWCI_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_U_ID field.
	''' </summary>
	Public Sub SetWCI_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_WClass_ID field.
	''' </summary>
	Public Function GetWCI_WClass_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_WClass_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_WClass_ID field.
	''' </summary>
	Public Function GetWCI_WClass_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCI_WClass_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_WClass_ID field.
	''' </summary>
	Public Sub SetWCI_WClass_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_WClass_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_WClass_ID field.
	''' </summary>
	Public Sub SetWCI_WClass_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCI_WClass_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_WClass_ID field.
	''' </summary>
	Public Sub SetWCI_WClass_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_WClass_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_WClass_ID field.
	''' </summary>
	Public Sub SetWCI_WClass_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_WClass_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_WClass_ID field.
	''' </summary>
	Public Sub SetWCI_WClass_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_WClass_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_Contract_Done field.
	''' </summary>
	Public Function GetWCI_Contract_DoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_Contract_DoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_Contract_Done field.
	''' </summary>
	Public Function GetWCI_Contract_DoneFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCI_Contract_DoneColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Contract_Done field.
	''' </summary>
	Public Sub SetWCI_Contract_DoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_Contract_DoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Contract_Done field.
	''' </summary>
	Public Sub SetWCI_Contract_DoneFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCI_Contract_DoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Contract_Done field.
	''' </summary>
	Public Sub SetWCI_Contract_DoneFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_Contract_DoneColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_Contract_Closed field.
	''' </summary>
	Public Function GetWCI_Contract_ClosedValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_Contract_ClosedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_Contract_Closed field.
	''' </summary>
	Public Function GetWCI_Contract_ClosedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WCI_Contract_ClosedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Contract_Closed field.
	''' </summary>
	Public Sub SetWCI_Contract_ClosedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_Contract_ClosedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Contract_Closed field.
	''' </summary>
	Public Sub SetWCI_Contract_ClosedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCI_Contract_ClosedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Contract_Closed field.
	''' </summary>
	Public Sub SetWCI_Contract_ClosedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_Contract_ClosedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_Contract_U_ID field.
	''' </summary>
	Public Function GetWCI_Contract_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_Contract_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Internal_.WCI_Contract_U_ID field.
	''' </summary>
	Public Function GetWCI_Contract_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCI_Contract_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Contract_U_ID field.
	''' </summary>
	Public Sub SetWCI_Contract_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_Contract_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Contract_U_ID field.
	''' </summary>
	Public Sub SetWCI_Contract_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCI_Contract_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Contract_U_ID field.
	''' </summary>
	Public Sub SetWCI_Contract_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_Contract_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Contract_U_ID field.
	''' </summary>
	Public Sub SetWCI_Contract_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_Contract_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Internal_.WCI_Contract_U_ID field.
	''' </summary>
	Public Sub SetWCI_Contract_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_Contract_U_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Internal_.WCI_ID field.
	''' </summary>
	Public Property WCI_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCI_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCI_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCI_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCI_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCI_IDDefault() As String
        Get
            Return TableUtils.WCI_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Internal_.WCI_C_ID field.
	''' </summary>
	Public Property WCI_C_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCI_C_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCI_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCI_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCI_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCI_C_IDDefault() As String
        Get
            Return TableUtils.WCI_C_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Internal_.WCI_WPRD_ID field.
	''' </summary>
	Public Property WCI_WPRD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCI_WPRD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCI_WPRD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCI_WPRD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCI_WPRD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCI_WPRD_IDDefault() As String
        Get
            Return TableUtils.WCI_WPRD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Internal_.WCI_Date field.
	''' </summary>
	Public Property WCI_Date() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WCI_DateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCI_DateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCI_DateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCI_DateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCI_DateDefault() As String
        Get
            Return TableUtils.WCI_DateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Internal_.WCI_Submit field.
	''' </summary>
	Public Property WCI_Submit() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCI_SubmitColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCI_SubmitColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCI_SubmitSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCI_SubmitColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCI_SubmitDefault() As String
        Get
            Return TableUtils.WCI_SubmitColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Internal_.WCI_Status field.
	''' </summary>
	Public Property WCI_Status() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCI_StatusColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCI_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCI_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCI_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCI_StatusDefault() As String
        Get
            Return TableUtils.WCI_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Internal_.WCI_Vendors field.
	''' </summary>
	Public Property WCI_Vendors() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCI_VendorsColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCI_VendorsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCI_VendorsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCI_VendorsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCI_VendorsDefault() As String
        Get
            Return TableUtils.WCI_VendorsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Internal_.WCI_U_ID field.
	''' </summary>
	Public Property WCI_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCI_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCI_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCI_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCI_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCI_U_IDDefault() As String
        Get
            Return TableUtils.WCI_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Internal_.WCI_WClass_ID field.
	''' </summary>
	Public Property WCI_WClass_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCI_WClass_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCI_WClass_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCI_WClass_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCI_WClass_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCI_WClass_IDDefault() As String
        Get
            Return TableUtils.WCI_WClass_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Internal_.WCI_Contract_Done field.
	''' </summary>
	Public Property WCI_Contract_Done() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCI_Contract_DoneColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCI_Contract_DoneColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCI_Contract_DoneSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCI_Contract_DoneColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCI_Contract_DoneDefault() As String
        Get
            Return TableUtils.WCI_Contract_DoneColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Internal_.WCI_Contract_Closed field.
	''' </summary>
	Public Property WCI_Contract_Closed() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WCI_Contract_ClosedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCI_Contract_ClosedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCI_Contract_ClosedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCI_Contract_ClosedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCI_Contract_ClosedDefault() As String
        Get
            Return TableUtils.WCI_Contract_ClosedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Internal_.WCI_Contract_U_ID field.
	''' </summary>
	Public Property WCI_Contract_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCI_Contract_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCI_Contract_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCI_Contract_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCI_Contract_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCI_Contract_U_IDDefault() As String
        Get
            Return TableUtils.WCI_Contract_U_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
