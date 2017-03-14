' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WPO_InquireDetails1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_WPO_InquireDetails1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WPO_InquireDetails1View"></see> class.
''' </remarks>
''' <seealso cref="Sel_WPO_InquireDetails1View"></seealso>
''' <seealso cref="Sel_WPO_InquireDetails1Record"></seealso>

<Serializable()> Public Class BaseSel_WPO_InquireDetails1Record
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_WPO_InquireDetails1View = Sel_WPO_InquireDetails1View.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_WPO_InquireDetails1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_WPO_InquireDetails1Rec As Sel_WPO_InquireDetails1Record = CType(sender,Sel_WPO_InquireDetails1Record)
        If Not Sel_WPO_InquireDetails1Rec Is Nothing AndAlso Not Sel_WPO_InquireDetails1Rec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_WPO_InquireDetails1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_WPO_InquireDetails1Rec As Sel_WPO_InquireDetails1Record = CType(sender,Sel_WPO_InquireDetails1Record)
        Validate_Inserting()
        If Not Sel_WPO_InquireDetails1Rec Is Nothing AndAlso Not Sel_WPO_InquireDetails1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CompanyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.PONUMBER field.
	''' </summary>
	Public Function GetPONUMBERValue() As ColumnValue
		Return Me.GetValue(TableUtils.PONUMBERColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.PONUMBER field.
	''' </summary>
	Public Function GetPONUMBERFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PONUMBERColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.PONUMBER field.
	''' </summary>
	Public Sub SetPONUMBERFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PONUMBERColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.PONUMBER field.
	''' </summary>
	Public Sub SetPONUMBERFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PONUMBERColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.LineNumber field.
	''' </summary>
	Public Function GetLineNumberValue() As ColumnValue
		Return Me.GetValue(TableUtils.LineNumberColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.LineNumber field.
	''' </summary>
	Public Function GetLineNumberFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.LineNumberColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.LineNumber field.
	''' </summary>
	Public Sub SetLineNumberFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LineNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.LineNumber field.
	''' </summary>
	Public Sub SetLineNumberFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LineNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.LineNumber field.
	''' </summary>
	Public Sub SetLineNumberFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LineNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.LineNumber field.
	''' </summary>
	Public Sub SetLineNumberFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LineNumberColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.LineNumber field.
	''' </summary>
	Public Sub SetLineNumberFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LineNumberColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.ITEMNMBR field.
	''' </summary>
	Public Function GetITEMNMBRValue() As ColumnValue
		Return Me.GetValue(TableUtils.ITEMNMBRColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.ITEMNMBR field.
	''' </summary>
	Public Function GetITEMNMBRFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ITEMNMBRColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.ITEMNMBR field.
	''' </summary>
	Public Sub SetITEMNMBRFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ITEMNMBRColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.ITEMNMBR field.
	''' </summary>
	Public Sub SetITEMNMBRFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ITEMNMBRColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.ITEMDESC field.
	''' </summary>
	Public Function GetITEMDESCValue() As ColumnValue
		Return Me.GetValue(TableUtils.ITEMDESCColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.ITEMDESC field.
	''' </summary>
	Public Function GetITEMDESCFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ITEMDESCColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.ITEMDESC field.
	''' </summary>
	Public Sub SetITEMDESCFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ITEMDESCColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.ITEMDESC field.
	''' </summary>
	Public Sub SetITEMDESCFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ITEMDESCColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.UOFM field.
	''' </summary>
	Public Function GetUOFMValue() As ColumnValue
		Return Me.GetValue(TableUtils.UOFMColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.UOFM field.
	''' </summary>
	Public Function GetUOFMFieldValue() As String
		Return CType(Me.GetValue(TableUtils.UOFMColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.UOFM field.
	''' </summary>
	Public Sub SetUOFMFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UOFMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.UOFM field.
	''' </summary>
	Public Sub SetUOFMFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UOFMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.UNITCOST field.
	''' </summary>
	Public Function GetUNITCOSTValue() As ColumnValue
		Return Me.GetValue(TableUtils.UNITCOSTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.UNITCOST field.
	''' </summary>
	Public Function GetUNITCOSTFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.UNITCOSTColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.UNITCOST field.
	''' </summary>
	Public Sub SetUNITCOSTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UNITCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.UNITCOST field.
	''' </summary>
	Public Sub SetUNITCOSTFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UNITCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.UNITCOST field.
	''' </summary>
	Public Sub SetUNITCOSTFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UNITCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.UNITCOST field.
	''' </summary>
	Public Sub SetUNITCOSTFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UNITCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.UNITCOST field.
	''' </summary>
	Public Sub SetUNITCOSTFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UNITCOSTColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.QTYORDER field.
	''' </summary>
	Public Function GetQTYORDERValue() As ColumnValue
		Return Me.GetValue(TableUtils.QTYORDERColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.QTYORDER field.
	''' </summary>
	Public Function GetQTYORDERFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.QTYORDERColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.QTYORDER field.
	''' </summary>
	Public Sub SetQTYORDERFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.QTYORDERColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.QTYORDER field.
	''' </summary>
	Public Sub SetQTYORDERFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.QTYORDERColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.QTYORDER field.
	''' </summary>
	Public Sub SetQTYORDERFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.QTYORDERColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.QTYORDER field.
	''' </summary>
	Public Sub SetQTYORDERFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.QTYORDERColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.QTYORDER field.
	''' </summary>
	Public Sub SetQTYORDERFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.QTYORDERColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.EXTDCOST field.
	''' </summary>
	Public Function GetEXTDCOSTValue() As ColumnValue
		Return Me.GetValue(TableUtils.EXTDCOSTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.EXTDCOST field.
	''' </summary>
	Public Function GetEXTDCOSTFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.EXTDCOSTColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.EXTDCOST field.
	''' </summary>
	Public Sub SetEXTDCOSTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EXTDCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.EXTDCOST field.
	''' </summary>
	Public Sub SetEXTDCOSTFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EXTDCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.EXTDCOST field.
	''' </summary>
	Public Sub SetEXTDCOSTFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EXTDCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.EXTDCOST field.
	''' </summary>
	Public Sub SetEXTDCOSTFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EXTDCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.EXTDCOST field.
	''' </summary>
	Public Sub SetEXTDCOSTFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EXTDCOSTColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.DOCDATE field.
	''' </summary>
	Public Function GetDOCDATEValue() As ColumnValue
		Return Me.GetValue(TableUtils.DOCDATEColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.DOCDATE field.
	''' </summary>
	Public Function GetDOCDATEFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.DOCDATEColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.DOCDATE field.
	''' </summary>
	Public Sub SetDOCDATEFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DOCDATEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.DOCDATE field.
	''' </summary>
	Public Sub SetDOCDATEFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DOCDATEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.DOCDATE field.
	''' </summary>
	Public Sub SetDOCDATEFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DOCDATEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.REQSTDBY field.
	''' </summary>
	Public Function GetREQSTDBYValue() As ColumnValue
		Return Me.GetValue(TableUtils.REQSTDBYColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.REQSTDBY field.
	''' </summary>
	Public Function GetREQSTDBYFieldValue() As String
		Return CType(Me.GetValue(TableUtils.REQSTDBYColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.REQSTDBY field.
	''' </summary>
	Public Sub SetREQSTDBYFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.REQSTDBYColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.REQSTDBY field.
	''' </summary>
	Public Sub SetREQSTDBYFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.REQSTDBYColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.ORD field.
	''' </summary>
	Public Function GetORDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ORDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.ORD field.
	''' </summary>
	Public Function GetORDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ORDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.ORD field.
	''' </summary>
	Public Sub SetORDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ORDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.ORD field.
	''' </summary>
	Public Sub SetORDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ORDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.ORD field.
	''' </summary>
	Public Sub SetORDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ORDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.ORD field.
	''' </summary>
	Public Sub SetORDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ORDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.ORD field.
	''' </summary>
	Public Sub SetORDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ORDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.COMMENTS field.
	''' </summary>
	Public Function GetCOMMENTSValue() As ColumnValue
		Return Me.GetValue(TableUtils.COMMENTSColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.COMMENTS field.
	''' </summary>
	Public Function GetCOMMENTSFieldValue() As String
		Return CType(Me.GetValue(TableUtils.COMMENTSColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.COMMENTS field.
	''' </summary>
	Public Sub SetCOMMENTSFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.COMMENTSColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.COMMENTS field.
	''' </summary>
	Public Sub SetCOMMENTSFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.COMMENTSColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.COMMENT_4 field.
	''' </summary>
	Public Function GetCOMMENT_4Value() As ColumnValue
		Return Me.GetValue(TableUtils.COMMENT_4Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.COMMENT_4 field.
	''' </summary>
	Public Function GetCOMMENT_4FieldValue() As String
		Return CType(Me.GetValue(TableUtils.COMMENT_4Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.COMMENT_4 field.
	''' </summary>
	Public Sub SetCOMMENT_4FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.COMMENT_4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.COMMENT_4 field.
	''' </summary>
	Public Sub SetCOMMENT_4FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.COMMENT_4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.VENDORID field.
	''' </summary>
	Public Function GetVENDORIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.VENDORIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.VENDORID field.
	''' </summary>
	Public Function GetVENDORIDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.VENDORIDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.VENDORID field.
	''' </summary>
	Public Sub SetVENDORIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.VENDORIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.VENDORID field.
	''' </summary>
	Public Sub SetVENDORIDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VENDORIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.VENDNAME field.
	''' </summary>
	Public Function GetVENDNAMEValue() As ColumnValue
		Return Me.GetValue(TableUtils.VENDNAMEColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.VENDNAME field.
	''' </summary>
	Public Function GetVENDNAMEFieldValue() As String
		Return CType(Me.GetValue(TableUtils.VENDNAMEColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.VENDNAME field.
	''' </summary>
	Public Sub SetVENDNAMEFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.VENDNAMEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.VENDNAME field.
	''' </summary>
	Public Sub SetVENDNAMEFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VENDNAMEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.WPOFR_Rate field.
	''' </summary>
	Public Function GetWPOFR_RateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPOFR_RateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.WPOFR_Rate field.
	''' </summary>
	Public Function GetWPOFR_RateFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WPOFR_RateColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.WPOFR_Rate field.
	''' </summary>
	Public Sub SetWPOFR_RateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPOFR_RateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.WPOFR_Rate field.
	''' </summary>
	Public Sub SetWPOFR_RateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPOFR_RateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.WPOFR_Rate field.
	''' </summary>
	Public Sub SetWPOFR_RateFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOFR_RateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.WPOFR_Rate field.
	''' </summary>
	Public Sub SetWPOFR_RateFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOFR_RateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.WPOFR_Rate field.
	''' </summary>
	Public Sub SetWPOFR_RateFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOFR_RateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.WPOFR_Unit_Cost field.
	''' </summary>
	Public Function GetWPOFR_Unit_CostValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPOFR_Unit_CostColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.WPOFR_Unit_Cost field.
	''' </summary>
	Public Function GetWPOFR_Unit_CostFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WPOFR_Unit_CostColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.WPOFR_Unit_Cost field.
	''' </summary>
	Public Sub SetWPOFR_Unit_CostFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPOFR_Unit_CostColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.WPOFR_Unit_Cost field.
	''' </summary>
	Public Sub SetWPOFR_Unit_CostFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPOFR_Unit_CostColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.WPOFR_Unit_Cost field.
	''' </summary>
	Public Sub SetWPOFR_Unit_CostFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOFR_Unit_CostColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.WPOFR_Unit_Cost field.
	''' </summary>
	Public Sub SetWPOFR_Unit_CostFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOFR_Unit_CostColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.WPOFR_Unit_Cost field.
	''' </summary>
	Public Sub SetWPOFR_Unit_CostFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOFR_Unit_CostColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.WCur_Short field.
	''' </summary>
	Public Function GetWCur_ShortValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCur_ShortColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.WCur_Short field.
	''' </summary>
	Public Function GetWCur_ShortFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCur_ShortColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.WCur_Short field.
	''' </summary>
	Public Sub SetWCur_ShortFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCur_ShortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.WCur_Short field.
	''' </summary>
	Public Sub SetWCur_ShortFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCur_ShortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.ExtCostForex field.
	''' </summary>
	Public Function GetExtCostForexValue() As ColumnValue
		Return Me.GetValue(TableUtils.ExtCostForexColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_InquireDetails_.ExtCostForex field.
	''' </summary>
	Public Function GetExtCostForexFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.ExtCostForexColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.ExtCostForex field.
	''' </summary>
	Public Sub SetExtCostForexFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ExtCostForexColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.ExtCostForex field.
	''' </summary>
	Public Sub SetExtCostForexFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ExtCostForexColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.ExtCostForex field.
	''' </summary>
	Public Sub SetExtCostForexFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExtCostForexColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.ExtCostForex field.
	''' </summary>
	Public Sub SetExtCostForexFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExtCostForexColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_InquireDetails_.ExtCostForex field.
	''' </summary>
	Public Sub SetExtCostForexFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ExtCostForexColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.CompanyID field.
	''' </summary>
	Public Property CompanyID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CompanyIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CompanyIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CompanyIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CompanyIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CompanyIDDefault() As String
        Get
            Return TableUtils.CompanyIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.PONUMBER field.
	''' </summary>
	Public Property PONUMBER() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PONUMBERColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PONUMBERColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PONUMBERSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PONUMBERColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PONUMBERDefault() As String
        Get
            Return TableUtils.PONUMBERColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.LineNumber field.
	''' </summary>
	Public Property LineNumber() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.LineNumberColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LineNumberColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LineNumberSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LineNumberColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LineNumberDefault() As String
        Get
            Return TableUtils.LineNumberColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.ITEMNMBR field.
	''' </summary>
	Public Property ITEMNMBR() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ITEMNMBRColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ITEMNMBRColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ITEMNMBRSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ITEMNMBRColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ITEMNMBRDefault() As String
        Get
            Return TableUtils.ITEMNMBRColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.ITEMDESC field.
	''' </summary>
	Public Property ITEMDESC() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ITEMDESCColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ITEMDESCColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ITEMDESCSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ITEMDESCColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ITEMDESCDefault() As String
        Get
            Return TableUtils.ITEMDESCColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.UOFM field.
	''' </summary>
	Public Property UOFM() As String
		Get 
			Return CType(Me.GetValue(TableUtils.UOFMColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.UOFMColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UOFMSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UOFMColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UOFMDefault() As String
        Get
            Return TableUtils.UOFMColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.UNITCOST field.
	''' </summary>
	Public Property UNITCOST() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.UNITCOSTColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.UNITCOSTColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UNITCOSTSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UNITCOSTColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UNITCOSTDefault() As String
        Get
            Return TableUtils.UNITCOSTColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.QTYORDER field.
	''' </summary>
	Public Property QTYORDER() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.QTYORDERColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.QTYORDERColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property QTYORDERSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.QTYORDERColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property QTYORDERDefault() As String
        Get
            Return TableUtils.QTYORDERColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.EXTDCOST field.
	''' </summary>
	Public Property EXTDCOST() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.EXTDCOSTColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EXTDCOSTColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EXTDCOSTSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EXTDCOSTColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EXTDCOSTDefault() As String
        Get
            Return TableUtils.EXTDCOSTColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.DOCDATE field.
	''' </summary>
	Public Property DOCDATE() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.DOCDATEColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DOCDATEColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DOCDATESpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DOCDATEColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DOCDATEDefault() As String
        Get
            Return TableUtils.DOCDATEColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.REQSTDBY field.
	''' </summary>
	Public Property REQSTDBY() As String
		Get 
			Return CType(Me.GetValue(TableUtils.REQSTDBYColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.REQSTDBYColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property REQSTDBYSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.REQSTDBYColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property REQSTDBYDefault() As String
        Get
            Return TableUtils.REQSTDBYColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.ORD field.
	''' </summary>
	Public Property ORD() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ORDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ORDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ORDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ORDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ORDDefault() As String
        Get
            Return TableUtils.ORDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.COMMENTS field.
	''' </summary>
	Public Property COMMENTS() As String
		Get 
			Return CType(Me.GetValue(TableUtils.COMMENTSColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.COMMENTSColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property COMMENTSSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.COMMENTSColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property COMMENTSDefault() As String
        Get
            Return TableUtils.COMMENTSColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.COMMENT_4 field.
	''' </summary>
	Public Property COMMENT_4() As String
		Get 
			Return CType(Me.GetValue(TableUtils.COMMENT_4Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.COMMENT_4Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property COMMENT_4Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.COMMENT_4Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property COMMENT_4Default() As String
        Get
            Return TableUtils.COMMENT_4Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.VENDORID field.
	''' </summary>
	Public Property VENDORID() As String
		Get 
			Return CType(Me.GetValue(TableUtils.VENDORIDColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.VENDORIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property VENDORIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.VENDORIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property VENDORIDDefault() As String
        Get
            Return TableUtils.VENDORIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.VENDNAME field.
	''' </summary>
	Public Property VENDNAME() As String
		Get 
			Return CType(Me.GetValue(TableUtils.VENDNAMEColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.VENDNAMEColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property VENDNAMESpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.VENDNAMEColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property VENDNAMEDefault() As String
        Get
            Return TableUtils.VENDNAMEColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.WPOFR_Rate field.
	''' </summary>
	Public Property WPOFR_Rate() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WPOFR_RateColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPOFR_RateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPOFR_RateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPOFR_RateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPOFR_RateDefault() As String
        Get
            Return TableUtils.WPOFR_RateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.WPOFR_Unit_Cost field.
	''' </summary>
	Public Property WPOFR_Unit_Cost() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WPOFR_Unit_CostColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPOFR_Unit_CostColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPOFR_Unit_CostSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPOFR_Unit_CostColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPOFR_Unit_CostDefault() As String
        Get
            Return TableUtils.WPOFR_Unit_CostColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.WCur_Short field.
	''' </summary>
	Public Property WCur_Short() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCur_ShortColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCur_ShortColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCur_ShortSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCur_ShortColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCur_ShortDefault() As String
        Get
            Return TableUtils.WCur_ShortColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_InquireDetails_.ExtCostForex field.
	''' </summary>
	Public Property ExtCostForex() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.ExtCostForexColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ExtCostForexColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ExtCostForexSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ExtCostForexColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ExtCostForexDefault() As String
        Get
            Return TableUtils.ExtCostForexColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
