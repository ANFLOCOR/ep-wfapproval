' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRep_ReportTypeRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WFinRep_ReportTypeRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WFinRep_ReportTypeTable"></see> class.
''' </remarks>
''' <seealso cref="WFinRep_ReportTypeTable"></seealso>
''' <seealso cref="WFinRep_ReportTypeRecord"></seealso>

<Serializable()> Public Class BaseWFinRep_ReportTypeRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WFinRep_ReportTypeTable = WFinRep_ReportTypeTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WFinRep_ReportTypeRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WFinRep_ReportTypeRec As WFinRep_ReportTypeRecord = CType(sender,WFinRep_ReportTypeRecord)
        Validate_Inserting()
        If Not WFinRep_ReportTypeRec Is Nothing AndAlso Not WFinRep_ReportTypeRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WFinRep_ReportTypeRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WFinRep_ReportTypeRec As WFinRep_ReportTypeRecord = CType(sender,WFinRep_ReportTypeRecord)
        Validate_Updating()
        If Not WFinRep_ReportTypeRec Is Nothing AndAlso Not WFinRep_ReportTypeRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WFinRep_ReportTypeRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WFinRep_ReportTypeRec As WFinRep_ReportTypeRecord = CType(sender,WFinRep_ReportTypeRecord)
        If Not WFinRep_ReportTypeRec Is Nothing AndAlso Not WFinRep_ReportTypeRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_ReportType_.WFRT_Type field.
	''' </summary>
	Public Function GetWFRT_TypeValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRT_TypeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_ReportType_.WFRT_Type field.
	''' </summary>
	Public Function GetWFRT_TypeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRT_TypeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_ReportType_.WFRT_Type field.
	''' </summary>
	Public Sub SetWFRT_TypeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRT_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_ReportType_.WFRT_Type field.
	''' </summary>
	Public Sub SetWFRT_TypeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRT_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_ReportType_.WFRT_Description field.
	''' </summary>
	Public Function GetWFRT_DescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRT_DescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_ReportType_.WFRT_Description field.
	''' </summary>
	Public Function GetWFRT_DescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRT_DescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_ReportType_.WFRT_Description field.
	''' </summary>
	Public Sub SetWFRT_DescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRT_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_ReportType_.WFRT_Description field.
	''' </summary>
	Public Sub SetWFRT_DescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRT_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_ReportType_.WFRT_SortOrder field.
	''' </summary>
	Public Function GetWFRT_SortOrderValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRT_SortOrderColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRep_ReportType_.WFRT_SortOrder field.
	''' </summary>
	Public Function GetWFRT_SortOrderFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRT_SortOrderColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_ReportType_.WFRT_SortOrder field.
	''' </summary>
	Public Sub SetWFRT_SortOrderFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRT_SortOrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_ReportType_.WFRT_SortOrder field.
	''' </summary>
	Public Sub SetWFRT_SortOrderFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRT_SortOrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_ReportType_.WFRT_SortOrder field.
	''' </summary>
	Public Sub SetWFRT_SortOrderFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRT_SortOrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_ReportType_.WFRT_SortOrder field.
	''' </summary>
	Public Sub SetWFRT_SortOrderFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRT_SortOrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRep_ReportType_.WFRT_SortOrder field.
	''' </summary>
	Public Sub SetWFRT_SortOrderFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRT_SortOrderColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_ReportType_.WFRT_Type field.
	''' </summary>
	Public Property WFRT_Type() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WFRT_TypeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WFRT_TypeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRT_TypeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRT_TypeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRT_TypeDefault() As String
        Get
            Return TableUtils.WFRT_TypeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_ReportType_.WFRT_Description field.
	''' </summary>
	Public Property WFRT_Description() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WFRT_DescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WFRT_DescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRT_DescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRT_DescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRT_DescriptionDefault() As String
        Get
            Return TableUtils.WFRT_DescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRep_ReportType_.WFRT_SortOrder field.
	''' </summary>
	Public Property WFRT_SortOrder() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRT_SortOrderColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRT_SortOrderColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRT_SortOrderSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRT_SortOrderColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRT_SortOrderDefault() As String
        Get
            Return TableUtils.WFRT_SortOrderColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
