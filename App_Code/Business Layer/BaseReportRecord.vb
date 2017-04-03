' This class is "generated" and will be overwritten.
' Your customizations should be made in ReportRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="ReportRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="ReportTable"></see> class.
''' </remarks>
''' <seealso cref="ReportTable"></seealso>
''' <seealso cref="ReportRecord"></seealso>

<Serializable()> Public Class BaseReportRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As ReportTable = ReportTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub ReportRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim ReportRec As ReportRecord = CType(sender,ReportRecord)
        Validate_Inserting()
        If Not ReportRec Is Nothing AndAlso Not ReportRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub ReportRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim ReportRec As ReportRecord = CType(sender,ReportRecord)
        Validate_Updating()
        If Not ReportRec Is Nothing AndAlso Not ReportRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub ReportRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim ReportRec As ReportRecord = CType(sender,ReportRecord)
        If Not ReportRec Is Nothing AndAlso Not ReportRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's Report_.ReportID field.
	''' </summary>
	Public Function GetReportIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ReportIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Report_.ReportID field.
	''' </summary>
	Public Function GetReportIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ReportIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Report_.ReportID field.
	''' </summary>
	Public Sub SetReportIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ReportIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Report_.ReportID field.
	''' </summary>
	Public Sub SetReportIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ReportIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Report_.ReportID field.
	''' </summary>
	Public Sub SetReportIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReportIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Report_.ReportID field.
	''' </summary>
	Public Sub SetReportIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReportIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Report_.ReportID field.
	''' </summary>
	Public Sub SetReportIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReportIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Report_.Report field.
	''' </summary>
	Public Function GetReportValue() As ColumnValue
		Return Me.GetValue(TableUtils.ReportColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Report_.Report field.
	''' </summary>
	Public Function GetReportFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ReportColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Report_.Report field.
	''' </summary>
	Public Sub SetReportFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ReportColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Report_.Report field.
	''' </summary>
	Public Sub SetReportFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReportColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Report_.Report_ShortName field.
	''' </summary>
	Public Function GetReport_ShortNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.Report_ShortNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Report_.Report_ShortName field.
	''' </summary>
	Public Function GetReport_ShortNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.Report_ShortNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Report_.Report_ShortName field.
	''' </summary>
	Public Sub SetReport_ShortNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Report_ShortNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Report_.Report_ShortName field.
	''' </summary>
	Public Sub SetReport_ShortNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Report_ShortNameColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Report_.ReportID field.
	''' </summary>
	Public Property ReportID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ReportIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ReportIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ReportIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ReportIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ReportIDDefault() As String
        Get
            Return TableUtils.ReportIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Report_.Report field.
	''' </summary>
	Public Property Report() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ReportColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ReportColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ReportSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ReportColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ReportDefault() As String
        Get
            Return TableUtils.ReportColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Report_.Report_ShortName field.
	''' </summary>
	Public Property Report_ShortName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Report_ShortNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Report_ShortNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Report_ShortNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Report_ShortNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Report_ShortNameDefault() As String
        Get
            Return TableUtils.Report_ShortNameColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
