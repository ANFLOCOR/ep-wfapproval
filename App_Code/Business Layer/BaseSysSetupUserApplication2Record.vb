' This class is "generated" and will be overwritten.
' Your customizations should be made in SysSetupUserApplication2Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="SysSetupUserApplication2Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="SysSetupUserApplication2Table"></see> class.
''' </remarks>
''' <seealso cref="SysSetupUserApplication2Table"></seealso>
''' <seealso cref="SysSetupUserApplication2Record"></seealso>

<Serializable()> Public Class BaseSysSetupUserApplication2Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As SysSetupUserApplication2Table = SysSetupUserApplication2Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub SysSetupUserApplication2Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim SysSetupUserApplication2Rec As SysSetupUserApplication2Record = CType(sender,SysSetupUserApplication2Record)
        Validate_Inserting()
        If Not SysSetupUserApplication2Rec Is Nothing AndAlso Not SysSetupUserApplication2Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub SysSetupUserApplication2Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim SysSetupUserApplication2Rec As SysSetupUserApplication2Record = CType(sender,SysSetupUserApplication2Record)
        Validate_Updating()
        If Not SysSetupUserApplication2Rec Is Nothing AndAlso Not SysSetupUserApplication2Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub SysSetupUserApplication2Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim SysSetupUserApplication2Rec As SysSetupUserApplication2Record = CType(sender,SysSetupUserApplication2Record)
        If Not SysSetupUserApplication2Rec Is Nothing AndAlso Not SysSetupUserApplication2Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserApplication_.SSUA_SSU_UserName field.
	''' </summary>
	Public Function GetSSUA_SSU_UserNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUA_SSU_UserNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserApplication_.SSUA_SSU_UserName field.
	''' </summary>
	Public Function GetSSUA_SSU_UserNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSUA_SSU_UserNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserApplication_.SSUA_SSU_UserName field.
	''' </summary>
	Public Sub SetSSUA_SSU_UserNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUA_SSU_UserNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserApplication_.SSUA_SSU_UserName field.
	''' </summary>
	Public Sub SetSSUA_SSU_UserNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUA_SSU_UserNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserApplication_.SSUA_App_ID field.
	''' </summary>
	Public Function GetSSUA_App_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUA_App_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserApplication_.SSUA_App_ID field.
	''' </summary>
	Public Function GetSSUA_App_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSUA_App_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserApplication_.SSUA_App_ID field.
	''' </summary>
	Public Sub SetSSUA_App_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUA_App_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserApplication_.SSUA_App_ID field.
	''' </summary>
	Public Sub SetSSUA_App_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUA_App_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserApplication_.SSUA_App_ID field.
	''' </summary>
	Public Sub SetSSUA_App_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUA_App_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserApplication_.SSUA_App_ID field.
	''' </summary>
	Public Sub SetSSUA_App_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUA_App_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserApplication_.SSUA_App_ID field.
	''' </summary>
	Public Sub SetSSUA_App_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUA_App_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserApplication_.SSUA_DateCreated field.
	''' </summary>
	Public Function GetSSUA_DateCreatedValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUA_DateCreatedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserApplication_.SSUA_DateCreated field.
	''' </summary>
	Public Function GetSSUA_DateCreatedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.SSUA_DateCreatedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserApplication_.SSUA_DateCreated field.
	''' </summary>
	Public Sub SetSSUA_DateCreatedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUA_DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserApplication_.SSUA_DateCreated field.
	''' </summary>
	Public Sub SetSSUA_DateCreatedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUA_DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserApplication_.SSUA_DateCreated field.
	''' </summary>
	Public Sub SetSSUA_DateCreatedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUA_DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserApplication_.SSUA_RowID field.
	''' </summary>
	Public Function GetSSUA_RowIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUA_RowIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserApplication_.SSUA_RowID field.
	''' </summary>
	Public Function GetSSUA_RowIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSUA_RowIDColumn).ToInt32(), Int32)
	End Function



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUserApplication_.SSUA_SSU_UserName field.
	''' </summary>
	Public Property SSUA_SSU_UserName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SSUA_SSU_UserNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SSUA_SSU_UserNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUA_SSU_UserNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUA_SSU_UserNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUA_SSU_UserNameDefault() As String
        Get
            Return TableUtils.SSUA_SSU_UserNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUserApplication_.SSUA_App_ID field.
	''' </summary>
	Public Property SSUA_App_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SSUA_App_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSUA_App_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUA_App_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUA_App_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUA_App_IDDefault() As String
        Get
            Return TableUtils.SSUA_App_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUserApplication_.SSUA_DateCreated field.
	''' </summary>
	Public Property SSUA_DateCreated() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.SSUA_DateCreatedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSUA_DateCreatedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUA_DateCreatedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUA_DateCreatedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUA_DateCreatedDefault() As String
        Get
            Return TableUtils.SSUA_DateCreatedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUserApplication_.SSUA_RowID field.
	''' </summary>
	Public Property SSUA_RowID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SSUA_RowIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSUA_RowIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUA_RowIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUA_RowIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUA_RowIDDefault() As String
        Get
            Return TableUtils.SSUA_RowIDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
