' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_Dynamics_Company3Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_Dynamics_Company3Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_Dynamics_Company3View"></see> class.
''' </remarks>
''' <seealso cref="Sel_Dynamics_Company3View"></seealso>
''' <seealso cref="Sel_Dynamics_Company3Record"></seealso>

<Serializable()> Public Class BaseSel_Dynamics_Company3Record
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_Dynamics_Company3View = Sel_Dynamics_Company3View.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_Dynamics_Company3Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_Dynamics_Company3Rec As Sel_Dynamics_Company3Record = CType(sender,Sel_Dynamics_Company3Record)
        If Not Sel_Dynamics_Company3Rec Is Nothing AndAlso Not Sel_Dynamics_Company3Rec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_Dynamics_Company3Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_Dynamics_Company3Rec As Sel_Dynamics_Company3Record = CType(sender,Sel_Dynamics_Company3Record)
        Validate_Inserting()
        If Not Sel_Dynamics_Company3Rec Is Nothing AndAlso Not Sel_Dynamics_Company3Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.CMPANYID field.
	''' </summary>
	Public Function GetCMPANYIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CMPANYIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.CMPANYID field.
	''' </summary>
	Public Function GetCMPANYIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.CMPANYIDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.CMPANYID field.
	''' </summary>
	Public Sub SetCMPANYIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CMPANYIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.CMPANYID field.
	''' </summary>
	Public Sub SetCMPANYIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CMPANYIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.CMPANYID field.
	''' </summary>
	Public Sub SetCMPANYIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CMPANYIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.CMPANYID field.
	''' </summary>
	Public Sub SetCMPANYIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CMPANYIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.CMPANYID field.
	''' </summary>
	Public Sub SetCMPANYIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CMPANYIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.CMPNYNAM field.
	''' </summary>
	Public Function GetCMPNYNAMValue() As ColumnValue
		Return Me.GetValue(TableUtils.CMPNYNAMColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.CMPNYNAM field.
	''' </summary>
	Public Function GetCMPNYNAMFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CMPNYNAMColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.CMPNYNAM field.
	''' </summary>
	Public Sub SetCMPNYNAMFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CMPNYNAMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.CMPNYNAM field.
	''' </summary>
	Public Sub SetCMPNYNAMFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CMPNYNAMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.INTERID field.
	''' </summary>
	Public Function GetINTERIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.INTERIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.INTERID field.
	''' </summary>
	Public Function GetINTERIDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.INTERIDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.INTERID field.
	''' </summary>
	Public Sub SetINTERIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.INTERIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.INTERID field.
	''' </summary>
	Public Sub SetINTERIDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.INTERIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.FULLADDRESS field.
	''' </summary>
	Public Function GetFULLADDRESSValue() As ColumnValue
		Return Me.GetValue(TableUtils.FULLADDRESSColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.FULLADDRESS field.
	''' </summary>
	Public Function GetFULLADDRESSFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FULLADDRESSColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.FULLADDRESS field.
	''' </summary>
	Public Sub SetFULLADDRESSFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FULLADDRESSColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.FULLADDRESS field.
	''' </summary>
	Public Sub SetFULLADDRESSFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FULLADDRESSColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.TAXREGTN field.
	''' </summary>
	Public Function GetTAXREGTNValue() As ColumnValue
		Return Me.GetValue(TableUtils.TAXREGTNColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.TAXREGTN field.
	''' </summary>
	Public Function GetTAXREGTNFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TAXREGTNColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.TAXREGTN field.
	''' </summary>
	Public Sub SetTAXREGTNFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TAXREGTNColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.TAXREGTN field.
	''' </summary>
	Public Sub SetTAXREGTNFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TAXREGTNColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.ADDRESS1 field.
	''' </summary>
	Public Function GetADDRESS1Value() As ColumnValue
		Return Me.GetValue(TableUtils.ADDRESS1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.ADDRESS1 field.
	''' </summary>
	Public Function GetADDRESS1FieldValue() As String
		Return CType(Me.GetValue(TableUtils.ADDRESS1Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.ADDRESS1 field.
	''' </summary>
	Public Sub SetADDRESS1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ADDRESS1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.ADDRESS1 field.
	''' </summary>
	Public Sub SetADDRESS1FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ADDRESS1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.ADDRESS2 field.
	''' </summary>
	Public Function GetADDRESS2Value() As ColumnValue
		Return Me.GetValue(TableUtils.ADDRESS2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.ADDRESS2 field.
	''' </summary>
	Public Function GetADDRESS2FieldValue() As String
		Return CType(Me.GetValue(TableUtils.ADDRESS2Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.ADDRESS2 field.
	''' </summary>
	Public Sub SetADDRESS2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ADDRESS2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.ADDRESS2 field.
	''' </summary>
	Public Sub SetADDRESS2FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ADDRESS2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.ADDRESS3 field.
	''' </summary>
	Public Function GetADDRESS3Value() As ColumnValue
		Return Me.GetValue(TableUtils.ADDRESS3Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.ADDRESS3 field.
	''' </summary>
	Public Function GetADDRESS3FieldValue() As String
		Return CType(Me.GetValue(TableUtils.ADDRESS3Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.ADDRESS3 field.
	''' </summary>
	Public Sub SetADDRESS3FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ADDRESS3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.ADDRESS3 field.
	''' </summary>
	Public Sub SetADDRESS3FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ADDRESS3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.CITY field.
	''' </summary>
	Public Function GetCITYValue() As ColumnValue
		Return Me.GetValue(TableUtils.CITYColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.CITY field.
	''' </summary>
	Public Function GetCITYFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CITYColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.CITY field.
	''' </summary>
	Public Sub SetCITYFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CITYColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.CITY field.
	''' </summary>
	Public Sub SetCITYFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CITYColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.ZIPCODE field.
	''' </summary>
	Public Function GetZIPCODEValue() As ColumnValue
		Return Me.GetValue(TableUtils.ZIPCODEColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.ZIPCODE field.
	''' </summary>
	Public Function GetZIPCODEFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ZIPCODEColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.ZIPCODE field.
	''' </summary>
	Public Sub SetZIPCODEFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ZIPCODEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.ZIPCODE field.
	''' </summary>
	Public Sub SetZIPCODEFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ZIPCODEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.COUNTY field.
	''' </summary>
	Public Function GetCOUNTYValue() As ColumnValue
		Return Me.GetValue(TableUtils.COUNTYColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.COUNTY field.
	''' </summary>
	Public Function GetCOUNTYFieldValue() As String
		Return CType(Me.GetValue(TableUtils.COUNTYColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.COUNTY field.
	''' </summary>
	Public Sub SetCOUNTYFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.COUNTYColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.COUNTY field.
	''' </summary>
	Public Sub SetCOUNTYFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.COUNTYColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.STATE field.
	''' </summary>
	Public Function GetSTATEValue() As ColumnValue
		Return Me.GetValue(TableUtils.STATEColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.STATE field.
	''' </summary>
	Public Function GetSTATEFieldValue() As String
		Return CType(Me.GetValue(TableUtils.STATEColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.STATE field.
	''' </summary>
	Public Sub SetSTATEFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.STATEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.STATE field.
	''' </summary>
	Public Sub SetSTATEFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.STATEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.PHONE2 field.
	''' </summary>
	Public Function GetPHONE2Value() As ColumnValue
		Return Me.GetValue(TableUtils.PHONE2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.PHONE2 field.
	''' </summary>
	Public Function GetPHONE2FieldValue() As String
		Return CType(Me.GetValue(TableUtils.PHONE2Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.PHONE2 field.
	''' </summary>
	Public Sub SetPHONE2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PHONE2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.PHONE2 field.
	''' </summary>
	Public Sub SetPHONE2FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PHONE2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.PHONE1 field.
	''' </summary>
	Public Function GetPHONE1Value() As ColumnValue
		Return Me.GetValue(TableUtils.PHONE1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.PHONE1 field.
	''' </summary>
	Public Function GetPHONE1FieldValue() As String
		Return CType(Me.GetValue(TableUtils.PHONE1Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.PHONE1 field.
	''' </summary>
	Public Sub SetPHONE1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PHONE1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.PHONE1 field.
	''' </summary>
	Public Sub SetPHONE1FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PHONE1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.PHONE3 field.
	''' </summary>
	Public Function GetPHONE3Value() As ColumnValue
		Return Me.GetValue(TableUtils.PHONE3Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.PHONE3 field.
	''' </summary>
	Public Function GetPHONE3FieldValue() As String
		Return CType(Me.GetValue(TableUtils.PHONE3Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.PHONE3 field.
	''' </summary>
	Public Sub SetPHONE3FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PHONE3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.PHONE3 field.
	''' </summary>
	Public Sub SetPHONE3FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PHONE3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.FAXNUMBR field.
	''' </summary>
	Public Function GetFAXNUMBRValue() As ColumnValue
		Return Me.GetValue(TableUtils.FAXNUMBRColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.FAXNUMBR field.
	''' </summary>
	Public Function GetFAXNUMBRFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FAXNUMBRColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.FAXNUMBR field.
	''' </summary>
	Public Sub SetFAXNUMBRFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FAXNUMBRColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.FAXNUMBR field.
	''' </summary>
	Public Sub SetFAXNUMBRFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FAXNUMBRColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.p1 field.
	''' </summary>
	Public Function Getp1Value() As ColumnValue
		Return Me.GetValue(TableUtils.p1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.p1 field.
	''' </summary>
	Public Function Getp1FieldValue() As String
		Return CType(Me.GetValue(TableUtils.p1Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.p1 field.
	''' </summary>
	Public Sub Setp1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.p1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.p1 field.
	''' </summary>
	Public Sub Setp1FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.p1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.p2 field.
	''' </summary>
	Public Function Getp2Value() As ColumnValue
		Return Me.GetValue(TableUtils.p2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.p2 field.
	''' </summary>
	Public Function Getp2FieldValue() As String
		Return CType(Me.GetValue(TableUtils.p2Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.p2 field.
	''' </summary>
	Public Sub Setp2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.p2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.p2 field.
	''' </summary>
	Public Sub Setp2FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.p2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.p3 field.
	''' </summary>
	Public Function Getp3Value() As ColumnValue
		Return Me.GetValue(TableUtils.p3Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.p3 field.
	''' </summary>
	Public Function Getp3FieldValue() As String
		Return CType(Me.GetValue(TableUtils.p3Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.p3 field.
	''' </summary>
	Public Sub Setp3FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.p3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.p3 field.
	''' </summary>
	Public Sub Setp3FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.p3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.fax field.
	''' </summary>
	Public Function GetfaxValue() As ColumnValue
		Return Me.GetValue(TableUtils.faxColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.fax field.
	''' </summary>
	Public Function GetfaxFieldValue() As String
		Return CType(Me.GetValue(TableUtils.faxColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.fax field.
	''' </summary>
	Public Sub SetfaxFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.faxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.fax field.
	''' </summary>
	Public Sub SetfaxFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.faxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.LSTUSRED field.
	''' </summary>
	Public Function GetLSTUSREDValue() As ColumnValue
		Return Me.GetValue(TableUtils.LSTUSREDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.LSTUSRED field.
	''' </summary>
	Public Function GetLSTUSREDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.LSTUSREDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.LSTUSRED field.
	''' </summary>
	Public Sub SetLSTUSREDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LSTUSREDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.LSTUSRED field.
	''' </summary>
	Public Sub SetLSTUSREDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LSTUSREDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.MODIFDT field.
	''' </summary>
	Public Function GetMODIFDTValue() As ColumnValue
		Return Me.GetValue(TableUtils.MODIFDTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.MODIFDT field.
	''' </summary>
	Public Function GetMODIFDTFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.MODIFDTColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.MODIFDT field.
	''' </summary>
	Public Sub SetMODIFDTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MODIFDTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.MODIFDT field.
	''' </summary>
	Public Sub SetMODIFDTFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MODIFDTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.MODIFDT field.
	''' </summary>
	Public Sub SetMODIFDTFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MODIFDTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.Company_Short_Name field.
	''' </summary>
	Public Function GetCompany_Short_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.Company_Short_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Dynamics_Company_.Company_Short_Name field.
	''' </summary>
	Public Function GetCompany_Short_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.Company_Short_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.Company_Short_Name field.
	''' </summary>
	Public Sub SetCompany_Short_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Company_Short_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Dynamics_Company_.Company_Short_Name field.
	''' </summary>
	Public Sub SetCompany_Short_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_Short_NameColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.CMPANYID field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.CMPNYNAM field.
	''' </summary>
	Public Property CMPNYNAM() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CMPNYNAMColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CMPNYNAMColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CMPNYNAMSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CMPNYNAMColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CMPNYNAMDefault() As String
        Get
            Return TableUtils.CMPNYNAMColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.INTERID field.
	''' </summary>
	Public Property INTERID() As String
		Get 
			Return CType(Me.GetValue(TableUtils.INTERIDColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.INTERIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property INTERIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.INTERIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property INTERIDDefault() As String
        Get
            Return TableUtils.INTERIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.FULLADDRESS field.
	''' </summary>
	Public Property FULLADDRESS() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FULLADDRESSColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FULLADDRESSColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FULLADDRESSSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FULLADDRESSColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FULLADDRESSDefault() As String
        Get
            Return TableUtils.FULLADDRESSColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.TAXREGTN field.
	''' </summary>
	Public Property TAXREGTN() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TAXREGTNColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TAXREGTNColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TAXREGTNSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TAXREGTNColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TAXREGTNDefault() As String
        Get
            Return TableUtils.TAXREGTNColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.ADDRESS1 field.
	''' </summary>
	Public Property ADDRESS1() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ADDRESS1Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ADDRESS1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ADDRESS1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ADDRESS1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ADDRESS1Default() As String
        Get
            Return TableUtils.ADDRESS1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.ADDRESS2 field.
	''' </summary>
	Public Property ADDRESS2() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ADDRESS2Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ADDRESS2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ADDRESS2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ADDRESS2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ADDRESS2Default() As String
        Get
            Return TableUtils.ADDRESS2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.ADDRESS3 field.
	''' </summary>
	Public Property ADDRESS3() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ADDRESS3Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ADDRESS3Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ADDRESS3Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ADDRESS3Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ADDRESS3Default() As String
        Get
            Return TableUtils.ADDRESS3Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.CITY field.
	''' </summary>
	Public Property CITY() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CITYColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CITYColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CITYSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CITYColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CITYDefault() As String
        Get
            Return TableUtils.CITYColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.ZIPCODE field.
	''' </summary>
	Public Property ZIPCODE() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ZIPCODEColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ZIPCODEColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ZIPCODESpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ZIPCODEColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ZIPCODEDefault() As String
        Get
            Return TableUtils.ZIPCODEColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.COUNTY field.
	''' </summary>
	Public Property COUNTY() As String
		Get 
			Return CType(Me.GetValue(TableUtils.COUNTYColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.COUNTYColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property COUNTYSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.COUNTYColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property COUNTYDefault() As String
        Get
            Return TableUtils.COUNTYColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.STATE field.
	''' </summary>
	Public Property STATE() As String
		Get 
			Return CType(Me.GetValue(TableUtils.STATEColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.STATEColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property STATESpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.STATEColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property STATEDefault() As String
        Get
            Return TableUtils.STATEColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.PHONE2 field.
	''' </summary>
	Public Property PHONE2() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PHONE2Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PHONE2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PHONE2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PHONE2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PHONE2Default() As String
        Get
            Return TableUtils.PHONE2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.PHONE1 field.
	''' </summary>
	Public Property PHONE1() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PHONE1Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PHONE1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PHONE1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PHONE1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PHONE1Default() As String
        Get
            Return TableUtils.PHONE1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.PHONE3 field.
	''' </summary>
	Public Property PHONE3() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PHONE3Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PHONE3Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PHONE3Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PHONE3Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PHONE3Default() As String
        Get
            Return TableUtils.PHONE3Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.FAXNUMBR field.
	''' </summary>
	Public Property FAXNUMBR() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FAXNUMBRColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FAXNUMBRColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FAXNUMBRSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FAXNUMBRColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FAXNUMBRDefault() As String
        Get
            Return TableUtils.FAXNUMBRColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.p1 field.
	''' </summary>
	Public Property p1() As String
		Get 
			Return CType(Me.GetValue(TableUtils.p1Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.p1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property p1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.p1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property p1Default() As String
        Get
            Return TableUtils.p1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.p2 field.
	''' </summary>
	Public Property p2() As String
		Get 
			Return CType(Me.GetValue(TableUtils.p2Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.p2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property p2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.p2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property p2Default() As String
        Get
            Return TableUtils.p2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.p3 field.
	''' </summary>
	Public Property p3() As String
		Get 
			Return CType(Me.GetValue(TableUtils.p3Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.p3Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property p3Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.p3Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property p3Default() As String
        Get
            Return TableUtils.p3Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.fax field.
	''' </summary>
	Public Property fax() As String
		Get 
			Return CType(Me.GetValue(TableUtils.faxColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.faxColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property faxSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.faxColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property faxDefault() As String
        Get
            Return TableUtils.faxColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.LSTUSRED field.
	''' </summary>
	Public Property LSTUSRED() As String
		Get 
			Return CType(Me.GetValue(TableUtils.LSTUSREDColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.LSTUSREDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LSTUSREDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LSTUSREDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LSTUSREDDefault() As String
        Get
            Return TableUtils.LSTUSREDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.MODIFDT field.
	''' </summary>
	Public Property MODIFDT() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.MODIFDTColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MODIFDTColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MODIFDTSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MODIFDTColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MODIFDTDefault() As String
        Get
            Return TableUtils.MODIFDTColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Dynamics_Company_.Company_Short_Name field.
	''' </summary>
	Public Property Company_Short_Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Company_Short_NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Company_Short_NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Company_Short_NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Company_Short_NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Company_Short_NameDefault() As String
        Get
            Return TableUtils.Company_Short_NameColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
