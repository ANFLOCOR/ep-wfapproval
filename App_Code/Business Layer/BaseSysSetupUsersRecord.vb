' This class is "generated" and will be overwritten.
' Your customizations should be made in SysSetupUsersRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="SysSetupUsersRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="SysSetupUsersTable"></see> class.
''' </remarks>
''' <seealso cref="SysSetupUsersTable"></seealso>
''' <seealso cref="SysSetupUsersRecord"></seealso>

<Serializable()> Public Class BaseSysSetupUsersRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As SysSetupUsersTable = SysSetupUsersTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub SysSetupUsersRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim SysSetupUsersRec As SysSetupUsersRecord = CType(sender,SysSetupUsersRecord)
        Validate_Inserting()
        If Not SysSetupUsersRec Is Nothing AndAlso Not SysSetupUsersRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub SysSetupUsersRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim SysSetupUsersRec As SysSetupUsersRecord = CType(sender,SysSetupUsersRecord)
        Validate_Updating()
        If Not SysSetupUsersRec Is Nothing AndAlso Not SysSetupUsersRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub SysSetupUsersRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim SysSetupUsersRec As SysSetupUsersRecord = CType(sender,SysSetupUsersRecord)
        If Not SysSetupUsersRec Is Nothing AndAlso Not SysSetupUsersRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_UserName field.
	''' </summary>
	Public Function GetSSU_UserNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_UserNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_UserName field.
	''' </summary>
	Public Function GetSSU_UserNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSU_UserNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_UserName field.
	''' </summary>
	Public Sub SetSSU_UserNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_UserNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_UserName field.
	''' </summary>
	Public Sub SetSSU_UserNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_UserNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_FullName field.
	''' </summary>
	Public Function GetSSU_FullNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_FullNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_FullName field.
	''' </summary>
	Public Function GetSSU_FullNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSU_FullNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_FullName field.
	''' </summary>
	Public Sub SetSSU_FullNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_FullNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_FullName field.
	''' </summary>
	Public Sub SetSSU_FullNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_FullNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_Password field.
	''' </summary>
	Public Function GetSSU_PasswordValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_PasswordColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_Password field.
	''' </summary>
	Public Function GetSSU_PasswordFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSU_PasswordColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_Password field.
	''' </summary>
	Public Sub SetSSU_PasswordFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_PasswordColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_Password field.
	''' </summary>
	Public Sub SetSSU_PasswordFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_PasswordColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_EmpID field.
	''' </summary>
	Public Function GetSSU_EmpIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_EmpIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_EmpID field.
	''' </summary>
	Public Function GetSSU_EmpIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSU_EmpIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_EmpID field.
	''' </summary>
	Public Sub SetSSU_EmpIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_EmpIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_EmpID field.
	''' </summary>
	Public Sub SetSSU_EmpIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSU_EmpIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_EmpID field.
	''' </summary>
	Public Sub SetSSU_EmpIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_EmpIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_EmpID field.
	''' </summary>
	Public Sub SetSSU_EmpIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_EmpIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_EmpID field.
	''' </summary>
	Public Sub SetSSU_EmpIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_EmpIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_SSC_CompanyID field.
	''' </summary>
	Public Function GetSSU_SSC_CompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_SSC_CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_SSC_CompanyID field.
	''' </summary>
	Public Function GetSSU_SSC_CompanyIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.SSU_SSC_CompanyIDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSU_SSC_CompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSU_SSC_CompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSU_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSU_SSC_CompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSU_SSC_CompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSU_SSC_CompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_SSC_CompanyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_IsActive field.
	''' </summary>
	Public Function GetSSU_IsActiveValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_IsActiveColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_IsActive field.
	''' </summary>
	Public Function GetSSU_IsActiveFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SSU_IsActiveColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_IsActive field.
	''' </summary>
	Public Sub SetSSU_IsActiveFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_IsActiveColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_IsActive field.
	''' </summary>
	Public Sub SetSSU_IsActiveFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSU_IsActiveColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_IsActive field.
	''' </summary>
	Public Sub SetSSU_IsActiveFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_IsActiveColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_DateCreated field.
	''' </summary>
	Public Function GetSSU_DateCreatedValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_DateCreatedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_DateCreated field.
	''' </summary>
	Public Function GetSSU_DateCreatedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.SSU_DateCreatedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_DateCreated field.
	''' </summary>
	Public Sub SetSSU_DateCreatedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_DateCreated field.
	''' </summary>
	Public Sub SetSSU_DateCreatedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSU_DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_DateCreated field.
	''' </summary>
	Public Sub SetSSU_DateCreatedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_DateModified field.
	''' </summary>
	Public Function GetSSU_DateModifiedValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_DateModifiedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_DateModified field.
	''' </summary>
	Public Function GetSSU_DateModifiedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.SSU_DateModifiedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_DateModified field.
	''' </summary>
	Public Sub SetSSU_DateModifiedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_DateModifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_DateModified field.
	''' </summary>
	Public Sub SetSSU_DateModifiedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSU_DateModifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_DateModified field.
	''' </summary>
	Public Sub SetSSU_DateModifiedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_DateModifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_RowID field.
	''' </summary>
	Public Function GetSSU_RowIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_RowIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_RowID field.
	''' </summary>
	Public Function GetSSU_RowIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSU_RowIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_GPUsername field.
	''' </summary>
	Public Function GetSSU_GPUsernameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_GPUsernameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_GPUsername field.
	''' </summary>
	Public Function GetSSU_GPUsernameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSU_GPUsernameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_GPUsername field.
	''' </summary>
	Public Sub SetSSU_GPUsernameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_GPUsernameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_GPUsername field.
	''' </summary>
	Public Sub SetSSU_GPUsernameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_GPUsernameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_Designation field.
	''' </summary>
	Public Function GetSSU_DesignationValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_DesignationColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUsers_.SSU_Designation field.
	''' </summary>
	Public Function GetSSU_DesignationFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSU_DesignationColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_Designation field.
	''' </summary>
	Public Sub SetSSU_DesignationFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_DesignationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUsers_.SSU_Designation field.
	''' </summary>
	Public Sub SetSSU_DesignationFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_DesignationColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUsers_.SSU_UserName field.
	''' </summary>
	Public Property SSU_UserName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SSU_UserNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SSU_UserNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSU_UserNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSU_UserNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSU_UserNameDefault() As String
        Get
            Return TableUtils.SSU_UserNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUsers_.SSU_FullName field.
	''' </summary>
	Public Property SSU_FullName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SSU_FullNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SSU_FullNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSU_FullNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSU_FullNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSU_FullNameDefault() As String
        Get
            Return TableUtils.SSU_FullNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUsers_.SSU_Password field.
	''' </summary>
	Public Property SSU_Password() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SSU_PasswordColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SSU_PasswordColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSU_PasswordSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSU_PasswordColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSU_PasswordDefault() As String
        Get
            Return TableUtils.SSU_PasswordColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUsers_.SSU_EmpID field.
	''' </summary>
	Public Property SSU_EmpID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SSU_EmpIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSU_EmpIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSU_EmpIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSU_EmpIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSU_EmpIDDefault() As String
        Get
            Return TableUtils.SSU_EmpIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUsers_.SSU_SSC_CompanyID field.
	''' </summary>
	Public Property SSU_SSC_CompanyID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.SSU_SSC_CompanyIDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSU_SSC_CompanyIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSU_SSC_CompanyIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSU_SSC_CompanyIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSU_SSC_CompanyIDDefault() As String
        Get
            Return TableUtils.SSU_SSC_CompanyIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUsers_.SSU_IsActive field.
	''' </summary>
	Public Property SSU_IsActive() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SSU_IsActiveColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSU_IsActiveColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSU_IsActiveSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSU_IsActiveColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSU_IsActiveDefault() As String
        Get
            Return TableUtils.SSU_IsActiveColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUsers_.SSU_DateCreated field.
	''' </summary>
	Public Property SSU_DateCreated() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.SSU_DateCreatedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSU_DateCreatedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSU_DateCreatedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSU_DateCreatedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSU_DateCreatedDefault() As String
        Get
            Return TableUtils.SSU_DateCreatedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUsers_.SSU_DateModified field.
	''' </summary>
	Public Property SSU_DateModified() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.SSU_DateModifiedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSU_DateModifiedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSU_DateModifiedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSU_DateModifiedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSU_DateModifiedDefault() As String
        Get
            Return TableUtils.SSU_DateModifiedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUsers_.SSU_RowID field.
	''' </summary>
	Public Property SSU_RowID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SSU_RowIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSU_RowIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSU_RowIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSU_RowIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSU_RowIDDefault() As String
        Get
            Return TableUtils.SSU_RowIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUsers_.SSU_GPUsername field.
	''' </summary>
	Public Property SSU_GPUsername() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SSU_GPUsernameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SSU_GPUsernameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSU_GPUsernameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSU_GPUsernameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSU_GPUsernameDefault() As String
        Get
            Return TableUtils.SSU_GPUsernameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUsers_.SSU_Designation field.
	''' </summary>
	Public Property SSU_Designation() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SSU_DesignationColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SSU_DesignationColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSU_DesignationSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSU_DesignationColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSU_DesignationDefault() As String
        Get
            Return TableUtils.SSU_DesignationColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
