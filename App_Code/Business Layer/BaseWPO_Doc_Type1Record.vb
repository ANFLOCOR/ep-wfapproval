' This class is "generated" and will be overwritten.
' Your customizations should be made in WPO_Doc_Type1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WPO_Doc_Type1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WPO_Doc_Type1Table"></see> class.
''' </remarks>
''' <seealso cref="WPO_Doc_Type1Table"></seealso>
''' <seealso cref="WPO_Doc_Type1Record"></seealso>

<Serializable()> Public Class BaseWPO_Doc_Type1Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WPO_Doc_Type1Table = WPO_Doc_Type1Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WPO_Doc_Type1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WPO_Doc_Type1Rec As WPO_Doc_Type1Record = CType(sender,WPO_Doc_Type1Record)
        Validate_Inserting()
        If Not WPO_Doc_Type1Rec Is Nothing AndAlso Not WPO_Doc_Type1Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WPO_Doc_Type1Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WPO_Doc_Type1Rec As WPO_Doc_Type1Record = CType(sender,WPO_Doc_Type1Record)
        Validate_Updating()
        If Not WPO_Doc_Type1Rec Is Nothing AndAlso Not WPO_Doc_Type1Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WPO_Doc_Type1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WPO_Doc_Type1Rec As WPO_Doc_Type1Record = CType(sender,WPO_Doc_Type1Record)
        If Not WPO_Doc_Type1Rec Is Nothing AndAlso Not WPO_Doc_Type1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_ID field.
	''' </summary>
	Public Function GetWPO_DT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_DT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_ID field.
	''' </summary>
	Public Function GetWPO_DT_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPO_DT_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_C_ID field.
	''' </summary>
	Public Function GetWPO_DT_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_DT_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_C_ID field.
	''' </summary>
	Public Function GetWPO_DT_C_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WPO_DT_C_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_C_ID field.
	''' </summary>
	Public Sub SetWPO_DT_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_DT_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_C_ID field.
	''' </summary>
	Public Sub SetWPO_DT_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_DT_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_C_ID field.
	''' </summary>
	Public Sub SetWPO_DT_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_DT_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_C_ID field.
	''' </summary>
	Public Sub SetWPO_DT_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_DT_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_C_ID field.
	''' </summary>
	Public Sub SetWPO_DT_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_DT_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_Name field.
	''' </summary>
	Public Function GetWPO_DT_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_DT_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_Name field.
	''' </summary>
	Public Function GetWPO_DT_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPO_DT_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Name field.
	''' </summary>
	Public Sub SetWPO_DT_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_DT_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Name field.
	''' </summary>
	Public Sub SetWPO_DT_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_DT_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_Desc field.
	''' </summary>
	Public Function GetWPO_DT_DescValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_DT_DescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_Desc field.
	''' </summary>
	Public Function GetWPO_DT_DescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPO_DT_DescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Desc field.
	''' </summary>
	Public Sub SetWPO_DT_DescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_DT_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Desc field.
	''' </summary>
	Public Sub SetWPO_DT_DescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_DT_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_Type field.
	''' </summary>
	Public Function GetWPO_DT_TypeValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_DT_TypeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_Type field.
	''' </summary>
	Public Function GetWPO_DT_TypeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPO_DT_TypeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Type field.
	''' </summary>
	Public Sub SetWPO_DT_TypeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_DT_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Type field.
	''' </summary>
	Public Sub SetWPO_DT_TypeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_DT_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_Minimum field.
	''' </summary>
	Public Function GetWPO_DT_MinimumValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_DT_MinimumColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_Minimum field.
	''' </summary>
	Public Function GetWPO_DT_MinimumFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WPO_DT_MinimumColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Minimum field.
	''' </summary>
	Public Sub SetWPO_DT_MinimumFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_DT_MinimumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Minimum field.
	''' </summary>
	Public Sub SetWPO_DT_MinimumFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_DT_MinimumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Minimum field.
	''' </summary>
	Public Sub SetWPO_DT_MinimumFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_DT_MinimumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Minimum field.
	''' </summary>
	Public Sub SetWPO_DT_MinimumFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_DT_MinimumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Minimum field.
	''' </summary>
	Public Sub SetWPO_DT_MinimumFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_DT_MinimumColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_Maximum field.
	''' </summary>
	Public Function GetWPO_DT_MaximumValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_DT_MaximumColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_Maximum field.
	''' </summary>
	Public Function GetWPO_DT_MaximumFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WPO_DT_MaximumColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Maximum field.
	''' </summary>
	Public Sub SetWPO_DT_MaximumFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_DT_MaximumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Maximum field.
	''' </summary>
	Public Sub SetWPO_DT_MaximumFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_DT_MaximumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Maximum field.
	''' </summary>
	Public Sub SetWPO_DT_MaximumFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_DT_MaximumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Maximum field.
	''' </summary>
	Public Sub SetWPO_DT_MaximumFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_DT_MaximumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Maximum field.
	''' </summary>
	Public Sub SetWPO_DT_MaximumFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_DT_MaximumColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_Limit field.
	''' </summary>
	Public Function GetWPO_DT_LimitValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_DT_LimitColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_Limit field.
	''' </summary>
	Public Function GetWPO_DT_LimitFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WPO_DT_LimitColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Limit field.
	''' </summary>
	Public Sub SetWPO_DT_LimitFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_DT_LimitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Limit field.
	''' </summary>
	Public Sub SetWPO_DT_LimitFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_DT_LimitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Limit field.
	''' </summary>
	Public Sub SetWPO_DT_LimitFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_DT_LimitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Limit field.
	''' </summary>
	Public Sub SetWPO_DT_LimitFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_DT_LimitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Doc_Type_.WPO_DT_Limit field.
	''' </summary>
	Public Sub SetWPO_DT_LimitFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_DT_LimitColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_ID field.
	''' </summary>
	Public Property WPO_DT_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_DT_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_DT_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_DT_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_DT_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_DT_IDDefault() As String
        Get
            Return TableUtils.WPO_DT_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_C_ID field.
	''' </summary>
	Public Property WPO_DT_C_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_DT_C_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_DT_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_DT_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_DT_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_DT_C_IDDefault() As String
        Get
            Return TableUtils.WPO_DT_C_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_Name field.
	''' </summary>
	Public Property WPO_DT_Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_DT_NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPO_DT_NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_DT_NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_DT_NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_DT_NameDefault() As String
        Get
            Return TableUtils.WPO_DT_NameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_Desc field.
	''' </summary>
	Public Property WPO_DT_Desc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_DT_DescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPO_DT_DescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_DT_DescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_DT_DescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_DT_DescDefault() As String
        Get
            Return TableUtils.WPO_DT_DescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_Type field.
	''' </summary>
	Public Property WPO_DT_Type() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_DT_TypeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPO_DT_TypeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_DT_TypeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_DT_TypeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_DT_TypeDefault() As String
        Get
            Return TableUtils.WPO_DT_TypeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_Minimum field.
	''' </summary>
	Public Property WPO_DT_Minimum() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_DT_MinimumColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_DT_MinimumColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_DT_MinimumSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_DT_MinimumColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_DT_MinimumDefault() As String
        Get
            Return TableUtils.WPO_DT_MinimumColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_Maximum field.
	''' </summary>
	Public Property WPO_DT_Maximum() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_DT_MaximumColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_DT_MaximumColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_DT_MaximumSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_DT_MaximumColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_DT_MaximumDefault() As String
        Get
            Return TableUtils.WPO_DT_MaximumColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Doc_Type_.WPO_DT_Limit field.
	''' </summary>
	Public Property WPO_DT_Limit() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_DT_LimitColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_DT_LimitColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_DT_LimitSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_DT_LimitColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_DT_LimitDefault() As String
        Get
            Return TableUtils.WPO_DT_LimitColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
