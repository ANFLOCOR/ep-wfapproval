' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRep_DocAttachRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WFinRep_DocAttachRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WFinRep_DocAttachTable"></see> class.
''' </remarks>
''' <seealso cref="WFinRep_DocAttachTable"></seealso>
''' <seealso cref="WFinRep_DocAttachRecord"></seealso>

<Serializable()> Public Class BaseWFinRep_DocAttachRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WFinRep_DocAttachTable = WFinRep_DocAttachTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WFinRep_DocAttachRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WFinRep_DocAttachRec As WFinRep_DocAttachRecord = CType(sender,WFinRep_DocAttachRecord)
        Validate_Inserting()
        If Not WFinRep_DocAttachRec Is Nothing AndAlso Not WFinRep_DocAttachRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WFinRep_DocAttachRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WFinRep_DocAttachRec As WFinRep_DocAttachRecord = CType(sender,WFinRep_DocAttachRecord)
        Validate_Updating()
        If Not WFinRep_DocAttachRec Is Nothing AndAlso Not WFinRep_DocAttachRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WFinRep_DocAttachRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WFinRep_DocAttachRec As WFinRep_DocAttachRecord = CType(sender,WFinRep_DocAttachRecord)
        If Not WFinRep_DocAttachRec Is Nothing AndAlso Not WFinRep_DocAttachRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_ID field.
	''' </summary>
	Public Function GetFIN_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FIN_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_ID field.
	''' </summary>
	Public Function GetFIN_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FIN_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_Year field.
	''' </summary>
	Public Function GetFIN_YearValue() As ColumnValue
		Return Me.GetValue(TableUtils.FIN_YearColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_Year field.
	''' </summary>
	Public Function GetFIN_YearFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FIN_YearColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Year field.
	''' </summary>
	Public Sub SetFIN_YearFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FIN_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Year field.
	''' </summary>
	Public Sub SetFIN_YearFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FIN_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Year field.
	''' </summary>
	Public Sub SetFIN_YearFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Year field.
	''' </summary>
	Public Sub SetFIN_YearFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Year field.
	''' </summary>
	Public Sub SetFIN_YearFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_YearColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_Month field.
	''' </summary>
	Public Function GetFIN_MonthValue() As ColumnValue
		Return Me.GetValue(TableUtils.FIN_MonthColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_Month field.
	''' </summary>
	Public Function GetFIN_MonthFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FIN_MonthColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Month field.
	''' </summary>
	Public Sub SetFIN_MonthFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FIN_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Month field.
	''' </summary>
	Public Sub SetFIN_MonthFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FIN_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Month field.
	''' </summary>
	Public Sub SetFIN_MonthFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Month field.
	''' </summary>
	Public Sub SetFIN_MonthFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Month field.
	''' </summary>
	Public Sub SetFIN_MonthFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_MonthColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_Type field.
	''' </summary>
	Public Function GetFIN_TypeValue() As ColumnValue
		Return Me.GetValue(TableUtils.FIN_TypeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_Type field.
	''' </summary>
	Public Function GetFIN_TypeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FIN_TypeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Type field.
	''' </summary>
	Public Sub SetFIN_TypeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FIN_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Type field.
	''' </summary>
	Public Sub SetFIN_TypeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIn_Description field.
	''' </summary>
	Public Function GetFIn_DescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.FIn_DescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIn_Description field.
	''' </summary>
	Public Function GetFIn_DescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FIn_DescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIn_Description field.
	''' </summary>
	Public Sub SetFIn_DescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FIn_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIn_Description field.
	''' </summary>
	Public Sub SetFIn_DescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIn_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_File field.
	''' </summary>
	Public Function GetFIN_FileValue() As ColumnValue
		Return Me.GetValue(TableUtils.FIN_FileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_File field.
	''' </summary>
	Public Function GetFIN_FileFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.FIN_FileColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_File field.
	''' </summary>
	Public Sub SetFIN_FileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FIN_FileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_File field.
	''' </summary>
	Public Sub SetFIN_FileFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FIN_FileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_File field.
	''' </summary>
	Public Sub SetFIN_FileFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_FileColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_Company field.
	''' </summary>
	Public Function GetFIN_CompanyValue() As ColumnValue
		Return Me.GetValue(TableUtils.FIN_CompanyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_Company field.
	''' </summary>
	Public Function GetFIN_CompanyFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.FIN_CompanyColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Company field.
	''' </summary>
	Public Sub SetFIN_CompanyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FIN_CompanyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Company field.
	''' </summary>
	Public Sub SetFIN_CompanyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FIN_CompanyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Company field.
	''' </summary>
	Public Sub SetFIN_CompanyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_CompanyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Company field.
	''' </summary>
	Public Sub SetFIN_CompanyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_CompanyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Company field.
	''' </summary>
	Public Sub SetFIN_CompanyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_CompanyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_Status field.
	''' </summary>
	Public Function GetFIN_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.FIN_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_Status field.
	''' </summary>
	Public Function GetFIN_StatusFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FIN_StatusColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Status field.
	''' </summary>
	Public Sub SetFIN_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FIN_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Status field.
	''' </summary>
	Public Sub SetFIN_StatusFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FIN_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Status field.
	''' </summary>
	Public Sub SetFIN_StatusFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Status field.
	''' </summary>
	Public Sub SetFIN_StatusFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Status field.
	''' </summary>
	Public Sub SetFIN_StatusFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_StatusColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_File1 field.
	''' </summary>
	Public Function GetFIN_File1Value() As ColumnValue
		Return Me.GetValue(TableUtils.FIN_File1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_File1 field.
	''' </summary>
	Public Function GetFIN_File1FieldValue() As String
		Return CType(Me.GetValue(TableUtils.FIN_File1Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_File1 field.
	''' </summary>
	Public Sub SetFIN_File1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FIN_File1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_File1 field.
	''' </summary>
	Public Sub SetFIN_File1FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_File1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_RptID field.
	''' </summary>
	Public Function GetFIN_RptIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FIN_RptIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_RptID field.
	''' </summary>
	Public Function GetFIN_RptIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FIN_RptIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_RptID field.
	''' </summary>
	Public Sub SetFIN_RptIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FIN_RptIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_RptID field.
	''' </summary>
	Public Sub SetFIN_RptIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FIN_RptIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_RptID field.
	''' </summary>
	Public Sub SetFIN_RptIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_RptIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_RptID field.
	''' </summary>
	Public Sub SetFIN_RptIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_RptIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_RptID field.
	''' </summary>
	Public Sub SetFIN_RptIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_RptIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_Post field.
	''' </summary>
	Public Function GetFIN_PostValue() As ColumnValue
		Return Me.GetValue(TableUtils.FIN_PostColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_Post field.
	''' </summary>
	Public Function GetFIN_PostFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.FIN_PostColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Post field.
	''' </summary>
	Public Sub SetFIN_PostFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FIN_PostColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Post field.
	''' </summary>
	Public Sub SetFIN_PostFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FIN_PostColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_Post field.
	''' </summary>
	Public Sub SetFIN_PostFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_PostColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_RWRem field.
	''' </summary>
	Public Function GetFIN_RWRemValue() As ColumnValue
		Return Me.GetValue(TableUtils.FIN_RWRemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_RWRem field.
	''' </summary>
	Public Function GetFIN_RWRemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FIN_RWRemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_RWRem field.
	''' </summary>
	Public Sub SetFIN_RWRemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FIN_RWRemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_RWRem field.
	''' </summary>
	Public Sub SetFIN_RWRemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_RWRemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_HFIN_ID field.
	''' </summary>
	Public Function GetFIN_HFIN_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FIN_HFIN_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_HFIN_ID field.
	''' </summary>
	Public Function GetFIN_HFIN_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FIN_HFIN_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_HFIN_ID field.
	''' </summary>
	Public Sub SetFIN_HFIN_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FIN_HFIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_HFIN_ID field.
	''' </summary>
	Public Sub SetFIN_HFIN_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FIN_HFIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_HFIN_ID field.
	''' </summary>
	Public Sub SetFIN_HFIN_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_HFIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_HFIN_ID field.
	''' </summary>
	Public Sub SetFIN_HFIN_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_HFIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_DocAttach_.FIN_HFIN_ID field.
	''' </summary>
	Public Sub SetFIN_HFIN_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_HFIN_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_ID field.
	''' </summary>
	Public Property FIN_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FIN_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FIN_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FIN_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FIN_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FIN_IDDefault() As String
        Get
            Return TableUtils.FIN_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_Year field.
	''' </summary>
	Public Property FIN_Year() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FIN_YearColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FIN_YearColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FIN_YearSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FIN_YearColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FIN_YearDefault() As String
        Get
            Return TableUtils.FIN_YearColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_Month field.
	''' </summary>
	Public Property FIN_Month() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FIN_MonthColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FIN_MonthColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FIN_MonthSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FIN_MonthColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FIN_MonthDefault() As String
        Get
            Return TableUtils.FIN_MonthColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_Type field.
	''' </summary>
	Public Property FIN_Type() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FIN_TypeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FIN_TypeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FIN_TypeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FIN_TypeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FIN_TypeDefault() As String
        Get
            Return TableUtils.FIN_TypeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_DocAttach_.FIn_Description field.
	''' </summary>
	Public Property FIn_Description() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FIn_DescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FIn_DescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FIn_DescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FIn_DescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FIn_DescriptionDefault() As String
        Get
            Return TableUtils.FIn_DescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_File field.
	''' </summary>
	Public Property FIN_File() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.FIN_FileColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FIN_FileColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FIN_FileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FIN_FileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FIN_FileDefault() As String
        Get
            Return TableUtils.FIN_FileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_Company field.
	''' </summary>
	Public Property FIN_Company() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.FIN_CompanyColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FIN_CompanyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FIN_CompanySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FIN_CompanyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FIN_CompanyDefault() As String
        Get
            Return TableUtils.FIN_CompanyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_Status field.
	''' </summary>
	Public Property FIN_Status() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FIN_StatusColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FIN_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FIN_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FIN_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FIN_StatusDefault() As String
        Get
            Return TableUtils.FIN_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_File1 field.
	''' </summary>
	Public Property FIN_File1() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FIN_File1Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FIN_File1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FIN_File1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FIN_File1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FIN_File1Default() As String
        Get
            Return TableUtils.FIN_File1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_RptID field.
	''' </summary>
	Public Property FIN_RptID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FIN_RptIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FIN_RptIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FIN_RptIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FIN_RptIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FIN_RptIDDefault() As String
        Get
            Return TableUtils.FIN_RptIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_Post field.
	''' </summary>
	Public Property FIN_Post() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.FIN_PostColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FIN_PostColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FIN_PostSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FIN_PostColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FIN_PostDefault() As String
        Get
            Return TableUtils.FIN_PostColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_RWRem field.
	''' </summary>
	Public Property FIN_RWRem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FIN_RWRemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FIN_RWRemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FIN_RWRemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FIN_RWRemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FIN_RWRemDefault() As String
        Get
            Return TableUtils.FIN_RWRemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_DocAttach_.FIN_HFIN_ID field.
	''' </summary>
	Public Property FIN_HFIN_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FIN_HFIN_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FIN_HFIN_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FIN_HFIN_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FIN_HFIN_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FIN_HFIN_IDDefault() As String
        Get
            Return TableUtils.FIN_HFIN_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
