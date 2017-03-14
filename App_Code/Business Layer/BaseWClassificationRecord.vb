' This class is "generated" and will be overwritten.
' Your customizations should be made in WClassificationRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WClassificationRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WClassificationTable"></see> class.
''' </remarks>
''' <seealso cref="WClassificationTable"></seealso>
''' <seealso cref="WClassificationRecord"></seealso>

<Serializable()> Public Class BaseWClassificationRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WClassificationTable = WClassificationTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WClassificationRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WClassificationRec As WClassificationRecord = CType(sender,WClassificationRecord)
        Validate_Inserting()
        If Not WClassificationRec Is Nothing AndAlso Not WClassificationRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WClassificationRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WClassificationRec As WClassificationRecord = CType(sender,WClassificationRecord)
        Validate_Updating()
        If Not WClassificationRec Is Nothing AndAlso Not WClassificationRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WClassificationRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WClassificationRec As WClassificationRecord = CType(sender,WClassificationRecord)
        If Not WClassificationRec Is Nothing AndAlso Not WClassificationRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WClassification_.WClass_ID field.
	''' </summary>
	Public Function GetWClass_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WClass_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WClassification_.WClass_ID field.
	''' </summary>
	Public Function GetWClass_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WClass_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WClassification_.WClass_Name field.
	''' </summary>
	Public Function GetWClass_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.WClass_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WClassification_.WClass_Name field.
	''' </summary>
	Public Function GetWClass_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WClass_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WClassification_.WClass_Name field.
	''' </summary>
	Public Sub SetWClass_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WClass_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WClassification_.WClass_Name field.
	''' </summary>
	Public Sub SetWClass_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WClass_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WClassification_.WClass_Value field.
	''' </summary>
	Public Function GetWClass_ValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.WClass_ValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WClassification_.WClass_Value field.
	''' </summary>
	Public Function GetWClass_ValueFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WClass_ValueColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WClassification_.WClass_Value field.
	''' </summary>
	Public Sub SetWClass_ValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WClass_ValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WClassification_.WClass_Value field.
	''' </summary>
	Public Sub SetWClass_ValueFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WClass_ValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WClassification_.WClass_Value field.
	''' </summary>
	Public Sub SetWClass_ValueFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WClass_ValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WClassification_.WClass_Value field.
	''' </summary>
	Public Sub SetWClass_ValueFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WClass_ValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WClassification_.WClass_Value field.
	''' </summary>
	Public Sub SetWClass_ValueFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WClass_ValueColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WClassification_.WClass_ID field.
	''' </summary>
	Public Property WClass_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WClass_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WClass_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WClass_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WClass_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WClass_IDDefault() As String
        Get
            Return TableUtils.WClass_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WClassification_.WClass_Name field.
	''' </summary>
	Public Property WClass_Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WClass_NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WClass_NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WClass_NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WClass_NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WClass_NameDefault() As String
        Get
            Return TableUtils.WClass_NameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WClassification_.WClass_Value field.
	''' </summary>
	Public Property WClass_Value() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WClass_ValueColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WClass_ValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WClass_ValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WClass_ValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WClass_ValueDefault() As String
        Get
            Return TableUtils.WClass_ValueColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
