' This class is "generated" and will be overwritten.
' Your customizations should be made in POP10100_HEADER_ALL2Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="POP10100_HEADER_ALL2Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="POP10100_HEADER_ALL2View"></see> class.
''' </remarks>
''' <seealso cref="POP10100_HEADER_ALL2View"></seealso>
''' <seealso cref="POP10100_HEADER_ALL2Record"></seealso>

<Serializable()> Public Class BasePOP10100_HEADER_ALL2Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As POP10100_HEADER_ALL2View = POP10100_HEADER_ALL2View.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub POP10100_HEADER_ALL2Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim POP10100_HEADER_ALL2Rec As POP10100_HEADER_ALL2Record = CType(sender,POP10100_HEADER_ALL2Record)
        Validate_Inserting()
        If Not POP10100_HEADER_ALL2Rec Is Nothing AndAlso Not POP10100_HEADER_ALL2Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub POP10100_HEADER_ALL2Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim POP10100_HEADER_ALL2Rec As POP10100_HEADER_ALL2Record = CType(sender,POP10100_HEADER_ALL2Record)
        Validate_Updating()
        If Not POP10100_HEADER_ALL2Rec Is Nothing AndAlso Not POP10100_HEADER_ALL2Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub POP10100_HEADER_ALL2Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim POP10100_HEADER_ALL2Rec As POP10100_HEADER_ALL2Record = CType(sender,POP10100_HEADER_ALL2Record)
        If Not POP10100_HEADER_ALL2Rec Is Nothing AndAlso Not POP10100_HEADER_ALL2Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.PONUMBER field.
	''' </summary>
	Public Function GetPONUMBERValue() As ColumnValue
		Return Me.GetValue(TableUtils.PONUMBERColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.PONUMBER field.
	''' </summary>
	Public Function GetPONUMBERFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PONUMBERColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.PONUMBER field.
	''' </summary>
	Public Sub SetPONUMBERFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PONUMBERColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.PONUMBER field.
	''' </summary>
	Public Sub SetPONUMBERFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PONUMBERColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.POSTATUS field.
	''' </summary>
	Public Function GetPOSTATUSValue() As ColumnValue
		Return Me.GetValue(TableUtils.POSTATUSColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.POSTATUS field.
	''' </summary>
	Public Function GetPOSTATUSFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.POSTATUSColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.POSTATUS field.
	''' </summary>
	Public Sub SetPOSTATUSFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.POSTATUSColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.POSTATUS field.
	''' </summary>
	Public Sub SetPOSTATUSFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.POSTATUSColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.POSTATUS field.
	''' </summary>
	Public Sub SetPOSTATUSFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.POSTATUSColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.POSTATUS field.
	''' </summary>
	Public Sub SetPOSTATUSFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.POSTATUSColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.POSTATUS field.
	''' </summary>
	Public Sub SetPOSTATUSFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.POSTATUSColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.DOCDATE field.
	''' </summary>
	Public Function GetDOCDATEValue() As ColumnValue
		Return Me.GetValue(TableUtils.DOCDATEColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.DOCDATE field.
	''' </summary>
	Public Function GetDOCDATEFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.DOCDATEColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.DOCDATE field.
	''' </summary>
	Public Sub SetDOCDATEFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DOCDATEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.DOCDATE field.
	''' </summary>
	Public Sub SetDOCDATEFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DOCDATEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.DOCDATE field.
	''' </summary>
	Public Sub SetDOCDATEFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DOCDATEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.SUBTOTAL field.
	''' </summary>
	Public Function GetSUBTOTALValue() As ColumnValue
		Return Me.GetValue(TableUtils.SUBTOTALColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.SUBTOTAL field.
	''' </summary>
	Public Function GetSUBTOTALFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.SUBTOTALColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.SUBTOTAL field.
	''' </summary>
	Public Sub SetSUBTOTALFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SUBTOTALColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.SUBTOTAL field.
	''' </summary>
	Public Sub SetSUBTOTALFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SUBTOTALColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.SUBTOTAL field.
	''' </summary>
	Public Sub SetSUBTOTALFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SUBTOTALColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.SUBTOTAL field.
	''' </summary>
	Public Sub SetSUBTOTALFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SUBTOTALColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.SUBTOTAL field.
	''' </summary>
	Public Sub SetSUBTOTALFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SUBTOTALColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.TRDISAMT field.
	''' </summary>
	Public Function GetTRDISAMTValue() As ColumnValue
		Return Me.GetValue(TableUtils.TRDISAMTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.TRDISAMT field.
	''' </summary>
	Public Function GetTRDISAMTFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.TRDISAMTColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.TRDISAMT field.
	''' </summary>
	Public Sub SetTRDISAMTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TRDISAMTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.TRDISAMT field.
	''' </summary>
	Public Sub SetTRDISAMTFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TRDISAMTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.TRDISAMT field.
	''' </summary>
	Public Sub SetTRDISAMTFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TRDISAMTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.TRDISAMT field.
	''' </summary>
	Public Sub SetTRDISAMTFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TRDISAMTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.TRDISAMT field.
	''' </summary>
	Public Sub SetTRDISAMTFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TRDISAMTColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.FRTAMNT field.
	''' </summary>
	Public Function GetFRTAMNTValue() As ColumnValue
		Return Me.GetValue(TableUtils.FRTAMNTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.FRTAMNT field.
	''' </summary>
	Public Function GetFRTAMNTFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.FRTAMNTColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.FRTAMNT field.
	''' </summary>
	Public Sub SetFRTAMNTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FRTAMNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.FRTAMNT field.
	''' </summary>
	Public Sub SetFRTAMNTFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FRTAMNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.FRTAMNT field.
	''' </summary>
	Public Sub SetFRTAMNTFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FRTAMNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.FRTAMNT field.
	''' </summary>
	Public Sub SetFRTAMNTFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FRTAMNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.FRTAMNT field.
	''' </summary>
	Public Sub SetFRTAMNTFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FRTAMNTColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.MSCCHAMT field.
	''' </summary>
	Public Function GetMSCCHAMTValue() As ColumnValue
		Return Me.GetValue(TableUtils.MSCCHAMTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.MSCCHAMT field.
	''' </summary>
	Public Function GetMSCCHAMTFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.MSCCHAMTColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.MSCCHAMT field.
	''' </summary>
	Public Sub SetMSCCHAMTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MSCCHAMTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.MSCCHAMT field.
	''' </summary>
	Public Sub SetMSCCHAMTFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MSCCHAMTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.MSCCHAMT field.
	''' </summary>
	Public Sub SetMSCCHAMTFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MSCCHAMTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.MSCCHAMT field.
	''' </summary>
	Public Sub SetMSCCHAMTFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MSCCHAMTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.MSCCHAMT field.
	''' </summary>
	Public Sub SetMSCCHAMTFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MSCCHAMTColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.TAXAMNT field.
	''' </summary>
	Public Function GetTAXAMNTValue() As ColumnValue
		Return Me.GetValue(TableUtils.TAXAMNTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.TAXAMNT field.
	''' </summary>
	Public Function GetTAXAMNTFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.TAXAMNTColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.TAXAMNT field.
	''' </summary>
	Public Sub SetTAXAMNTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TAXAMNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.TAXAMNT field.
	''' </summary>
	Public Sub SetTAXAMNTFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TAXAMNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.TAXAMNT field.
	''' </summary>
	Public Sub SetTAXAMNTFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TAXAMNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.TAXAMNT field.
	''' </summary>
	Public Sub SetTAXAMNTFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TAXAMNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.TAXAMNT field.
	''' </summary>
	Public Sub SetTAXAMNTFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TAXAMNTColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.VENDORID field.
	''' </summary>
	Public Function GetVENDORIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.VENDORIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.VENDORID field.
	''' </summary>
	Public Function GetVENDORIDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.VENDORIDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.VENDORID field.
	''' </summary>
	Public Sub SetVENDORIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.VENDORIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.VENDORID field.
	''' </summary>
	Public Sub SetVENDORIDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VENDORIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.VENDNAME field.
	''' </summary>
	Public Function GetVENDNAMEValue() As ColumnValue
		Return Me.GetValue(TableUtils.VENDNAMEColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.VENDNAME field.
	''' </summary>
	Public Function GetVENDNAMEFieldValue() As String
		Return CType(Me.GetValue(TableUtils.VENDNAMEColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.VENDNAME field.
	''' </summary>
	Public Sub SetVENDNAMEFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.VENDNAMEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.VENDNAME field.
	''' </summary>
	Public Sub SetVENDNAMEFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VENDNAMEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.CMPANYID field.
	''' </summary>
	Public Function GetCMPANYIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CMPANYIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.CMPANYID field.
	''' </summary>
	Public Function GetCMPANYIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.CMPANYIDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.CMPANYID field.
	''' </summary>
	Public Sub SetCMPANYIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CMPANYIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.CMPANYID field.
	''' </summary>
	Public Sub SetCMPANYIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CMPANYIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.CMPANYID field.
	''' </summary>
	Public Sub SetCMPANYIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CMPANYIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.CMPANYID field.
	''' </summary>
	Public Sub SetCMPANYIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CMPANYIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.CMPANYID field.
	''' </summary>
	Public Sub SetCMPANYIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CMPANYIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.COMMNTID field.
	''' </summary>
	Public Function GetCOMMNTIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.COMMNTIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.COMMNTID field.
	''' </summary>
	Public Function GetCOMMNTIDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.COMMNTIDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.COMMNTID field.
	''' </summary>
	Public Sub SetCOMMNTIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.COMMNTIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.COMMNTID field.
	''' </summary>
	Public Sub SetCOMMNTIDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.COMMNTIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.BUYERID field.
	''' </summary>
	Public Function GetBUYERIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.BUYERIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.BUYERID field.
	''' </summary>
	Public Function GetBUYERIDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.BUYERIDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.BUYERID field.
	''' </summary>
	Public Sub SetBUYERIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.BUYERIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.BUYERID field.
	''' </summary>
	Public Sub SetBUYERIDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.BUYERIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.Workflow_Approval_Status field.
	''' </summary>
	Public Function GetWorkflow_Approval_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.Workflow_Approval_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.Workflow_Approval_Status field.
	''' </summary>
	Public Function GetWorkflow_Approval_StatusFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.Workflow_Approval_StatusColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.Workflow_Approval_Status field.
	''' </summary>
	Public Sub SetWorkflow_Approval_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Workflow_Approval_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.Workflow_Approval_Status field.
	''' </summary>
	Public Sub SetWorkflow_Approval_StatusFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Workflow_Approval_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.Workflow_Approval_Status field.
	''' </summary>
	Public Sub SetWorkflow_Approval_StatusFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Workflow_Approval_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.Workflow_Approval_Status field.
	''' </summary>
	Public Sub SetWorkflow_Approval_StatusFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Workflow_Approval_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.Workflow_Approval_Status field.
	''' </summary>
	Public Sub SetWorkflow_Approval_StatusFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Workflow_Approval_StatusColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CompanyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.CMMTTEXT field.
	''' </summary>
	Public Function GetCMMTTEXTValue() As ColumnValue
		Return Me.GetValue(TableUtils.CMMTTEXTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's POP10100_HEADER_ALL_.CMMTTEXT field.
	''' </summary>
	Public Function GetCMMTTEXTFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CMMTTEXTColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.CMMTTEXT field.
	''' </summary>
	Public Sub SetCMMTTEXTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CMMTTEXTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's POP10100_HEADER_ALL_.CMMTTEXT field.
	''' </summary>
	Public Sub SetCMMTTEXTFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CMMTTEXTColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's POP10100_HEADER_ALL_.PONUMBER field.
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
	''' This is a convenience property that provides direct access to the value of the record's POP10100_HEADER_ALL_.POSTATUS field.
	''' </summary>
	Public Property POSTATUS() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.POSTATUSColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.POSTATUSColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property POSTATUSSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.POSTATUSColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property POSTATUSDefault() As String
        Get
            Return TableUtils.POSTATUSColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's POP10100_HEADER_ALL_.DOCDATE field.
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
	''' This is a convenience property that provides direct access to the value of the record's POP10100_HEADER_ALL_.SUBTOTAL field.
	''' </summary>
	Public Property SUBTOTAL() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.SUBTOTALColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SUBTOTALColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SUBTOTALSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SUBTOTALColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SUBTOTALDefault() As String
        Get
            Return TableUtils.SUBTOTALColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's POP10100_HEADER_ALL_.TRDISAMT field.
	''' </summary>
	Public Property TRDISAMT() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.TRDISAMTColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TRDISAMTColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TRDISAMTSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TRDISAMTColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TRDISAMTDefault() As String
        Get
            Return TableUtils.TRDISAMTColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's POP10100_HEADER_ALL_.FRTAMNT field.
	''' </summary>
	Public Property FRTAMNT() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.FRTAMNTColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FRTAMNTColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FRTAMNTSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FRTAMNTColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FRTAMNTDefault() As String
        Get
            Return TableUtils.FRTAMNTColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's POP10100_HEADER_ALL_.MSCCHAMT field.
	''' </summary>
	Public Property MSCCHAMT() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.MSCCHAMTColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MSCCHAMTColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MSCCHAMTSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MSCCHAMTColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MSCCHAMTDefault() As String
        Get
            Return TableUtils.MSCCHAMTColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's POP10100_HEADER_ALL_.TAXAMNT field.
	''' </summary>
	Public Property TAXAMNT() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.TAXAMNTColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TAXAMNTColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TAXAMNTSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TAXAMNTColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TAXAMNTDefault() As String
        Get
            Return TableUtils.TAXAMNTColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's POP10100_HEADER_ALL_.VENDORID field.
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
	''' This is a convenience property that provides direct access to the value of the record's POP10100_HEADER_ALL_.VENDNAME field.
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
	''' This is a convenience property that provides direct access to the value of the record's POP10100_HEADER_ALL_.CMPANYID field.
	''' </summary>
	Public Property CMPANYID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.CMPANYIDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CMPANYIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CMPANYIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CMPANYIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CMPANYIDDefault() As String
        Get
            Return TableUtils.CMPANYIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's POP10100_HEADER_ALL_.COMMNTID field.
	''' </summary>
	Public Property COMMNTID() As String
		Get 
			Return CType(Me.GetValue(TableUtils.COMMNTIDColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.COMMNTIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property COMMNTIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.COMMNTIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property COMMNTIDDefault() As String
        Get
            Return TableUtils.COMMNTIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's POP10100_HEADER_ALL_.BUYERID field.
	''' </summary>
	Public Property BUYERID() As String
		Get 
			Return CType(Me.GetValue(TableUtils.BUYERIDColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.BUYERIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property BUYERIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.BUYERIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property BUYERIDDefault() As String
        Get
            Return TableUtils.BUYERIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's POP10100_HEADER_ALL_.Workflow_Approval_Status field.
	''' </summary>
	Public Property Workflow_Approval_Status() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.Workflow_Approval_StatusColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Workflow_Approval_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Workflow_Approval_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Workflow_Approval_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Workflow_Approval_StatusDefault() As String
        Get
            Return TableUtils.Workflow_Approval_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's POP10100_HEADER_ALL_.CompanyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's POP10100_HEADER_ALL_.CMMTTEXT field.
	''' </summary>
	Public Property CMMTTEXT() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CMMTTEXTColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CMMTTEXTColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CMMTTEXTSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CMMTTEXTColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CMMTTEXTDefault() As String
        Get
            Return TableUtils.CMMTTEXTColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
