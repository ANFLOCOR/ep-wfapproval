' This class is "generated" and will be overwritten.
' Your customizations should be made in WCanvass_Detail_InternalRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WCanvass_Detail_InternalRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WCanvass_Detail_InternalTable"></see> class.
''' </remarks>
''' <seealso cref="WCanvass_Detail_InternalTable"></seealso>
''' <seealso cref="WCanvass_Detail_InternalRecord"></seealso>

<Serializable()> Public Class BaseWCanvass_Detail_InternalRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WCanvass_Detail_InternalTable = WCanvass_Detail_InternalTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WCanvass_Detail_InternalRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WCanvass_Detail_InternalRec As WCanvass_Detail_InternalRecord = CType(sender,WCanvass_Detail_InternalRecord)
        Validate_Inserting()
        If Not WCanvass_Detail_InternalRec Is Nothing AndAlso Not WCanvass_Detail_InternalRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WCanvass_Detail_InternalRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WCanvass_Detail_InternalRec As WCanvass_Detail_InternalRecord = CType(sender,WCanvass_Detail_InternalRecord)
        Validate_Updating()
        If Not WCanvass_Detail_InternalRec Is Nothing AndAlso Not WCanvass_Detail_InternalRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WCanvass_Detail_InternalRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WCanvass_Detail_InternalRec As WCanvass_Detail_InternalRecord = CType(sender,WCanvass_Detail_InternalRecord)
        If Not WCanvass_Detail_InternalRec Is Nothing AndAlso Not WCanvass_Detail_InternalRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_ID field.
	''' </summary>
	Public Function GetWCDI_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_ID field.
	''' </summary>
	Public Function GetWCDI_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCDI_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCI_ID field.
	''' </summary>
	Public Function GetWCDI_WCI_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_WCI_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCI_ID field.
	''' </summary>
	Public Function GetWCDI_WCI_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCDI_WCI_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCI_ID field.
	''' </summary>
	Public Sub SetWCDI_WCI_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_WCI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCI_ID field.
	''' </summary>
	Public Sub SetWCDI_WCI_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_WCI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCI_ID field.
	''' </summary>
	Public Sub SetWCDI_WCI_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCI_ID field.
	''' </summary>
	Public Sub SetWCDI_WCI_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCI_ID field.
	''' </summary>
	Public Sub SetWCDI_WCI_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCI_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WPRL_ID field.
	''' </summary>
	Public Function GetWCDI_WPRL_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_WPRL_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WPRL_ID field.
	''' </summary>
	Public Function GetWCDI_WPRL_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCDI_WPRL_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WPRL_ID field.
	''' </summary>
	Public Sub SetWCDI_WPRL_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_WPRL_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WPRL_ID field.
	''' </summary>
	Public Sub SetWCDI_WPRL_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_WPRL_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WPRL_ID field.
	''' </summary>
	Public Sub SetWCDI_WPRL_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WPRL_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WPRL_ID field.
	''' </summary>
	Public Sub SetWCDI_WPRL_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WPRL_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WPRL_ID field.
	''' </summary>
	Public Sub SetWCDI_WPRL_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WPRL_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID1 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID1Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID1 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID1FieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID1Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID1 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PM00200_Vendor_ID1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID1 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID1FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PM00200_Vendor_ID1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID2 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID2Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID2 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID2FieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID2Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID2 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PM00200_Vendor_ID2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID2 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID2FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PM00200_Vendor_ID2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID3 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID3Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID3Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID3 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID3FieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID3Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID3 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID3FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PM00200_Vendor_ID3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID3 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID3FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PM00200_Vendor_ID3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID4 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID4Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID4Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID4 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID4FieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID4Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID4 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID4FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PM00200_Vendor_ID4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID4 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID4FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PM00200_Vendor_ID4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID5 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID5Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID5Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID5 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID5FieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID5Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID5 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID5FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PM00200_Vendor_ID5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID5 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID5FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PM00200_Vendor_ID5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID6 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID6Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID6Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID6 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID6FieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID6Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID6 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID6FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PM00200_Vendor_ID6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID6 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID6FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PM00200_Vendor_ID6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid1 field.
	''' </summary>
	Public Function GetWCDI_Bid1Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Bid1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid1 field.
	''' </summary>
	Public Function GetWCDI_Bid1FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Bid1Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid1 field.
	''' </summary>
	Public Sub SetWCDI_Bid1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Bid1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid1 field.
	''' </summary>
	Public Sub SetWCDI_Bid1FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Bid1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid1 field.
	''' </summary>
	Public Sub SetWCDI_Bid1FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid1 field.
	''' </summary>
	Public Sub SetWCDI_Bid1FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid1 field.
	''' </summary>
	Public Sub SetWCDI_Bid1FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid1Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid2 field.
	''' </summary>
	Public Function GetWCDI_Bid2Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Bid2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid2 field.
	''' </summary>
	Public Function GetWCDI_Bid2FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Bid2Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid2 field.
	''' </summary>
	Public Sub SetWCDI_Bid2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Bid2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid2 field.
	''' </summary>
	Public Sub SetWCDI_Bid2FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Bid2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid2 field.
	''' </summary>
	Public Sub SetWCDI_Bid2FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid2 field.
	''' </summary>
	Public Sub SetWCDI_Bid2FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid2 field.
	''' </summary>
	Public Sub SetWCDI_Bid2FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid2Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid3 field.
	''' </summary>
	Public Function GetWCDI_Bid3Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Bid3Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid3 field.
	''' </summary>
	Public Function GetWCDI_Bid3FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Bid3Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid3 field.
	''' </summary>
	Public Sub SetWCDI_Bid3FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Bid3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid3 field.
	''' </summary>
	Public Sub SetWCDI_Bid3FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Bid3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid3 field.
	''' </summary>
	Public Sub SetWCDI_Bid3FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid3 field.
	''' </summary>
	Public Sub SetWCDI_Bid3FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid3 field.
	''' </summary>
	Public Sub SetWCDI_Bid3FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid3Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid4 field.
	''' </summary>
	Public Function GetWCDI_Bid4Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Bid4Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid4 field.
	''' </summary>
	Public Function GetWCDI_Bid4FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Bid4Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid4 field.
	''' </summary>
	Public Sub SetWCDI_Bid4FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Bid4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid4 field.
	''' </summary>
	Public Sub SetWCDI_Bid4FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Bid4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid4 field.
	''' </summary>
	Public Sub SetWCDI_Bid4FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid4 field.
	''' </summary>
	Public Sub SetWCDI_Bid4FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid4 field.
	''' </summary>
	Public Sub SetWCDI_Bid4FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid4Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid5 field.
	''' </summary>
	Public Function GetWCDI_Bid5Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Bid5Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid5 field.
	''' </summary>
	Public Function GetWCDI_Bid5FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Bid5Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid5 field.
	''' </summary>
	Public Sub SetWCDI_Bid5FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Bid5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid5 field.
	''' </summary>
	Public Sub SetWCDI_Bid5FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Bid5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid5 field.
	''' </summary>
	Public Sub SetWCDI_Bid5FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid5 field.
	''' </summary>
	Public Sub SetWCDI_Bid5FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid5 field.
	''' </summary>
	Public Sub SetWCDI_Bid5FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid5Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid6 field.
	''' </summary>
	Public Function GetWCDI_Bid6Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Bid6Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid6 field.
	''' </summary>
	Public Function GetWCDI_Bid6FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Bid6Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid6 field.
	''' </summary>
	Public Sub SetWCDI_Bid6FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Bid6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid6 field.
	''' </summary>
	Public Sub SetWCDI_Bid6FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Bid6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid6 field.
	''' </summary>
	Public Sub SetWCDI_Bid6FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid6 field.
	''' </summary>
	Public Sub SetWCDI_Bid6FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid6 field.
	''' </summary>
	Public Sub SetWCDI_Bid6FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid6Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award1 field.
	''' </summary>
	Public Function GetWCDI_Award1Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Award1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award1 field.
	''' </summary>
	Public Function GetWCDI_Award1FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Award1Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award1 field.
	''' </summary>
	Public Sub SetWCDI_Award1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Award1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award1 field.
	''' </summary>
	Public Sub SetWCDI_Award1FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Award1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award1 field.
	''' </summary>
	Public Sub SetWCDI_Award1FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Award1Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award2 field.
	''' </summary>
	Public Function GetWCDI_Award2Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Award2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award2 field.
	''' </summary>
	Public Function GetWCDI_Award2FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Award2Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award2 field.
	''' </summary>
	Public Sub SetWCDI_Award2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Award2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award2 field.
	''' </summary>
	Public Sub SetWCDI_Award2FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Award2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award2 field.
	''' </summary>
	Public Sub SetWCDI_Award2FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Award2Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award3 field.
	''' </summary>
	Public Function GetWCDI_Award3Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Award3Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award3 field.
	''' </summary>
	Public Function GetWCDI_Award3FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Award3Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award3 field.
	''' </summary>
	Public Sub SetWCDI_Award3FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Award3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award3 field.
	''' </summary>
	Public Sub SetWCDI_Award3FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Award3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award3 field.
	''' </summary>
	Public Sub SetWCDI_Award3FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Award3Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award4 field.
	''' </summary>
	Public Function GetWCDI_Award4Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Award4Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award4 field.
	''' </summary>
	Public Function GetWCDI_Award4FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Award4Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award4 field.
	''' </summary>
	Public Sub SetWCDI_Award4FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Award4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award4 field.
	''' </summary>
	Public Sub SetWCDI_Award4FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Award4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award4 field.
	''' </summary>
	Public Sub SetWCDI_Award4FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Award4Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award5 field.
	''' </summary>
	Public Function GetWCDI_Award5Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Award5Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award5 field.
	''' </summary>
	Public Function GetWCDI_Award5FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Award5Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award5 field.
	''' </summary>
	Public Sub SetWCDI_Award5FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Award5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award5 field.
	''' </summary>
	Public Sub SetWCDI_Award5FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Award5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award5 field.
	''' </summary>
	Public Sub SetWCDI_Award5FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Award5Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award6 field.
	''' </summary>
	Public Function GetWCDI_Award6Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Award6Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award6 field.
	''' </summary>
	Public Function GetWCDI_Award6FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Award6Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award6 field.
	''' </summary>
	Public Sub SetWCDI_Award6FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Award6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award6 field.
	''' </summary>
	Public Sub SetWCDI_Award6FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Award6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award6 field.
	''' </summary>
	Public Sub SetWCDI_Award6FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Award6Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Status field.
	''' </summary>
	Public Function GetWCDI_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Status field.
	''' </summary>
	Public Function GetWCDI_StatusFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDI_StatusColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Status field.
	''' </summary>
	Public Sub SetWCDI_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Status field.
	''' </summary>
	Public Sub SetWCDI_StatusFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Audit_Comment field.
	''' </summary>
	Public Function GetWCDI_Audit_CommentValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Audit_CommentColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Audit_Comment field.
	''' </summary>
	Public Function GetWCDI_Audit_CommentFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDI_Audit_CommentColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Audit_Comment field.
	''' </summary>
	Public Sub SetWCDI_Audit_CommentFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Audit_CommentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Audit_Comment field.
	''' </summary>
	Public Sub SetWCDI_Audit_CommentFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Audit_CommentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Comment field.
	''' </summary>
	Public Function GetWCDI_CommentValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_CommentColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Comment field.
	''' </summary>
	Public Function GetWCDI_CommentFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDI_CommentColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Comment field.
	''' </summary>
	Public Sub SetWCDI_CommentFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_CommentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Comment field.
	''' </summary>
	Public Sub SetWCDI_CommentFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_CommentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID7 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID7Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID7Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID7 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID7FieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID7Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID7 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID7FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PM00200_Vendor_ID7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID7 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID7FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PM00200_Vendor_ID7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID8 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID8Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID8Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID8 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID8FieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID8Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID8 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID8FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PM00200_Vendor_ID8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID8 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID8FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PM00200_Vendor_ID8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID9 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID9Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID9Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID9 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID9FieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID9Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID9 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID9FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PM00200_Vendor_ID9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID9 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID9FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PM00200_Vendor_ID9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID10 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID10Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID10Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID10 field.
	''' </summary>
	Public Function GetWCDI_PM00200_Vendor_ID10FieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID10Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID10 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID10FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PM00200_Vendor_ID10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID10 field.
	''' </summary>
	Public Sub SetWCDI_PM00200_Vendor_ID10FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PM00200_Vendor_ID10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid7 field.
	''' </summary>
	Public Function GetWCDI_Bid7Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Bid7Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid7 field.
	''' </summary>
	Public Function GetWCDI_Bid7FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Bid7Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid7 field.
	''' </summary>
	Public Sub SetWCDI_Bid7FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Bid7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid7 field.
	''' </summary>
	Public Sub SetWCDI_Bid7FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Bid7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid7 field.
	''' </summary>
	Public Sub SetWCDI_Bid7FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid7 field.
	''' </summary>
	Public Sub SetWCDI_Bid7FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid7 field.
	''' </summary>
	Public Sub SetWCDI_Bid7FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid7Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid8 field.
	''' </summary>
	Public Function GetWCDI_Bid8Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Bid8Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid8 field.
	''' </summary>
	Public Function GetWCDI_Bid8FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Bid8Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid8 field.
	''' </summary>
	Public Sub SetWCDI_Bid8FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Bid8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid8 field.
	''' </summary>
	Public Sub SetWCDI_Bid8FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Bid8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid8 field.
	''' </summary>
	Public Sub SetWCDI_Bid8FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid8 field.
	''' </summary>
	Public Sub SetWCDI_Bid8FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid8 field.
	''' </summary>
	Public Sub SetWCDI_Bid8FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid8Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid9 field.
	''' </summary>
	Public Function GetWCDI_Bid9Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Bid9Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid9 field.
	''' </summary>
	Public Function GetWCDI_Bid9FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Bid9Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid9 field.
	''' </summary>
	Public Sub SetWCDI_Bid9FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Bid9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid9 field.
	''' </summary>
	Public Sub SetWCDI_Bid9FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Bid9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid9 field.
	''' </summary>
	Public Sub SetWCDI_Bid9FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid9 field.
	''' </summary>
	Public Sub SetWCDI_Bid9FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid9 field.
	''' </summary>
	Public Sub SetWCDI_Bid9FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid9Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid10 field.
	''' </summary>
	Public Function GetWCDI_Bid10Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Bid10Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid10 field.
	''' </summary>
	Public Function GetWCDI_Bid10FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Bid10Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid10 field.
	''' </summary>
	Public Sub SetWCDI_Bid10FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Bid10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid10 field.
	''' </summary>
	Public Sub SetWCDI_Bid10FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Bid10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid10 field.
	''' </summary>
	Public Sub SetWCDI_Bid10FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid10 field.
	''' </summary>
	Public Sub SetWCDI_Bid10FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Bid10 field.
	''' </summary>
	Public Sub SetWCDI_Bid10FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Bid10Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award7 field.
	''' </summary>
	Public Function GetWCDI_Award7Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Award7Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award7 field.
	''' </summary>
	Public Function GetWCDI_Award7FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Award7Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award7 field.
	''' </summary>
	Public Sub SetWCDI_Award7FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Award7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award7 field.
	''' </summary>
	Public Sub SetWCDI_Award7FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Award7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award7 field.
	''' </summary>
	Public Sub SetWCDI_Award7FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Award7Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award8 field.
	''' </summary>
	Public Function GetWCDI_Award8Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Award8Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award8 field.
	''' </summary>
	Public Function GetWCDI_Award8FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Award8Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award8 field.
	''' </summary>
	Public Sub SetWCDI_Award8FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Award8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award8 field.
	''' </summary>
	Public Sub SetWCDI_Award8FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Award8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award8 field.
	''' </summary>
	Public Sub SetWCDI_Award8FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Award8Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award9 field.
	''' </summary>
	Public Function GetWCDI_Award9Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Award9Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award9 field.
	''' </summary>
	Public Function GetWCDI_Award9FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Award9Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award9 field.
	''' </summary>
	Public Sub SetWCDI_Award9FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Award9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award9 field.
	''' </summary>
	Public Sub SetWCDI_Award9FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Award9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award9 field.
	''' </summary>
	Public Sub SetWCDI_Award9FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Award9Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award10 field.
	''' </summary>
	Public Function GetWCDI_Award10Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Award10Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award10 field.
	''' </summary>
	Public Function GetWCDI_Award10FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Award10Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award10 field.
	''' </summary>
	Public Sub SetWCDI_Award10FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Award10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award10 field.
	''' </summary>
	Public Sub SetWCDI_Award10FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Award10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Award10 field.
	''' </summary>
	Public Sub SetWCDI_Award10FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Award10Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty1 field.
	''' </summary>
	Public Function GetWCDI_Qty1Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Qty1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty1 field.
	''' </summary>
	Public Function GetWCDI_Qty1FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Qty1Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty1 field.
	''' </summary>
	Public Sub SetWCDI_Qty1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Qty1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty1 field.
	''' </summary>
	Public Sub SetWCDI_Qty1FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Qty1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty1 field.
	''' </summary>
	Public Sub SetWCDI_Qty1FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty1 field.
	''' </summary>
	Public Sub SetWCDI_Qty1FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty1 field.
	''' </summary>
	Public Sub SetWCDI_Qty1FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty1Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty2 field.
	''' </summary>
	Public Function GetWCDI_Qty2Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Qty2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty2 field.
	''' </summary>
	Public Function GetWCDI_Qty2FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Qty2Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty2 field.
	''' </summary>
	Public Sub SetWCDI_Qty2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Qty2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty2 field.
	''' </summary>
	Public Sub SetWCDI_Qty2FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Qty2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty2 field.
	''' </summary>
	Public Sub SetWCDI_Qty2FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty2 field.
	''' </summary>
	Public Sub SetWCDI_Qty2FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty2 field.
	''' </summary>
	Public Sub SetWCDI_Qty2FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty2Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty3 field.
	''' </summary>
	Public Function GetWCDI_Qty3Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Qty3Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty3 field.
	''' </summary>
	Public Function GetWCDI_Qty3FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Qty3Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty3 field.
	''' </summary>
	Public Sub SetWCDI_Qty3FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Qty3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty3 field.
	''' </summary>
	Public Sub SetWCDI_Qty3FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Qty3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty3 field.
	''' </summary>
	Public Sub SetWCDI_Qty3FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty3 field.
	''' </summary>
	Public Sub SetWCDI_Qty3FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty3 field.
	''' </summary>
	Public Sub SetWCDI_Qty3FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty3Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty4 field.
	''' </summary>
	Public Function GetWCDI_Qty4Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Qty4Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty4 field.
	''' </summary>
	Public Function GetWCDI_Qty4FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Qty4Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty4 field.
	''' </summary>
	Public Sub SetWCDI_Qty4FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Qty4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty4 field.
	''' </summary>
	Public Sub SetWCDI_Qty4FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Qty4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty4 field.
	''' </summary>
	Public Sub SetWCDI_Qty4FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty4 field.
	''' </summary>
	Public Sub SetWCDI_Qty4FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty4 field.
	''' </summary>
	Public Sub SetWCDI_Qty4FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty4Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty5 field.
	''' </summary>
	Public Function GetWCDI_Qty5Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Qty5Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty5 field.
	''' </summary>
	Public Function GetWCDI_Qty5FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Qty5Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty5 field.
	''' </summary>
	Public Sub SetWCDI_Qty5FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Qty5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty5 field.
	''' </summary>
	Public Sub SetWCDI_Qty5FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Qty5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty5 field.
	''' </summary>
	Public Sub SetWCDI_Qty5FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty5 field.
	''' </summary>
	Public Sub SetWCDI_Qty5FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty5 field.
	''' </summary>
	Public Sub SetWCDI_Qty5FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty5Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty6 field.
	''' </summary>
	Public Function GetWCDI_Qty6Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Qty6Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty6 field.
	''' </summary>
	Public Function GetWCDI_Qty6FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Qty6Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty6 field.
	''' </summary>
	Public Sub SetWCDI_Qty6FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Qty6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty6 field.
	''' </summary>
	Public Sub SetWCDI_Qty6FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Qty6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty6 field.
	''' </summary>
	Public Sub SetWCDI_Qty6FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty6 field.
	''' </summary>
	Public Sub SetWCDI_Qty6FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty6 field.
	''' </summary>
	Public Sub SetWCDI_Qty6FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty6Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty7 field.
	''' </summary>
	Public Function GetWCDI_Qty7Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Qty7Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty7 field.
	''' </summary>
	Public Function GetWCDI_Qty7FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Qty7Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty7 field.
	''' </summary>
	Public Sub SetWCDI_Qty7FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Qty7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty7 field.
	''' </summary>
	Public Sub SetWCDI_Qty7FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Qty7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty7 field.
	''' </summary>
	Public Sub SetWCDI_Qty7FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty7 field.
	''' </summary>
	Public Sub SetWCDI_Qty7FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty7 field.
	''' </summary>
	Public Sub SetWCDI_Qty7FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty7Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty8 field.
	''' </summary>
	Public Function GetWCDI_Qty8Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Qty8Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty8 field.
	''' </summary>
	Public Function GetWCDI_Qty8FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Qty8Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty8 field.
	''' </summary>
	Public Sub SetWCDI_Qty8FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Qty8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty8 field.
	''' </summary>
	Public Sub SetWCDI_Qty8FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Qty8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty8 field.
	''' </summary>
	Public Sub SetWCDI_Qty8FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty8 field.
	''' </summary>
	Public Sub SetWCDI_Qty8FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty8 field.
	''' </summary>
	Public Sub SetWCDI_Qty8FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty8Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty9 field.
	''' </summary>
	Public Function GetWCDI_Qty9Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Qty9Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty9 field.
	''' </summary>
	Public Function GetWCDI_Qty9FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Qty9Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty9 field.
	''' </summary>
	Public Sub SetWCDI_Qty9FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Qty9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty9 field.
	''' </summary>
	Public Sub SetWCDI_Qty9FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Qty9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty9 field.
	''' </summary>
	Public Sub SetWCDI_Qty9FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty9 field.
	''' </summary>
	Public Sub SetWCDI_Qty9FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty9 field.
	''' </summary>
	Public Sub SetWCDI_Qty9FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty9Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty10 field.
	''' </summary>
	Public Function GetWCDI_Qty10Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Qty10Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty10 field.
	''' </summary>
	Public Function GetWCDI_Qty10FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Qty10Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty10 field.
	''' </summary>
	Public Sub SetWCDI_Qty10FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Qty10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty10 field.
	''' </summary>
	Public Sub SetWCDI_Qty10FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Qty10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty10 field.
	''' </summary>
	Public Sub SetWCDI_Qty10FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty10 field.
	''' </summary>
	Public Sub SetWCDI_Qty10FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Qty10 field.
	''' </summary>
	Public Sub SetWCDI_Qty10FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Qty10Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO1 field.
	''' </summary>
	Public Function GetWCDI_PO1Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PO1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO1 field.
	''' </summary>
	Public Function GetWCDI_PO1FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_PO1Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO1 field.
	''' </summary>
	Public Sub SetWCDI_PO1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PO1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO1 field.
	''' </summary>
	Public Sub SetWCDI_PO1FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_PO1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO1 field.
	''' </summary>
	Public Sub SetWCDI_PO1FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PO1Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO2 field.
	''' </summary>
	Public Function GetWCDI_PO2Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PO2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO2 field.
	''' </summary>
	Public Function GetWCDI_PO2FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_PO2Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO2 field.
	''' </summary>
	Public Sub SetWCDI_PO2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PO2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO2 field.
	''' </summary>
	Public Sub SetWCDI_PO2FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_PO2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO2 field.
	''' </summary>
	Public Sub SetWCDI_PO2FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PO2Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO3 field.
	''' </summary>
	Public Function GetWCDI_PO3Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PO3Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO3 field.
	''' </summary>
	Public Function GetWCDI_PO3FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_PO3Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO3 field.
	''' </summary>
	Public Sub SetWCDI_PO3FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PO3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO3 field.
	''' </summary>
	Public Sub SetWCDI_PO3FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_PO3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO3 field.
	''' </summary>
	Public Sub SetWCDI_PO3FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PO3Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO4 field.
	''' </summary>
	Public Function GetWCDI_PO4Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PO4Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO4 field.
	''' </summary>
	Public Function GetWCDI_PO4FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_PO4Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO4 field.
	''' </summary>
	Public Sub SetWCDI_PO4FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PO4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO4 field.
	''' </summary>
	Public Sub SetWCDI_PO4FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_PO4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO4 field.
	''' </summary>
	Public Sub SetWCDI_PO4FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PO4Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO5 field.
	''' </summary>
	Public Function GetWCDI_PO5Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PO5Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO5 field.
	''' </summary>
	Public Function GetWCDI_PO5FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_PO5Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO5 field.
	''' </summary>
	Public Sub SetWCDI_PO5FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PO5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO5 field.
	''' </summary>
	Public Sub SetWCDI_PO5FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_PO5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO5 field.
	''' </summary>
	Public Sub SetWCDI_PO5FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PO5Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO6 field.
	''' </summary>
	Public Function GetWCDI_PO6Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PO6Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO6 field.
	''' </summary>
	Public Function GetWCDI_PO6FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_PO6Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO6 field.
	''' </summary>
	Public Sub SetWCDI_PO6FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PO6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO6 field.
	''' </summary>
	Public Sub SetWCDI_PO6FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_PO6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO6 field.
	''' </summary>
	Public Sub SetWCDI_PO6FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PO6Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO7 field.
	''' </summary>
	Public Function GetWCDI_PO7Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PO7Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO7 field.
	''' </summary>
	Public Function GetWCDI_PO7FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_PO7Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO7 field.
	''' </summary>
	Public Sub SetWCDI_PO7FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PO7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO7 field.
	''' </summary>
	Public Sub SetWCDI_PO7FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_PO7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO7 field.
	''' </summary>
	Public Sub SetWCDI_PO7FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PO7Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO8 field.
	''' </summary>
	Public Function GetWCDI_PO8Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PO8Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO8 field.
	''' </summary>
	Public Function GetWCDI_PO8FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_PO8Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO8 field.
	''' </summary>
	Public Sub SetWCDI_PO8FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PO8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO8 field.
	''' </summary>
	Public Sub SetWCDI_PO8FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_PO8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO8 field.
	''' </summary>
	Public Sub SetWCDI_PO8FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PO8Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO9 field.
	''' </summary>
	Public Function GetWCDI_PO9Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PO9Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO9 field.
	''' </summary>
	Public Function GetWCDI_PO9FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_PO9Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO9 field.
	''' </summary>
	Public Sub SetWCDI_PO9FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PO9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO9 field.
	''' </summary>
	Public Sub SetWCDI_PO9FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_PO9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO9 field.
	''' </summary>
	Public Sub SetWCDI_PO9FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PO9Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO10 field.
	''' </summary>
	Public Function GetWCDI_PO10Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PO10Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO10 field.
	''' </summary>
	Public Function GetWCDI_PO10FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_PO10Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO10 field.
	''' </summary>
	Public Sub SetWCDI_PO10FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PO10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO10 field.
	''' </summary>
	Public Sub SetWCDI_PO10FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_PO10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_PO10 field.
	''' </summary>
	Public Sub SetWCDI_PO10FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PO10Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw1 field.
	''' </summary>
	Public Function GetWCDI_Aw1Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Aw1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw1 field.
	''' </summary>
	Public Function GetWCDI_Aw1FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Aw1Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw1 field.
	''' </summary>
	Public Sub SetWCDI_Aw1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Aw1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw1 field.
	''' </summary>
	Public Sub SetWCDI_Aw1FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Aw1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw1 field.
	''' </summary>
	Public Sub SetWCDI_Aw1FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Aw1Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw2 field.
	''' </summary>
	Public Function GetWCDI_Aw2Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Aw2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw2 field.
	''' </summary>
	Public Function GetWCDI_Aw2FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Aw2Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw2 field.
	''' </summary>
	Public Sub SetWCDI_Aw2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Aw2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw2 field.
	''' </summary>
	Public Sub SetWCDI_Aw2FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Aw2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw2 field.
	''' </summary>
	Public Sub SetWCDI_Aw2FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Aw2Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw3 field.
	''' </summary>
	Public Function GetWCDI_Aw3Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Aw3Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw3 field.
	''' </summary>
	Public Function GetWCDI_Aw3FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Aw3Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw3 field.
	''' </summary>
	Public Sub SetWCDI_Aw3FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Aw3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw3 field.
	''' </summary>
	Public Sub SetWCDI_Aw3FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Aw3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw3 field.
	''' </summary>
	Public Sub SetWCDI_Aw3FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Aw3Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw4 field.
	''' </summary>
	Public Function GetWCDI_Aw4Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Aw4Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw4 field.
	''' </summary>
	Public Function GetWCDI_Aw4FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Aw4Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw4 field.
	''' </summary>
	Public Sub SetWCDI_Aw4FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Aw4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw4 field.
	''' </summary>
	Public Sub SetWCDI_Aw4FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Aw4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw4 field.
	''' </summary>
	Public Sub SetWCDI_Aw4FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Aw4Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw5 field.
	''' </summary>
	Public Function GetWCDI_Aw5Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Aw5Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw5 field.
	''' </summary>
	Public Function GetWCDI_Aw5FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Aw5Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw5 field.
	''' </summary>
	Public Sub SetWCDI_Aw5FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Aw5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw5 field.
	''' </summary>
	Public Sub SetWCDI_Aw5FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Aw5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw5 field.
	''' </summary>
	Public Sub SetWCDI_Aw5FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Aw5Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw6 field.
	''' </summary>
	Public Function GetWCDI_Aw6Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Aw6Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw6 field.
	''' </summary>
	Public Function GetWCDI_Aw6FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Aw6Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw6 field.
	''' </summary>
	Public Sub SetWCDI_Aw6FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Aw6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw6 field.
	''' </summary>
	Public Sub SetWCDI_Aw6FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Aw6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw6 field.
	''' </summary>
	Public Sub SetWCDI_Aw6FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Aw6Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw7 field.
	''' </summary>
	Public Function GetWCDI_Aw7Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Aw7Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw7 field.
	''' </summary>
	Public Function GetWCDI_Aw7FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Aw7Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw7 field.
	''' </summary>
	Public Sub SetWCDI_Aw7FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Aw7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw7 field.
	''' </summary>
	Public Sub SetWCDI_Aw7FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Aw7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw7 field.
	''' </summary>
	Public Sub SetWCDI_Aw7FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Aw7Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw8 field.
	''' </summary>
	Public Function GetWCDI_Aw8Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Aw8Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw8 field.
	''' </summary>
	Public Function GetWCDI_Aw8FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Aw8Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw8 field.
	''' </summary>
	Public Sub SetWCDI_Aw8FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Aw8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw8 field.
	''' </summary>
	Public Sub SetWCDI_Aw8FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Aw8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw8 field.
	''' </summary>
	Public Sub SetWCDI_Aw8FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Aw8Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw9 field.
	''' </summary>
	Public Function GetWCDI_Aw9Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Aw9Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw9 field.
	''' </summary>
	Public Function GetWCDI_Aw9FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Aw9Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw9 field.
	''' </summary>
	Public Sub SetWCDI_Aw9FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Aw9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw9 field.
	''' </summary>
	Public Sub SetWCDI_Aw9FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Aw9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw9 field.
	''' </summary>
	Public Sub SetWCDI_Aw9FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Aw9Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw10 field.
	''' </summary>
	Public Function GetWCDI_Aw10Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Aw10Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw10 field.
	''' </summary>
	Public Function GetWCDI_Aw10FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Aw10Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw10 field.
	''' </summary>
	Public Sub SetWCDI_Aw10FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Aw10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw10 field.
	''' </summary>
	Public Sub SetWCDI_Aw10FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Aw10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Aw10 field.
	''' </summary>
	Public Sub SetWCDI_Aw10FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Aw10Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat1 field.
	''' </summary>
	Public Function GetWCDI_Vat1Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Vat1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat1 field.
	''' </summary>
	Public Function GetWCDI_Vat1FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Vat1Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat1 field.
	''' </summary>
	Public Sub SetWCDI_Vat1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Vat1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat1 field.
	''' </summary>
	Public Sub SetWCDI_Vat1FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Vat1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat1 field.
	''' </summary>
	Public Sub SetWCDI_Vat1FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Vat1Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat2 field.
	''' </summary>
	Public Function GetWCDI_Vat2Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Vat2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat2 field.
	''' </summary>
	Public Function GetWCDI_Vat2FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Vat2Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat2 field.
	''' </summary>
	Public Sub SetWCDI_Vat2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Vat2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat2 field.
	''' </summary>
	Public Sub SetWCDI_Vat2FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Vat2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat2 field.
	''' </summary>
	Public Sub SetWCDI_Vat2FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Vat2Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat3 field.
	''' </summary>
	Public Function GetWCDI_Vat3Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Vat3Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat3 field.
	''' </summary>
	Public Function GetWCDI_Vat3FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Vat3Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat3 field.
	''' </summary>
	Public Sub SetWCDI_Vat3FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Vat3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat3 field.
	''' </summary>
	Public Sub SetWCDI_Vat3FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Vat3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat3 field.
	''' </summary>
	Public Sub SetWCDI_Vat3FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Vat3Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat4 field.
	''' </summary>
	Public Function GetWCDI_Vat4Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Vat4Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat4 field.
	''' </summary>
	Public Function GetWCDI_Vat4FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Vat4Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat4 field.
	''' </summary>
	Public Sub SetWCDI_Vat4FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Vat4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat4 field.
	''' </summary>
	Public Sub SetWCDI_Vat4FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Vat4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat4 field.
	''' </summary>
	Public Sub SetWCDI_Vat4FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Vat4Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat5 field.
	''' </summary>
	Public Function GetWCDI_Vat5Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Vat5Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat5 field.
	''' </summary>
	Public Function GetWCDI_Vat5FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Vat5Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat5 field.
	''' </summary>
	Public Sub SetWCDI_Vat5FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Vat5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat5 field.
	''' </summary>
	Public Sub SetWCDI_Vat5FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Vat5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat5 field.
	''' </summary>
	Public Sub SetWCDI_Vat5FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Vat5Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat6 field.
	''' </summary>
	Public Function GetWCDI_Vat6Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Vat6Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat6 field.
	''' </summary>
	Public Function GetWCDI_Vat6FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Vat6Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat6 field.
	''' </summary>
	Public Sub SetWCDI_Vat6FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Vat6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat6 field.
	''' </summary>
	Public Sub SetWCDI_Vat6FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Vat6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat6 field.
	''' </summary>
	Public Sub SetWCDI_Vat6FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Vat6Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat7 field.
	''' </summary>
	Public Function GetWCDI_Vat7Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Vat7Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat7 field.
	''' </summary>
	Public Function GetWCDI_Vat7FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Vat7Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat7 field.
	''' </summary>
	Public Sub SetWCDI_Vat7FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Vat7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat7 field.
	''' </summary>
	Public Sub SetWCDI_Vat7FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Vat7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat7 field.
	''' </summary>
	Public Sub SetWCDI_Vat7FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Vat7Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat8 field.
	''' </summary>
	Public Function GetWCDI_Vat8Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Vat8Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat8 field.
	''' </summary>
	Public Function GetWCDI_Vat8FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Vat8Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat8 field.
	''' </summary>
	Public Sub SetWCDI_Vat8FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Vat8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat8 field.
	''' </summary>
	Public Sub SetWCDI_Vat8FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Vat8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat8 field.
	''' </summary>
	Public Sub SetWCDI_Vat8FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Vat8Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat9 field.
	''' </summary>
	Public Function GetWCDI_Vat9Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Vat9Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat9 field.
	''' </summary>
	Public Function GetWCDI_Vat9FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Vat9Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat9 field.
	''' </summary>
	Public Sub SetWCDI_Vat9FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Vat9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat9 field.
	''' </summary>
	Public Sub SetWCDI_Vat9FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Vat9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat9 field.
	''' </summary>
	Public Sub SetWCDI_Vat9FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Vat9Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat10 field.
	''' </summary>
	Public Function GetWCDI_Vat10Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Vat10Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat10 field.
	''' </summary>
	Public Function GetWCDI_Vat10FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_Vat10Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat10 field.
	''' </summary>
	Public Sub SetWCDI_Vat10FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Vat10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat10 field.
	''' </summary>
	Public Sub SetWCDI_Vat10FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Vat10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Vat10 field.
	''' </summary>
	Public Sub SetWCDI_Vat10FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Vat10Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net1 field.
	''' </summary>
	Public Function GetWCDI_Net1Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Net1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net1 field.
	''' </summary>
	Public Function GetWCDI_Net1FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Net1Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net1 field.
	''' </summary>
	Public Sub SetWCDI_Net1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Net1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net1 field.
	''' </summary>
	Public Sub SetWCDI_Net1FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Net1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net1 field.
	''' </summary>
	Public Sub SetWCDI_Net1FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net1 field.
	''' </summary>
	Public Sub SetWCDI_Net1FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net1 field.
	''' </summary>
	Public Sub SetWCDI_Net1FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net1Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net2 field.
	''' </summary>
	Public Function GetWCDI_Net2Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Net2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net2 field.
	''' </summary>
	Public Function GetWCDI_Net2FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Net2Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net2 field.
	''' </summary>
	Public Sub SetWCDI_Net2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Net2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net2 field.
	''' </summary>
	Public Sub SetWCDI_Net2FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Net2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net2 field.
	''' </summary>
	Public Sub SetWCDI_Net2FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net2 field.
	''' </summary>
	Public Sub SetWCDI_Net2FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net2 field.
	''' </summary>
	Public Sub SetWCDI_Net2FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net2Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net3 field.
	''' </summary>
	Public Function GetWCDI_Net3Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Net3Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net3 field.
	''' </summary>
	Public Function GetWCDI_Net3FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Net3Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net3 field.
	''' </summary>
	Public Sub SetWCDI_Net3FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Net3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net3 field.
	''' </summary>
	Public Sub SetWCDI_Net3FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Net3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net3 field.
	''' </summary>
	Public Sub SetWCDI_Net3FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net3 field.
	''' </summary>
	Public Sub SetWCDI_Net3FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net3 field.
	''' </summary>
	Public Sub SetWCDI_Net3FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net3Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net4 field.
	''' </summary>
	Public Function GetWCDI_Net4Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Net4Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net4 field.
	''' </summary>
	Public Function GetWCDI_Net4FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Net4Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net4 field.
	''' </summary>
	Public Sub SetWCDI_Net4FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Net4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net4 field.
	''' </summary>
	Public Sub SetWCDI_Net4FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Net4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net4 field.
	''' </summary>
	Public Sub SetWCDI_Net4FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net4 field.
	''' </summary>
	Public Sub SetWCDI_Net4FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net4 field.
	''' </summary>
	Public Sub SetWCDI_Net4FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net4Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net5 field.
	''' </summary>
	Public Function GetWCDI_Net5Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Net5Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net5 field.
	''' </summary>
	Public Function GetWCDI_Net5FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Net5Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net5 field.
	''' </summary>
	Public Sub SetWCDI_Net5FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Net5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net5 field.
	''' </summary>
	Public Sub SetWCDI_Net5FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Net5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net5 field.
	''' </summary>
	Public Sub SetWCDI_Net5FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net5 field.
	''' </summary>
	Public Sub SetWCDI_Net5FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net5 field.
	''' </summary>
	Public Sub SetWCDI_Net5FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net5Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net6 field.
	''' </summary>
	Public Function GetWCDI_Net6Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Net6Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net6 field.
	''' </summary>
	Public Function GetWCDI_Net6FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Net6Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net6 field.
	''' </summary>
	Public Sub SetWCDI_Net6FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Net6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net6 field.
	''' </summary>
	Public Sub SetWCDI_Net6FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Net6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net6 field.
	''' </summary>
	Public Sub SetWCDI_Net6FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net6 field.
	''' </summary>
	Public Sub SetWCDI_Net6FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net6 field.
	''' </summary>
	Public Sub SetWCDI_Net6FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net6Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net7 field.
	''' </summary>
	Public Function GetWCDI_Net7Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Net7Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net7 field.
	''' </summary>
	Public Function GetWCDI_Net7FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Net7Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net7 field.
	''' </summary>
	Public Sub SetWCDI_Net7FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Net7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net7 field.
	''' </summary>
	Public Sub SetWCDI_Net7FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Net7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net7 field.
	''' </summary>
	Public Sub SetWCDI_Net7FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net7 field.
	''' </summary>
	Public Sub SetWCDI_Net7FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net7 field.
	''' </summary>
	Public Sub SetWCDI_Net7FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net7Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net8 field.
	''' </summary>
	Public Function GetWCDI_Net8Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Net8Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net8 field.
	''' </summary>
	Public Function GetWCDI_Net8FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Net8Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net8 field.
	''' </summary>
	Public Sub SetWCDI_Net8FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Net8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net8 field.
	''' </summary>
	Public Sub SetWCDI_Net8FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Net8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net8 field.
	''' </summary>
	Public Sub SetWCDI_Net8FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net8 field.
	''' </summary>
	Public Sub SetWCDI_Net8FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net8 field.
	''' </summary>
	Public Sub SetWCDI_Net8FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net8Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net9 field.
	''' </summary>
	Public Function GetWCDI_Net9Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Net9Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net9 field.
	''' </summary>
	Public Function GetWCDI_Net9FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Net9Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net9 field.
	''' </summary>
	Public Sub SetWCDI_Net9FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Net9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net9 field.
	''' </summary>
	Public Sub SetWCDI_Net9FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Net9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net9 field.
	''' </summary>
	Public Sub SetWCDI_Net9FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net9 field.
	''' </summary>
	Public Sub SetWCDI_Net9FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net9 field.
	''' </summary>
	Public Sub SetWCDI_Net9FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net9Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net10 field.
	''' </summary>
	Public Function GetWCDI_Net10Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Net10Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net10 field.
	''' </summary>
	Public Function GetWCDI_Net10FieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_Net10Column).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net10 field.
	''' </summary>
	Public Sub SetWCDI_Net10FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Net10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net10 field.
	''' </summary>
	Public Sub SetWCDI_Net10FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_Net10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net10 field.
	''' </summary>
	Public Sub SetWCDI_Net10FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net10 field.
	''' </summary>
	Public Sub SetWCDI_Net10FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_Net10 field.
	''' </summary>
	Public Sub SetWCDI_Net10FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Net10Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID1 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID1Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_WCur_ID1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID1 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID1FieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID1Column).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID1 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_WCur_ID1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID1 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID1FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_WCur_ID1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID1 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID1FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID1 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID1FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID1 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID1FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID1Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID2 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID2Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_WCur_ID2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID2 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID2FieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID2Column).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID2 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_WCur_ID2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID2 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID2FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_WCur_ID2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID2 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID2FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID2 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID2FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID2 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID2FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID2Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID3 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID3Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_WCur_ID3Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID3 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID3FieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID3Column).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID3 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID3FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_WCur_ID3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID3 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID3FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_WCur_ID3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID3 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID3FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID3 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID3FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID3 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID3FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID3Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID4 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID4Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_WCur_ID4Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID4 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID4FieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID4Column).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID4 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID4FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_WCur_ID4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID4 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID4FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_WCur_ID4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID4 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID4FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID4 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID4FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID4 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID4FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID4Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID5 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID5Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_WCur_ID5Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID5 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID5FieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID5Column).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID5 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID5FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_WCur_ID5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID5 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID5FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_WCur_ID5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID5 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID5FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID5 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID5FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID5 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID5FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID5Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID6 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID6Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_WCur_ID6Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID6 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID6FieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID6Column).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID6 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID6FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_WCur_ID6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID6 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID6FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_WCur_ID6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID6 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID6FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID6 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID6FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID6 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID6FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID6Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID7 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID7Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_WCur_ID7Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID7 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID7FieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID7Column).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID7 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID7FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_WCur_ID7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID7 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID7FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_WCur_ID7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID7 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID7FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID7 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID7FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID7 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID7FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID7Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID8 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID8Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_WCur_ID8Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID8 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID8FieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID8Column).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID8 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID8FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_WCur_ID8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID8 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID8FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_WCur_ID8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID8 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID8FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID8 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID8FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID8 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID8FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID8Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID9 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID9Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_WCur_ID9Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID9 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID9FieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID9Column).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID9 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID9FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_WCur_ID9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID9 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID9FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_WCur_ID9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID9 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID9FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID9 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID9FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID9 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID9FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID9Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID10 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID10Value() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_WCur_ID10Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID10 field.
	''' </summary>
	Public Function GetWCDI_WCur_ID10FieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID10Column).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID10 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID10FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_WCur_ID10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID10 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID10FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_WCur_ID10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID10 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID10FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID10 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID10FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID10Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID10 field.
	''' </summary>
	Public Sub SetWCDI_WCur_ID10FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_ID10Column)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_ID field.
	''' </summary>
	Public Property WCDI_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_IDDefault() As String
        Get
            Return TableUtils.WCDI_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCI_ID field.
	''' </summary>
	Public Property WCDI_WCI_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_WCI_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_WCI_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_WCI_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_WCI_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_WCI_IDDefault() As String
        Get
            Return TableUtils.WCDI_WCI_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WPRL_ID field.
	''' </summary>
	Public Property WCDI_WPRL_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_WPRL_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_WPRL_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_WPRL_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_WPRL_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_WPRL_IDDefault() As String
        Get
            Return TableUtils.WCDI_WPRL_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID1 field.
	''' </summary>
	Public Property WCDI_PM00200_Vendor_ID1() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID1Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCDI_PM00200_Vendor_ID1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PM00200_Vendor_ID1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID1Default() As String
        Get
            Return TableUtils.WCDI_PM00200_Vendor_ID1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID2 field.
	''' </summary>
	Public Property WCDI_PM00200_Vendor_ID2() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID2Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCDI_PM00200_Vendor_ID2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PM00200_Vendor_ID2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID2Default() As String
        Get
            Return TableUtils.WCDI_PM00200_Vendor_ID2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID3 field.
	''' </summary>
	Public Property WCDI_PM00200_Vendor_ID3() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID3Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCDI_PM00200_Vendor_ID3Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PM00200_Vendor_ID3Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID3Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID3Default() As String
        Get
            Return TableUtils.WCDI_PM00200_Vendor_ID3Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID4 field.
	''' </summary>
	Public Property WCDI_PM00200_Vendor_ID4() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID4Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCDI_PM00200_Vendor_ID4Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PM00200_Vendor_ID4Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID4Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID4Default() As String
        Get
            Return TableUtils.WCDI_PM00200_Vendor_ID4Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID5 field.
	''' </summary>
	Public Property WCDI_PM00200_Vendor_ID5() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID5Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCDI_PM00200_Vendor_ID5Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PM00200_Vendor_ID5Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID5Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID5Default() As String
        Get
            Return TableUtils.WCDI_PM00200_Vendor_ID5Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID6 field.
	''' </summary>
	Public Property WCDI_PM00200_Vendor_ID6() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID6Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCDI_PM00200_Vendor_ID6Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PM00200_Vendor_ID6Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID6Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID6Default() As String
        Get
            Return TableUtils.WCDI_PM00200_Vendor_ID6Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid1 field.
	''' </summary>
	Public Property WCDI_Bid1() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Bid1Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Bid1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Bid1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Bid1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Bid1Default() As String
        Get
            Return TableUtils.WCDI_Bid1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid2 field.
	''' </summary>
	Public Property WCDI_Bid2() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Bid2Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Bid2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Bid2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Bid2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Bid2Default() As String
        Get
            Return TableUtils.WCDI_Bid2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid3 field.
	''' </summary>
	Public Property WCDI_Bid3() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Bid3Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Bid3Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Bid3Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Bid3Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Bid3Default() As String
        Get
            Return TableUtils.WCDI_Bid3Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid4 field.
	''' </summary>
	Public Property WCDI_Bid4() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Bid4Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Bid4Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Bid4Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Bid4Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Bid4Default() As String
        Get
            Return TableUtils.WCDI_Bid4Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid5 field.
	''' </summary>
	Public Property WCDI_Bid5() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Bid5Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Bid5Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Bid5Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Bid5Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Bid5Default() As String
        Get
            Return TableUtils.WCDI_Bid5Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid6 field.
	''' </summary>
	Public Property WCDI_Bid6() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Bid6Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Bid6Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Bid6Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Bid6Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Bid6Default() As String
        Get
            Return TableUtils.WCDI_Bid6Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award1 field.
	''' </summary>
	Public Property WCDI_Award1() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Award1Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Award1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Award1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Award1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Award1Default() As String
        Get
            Return TableUtils.WCDI_Award1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award2 field.
	''' </summary>
	Public Property WCDI_Award2() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Award2Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Award2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Award2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Award2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Award2Default() As String
        Get
            Return TableUtils.WCDI_Award2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award3 field.
	''' </summary>
	Public Property WCDI_Award3() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Award3Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Award3Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Award3Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Award3Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Award3Default() As String
        Get
            Return TableUtils.WCDI_Award3Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award4 field.
	''' </summary>
	Public Property WCDI_Award4() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Award4Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Award4Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Award4Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Award4Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Award4Default() As String
        Get
            Return TableUtils.WCDI_Award4Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award5 field.
	''' </summary>
	Public Property WCDI_Award5() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Award5Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Award5Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Award5Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Award5Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Award5Default() As String
        Get
            Return TableUtils.WCDI_Award5Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award6 field.
	''' </summary>
	Public Property WCDI_Award6() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Award6Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Award6Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Award6Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Award6Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Award6Default() As String
        Get
            Return TableUtils.WCDI_Award6Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Status field.
	''' </summary>
	Public Property WCDI_Status() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_StatusColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCDI_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_StatusDefault() As String
        Get
            Return TableUtils.WCDI_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Audit_Comment field.
	''' </summary>
	Public Property WCDI_Audit_Comment() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Audit_CommentColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCDI_Audit_CommentColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Audit_CommentSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Audit_CommentColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Audit_CommentDefault() As String
        Get
            Return TableUtils.WCDI_Audit_CommentColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Comment field.
	''' </summary>
	Public Property WCDI_Comment() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_CommentColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCDI_CommentColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_CommentSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_CommentColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_CommentDefault() As String
        Get
            Return TableUtils.WCDI_CommentColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID7 field.
	''' </summary>
	Public Property WCDI_PM00200_Vendor_ID7() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID7Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCDI_PM00200_Vendor_ID7Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PM00200_Vendor_ID7Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID7Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID7Default() As String
        Get
            Return TableUtils.WCDI_PM00200_Vendor_ID7Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID8 field.
	''' </summary>
	Public Property WCDI_PM00200_Vendor_ID8() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID8Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCDI_PM00200_Vendor_ID8Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PM00200_Vendor_ID8Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID8Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID8Default() As String
        Get
            Return TableUtils.WCDI_PM00200_Vendor_ID8Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID9 field.
	''' </summary>
	Public Property WCDI_PM00200_Vendor_ID9() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID9Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCDI_PM00200_Vendor_ID9Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PM00200_Vendor_ID9Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID9Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID9Default() As String
        Get
            Return TableUtils.WCDI_PM00200_Vendor_ID9Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PM00200_Vendor_ID10 field.
	''' </summary>
	Public Property WCDI_PM00200_Vendor_ID10() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID10Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCDI_PM00200_Vendor_ID10Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PM00200_Vendor_ID10Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PM00200_Vendor_ID10Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PM00200_Vendor_ID10Default() As String
        Get
            Return TableUtils.WCDI_PM00200_Vendor_ID10Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid7 field.
	''' </summary>
	Public Property WCDI_Bid7() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Bid7Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Bid7Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Bid7Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Bid7Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Bid7Default() As String
        Get
            Return TableUtils.WCDI_Bid7Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid8 field.
	''' </summary>
	Public Property WCDI_Bid8() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Bid8Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Bid8Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Bid8Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Bid8Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Bid8Default() As String
        Get
            Return TableUtils.WCDI_Bid8Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid9 field.
	''' </summary>
	Public Property WCDI_Bid9() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Bid9Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Bid9Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Bid9Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Bid9Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Bid9Default() As String
        Get
            Return TableUtils.WCDI_Bid9Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Bid10 field.
	''' </summary>
	Public Property WCDI_Bid10() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Bid10Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Bid10Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Bid10Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Bid10Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Bid10Default() As String
        Get
            Return TableUtils.WCDI_Bid10Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award7 field.
	''' </summary>
	Public Property WCDI_Award7() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Award7Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Award7Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Award7Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Award7Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Award7Default() As String
        Get
            Return TableUtils.WCDI_Award7Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award8 field.
	''' </summary>
	Public Property WCDI_Award8() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Award8Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Award8Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Award8Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Award8Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Award8Default() As String
        Get
            Return TableUtils.WCDI_Award8Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award9 field.
	''' </summary>
	Public Property WCDI_Award9() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Award9Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Award9Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Award9Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Award9Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Award9Default() As String
        Get
            Return TableUtils.WCDI_Award9Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Award10 field.
	''' </summary>
	Public Property WCDI_Award10() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Award10Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Award10Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Award10Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Award10Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Award10Default() As String
        Get
            Return TableUtils.WCDI_Award10Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty1 field.
	''' </summary>
	Public Property WCDI_Qty1() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Qty1Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Qty1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Qty1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Qty1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Qty1Default() As String
        Get
            Return TableUtils.WCDI_Qty1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty2 field.
	''' </summary>
	Public Property WCDI_Qty2() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Qty2Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Qty2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Qty2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Qty2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Qty2Default() As String
        Get
            Return TableUtils.WCDI_Qty2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty3 field.
	''' </summary>
	Public Property WCDI_Qty3() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Qty3Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Qty3Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Qty3Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Qty3Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Qty3Default() As String
        Get
            Return TableUtils.WCDI_Qty3Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty4 field.
	''' </summary>
	Public Property WCDI_Qty4() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Qty4Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Qty4Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Qty4Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Qty4Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Qty4Default() As String
        Get
            Return TableUtils.WCDI_Qty4Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty5 field.
	''' </summary>
	Public Property WCDI_Qty5() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Qty5Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Qty5Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Qty5Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Qty5Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Qty5Default() As String
        Get
            Return TableUtils.WCDI_Qty5Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty6 field.
	''' </summary>
	Public Property WCDI_Qty6() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Qty6Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Qty6Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Qty6Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Qty6Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Qty6Default() As String
        Get
            Return TableUtils.WCDI_Qty6Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty7 field.
	''' </summary>
	Public Property WCDI_Qty7() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Qty7Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Qty7Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Qty7Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Qty7Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Qty7Default() As String
        Get
            Return TableUtils.WCDI_Qty7Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty8 field.
	''' </summary>
	Public Property WCDI_Qty8() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Qty8Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Qty8Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Qty8Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Qty8Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Qty8Default() As String
        Get
            Return TableUtils.WCDI_Qty8Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty9 field.
	''' </summary>
	Public Property WCDI_Qty9() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Qty9Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Qty9Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Qty9Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Qty9Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Qty9Default() As String
        Get
            Return TableUtils.WCDI_Qty9Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Qty10 field.
	''' </summary>
	Public Property WCDI_Qty10() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Qty10Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Qty10Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Qty10Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Qty10Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Qty10Default() As String
        Get
            Return TableUtils.WCDI_Qty10Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO1 field.
	''' </summary>
	Public Property WCDI_PO1() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PO1Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_PO1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PO1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PO1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PO1Default() As String
        Get
            Return TableUtils.WCDI_PO1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO2 field.
	''' </summary>
	Public Property WCDI_PO2() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PO2Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_PO2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PO2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PO2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PO2Default() As String
        Get
            Return TableUtils.WCDI_PO2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO3 field.
	''' </summary>
	Public Property WCDI_PO3() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PO3Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_PO3Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PO3Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PO3Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PO3Default() As String
        Get
            Return TableUtils.WCDI_PO3Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO4 field.
	''' </summary>
	Public Property WCDI_PO4() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PO4Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_PO4Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PO4Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PO4Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PO4Default() As String
        Get
            Return TableUtils.WCDI_PO4Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO5 field.
	''' </summary>
	Public Property WCDI_PO5() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PO5Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_PO5Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PO5Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PO5Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PO5Default() As String
        Get
            Return TableUtils.WCDI_PO5Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO6 field.
	''' </summary>
	Public Property WCDI_PO6() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PO6Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_PO6Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PO6Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PO6Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PO6Default() As String
        Get
            Return TableUtils.WCDI_PO6Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO7 field.
	''' </summary>
	Public Property WCDI_PO7() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PO7Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_PO7Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PO7Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PO7Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PO7Default() As String
        Get
            Return TableUtils.WCDI_PO7Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO8 field.
	''' </summary>
	Public Property WCDI_PO8() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PO8Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_PO8Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PO8Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PO8Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PO8Default() As String
        Get
            Return TableUtils.WCDI_PO8Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO9 field.
	''' </summary>
	Public Property WCDI_PO9() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PO9Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_PO9Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PO9Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PO9Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PO9Default() As String
        Get
            Return TableUtils.WCDI_PO9Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_PO10 field.
	''' </summary>
	Public Property WCDI_PO10() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PO10Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_PO10Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PO10Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PO10Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PO10Default() As String
        Get
            Return TableUtils.WCDI_PO10Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw1 field.
	''' </summary>
	Public Property WCDI_Aw1() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Aw1Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Aw1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Aw1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Aw1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Aw1Default() As String
        Get
            Return TableUtils.WCDI_Aw1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw2 field.
	''' </summary>
	Public Property WCDI_Aw2() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Aw2Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Aw2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Aw2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Aw2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Aw2Default() As String
        Get
            Return TableUtils.WCDI_Aw2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw3 field.
	''' </summary>
	Public Property WCDI_Aw3() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Aw3Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Aw3Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Aw3Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Aw3Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Aw3Default() As String
        Get
            Return TableUtils.WCDI_Aw3Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw4 field.
	''' </summary>
	Public Property WCDI_Aw4() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Aw4Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Aw4Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Aw4Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Aw4Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Aw4Default() As String
        Get
            Return TableUtils.WCDI_Aw4Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw5 field.
	''' </summary>
	Public Property WCDI_Aw5() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Aw5Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Aw5Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Aw5Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Aw5Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Aw5Default() As String
        Get
            Return TableUtils.WCDI_Aw5Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw6 field.
	''' </summary>
	Public Property WCDI_Aw6() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Aw6Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Aw6Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Aw6Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Aw6Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Aw6Default() As String
        Get
            Return TableUtils.WCDI_Aw6Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw7 field.
	''' </summary>
	Public Property WCDI_Aw7() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Aw7Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Aw7Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Aw7Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Aw7Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Aw7Default() As String
        Get
            Return TableUtils.WCDI_Aw7Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw8 field.
	''' </summary>
	Public Property WCDI_Aw8() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Aw8Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Aw8Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Aw8Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Aw8Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Aw8Default() As String
        Get
            Return TableUtils.WCDI_Aw8Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw9 field.
	''' </summary>
	Public Property WCDI_Aw9() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Aw9Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Aw9Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Aw9Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Aw9Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Aw9Default() As String
        Get
            Return TableUtils.WCDI_Aw9Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Aw10 field.
	''' </summary>
	Public Property WCDI_Aw10() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Aw10Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Aw10Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Aw10Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Aw10Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Aw10Default() As String
        Get
            Return TableUtils.WCDI_Aw10Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat1 field.
	''' </summary>
	Public Property WCDI_Vat1() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Vat1Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Vat1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Vat1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Vat1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Vat1Default() As String
        Get
            Return TableUtils.WCDI_Vat1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat2 field.
	''' </summary>
	Public Property WCDI_Vat2() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Vat2Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Vat2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Vat2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Vat2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Vat2Default() As String
        Get
            Return TableUtils.WCDI_Vat2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat3 field.
	''' </summary>
	Public Property WCDI_Vat3() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Vat3Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Vat3Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Vat3Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Vat3Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Vat3Default() As String
        Get
            Return TableUtils.WCDI_Vat3Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat4 field.
	''' </summary>
	Public Property WCDI_Vat4() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Vat4Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Vat4Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Vat4Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Vat4Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Vat4Default() As String
        Get
            Return TableUtils.WCDI_Vat4Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat5 field.
	''' </summary>
	Public Property WCDI_Vat5() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Vat5Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Vat5Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Vat5Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Vat5Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Vat5Default() As String
        Get
            Return TableUtils.WCDI_Vat5Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat6 field.
	''' </summary>
	Public Property WCDI_Vat6() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Vat6Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Vat6Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Vat6Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Vat6Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Vat6Default() As String
        Get
            Return TableUtils.WCDI_Vat6Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat7 field.
	''' </summary>
	Public Property WCDI_Vat7() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Vat7Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Vat7Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Vat7Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Vat7Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Vat7Default() As String
        Get
            Return TableUtils.WCDI_Vat7Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat8 field.
	''' </summary>
	Public Property WCDI_Vat8() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Vat8Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Vat8Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Vat8Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Vat8Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Vat8Default() As String
        Get
            Return TableUtils.WCDI_Vat8Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat9 field.
	''' </summary>
	Public Property WCDI_Vat9() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Vat9Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Vat9Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Vat9Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Vat9Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Vat9Default() As String
        Get
            Return TableUtils.WCDI_Vat9Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Vat10 field.
	''' </summary>
	Public Property WCDI_Vat10() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Vat10Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Vat10Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Vat10Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Vat10Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Vat10Default() As String
        Get
            Return TableUtils.WCDI_Vat10Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net1 field.
	''' </summary>
	Public Property WCDI_Net1() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Net1Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Net1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Net1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Net1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Net1Default() As String
        Get
            Return TableUtils.WCDI_Net1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net2 field.
	''' </summary>
	Public Property WCDI_Net2() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Net2Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Net2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Net2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Net2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Net2Default() As String
        Get
            Return TableUtils.WCDI_Net2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net3 field.
	''' </summary>
	Public Property WCDI_Net3() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Net3Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Net3Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Net3Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Net3Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Net3Default() As String
        Get
            Return TableUtils.WCDI_Net3Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net4 field.
	''' </summary>
	Public Property WCDI_Net4() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Net4Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Net4Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Net4Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Net4Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Net4Default() As String
        Get
            Return TableUtils.WCDI_Net4Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net5 field.
	''' </summary>
	Public Property WCDI_Net5() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Net5Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Net5Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Net5Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Net5Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Net5Default() As String
        Get
            Return TableUtils.WCDI_Net5Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net6 field.
	''' </summary>
	Public Property WCDI_Net6() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Net6Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Net6Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Net6Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Net6Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Net6Default() As String
        Get
            Return TableUtils.WCDI_Net6Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net7 field.
	''' </summary>
	Public Property WCDI_Net7() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Net7Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Net7Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Net7Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Net7Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Net7Default() As String
        Get
            Return TableUtils.WCDI_Net7Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net8 field.
	''' </summary>
	Public Property WCDI_Net8() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Net8Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Net8Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Net8Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Net8Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Net8Default() As String
        Get
            Return TableUtils.WCDI_Net8Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net9 field.
	''' </summary>
	Public Property WCDI_Net9() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Net9Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Net9Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Net9Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Net9Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Net9Default() As String
        Get
            Return TableUtils.WCDI_Net9Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_Net10 field.
	''' </summary>
	Public Property WCDI_Net10() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_Net10Column).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_Net10Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_Net10Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_Net10Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_Net10Default() As String
        Get
            Return TableUtils.WCDI_Net10Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID1 field.
	''' </summary>
	Public Property WCDI_WCur_ID1() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID1Column).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_WCur_ID1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_WCur_ID1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_WCur_ID1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_WCur_ID1Default() As String
        Get
            Return TableUtils.WCDI_WCur_ID1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID2 field.
	''' </summary>
	Public Property WCDI_WCur_ID2() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID2Column).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_WCur_ID2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_WCur_ID2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_WCur_ID2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_WCur_ID2Default() As String
        Get
            Return TableUtils.WCDI_WCur_ID2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID3 field.
	''' </summary>
	Public Property WCDI_WCur_ID3() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID3Column).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_WCur_ID3Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_WCur_ID3Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_WCur_ID3Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_WCur_ID3Default() As String
        Get
            Return TableUtils.WCDI_WCur_ID3Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID4 field.
	''' </summary>
	Public Property WCDI_WCur_ID4() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID4Column).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_WCur_ID4Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_WCur_ID4Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_WCur_ID4Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_WCur_ID4Default() As String
        Get
            Return TableUtils.WCDI_WCur_ID4Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID5 field.
	''' </summary>
	Public Property WCDI_WCur_ID5() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID5Column).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_WCur_ID5Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_WCur_ID5Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_WCur_ID5Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_WCur_ID5Default() As String
        Get
            Return TableUtils.WCDI_WCur_ID5Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID6 field.
	''' </summary>
	Public Property WCDI_WCur_ID6() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID6Column).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_WCur_ID6Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_WCur_ID6Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_WCur_ID6Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_WCur_ID6Default() As String
        Get
            Return TableUtils.WCDI_WCur_ID6Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID7 field.
	''' </summary>
	Public Property WCDI_WCur_ID7() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID7Column).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_WCur_ID7Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_WCur_ID7Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_WCur_ID7Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_WCur_ID7Default() As String
        Get
            Return TableUtils.WCDI_WCur_ID7Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID8 field.
	''' </summary>
	Public Property WCDI_WCur_ID8() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID8Column).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_WCur_ID8Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_WCur_ID8Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_WCur_ID8Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_WCur_ID8Default() As String
        Get
            Return TableUtils.WCDI_WCur_ID8Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID9 field.
	''' </summary>
	Public Property WCDI_WCur_ID9() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID9Column).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_WCur_ID9Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_WCur_ID9Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_WCur_ID9Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_WCur_ID9Default() As String
        Get
            Return TableUtils.WCDI_WCur_ID9Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Detail_Internal_.WCDI_WCur_ID10 field.
	''' </summary>
	Public Property WCDI_WCur_ID10() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_WCur_ID10Column).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_WCur_ID10Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_WCur_ID10Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_WCur_ID10Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_WCur_ID10Default() As String
        Get
            Return TableUtils.WCDI_WCur_ID10Column.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
