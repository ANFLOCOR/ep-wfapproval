' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_W_User_DYNAMICS_Company_FSRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_W_User_DYNAMICS_Company_FSRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_W_User_DYNAMICS_Company_FSView"></see> class.
''' </remarks>
''' <seealso cref="Sel_W_User_DYNAMICS_Company_FSView"></seealso>
''' <seealso cref="Sel_W_User_DYNAMICS_Company_FSRecord"></seealso>

<Serializable()> Public Class BaseSel_W_User_DYNAMICS_Company_FSRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_W_User_DYNAMICS_Company_FSView = Sel_W_User_DYNAMICS_Company_FSView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_W_User_DYNAMICS_Company_FSRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_W_User_DYNAMICS_Company_FSRec As Sel_W_User_DYNAMICS_Company_FSRecord = CType(sender,Sel_W_User_DYNAMICS_Company_FSRecord)
        If Not Sel_W_User_DYNAMICS_Company_FSRec Is Nothing AndAlso Not Sel_W_User_DYNAMICS_Company_FSRec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_W_User_DYNAMICS_Company_FSRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_W_User_DYNAMICS_Company_FSRec As Sel_W_User_DYNAMICS_Company_FSRecord = CType(sender,Sel_W_User_DYNAMICS_Company_FSRecord)
        Validate_Inserting()
        If Not Sel_W_User_DYNAMICS_Company_FSRec Is Nothing AndAlso Not Sel_W_User_DYNAMICS_Company_FSRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's Sel_W_User_DYNAMIC_1089084141_.W_U_ID field.
	''' </summary>
	Public Function GetW_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_W_User_DYNAMIC_1089084141_.W_U_ID field.
	''' </summary>
	Public Function GetW_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.W_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_W_User_DYNAMIC_1089084141_.W_U_ID field.
	''' </summary>
	Public Sub SetW_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_W_User_DYNAMIC_1089084141_.W_U_ID field.
	''' </summary>
	Public Sub SetW_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_W_User_DYNAMIC_1089084141_.W_U_ID field.
	''' </summary>
	Public Sub SetW_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_W_User_DYNAMIC_1089084141_.W_U_ID field.
	''' </summary>
	Public Sub SetW_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_W_User_DYNAMIC_1089084141_.W_U_ID field.
	''' </summary>
	Public Sub SetW_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_W_User_DYNAMIC_1089084141_.W_U_User_Name field.
	''' </summary>
	Public Function GetW_U_User_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_U_User_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_W_User_DYNAMIC_1089084141_.W_U_User_Name field.
	''' </summary>
	Public Function GetW_U_User_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.W_U_User_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_W_User_DYNAMIC_1089084141_.W_U_User_Name field.
	''' </summary>
	Public Sub SetW_U_User_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_U_User_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_W_User_DYNAMIC_1089084141_.W_U_User_Name field.
	''' </summary>
	Public Sub SetW_U_User_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_U_User_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_W_User_DYNAMIC_1089084141_.Company_Short_Name field.
	''' </summary>
	Public Function GetCompany_Short_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.Company_Short_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_W_User_DYNAMIC_1089084141_.Company_Short_Name field.
	''' </summary>
	Public Function GetCompany_Short_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.Company_Short_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_W_User_DYNAMIC_1089084141_.Company_Short_Name field.
	''' </summary>
	Public Sub SetCompany_Short_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Company_Short_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_W_User_DYNAMIC_1089084141_.Company_Short_Name field.
	''' </summary>
	Public Sub SetCompany_Short_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_Short_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_W_User_DYNAMIC_1089084141_.Company_ID field.
	''' </summary>
	Public Function GetCompany_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.Company_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_W_User_DYNAMIC_1089084141_.Company_ID field.
	''' </summary>
	Public Function GetCompany_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.Company_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_W_User_DYNAMIC_1089084141_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_W_User_DYNAMIC_1089084141_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_W_User_DYNAMIC_1089084141_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_W_User_DYNAMIC_1089084141_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_W_User_DYNAMIC_1089084141_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_W_User_DYNAMIC_1089084141_.IsNonGP field.
	''' </summary>
	Public Function GetIsNonGPValue() As ColumnValue
		Return Me.GetValue(TableUtils.IsNonGPColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_W_User_DYNAMIC_1089084141_.IsNonGP field.
	''' </summary>
	Public Function GetIsNonGPFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.IsNonGPColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_W_User_DYNAMIC_1089084141_.IsNonGP field.
	''' </summary>
	Public Sub SetIsNonGPFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IsNonGPColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_W_User_DYNAMIC_1089084141_.IsNonGP field.
	''' </summary>
	Public Sub SetIsNonGPFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.IsNonGPColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_W_User_DYNAMIC_1089084141_.IsNonGP field.
	''' </summary>
	Public Sub SetIsNonGPFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IsNonGPColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_W_User_DYNAMIC_1089084141_.IsNonGP field.
	''' </summary>
	Public Sub SetIsNonGPFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IsNonGPColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_W_User_DYNAMIC_1089084141_.IsNonGP field.
	''' </summary>
	Public Sub SetIsNonGPFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IsNonGPColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Sel_W_User_DYNAMIC_1089084141_.W_U_ID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Sel_W_User_DYNAMIC_1089084141_.W_U_User_Name field.
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
	''' This is a convenience property that provides direct access to the value of the record's Sel_W_User_DYNAMIC_1089084141_.Company_Short_Name field.
	''' </summary>
	Public Property Company_Short_Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Company_Short_NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Company_Short_NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Company_Short_NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Company_Short_NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Company_Short_NameDefault() As String
        Get
            Return TableUtils.Company_Short_NameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Sel_W_User_DYNAMIC_1089084141_.Company_ID field.
	''' </summary>
	Public Property Company_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.Company_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Company_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Company_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Company_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Company_IDDefault() As String
        Get
            Return TableUtils.Company_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Sel_W_User_DYNAMIC_1089084141_.IsNonGP field.
	''' </summary>
	Public Property IsNonGP() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.IsNonGPColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.IsNonGPColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property IsNonGPSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.IsNonGPColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property IsNonGPDefault() As String
        Get
            Return TableUtils.IsNonGPColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
