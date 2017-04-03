' This class is "generated" and will be overwritten.
' Your customizations should be made in CompanyRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="CompanyRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="CompanyTable"></see> class.
''' </remarks>
''' <seealso cref="CompanyTable"></seealso>
''' <seealso cref="CompanyRecord"></seealso>

<Serializable()> Public Class BaseCompanyRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As CompanyTable = CompanyTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub CompanyRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim CompanyRec As CompanyRecord = CType(sender,CompanyRecord)
        Validate_Inserting()
        If Not CompanyRec Is Nothing AndAlso Not CompanyRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub CompanyRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim CompanyRec As CompanyRecord = CType(sender,CompanyRecord)
        Validate_Updating()
        If Not CompanyRec Is Nothing AndAlso Not CompanyRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub CompanyRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim CompanyRec As CompanyRecord = CType(sender,CompanyRecord)
        If Not CompanyRec Is Nothing AndAlso Not CompanyRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's Company_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CompanyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.Name field.
	''' </summary>
	Public Function GetNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.Name field.
	''' </summary>
	Public Function GetNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.Name field.
	''' </summary>
	Public Sub SetNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.Name field.
	''' </summary>
	Public Sub SetNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.ShortName field.
	''' </summary>
	Public Function GetShortNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.ShortNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.ShortName field.
	''' </summary>
	Public Function GetShortNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ShortNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.ShortName field.
	''' </summary>
	Public Sub SetShortNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ShortNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.ShortName field.
	''' </summary>
	Public Sub SetShortNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ShortNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.GroupID field.
	''' </summary>
	Public Function GetGroupIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.GroupIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.GroupID field.
	''' </summary>
	Public Function GetGroupIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.GroupIDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.GroupID field.
	''' </summary>
	Public Sub SetGroupIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GroupIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.GroupID field.
	''' </summary>
	Public Sub SetGroupIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.GroupIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.GroupID field.
	''' </summary>
	Public Sub SetGroupIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GroupIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.GroupID field.
	''' </summary>
	Public Sub SetGroupIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GroupIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.GroupID field.
	''' </summary>
	Public Sub SetGroupIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GroupIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.IsNonGP field.
	''' </summary>
	Public Function GetIsNonGPValue() As ColumnValue
		Return Me.GetValue(TableUtils.IsNonGPColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.IsNonGP field.
	''' </summary>
	Public Function GetIsNonGPFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.IsNonGPColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.IsNonGP field.
	''' </summary>
	Public Sub SetIsNonGPFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IsNonGPColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.IsNonGP field.
	''' </summary>
	Public Sub SetIsNonGPFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.IsNonGPColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.IsNonGP field.
	''' </summary>
	Public Sub SetIsNonGPFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IsNonGPColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.DynamicsCompanyID field.
	''' </summary>
	Public Function GetDynamicsCompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DynamicsCompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.DynamicsCompanyID field.
	''' </summary>
	Public Function GetDynamicsCompanyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DynamicsCompanyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.DynamicsCompanyID field.
	''' </summary>
	Public Sub SetDynamicsCompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DynamicsCompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.DynamicsCompanyID field.
	''' </summary>
	Public Sub SetDynamicsCompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DynamicsCompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.DynamicsCompanyID field.
	''' </summary>
	Public Sub SetDynamicsCompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DynamicsCompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.DynamicsCompanyID field.
	''' </summary>
	Public Sub SetDynamicsCompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DynamicsCompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.DynamicsCompanyID field.
	''' </summary>
	Public Sub SetDynamicsCompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DynamicsCompanyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.CreatedBy field.
	''' </summary>
	Public Function GetCreatedByValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.CreatedBy field.
	''' </summary>
	Public Function GetCreatedByFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.CreatedBy field.
	''' </summary>
	Public Sub SetCreatedByFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.CreatedBy field.
	''' </summary>
	Public Sub SetCreatedByFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.CreatedBy field.
	''' </summary>
	Public Sub SetCreatedByFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.CreatedBy field.
	''' </summary>
	Public Sub SetCreatedByFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.CreatedBy field.
	''' </summary>
	Public Sub SetCreatedByFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.DateCreated field.
	''' </summary>
	Public Function GetDateCreatedValue() As ColumnValue
		Return Me.GetValue(TableUtils.DateCreatedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.DateCreated field.
	''' </summary>
	Public Function GetDateCreatedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.DateCreatedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.DateCreated field.
	''' </summary>
	Public Sub SetDateCreatedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.DateCreated field.
	''' </summary>
	Public Sub SetDateCreatedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.DateCreated field.
	''' </summary>
	Public Sub SetDateCreatedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.ModifiedBy field.
	''' </summary>
	Public Function GetModifiedByValue() As ColumnValue
		Return Me.GetValue(TableUtils.ModifiedByColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.ModifiedBy field.
	''' </summary>
	Public Function GetModifiedByFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ModifiedByColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.ModifiedBy field.
	''' </summary>
	Public Sub SetModifiedByFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ModifiedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.ModifiedBy field.
	''' </summary>
	Public Sub SetModifiedByFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ModifiedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.ModifiedBy field.
	''' </summary>
	Public Sub SetModifiedByFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ModifiedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.ModifiedBy field.
	''' </summary>
	Public Sub SetModifiedByFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ModifiedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.ModifiedBy field.
	''' </summary>
	Public Sub SetModifiedByFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ModifiedByColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.DateModified field.
	''' </summary>
	Public Function GetDateModifiedValue() As ColumnValue
		Return Me.GetValue(TableUtils.DateModifiedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.DateModified field.
	''' </summary>
	Public Function GetDateModifiedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.DateModifiedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.DateModified field.
	''' </summary>
	Public Sub SetDateModifiedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DateModifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.DateModified field.
	''' </summary>
	Public Sub SetDateModifiedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DateModifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.DateModified field.
	''' </summary>
	Public Sub SetDateModifiedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DateModifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.GPInterID field.
	''' </summary>
	Public Function GetGPInterIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.GPInterIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.GPInterID field.
	''' </summary>
	Public Function GetGPInterIDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.GPInterIDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.GPInterID field.
	''' </summary>
	Public Sub SetGPInterIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GPInterIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.GPInterID field.
	''' </summary>
	Public Sub SetGPInterIDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GPInterIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.IsConso field.
	''' </summary>
	Public Function GetIsConsoValue() As ColumnValue
		Return Me.GetValue(TableUtils.IsConsoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.IsConso field.
	''' </summary>
	Public Function GetIsConsoFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.IsConsoColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.IsConso field.
	''' </summary>
	Public Sub SetIsConsoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IsConsoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.IsConso field.
	''' </summary>
	Public Sub SetIsConsoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.IsConsoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.IsConso field.
	''' </summary>
	Public Sub SetIsConsoFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IsConsoColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.CompanyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Company_.Name field.
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
	''' This is a convenience property that provides direct access to the value of the record's Company_.ShortName field.
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
	''' This is a convenience property that provides direct access to the value of the record's Company_.GroupID field.
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
	''' This is a convenience property that provides direct access to the value of the record's Company_.IsNonGP field.
	''' </summary>
	Public Property IsNonGP() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.IsNonGPColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.DynamicsCompanyID field.
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.CreatedBy field.
	''' </summary>
	Public Property CreatedBy() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CreatedByColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CreatedByColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CreatedBySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CreatedByColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CreatedByDefault() As String
        Get
            Return TableUtils.CreatedByColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.DateCreated field.
	''' </summary>
	Public Property DateCreated() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.DateCreatedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DateCreatedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DateCreatedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DateCreatedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DateCreatedDefault() As String
        Get
            Return TableUtils.DateCreatedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.ModifiedBy field.
	''' </summary>
	Public Property ModifiedBy() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ModifiedByColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ModifiedByColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ModifiedBySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ModifiedByColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ModifiedByDefault() As String
        Get
            Return TableUtils.ModifiedByColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.DateModified field.
	''' </summary>
	Public Property DateModified() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.DateModifiedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DateModifiedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DateModifiedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DateModifiedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DateModifiedDefault() As String
        Get
            Return TableUtils.DateModifiedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.GPInterID field.
	''' </summary>
	Public Property GPInterID() As String
		Get 
			Return CType(Me.GetValue(TableUtils.GPInterIDColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.GPInterIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property GPInterIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.GPInterIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property GPInterIDDefault() As String
        Get
            Return TableUtils.GPInterIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.IsConso field.
	''' </summary>
	Public Property IsConso() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.IsConsoColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.IsConsoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property IsConsoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.IsConsoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property IsConsoDefault() As String
        Get
            Return TableUtils.IsConsoColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
