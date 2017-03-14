' This class is "generated" and will be overwritten.
' Your customizations should be made in WStep1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WStep1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WStep1Table"></see> class.
''' </remarks>
''' <seealso cref="WStep1Table"></seealso>
''' <seealso cref="WStep1Record"></seealso>

<Serializable()> Public Class BaseWStep1Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WStep1Table = WStep1Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WStep1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WStep1Rec As WStep1Record = CType(sender,WStep1Record)
        Validate_Inserting()
        If Not WStep1Rec Is Nothing AndAlso Not WStep1Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WStep1Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WStep1Rec As WStep1Record = CType(sender,WStep1Record)
        Validate_Updating()
        If Not WStep1Rec Is Nothing AndAlso Not WStep1Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WStep1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WStep1Rec As WStep1Record = CType(sender,WStep1Record)
        If Not WStep1Rec Is Nothing AndAlso Not WStep1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WStep_.WS_ID field.
	''' </summary>
	Public Function GetWS_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WS_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_.WS_ID field.
	''' </summary>
	Public Function GetWS_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WS_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_.WS_WDT_ID field.
	''' </summary>
	Public Function GetWS_WDT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WS_WDT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_.WS_WDT_ID field.
	''' </summary>
	Public Function GetWS_WDT_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WS_WDT_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_WDT_ID field.
	''' </summary>
	Public Sub SetWS_WDT_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WS_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_WDT_ID field.
	''' </summary>
	Public Sub SetWS_WDT_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WS_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_WDT_ID field.
	''' </summary>
	Public Sub SetWS_WDT_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WS_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_WDT_ID field.
	''' </summary>
	Public Sub SetWS_WDT_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WS_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_WDT_ID field.
	''' </summary>
	Public Sub SetWS_WDT_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WS_WDT_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_.WS_ID_Next field.
	''' </summary>
	Public Function GetWS_ID_NextValue() As ColumnValue
		Return Me.GetValue(TableUtils.WS_ID_NextColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_.WS_ID_Next field.
	''' </summary>
	Public Function GetWS_ID_NextFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WS_ID_NextColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_ID_Next field.
	''' </summary>
	Public Sub SetWS_ID_NextFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WS_ID_NextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_ID_Next field.
	''' </summary>
	Public Sub SetWS_ID_NextFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WS_ID_NextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_ID_Next field.
	''' </summary>
	Public Sub SetWS_ID_NextFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WS_ID_NextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_ID_Next field.
	''' </summary>
	Public Sub SetWS_ID_NextFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WS_ID_NextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_ID_Next field.
	''' </summary>
	Public Sub SetWS_ID_NextFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WS_ID_NextColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_.WS_Step_Type field.
	''' </summary>
	Public Function GetWS_Step_TypeValue() As ColumnValue
		Return Me.GetValue(TableUtils.WS_Step_TypeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_.WS_Step_Type field.
	''' </summary>
	Public Function GetWS_Step_TypeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WS_Step_TypeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_Step_Type field.
	''' </summary>
	Public Sub SetWS_Step_TypeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WS_Step_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_Step_Type field.
	''' </summary>
	Public Sub SetWS_Step_TypeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WS_Step_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_.WS_Desc field.
	''' </summary>
	Public Function GetWS_DescValue() As ColumnValue
		Return Me.GetValue(TableUtils.WS_DescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_.WS_Desc field.
	''' </summary>
	Public Function GetWS_DescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WS_DescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_Desc field.
	''' </summary>
	Public Sub SetWS_DescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WS_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_Desc field.
	''' </summary>
	Public Sub SetWS_DescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WS_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_.WS_Approval_Needed field.
	''' </summary>
	Public Function GetWS_Approval_NeededValue() As ColumnValue
		Return Me.GetValue(TableUtils.WS_Approval_NeededColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_.WS_Approval_Needed field.
	''' </summary>
	Public Function GetWS_Approval_NeededFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WS_Approval_NeededColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_Approval_Needed field.
	''' </summary>
	Public Sub SetWS_Approval_NeededFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WS_Approval_NeededColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_Approval_Needed field.
	''' </summary>
	Public Sub SetWS_Approval_NeededFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WS_Approval_NeededColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_Approval_Needed field.
	''' </summary>
	Public Sub SetWS_Approval_NeededFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WS_Approval_NeededColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_Approval_Needed field.
	''' </summary>
	Public Sub SetWS_Approval_NeededFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WS_Approval_NeededColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_Approval_Needed field.
	''' </summary>
	Public Sub SetWS_Approval_NeededFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WS_Approval_NeededColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_.WS_C_ID field.
	''' </summary>
	Public Function GetWS_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WS_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_.WS_C_ID field.
	''' </summary>
	Public Function GetWS_C_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WS_C_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_C_ID field.
	''' </summary>
	Public Sub SetWS_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WS_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_C_ID field.
	''' </summary>
	Public Sub SetWS_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WS_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_C_ID field.
	''' </summary>
	Public Sub SetWS_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WS_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_C_ID field.
	''' </summary>
	Public Sub SetWS_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WS_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_.WS_C_ID field.
	''' </summary>
	Public Sub SetWS_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WS_C_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WStep_.WS_ID field.
	''' </summary>
	Public Property WS_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WS_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WS_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WS_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WS_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WS_IDDefault() As String
        Get
            Return TableUtils.WS_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WStep_.WS_WDT_ID field.
	''' </summary>
	Public Property WS_WDT_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WS_WDT_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WS_WDT_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WS_WDT_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WS_WDT_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WS_WDT_IDDefault() As String
        Get
            Return TableUtils.WS_WDT_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WStep_.WS_ID_Next field.
	''' </summary>
	Public Property WS_ID_Next() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WS_ID_NextColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WS_ID_NextColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WS_ID_NextSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WS_ID_NextColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WS_ID_NextDefault() As String
        Get
            Return TableUtils.WS_ID_NextColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WStep_.WS_Step_Type field.
	''' </summary>
	Public Property WS_Step_Type() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WS_Step_TypeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WS_Step_TypeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WS_Step_TypeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WS_Step_TypeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WS_Step_TypeDefault() As String
        Get
            Return TableUtils.WS_Step_TypeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WStep_.WS_Desc field.
	''' </summary>
	Public Property WS_Desc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WS_DescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WS_DescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WS_DescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WS_DescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WS_DescDefault() As String
        Get
            Return TableUtils.WS_DescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WStep_.WS_Approval_Needed field.
	''' </summary>
	Public Property WS_Approval_Needed() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WS_Approval_NeededColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WS_Approval_NeededColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WS_Approval_NeededSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WS_Approval_NeededColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WS_Approval_NeededDefault() As String
        Get
            Return TableUtils.WS_Approval_NeededColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WStep_.WS_C_ID field.
	''' </summary>
	Public Property WS_C_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WS_C_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WS_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WS_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WS_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WS_C_IDDefault() As String
        Get
            Return TableUtils.WS_C_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
