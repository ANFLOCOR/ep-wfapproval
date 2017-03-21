' This class is "generated" and will be overwritten.
' Your customizations should be made in WCanvass_PO_Map1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WCanvass_PO_Map1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WCanvass_PO_Map1Table"></see> class.
''' </remarks>
''' <seealso cref="WCanvass_PO_Map1Table"></seealso>
''' <seealso cref="WCanvass_PO_Map1Record"></seealso>

<Serializable()> Public Class BaseWCanvass_PO_Map1Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WCanvass_PO_Map1Table = WCanvass_PO_Map1Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WCanvass_PO_Map1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WCanvass_PO_Map1Rec As WCanvass_PO_Map1Record = CType(sender,WCanvass_PO_Map1Record)
        Validate_Inserting()
        If Not WCanvass_PO_Map1Rec Is Nothing AndAlso Not WCanvass_PO_Map1Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WCanvass_PO_Map1Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WCanvass_PO_Map1Rec As WCanvass_PO_Map1Record = CType(sender,WCanvass_PO_Map1Record)
        Validate_Updating()
        If Not WCanvass_PO_Map1Rec Is Nothing AndAlso Not WCanvass_PO_Map1Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WCanvass_PO_Map1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WCanvass_PO_Map1Rec As WCanvass_PO_Map1Record = CType(sender,WCanvass_PO_Map1Record)
        If Not WCanvass_PO_Map1Rec Is Nothing AndAlso Not WCanvass_PO_Map1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_ID field.
	''' </summary>
	Public Function GetWCPOM_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCPOM_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_ID field.
	''' </summary>
	Public Function GetWCPOM_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCPOM_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_C_ID field.
	''' </summary>
	Public Function GetWCPOM_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCPOM_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_C_ID field.
	''' </summary>
	Public Function GetWCPOM_C_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCPOM_C_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_C_ID field.
	''' </summary>
	Public Sub SetWCPOM_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCPOM_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_C_ID field.
	''' </summary>
	Public Sub SetWCPOM_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCPOM_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_C_ID field.
	''' </summary>
	Public Sub SetWCPOM_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_C_ID field.
	''' </summary>
	Public Sub SetWCPOM_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_C_ID field.
	''' </summary>
	Public Sub SetWCPOM_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_WCDI_ID field.
	''' </summary>
	Public Function GetWCPOM_WCDI_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCPOM_WCDI_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_WCDI_ID field.
	''' </summary>
	Public Function GetWCPOM_WCDI_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCPOM_WCDI_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_WCDI_ID field.
	''' </summary>
	Public Sub SetWCPOM_WCDI_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCPOM_WCDI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_WCDI_ID field.
	''' </summary>
	Public Sub SetWCPOM_WCDI_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCPOM_WCDI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_WCDI_ID field.
	''' </summary>
	Public Sub SetWCPOM_WCDI_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_WCDI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_WCDI_ID field.
	''' </summary>
	Public Sub SetWCPOM_WCDI_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_WCDI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_WCDI_ID field.
	''' </summary>
	Public Sub SetWCPOM_WCDI_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_WCDI_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_WPRD_ID field.
	''' </summary>
	Public Function GetWCPOM_WPRD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCPOM_WPRD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_WPRD_ID field.
	''' </summary>
	Public Function GetWCPOM_WPRD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCPOM_WPRD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_WPRD_ID field.
	''' </summary>
	Public Sub SetWCPOM_WPRD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCPOM_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_WPRD_ID field.
	''' </summary>
	Public Sub SetWCPOM_WPRD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCPOM_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_WPRD_ID field.
	''' </summary>
	Public Sub SetWCPOM_WPRD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_WPRD_ID field.
	''' </summary>
	Public Sub SetWCPOM_WPRD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_WPRD_ID field.
	''' </summary>
	Public Sub SetWCPOM_WPRD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_WPRD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_WPRL_ID field.
	''' </summary>
	Public Function GetWCPOM_WPRL_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCPOM_WPRL_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_WPRL_ID field.
	''' </summary>
	Public Function GetWCPOM_WPRL_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCPOM_WPRL_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_WPRL_ID field.
	''' </summary>
	Public Sub SetWCPOM_WPRL_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCPOM_WPRL_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_WPRL_ID field.
	''' </summary>
	Public Sub SetWCPOM_WPRL_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCPOM_WPRL_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_WPRL_ID field.
	''' </summary>
	Public Sub SetWCPOM_WPRL_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_WPRL_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_WPRL_ID field.
	''' </summary>
	Public Sub SetWCPOM_WPRL_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_WPRL_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_WPRL_ID field.
	''' </summary>
	Public Sub SetWCPOM_WPRL_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_WPRL_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_U_ID field.
	''' </summary>
	Public Function GetWCPOM_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCPOM_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_U_ID field.
	''' </summary>
	Public Function GetWCPOM_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCPOM_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_U_ID field.
	''' </summary>
	Public Sub SetWCPOM_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCPOM_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_U_ID field.
	''' </summary>
	Public Sub SetWCPOM_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCPOM_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_U_ID field.
	''' </summary>
	Public Sub SetWCPOM_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_U_ID field.
	''' </summary>
	Public Sub SetWCPOM_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_U_ID field.
	''' </summary>
	Public Sub SetWCPOM_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_PO_No field.
	''' </summary>
	Public Function GetWCPOM_PO_NoValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCPOM_PO_NoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_PO_No field.
	''' </summary>
	Public Function GetWCPOM_PO_NoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCPOM_PO_NoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_PO_No field.
	''' </summary>
	Public Sub SetWCPOM_PO_NoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCPOM_PO_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_PO_No field.
	''' </summary>
	Public Sub SetWCPOM_PO_NoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_PO_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_Date field.
	''' </summary>
	Public Function GetWCPOM_DateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCPOM_DateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_Date field.
	''' </summary>
	Public Function GetWCPOM_DateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WCPOM_DateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_Date field.
	''' </summary>
	Public Sub SetWCPOM_DateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCPOM_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_Date field.
	''' </summary>
	Public Sub SetWCPOM_DateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCPOM_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_Date field.
	''' </summary>
	Public Sub SetWCPOM_DateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_PM00200_Vendor field.
	''' </summary>
	Public Function GetWCPOM_PM00200_VendorValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCPOM_PM00200_VendorColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_PM00200_Vendor field.
	''' </summary>
	Public Function GetWCPOM_PM00200_VendorFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCPOM_PM00200_VendorColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_PM00200_Vendor field.
	''' </summary>
	Public Sub SetWCPOM_PM00200_VendorFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCPOM_PM00200_VendorColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_PM00200_Vendor field.
	''' </summary>
	Public Sub SetWCPOM_PM00200_VendorFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_PM00200_VendorColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_Bid field.
	''' </summary>
	Public Function GetWCPOM_BidValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCPOM_BidColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_Bid field.
	''' </summary>
	Public Function GetWCPOM_BidFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCPOM_BidColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_Bid field.
	''' </summary>
	Public Sub SetWCPOM_BidFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCPOM_BidColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_Bid field.
	''' </summary>
	Public Sub SetWCPOM_BidFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCPOM_BidColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_Bid field.
	''' </summary>
	Public Sub SetWCPOM_BidFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_BidColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_Bid field.
	''' </summary>
	Public Sub SetWCPOM_BidFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_BidColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_Bid field.
	''' </summary>
	Public Sub SetWCPOM_BidFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_BidColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_Qty field.
	''' </summary>
	Public Function GetWCPOM_QtyValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCPOM_QtyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_Qty field.
	''' </summary>
	Public Function GetWCPOM_QtyFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCPOM_QtyColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_Qty field.
	''' </summary>
	Public Sub SetWCPOM_QtyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCPOM_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_Qty field.
	''' </summary>
	Public Sub SetWCPOM_QtyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCPOM_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_Qty field.
	''' </summary>
	Public Sub SetWCPOM_QtyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_Qty field.
	''' </summary>
	Public Sub SetWCPOM_QtyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_Qty field.
	''' </summary>
	Public Sub SetWCPOM_QtyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_QtyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_PO_Line field.
	''' </summary>
	Public Function GetWCPOM_PO_LineValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCPOM_PO_LineColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_PO_Line field.
	''' </summary>
	Public Function GetWCPOM_PO_LineFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCPOM_PO_LineColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_PO_Line field.
	''' </summary>
	Public Sub SetWCPOM_PO_LineFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCPOM_PO_LineColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_PO_Line field.
	''' </summary>
	Public Sub SetWCPOM_PO_LineFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCPOM_PO_LineColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_PO_Line field.
	''' </summary>
	Public Sub SetWCPOM_PO_LineFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_PO_LineColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_PO_Line field.
	''' </summary>
	Public Sub SetWCPOM_PO_LineFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_PO_LineColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_PO_Line field.
	''' </summary>
	Public Sub SetWCPOM_PO_LineFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_PO_LineColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_Col_Marker field.
	''' </summary>
	Public Function GetWCPOM_Col_MarkerValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCPOM_Col_MarkerColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_Col_Marker field.
	''' </summary>
	Public Function GetWCPOM_Col_MarkerFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCPOM_Col_MarkerColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_Col_Marker field.
	''' </summary>
	Public Sub SetWCPOM_Col_MarkerFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCPOM_Col_MarkerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_Col_Marker field.
	''' </summary>
	Public Sub SetWCPOM_Col_MarkerFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCPOM_Col_MarkerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_Col_Marker field.
	''' </summary>
	Public Sub SetWCPOM_Col_MarkerFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_Col_MarkerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_Col_Marker field.
	''' </summary>
	Public Sub SetWCPOM_Col_MarkerFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_Col_MarkerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_.WCPOM_Col_Marker field.
	''' </summary>
	Public Sub SetWCPOM_Col_MarkerFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCPOM_Col_MarkerColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_ID field.
	''' </summary>
	Public Property WCPOM_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCPOM_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCPOM_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCPOM_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCPOM_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCPOM_IDDefault() As String
        Get
            Return TableUtils.WCPOM_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_C_ID field.
	''' </summary>
	Public Property WCPOM_C_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCPOM_C_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCPOM_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCPOM_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCPOM_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCPOM_C_IDDefault() As String
        Get
            Return TableUtils.WCPOM_C_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_WCDI_ID field.
	''' </summary>
	Public Property WCPOM_WCDI_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCPOM_WCDI_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCPOM_WCDI_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCPOM_WCDI_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCPOM_WCDI_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCPOM_WCDI_IDDefault() As String
        Get
            Return TableUtils.WCPOM_WCDI_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_WPRD_ID field.
	''' </summary>
	Public Property WCPOM_WPRD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCPOM_WPRD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCPOM_WPRD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCPOM_WPRD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCPOM_WPRD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCPOM_WPRD_IDDefault() As String
        Get
            Return TableUtils.WCPOM_WPRD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_WPRL_ID field.
	''' </summary>
	Public Property WCPOM_WPRL_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCPOM_WPRL_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCPOM_WPRL_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCPOM_WPRL_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCPOM_WPRL_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCPOM_WPRL_IDDefault() As String
        Get
            Return TableUtils.WCPOM_WPRL_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_U_ID field.
	''' </summary>
	Public Property WCPOM_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCPOM_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCPOM_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCPOM_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCPOM_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCPOM_U_IDDefault() As String
        Get
            Return TableUtils.WCPOM_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_PO_No field.
	''' </summary>
	Public Property WCPOM_PO_No() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCPOM_PO_NoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCPOM_PO_NoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCPOM_PO_NoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCPOM_PO_NoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCPOM_PO_NoDefault() As String
        Get
            Return TableUtils.WCPOM_PO_NoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_Date field.
	''' </summary>
	Public Property WCPOM_Date() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WCPOM_DateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCPOM_DateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCPOM_DateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCPOM_DateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCPOM_DateDefault() As String
        Get
            Return TableUtils.WCPOM_DateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_PM00200_Vendor field.
	''' </summary>
	Public Property WCPOM_PM00200_Vendor() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCPOM_PM00200_VendorColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCPOM_PM00200_VendorColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCPOM_PM00200_VendorSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCPOM_PM00200_VendorColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCPOM_PM00200_VendorDefault() As String
        Get
            Return TableUtils.WCPOM_PM00200_VendorColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_Bid field.
	''' </summary>
	Public Property WCPOM_Bid() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCPOM_BidColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCPOM_BidColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCPOM_BidSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCPOM_BidColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCPOM_BidDefault() As String
        Get
            Return TableUtils.WCPOM_BidColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_Qty field.
	''' </summary>
	Public Property WCPOM_Qty() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCPOM_QtyColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCPOM_QtyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCPOM_QtySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCPOM_QtyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCPOM_QtyDefault() As String
        Get
            Return TableUtils.WCPOM_QtyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_PO_Line field.
	''' </summary>
	Public Property WCPOM_PO_Line() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCPOM_PO_LineColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCPOM_PO_LineColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCPOM_PO_LineSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCPOM_PO_LineColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCPOM_PO_LineDefault() As String
        Get
            Return TableUtils.WCPOM_PO_LineColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_.WCPOM_Col_Marker field.
	''' </summary>
	Public Property WCPOM_Col_Marker() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCPOM_Col_MarkerColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCPOM_Col_MarkerColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCPOM_Col_MarkerSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCPOM_Col_MarkerColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCPOM_Col_MarkerDefault() As String
        Get
            Return TableUtils.WCPOM_Col_MarkerColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
