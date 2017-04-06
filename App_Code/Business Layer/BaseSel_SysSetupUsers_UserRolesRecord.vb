' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_SysSetupUsers_UserRolesRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_SysSetupUsers_UserRolesRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_SysSetupUsers_UserRolesView"></see> class.
''' </remarks>
''' <seealso cref="Sel_SysSetupUsers_UserRolesView"></seealso>
''' <seealso cref="Sel_SysSetupUsers_UserRolesRecord"></seealso>

<Serializable()> Public Class BaseSel_SysSetupUsers_UserRolesRecord
	Inherits KeylessRecord
	Implements IUserRoleRecord


	Public Shared Shadows ReadOnly TableUtils As Sel_SysSetupUsers_UserRolesView = Sel_SysSetupUsers_UserRolesView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_SysSetupUsers_UserRolesRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_SysSetupUsers_UserRolesRec As Sel_SysSetupUsers_UserRolesRecord = CType(sender,Sel_SysSetupUsers_UserRolesRecord)
        If Not Sel_SysSetupUsers_UserRolesRec Is Nothing AndAlso Not Sel_SysSetupUsers_UserRolesRec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_SysSetupUsers_UserRolesRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_SysSetupUsers_UserRolesRec As Sel_SysSetupUsers_UserRolesRecord = CType(sender,Sel_SysSetupUsers_UserRolesRecord)
        Validate_Inserting()
        If Not Sel_SysSetupUsers_UserRolesRec Is Nothing AndAlso Not Sel_SysSetupUsers_UserRolesRec.IsReadOnly Then
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

#Region "IUserRecord Members"

	' Get the user's unique identifier
	Public Function GetUserId() As String Implements IUserRecord.GetUserId
		Return CType(Me, IRecord).GetString(CType(Me.TableAccess, IUserTable).UserIdColumn)
	End Function

#End Region




#Region "IUserRoleRecord Members"

	' Get the role to which this user belongs
	Public Function GetUserRole() As String Implements IUserRoleRecord.GetUserRole
		Return CType(Me, IRecord).GetString(CType(Me.TableAccess, IUserRoleTable).UserRoleColumn)
	End Function

#End Region


#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSU_UserName field.
	''' </summary>
	Public Function GetSSU_UserNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_UserNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSU_UserName field.
	''' </summary>
	Public Function GetSSU_UserNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSU_UserNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSU_UserName field.
	''' </summary>
	Public Sub SetSSU_UserNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_UserNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSU_UserName field.
	''' </summary>
	Public Sub SetSSU_UserNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_UserNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSU_RowID field.
	''' </summary>
	Public Function GetSSU_RowIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_RowIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSU_RowID field.
	''' </summary>
	Public Function GetSSU_RowIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSU_RowIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSU_RowID field.
	''' </summary>
	Public Sub SetSSU_RowIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSU_RowID field.
	''' </summary>
	Public Sub SetSSU_RowIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSU_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSU_RowID field.
	''' </summary>
	Public Sub SetSSU_RowIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSU_RowID field.
	''' </summary>
	Public Sub SetSSU_RowIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSU_RowID field.
	''' </summary>
	Public Sub SetSSU_RowIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_RowIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUA_App_ID field.
	''' </summary>
	Public Function GetSSUA_App_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUA_App_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUA_App_ID field.
	''' </summary>
	Public Function GetSSUA_App_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSUA_App_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUA_App_ID field.
	''' </summary>
	Public Sub SetSSUA_App_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUA_App_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUA_App_ID field.
	''' </summary>
	Public Sub SetSSUA_App_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUA_App_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUA_App_ID field.
	''' </summary>
	Public Sub SetSSUA_App_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUA_App_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUA_App_ID field.
	''' </summary>
	Public Sub SetSSUA_App_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUA_App_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUA_App_ID field.
	''' </summary>
	Public Sub SetSSUA_App_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUA_App_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Function GetSSUC_SSC_CompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUC_SSC_CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Function GetSSUC_SSC_CompanyIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.SSUC_SSC_CompanyIDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Function GetSSUP_SSR_RoleIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUP_SSR_RoleIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Function GetSSUP_SSR_RoleIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSUP_SSR_RoleIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Sub SetSSUP_SSR_RoleIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUP_SSR_RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Sub SetSSUP_SSR_RoleIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUP_SSR_RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Sub SetSSUP_SSR_RoleIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_SSR_RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Sub SetSSUP_SSR_RoleIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_SSR_RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Sub SetSSUP_SSR_RoleIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_SSR_RoleIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_RowID field.
	''' </summary>
	Public Function GetSSUP_RowIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUP_RowIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_RowID field.
	''' </summary>
	Public Function GetSSUP_RowIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSUP_RowIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_RowID field.
	''' </summary>
	Public Sub SetSSUP_RowIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUP_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_RowID field.
	''' </summary>
	Public Sub SetSSUP_RowIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUP_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_RowID field.
	''' </summary>
	Public Sub SetSSUP_RowIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_RowID field.
	''' </summary>
	Public Sub SetSSUP_RowIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_RowID field.
	''' </summary>
	Public Sub SetSSUP_RowIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_RowIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSR_RoleName field.
	''' </summary>
	Public Function GetSSR_RoleNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSR_RoleNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSR_RoleName field.
	''' </summary>
	Public Function GetSSR_RoleNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSR_RoleNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSR_RoleName field.
	''' </summary>
	Public Sub SetSSR_RoleNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSR_RoleNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSR_RoleName field.
	''' </summary>
	Public Sub SetSSR_RoleNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSR_RoleNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUC_RowID field.
	''' </summary>
	Public Function GetSSUC_RowIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUC_RowIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUC_RowID field.
	''' </summary>
	Public Function GetSSUC_RowIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSUC_RowIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUC_RowID field.
	''' </summary>
	Public Sub SetSSUC_RowIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUC_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUC_RowID field.
	''' </summary>
	Public Sub SetSSUC_RowIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUC_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUC_RowID field.
	''' </summary>
	Public Sub SetSSUC_RowIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUC_RowID field.
	''' </summary>
	Public Sub SetSSUC_RowIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUC_RowID field.
	''' </summary>
	Public Sub SetSSUC_RowIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_RowIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUA_RowID field.
	''' </summary>
	Public Function GetSSUA_RowIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUA_RowIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUA_RowID field.
	''' </summary>
	Public Function GetSSUA_RowIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSUA_RowIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUA_RowID field.
	''' </summary>
	Public Sub SetSSUA_RowIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUA_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUA_RowID field.
	''' </summary>
	Public Sub SetSSUA_RowIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUA_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUA_RowID field.
	''' </summary>
	Public Sub SetSSUA_RowIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUA_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUA_RowID field.
	''' </summary>
	Public Sub SetSSUA_RowIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUA_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUA_RowID field.
	''' </summary>
	Public Sub SetSSUA_RowIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUA_RowIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_Permission field.
	''' </summary>
	Public Function GetSSUP_PermissionValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUP_PermissionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_Permission field.
	''' </summary>
	Public Function GetSSUP_PermissionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSUP_PermissionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_Permission field.
	''' </summary>
	Public Sub SetSSUP_PermissionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUP_PermissionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_Permission field.
	''' </summary>
	Public Sub SetSSUP_PermissionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_PermissionColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSU_UserName field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSU_RowID field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUA_App_ID field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Property SSUC_SSC_CompanyID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.SSUC_SSC_CompanyIDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSUC_SSC_CompanyIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUC_SSC_CompanyIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUC_SSC_CompanyIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUC_SSC_CompanyIDDefault() As String
        Get
            Return TableUtils.SSUC_SSC_CompanyIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_SSR_RoleID field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_RowID field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSR_RoleName field.
	''' </summary>
	Public Property SSR_RoleName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SSR_RoleNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SSR_RoleNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSR_RoleNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSR_RoleNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSR_RoleNameDefault() As String
        Get
            Return TableUtils.SSR_RoleNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUC_RowID field.
	''' </summary>
	Public Property SSUC_RowID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SSUC_RowIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSUC_RowIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUC_RowIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUC_RowIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUC_RowIDDefault() As String
        Get
            Return TableUtils.SSUC_RowIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUA_RowID field.
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_SysSetupUsers_UserRoles_.SSUP_Permission field.
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



#End Region

End Class
End Namespace
