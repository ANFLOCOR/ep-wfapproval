' This class is "generated" and will be overwritten.
' Your customizations should be made in SysSetupUserPermissionRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="SysSetupUserPermissionRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="SysSetupUserPermissionTable"></see> class.
''' </remarks>
''' <seealso cref="SysSetupUserPermissionTable"></seealso>
''' <seealso cref="SysSetupUserPermissionRecord"></seealso>

<Serializable()> Public Class BaseSysSetupUserPermissionRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As SysSetupUserPermissionTable = SysSetupUserPermissionTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub SysSetupUserPermissionRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim SysSetupUserPermissionRec As SysSetupUserPermissionRecord = CType(sender,SysSetupUserPermissionRecord)
        Validate_Inserting()
        If Not SysSetupUserPermissionRec Is Nothing AndAlso Not SysSetupUserPermissionRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub SysSetupUserPermissionRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim SysSetupUserPermissionRec As SysSetupUserPermissionRecord = CType(sender,SysSetupUserPermissionRecord)
        Validate_Updating()
        If Not SysSetupUserPermissionRec Is Nothing AndAlso Not SysSetupUserPermissionRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub SysSetupUserPermissionRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim SysSetupUserPermissionRec As SysSetupUserPermissionRecord = CType(sender,SysSetupUserPermissionRecord)
        If Not SysSetupUserPermissionRec Is Nothing AndAlso Not SysSetupUserPermissionRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_SSU_UserName field.
	''' </summary>
	Public Function GetSSUP_SSU_UserNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUP_SSU_UserNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_SSU_UserName field.
	''' </summary>
	Public Function GetSSUP_SSU_UserNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSUP_SSU_UserNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSU_UserName field.
	''' </summary>
	Public Sub SetSSUP_SSU_UserNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUP_SSU_UserNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSU_UserName field.
	''' </summary>
	Public Sub SetSSUP_SSU_UserNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_SSU_UserNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Function GetSSUP_SSR_RoleIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUP_SSR_RoleIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Function GetSSUP_SSR_RoleIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSUP_SSR_RoleIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Sub SetSSUP_SSR_RoleIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUP_SSR_RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Sub SetSSUP_SSR_RoleIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUP_SSR_RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Sub SetSSUP_SSR_RoleIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_SSR_RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Sub SetSSUP_SSR_RoleIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_SSR_RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Sub SetSSUP_SSR_RoleIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_SSR_RoleIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_SSR_AppID field.
	''' </summary>
	Public Function GetSSUP_SSR_AppIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUP_SSR_AppIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_SSR_AppID field.
	''' </summary>
	Public Function GetSSUP_SSR_AppIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSUP_SSR_AppIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSR_AppID field.
	''' </summary>
	Public Sub SetSSUP_SSR_AppIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUP_SSR_AppIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSR_AppID field.
	''' </summary>
	Public Sub SetSSUP_SSR_AppIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUP_SSR_AppIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSR_AppID field.
	''' </summary>
	Public Sub SetSSUP_SSR_AppIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_SSR_AppIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSR_AppID field.
	''' </summary>
	Public Sub SetSSUP_SSR_AppIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_SSR_AppIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSR_AppID field.
	''' </summary>
	Public Sub SetSSUP_SSR_AppIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_SSR_AppIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_SSC_CompanyID field.
	''' </summary>
	Public Function GetSSUP_SSC_CompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUP_SSC_CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_SSC_CompanyID field.
	''' </summary>
	Public Function GetSSUP_SSC_CompanyIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.SSUP_SSC_CompanyIDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUP_SSC_CompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUP_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUP_SSC_CompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUP_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUP_SSC_CompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUP_SSC_CompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUP_SSC_CompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_SSC_CompanyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_Permission field.
	''' </summary>
	Public Function GetSSUP_PermissionValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUP_PermissionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_Permission field.
	''' </summary>
	Public Function GetSSUP_PermissionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSUP_PermissionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_Permission field.
	''' </summary>
	Public Sub SetSSUP_PermissionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUP_PermissionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_Permission field.
	''' </summary>
	Public Sub SetSSUP_PermissionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_PermissionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_SSUC_RowID field.
	''' </summary>
	Public Function GetSSUP_SSUC_RowIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUP_SSUC_RowIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_SSUC_RowID field.
	''' </summary>
	Public Function GetSSUP_SSUC_RowIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSUP_SSUC_RowIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSUC_RowID field.
	''' </summary>
	Public Sub SetSSUP_SSUC_RowIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUP_SSUC_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSUC_RowID field.
	''' </summary>
	Public Sub SetSSUP_SSUC_RowIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUP_SSUC_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSUC_RowID field.
	''' </summary>
	Public Sub SetSSUP_SSUC_RowIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_SSUC_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSUC_RowID field.
	''' </summary>
	Public Sub SetSSUP_SSUC_RowIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_SSUC_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_SSUC_RowID field.
	''' </summary>
	Public Sub SetSSUP_SSUC_RowIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_SSUC_RowIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_RowID field.
	''' </summary>
	Public Function GetSSUP_RowIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUP_RowIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_RowID field.
	''' </summary>
	Public Function GetSSUP_RowIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSUP_RowIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_isDefault field.
	''' </summary>
	Public Function GetSSUP_isDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUP_isDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_isDefault field.
	''' </summary>
	Public Function GetSSUP_isDefaultFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SSUP_isDefaultColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_isDefault field.
	''' </summary>
	Public Sub SetSSUP_isDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUP_isDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_isDefault field.
	''' </summary>
	Public Sub SetSSUP_isDefaultFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUP_isDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserPermission_.SSUP_isDefault field.
	''' </summary>
	Public Sub SetSSUP_isDefaultFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_isDefaultColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_SSU_UserName field.
	''' </summary>
	Public Property SSUP_SSU_UserName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SSUP_SSU_UserNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SSUP_SSU_UserNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUP_SSU_UserNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUP_SSU_UserNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUP_SSU_UserNameDefault() As String
        Get
            Return TableUtils.SSUP_SSU_UserNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Property SSUP_SSR_RoleID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SSUP_SSR_RoleIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSUP_SSR_RoleIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUP_SSR_RoleIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUP_SSR_RoleIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUP_SSR_RoleIDDefault() As String
        Get
            Return TableUtils.SSUP_SSR_RoleIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_SSR_AppID field.
	''' </summary>
	Public Property SSUP_SSR_AppID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SSUP_SSR_AppIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSUP_SSR_AppIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUP_SSR_AppIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUP_SSR_AppIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUP_SSR_AppIDDefault() As String
        Get
            Return TableUtils.SSUP_SSR_AppIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_SSC_CompanyID field.
	''' </summary>
	Public Property SSUP_SSC_CompanyID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.SSUP_SSC_CompanyIDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSUP_SSC_CompanyIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUP_SSC_CompanyIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUP_SSC_CompanyIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUP_SSC_CompanyIDDefault() As String
        Get
            Return TableUtils.SSUP_SSC_CompanyIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_Permission field.
	''' </summary>
	Public Property SSUP_Permission() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SSUP_PermissionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SSUP_PermissionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUP_PermissionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUP_PermissionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUP_PermissionDefault() As String
        Get
            Return TableUtils.SSUP_PermissionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_SSUC_RowID field.
	''' </summary>
	Public Property SSUP_SSUC_RowID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SSUP_SSUC_RowIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSUP_SSUC_RowIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUP_SSUC_RowIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUP_SSUC_RowIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUP_SSUC_RowIDDefault() As String
        Get
            Return TableUtils.SSUP_SSUC_RowIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_RowID field.
	''' </summary>
	Public Property SSUP_RowID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SSUP_RowIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSUP_RowIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUP_RowIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUP_RowIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUP_RowIDDefault() As String
        Get
            Return TableUtils.SSUP_RowIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUserPermission_.SSUP_isDefault field.
	''' </summary>
	Public Property SSUP_isDefault() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SSUP_isDefaultColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSUP_isDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUP_isDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUP_isDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUP_isDefaultDefault() As String
        Get
            Return TableUtils.SSUP_isDefaultColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
