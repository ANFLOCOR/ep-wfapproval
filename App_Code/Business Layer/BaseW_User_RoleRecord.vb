' This class is "generated" and will be overwritten.
' Your customizations should be made in W_User_RoleRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="W_User_RoleRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="W_User_RoleTable"></see> class.
''' </remarks>
''' <seealso cref="W_User_RoleTable"></seealso>
''' <seealso cref="W_User_RoleRecord"></seealso>

<Serializable()> Public Class BaseW_User_RoleRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As W_User_RoleTable = W_User_RoleTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub W_User_RoleRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim W_User_RoleRec As W_User_RoleRecord = CType(sender,W_User_RoleRecord)
        Validate_Inserting()
        If Not W_User_RoleRec Is Nothing AndAlso Not W_User_RoleRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub W_User_RoleRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim W_User_RoleRec As W_User_RoleRecord = CType(sender,W_User_RoleRecord)
        Validate_Updating()
        If Not W_User_RoleRec Is Nothing AndAlso Not W_User_RoleRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub W_User_RoleRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim W_User_RoleRec As W_User_RoleRecord = CType(sender,W_User_RoleRecord)
        If Not W_User_RoleRec Is Nothing AndAlso Not W_User_RoleRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's W_User_Role_.W_UR_ID field.
	''' </summary>
	Public Function GetW_UR_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_UR_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_Role_.W_UR_ID field.
	''' </summary>
	Public Function GetW_UR_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.W_UR_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_Role_.W_UR_U_ID field.
	''' </summary>
	Public Function GetW_UR_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_UR_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_Role_.W_UR_U_ID field.
	''' </summary>
	Public Function GetW_UR_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.W_UR_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_Role_.W_UR_U_ID field.
	''' </summary>
	Public Sub SetW_UR_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_UR_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_Role_.W_UR_U_ID field.
	''' </summary>
	Public Sub SetW_UR_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.W_UR_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_Role_.W_UR_U_ID field.
	''' </summary>
	Public Sub SetW_UR_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_UR_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_Role_.W_UR_U_ID field.
	''' </summary>
	Public Sub SetW_UR_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_UR_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_Role_.W_UR_U_ID field.
	''' </summary>
	Public Sub SetW_UR_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_UR_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_Role_.W_UR_R_ID field.
	''' </summary>
	Public Function GetW_UR_R_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_UR_R_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_Role_.W_UR_R_ID field.
	''' </summary>
	Public Function GetW_UR_R_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.W_UR_R_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_Role_.W_UR_R_ID field.
	''' </summary>
	Public Sub SetW_UR_R_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_UR_R_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_Role_.W_UR_R_ID field.
	''' </summary>
	Public Sub SetW_UR_R_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.W_UR_R_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_Role_.W_UR_R_ID field.
	''' </summary>
	Public Sub SetW_UR_R_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_UR_R_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_Role_.W_UR_R_ID field.
	''' </summary>
	Public Sub SetW_UR_R_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_UR_R_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_Role_.W_UR_R_ID field.
	''' </summary>
	Public Sub SetW_UR_R_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_UR_R_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_User_Role_.W_UR_ID field.
	''' </summary>
	Public Property W_UR_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.W_UR_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.W_UR_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_UR_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_UR_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_UR_IDDefault() As String
        Get
            Return TableUtils.W_UR_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_User_Role_.W_UR_U_ID field.
	''' </summary>
	Public Property W_UR_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.W_UR_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.W_UR_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_UR_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_UR_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_UR_U_IDDefault() As String
        Get
            Return TableUtils.W_UR_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_User_Role_.W_UR_R_ID field.
	''' </summary>
	Public Property W_UR_R_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.W_UR_R_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.W_UR_R_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_UR_R_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_UR_R_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_UR_R_IDDefault() As String
        Get
            Return TableUtils.W_UR_R_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
