' This class is "generated" and will be overwritten.
' Your customizations should be made in Vw_ANFLO_DW_CompanyGPRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Vw_ANFLO_DW_CompanyGPRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Vw_ANFLO_DW_CompanyGPView"></see> class.
''' </remarks>
''' <seealso cref="Vw_ANFLO_DW_CompanyGPView"></seealso>
''' <seealso cref="Vw_ANFLO_DW_CompanyGPRecord"></seealso>

<Serializable()> Public Class BaseVw_ANFLO_DW_CompanyGPRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As Vw_ANFLO_DW_CompanyGPView = Vw_ANFLO_DW_CompanyGPView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Vw_ANFLO_DW_CompanyGPRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Vw_ANFLO_DW_CompanyGPRec As Vw_ANFLO_DW_CompanyGPRecord = CType(sender,Vw_ANFLO_DW_CompanyGPRecord)
        If Not Vw_ANFLO_DW_CompanyGPRec Is Nothing AndAlso Not Vw_ANFLO_DW_CompanyGPRec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Vw_ANFLO_DW_CompanyGPRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Vw_ANFLO_DW_CompanyGPRec As Vw_ANFLO_DW_CompanyGPRecord = CType(sender,Vw_ANFLO_DW_CompanyGPRecord)
        Validate_Inserting()
        If Not Vw_ANFLO_DW_CompanyGPRec Is Nothing AndAlso Not Vw_ANFLO_DW_CompanyGPRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyGP_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyGP_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CompanyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyGP_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyGP_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyGP_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyGP_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyGP_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyGP_.Name field.
	''' </summary>
	Public Function GetNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyGP_.Name field.
	''' </summary>
	Public Function GetNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyGP_.Name field.
	''' </summary>
	Public Sub SetNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyGP_.Name field.
	''' </summary>
	Public Sub SetNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyGP_.ShortName field.
	''' </summary>
	Public Function GetShortNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.ShortNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyGP_.ShortName field.
	''' </summary>
	Public Function GetShortNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ShortNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyGP_.ShortName field.
	''' </summary>
	Public Sub SetShortNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ShortNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyGP_.ShortName field.
	''' </summary>
	Public Sub SetShortNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ShortNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyGP_.GroupID field.
	''' </summary>
	Public Function GetGroupIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.GroupIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyGP_.GroupID field.
	''' </summary>
	Public Function GetGroupIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.GroupIDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyGP_.GroupID field.
	''' </summary>
	Public Sub SetGroupIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GroupIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyGP_.GroupID field.
	''' </summary>
	Public Sub SetGroupIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.GroupIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyGP_.GroupID field.
	''' </summary>
	Public Sub SetGroupIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GroupIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyGP_.GroupID field.
	''' </summary>
	Public Sub SetGroupIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GroupIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyGP_.GroupID field.
	''' </summary>
	Public Sub SetGroupIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GroupIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyGP_.DynamicsCompanyID field.
	''' </summary>
	Public Function GetDynamicsCompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DynamicsCompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyGP_.DynamicsCompanyID field.
	''' </summary>
	Public Function GetDynamicsCompanyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DynamicsCompanyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyGP_.DynamicsCompanyID field.
	''' </summary>
	Public Sub SetDynamicsCompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DynamicsCompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyGP_.DynamicsCompanyID field.
	''' </summary>
	Public Sub SetDynamicsCompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DynamicsCompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyGP_.DynamicsCompanyID field.
	''' </summary>
	Public Sub SetDynamicsCompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DynamicsCompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyGP_.DynamicsCompanyID field.
	''' </summary>
	Public Sub SetDynamicsCompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DynamicsCompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyGP_.DynamicsCompanyID field.
	''' </summary>
	Public Sub SetDynamicsCompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DynamicsCompanyIDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_ANFLO_DW_CompanyGP_.CompanyID field.
	''' </summary>
	Public Property CompanyID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CompanyIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CompanyIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CompanyIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CompanyIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CompanyIDDefault() As String
        Get
            Return TableUtils.CompanyIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_ANFLO_DW_CompanyGP_.Name field.
	''' </summary>
	Public Property Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property NameDefault() As String
        Get
            Return TableUtils.NameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_ANFLO_DW_CompanyGP_.ShortName field.
	''' </summary>
	Public Property ShortName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ShortNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ShortNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ShortNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ShortNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ShortNameDefault() As String
        Get
            Return TableUtils.ShortNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_ANFLO_DW_CompanyGP_.GroupID field.
	''' </summary>
	Public Property GroupID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.GroupIDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.GroupIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property GroupIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.GroupIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property GroupIDDefault() As String
        Get
            Return TableUtils.GroupIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_ANFLO_DW_CompanyGP_.DynamicsCompanyID field.
	''' </summary>
	Public Property DynamicsCompanyID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DynamicsCompanyIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DynamicsCompanyIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DynamicsCompanyIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DynamicsCompanyIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DynamicsCompanyIDDefault() As String
        Get
            Return TableUtils.DynamicsCompanyIDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
