' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WCAR_Doc_Related_Supplemental1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_WCAR_Doc_Related_Supplemental1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WCAR_Doc_Related_Supplemental1View"></see> class.
''' </remarks>
''' <seealso cref="Sel_WCAR_Doc_Related_Supplemental1View"></seealso>
''' <seealso cref="Sel_WCAR_Doc_Related_Supplemental1Record"></seealso>

<Serializable()> Public Class BaseSel_WCAR_Doc_Related_Supplemental1Record
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_WCAR_Doc_Related_Supplemental1View = Sel_WCAR_Doc_Related_Supplemental1View.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_WCAR_Doc_Related_Supplemental1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_WCAR_Doc_Related_Supplemental1Rec As Sel_WCAR_Doc_Related_Supplemental1Record = CType(sender,Sel_WCAR_Doc_Related_Supplemental1Record)
        If Not Sel_WCAR_Doc_Related_Supplemental1Rec Is Nothing AndAlso Not Sel_WCAR_Doc_Related_Supplemental1Rec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_WCAR_Doc_Related_Supplemental1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_WCAR_Doc_Related_Supplemental1Rec As Sel_WCAR_Doc_Related_Supplemental1Record = CType(sender,Sel_WCAR_Doc_Related_Supplemental1Record)
        Validate_Inserting()
        If Not Sel_WCAR_Doc_Related_Supplemental1Rec Is Nothing AndAlso Not Sel_WCAR_Doc_Related_Supplemental1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_ID field.
	''' </summary>
	Public Function GetWCD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_ID field.
	''' </summary>
	Public Function GetWCD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_ID field.
	''' </summary>
	Public Sub SetWCD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_ID field.
	''' </summary>
	Public Sub SetWCD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_ID field.
	''' </summary>
	Public Sub SetWCD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_ID field.
	''' </summary>
	Public Sub SetWCD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_ID field.
	''' </summary>
	Public Sub SetWCD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.Src_CAR field.
	''' </summary>
	Public Function GetSrc_CARValue() As ColumnValue
		Return Me.GetValue(TableUtils.Src_CARColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.Src_CAR field.
	''' </summary>
	Public Function GetSrc_CARFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.Src_CARColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.Src_CAR field.
	''' </summary>
	Public Sub SetSrc_CARFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Src_CARColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.Src_CAR field.
	''' </summary>
	Public Sub SetSrc_CARFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Src_CARColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.Src_CAR field.
	''' </summary>
	Public Sub SetSrc_CARFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Src_CARColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.Src_CAR field.
	''' </summary>
	Public Sub SetSrc_CARFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Src_CARColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.Src_CAR field.
	''' </summary>
	Public Sub SetSrc_CARFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Src_CARColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Supplementary field.
	''' </summary>
	Public Function GetWCD_SupplementaryValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_SupplementaryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Supplementary field.
	''' </summary>
	Public Function GetWCD_SupplementaryFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCD_SupplementaryColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Supplementary field.
	''' </summary>
	Public Sub SetWCD_SupplementaryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_SupplementaryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Supplementary field.
	''' </summary>
	Public Sub SetWCD_SupplementaryFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_SupplementaryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Supplementary field.
	''' </summary>
	Public Sub SetWCD_SupplementaryFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_SupplementaryColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_No field.
	''' </summary>
	Public Function GetWCD_NoValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_NoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_No field.
	''' </summary>
	Public Function GetWCD_NoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCD_NoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_No field.
	''' </summary>
	Public Sub SetWCD_NoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_No field.
	''' </summary>
	Public Sub SetWCD_NoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Project_Title field.
	''' </summary>
	Public Function GetWCD_Project_TitleValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Project_TitleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Project_Title field.
	''' </summary>
	Public Function GetWCD_Project_TitleFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCD_Project_TitleColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Project_Title field.
	''' </summary>
	Public Sub SetWCD_Project_TitleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Project_TitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Project_Title field.
	''' </summary>
	Public Sub SetWCD_Project_TitleFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Project_TitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Request_Date field.
	''' </summary>
	Public Function GetWCD_Request_DateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Request_DateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Request_Date field.
	''' </summary>
	Public Function GetWCD_Request_DateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WCD_Request_DateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Request_Date field.
	''' </summary>
	Public Sub SetWCD_Request_DateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Request_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Request_Date field.
	''' </summary>
	Public Sub SetWCD_Request_DateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_Request_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Request_Date field.
	''' </summary>
	Public Sub SetWCD_Request_DateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Request_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Exp_Total field.
	''' </summary>
	Public Function GetWCD_Exp_TotalValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Exp_TotalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Exp_Total field.
	''' </summary>
	Public Function GetWCD_Exp_TotalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCD_Exp_TotalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Exp_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_Exp_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_TotalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_CAR field.
	''' </summary>
	Public Function GetRel_CARValue() As ColumnValue
		Return Me.GetValue(TableUtils.Rel_CARColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_CAR field.
	''' </summary>
	Public Function GetRel_CARFieldValue() As String
		Return CType(Me.GetValue(TableUtils.Rel_CARColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_CAR field.
	''' </summary>
	Public Sub SetRel_CARFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Rel_CARColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_CAR field.
	''' </summary>
	Public Sub SetRel_CARFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Rel_CARColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_Proj field.
	''' </summary>
	Public Function GetRel_ProjValue() As ColumnValue
		Return Me.GetValue(TableUtils.Rel_ProjColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_Proj field.
	''' </summary>
	Public Function GetRel_ProjFieldValue() As String
		Return CType(Me.GetValue(TableUtils.Rel_ProjColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_Proj field.
	''' </summary>
	Public Sub SetRel_ProjFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Rel_ProjColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_Proj field.
	''' </summary>
	Public Sub SetRel_ProjFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Rel_ProjColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_Req_Date field.
	''' </summary>
	Public Function GetRel_Req_DateValue() As ColumnValue
		Return Me.GetValue(TableUtils.Rel_Req_DateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_Req_Date field.
	''' </summary>
	Public Function GetRel_Req_DateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.Rel_Req_DateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_Req_Date field.
	''' </summary>
	Public Sub SetRel_Req_DateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Rel_Req_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_Req_Date field.
	''' </summary>
	Public Sub SetRel_Req_DateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Rel_Req_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_Req_Date field.
	''' </summary>
	Public Sub SetRel_Req_DateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Rel_Req_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_Total field.
	''' </summary>
	Public Function GetRel_TotalValue() As ColumnValue
		Return Me.GetValue(TableUtils.Rel_TotalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_Total field.
	''' </summary>
	Public Function GetRel_TotalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.Rel_TotalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_Total field.
	''' </summary>
	Public Sub SetRel_TotalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Rel_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_Total field.
	''' </summary>
	Public Sub SetRel_TotalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Rel_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_Total field.
	''' </summary>
	Public Sub SetRel_TotalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Rel_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_Total field.
	''' </summary>
	Public Sub SetRel_TotalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Rel_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_Total field.
	''' </summary>
	Public Sub SetRel_TotalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Rel_TotalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_C_ID field.
	''' </summary>
	Public Function GetWCD_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_C_ID field.
	''' </summary>
	Public Function GetWCD_C_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCD_C_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_C_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_ID field.
	''' </summary>
	Public Property WCD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_IDDefault() As String
        Get
            Return TableUtils.WCD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.Src_CAR field.
	''' </summary>
	Public Property Src_CAR() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.Src_CARColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Src_CARColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Src_CARSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Src_CARColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Src_CARDefault() As String
        Get
            Return TableUtils.Src_CARColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Supplementary field.
	''' </summary>
	Public Property WCD_Supplementary() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_SupplementaryColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_SupplementaryColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_SupplementarySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_SupplementaryColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_SupplementaryDefault() As String
        Get
            Return TableUtils.WCD_SupplementaryColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_No field.
	''' </summary>
	Public Property WCD_No() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_NoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCD_NoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_NoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_NoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_NoDefault() As String
        Get
            Return TableUtils.WCD_NoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Project_Title field.
	''' </summary>
	Public Property WCD_Project_Title() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Project_TitleColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCD_Project_TitleColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Project_TitleSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Project_TitleColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Project_TitleDefault() As String
        Get
            Return TableUtils.WCD_Project_TitleColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Request_Date field.
	''' </summary>
	Public Property WCD_Request_Date() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Request_DateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_Request_DateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Request_DateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Request_DateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Request_DateDefault() As String
        Get
            Return TableUtils.WCD_Request_DateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_Exp_Total field.
	''' </summary>
	Public Property WCD_Exp_Total() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Exp_TotalColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_Exp_TotalColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Exp_TotalSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Exp_TotalColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Exp_TotalDefault() As String
        Get
            Return TableUtils.WCD_Exp_TotalColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_CAR field.
	''' </summary>
	Public Property Rel_CAR() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Rel_CARColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Rel_CARColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Rel_CARSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Rel_CARColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Rel_CARDefault() As String
        Get
            Return TableUtils.Rel_CARColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_Proj field.
	''' </summary>
	Public Property Rel_Proj() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Rel_ProjColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Rel_ProjColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Rel_ProjSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Rel_ProjColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Rel_ProjDefault() As String
        Get
            Return TableUtils.Rel_ProjColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_Req_Date field.
	''' </summary>
	Public Property Rel_Req_Date() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.Rel_Req_DateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Rel_Req_DateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Rel_Req_DateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Rel_Req_DateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Rel_Req_DateDefault() As String
        Get
            Return TableUtils.Rel_Req_DateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.Rel_Total field.
	''' </summary>
	Public Property Rel_Total() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.Rel_TotalColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Rel_TotalColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Rel_TotalSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Rel_TotalColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Rel_TotalDefault() As String
        Get
            Return TableUtils.Rel_TotalColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Doc_Related_Supplemental_.WCD_C_ID field.
	''' </summary>
	Public Property WCD_C_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_C_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_C_IDDefault() As String
        Get
            Return TableUtils.WCD_C_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
