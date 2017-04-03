' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRepNGP_DocAttachRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WFinRepNGP_DocAttachRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WFinRepNGP_DocAttachTable"></see> class.
''' </remarks>
''' <seealso cref="WFinRepNGP_DocAttachTable"></seealso>
''' <seealso cref="WFinRepNGP_DocAttachRecord"></seealso>

<Serializable()> Public Class BaseWFinRepNGP_DocAttachRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WFinRepNGP_DocAttachTable = WFinRepNGP_DocAttachTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WFinRepNGP_DocAttachRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WFinRepNGP_DocAttachRec As WFinRepNGP_DocAttachRecord = CType(sender,WFinRepNGP_DocAttachRecord)
        Validate_Inserting()
        If Not WFinRepNGP_DocAttachRec Is Nothing AndAlso Not WFinRepNGP_DocAttachRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WFinRepNGP_DocAttachRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WFinRepNGP_DocAttachRec As WFinRepNGP_DocAttachRecord = CType(sender,WFinRepNGP_DocAttachRecord)
        Validate_Updating()
        If Not WFinRepNGP_DocAttachRec Is Nothing AndAlso Not WFinRepNGP_DocAttachRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WFinRepNGP_DocAttachRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WFinRepNGP_DocAttachRec As WFinRepNGP_DocAttachRecord = CType(sender,WFinRepNGP_DocAttachRecord)
        If Not WFinRepNGP_DocAttachRec Is Nothing AndAlso Not WFinRepNGP_DocAttachRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_ID field.
	''' </summary>
	Public Function GetWFRCDNGP_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCDNGP_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_ID field.
	''' </summary>
	Public Function GetWFRCDNGP_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCDNGP_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Year field.
	''' </summary>
	Public Function GetWFRCDNGP_YearValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCDNGP_YearColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Year field.
	''' </summary>
	Public Function GetWFRCDNGP_YearFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCDNGP_YearColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Year field.
	''' </summary>
	Public Sub SetWFRCDNGP_YearFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCDNGP_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Year field.
	''' </summary>
	Public Sub SetWFRCDNGP_YearFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCDNGP_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Year field.
	''' </summary>
	Public Sub SetWFRCDNGP_YearFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Year field.
	''' </summary>
	Public Sub SetWFRCDNGP_YearFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Year field.
	''' </summary>
	Public Sub SetWFRCDNGP_YearFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_YearColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Month field.
	''' </summary>
	Public Function GetWFRCDNGP_MonthValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCDNGP_MonthColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Month field.
	''' </summary>
	Public Function GetWFRCDNGP_MonthFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCDNGP_MonthColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Month field.
	''' </summary>
	Public Sub SetWFRCDNGP_MonthFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCDNGP_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Month field.
	''' </summary>
	Public Sub SetWFRCDNGP_MonthFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCDNGP_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Month field.
	''' </summary>
	Public Sub SetWFRCDNGP_MonthFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Month field.
	''' </summary>
	Public Sub SetWFRCDNGP_MonthFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Month field.
	''' </summary>
	Public Sub SetWFRCDNGP_MonthFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_MonthColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Type field.
	''' </summary>
	Public Function GetWFRCDNGP_TypeValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCDNGP_TypeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Type field.
	''' </summary>
	Public Function GetWFRCDNGP_TypeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRCDNGP_TypeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Type field.
	''' </summary>
	Public Sub SetWFRCDNGP_TypeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCDNGP_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Type field.
	''' </summary>
	Public Sub SetWFRCDNGP_TypeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Description field.
	''' </summary>
	Public Function GetWFRCDNGP_DescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCDNGP_DescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Description field.
	''' </summary>
	Public Function GetWFRCDNGP_DescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRCDNGP_DescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Description field.
	''' </summary>
	Public Sub SetWFRCDNGP_DescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCDNGP_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Description field.
	''' </summary>
	Public Sub SetWFRCDNGP_DescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_File field.
	''' </summary>
	Public Function GetWFRCDNGP_FileValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCDNGP_FileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_File field.
	''' </summary>
	Public Function GetWFRCDNGP_FileFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.WFRCDNGP_FileColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_File field.
	''' </summary>
	Public Sub SetWFRCDNGP_FileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCDNGP_FileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_File field.
	''' </summary>
	Public Sub SetWFRCDNGP_FileFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCDNGP_FileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_File field.
	''' </summary>
	Public Sub SetWFRCDNGP_FileFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_FileColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Company field.
	''' </summary>
	Public Function GetWFRCDNGP_CompanyValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCDNGP_CompanyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Company field.
	''' </summary>
	Public Function GetWFRCDNGP_CompanyFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WFRCDNGP_CompanyColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Company field.
	''' </summary>
	Public Sub SetWFRCDNGP_CompanyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCDNGP_CompanyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Company field.
	''' </summary>
	Public Sub SetWFRCDNGP_CompanyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCDNGP_CompanyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Company field.
	''' </summary>
	Public Sub SetWFRCDNGP_CompanyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_CompanyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Company field.
	''' </summary>
	Public Sub SetWFRCDNGP_CompanyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_CompanyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Company field.
	''' </summary>
	Public Sub SetWFRCDNGP_CompanyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_CompanyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Status field.
	''' </summary>
	Public Function GetWFRCDNGP_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCDNGP_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Status field.
	''' </summary>
	Public Function GetWFRCDNGP_StatusFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCDNGP_StatusColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Status field.
	''' </summary>
	Public Sub SetWFRCDNGP_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCDNGP_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Status field.
	''' </summary>
	Public Sub SetWFRCDNGP_StatusFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCDNGP_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Status field.
	''' </summary>
	Public Sub SetWFRCDNGP_StatusFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Status field.
	''' </summary>
	Public Sub SetWFRCDNGP_StatusFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Status field.
	''' </summary>
	Public Sub SetWFRCDNGP_StatusFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_StatusColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_File1 field.
	''' </summary>
	Public Function GetWFRCDNGP_File1Value() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCDNGP_File1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_File1 field.
	''' </summary>
	Public Function GetWFRCDNGP_File1FieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRCDNGP_File1Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_File1 field.
	''' </summary>
	Public Sub SetWFRCDNGP_File1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCDNGP_File1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_File1 field.
	''' </summary>
	Public Sub SetWFRCDNGP_File1FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_File1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_RptID field.
	''' </summary>
	Public Function GetWFRCDNGP_RptIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCDNGP_RptIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_RptID field.
	''' </summary>
	Public Function GetWFRCDNGP_RptIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCDNGP_RptIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_RptID field.
	''' </summary>
	Public Sub SetWFRCDNGP_RptIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCDNGP_RptIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_RptID field.
	''' </summary>
	Public Sub SetWFRCDNGP_RptIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCDNGP_RptIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_RptID field.
	''' </summary>
	Public Sub SetWFRCDNGP_RptIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_RptIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_RptID field.
	''' </summary>
	Public Sub SetWFRCDNGP_RptIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_RptIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_RptID field.
	''' </summary>
	Public Sub SetWFRCDNGP_RptIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_RptIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Post field.
	''' </summary>
	Public Function GetWFRCDNGP_PostValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCDNGP_PostColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Post field.
	''' </summary>
	Public Function GetWFRCDNGP_PostFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WFRCDNGP_PostColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Post field.
	''' </summary>
	Public Sub SetWFRCDNGP_PostFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCDNGP_PostColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Post field.
	''' </summary>
	Public Sub SetWFRCDNGP_PostFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCDNGP_PostColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Post field.
	''' </summary>
	Public Sub SetWFRCDNGP_PostFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_PostColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_RWRem field.
	''' </summary>
	Public Function GetWFRCDNGP_RWRemValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCDNGP_RWRemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_RWRem field.
	''' </summary>
	Public Function GetWFRCDNGP_RWRemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRCDNGP_RWRemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_RWRem field.
	''' </summary>
	Public Sub SetWFRCDNGP_RWRemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCDNGP_RWRemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_RWRem field.
	''' </summary>
	Public Sub SetWFRCDNGP_RWRemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_RWRemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_WFRCHNGP_ID field.
	''' </summary>
	Public Function GetWFRCDNGP_WFRCHNGP_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCDNGP_WFRCHNGP_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_WFRCHNGP_ID field.
	''' </summary>
	Public Function GetWFRCDNGP_WFRCHNGP_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCDNGP_WFRCHNGP_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRCDNGP_WFRCHNGP_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCDNGP_WFRCHNGP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRCDNGP_WFRCHNGP_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCDNGP_WFRCHNGP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRCDNGP_WFRCHNGP_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_WFRCHNGP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRCDNGP_WFRCHNGP_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_WFRCHNGP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRCDNGP_WFRCHNGP_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCDNGP_WFRCHNGP_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_ID field.
	''' </summary>
	Public Property WFRCDNGP_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCDNGP_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCDNGP_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCDNGP_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCDNGP_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCDNGP_IDDefault() As String
        Get
            Return TableUtils.WFRCDNGP_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Year field.
	''' </summary>
	Public Property WFRCDNGP_Year() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCDNGP_YearColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCDNGP_YearColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCDNGP_YearSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCDNGP_YearColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCDNGP_YearDefault() As String
        Get
            Return TableUtils.WFRCDNGP_YearColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Month field.
	''' </summary>
	Public Property WFRCDNGP_Month() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCDNGP_MonthColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCDNGP_MonthColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCDNGP_MonthSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCDNGP_MonthColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCDNGP_MonthDefault() As String
        Get
            Return TableUtils.WFRCDNGP_MonthColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Type field.
	''' </summary>
	Public Property WFRCDNGP_Type() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCDNGP_TypeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WFRCDNGP_TypeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCDNGP_TypeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCDNGP_TypeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCDNGP_TypeDefault() As String
        Get
            Return TableUtils.WFRCDNGP_TypeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Description field.
	''' </summary>
	Public Property WFRCDNGP_Description() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCDNGP_DescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WFRCDNGP_DescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCDNGP_DescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCDNGP_DescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCDNGP_DescriptionDefault() As String
        Get
            Return TableUtils.WFRCDNGP_DescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_File field.
	''' </summary>
	Public Property WFRCDNGP_File() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCDNGP_FileColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCDNGP_FileColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCDNGP_FileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCDNGP_FileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCDNGP_FileDefault() As String
        Get
            Return TableUtils.WFRCDNGP_FileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Company field.
	''' </summary>
	Public Property WFRCDNGP_Company() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCDNGP_CompanyColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCDNGP_CompanyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCDNGP_CompanySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCDNGP_CompanyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCDNGP_CompanyDefault() As String
        Get
            Return TableUtils.WFRCDNGP_CompanyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Status field.
	''' </summary>
	Public Property WFRCDNGP_Status() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCDNGP_StatusColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCDNGP_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCDNGP_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCDNGP_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCDNGP_StatusDefault() As String
        Get
            Return TableUtils.WFRCDNGP_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_File1 field.
	''' </summary>
	Public Property WFRCDNGP_File1() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCDNGP_File1Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WFRCDNGP_File1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCDNGP_File1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCDNGP_File1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCDNGP_File1Default() As String
        Get
            Return TableUtils.WFRCDNGP_File1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_RptID field.
	''' </summary>
	Public Property WFRCDNGP_RptID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCDNGP_RptIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCDNGP_RptIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCDNGP_RptIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCDNGP_RptIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCDNGP_RptIDDefault() As String
        Get
            Return TableUtils.WFRCDNGP_RptIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_Post field.
	''' </summary>
	Public Property WFRCDNGP_Post() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCDNGP_PostColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCDNGP_PostColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCDNGP_PostSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCDNGP_PostColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCDNGP_PostDefault() As String
        Get
            Return TableUtils.WFRCDNGP_PostColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_RWRem field.
	''' </summary>
	Public Property WFRCDNGP_RWRem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCDNGP_RWRemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WFRCDNGP_RWRemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCDNGP_RWRemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCDNGP_RWRemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCDNGP_RWRemDefault() As String
        Get
            Return TableUtils.WFRCDNGP_RWRemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_DocAttach_.WFRCDNGP_WFRCHNGP_ID field.
	''' </summary>
	Public Property WFRCDNGP_WFRCHNGP_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCDNGP_WFRCHNGP_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCDNGP_WFRCHNGP_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCDNGP_WFRCHNGP_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCDNGP_WFRCHNGP_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCDNGP_WFRCHNGP_IDDefault() As String
        Get
            Return TableUtils.WFRCDNGP_WFRCHNGP_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
