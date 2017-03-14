' This class is "generated" and will be overwritten.
' Your customizations should be made in W_EmailRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="W_EmailRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="W_EmailTable"></see> class.
''' </remarks>
''' <seealso cref="W_EmailTable"></seealso>
''' <seealso cref="W_EmailRecord"></seealso>

<Serializable()> Public Class BaseW_EmailRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As W_EmailTable = W_EmailTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub W_EmailRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim W_EmailRec As W_EmailRecord = CType(sender,W_EmailRecord)
        Validate_Inserting()
        If Not W_EmailRec Is Nothing AndAlso Not W_EmailRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub W_EmailRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim W_EmailRec As W_EmailRecord = CType(sender,W_EmailRecord)
        Validate_Updating()
        If Not W_EmailRec Is Nothing AndAlso Not W_EmailRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub W_EmailRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim W_EmailRec As W_EmailRecord = CType(sender,W_EmailRecord)
        If Not W_EmailRec Is Nothing AndAlso Not W_EmailRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's W_Email_.WE_ID field.
	''' </summary>
	Public Function GetWE_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WE_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_Email_.WE_ID field.
	''' </summary>
	Public Function GetWE_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WE_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_Email_.WE_U_ID field.
	''' </summary>
	Public Function GetWE_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WE_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_Email_.WE_U_ID field.
	''' </summary>
	Public Function GetWE_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WE_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Email_.WE_U_ID field.
	''' </summary>
	Public Sub SetWE_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WE_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Email_.WE_U_ID field.
	''' </summary>
	Public Sub SetWE_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WE_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Email_.WE_U_ID field.
	''' </summary>
	Public Sub SetWE_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WE_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Email_.WE_U_ID field.
	''' </summary>
	Public Sub SetWE_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WE_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Email_.WE_U_ID field.
	''' </summary>
	Public Sub SetWE_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WE_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_Email_.WE_Directory field.
	''' </summary>
	Public Function GetWE_DirectoryValue() As ColumnValue
		Return Me.GetValue(TableUtils.WE_DirectoryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_Email_.WE_Directory field.
	''' </summary>
	Public Function GetWE_DirectoryFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WE_DirectoryColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Email_.WE_Directory field.
	''' </summary>
	Public Sub SetWE_DirectoryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WE_DirectoryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Email_.WE_Directory field.
	''' </summary>
	Public Sub SetWE_DirectoryFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WE_DirectoryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_Email_.WE_Site field.
	''' </summary>
	Public Function GetWE_SiteValue() As ColumnValue
		Return Me.GetValue(TableUtils.WE_SiteColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_Email_.WE_Site field.
	''' </summary>
	Public Function GetWE_SiteFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WE_SiteColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Email_.WE_Site field.
	''' </summary>
	Public Sub SetWE_SiteFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WE_SiteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Email_.WE_Site field.
	''' </summary>
	Public Sub SetWE_SiteFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WE_SiteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_Email_.WE_Template field.
	''' </summary>
	Public Function GetWE_TemplateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WE_TemplateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_Email_.WE_Template field.
	''' </summary>
	Public Function GetWE_TemplateFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WE_TemplateColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Email_.WE_Template field.
	''' </summary>
	Public Sub SetWE_TemplateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WE_TemplateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Email_.WE_Template field.
	''' </summary>
	Public Sub SetWE_TemplateFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WE_TemplateColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_Email_.WE_ID field.
	''' </summary>
	Public Property WE_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WE_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WE_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WE_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WE_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WE_IDDefault() As String
        Get
            Return TableUtils.WE_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_Email_.WE_U_ID field.
	''' </summary>
	Public Property WE_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WE_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WE_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WE_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WE_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WE_U_IDDefault() As String
        Get
            Return TableUtils.WE_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_Email_.WE_Directory field.
	''' </summary>
	Public Property WE_Directory() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WE_DirectoryColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WE_DirectoryColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WE_DirectorySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WE_DirectoryColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WE_DirectoryDefault() As String
        Get
            Return TableUtils.WE_DirectoryColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_Email_.WE_Site field.
	''' </summary>
	Public Property WE_Site() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WE_SiteColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WE_SiteColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WE_SiteSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WE_SiteColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WE_SiteDefault() As String
        Get
            Return TableUtils.WE_SiteColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_Email_.WE_Template field.
	''' </summary>
	Public Property WE_Template() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WE_TemplateColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WE_TemplateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WE_TemplateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WE_TemplateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WE_TemplateDefault() As String
        Get
            Return TableUtils.WE_TemplateColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
