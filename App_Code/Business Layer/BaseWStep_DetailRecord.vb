' This class is "generated" and will be overwritten.
' Your customizations should be made in WStep_DetailRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WStep_DetailRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WStep_DetailTable"></see> class.
''' </remarks>
''' <seealso cref="WStep_DetailTable"></seealso>
''' <seealso cref="WStep_DetailRecord"></seealso>

<Serializable()> Public Class BaseWStep_DetailRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WStep_DetailTable = WStep_DetailTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WStep_DetailRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WStep_DetailRec As WStep_DetailRecord = CType(sender,WStep_DetailRecord)
        Validate_Inserting()
        If Not WStep_DetailRec Is Nothing AndAlso Not WStep_DetailRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WStep_DetailRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WStep_DetailRec As WStep_DetailRecord = CType(sender,WStep_DetailRecord)
        Validate_Updating()
        If Not WStep_DetailRec Is Nothing AndAlso Not WStep_DetailRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WStep_DetailRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WStep_DetailRec As WStep_DetailRecord = CType(sender,WStep_DetailRecord)
        If Not WStep_DetailRec Is Nothing AndAlso Not WStep_DetailRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_ID field.
	''' </summary>
	Public Function GetWSD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WSD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_ID field.
	''' </summary>
	Public Function GetWSD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WSD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_WS_ID field.
	''' </summary>
	Public Function GetWSD_WS_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WSD_WS_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_WS_ID field.
	''' </summary>
	Public Function GetWSD_WS_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WSD_WS_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_WS_ID field.
	''' </summary>
	Public Sub SetWSD_WS_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WSD_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_WS_ID field.
	''' </summary>
	Public Sub SetWSD_WS_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WSD_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_WS_ID field.
	''' </summary>
	Public Sub SetWSD_WS_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WSD_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_WS_ID field.
	''' </summary>
	Public Sub SetWSD_WS_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WSD_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_WS_ID field.
	''' </summary>
	Public Sub SetWSD_WS_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WSD_WS_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_W_U_ID field.
	''' </summary>
	Public Function GetWSD_W_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WSD_W_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_W_U_ID field.
	''' </summary>
	Public Function GetWSD_W_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WSD_W_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_W_U_ID field.
	''' </summary>
	Public Sub SetWSD_W_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WSD_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_W_U_ID field.
	''' </summary>
	Public Sub SetWSD_W_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WSD_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_W_U_ID field.
	''' </summary>
	Public Sub SetWSD_W_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WSD_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_W_U_ID field.
	''' </summary>
	Public Sub SetWSD_W_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WSD_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_W_U_ID field.
	''' </summary>
	Public Sub SetWSD_W_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WSD_W_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_Desc field.
	''' </summary>
	Public Function GetWSD_DescValue() As ColumnValue
		Return Me.GetValue(TableUtils.WSD_DescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_Desc field.
	''' </summary>
	Public Function GetWSD_DescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WSD_DescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_Desc field.
	''' </summary>
	Public Sub SetWSD_DescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WSD_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_Desc field.
	''' </summary>
	Public Sub SetWSD_DescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WSD_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_Status field.
	''' </summary>
	Public Function GetWSD_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WSD_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_Status field.
	''' </summary>
	Public Function GetWSD_StatusFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WSD_StatusColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_Status field.
	''' </summary>
	Public Sub SetWSD_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WSD_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_Status field.
	''' </summary>
	Public Sub SetWSD_StatusFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WSD_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_Variable_Ref field.
	''' </summary>
	Public Function GetWSD_Variable_RefValue() As ColumnValue
		Return Me.GetValue(TableUtils.WSD_Variable_RefColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_Variable_Ref field.
	''' </summary>
	Public Function GetWSD_Variable_RefFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WSD_Variable_RefColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_Variable_Ref field.
	''' </summary>
	Public Sub SetWSD_Variable_RefFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WSD_Variable_RefColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_Variable_Ref field.
	''' </summary>
	Public Sub SetWSD_Variable_RefFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WSD_Variable_RefColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_Variable_Ref field.
	''' </summary>
	Public Sub SetWSD_Variable_RefFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WSD_Variable_RefColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_Variable_Ref field.
	''' </summary>
	Public Sub SetWSD_Variable_RefFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WSD_Variable_RefColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_Variable_Ref field.
	''' </summary>
	Public Sub SetWSD_Variable_RefFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WSD_Variable_RefColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_Variable_SQL field.
	''' </summary>
	Public Function GetWSD_Variable_SQLValue() As ColumnValue
		Return Me.GetValue(TableUtils.WSD_Variable_SQLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_Variable_SQL field.
	''' </summary>
	Public Function GetWSD_Variable_SQLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WSD_Variable_SQLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_Variable_SQL field.
	''' </summary>
	Public Sub SetWSD_Variable_SQLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WSD_Variable_SQLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_Variable_SQL field.
	''' </summary>
	Public Sub SetWSD_Variable_SQLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WSD_Variable_SQLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_Expire field.
	''' </summary>
	Public Function GetWSD_ExpireValue() As ColumnValue
		Return Me.GetValue(TableUtils.WSD_ExpireColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_Expire field.
	''' </summary>
	Public Function GetWSD_ExpireFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WSD_ExpireColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_Expire field.
	''' </summary>
	Public Sub SetWSD_ExpireFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WSD_ExpireColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_Expire field.
	''' </summary>
	Public Sub SetWSD_ExpireFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WSD_ExpireColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_Expire field.
	''' </summary>
	Public Sub SetWSD_ExpireFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WSD_ExpireColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_Expire field.
	''' </summary>
	Public Sub SetWSD_ExpireFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WSD_ExpireColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_Expire field.
	''' </summary>
	Public Sub SetWSD_ExpireFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WSD_ExpireColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_W_U_ID_Delegate field.
	''' </summary>
	Public Function GetWSD_W_U_ID_DelegateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WSD_W_U_ID_DelegateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_W_U_ID_Delegate field.
	''' </summary>
	Public Function GetWSD_W_U_ID_DelegateFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WSD_W_U_ID_DelegateColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWSD_W_U_ID_DelegateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WSD_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWSD_W_U_ID_DelegateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WSD_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWSD_W_U_ID_DelegateFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WSD_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWSD_W_U_ID_DelegateFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WSD_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWSD_W_U_ID_DelegateFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WSD_W_U_ID_DelegateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_Is_Escalate field.
	''' </summary>
	Public Function GetWSD_Is_EscalateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WSD_Is_EscalateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WStep_Detail_.WSD_Is_Escalate field.
	''' </summary>
	Public Function GetWSD_Is_EscalateFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WSD_Is_EscalateColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_Is_Escalate field.
	''' </summary>
	Public Sub SetWSD_Is_EscalateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WSD_Is_EscalateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_Is_Escalate field.
	''' </summary>
	Public Sub SetWSD_Is_EscalateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WSD_Is_EscalateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WStep_Detail_.WSD_Is_Escalate field.
	''' </summary>
	Public Sub SetWSD_Is_EscalateFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WSD_Is_EscalateColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WStep_Detail_.WSD_ID field.
	''' </summary>
	Public Property WSD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WSD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WSD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WSD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WSD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WSD_IDDefault() As String
        Get
            Return TableUtils.WSD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WStep_Detail_.WSD_WS_ID field.
	''' </summary>
	Public Property WSD_WS_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WSD_WS_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WSD_WS_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WSD_WS_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WSD_WS_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WSD_WS_IDDefault() As String
        Get
            Return TableUtils.WSD_WS_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WStep_Detail_.WSD_W_U_ID field.
	''' </summary>
	Public Property WSD_W_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WSD_W_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WSD_W_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WSD_W_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WSD_W_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WSD_W_U_IDDefault() As String
        Get
            Return TableUtils.WSD_W_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WStep_Detail_.WSD_Desc field.
	''' </summary>
	Public Property WSD_Desc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WSD_DescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WSD_DescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WSD_DescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WSD_DescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WSD_DescDefault() As String
        Get
            Return TableUtils.WSD_DescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WStep_Detail_.WSD_Status field.
	''' </summary>
	Public Property WSD_Status() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WSD_StatusColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WSD_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WSD_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WSD_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WSD_StatusDefault() As String
        Get
            Return TableUtils.WSD_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WStep_Detail_.WSD_Variable_Ref field.
	''' </summary>
	Public Property WSD_Variable_Ref() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WSD_Variable_RefColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WSD_Variable_RefColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WSD_Variable_RefSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WSD_Variable_RefColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WSD_Variable_RefDefault() As String
        Get
            Return TableUtils.WSD_Variable_RefColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WStep_Detail_.WSD_Variable_SQL field.
	''' </summary>
	Public Property WSD_Variable_SQL() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WSD_Variable_SQLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WSD_Variable_SQLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WSD_Variable_SQLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WSD_Variable_SQLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WSD_Variable_SQLDefault() As String
        Get
            Return TableUtils.WSD_Variable_SQLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WStep_Detail_.WSD_Expire field.
	''' </summary>
	Public Property WSD_Expire() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WSD_ExpireColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WSD_ExpireColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WSD_ExpireSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WSD_ExpireColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WSD_ExpireDefault() As String
        Get
            Return TableUtils.WSD_ExpireColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WStep_Detail_.WSD_W_U_ID_Delegate field.
	''' </summary>
	Public Property WSD_W_U_ID_Delegate() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WSD_W_U_ID_DelegateColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WSD_W_U_ID_DelegateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WSD_W_U_ID_DelegateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WSD_W_U_ID_DelegateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WSD_W_U_ID_DelegateDefault() As String
        Get
            Return TableUtils.WSD_W_U_ID_DelegateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WStep_Detail_.WSD_Is_Escalate field.
	''' </summary>
	Public Property WSD_Is_Escalate() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WSD_Is_EscalateColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WSD_Is_EscalateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WSD_Is_EscalateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WSD_Is_EscalateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WSD_Is_EscalateDefault() As String
        Get
            Return TableUtils.WSD_Is_EscalateColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
