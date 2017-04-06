' This class is "generated" and will be overwritten.
' Your customizations should be made in WTask_DelegationRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WTask_DelegationRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WTask_DelegationTable"></see> class.
''' </remarks>
''' <seealso cref="WTask_DelegationTable"></seealso>
''' <seealso cref="WTask_DelegationRecord"></seealso>

<Serializable()> Public Class BaseWTask_DelegationRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WTask_DelegationTable = WTask_DelegationTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WTask_DelegationRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WTask_DelegationRec As WTask_DelegationRecord = CType(sender,WTask_DelegationRecord)
        Validate_Inserting()
        If Not WTask_DelegationRec Is Nothing AndAlso Not WTask_DelegationRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WTask_DelegationRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WTask_DelegationRec As WTask_DelegationRecord = CType(sender,WTask_DelegationRecord)
        Validate_Updating()
        If Not WTask_DelegationRec Is Nothing AndAlso Not WTask_DelegationRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WTask_DelegationRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WTask_DelegationRec As WTask_DelegationRecord = CType(sender,WTask_DelegationRecord)
        If Not WTask_DelegationRec Is Nothing AndAlso Not WTask_DelegationRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WTask_Delegation_.WTD_ID field.
	''' </summary>
	Public Function GetWTD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WTD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WTask_Delegation_.WTD_ID field.
	''' </summary>
	Public Function GetWTD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WTD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WTask_Delegation_.WTD_W_U_ID field.
	''' </summary>
	Public Function GetWTD_W_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WTD_W_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WTask_Delegation_.WTD_W_U_ID field.
	''' </summary>
	Public Function GetWTD_W_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WTD_W_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_W_U_ID field.
	''' </summary>
	Public Sub SetWTD_W_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WTD_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_W_U_ID field.
	''' </summary>
	Public Sub SetWTD_W_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WTD_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_W_U_ID field.
	''' </summary>
	Public Sub SetWTD_W_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WTD_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_W_U_ID field.
	''' </summary>
	Public Sub SetWTD_W_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WTD_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_W_U_ID field.
	''' </summary>
	Public Sub SetWTD_W_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WTD_W_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WTask_Delegation_.WTD_W_U_ID_Delegate field.
	''' </summary>
	Public Function GetWTD_W_U_ID_DelegateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WTD_W_U_ID_DelegateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WTask_Delegation_.WTD_W_U_ID_Delegate field.
	''' </summary>
	Public Function GetWTD_W_U_ID_DelegateFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WTD_W_U_ID_DelegateColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWTD_W_U_ID_DelegateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WTD_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWTD_W_U_ID_DelegateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WTD_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWTD_W_U_ID_DelegateFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WTD_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWTD_W_U_ID_DelegateFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WTD_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWTD_W_U_ID_DelegateFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WTD_W_U_ID_DelegateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WTask_Delegation_.WTD_WDT_Type field.
	''' </summary>
	Public Function GetWTD_WDT_TypeValue() As ColumnValue
		Return Me.GetValue(TableUtils.WTD_WDT_TypeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WTask_Delegation_.WTD_WDT_Type field.
	''' </summary>
	Public Function GetWTD_WDT_TypeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WTD_WDT_TypeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_WDT_Type field.
	''' </summary>
	Public Sub SetWTD_WDT_TypeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WTD_WDT_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_WDT_Type field.
	''' </summary>
	Public Sub SetWTD_WDT_TypeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WTD_WDT_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WTask_Delegation_.WTD_From field.
	''' </summary>
	Public Function GetWTD_FromValue() As ColumnValue
		Return Me.GetValue(TableUtils.WTD_FromColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WTask_Delegation_.WTD_From field.
	''' </summary>
	Public Function GetWTD_FromFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WTD_FromColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_From field.
	''' </summary>
	Public Sub SetWTD_FromFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WTD_FromColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_From field.
	''' </summary>
	Public Sub SetWTD_FromFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WTD_FromColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_From field.
	''' </summary>
	Public Sub SetWTD_FromFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WTD_FromColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WTask_Delegation_.WTD_To field.
	''' </summary>
	Public Function GetWTD_ToValue() As ColumnValue
		Return Me.GetValue(TableUtils.WTD_ToColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WTask_Delegation_.WTD_To field.
	''' </summary>
	Public Function GetWTD_ToFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WTD_ToColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_To field.
	''' </summary>
	Public Sub SetWTD_ToFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WTD_ToColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_To field.
	''' </summary>
	Public Sub SetWTD_ToFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WTD_ToColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_To field.
	''' </summary>
	Public Sub SetWTD_ToFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WTD_ToColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WTask_Delegation_.WTD_C_ID field.
	''' </summary>
	Public Function GetWTD_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WTD_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WTask_Delegation_.WTD_C_ID field.
	''' </summary>
	Public Function GetWTD_C_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WTD_C_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_C_ID field.
	''' </summary>
	Public Sub SetWTD_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WTD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_C_ID field.
	''' </summary>
	Public Sub SetWTD_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WTD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_C_ID field.
	''' </summary>
	Public Sub SetWTD_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WTD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_C_ID field.
	''' </summary>
	Public Sub SetWTD_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WTD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WTask_Delegation_.WTD_C_ID field.
	''' </summary>
	Public Sub SetWTD_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WTD_C_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WTask_Delegation_.WTD_ID field.
	''' </summary>
	Public Property WTD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WTD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WTD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WTD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WTD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WTD_IDDefault() As String
        Get
            Return TableUtils.WTD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WTask_Delegation_.WTD_W_U_ID field.
	''' </summary>
	Public Property WTD_W_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WTD_W_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WTD_W_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WTD_W_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WTD_W_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WTD_W_U_IDDefault() As String
        Get
            Return TableUtils.WTD_W_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WTask_Delegation_.WTD_W_U_ID_Delegate field.
	''' </summary>
	Public Property WTD_W_U_ID_Delegate() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WTD_W_U_ID_DelegateColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WTD_W_U_ID_DelegateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WTD_W_U_ID_DelegateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WTD_W_U_ID_DelegateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WTD_W_U_ID_DelegateDefault() As String
        Get
            Return TableUtils.WTD_W_U_ID_DelegateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WTask_Delegation_.WTD_WDT_Type field.
	''' </summary>
	Public Property WTD_WDT_Type() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WTD_WDT_TypeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WTD_WDT_TypeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WTD_WDT_TypeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WTD_WDT_TypeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WTD_WDT_TypeDefault() As String
        Get
            Return TableUtils.WTD_WDT_TypeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WTask_Delegation_.WTD_From field.
	''' </summary>
	Public Property WTD_From() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WTD_FromColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WTD_FromColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WTD_FromSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WTD_FromColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WTD_FromDefault() As String
        Get
            Return TableUtils.WTD_FromColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WTask_Delegation_.WTD_To field.
	''' </summary>
	Public Property WTD_To() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WTD_ToColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WTD_ToColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WTD_ToSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WTD_ToColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WTD_ToDefault() As String
        Get
            Return TableUtils.WTD_ToColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WTask_Delegation_.WTD_C_ID field.
	''' </summary>
	Public Property WTD_C_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WTD_C_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WTD_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WTD_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WTD_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WTD_C_IDDefault() As String
        Get
            Return TableUtils.WTD_C_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
