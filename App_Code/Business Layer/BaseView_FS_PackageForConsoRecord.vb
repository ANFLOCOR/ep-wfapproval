' This class is "generated" and will be overwritten.
' Your customizations should be made in View_FS_PackageForConsoRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="View_FS_PackageForConsoRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="View_FS_PackageForConsoView"></see> class.
''' </remarks>
''' <seealso cref="View_FS_PackageForConsoView"></seealso>
''' <seealso cref="View_FS_PackageForConsoRecord"></seealso>

<Serializable()> Public Class BaseView_FS_PackageForConsoRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As View_FS_PackageForConsoView = View_FS_PackageForConsoView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub View_FS_PackageForConsoRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim View_FS_PackageForConsoRec As View_FS_PackageForConsoRecord = CType(sender,View_FS_PackageForConsoRecord)
        If Not View_FS_PackageForConsoRec Is Nothing AndAlso Not View_FS_PackageForConsoRec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub View_FS_PackageForConsoRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim View_FS_PackageForConsoRec As View_FS_PackageForConsoRecord = CType(sender,View_FS_PackageForConsoRecord)
        Validate_Inserting()
        If Not View_FS_PackageForConsoRec Is Nothing AndAlso Not View_FS_PackageForConsoRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.wass_C_ID field.
	''' </summary>
	Public Function Getwass_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.wass_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.wass_C_ID field.
	''' </summary>
	Public Function Getwass_C_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.wass_C_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.wass_C_ID field.
	''' </summary>
	Public Sub Setwass_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.wass_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.wass_C_ID field.
	''' </summary>
	Public Sub Setwass_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.wass_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.wass_C_ID field.
	''' </summary>
	Public Sub Setwass_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.wass_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.wass_C_ID field.
	''' </summary>
	Public Sub Setwass_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.wass_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.wass_C_ID field.
	''' </summary>
	Public Sub Setwass_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.wass_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.ID field.
	''' </summary>
	Public Function GetID0Value() As ColumnValue
		Return Me.GetValue(TableUtils.ID0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.ID field.
	''' </summary>
	Public Function GetID0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ID0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.ID field.
	''' </summary>
	Public Sub SetID0FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ID0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.ID field.
	''' </summary>
	Public Sub SetID0FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ID0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.ID field.
	''' </summary>
	Public Sub SetID0FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ID0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.ID field.
	''' </summary>
	Public Sub SetID0FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ID0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.ID field.
	''' </summary>
	Public Sub SetID0FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ID0Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.Year field.
	''' </summary>
	Public Function GetYearValue() As ColumnValue
		Return Me.GetValue(TableUtils.YearColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.Year field.
	''' </summary>
	Public Function GetYearFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.YearColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Year field.
	''' </summary>
	Public Sub SetYearFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Year field.
	''' </summary>
	Public Sub SetYearFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Year field.
	''' </summary>
	Public Sub SetYearFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Year field.
	''' </summary>
	Public Sub SetYearFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Year field.
	''' </summary>
	Public Sub SetYearFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.YearColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.Month field.
	''' </summary>
	Public Function GetMonthValue() As ColumnValue
		Return Me.GetValue(TableUtils.MonthColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.Month field.
	''' </summary>
	Public Function GetMonthFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.MonthColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Month field.
	''' </summary>
	Public Sub SetMonthFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Month field.
	''' </summary>
	Public Sub SetMonthFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Month field.
	''' </summary>
	Public Sub SetMonthFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Month field.
	''' </summary>
	Public Sub SetMonthFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MonthColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Month field.
	''' </summary>
	Public Sub SetMonthFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MonthColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.Doc_TypeID field.
	''' </summary>
	Public Function GetDoc_TypeIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.Doc_TypeIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.Doc_TypeID field.
	''' </summary>
	Public Function GetDoc_TypeIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.Doc_TypeIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Doc_TypeID field.
	''' </summary>
	Public Sub SetDoc_TypeIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Doc_TypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Doc_TypeID field.
	''' </summary>
	Public Sub SetDoc_TypeIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Doc_TypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Doc_TypeID field.
	''' </summary>
	Public Sub SetDoc_TypeIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Doc_TypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Doc_TypeID field.
	''' </summary>
	Public Sub SetDoc_TypeIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Doc_TypeIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Doc_TypeID field.
	''' </summary>
	Public Sub SetDoc_TypeIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Doc_TypeIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.Submit field.
	''' </summary>
	Public Function GetSubmitValue() As ColumnValue
		Return Me.GetValue(TableUtils.SubmitColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.Submit field.
	''' </summary>
	Public Function GetSubmitFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SubmitColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Submit field.
	''' </summary>
	Public Sub SetSubmitFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SubmitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Submit field.
	''' </summary>
	Public Sub SetSubmitFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SubmitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Submit field.
	''' </summary>
	Public Sub SetSubmitFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SubmitColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.Status field.
	''' </summary>
	Public Function GetStatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.Status field.
	''' </summary>
	Public Function GetStatusFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.StatusColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Status field.
	''' </summary>
	Public Sub SetStatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Status field.
	''' </summary>
	Public Sub SetStatusFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Status field.
	''' </summary>
	Public Sub SetStatusFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Status field.
	''' </summary>
	Public Sub SetStatusFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Status field.
	''' </summary>
	Public Sub SetStatusFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.StatusColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CompanyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.UserId field.
	''' </summary>
	Public Function GetUserId0Value() As ColumnValue
		Return Me.GetValue(TableUtils.UserId0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.UserId field.
	''' </summary>
	Public Function GetUserId0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UserId0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.UserId field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UserId0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.UserId field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UserId0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.UserId field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UserId0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.UserId field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UserId0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.UserId field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UserId0Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.Remarks field.
	''' </summary>
	Public Function GetRemarksValue() As ColumnValue
		Return Me.GetValue(TableUtils.RemarksColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.Remarks field.
	''' </summary>
	Public Function GetRemarksFieldValue() As String
		Return CType(Me.GetValue(TableUtils.RemarksColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Remarks field.
	''' </summary>
	Public Sub SetRemarksFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RemarksColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Remarks field.
	''' </summary>
	Public Sub SetRemarksFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RemarksColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.ReportCnt field.
	''' </summary>
	Public Function GetReportCntValue() As ColumnValue
		Return Me.GetValue(TableUtils.ReportCntColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.ReportCnt field.
	''' </summary>
	Public Function GetReportCntFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ReportCntColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.ReportCnt field.
	''' </summary>
	Public Sub SetReportCntFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ReportCntColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.ReportCnt field.
	''' </summary>
	Public Sub SetReportCntFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ReportCntColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.ReportCnt field.
	''' </summary>
	Public Sub SetReportCntFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReportCntColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.ReportCnt field.
	''' </summary>
	Public Sub SetReportCntFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReportCntColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.ReportCnt field.
	''' </summary>
	Public Sub SetReportCntFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReportCntColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.Description field.
	''' </summary>
	Public Function GetDescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.DescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.Description field.
	''' </summary>
	Public Function GetDescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Description field.
	''' </summary>
	Public Sub SetDescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.Description field.
	''' </summary>
	Public Sub SetDescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.DescriptionStat field.
	''' </summary>
	Public Function GetDescriptionStatValue() As ColumnValue
		Return Me.GetValue(TableUtils.DescriptionStatColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.DescriptionStat field.
	''' </summary>
	Public Function GetDescriptionStatFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DescriptionStatColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.DescriptionStat field.
	''' </summary>
	Public Sub SetDescriptionStatFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DescriptionStatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.DescriptionStat field.
	''' </summary>
	Public Sub SetDescriptionStatFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DescriptionStatColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.FS_Type field.
	''' </summary>
	Public Function GetFS_TypeValue() As ColumnValue
		Return Me.GetValue(TableUtils.FS_TypeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_FS_PackageForConso_.FS_Type field.
	''' </summary>
	Public Function GetFS_TypeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FS_TypeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.FS_Type field.
	''' </summary>
	Public Sub SetFS_TypeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FS_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_FS_PackageForConso_.FS_Type field.
	''' </summary>
	Public Sub SetFS_TypeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FS_TypeColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_FS_PackageForConso_.wass_C_ID field.
	''' </summary>
	Public Property wass_C_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.wass_C_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.wass_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property wass_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.wass_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property wass_C_IDDefault() As String
        Get
            Return TableUtils.wass_C_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_FS_PackageForConso_.ID field.
	''' </summary>
	Public Property ID0() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ID0Column).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ID0Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ID0Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ID0Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ID0Default() As String
        Get
            Return TableUtils.ID0Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_FS_PackageForConso_.Year field.
	''' </summary>
	Public Property Year() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.YearColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.YearColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property YearSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.YearColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property YearDefault() As String
        Get
            Return TableUtils.YearColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_FS_PackageForConso_.Month field.
	''' </summary>
	Public Property Month() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.MonthColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MonthColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MonthSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MonthColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MonthDefault() As String
        Get
            Return TableUtils.MonthColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_FS_PackageForConso_.Doc_TypeID field.
	''' </summary>
	Public Property Doc_TypeID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.Doc_TypeIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Doc_TypeIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Doc_TypeIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Doc_TypeIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Doc_TypeIDDefault() As String
        Get
            Return TableUtils.Doc_TypeIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_FS_PackageForConso_.Submit field.
	''' </summary>
	Public Property Submit() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SubmitColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SubmitColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SubmitSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SubmitColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SubmitDefault() As String
        Get
            Return TableUtils.SubmitColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_FS_PackageForConso_.Status field.
	''' </summary>
	Public Property Status() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.StatusColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.StatusColumn)
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_FS_PackageForConso_.CompanyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's view_FS_PackageForConso_.UserId field.
	''' </summary>
	Public Property UserId0() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.UserId0Column).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.UserId0Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UserId0Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UserId0Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UserId0Default() As String
        Get
            Return TableUtils.UserId0Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_FS_PackageForConso_.Remarks field.
	''' </summary>
	Public Property Remarks() As String
		Get 
			Return CType(Me.GetValue(TableUtils.RemarksColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.RemarksColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RemarksSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RemarksColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RemarksDefault() As String
        Get
            Return TableUtils.RemarksColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_FS_PackageForConso_.ReportCnt field.
	''' </summary>
	Public Property ReportCnt() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ReportCntColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ReportCntColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ReportCntSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ReportCntColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ReportCntDefault() As String
        Get
            Return TableUtils.ReportCntColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_FS_PackageForConso_.Description field.
	''' </summary>
	Public Property Description() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DescriptionDefault() As String
        Get
            Return TableUtils.DescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_FS_PackageForConso_.DescriptionStat field.
	''' </summary>
	Public Property DescriptionStat() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DescriptionStatColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DescriptionStatColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DescriptionStatSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DescriptionStatColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DescriptionStatDefault() As String
        Get
            Return TableUtils.DescriptionStatColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_FS_PackageForConso_.FS_Type field.
	''' </summary>
	Public Property FS_Type() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FS_TypeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FS_TypeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FS_TypeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FS_TypeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FS_TypeDefault() As String
        Get
            Return TableUtils.FS_TypeColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
