' This class is "generated" and will be overwritten.
' Your customizations should be made in WPR_Doc1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WPR_Doc1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WPR_Doc1Table"></see> class.
''' </remarks>
''' <seealso cref="WPR_Doc1Table"></seealso>
''' <seealso cref="WPR_Doc1Record"></seealso>

<Serializable()> Public Class BaseWPR_Doc1Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WPR_Doc1Table = WPR_Doc1Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WPR_Doc1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WPR_Doc1Rec As WPR_Doc1Record = CType(sender,WPR_Doc1Record)
        Validate_Inserting()
        If Not WPR_Doc1Rec Is Nothing AndAlso Not WPR_Doc1Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WPR_Doc1Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WPR_Doc1Rec As WPR_Doc1Record = CType(sender,WPR_Doc1Record)
        Validate_Updating()
        If Not WPR_Doc1Rec Is Nothing AndAlso Not WPR_Doc1Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WPR_Doc1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WPR_Doc1Rec As WPR_Doc1Record = CType(sender,WPR_Doc1Record)
        If Not WPR_Doc1Rec Is Nothing AndAlso Not WPR_Doc1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_ID field.
	''' </summary>
	Public Function GetWPRD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_ID field.
	''' </summary>
	Public Function GetWPRD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_C_ID field.
	''' </summary>
	Public Function GetWPRD_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_C_ID field.
	''' </summary>
	Public Function GetWPRD_C_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WPRD_C_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_C_ID field.
	''' </summary>
	Public Sub SetWPRD_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_C_ID field.
	''' </summary>
	Public Sub SetWPRD_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_C_ID field.
	''' </summary>
	Public Sub SetWPRD_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_C_ID field.
	''' </summary>
	Public Sub SetWPRD_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_C_ID field.
	''' </summary>
	Public Sub SetWPRD_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_WDT_ID field.
	''' </summary>
	Public Function GetWPRD_WDT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_WDT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_WDT_ID field.
	''' </summary>
	Public Function GetWPRD_WDT_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRD_WDT_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WDT_ID field.
	''' </summary>
	Public Sub SetWPRD_WDT_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WDT_ID field.
	''' </summary>
	Public Sub SetWPRD_WDT_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRD_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WDT_ID field.
	''' </summary>
	Public Sub SetWPRD_WDT_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WDT_ID field.
	''' </summary>
	Public Sub SetWPRD_WDT_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WDT_ID field.
	''' </summary>
	Public Sub SetWPRD_WDT_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_WDT_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_WCD_ID field.
	''' </summary>
	Public Function GetWPRD_WCD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_WCD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_WCD_ID field.
	''' </summary>
	Public Function GetWPRD_WCD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRD_WCD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WCD_ID field.
	''' </summary>
	Public Sub SetWPRD_WCD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WCD_ID field.
	''' </summary>
	Public Sub SetWPRD_WCD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRD_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WCD_ID field.
	''' </summary>
	Public Sub SetWPRD_WCD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WCD_ID field.
	''' </summary>
	Public Sub SetWPRD_WCD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WCD_ID field.
	''' </summary>
	Public Sub SetWPRD_WCD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_WCD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_WCur_ID field.
	''' </summary>
	Public Function GetWPRD_WCur_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_WCur_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_WCur_ID field.
	''' </summary>
	Public Function GetWPRD_WCur_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WPRD_WCur_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WCur_ID field.
	''' </summary>
	Public Sub SetWPRD_WCur_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WCur_ID field.
	''' </summary>
	Public Sub SetWPRD_WCur_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRD_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WCur_ID field.
	''' </summary>
	Public Sub SetWPRD_WCur_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WCur_ID field.
	''' </summary>
	Public Sub SetWPRD_WCur_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WCur_ID field.
	''' </summary>
	Public Sub SetWPRD_WCur_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_WCur_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_U_ID field.
	''' </summary>
	Public Function GetWPRD_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_U_ID field.
	''' </summary>
	Public Function GetWPRD_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRD_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_U_ID field.
	''' </summary>
	Public Sub SetWPRD_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_U_ID field.
	''' </summary>
	Public Sub SetWPRD_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRD_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_U_ID field.
	''' </summary>
	Public Sub SetWPRD_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_U_ID field.
	''' </summary>
	Public Sub SetWPRD_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_U_ID field.
	''' </summary>
	Public Sub SetWPRD_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_U_ID_Modify field.
	''' </summary>
	Public Function GetWPRD_U_ID_ModifyValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_U_ID_ModifyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_U_ID_Modify field.
	''' </summary>
	Public Function GetWPRD_U_ID_ModifyFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRD_U_ID_ModifyColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_U_ID_Modify field.
	''' </summary>
	Public Sub SetWPRD_U_ID_ModifyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_U_ID_ModifyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_U_ID_Modify field.
	''' </summary>
	Public Sub SetWPRD_U_ID_ModifyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRD_U_ID_ModifyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_U_ID_Modify field.
	''' </summary>
	Public Sub SetWPRD_U_ID_ModifyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_U_ID_ModifyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_U_ID_Modify field.
	''' </summary>
	Public Sub SetWPRD_U_ID_ModifyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_U_ID_ModifyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_U_ID_Modify field.
	''' </summary>
	Public Sub SetWPRD_U_ID_ModifyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_U_ID_ModifyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_No field.
	''' </summary>
	Public Function GetWPRD_NoValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_NoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_No field.
	''' </summary>
	Public Function GetWPRD_NoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRD_NoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_No field.
	''' </summary>
	Public Sub SetWPRD_NoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_No field.
	''' </summary>
	Public Sub SetWPRD_NoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_Created field.
	''' </summary>
	Public Function GetWPRD_CreatedValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_CreatedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_Created field.
	''' </summary>
	Public Function GetWPRD_CreatedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WPRD_CreatedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Created field.
	''' </summary>
	Public Sub SetWPRD_CreatedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_CreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Created field.
	''' </summary>
	Public Sub SetWPRD_CreatedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRD_CreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Created field.
	''' </summary>
	Public Sub SetWPRD_CreatedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_CreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_Modified field.
	''' </summary>
	Public Function GetWPRD_ModifiedValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_ModifiedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_Modified field.
	''' </summary>
	Public Function GetWPRD_ModifiedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WPRD_ModifiedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Modified field.
	''' </summary>
	Public Sub SetWPRD_ModifiedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_ModifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Modified field.
	''' </summary>
	Public Sub SetWPRD_ModifiedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRD_ModifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Modified field.
	''' </summary>
	Public Sub SetWPRD_ModifiedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_ModifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_Total field.
	''' </summary>
	Public Function GetWPRD_TotalValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_TotalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_Total field.
	''' </summary>
	Public Function GetWPRD_TotalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WPRD_TotalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Total field.
	''' </summary>
	Public Sub SetWPRD_TotalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Total field.
	''' </summary>
	Public Sub SetWPRD_TotalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRD_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Total field.
	''' </summary>
	Public Sub SetWPRD_TotalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Total field.
	''' </summary>
	Public Sub SetWPRD_TotalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Total field.
	''' </summary>
	Public Sub SetWPRD_TotalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_TotalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_Comment field.
	''' </summary>
	Public Function GetWPRD_CommentValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_CommentColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_Comment field.
	''' </summary>
	Public Function GetWPRD_CommentFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRD_CommentColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Comment field.
	''' </summary>
	Public Sub SetWPRD_CommentFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_CommentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Comment field.
	''' </summary>
	Public Sub SetWPRD_CommentFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_CommentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_WPRDS_ID field.
	''' </summary>
	Public Function GetWPRD_WPRDS_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_WPRDS_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_WPRDS_ID field.
	''' </summary>
	Public Function GetWPRD_WPRDS_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WPRD_WPRDS_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WPRDS_ID field.
	''' </summary>
	Public Sub SetWPRD_WPRDS_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_WPRDS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WPRDS_ID field.
	''' </summary>
	Public Sub SetWPRD_WPRDS_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRD_WPRDS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WPRDS_ID field.
	''' </summary>
	Public Sub SetWPRD_WPRDS_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_WPRDS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WPRDS_ID field.
	''' </summary>
	Public Sub SetWPRD_WPRDS_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_WPRDS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_WPRDS_ID field.
	''' </summary>
	Public Sub SetWPRD_WPRDS_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_WPRDS_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_Submit field.
	''' </summary>
	Public Function GetWPRD_SubmitValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_SubmitColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_Submit field.
	''' </summary>
	Public Function GetWPRD_SubmitFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WPRD_SubmitColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Submit field.
	''' </summary>
	Public Sub SetWPRD_SubmitFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_SubmitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Submit field.
	''' </summary>
	Public Sub SetWPRD_SubmitFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRD_SubmitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Submit field.
	''' </summary>
	Public Sub SetWPRD_SubmitFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_SubmitColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_Title field.
	''' </summary>
	Public Function GetWPRD_TitleValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_TitleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_Title field.
	''' </summary>
	Public Function GetWPRD_TitleFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRD_TitleColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Title field.
	''' </summary>
	Public Sub SetWPRD_TitleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_TitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Title field.
	''' </summary>
	Public Sub SetWPRD_TitleFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_TitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_Contract field.
	''' </summary>
	Public Function GetWPRD_ContractValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_ContractColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_.WPRD_Contract field.
	''' </summary>
	Public Function GetWPRD_ContractFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WPRD_ContractColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Contract field.
	''' </summary>
	Public Sub SetWPRD_ContractFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_ContractColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Contract field.
	''' </summary>
	Public Sub SetWPRD_ContractFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRD_ContractColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_.WPRD_Contract field.
	''' </summary>
	Public Sub SetWPRD_ContractFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_ContractColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_.WPRD_ID field.
	''' </summary>
	Public Property WPRD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_IDDefault() As String
        Get
            Return TableUtils.WPRD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_.WPRD_C_ID field.
	''' </summary>
	Public Property WPRD_C_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_C_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRD_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_C_IDDefault() As String
        Get
            Return TableUtils.WPRD_C_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_.WPRD_WDT_ID field.
	''' </summary>
	Public Property WPRD_WDT_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_WDT_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRD_WDT_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_WDT_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_WDT_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_WDT_IDDefault() As String
        Get
            Return TableUtils.WPRD_WDT_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_.WPRD_WCD_ID field.
	''' </summary>
	Public Property WPRD_WCD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_WCD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRD_WCD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_WCD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_WCD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_WCD_IDDefault() As String
        Get
            Return TableUtils.WPRD_WCD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_.WPRD_WCur_ID field.
	''' </summary>
	Public Property WPRD_WCur_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_WCur_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRD_WCur_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_WCur_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_WCur_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_WCur_IDDefault() As String
        Get
            Return TableUtils.WPRD_WCur_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_.WPRD_U_ID field.
	''' </summary>
	Public Property WPRD_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRD_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_U_IDDefault() As String
        Get
            Return TableUtils.WPRD_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_.WPRD_U_ID_Modify field.
	''' </summary>
	Public Property WPRD_U_ID_Modify() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_U_ID_ModifyColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRD_U_ID_ModifyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_U_ID_ModifySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_U_ID_ModifyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_U_ID_ModifyDefault() As String
        Get
            Return TableUtils.WPRD_U_ID_ModifyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_.WPRD_No field.
	''' </summary>
	Public Property WPRD_No() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_NoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRD_NoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_NoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_NoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_NoDefault() As String
        Get
            Return TableUtils.WPRD_NoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_.WPRD_Created field.
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
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_.WPRD_Modified field.
	''' </summary>
	Public Property WPRD_Modified() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_ModifiedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRD_ModifiedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_ModifiedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_ModifiedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_ModifiedDefault() As String
        Get
            Return TableUtils.WPRD_ModifiedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_.WPRD_Total field.
	''' </summary>
	Public Property WPRD_Total() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_TotalColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRD_TotalColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_TotalSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_TotalColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_TotalDefault() As String
        Get
            Return TableUtils.WPRD_TotalColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_.WPRD_Comment field.
	''' </summary>
	Public Property WPRD_Comment() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_CommentColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRD_CommentColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_CommentSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_CommentColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_CommentDefault() As String
        Get
            Return TableUtils.WPRD_CommentColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_.WPRD_WPRDS_ID field.
	''' </summary>
	Public Property WPRD_WPRDS_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_WPRDS_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRD_WPRDS_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_WPRDS_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_WPRDS_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_WPRDS_IDDefault() As String
        Get
            Return TableUtils.WPRD_WPRDS_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_.WPRD_Submit field.
	''' </summary>
	Public Property WPRD_Submit() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_SubmitColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRD_SubmitColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_SubmitSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_SubmitColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_SubmitDefault() As String
        Get
            Return TableUtils.WPRD_SubmitColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_.WPRD_Title field.
	''' </summary>
	Public Property WPRD_Title() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_TitleColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRD_TitleColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_TitleSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_TitleColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_TitleDefault() As String
        Get
            Return TableUtils.WPRD_TitleColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_.WPRD_Contract field.
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



#End Region

End Class
End Namespace
