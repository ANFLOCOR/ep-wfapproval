' This class is "generated" and will be overwritten.
' Your customizations should be made in WASS_Email_Default1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WASS_Email_Default1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WASS_Email_Default1Table"></see> class.
''' </remarks>
''' <seealso cref="WASS_Email_Default1Table"></seealso>
''' <seealso cref="WASS_Email_Default1Record"></seealso>

<Serializable()> Public Class BaseWASS_Email_Default1Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WASS_Email_Default1Table = WASS_Email_Default1Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WASS_Email_Default1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WASS_Email_Default1Rec As WASS_Email_Default1Record = CType(sender,WASS_Email_Default1Record)
        Validate_Inserting()
        If Not WASS_Email_Default1Rec Is Nothing AndAlso Not WASS_Email_Default1Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WASS_Email_Default1Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WASS_Email_Default1Rec As WASS_Email_Default1Record = CType(sender,WASS_Email_Default1Record)
        Validate_Updating()
        If Not WASS_Email_Default1Rec Is Nothing AndAlso Not WASS_Email_Default1Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WASS_Email_Default1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WASS_Email_Default1Rec As WASS_Email_Default1Record = CType(sender,WASS_Email_Default1Record)
        If Not WASS_Email_Default1Rec Is Nothing AndAlso Not WASS_Email_Default1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WASS_Email_Default_.WED_ID field.
	''' </summary>
	Public Function GetWED_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WED_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WASS_Email_Default_.WED_ID field.
	''' </summary>
	Public Function GetWED_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WED_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WASS_Email_Default_.WED_Type field.
	''' </summary>
	Public Function GetWED_TypeValue() As ColumnValue
		Return Me.GetValue(TableUtils.WED_TypeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WASS_Email_Default_.WED_Type field.
	''' </summary>
	Public Function GetWED_TypeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WED_TypeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WASS_Email_Default_.WED_Type field.
	''' </summary>
	Public Sub SetWED_TypeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WED_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WASS_Email_Default_.WED_Type field.
	''' </summary>
	Public Sub SetWED_TypeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WED_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WASS_Email_Default_.WED_Template field.
	''' </summary>
	Public Function GetWED_TemplateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WED_TemplateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WASS_Email_Default_.WED_Template field.
	''' </summary>
	Public Function GetWED_TemplateFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WED_TemplateColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WASS_Email_Default_.WED_Template field.
	''' </summary>
	Public Sub SetWED_TemplateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WED_TemplateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WASS_Email_Default_.WED_Template field.
	''' </summary>
	Public Sub SetWED_TemplateFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WED_TemplateColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WASS_Email_Default_.WED_ID field.
	''' </summary>
	Public Property WED_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WED_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WED_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WED_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WED_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WED_IDDefault() As String
        Get
            Return TableUtils.WED_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WASS_Email_Default_.WED_Type field.
	''' </summary>
	Public Property WED_Type() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WED_TypeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WED_TypeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WED_TypeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WED_TypeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WED_TypeDefault() As String
        Get
            Return TableUtils.WED_TypeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WASS_Email_Default_.WED_Template field.
	''' </summary>
	Public Property WED_Template() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WED_TemplateColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WED_TemplateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WED_TemplateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WED_TemplateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WED_TemplateDefault() As String
        Get
            Return TableUtils.WED_TemplateColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
