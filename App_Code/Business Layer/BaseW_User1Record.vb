' This class is "generated" and will be overwritten.
' Your customizations should be made in W_User1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="W_User1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="W_User1Table"></see> class.
''' </remarks>
''' <seealso cref="W_User1Table"></seealso>
''' <seealso cref="W_User1Record"></seealso>

<Serializable()> Public Class BaseW_User1Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As W_User1Table = W_User1Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub W_User1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim W_User1Rec As W_User1Record = CType(sender,W_User1Record)
        Validate_Inserting()
        If Not W_User1Rec Is Nothing AndAlso Not W_User1Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub W_User1Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim W_User1Rec As W_User1Record = CType(sender,W_User1Record)
        Validate_Updating()
        If Not W_User1Rec Is Nothing AndAlso Not W_User1Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub W_User1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim W_User1Rec As W_User1Record = CType(sender,W_User1Record)
        If Not W_User1Rec Is Nothing AndAlso Not W_User1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's W_User_.W_U_ID field.
	''' </summary>
	Public Function GetW_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_.W_U_ID field.
	''' </summary>
	Public Function GetW_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.W_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_.W_U_User_Name field.
	''' </summary>
	Public Function GetW_U_User_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_U_User_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_.W_U_User_Name field.
	''' </summary>
	Public Function GetW_U_User_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.W_U_User_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_.W_U_User_Name field.
	''' </summary>
	Public Sub SetW_U_User_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_U_User_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_.W_U_User_Name field.
	''' </summary>
	Public Sub SetW_U_User_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_U_User_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_.W_U_Password field.
	''' </summary>
	Public Function GetW_U_PasswordValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_U_PasswordColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_.W_U_Password field.
	''' </summary>
	Public Function GetW_U_PasswordFieldValue() As String
		Return CType(Me.GetValue(TableUtils.W_U_PasswordColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_.W_U_Password field.
	''' </summary>
	Public Sub SetW_U_PasswordFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_U_PasswordColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_.W_U_Password field.
	''' </summary>
	Public Sub SetW_U_PasswordFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_U_PasswordColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_.W_U_Full_Name field.
	''' </summary>
	Public Function GetW_U_Full_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_U_Full_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_.W_U_Full_Name field.
	''' </summary>
	Public Function GetW_U_Full_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.W_U_Full_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_.W_U_Full_Name field.
	''' </summary>
	Public Sub SetW_U_Full_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_U_Full_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_.W_U_Full_Name field.
	''' </summary>
	Public Sub SetW_U_Full_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_U_Full_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_.W_U_Email field.
	''' </summary>
	Public Function GetW_U_EmailValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_U_EmailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_.W_U_Email field.
	''' </summary>
	Public Function GetW_U_EmailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.W_U_EmailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_.W_U_Email field.
	''' </summary>
	Public Sub SetW_U_EmailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_U_EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_.W_U_Email field.
	''' </summary>
	Public Sub SetW_U_EmailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_U_EmailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_.W_U_GP_User_Name field.
	''' </summary>
	Public Function GetW_U_GP_User_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_U_GP_User_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_.W_U_GP_User_Name field.
	''' </summary>
	Public Function GetW_U_GP_User_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.W_U_GP_User_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_.W_U_GP_User_Name field.
	''' </summary>
	Public Sub SetW_U_GP_User_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_U_GP_User_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_.W_U_GP_User_Name field.
	''' </summary>
	Public Sub SetW_U_GP_User_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_U_GP_User_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_.W_U_Designation field.
	''' </summary>
	Public Function GetW_U_DesignationValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_U_DesignationColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_.W_U_Designation field.
	''' </summary>
	Public Function GetW_U_DesignationFieldValue() As String
		Return CType(Me.GetValue(TableUtils.W_U_DesignationColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_.W_U_Designation field.
	''' </summary>
	Public Sub SetW_U_DesignationFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_U_DesignationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_.W_U_Designation field.
	''' </summary>
	Public Sub SetW_U_DesignationFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_U_DesignationColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_User_.W_U_ID field.
	''' </summary>
	Public Property W_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.W_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.W_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_U_IDDefault() As String
        Get
            Return TableUtils.W_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_User_.W_U_User_Name field.
	''' </summary>
	Public Property W_U_User_Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.W_U_User_NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.W_U_User_NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_U_User_NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_U_User_NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_U_User_NameDefault() As String
        Get
            Return TableUtils.W_U_User_NameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_User_.W_U_Password field.
	''' </summary>
	Public Property W_U_Password() As String
		Get 
			Return CType(Me.GetValue(TableUtils.W_U_PasswordColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.W_U_PasswordColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_U_PasswordSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_U_PasswordColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_U_PasswordDefault() As String
        Get
            Return TableUtils.W_U_PasswordColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_User_.W_U_Full_Name field.
	''' </summary>
	Public Property W_U_Full_Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.W_U_Full_NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.W_U_Full_NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_U_Full_NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_U_Full_NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_U_Full_NameDefault() As String
        Get
            Return TableUtils.W_U_Full_NameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_User_.W_U_Email field.
	''' </summary>
	Public Property W_U_Email() As String
		Get 
			Return CType(Me.GetValue(TableUtils.W_U_EmailColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.W_U_EmailColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_U_EmailSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_U_EmailColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_U_EmailDefault() As String
        Get
            Return TableUtils.W_U_EmailColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_User_.W_U_GP_User_Name field.
	''' </summary>
	Public Property W_U_GP_User_Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.W_U_GP_User_NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.W_U_GP_User_NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_U_GP_User_NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_U_GP_User_NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_U_GP_User_NameDefault() As String
        Get
            Return TableUtils.W_U_GP_User_NameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_User_.W_U_Designation field.
	''' </summary>
	Public Property W_U_Designation() As String
		Get 
			Return CType(Me.GetValue(TableUtils.W_U_DesignationColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.W_U_DesignationColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_U_DesignationSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_U_DesignationColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_U_DesignationDefault() As String
        Get
            Return TableUtils.W_U_DesignationColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
