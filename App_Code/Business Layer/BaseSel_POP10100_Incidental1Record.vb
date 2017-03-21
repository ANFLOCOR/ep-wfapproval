' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_POP10100_Incidental1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_POP10100_Incidental1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_POP10100_Incidental1View"></see> class.
''' </remarks>
''' <seealso cref="Sel_POP10100_Incidental1View"></seealso>
''' <seealso cref="Sel_POP10100_Incidental1Record"></seealso>

<Serializable()> Public Class BaseSel_POP10100_Incidental1Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_POP10100_Incidental1View = Sel_POP10100_Incidental1View.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_POP10100_Incidental1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_POP10100_Incidental1Rec As Sel_POP10100_Incidental1Record = CType(sender,Sel_POP10100_Incidental1Record)
        Validate_Inserting()
        If Not Sel_POP10100_Incidental1Rec Is Nothing AndAlso Not Sel_POP10100_Incidental1Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub Sel_POP10100_Incidental1Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim Sel_POP10100_Incidental1Rec As Sel_POP10100_Incidental1Record = CType(sender,Sel_POP10100_Incidental1Record)
        Validate_Updating()
        If Not Sel_POP10100_Incidental1Rec Is Nothing AndAlso Not Sel_POP10100_Incidental1Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_POP10100_Incidental1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_POP10100_Incidental1Rec As Sel_POP10100_Incidental1Record = CType(sender,Sel_POP10100_Incidental1Record)
        If Not Sel_POP10100_Incidental1Rec Is Nothing AndAlso Not Sel_POP10100_Incidental1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.PONUMBER field.
	''' </summary>
	Public Function GetPONUMBERValue() As ColumnValue
		Return Me.GetValue(TableUtils.PONUMBERColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.PONUMBER field.
	''' </summary>
	Public Function GetPONUMBERFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PONUMBERColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.PONUMBER field.
	''' </summary>
	Public Sub SetPONUMBERFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PONUMBERColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.PONUMBER field.
	''' </summary>
	Public Sub SetPONUMBERFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PONUMBERColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.POSTATUS field.
	''' </summary>
	Public Function GetPOSTATUSValue() As ColumnValue
		Return Me.GetValue(TableUtils.POSTATUSColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.POSTATUS field.
	''' </summary>
	Public Function GetPOSTATUSFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.POSTATUSColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.POSTATUS field.
	''' </summary>
	Public Sub SetPOSTATUSFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.POSTATUSColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.POSTATUS field.
	''' </summary>
	Public Sub SetPOSTATUSFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.POSTATUSColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.POSTATUS field.
	''' </summary>
	Public Sub SetPOSTATUSFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.POSTATUSColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.POSTATUS field.
	''' </summary>
	Public Sub SetPOSTATUSFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.POSTATUSColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.POSTATUS field.
	''' </summary>
	Public Sub SetPOSTATUSFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.POSTATUSColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.DOCDATE field.
	''' </summary>
	Public Function GetDOCDATEValue() As ColumnValue
		Return Me.GetValue(TableUtils.DOCDATEColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.DOCDATE field.
	''' </summary>
	Public Function GetDOCDATEFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.DOCDATEColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.DOCDATE field.
	''' </summary>
	Public Sub SetDOCDATEFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DOCDATEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.DOCDATE field.
	''' </summary>
	Public Sub SetDOCDATEFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DOCDATEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.DOCDATE field.
	''' </summary>
	Public Sub SetDOCDATEFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DOCDATEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.SUBTOTAL field.
	''' </summary>
	Public Function GetSUBTOTALValue() As ColumnValue
		Return Me.GetValue(TableUtils.SUBTOTALColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.SUBTOTAL field.
	''' </summary>
	Public Function GetSUBTOTALFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.SUBTOTALColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.SUBTOTAL field.
	''' </summary>
	Public Sub SetSUBTOTALFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SUBTOTALColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.SUBTOTAL field.
	''' </summary>
	Public Sub SetSUBTOTALFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SUBTOTALColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.SUBTOTAL field.
	''' </summary>
	Public Sub SetSUBTOTALFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SUBTOTALColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.SUBTOTAL field.
	''' </summary>
	Public Sub SetSUBTOTALFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SUBTOTALColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.SUBTOTAL field.
	''' </summary>
	Public Sub SetSUBTOTALFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SUBTOTALColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.VENDORID field.
	''' </summary>
	Public Function GetVENDORIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.VENDORIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.VENDORID field.
	''' </summary>
	Public Function GetVENDORIDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.VENDORIDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.VENDORID field.
	''' </summary>
	Public Sub SetVENDORIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.VENDORIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.VENDORID field.
	''' </summary>
	Public Sub SetVENDORIDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VENDORIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.VENDNAME field.
	''' </summary>
	Public Function GetVENDNAMEValue() As ColumnValue
		Return Me.GetValue(TableUtils.VENDNAMEColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.VENDNAME field.
	''' </summary>
	Public Function GetVENDNAMEFieldValue() As String
		Return CType(Me.GetValue(TableUtils.VENDNAMEColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.VENDNAME field.
	''' </summary>
	Public Sub SetVENDNAMEFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.VENDNAMEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.VENDNAME field.
	''' </summary>
	Public Sub SetVENDNAMEFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VENDNAMEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.Company_ID field.
	''' </summary>
	Public Function GetCompany_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.Company_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.Company_ID field.
	''' </summary>
	Public Function GetCompany_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.Company_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.PRMDATE field.
	''' </summary>
	Public Function GetPRMDATEValue() As ColumnValue
		Return Me.GetValue(TableUtils.PRMDATEColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.PRMDATE field.
	''' </summary>
	Public Function GetPRMDATEFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.PRMDATEColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.PRMDATE field.
	''' </summary>
	Public Sub SetPRMDATEFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PRMDATEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.PRMDATE field.
	''' </summary>
	Public Sub SetPRMDATEFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PRMDATEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.PRMDATE field.
	''' </summary>
	Public Sub SetPRMDATEFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PRMDATEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.SHIPMTHD field.
	''' </summary>
	Public Function GetSHIPMTHDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SHIPMTHDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.SHIPMTHD field.
	''' </summary>
	Public Function GetSHIPMTHDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SHIPMTHDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.SHIPMTHD field.
	''' </summary>
	Public Sub SetSHIPMTHDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SHIPMTHDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.SHIPMTHD field.
	''' </summary>
	Public Sub SetSHIPMTHDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SHIPMTHDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.TAXAMNT field.
	''' </summary>
	Public Function GetTAXAMNTValue() As ColumnValue
		Return Me.GetValue(TableUtils.TAXAMNTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.TAXAMNT field.
	''' </summary>
	Public Function GetTAXAMNTFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.TAXAMNTColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.TAXAMNT field.
	''' </summary>
	Public Sub SetTAXAMNTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TAXAMNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.TAXAMNT field.
	''' </summary>
	Public Sub SetTAXAMNTFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TAXAMNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.TAXAMNT field.
	''' </summary>
	Public Sub SetTAXAMNTFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TAXAMNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.TAXAMNT field.
	''' </summary>
	Public Sub SetTAXAMNTFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TAXAMNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.TAXAMNT field.
	''' </summary>
	Public Sub SetTAXAMNTFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TAXAMNTColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.PYMTRMID field.
	''' </summary>
	Public Function GetPYMTRMIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PYMTRMIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.PYMTRMID field.
	''' </summary>
	Public Function GetPYMTRMIDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PYMTRMIDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.PYMTRMID field.
	''' </summary>
	Public Sub SetPYMTRMIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PYMTRMIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.PYMTRMID field.
	''' </summary>
	Public Sub SetPYMTRMIDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PYMTRMIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.COMMNTID field.
	''' </summary>
	Public Function GetCOMMNTIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.COMMNTIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP10100_Incidental_.COMMNTID field.
	''' </summary>
	Public Function GetCOMMNTIDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.COMMNTIDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.COMMNTID field.
	''' </summary>
	Public Sub SetCOMMNTIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.COMMNTIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP10100_Incidental_.COMMNTID field.
	''' </summary>
	Public Sub SetCOMMNTIDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.COMMNTIDColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_POP10100_Incidental_.PONUMBER field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_POP10100_Incidental_.POSTATUS field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_POP10100_Incidental_.DOCDATE field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_POP10100_Incidental_.SUBTOTAL field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_POP10100_Incidental_.VENDORID field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_POP10100_Incidental_.VENDNAME field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_POP10100_Incidental_.Company_ID field.
	''' </summary>
	Public Property Company_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.Company_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Company_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Company_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Company_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Company_IDDefault() As String
        Get
            Return TableUtils.Company_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_POP10100_Incidental_.PRMDATE field.
	''' </summary>
	Public Property PRMDATE() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.PRMDATEColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PRMDATEColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PRMDATESpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PRMDATEColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PRMDATEDefault() As String
        Get
            Return TableUtils.PRMDATEColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_POP10100_Incidental_.SHIPMTHD field.
	''' </summary>
	Public Property SHIPMTHD() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SHIPMTHDColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SHIPMTHDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SHIPMTHDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SHIPMTHDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SHIPMTHDDefault() As String
        Get
            Return TableUtils.SHIPMTHDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_POP10100_Incidental_.TAXAMNT field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_POP10100_Incidental_.PYMTRMID field.
	''' </summary>
	Public Property PYMTRMID() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PYMTRMIDColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PYMTRMIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PYMTRMIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PYMTRMIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PYMTRMIDDefault() As String
        Get
            Return TableUtils.PYMTRMIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_POP10100_Incidental_.COMMNTID field.
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



#End Region

End Class
End Namespace
