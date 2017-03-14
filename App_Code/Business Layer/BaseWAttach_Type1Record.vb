' This class is "generated" and will be overwritten.
' Your customizations should be made in WAttach_Type1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WAttach_Type1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WAttach_Type1Table"></see> class.
''' </remarks>
''' <seealso cref="WAttach_Type1Table"></seealso>
''' <seealso cref="WAttach_Type1Record"></seealso>

<Serializable()> Public Class BaseWAttach_Type1Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WAttach_Type1Table = WAttach_Type1Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WAttach_Type1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WAttach_Type1Rec As WAttach_Type1Record = CType(sender,WAttach_Type1Record)
        Validate_Inserting()
        If Not WAttach_Type1Rec Is Nothing AndAlso Not WAttach_Type1Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WAttach_Type1Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WAttach_Type1Rec As WAttach_Type1Record = CType(sender,WAttach_Type1Record)
        Validate_Updating()
        If Not WAttach_Type1Rec Is Nothing AndAlso Not WAttach_Type1Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WAttach_Type1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WAttach_Type1Rec As WAttach_Type1Record = CType(sender,WAttach_Type1Record)
        If Not WAttach_Type1Rec Is Nothing AndAlso Not WAttach_Type1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WAttach_Type_.WAT_ID field.
	''' </summary>
	Public Function GetWAT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WAT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WAttach_Type_.WAT_ID field.
	''' </summary>
	Public Function GetWAT_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WAT_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WAttach_Type_.WAT_Name field.
	''' </summary>
	Public Function GetWAT_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.WAT_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WAttach_Type_.WAT_Name field.
	''' </summary>
	Public Function GetWAT_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WAT_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WAttach_Type_.WAT_Name field.
	''' </summary>
	Public Sub SetWAT_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WAT_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WAttach_Type_.WAT_Name field.
	''' </summary>
	Public Sub SetWAT_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WAT_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WAttach_Type_.WAT_Operation field.
	''' </summary>
	Public Function GetWAT_OperationValue() As ColumnValue
		Return Me.GetValue(TableUtils.WAT_OperationColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WAttach_Type_.WAT_Operation field.
	''' </summary>
	Public Function GetWAT_OperationFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WAT_OperationColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WAttach_Type_.WAT_Operation field.
	''' </summary>
	Public Sub SetWAT_OperationFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WAT_OperationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WAttach_Type_.WAT_Operation field.
	''' </summary>
	Public Sub SetWAT_OperationFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WAT_OperationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WAttach_Type_.WAT_Order field.
	''' </summary>
	Public Function GetWAT_OrderValue() As ColumnValue
		Return Me.GetValue(TableUtils.WAT_OrderColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WAttach_Type_.WAT_Order field.
	''' </summary>
	Public Function GetWAT_OrderFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WAT_OrderColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WAttach_Type_.WAT_Order field.
	''' </summary>
	Public Sub SetWAT_OrderFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WAT_OrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WAttach_Type_.WAT_Order field.
	''' </summary>
	Public Sub SetWAT_OrderFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WAT_OrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WAttach_Type_.WAT_Order field.
	''' </summary>
	Public Sub SetWAT_OrderFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WAT_OrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WAttach_Type_.WAT_Order field.
	''' </summary>
	Public Sub SetWAT_OrderFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WAT_OrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WAttach_Type_.WAT_Order field.
	''' </summary>
	Public Sub SetWAT_OrderFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WAT_OrderColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WAttach_Type_.WAT_ID field.
	''' </summary>
	Public Property WAT_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WAT_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WAT_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WAT_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WAT_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WAT_IDDefault() As String
        Get
            Return TableUtils.WAT_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WAttach_Type_.WAT_Name field.
	''' </summary>
	Public Property WAT_Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WAT_NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WAT_NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WAT_NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WAT_NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WAT_NameDefault() As String
        Get
            Return TableUtils.WAT_NameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WAttach_Type_.WAT_Operation field.
	''' </summary>
	Public Property WAT_Operation() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WAT_OperationColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WAT_OperationColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WAT_OperationSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WAT_OperationColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WAT_OperationDefault() As String
        Get
            Return TableUtils.WAT_OperationColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WAttach_Type_.WAT_Order field.
	''' </summary>
	Public Property WAT_Order() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WAT_OrderColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WAT_OrderColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WAT_OrderSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WAT_OrderColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WAT_OrderDefault() As String
        Get
            Return TableUtils.WAT_OrderColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
