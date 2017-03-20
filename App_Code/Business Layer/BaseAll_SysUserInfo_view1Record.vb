' This class is "generated" and will be overwritten.
' Your customizations should be made in All_SysUserInfo_view1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="All_SysUserInfo_view1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="All_SysUserInfo_view1View"></see> class.
''' </remarks>
''' <seealso cref="All_SysUserInfo_view1View"></seealso>
''' <seealso cref="All_SysUserInfo_view1Record"></seealso>

<Serializable()> Public Class BaseAll_SysUserInfo_view1Record
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As All_SysUserInfo_view1View = All_SysUserInfo_view1View.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub All_SysUserInfo_view1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim All_SysUserInfo_view1Rec As All_SysUserInfo_view1Record = CType(sender,All_SysUserInfo_view1Record)
        If Not All_SysUserInfo_view1Rec Is Nothing AndAlso Not All_SysUserInfo_view1Rec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub All_SysUserInfo_view1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim All_SysUserInfo_view1Rec As All_SysUserInfo_view1Record = CType(sender,All_SysUserInfo_view1Record)
        Validate_Inserting()
        If Not All_SysUserInfo_view1Rec Is Nothing AndAlso Not All_SysUserInfo_view1Rec.IsReadOnly Then
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







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_UserName field.
	''' </summary>
	Public Function GetSSU_UserNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_UserNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_UserName field.
	''' </summary>
	Public Function GetSSU_UserNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSU_UserNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_UserName field.
	''' </summary>
	Public Sub SetSSU_UserNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_UserNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_UserName field.
	''' </summary>
	Public Sub SetSSU_UserNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_UserNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_FullName field.
	''' </summary>
	Public Function GetSSU_FullNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_FullNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_FullName field.
	''' </summary>
	Public Function GetSSU_FullNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSU_FullNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_FullName field.
	''' </summary>
	Public Sub SetSSU_FullNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_FullNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_FullName field.
	''' </summary>
	Public Sub SetSSU_FullNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_FullNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_Password field.
	''' </summary>
	Public Function GetSSU_PasswordValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_PasswordColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_Password field.
	''' </summary>
	Public Function GetSSU_PasswordFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSU_PasswordColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_Password field.
	''' </summary>
	Public Sub SetSSU_PasswordFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_PasswordColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_Password field.
	''' </summary>
	Public Sub SetSSU_PasswordFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_PasswordColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_EmpID field.
	''' </summary>
	Public Function GetSSU_EmpIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_EmpIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_EmpID field.
	''' </summary>
	Public Function GetSSU_EmpIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSU_EmpIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_EmpID field.
	''' </summary>
	Public Sub SetSSU_EmpIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_EmpIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_EmpID field.
	''' </summary>
	Public Sub SetSSU_EmpIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSU_EmpIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_EmpID field.
	''' </summary>
	Public Sub SetSSU_EmpIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_EmpIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_EmpID field.
	''' </summary>
	Public Sub SetSSU_EmpIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_EmpIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_EmpID field.
	''' </summary>
	Public Sub SetSSU_EmpIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_EmpIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_SSC_CompanyID field.
	''' </summary>
	Public Function GetSSU_SSC_CompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_SSC_CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_SSC_CompanyID field.
	''' </summary>
	Public Function GetSSU_SSC_CompanyIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.SSU_SSC_CompanyIDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSU_SSC_CompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSU_SSC_CompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSU_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSU_SSC_CompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSU_SSC_CompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSU_SSC_CompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_SSC_CompanyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_IsActive field.
	''' </summary>
	Public Function GetSSU_IsActiveValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_IsActiveColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_IsActive field.
	''' </summary>
	Public Function GetSSU_IsActiveFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SSU_IsActiveColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_IsActive field.
	''' </summary>
	Public Sub SetSSU_IsActiveFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_IsActiveColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_IsActive field.
	''' </summary>
	Public Sub SetSSU_IsActiveFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSU_IsActiveColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_IsActive field.
	''' </summary>
	Public Sub SetSSU_IsActiveFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_IsActiveColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_DateCreated field.
	''' </summary>
	Public Function GetSSU_DateCreatedValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_DateCreatedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_DateCreated field.
	''' </summary>
	Public Function GetSSU_DateCreatedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.SSU_DateCreatedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_DateCreated field.
	''' </summary>
	Public Sub SetSSU_DateCreatedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_DateCreated field.
	''' </summary>
	Public Sub SetSSU_DateCreatedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSU_DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_DateCreated field.
	''' </summary>
	Public Sub SetSSU_DateCreatedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_DateModified field.
	''' </summary>
	Public Function GetSSU_DateModifiedValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_DateModifiedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_DateModified field.
	''' </summary>
	Public Function GetSSU_DateModifiedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.SSU_DateModifiedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_DateModified field.
	''' </summary>
	Public Sub SetSSU_DateModifiedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_DateModifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_DateModified field.
	''' </summary>
	Public Sub SetSSU_DateModifiedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSU_DateModifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_DateModified field.
	''' </summary>
	Public Sub SetSSU_DateModifiedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_DateModifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_RowID field.
	''' </summary>
	Public Function GetSSU_RowIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSU_RowIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_RowID field.
	''' </summary>
	Public Function GetSSU_RowIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSU_RowIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_RowID field.
	''' </summary>
	Public Sub SetSSU_RowIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSU_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_RowID field.
	''' </summary>
	Public Sub SetSSU_RowIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSU_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_RowID field.
	''' </summary>
	Public Sub SetSSU_RowIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_RowID field.
	''' </summary>
	Public Sub SetSSU_RowIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSU_RowID field.
	''' </summary>
	Public Sub SetSSU_RowIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSU_RowIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSUA_App_ID field.
	''' </summary>
	Public Function GetSSUA_App_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUA_App_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSUA_App_ID field.
	''' </summary>
	Public Function GetSSUA_App_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSUA_App_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUA_App_ID field.
	''' </summary>
	Public Sub SetSSUA_App_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUA_App_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUA_App_ID field.
	''' </summary>
	Public Sub SetSSUA_App_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUA_App_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUA_App_ID field.
	''' </summary>
	Public Sub SetSSUA_App_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUA_App_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUA_App_ID field.
	''' </summary>
	Public Sub SetSSUA_App_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUA_App_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUA_App_ID field.
	''' </summary>
	Public Sub SetSSUA_App_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUA_App_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSUA_DateCreated field.
	''' </summary>
	Public Function GetSSUA_DateCreatedValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUA_DateCreatedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSUA_DateCreated field.
	''' </summary>
	Public Function GetSSUA_DateCreatedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.SSUA_DateCreatedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUA_DateCreated field.
	''' </summary>
	Public Sub SetSSUA_DateCreatedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUA_DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUA_DateCreated field.
	''' </summary>
	Public Sub SetSSUA_DateCreatedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUA_DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUA_DateCreated field.
	''' </summary>
	Public Sub SetSSUA_DateCreatedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUA_DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.App_Name field.
	''' </summary>
	Public Function GetApp_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.App_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.App_Name field.
	''' </summary>
	Public Function GetApp_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.App_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.App_Name field.
	''' </summary>
	Public Sub SetApp_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.App_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.App_Name field.
	''' </summary>
	Public Sub SetApp_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.App_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.App_Description field.
	''' </summary>
	Public Function GetApp_DescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.App_DescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.App_Description field.
	''' </summary>
	Public Function GetApp_DescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.App_DescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.App_Description field.
	''' </summary>
	Public Sub SetApp_DescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.App_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.App_Description field.
	''' </summary>
	Public Sub SetApp_DescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.App_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Function GetSSUC_SSC_CompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUC_SSC_CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Function GetSSUC_SSC_CompanyIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.SSUC_SSC_CompanyIDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSUC_isDefault field.
	''' </summary>
	Public Function GetSSUC_isDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUC_isDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSUC_isDefault field.
	''' </summary>
	Public Function GetSSUC_isDefaultFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SSUC_isDefaultColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUC_isDefault field.
	''' </summary>
	Public Sub SetSSUC_isDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUC_isDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUC_isDefault field.
	''' </summary>
	Public Sub SetSSUC_isDefaultFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUC_isDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUC_isDefault field.
	''' </summary>
	Public Sub SetSSUC_isDefaultFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_isDefaultColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSC_CompanyName field.
	''' </summary>
	Public Function GetSSC_CompanyNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSC_CompanyNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSC_CompanyName field.
	''' </summary>
	Public Function GetSSC_CompanyNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSC_CompanyNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSC_CompanyName field.
	''' </summary>
	Public Sub SetSSC_CompanyNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSC_CompanyNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSC_CompanyName field.
	''' </summary>
	Public Sub SetSSC_CompanyNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSC_CompanyNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSC_Description field.
	''' </summary>
	Public Function GetSSC_DescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSC_DescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSC_Description field.
	''' </summary>
	Public Function GetSSC_DescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSC_DescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSC_Description field.
	''' </summary>
	Public Sub SetSSC_DescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSC_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSC_Description field.
	''' </summary>
	Public Sub SetSSC_DescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSC_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Function GetSSUP_SSR_RoleIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUP_SSR_RoleIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Function GetSSUP_SSR_RoleIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSUP_SSR_RoleIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Sub SetSSUP_SSR_RoleIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUP_SSR_RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Sub SetSSUP_SSR_RoleIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUP_SSR_RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Sub SetSSUP_SSR_RoleIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_SSR_RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Sub SetSSUP_SSR_RoleIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_SSR_RoleIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUP_SSR_RoleID field.
	''' </summary>
	Public Sub SetSSUP_SSR_RoleIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_SSR_RoleIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSUP_Permission field.
	''' </summary>
	Public Function GetSSUP_PermissionValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUP_PermissionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSUP_Permission field.
	''' </summary>
	Public Function GetSSUP_PermissionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSUP_PermissionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUP_Permission field.
	''' </summary>
	Public Sub SetSSUP_PermissionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUP_PermissionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUP_Permission field.
	''' </summary>
	Public Sub SetSSUP_PermissionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUP_PermissionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSR_RoleName field.
	''' </summary>
	Public Function GetSSR_RoleNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSR_RoleNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSR_RoleName field.
	''' </summary>
	Public Function GetSSR_RoleNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSR_RoleNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSR_RoleName field.
	''' </summary>
	Public Sub SetSSR_RoleNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSR_RoleNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSR_RoleName field.
	''' </summary>
	Public Sub SetSSR_RoleNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSR_RoleNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSUE_Email field.
	''' </summary>
	Public Function GetSSUE_EmailValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUE_EmailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's All_SysUserInfo_view_.SSUE_Email field.
	''' </summary>
	Public Function GetSSUE_EmailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSUE_EmailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUE_Email field.
	''' </summary>
	Public Sub SetSSUE_EmailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUE_EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's All_SysUserInfo_view_.SSUE_Email field.
	''' </summary>
	Public Sub SetSSUE_EmailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUE_EmailColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_UserName field.
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
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_FullName field.
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
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_Password field.
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
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_EmpID field.
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
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_SSC_CompanyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_IsActive field.
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
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_DateCreated field.
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
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_DateModified field.
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
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.SSU_RowID field.
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
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.SSUA_App_ID field.
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
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.SSUA_DateCreated field.
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
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.App_Name field.
	''' </summary>
	Public Property App_Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.App_NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.App_NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property App_NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.App_NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property App_NameDefault() As String
        Get
            Return TableUtils.App_NameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.App_Description field.
	''' </summary>
	Public Property App_Description() As String
		Get 
			Return CType(Me.GetValue(TableUtils.App_DescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.App_DescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property App_DescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.App_DescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property App_DescriptionDefault() As String
        Get
            Return TableUtils.App_DescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.SSUC_SSC_CompanyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.SSUC_isDefault field.
	''' </summary>
	Public Property SSUC_isDefault() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SSUC_isDefaultColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSUC_isDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUC_isDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUC_isDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUC_isDefaultDefault() As String
        Get
            Return TableUtils.SSUC_isDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.SSC_CompanyName field.
	''' </summary>
	Public Property SSC_CompanyName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SSC_CompanyNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SSC_CompanyNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSC_CompanyNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSC_CompanyNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSC_CompanyNameDefault() As String
        Get
            Return TableUtils.SSC_CompanyNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.SSC_Description field.
	''' </summary>
	Public Property SSC_Description() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SSC_DescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SSC_DescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSC_DescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSC_DescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSC_DescriptionDefault() As String
        Get
            Return TableUtils.SSC_DescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.SSUP_SSR_RoleID field.
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
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.SSUP_Permission field.
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
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.SSR_RoleName field.
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
	''' This is a convenience property that provides direct access to the value of the record's All_SysUserInfo_view_.SSUE_Email field.
	''' </summary>
	Public Property SSUE_Email() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SSUE_EmailColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SSUE_EmailColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUE_EmailSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUE_EmailColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUE_EmailDefault() As String
        Get
            Return TableUtils.SSUE_EmailColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
