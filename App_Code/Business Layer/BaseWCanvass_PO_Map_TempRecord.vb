' This class is "generated" and will be overwritten.
' Your customizations should be made in WCanvass_PO_Map_TempRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WCanvass_PO_Map_TempRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WCanvass_PO_Map_TempTable"></see> class.
''' </remarks>
''' <seealso cref="WCanvass_PO_Map_TempTable"></seealso>
''' <seealso cref="WCanvass_PO_Map_TempRecord"></seealso>

<Serializable()> Public Class BaseWCanvass_PO_Map_TempRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WCanvass_PO_Map_TempTable = WCanvass_PO_Map_TempTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WCanvass_PO_Map_TempRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WCanvass_PO_Map_TempRec As WCanvass_PO_Map_TempRecord = CType(sender,WCanvass_PO_Map_TempRecord)
        Validate_Inserting()
        If Not WCanvass_PO_Map_TempRec Is Nothing AndAlso Not WCanvass_PO_Map_TempRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WCanvass_PO_Map_TempRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WCanvass_PO_Map_TempRec As WCanvass_PO_Map_TempRecord = CType(sender,WCanvass_PO_Map_TempRecord)
        Validate_Updating()
        If Not WCanvass_PO_Map_TempRec Is Nothing AndAlso Not WCanvass_PO_Map_TempRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WCanvass_PO_Map_TempRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WCanvass_PO_Map_TempRec As WCanvass_PO_Map_TempRecord = CType(sender,WCanvass_PO_Map_TempRecord)
        If Not WCanvass_PO_Map_TempRec Is Nothing AndAlso Not WCanvass_PO_Map_TempRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Temp_ID field.
	''' </summary>
	Public Function GetTemp_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.Temp_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Temp_ID field.
	''' </summary>
	Public Function GetTemp_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.Temp_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_ID field.
	''' </summary>
	Public Function GetWCDI_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_ID field.
	''' </summary>
	Public Function GetWCDI_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCDI_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_ID field.
	''' </summary>
	Public Sub SetWCDI_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_ID field.
	''' </summary>
	Public Sub SetWCDI_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_ID field.
	''' </summary>
	Public Sub SetWCDI_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_ID field.
	''' </summary>
	Public Sub SetWCDI_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_ID field.
	''' </summary>
	Public Sub SetWCDI_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_WCI_ID field.
	''' </summary>
	Public Function GetWCDI_WCI_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_WCI_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_WCI_ID field.
	''' </summary>
	Public Function GetWCDI_WCI_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCDI_WCI_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_WCI_ID field.
	''' </summary>
	Public Sub SetWCDI_WCI_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_WCI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_WCI_ID field.
	''' </summary>
	Public Sub SetWCDI_WCI_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_WCI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_WCI_ID field.
	''' </summary>
	Public Sub SetWCDI_WCI_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_WCI_ID field.
	''' </summary>
	Public Sub SetWCDI_WCI_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_WCI_ID field.
	''' </summary>
	Public Sub SetWCDI_WCI_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCI_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_WPRL_ID field.
	''' </summary>
	Public Function GetWCDI_WPRL_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_WPRL_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_WPRL_ID field.
	''' </summary>
	Public Function GetWCDI_WPRL_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCDI_WPRL_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_WPRL_ID field.
	''' </summary>
	Public Sub SetWCDI_WPRL_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_WPRL_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_WPRL_ID field.
	''' </summary>
	Public Sub SetWCDI_WPRL_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_WPRL_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_WPRL_ID field.
	''' </summary>
	Public Sub SetWCDI_WPRL_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WPRL_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_WPRL_ID field.
	''' </summary>
	Public Sub SetWCDI_WPRL_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WPRL_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_WPRL_ID field.
	''' </summary>
	Public Sub SetWCDI_WPRL_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WPRL_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Status field.
	''' </summary>
	Public Function GetWCDI_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Status field.
	''' </summary>
	Public Function GetWCDI_StatusFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDI_StatusColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Status field.
	''' </summary>
	Public Sub SetWCDI_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Status field.
	''' </summary>
	Public Sub SetWCDI_StatusFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Audit_Comment field.
	''' </summary>
	Public Function GetWCDI_Audit_CommentValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_Audit_CommentColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Audit_Comment field.
	''' </summary>
	Public Function GetWCDI_Audit_CommentFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDI_Audit_CommentColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Audit_Comment field.
	''' </summary>
	Public Sub SetWCDI_Audit_CommentFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_Audit_CommentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Audit_Comment field.
	''' </summary>
	Public Sub SetWCDI_Audit_CommentFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_Audit_CommentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Comment field.
	''' </summary>
	Public Function GetWCDI_CommentValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_CommentColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Comment field.
	''' </summary>
	Public Function GetWCDI_CommentFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDI_CommentColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Comment field.
	''' </summary>
	Public Sub SetWCDI_CommentFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_CommentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Comment field.
	''' </summary>
	Public Sub SetWCDI_CommentFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_CommentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_PM00200_Vendor field.
	''' </summary>
	Public Function GetWCDI_PM00200_VendorValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_PM00200_VendorColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_PM00200_Vendor field.
	''' </summary>
	Public Function GetWCDI_PM00200_VendorFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDI_PM00200_VendorColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_PM00200_Vendor field.
	''' </summary>
	Public Sub SetWCDI_PM00200_VendorFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_PM00200_VendorColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_PM00200_Vendor field.
	''' </summary>
	Public Sub SetWCDI_PM00200_VendorFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_PM00200_VendorColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Qty field.
	''' </summary>
	Public Function GetWCDI_QtyValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_QtyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Qty field.
	''' </summary>
	Public Function GetWCDI_QtyFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_QtyColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Qty field.
	''' </summary>
	Public Sub SetWCDI_QtyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Qty field.
	''' </summary>
	Public Sub SetWCDI_QtyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Qty field.
	''' </summary>
	Public Sub SetWCDI_QtyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Qty field.
	''' </summary>
	Public Sub SetWCDI_QtyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Qty field.
	''' </summary>
	Public Sub SetWCDI_QtyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_QtyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Bid field.
	''' </summary>
	Public Function GetWCDI_BidValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_BidColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Bid field.
	''' </summary>
	Public Function GetWCDI_BidFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_BidColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Bid field.
	''' </summary>
	Public Sub SetWCDI_BidFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_BidColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Bid field.
	''' </summary>
	Public Sub SetWCDI_BidFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_BidColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Bid field.
	''' </summary>
	Public Sub SetWCDI_BidFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_BidColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Bid field.
	''' </summary>
	Public Sub SetWCDI_BidFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_BidColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Bid field.
	''' </summary>
	Public Sub SetWCDI_BidFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_BidColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Award field.
	''' </summary>
	Public Function GetWCDI_AwardValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_AwardColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Award field.
	''' </summary>
	Public Function GetWCDI_AwardFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_AwardColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Award field.
	''' </summary>
	Public Sub SetWCDI_AwardFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_AwardColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Award field.
	''' </summary>
	Public Sub SetWCDI_AwardFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_AwardColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Award field.
	''' </summary>
	Public Sub SetWCDI_AwardFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_AwardColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WPRL_WPRD_ID field.
	''' </summary>
	Public Function GetWPRL_WPRD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_WPRD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WPRL_WPRD_ID field.
	''' </summary>
	Public Function GetWPRL_WPRD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRL_WPRD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRL_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRL_WPRD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRL_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRL_WPRD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRL_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRL_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRL_WPRD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRL_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRL_WPRD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRL_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRL_WPRD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_WPRD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Item field.
	''' </summary>
	Public Function GetItemValue() As ColumnValue
		Return Me.GetValue(TableUtils.ItemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Item field.
	''' </summary>
	Public Function GetItemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ItemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Item field.
	''' </summary>
	Public Sub SetItemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Item field.
	''' </summary>
	Public Sub SetItemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ItemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.ItemDescription field.
	''' </summary>
	Public Function GetItemDescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.ItemDescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.ItemDescription field.
	''' </summary>
	Public Function GetItemDescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ItemDescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.ItemDescription field.
	''' </summary>
	Public Sub SetItemDescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ItemDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.ItemDescription field.
	''' </summary>
	Public Sub SetItemDescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ItemDescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.UnitOfMeasure field.
	''' </summary>
	Public Function GetUnitOfMeasureValue() As ColumnValue
		Return Me.GetValue(TableUtils.UnitOfMeasureColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.UnitOfMeasure field.
	''' </summary>
	Public Function GetUnitOfMeasureFieldValue() As String
		Return CType(Me.GetValue(TableUtils.UnitOfMeasureColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.UnitOfMeasure field.
	''' </summary>
	Public Sub SetUnitOfMeasureFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UnitOfMeasureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.UnitOfMeasure field.
	''' </summary>
	Public Sub SetUnitOfMeasureFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UnitOfMeasureColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Site field.
	''' </summary>
	Public Function GetSite0Value() As ColumnValue
		Return Me.GetValue(TableUtils.Site0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Site field.
	''' </summary>
	Public Function GetSite0FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Site0Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Site field.
	''' </summary>
	Public Sub SetSite0FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Site0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Site field.
	''' </summary>
	Public Sub SetSite0FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Site0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.UnitPrice field.
	''' </summary>
	Public Function GetUnitPriceValue() As ColumnValue
		Return Me.GetValue(TableUtils.UnitPriceColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.UnitPrice field.
	''' </summary>
	Public Function GetUnitPriceFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.UnitPriceColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.UnitPrice field.
	''' </summary>
	Public Sub SetUnitPriceFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UnitPriceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.UnitPrice field.
	''' </summary>
	Public Sub SetUnitPriceFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UnitPriceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.UnitPrice field.
	''' </summary>
	Public Sub SetUnitPriceFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UnitPriceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.UnitPrice field.
	''' </summary>
	Public Sub SetUnitPriceFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UnitPriceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.UnitPrice field.
	''' </summary>
	Public Sub SetUnitPriceFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UnitPriceColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WPRL_Qty field.
	''' </summary>
	Public Function GetWPRL_QtyValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_QtyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WPRL_Qty field.
	''' </summary>
	Public Function GetWPRL_QtyFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WPRL_QtyColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRL_Qty field.
	''' </summary>
	Public Sub SetWPRL_QtyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRL_Qty field.
	''' </summary>
	Public Sub SetWPRL_QtyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRL_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRL_Qty field.
	''' </summary>
	Public Sub SetWPRL_QtyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRL_Qty field.
	''' </summary>
	Public Sub SetWPRL_QtyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRL_Qty field.
	''' </summary>
	Public Sub SetWPRL_QtyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_QtyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WPRL_Ext_Price field.
	''' </summary>
	Public Function GetWPRL_Ext_PriceValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_Ext_PriceColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WPRL_Ext_Price field.
	''' </summary>
	Public Function GetWPRL_Ext_PriceFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WPRL_Ext_PriceColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRL_Ext_Price field.
	''' </summary>
	Public Sub SetWPRL_Ext_PriceFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_Ext_PriceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRL_Ext_Price field.
	''' </summary>
	Public Sub SetWPRL_Ext_PriceFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRL_Ext_PriceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRL_Ext_Price field.
	''' </summary>
	Public Sub SetWPRL_Ext_PriceFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_Ext_PriceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRL_Ext_Price field.
	''' </summary>
	Public Sub SetWPRL_Ext_PriceFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_Ext_PriceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRL_Ext_Price field.
	''' </summary>
	Public Sub SetWPRL_Ext_PriceFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_Ext_PriceColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_C_ID field.
	''' </summary>
	Public Function GetWCI_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_C_ID field.
	''' </summary>
	Public Function GetWCI_C_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCI_C_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_C_ID field.
	''' </summary>
	Public Sub SetWCI_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_C_ID field.
	''' </summary>
	Public Sub SetWCI_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCI_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_C_ID field.
	''' </summary>
	Public Sub SetWCI_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_C_ID field.
	''' </summary>
	Public Sub SetWCI_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_C_ID field.
	''' </summary>
	Public Sub SetWCI_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_Status field.
	''' </summary>
	Public Function GetWCI_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_Status field.
	''' </summary>
	Public Function GetWCI_StatusFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCI_StatusColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_Status field.
	''' </summary>
	Public Sub SetWCI_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_Status field.
	''' </summary>
	Public Sub SetWCI_StatusFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_U_ID field.
	''' </summary>
	Public Function GetWCI_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_U_ID field.
	''' </summary>
	Public Function GetWCI_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCI_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_U_ID field.
	''' </summary>
	Public Sub SetWCI_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_U_ID field.
	''' </summary>
	Public Sub SetWCI_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCI_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_U_ID field.
	''' </summary>
	Public Sub SetWCI_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_U_ID field.
	''' </summary>
	Public Sub SetWCI_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_U_ID field.
	''' </summary>
	Public Sub SetWCI_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_WClass_ID field.
	''' </summary>
	Public Function GetWCI_WClass_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_WClass_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_WClass_ID field.
	''' </summary>
	Public Function GetWCI_WClass_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCI_WClass_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_WClass_ID field.
	''' </summary>
	Public Sub SetWCI_WClass_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_WClass_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_WClass_ID field.
	''' </summary>
	Public Sub SetWCI_WClass_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCI_WClass_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_WClass_ID field.
	''' </summary>
	Public Sub SetWCI_WClass_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_WClass_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_WClass_ID field.
	''' </summary>
	Public Sub SetWCI_WClass_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_WClass_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_WClass_ID field.
	''' </summary>
	Public Sub SetWCI_WClass_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_WClass_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WPRD_Created field.
	''' </summary>
	Public Function GetWPRD_CreatedValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_CreatedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WPRD_Created field.
	''' </summary>
	Public Function GetWPRD_CreatedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WPRD_CreatedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRD_Created field.
	''' </summary>
	Public Sub SetWPRD_CreatedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_CreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRD_Created field.
	''' </summary>
	Public Sub SetWPRD_CreatedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRD_CreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRD_Created field.
	''' </summary>
	Public Sub SetWPRD_CreatedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_CreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_Date field.
	''' </summary>
	Public Function GetWCI_DateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_DateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_Date field.
	''' </summary>
	Public Function GetWCI_DateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WCI_DateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_Date field.
	''' </summary>
	Public Sub SetWCI_DateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_Date field.
	''' </summary>
	Public Sub SetWCI_DateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCI_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_Date field.
	''' </summary>
	Public Sub SetWCI_DateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Offered_Qty field.
	''' </summary>
	Public Function GetOffered_QtyValue() As ColumnValue
		Return Me.GetValue(TableUtils.Offered_QtyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Offered_Qty field.
	''' </summary>
	Public Function GetOffered_QtyFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.Offered_QtyColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Offered_Qty field.
	''' </summary>
	Public Sub SetOffered_QtyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Offered_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Offered_Qty field.
	''' </summary>
	Public Sub SetOffered_QtyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Offered_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Offered_Qty field.
	''' </summary>
	Public Sub SetOffered_QtyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Offered_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Offered_Qty field.
	''' </summary>
	Public Sub SetOffered_QtyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Offered_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Offered_Qty field.
	''' </summary>
	Public Sub SetOffered_QtyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Offered_QtyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Balance_Qty field.
	''' </summary>
	Public Function GetBalance_QtyValue() As ColumnValue
		Return Me.GetValue(TableUtils.Balance_QtyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Balance_Qty field.
	''' </summary>
	Public Function GetBalance_QtyFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.Balance_QtyColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Balance_Qty field.
	''' </summary>
	Public Sub SetBalance_QtyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Balance_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Balance_Qty field.
	''' </summary>
	Public Sub SetBalance_QtyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Balance_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Balance_Qty field.
	''' </summary>
	Public Sub SetBalance_QtyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Balance_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Balance_Qty field.
	''' </summary>
	Public Sub SetBalance_QtyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Balance_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Balance_Qty field.
	''' </summary>
	Public Sub SetBalance_QtyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Balance_QtyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Vat field.
	''' </summary>
	Public Function GetWCDI_VatValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_VatColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Vat field.
	''' </summary>
	Public Function GetWCDI_VatFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCDI_VatColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Vat field.
	''' </summary>
	Public Sub SetWCDI_VatFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_VatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Vat field.
	''' </summary>
	Public Sub SetWCDI_VatFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_VatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Vat field.
	''' </summary>
	Public Sub SetWCDI_VatFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_VatColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Net field.
	''' </summary>
	Public Function GetWCDI_NetValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_NetColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Net field.
	''' </summary>
	Public Function GetWCDI_NetFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCDI_NetColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Net field.
	''' </summary>
	Public Sub SetWCDI_NetFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_NetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Net field.
	''' </summary>
	Public Sub SetWCDI_NetFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_NetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Net field.
	''' </summary>
	Public Sub SetWCDI_NetFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_NetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Net field.
	''' </summary>
	Public Sub SetWCDI_NetFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_NetColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_Net field.
	''' </summary>
	Public Sub SetWCDI_NetFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_NetColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_WCur_ID field.
	''' </summary>
	Public Function GetWCDI_WCur_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDI_WCur_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_WCur_ID field.
	''' </summary>
	Public Function GetWCDI_WCur_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCDI_WCur_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_WCur_ID field.
	''' </summary>
	Public Sub SetWCDI_WCur_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDI_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_WCur_ID field.
	''' </summary>
	Public Sub SetWCDI_WCur_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDI_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_WCur_ID field.
	''' </summary>
	Public Sub SetWCDI_WCur_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_WCur_ID field.
	''' </summary>
	Public Sub SetWCDI_WCur_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCDI_WCur_ID field.
	''' </summary>
	Public Sub SetWCDI_WCur_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDI_WCur_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WPRD_Contract field.
	''' </summary>
	Public Function GetWPRD_ContractValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_ContractColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WPRD_Contract field.
	''' </summary>
	Public Function GetWPRD_ContractFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WPRD_ContractColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRD_Contract field.
	''' </summary>
	Public Sub SetWPRD_ContractFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_ContractColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRD_Contract field.
	''' </summary>
	Public Sub SetWPRD_ContractFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRD_ContractColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WPRD_Contract field.
	''' </summary>
	Public Sub SetWPRD_ContractFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_ContractColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_Done field.
	''' </summary>
	Public Function GetWCI_Contract_DoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_Contract_DoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_Done field.
	''' </summary>
	Public Function GetWCI_Contract_DoneFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCI_Contract_DoneColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_Done field.
	''' </summary>
	Public Sub SetWCI_Contract_DoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_Contract_DoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_Done field.
	''' </summary>
	Public Sub SetWCI_Contract_DoneFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCI_Contract_DoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_Done field.
	''' </summary>
	Public Sub SetWCI_Contract_DoneFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_Contract_DoneColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_Closed field.
	''' </summary>
	Public Function GetWCI_Contract_ClosedValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_Contract_ClosedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_Closed field.
	''' </summary>
	Public Function GetWCI_Contract_ClosedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WCI_Contract_ClosedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_Closed field.
	''' </summary>
	Public Sub SetWCI_Contract_ClosedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_Contract_ClosedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_Closed field.
	''' </summary>
	Public Sub SetWCI_Contract_ClosedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCI_Contract_ClosedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_Closed field.
	''' </summary>
	Public Sub SetWCI_Contract_ClosedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_Contract_ClosedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_U_ID field.
	''' </summary>
	Public Function GetWCI_Contract_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_Contract_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_U_ID field.
	''' </summary>
	Public Function GetWCI_Contract_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCI_Contract_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_U_ID field.
	''' </summary>
	Public Sub SetWCI_Contract_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_Contract_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_U_ID field.
	''' </summary>
	Public Sub SetWCI_Contract_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCI_Contract_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_U_ID field.
	''' </summary>
	Public Sub SetWCI_Contract_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_Contract_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_U_ID field.
	''' </summary>
	Public Sub SetWCI_Contract_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_Contract_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_U_ID field.
	''' </summary>
	Public Sub SetWCI_Contract_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_Contract_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Col_Marker field.
	''' </summary>
	Public Function GetCol_MarkerValue() As ColumnValue
		Return Me.GetValue(TableUtils.Col_MarkerColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Col_Marker field.
	''' </summary>
	Public Function GetCol_MarkerFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.Col_MarkerColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Col_Marker field.
	''' </summary>
	Public Sub SetCol_MarkerFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Col_MarkerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Col_Marker field.
	''' </summary>
	Public Sub SetCol_MarkerFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Col_MarkerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Col_Marker field.
	''' </summary>
	Public Sub SetCol_MarkerFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Col_MarkerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Col_Marker field.
	''' </summary>
	Public Sub SetCol_MarkerFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Col_MarkerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Col_Marker field.
	''' </summary>
	Public Sub SetCol_MarkerFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Col_MarkerColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Status field.
	''' </summary>
	Public Function GetStatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Status field.
	''' </summary>
	Public Function GetStatusFieldValue() As String
		Return CType(Me.GetValue(TableUtils.StatusColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Status field.
	''' </summary>
	Public Sub SetStatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_PO_Map_Temp_.Status field.
	''' </summary>
	Public Sub SetStatusFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StatusColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Temp_ID field.
	''' </summary>
	Public Property Temp_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.Temp_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Temp_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Temp_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Temp_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Temp_IDDefault() As String
        Get
            Return TableUtils.Temp_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_ID field.
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
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_WCI_ID field.
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
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_WPRL_ID field.
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
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Status field.
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
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Audit_Comment field.
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
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Comment field.
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
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_PM00200_Vendor field.
	''' </summary>
	Public Property WCDI_PM00200_Vendor() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_PM00200_VendorColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCDI_PM00200_VendorColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_PM00200_VendorSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_PM00200_VendorColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_PM00200_VendorDefault() As String
        Get
            Return TableUtils.WCDI_PM00200_VendorColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Qty field.
	''' </summary>
	Public Property WCDI_Qty() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_QtyColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_QtyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_QtySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_QtyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_QtyDefault() As String
        Get
            Return TableUtils.WCDI_QtyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Bid field.
	''' </summary>
	Public Property WCDI_Bid() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_BidColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_BidColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_BidSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_BidColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_BidDefault() As String
        Get
            Return TableUtils.WCDI_BidColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Award field.
	''' </summary>
	Public Property WCDI_Award() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_AwardColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_AwardColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_AwardSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_AwardColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_AwardDefault() As String
        Get
            Return TableUtils.WCDI_AwardColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WPRL_WPRD_ID field.
	''' </summary>
	Public Property WPRL_WPRD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_WPRD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRL_WPRD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_WPRD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_WPRD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_WPRD_IDDefault() As String
        Get
            Return TableUtils.WPRL_WPRD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Item field.
	''' </summary>
	Public Property Item() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ItemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ItemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ItemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ItemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ItemDefault() As String
        Get
            Return TableUtils.ItemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.ItemDescription field.
	''' </summary>
	Public Property ItemDescription() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ItemDescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ItemDescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ItemDescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ItemDescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ItemDescriptionDefault() As String
        Get
            Return TableUtils.ItemDescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.UnitOfMeasure field.
	''' </summary>
	Public Property UnitOfMeasure() As String
		Get 
			Return CType(Me.GetValue(TableUtils.UnitOfMeasureColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.UnitOfMeasureColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UnitOfMeasureSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UnitOfMeasureColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UnitOfMeasureDefault() As String
        Get
            Return TableUtils.UnitOfMeasureColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Site field.
	''' </summary>
	Public Property Site0() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Site0Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Site0Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Site0Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Site0Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Site0Default() As String
        Get
            Return TableUtils.Site0Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.UnitPrice field.
	''' </summary>
	Public Property UnitPrice() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.UnitPriceColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.UnitPriceColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UnitPriceSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UnitPriceColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UnitPriceDefault() As String
        Get
            Return TableUtils.UnitPriceColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WPRL_Qty field.
	''' </summary>
	Public Property WPRL_Qty() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_QtyColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRL_QtyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_QtySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_QtyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_QtyDefault() As String
        Get
            Return TableUtils.WPRL_QtyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WPRL_Ext_Price field.
	''' </summary>
	Public Property WPRL_Ext_Price() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_Ext_PriceColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRL_Ext_PriceColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_Ext_PriceSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_Ext_PriceColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_Ext_PriceDefault() As String
        Get
            Return TableUtils.WPRL_Ext_PriceColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_C_ID field.
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
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_Status field.
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
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_U_ID field.
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
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_WClass_ID field.
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
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WPRD_Created field.
	''' </summary>
	Public Property WPRD_Created() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_CreatedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRD_CreatedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_CreatedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_CreatedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_CreatedDefault() As String
        Get
            Return TableUtils.WPRD_CreatedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_Date field.
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
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Offered_Qty field.
	''' </summary>
	Public Property Offered_Qty() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.Offered_QtyColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Offered_QtyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Offered_QtySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Offered_QtyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Offered_QtyDefault() As String
        Get
            Return TableUtils.Offered_QtyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Balance_Qty field.
	''' </summary>
	Public Property Balance_Qty() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.Balance_QtyColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Balance_QtyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Balance_QtySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Balance_QtyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Balance_QtyDefault() As String
        Get
            Return TableUtils.Balance_QtyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Vat field.
	''' </summary>
	Public Property WCDI_Vat() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_VatColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_VatColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_VatSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_VatColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_VatDefault() As String
        Get
            Return TableUtils.WCDI_VatColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_Net field.
	''' </summary>
	Public Property WCDI_Net() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_NetColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_NetColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_NetSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_NetColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_NetDefault() As String
        Get
            Return TableUtils.WCDI_NetColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCDI_WCur_ID field.
	''' </summary>
	Public Property WCDI_WCur_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCDI_WCur_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDI_WCur_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDI_WCur_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDI_WCur_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDI_WCur_IDDefault() As String
        Get
            Return TableUtils.WCDI_WCur_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WPRD_Contract field.
	''' </summary>
	Public Property WPRD_Contract() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_ContractColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRD_ContractColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_ContractSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_ContractColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_ContractDefault() As String
        Get
            Return TableUtils.WPRD_ContractColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_Done field.
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
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_Closed field.
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
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.WCI_Contract_U_ID field.
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Col_Marker field.
	''' </summary>
	Public Property Col_Marker() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.Col_MarkerColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Col_MarkerColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Col_MarkerSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Col_MarkerColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Col_MarkerDefault() As String
        Get
            Return TableUtils.Col_MarkerColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_PO_Map_Temp_.Status field.
	''' </summary>
	Public Property Status() As String
		Get 
			Return CType(Me.GetValue(TableUtils.StatusColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property StatusDefault() As String
        Get
            Return TableUtils.StatusColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
