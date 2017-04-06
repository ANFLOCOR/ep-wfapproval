' This class is "generated" and will be overwritten.
' Your customizations should be made in SysSetupUserCompany2Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="SysSetupUserCompany2Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="SysSetupUserCompany2Table"></see> class.
''' </remarks>
''' <seealso cref="SysSetupUserCompany2Table"></seealso>
''' <seealso cref="SysSetupUserCompany2Record"></seealso>

<Serializable()> Public Class BaseSysSetupUserCompany2Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As SysSetupUserCompany2Table = SysSetupUserCompany2Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub SysSetupUserCompany2Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim SysSetupUserCompany2Rec As SysSetupUserCompany2Record = CType(sender,SysSetupUserCompany2Record)
        Validate_Inserting()
        If Not SysSetupUserCompany2Rec Is Nothing AndAlso Not SysSetupUserCompany2Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub SysSetupUserCompany2Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim SysSetupUserCompany2Rec As SysSetupUserCompany2Record = CType(sender,SysSetupUserCompany2Record)
        Validate_Updating()
        If Not SysSetupUserCompany2Rec Is Nothing AndAlso Not SysSetupUserCompany2Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub SysSetupUserCompany2Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim SysSetupUserCompany2Rec As SysSetupUserCompany2Record = CType(sender,SysSetupUserCompany2Record)
        If Not SysSetupUserCompany2Rec Is Nothing AndAlso Not SysSetupUserCompany2Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserCompany_.SSUC_SSU_UserName field.
	''' </summary>
	Public Function GetSSUC_SSU_UserNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUC_SSU_UserNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserCompany_.SSUC_SSU_UserName field.
	''' </summary>
	Public Function GetSSUC_SSU_UserNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSUC_SSU_UserNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_SSU_UserName field.
	''' </summary>
	Public Sub SetSSUC_SSU_UserNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUC_SSU_UserNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_SSU_UserName field.
	''' </summary>
	Public Sub SetSSUC_SSU_UserNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_SSU_UserNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserCompany_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Function GetSSUC_SSC_CompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUC_SSC_CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserCompany_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Function GetSSUC_SSC_CompanyIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.SSUC_SSC_CompanyIDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserCompany_.SSUC_APP_ID field.
	''' </summary>
	Public Function GetSSUC_APP_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUC_APP_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserCompany_.SSUC_APP_ID field.
	''' </summary>
	Public Function GetSSUC_APP_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSUC_APP_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_APP_ID field.
	''' </summary>
	Public Sub SetSSUC_APP_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUC_APP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_APP_ID field.
	''' </summary>
	Public Sub SetSSUC_APP_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUC_APP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_APP_ID field.
	''' </summary>
	Public Sub SetSSUC_APP_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_APP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_APP_ID field.
	''' </summary>
	Public Sub SetSSUC_APP_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_APP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_APP_ID field.
	''' </summary>
	Public Sub SetSSUC_APP_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_APP_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserCompany_.SSUC_isDefault field.
	''' </summary>
	Public Function GetSSUC_isDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUC_isDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserCompany_.SSUC_isDefault field.
	''' </summary>
	Public Function GetSSUC_isDefaultFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SSUC_isDefaultColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_isDefault field.
	''' </summary>
	Public Sub SetSSUC_isDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUC_isDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_isDefault field.
	''' </summary>
	Public Sub SetSSUC_isDefaultFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUC_isDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_isDefault field.
	''' </summary>
	Public Sub SetSSUC_isDefaultFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_isDefaultColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserCompany_.SSUC_SSUA_RowID field.
	''' </summary>
	Public Function GetSSUC_SSUA_RowIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUC_SSUA_RowIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserCompany_.SSUC_SSUA_RowID field.
	''' </summary>
	Public Function GetSSUC_SSUA_RowIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSUC_SSUA_RowIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_SSUA_RowID field.
	''' </summary>
	Public Sub SetSSUC_SSUA_RowIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUC_SSUA_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_SSUA_RowID field.
	''' </summary>
	Public Sub SetSSUC_SSUA_RowIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUC_SSUA_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_SSUA_RowID field.
	''' </summary>
	Public Sub SetSSUC_SSUA_RowIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_SSUA_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_SSUA_RowID field.
	''' </summary>
	Public Sub SetSSUC_SSUA_RowIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_SSUA_RowIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysSetupUserCompany_.SSUC_SSUA_RowID field.
	''' </summary>
	Public Sub SetSSUC_SSUA_RowIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_SSUA_RowIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserCompany_.SSUC_RowID field.
	''' </summary>
	Public Function GetSSUC_RowIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUC_RowIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysSetupUserCompany_.SSUC_RowID field.
	''' </summary>
	Public Function GetSSUC_RowIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSUC_RowIDColumn).ToInt32(), Int32)
	End Function



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUserCompany_.SSUC_SSU_UserName field.
	''' </summary>
	Public Property SSUC_SSU_UserName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SSUC_SSU_UserNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SSUC_SSU_UserNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUC_SSU_UserNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUC_SSU_UserNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUC_SSU_UserNameDefault() As String
        Get
            Return TableUtils.SSUC_SSU_UserNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUserCompany_.SSUC_SSC_CompanyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUserCompany_.SSUC_APP_ID field.
	''' </summary>
	Public Property SSUC_APP_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SSUC_APP_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSUC_APP_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUC_APP_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUC_APP_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUC_APP_IDDefault() As String
        Get
            Return TableUtils.SSUC_APP_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUserCompany_.SSUC_isDefault field.
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
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUserCompany_.SSUC_SSUA_RowID field.
	''' </summary>
	Public Property SSUC_SSUA_RowID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SSUC_SSUA_RowIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSUC_SSUA_RowIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUC_SSUA_RowIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUC_SSUA_RowIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUC_SSUA_RowIDDefault() As String
        Get
            Return TableUtils.SSUC_SSUA_RowIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysSetupUserCompany_.SSUC_RowID field.
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



#End Region

End Class
End Namespace
