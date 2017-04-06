' This class is "generated" and will be overwritten.
' Your customizations should be made in W_Module_SourceRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="W_Module_SourceRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="W_Module_SourceTable"></see> class.
''' </remarks>
''' <seealso cref="W_Module_SourceTable"></seealso>
''' <seealso cref="W_Module_SourceRecord"></seealso>

<Serializable()> Public Class BaseW_Module_SourceRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As W_Module_SourceTable = W_Module_SourceTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub W_Module_SourceRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim W_Module_SourceRec As W_Module_SourceRecord = CType(sender,W_Module_SourceRecord)
        Validate_Inserting()
        If Not W_Module_SourceRec Is Nothing AndAlso Not W_Module_SourceRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub W_Module_SourceRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim W_Module_SourceRec As W_Module_SourceRecord = CType(sender,W_Module_SourceRecord)
        Validate_Updating()
        If Not W_Module_SourceRec Is Nothing AndAlso Not W_Module_SourceRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub W_Module_SourceRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim W_Module_SourceRec As W_Module_SourceRecord = CType(sender,W_Module_SourceRecord)
        If Not W_Module_SourceRec Is Nothing AndAlso Not W_Module_SourceRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's W_Module_Source_.W_MS_ID field.
	''' </summary>
	Public Function GetW_MS_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_MS_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_Module_Source_.W_MS_ID field.
	''' </summary>
	Public Function GetW_MS_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.W_MS_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_Module_Source_.W_MS_A_ID field.
	''' </summary>
	Public Function GetW_MS_A_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_MS_A_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_Module_Source_.W_MS_A_ID field.
	''' </summary>
	Public Function GetW_MS_A_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.W_MS_A_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Module_Source_.W_MS_A_ID field.
	''' </summary>
	Public Sub SetW_MS_A_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_MS_A_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Module_Source_.W_MS_A_ID field.
	''' </summary>
	Public Sub SetW_MS_A_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.W_MS_A_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Module_Source_.W_MS_A_ID field.
	''' </summary>
	Public Sub SetW_MS_A_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_MS_A_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Module_Source_.W_MS_A_ID field.
	''' </summary>
	Public Sub SetW_MS_A_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_MS_A_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Module_Source_.W_MS_A_ID field.
	''' </summary>
	Public Sub SetW_MS_A_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_MS_A_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_Module_Source_.W_MS_Name field.
	''' </summary>
	Public Function GetW_MS_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_MS_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_Module_Source_.W_MS_Name field.
	''' </summary>
	Public Function GetW_MS_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.W_MS_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Module_Source_.W_MS_Name field.
	''' </summary>
	Public Sub SetW_MS_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_MS_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Module_Source_.W_MS_Name field.
	''' </summary>
	Public Sub SetW_MS_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_MS_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_Module_Source_.W_MS_Desc field.
	''' </summary>
	Public Function GetW_MS_DescValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_MS_DescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_Module_Source_.W_MS_Desc field.
	''' </summary>
	Public Function GetW_MS_DescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.W_MS_DescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Module_Source_.W_MS_Desc field.
	''' </summary>
	Public Sub SetW_MS_DescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_MS_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_Module_Source_.W_MS_Desc field.
	''' </summary>
	Public Sub SetW_MS_DescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_MS_DescColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_Module_Source_.W_MS_ID field.
	''' </summary>
	Public Property W_MS_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.W_MS_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.W_MS_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_MS_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_MS_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_MS_IDDefault() As String
        Get
            Return TableUtils.W_MS_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_Module_Source_.W_MS_A_ID field.
	''' </summary>
	Public Property W_MS_A_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.W_MS_A_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.W_MS_A_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_MS_A_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_MS_A_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_MS_A_IDDefault() As String
        Get
            Return TableUtils.W_MS_A_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_Module_Source_.W_MS_Name field.
	''' </summary>
	Public Property W_MS_Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.W_MS_NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.W_MS_NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_MS_NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_MS_NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_MS_NameDefault() As String
        Get
            Return TableUtils.W_MS_NameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_Module_Source_.W_MS_Desc field.
	''' </summary>
	Public Property W_MS_Desc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.W_MS_DescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.W_MS_DescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_MS_DescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_MS_DescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_MS_DescDefault() As String
        Get
            Return TableUtils.W_MS_DescColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
