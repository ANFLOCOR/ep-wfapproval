' This class is "generated" and will be overwritten.
' Your customizations should be made in WPR_LineRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WPR_LineRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WPR_LineTable"></see> class.
''' </remarks>
''' <seealso cref="WPR_LineTable"></seealso>
''' <seealso cref="WPR_LineRecord"></seealso>

<Serializable()> Public Class BaseWPR_LineRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WPR_LineTable = WPR_LineTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WPR_LineRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WPR_LineRec As WPR_LineRecord = CType(sender,WPR_LineRecord)
        Validate_Inserting()
        If Not WPR_LineRec Is Nothing AndAlso Not WPR_LineRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WPR_LineRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WPR_LineRec As WPR_LineRecord = CType(sender,WPR_LineRecord)
        Validate_Updating()
        If Not WPR_LineRec Is Nothing AndAlso Not WPR_LineRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WPR_LineRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WPR_LineRec As WPR_LineRecord = CType(sender,WPR_LineRecord)
        If Not WPR_LineRec Is Nothing AndAlso Not WPR_LineRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_ID field.
	''' </summary>
	Public Function GetWPRL_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_ID field.
	''' </summary>
	Public Function GetWPRL_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRL_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_WPRD_ID field.
	''' </summary>
	Public Function GetWPRL_WPRD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_WPRD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_WPRD_ID field.
	''' </summary>
	Public Function GetWPRL_WPRD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRL_WPRD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRL_WPRD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRL_WPRD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRL_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRL_WPRD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRL_WPRD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRL_WPRD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_WPRD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_IV00101_Item_No field.
	''' </summary>
	Public Function GetWPRL_IV00101_Item_NoValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_IV00101_Item_NoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_IV00101_Item_No field.
	''' </summary>
	Public Function GetWPRL_IV00101_Item_NoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRL_IV00101_Item_NoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_IV00101_Item_No field.
	''' </summary>
	Public Sub SetWPRL_IV00101_Item_NoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_IV00101_Item_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_IV00101_Item_No field.
	''' </summary>
	Public Sub SetWPRL_IV00101_Item_NoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_IV00101_Item_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_IV40700_Locn_Code field.
	''' </summary>
	Public Function GetWPRL_IV40700_Locn_CodeValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_IV40700_Locn_CodeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_IV40700_Locn_Code field.
	''' </summary>
	Public Function GetWPRL_IV40700_Locn_CodeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRL_IV40700_Locn_CodeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_IV40700_Locn_Code field.
	''' </summary>
	Public Sub SetWPRL_IV40700_Locn_CodeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_IV40700_Locn_CodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_IV40700_Locn_Code field.
	''' </summary>
	Public Sub SetWPRL_IV40700_Locn_CodeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_IV40700_Locn_CodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_PM00200_Vendor_ID field.
	''' </summary>
	Public Function GetWPRL_PM00200_Vendor_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_PM00200_Vendor_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_PM00200_Vendor_ID field.
	''' </summary>
	Public Function GetWPRL_PM00200_Vendor_IDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRL_PM00200_Vendor_IDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_PM00200_Vendor_ID field.
	''' </summary>
	Public Sub SetWPRL_PM00200_Vendor_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_PM00200_Vendor_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_PM00200_Vendor_ID field.
	''' </summary>
	Public Sub SetWPRL_PM00200_Vendor_IDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_PM00200_Vendor_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_GL00101_Acct_Indx field.
	''' </summary>
	Public Function GetWPRL_GL00101_Acct_IndxValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_GL00101_Acct_IndxColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_GL00101_Acct_Indx field.
	''' </summary>
	Public Function GetWPRL_GL00101_Acct_IndxFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRL_GL00101_Acct_IndxColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_GL00101_Acct_Indx field.
	''' </summary>
	Public Sub SetWPRL_GL00101_Acct_IndxFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_GL00101_Acct_IndxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_GL00101_Acct_Indx field.
	''' </summary>
	Public Sub SetWPRL_GL00101_Acct_IndxFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRL_GL00101_Acct_IndxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_GL00101_Acct_Indx field.
	''' </summary>
	Public Sub SetWPRL_GL00101_Acct_IndxFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_GL00101_Acct_IndxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_GL00101_Acct_Indx field.
	''' </summary>
	Public Sub SetWPRL_GL00101_Acct_IndxFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_GL00101_Acct_IndxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_GL00101_Acct_Indx field.
	''' </summary>
	Public Sub SetWPRL_GL00101_Acct_IndxFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_GL00101_Acct_IndxColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_IV00101_Prchs_UOM field.
	''' </summary>
	Public Function GetWPRL_IV00101_Prchs_UOMValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_IV00101_Prchs_UOMColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_IV00101_Prchs_UOM field.
	''' </summary>
	Public Function GetWPRL_IV00101_Prchs_UOMFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRL_IV00101_Prchs_UOMColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_IV00101_Prchs_UOM field.
	''' </summary>
	Public Sub SetWPRL_IV00101_Prchs_UOMFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_IV00101_Prchs_UOMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_IV00101_Prchs_UOM field.
	''' </summary>
	Public Sub SetWPRL_IV00101_Prchs_UOMFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_IV00101_Prchs_UOMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Line_Seq_No field.
	''' </summary>
	Public Function GetWPRL_Line_Seq_NoValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_Line_Seq_NoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Line_Seq_No field.
	''' </summary>
	Public Function GetWPRL_Line_Seq_NoFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRL_Line_Seq_NoColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Line_Seq_No field.
	''' </summary>
	Public Sub SetWPRL_Line_Seq_NoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_Line_Seq_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Line_Seq_No field.
	''' </summary>
	Public Sub SetWPRL_Line_Seq_NoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRL_Line_Seq_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Line_Seq_No field.
	''' </summary>
	Public Sub SetWPRL_Line_Seq_NoFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_Line_Seq_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Line_Seq_No field.
	''' </summary>
	Public Sub SetWPRL_Line_Seq_NoFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_Line_Seq_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Line_Seq_No field.
	''' </summary>
	Public Sub SetWPRL_Line_Seq_NoFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_Line_Seq_NoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Item_Comment field.
	''' </summary>
	Public Function GetWPRL_Item_CommentValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_Item_CommentColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Item_Comment field.
	''' </summary>
	Public Function GetWPRL_Item_CommentFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRL_Item_CommentColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Item_Comment field.
	''' </summary>
	Public Sub SetWPRL_Item_CommentFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_Item_CommentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Item_Comment field.
	''' </summary>
	Public Sub SetWPRL_Item_CommentFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_Item_CommentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Item_Text field.
	''' </summary>
	Public Function GetWPRL_Item_TextValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_Item_TextColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Item_Text field.
	''' </summary>
	Public Function GetWPRL_Item_TextFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRL_Item_TextColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Item_Text field.
	''' </summary>
	Public Sub SetWPRL_Item_TextFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_Item_TextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Item_Text field.
	''' </summary>
	Public Sub SetWPRL_Item_TextFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_Item_TextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Item_Desc field.
	''' </summary>
	Public Function GetWPRL_Item_DescValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_Item_DescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Item_Desc field.
	''' </summary>
	Public Function GetWPRL_Item_DescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRL_Item_DescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Item_Desc field.
	''' </summary>
	Public Sub SetWPRL_Item_DescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_Item_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Item_Desc field.
	''' </summary>
	Public Sub SetWPRL_Item_DescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_Item_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Item_Non_Inv field.
	''' </summary>
	Public Function GetWPRL_Item_Non_InvValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_Item_Non_InvColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Item_Non_Inv field.
	''' </summary>
	Public Function GetWPRL_Item_Non_InvFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRL_Item_Non_InvColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Item_Non_Inv field.
	''' </summary>
	Public Sub SetWPRL_Item_Non_InvFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_Item_Non_InvColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Item_Non_Inv field.
	''' </summary>
	Public Sub SetWPRL_Item_Non_InvFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_Item_Non_InvColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Required_Date field.
	''' </summary>
	Public Function GetWPRL_Required_DateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_Required_DateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Required_Date field.
	''' </summary>
	Public Function GetWPRL_Required_DateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WPRL_Required_DateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Required_Date field.
	''' </summary>
	Public Sub SetWPRL_Required_DateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_Required_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Required_Date field.
	''' </summary>
	Public Sub SetWPRL_Required_DateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRL_Required_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Required_Date field.
	''' </summary>
	Public Sub SetWPRL_Required_DateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_Required_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Unit_Price field.
	''' </summary>
	Public Function GetWPRL_Unit_PriceValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_Unit_PriceColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Unit_Price field.
	''' </summary>
	Public Function GetWPRL_Unit_PriceFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WPRL_Unit_PriceColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Unit_Price field.
	''' </summary>
	Public Sub SetWPRL_Unit_PriceFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_Unit_PriceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Unit_Price field.
	''' </summary>
	Public Sub SetWPRL_Unit_PriceFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRL_Unit_PriceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Unit_Price field.
	''' </summary>
	Public Sub SetWPRL_Unit_PriceFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_Unit_PriceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Unit_Price field.
	''' </summary>
	Public Sub SetWPRL_Unit_PriceFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_Unit_PriceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Unit_Price field.
	''' </summary>
	Public Sub SetWPRL_Unit_PriceFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_Unit_PriceColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Qty field.
	''' </summary>
	Public Function GetWPRL_QtyValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_QtyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Qty field.
	''' </summary>
	Public Function GetWPRL_QtyFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WPRL_QtyColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Qty field.
	''' </summary>
	Public Sub SetWPRL_QtyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Qty field.
	''' </summary>
	Public Sub SetWPRL_QtyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRL_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Qty field.
	''' </summary>
	Public Sub SetWPRL_QtyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Qty field.
	''' </summary>
	Public Sub SetWPRL_QtyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Qty field.
	''' </summary>
	Public Sub SetWPRL_QtyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_QtyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Ext_Price field.
	''' </summary>
	Public Function GetWPRL_Ext_PriceValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_Ext_PriceColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Ext_Price field.
	''' </summary>
	Public Function GetWPRL_Ext_PriceFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WPRL_Ext_PriceColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Ext_Price field.
	''' </summary>
	Public Sub SetWPRL_Ext_PriceFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_Ext_PriceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Ext_Price field.
	''' </summary>
	Public Sub SetWPRL_Ext_PriceFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRL_Ext_PriceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Ext_Price field.
	''' </summary>
	Public Sub SetWPRL_Ext_PriceFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_Ext_PriceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Ext_Price field.
	''' </summary>
	Public Sub SetWPRL_Ext_PriceFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_Ext_PriceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Ext_Price field.
	''' </summary>
	Public Sub SetWPRL_Ext_PriceFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_Ext_PriceColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_WPRLS_ID field.
	''' </summary>
	Public Function GetWPRL_WPRLS_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_WPRLS_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_WPRLS_ID field.
	''' </summary>
	Public Function GetWPRL_WPRLS_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WPRL_WPRLS_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_WPRLS_ID field.
	''' </summary>
	Public Sub SetWPRL_WPRLS_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_WPRLS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_WPRLS_ID field.
	''' </summary>
	Public Sub SetWPRL_WPRLS_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRL_WPRLS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_WPRLS_ID field.
	''' </summary>
	Public Sub SetWPRL_WPRLS_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_WPRLS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_WPRLS_ID field.
	''' </summary>
	Public Sub SetWPRL_WPRLS_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_WPRLS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_WPRLS_ID field.
	''' </summary>
	Public Sub SetWPRL_WPRLS_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_WPRLS_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_PO_No field.
	''' </summary>
	Public Function GetWPRL_PO_NoValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_PO_NoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_PO_No field.
	''' </summary>
	Public Function GetWPRL_PO_NoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRL_PO_NoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_PO_No field.
	''' </summary>
	Public Sub SetWPRL_PO_NoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_PO_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_PO_No field.
	''' </summary>
	Public Sub SetWPRL_PO_NoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_PO_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_PO_Line_Seq_No field.
	''' </summary>
	Public Function GetWPRL_PO_Line_Seq_NoValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_PO_Line_Seq_NoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_PO_Line_Seq_No field.
	''' </summary>
	Public Function GetWPRL_PO_Line_Seq_NoFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRL_PO_Line_Seq_NoColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_PO_Line_Seq_No field.
	''' </summary>
	Public Sub SetWPRL_PO_Line_Seq_NoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_PO_Line_Seq_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_PO_Line_Seq_No field.
	''' </summary>
	Public Sub SetWPRL_PO_Line_Seq_NoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRL_PO_Line_Seq_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_PO_Line_Seq_No field.
	''' </summary>
	Public Sub SetWPRL_PO_Line_Seq_NoFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_PO_Line_Seq_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_PO_Line_Seq_No field.
	''' </summary>
	Public Sub SetWPRL_PO_Line_Seq_NoFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_PO_Line_Seq_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_PO_Line_Seq_No field.
	''' </summary>
	Public Sub SetWPRL_PO_Line_Seq_NoFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_PO_Line_Seq_NoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Item_Non_Inv_UOM field.
	''' </summary>
	Public Function GetWPRL_Item_Non_Inv_UOMValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_Item_Non_Inv_UOMColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Item_Non_Inv_UOM field.
	''' </summary>
	Public Function GetWPRL_Item_Non_Inv_UOMFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRL_Item_Non_Inv_UOMColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Item_Non_Inv_UOM field.
	''' </summary>
	Public Sub SetWPRL_Item_Non_Inv_UOMFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_Item_Non_Inv_UOMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Item_Non_Inv_UOM field.
	''' </summary>
	Public Sub SetWPRL_Item_Non_Inv_UOMFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_Item_Non_Inv_UOMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Vendor_Name field.
	''' </summary>
	Public Function GetWPRL_Vendor_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_Vendor_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Vendor_Name field.
	''' </summary>
	Public Function GetWPRL_Vendor_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRL_Vendor_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Vendor_Name field.
	''' </summary>
	Public Sub SetWPRL_Vendor_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_Vendor_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Vendor_Name field.
	''' </summary>
	Public Sub SetWPRL_Vendor_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_Vendor_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Account field.
	''' </summary>
	Public Function GetWPRL_AccountValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_AccountColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_Account field.
	''' </summary>
	Public Function GetWPRL_AccountFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRL_AccountColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Account field.
	''' </summary>
	Public Sub SetWPRL_AccountFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_AccountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_Account field.
	''' </summary>
	Public Sub SetWPRL_AccountFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_AccountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_WClass_ID field.
	''' </summary>
	Public Function GetWPRL_WClass_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRL_WClass_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Line_.WPRL_WClass_ID field.
	''' </summary>
	Public Function GetWPRL_WClass_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRL_WClass_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_WClass_ID field.
	''' </summary>
	Public Sub SetWPRL_WClass_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRL_WClass_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_WClass_ID field.
	''' </summary>
	Public Sub SetWPRL_WClass_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRL_WClass_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_WClass_ID field.
	''' </summary>
	Public Sub SetWPRL_WClass_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_WClass_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_WClass_ID field.
	''' </summary>
	Public Sub SetWPRL_WClass_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_WClass_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Line_.WPRL_WClass_ID field.
	''' </summary>
	Public Sub SetWPRL_WClass_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRL_WClass_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_ID field.
	''' </summary>
	Public Property WPRL_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRL_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_IDDefault() As String
        Get
            Return TableUtils.WPRL_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_WPRD_ID field.
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
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_IV00101_Item_No field.
	''' </summary>
	Public Property WPRL_IV00101_Item_No() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_IV00101_Item_NoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRL_IV00101_Item_NoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_IV00101_Item_NoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_IV00101_Item_NoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_IV00101_Item_NoDefault() As String
        Get
            Return TableUtils.WPRL_IV00101_Item_NoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_IV40700_Locn_Code field.
	''' </summary>
	Public Property WPRL_IV40700_Locn_Code() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_IV40700_Locn_CodeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRL_IV40700_Locn_CodeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_IV40700_Locn_CodeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_IV40700_Locn_CodeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_IV40700_Locn_CodeDefault() As String
        Get
            Return TableUtils.WPRL_IV40700_Locn_CodeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_PM00200_Vendor_ID field.
	''' </summary>
	Public Property WPRL_PM00200_Vendor_ID() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_PM00200_Vendor_IDColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRL_PM00200_Vendor_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_PM00200_Vendor_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_PM00200_Vendor_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_PM00200_Vendor_IDDefault() As String
        Get
            Return TableUtils.WPRL_PM00200_Vendor_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_GL00101_Acct_Indx field.
	''' </summary>
	Public Property WPRL_GL00101_Acct_Indx() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_GL00101_Acct_IndxColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRL_GL00101_Acct_IndxColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_GL00101_Acct_IndxSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_GL00101_Acct_IndxColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_GL00101_Acct_IndxDefault() As String
        Get
            Return TableUtils.WPRL_GL00101_Acct_IndxColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_IV00101_Prchs_UOM field.
	''' </summary>
	Public Property WPRL_IV00101_Prchs_UOM() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_IV00101_Prchs_UOMColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRL_IV00101_Prchs_UOMColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_IV00101_Prchs_UOMSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_IV00101_Prchs_UOMColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_IV00101_Prchs_UOMDefault() As String
        Get
            Return TableUtils.WPRL_IV00101_Prchs_UOMColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_Line_Seq_No field.
	''' </summary>
	Public Property WPRL_Line_Seq_No() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_Line_Seq_NoColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRL_Line_Seq_NoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_Line_Seq_NoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_Line_Seq_NoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_Line_Seq_NoDefault() As String
        Get
            Return TableUtils.WPRL_Line_Seq_NoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_Item_Comment field.
	''' </summary>
	Public Property WPRL_Item_Comment() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_Item_CommentColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRL_Item_CommentColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_Item_CommentSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_Item_CommentColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_Item_CommentDefault() As String
        Get
            Return TableUtils.WPRL_Item_CommentColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_Item_Text field.
	''' </summary>
	Public Property WPRL_Item_Text() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_Item_TextColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRL_Item_TextColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_Item_TextSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_Item_TextColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_Item_TextDefault() As String
        Get
            Return TableUtils.WPRL_Item_TextColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_Item_Desc field.
	''' </summary>
	Public Property WPRL_Item_Desc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_Item_DescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRL_Item_DescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_Item_DescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_Item_DescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_Item_DescDefault() As String
        Get
            Return TableUtils.WPRL_Item_DescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_Item_Non_Inv field.
	''' </summary>
	Public Property WPRL_Item_Non_Inv() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_Item_Non_InvColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRL_Item_Non_InvColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_Item_Non_InvSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_Item_Non_InvColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_Item_Non_InvDefault() As String
        Get
            Return TableUtils.WPRL_Item_Non_InvColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_Required_Date field.
	''' </summary>
	Public Property WPRL_Required_Date() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_Required_DateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRL_Required_DateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_Required_DateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_Required_DateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_Required_DateDefault() As String
        Get
            Return TableUtils.WPRL_Required_DateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_Unit_Price field.
	''' </summary>
	Public Property WPRL_Unit_Price() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_Unit_PriceColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRL_Unit_PriceColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_Unit_PriceSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_Unit_PriceColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_Unit_PriceDefault() As String
        Get
            Return TableUtils.WPRL_Unit_PriceColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_Qty field.
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
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_Ext_Price field.
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
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_WPRLS_ID field.
	''' </summary>
	Public Property WPRL_WPRLS_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_WPRLS_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRL_WPRLS_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_WPRLS_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_WPRLS_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_WPRLS_IDDefault() As String
        Get
            Return TableUtils.WPRL_WPRLS_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_PO_No field.
	''' </summary>
	Public Property WPRL_PO_No() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_PO_NoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRL_PO_NoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_PO_NoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_PO_NoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_PO_NoDefault() As String
        Get
            Return TableUtils.WPRL_PO_NoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_PO_Line_Seq_No field.
	''' </summary>
	Public Property WPRL_PO_Line_Seq_No() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_PO_Line_Seq_NoColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRL_PO_Line_Seq_NoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_PO_Line_Seq_NoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_PO_Line_Seq_NoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_PO_Line_Seq_NoDefault() As String
        Get
            Return TableUtils.WPRL_PO_Line_Seq_NoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_Item_Non_Inv_UOM field.
	''' </summary>
	Public Property WPRL_Item_Non_Inv_UOM() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_Item_Non_Inv_UOMColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRL_Item_Non_Inv_UOMColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_Item_Non_Inv_UOMSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_Item_Non_Inv_UOMColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_Item_Non_Inv_UOMDefault() As String
        Get
            Return TableUtils.WPRL_Item_Non_Inv_UOMColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_Vendor_Name field.
	''' </summary>
	Public Property WPRL_Vendor_Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_Vendor_NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRL_Vendor_NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_Vendor_NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_Vendor_NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_Vendor_NameDefault() As String
        Get
            Return TableUtils.WPRL_Vendor_NameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_Account field.
	''' </summary>
	Public Property WPRL_Account() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_AccountColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRL_AccountColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_AccountSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_AccountColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_AccountDefault() As String
        Get
            Return TableUtils.WPRL_AccountColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Line_.WPRL_WClass_ID field.
	''' </summary>
	Public Property WPRL_WClass_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRL_WClass_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRL_WClass_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRL_WClass_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRL_WClass_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRL_WClass_IDDefault() As String
        Get
            Return TableUtils.WPRL_WClass_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
