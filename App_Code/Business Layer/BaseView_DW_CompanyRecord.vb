' This class is "generated" and will be overwritten.
' Your customizations should be made in View_DW_CompanyRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="View_DW_CompanyRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="View_DW_CompanyView"></see> class.
''' </remarks>
''' <seealso cref="View_DW_CompanyView"></seealso>
''' <seealso cref="View_DW_CompanyRecord"></seealso>

<Serializable()> Public Class BaseView_DW_CompanyRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As View_DW_CompanyView = View_DW_CompanyView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub View_DW_CompanyRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim View_DW_CompanyRec As View_DW_CompanyRecord = CType(sender,View_DW_CompanyRecord)
        If Not View_DW_CompanyRec Is Nothing AndAlso Not View_DW_CompanyRec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub View_DW_CompanyRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim View_DW_CompanyRec As View_DW_CompanyRecord = CType(sender,View_DW_CompanyRecord)
        Validate_Inserting()
        If Not View_DW_CompanyRec Is Nothing AndAlso Not View_DW_CompanyRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's View_DW_Company_.wass_C_ID field.
	''' </summary>
	Public Function Getwass_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.wass_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's View_DW_Company_.wass_C_ID field.
	''' </summary>
	Public Function Getwass_C_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.wass_C_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.wass_C_ID field.
	''' </summary>
	Public Sub Setwass_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.wass_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.wass_C_ID field.
	''' </summary>
	Public Sub Setwass_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.wass_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.wass_C_ID field.
	''' </summary>
	Public Sub Setwass_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.wass_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.wass_C_ID field.
	''' </summary>
	Public Sub Setwass_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.wass_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.wass_C_ID field.
	''' </summary>
	Public Sub Setwass_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.wass_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's View_DW_Company_.DW_C_ID field.
	''' </summary>
	Public Function GetDW_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DW_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's View_DW_Company_.DW_C_ID field.
	''' </summary>
	Public Function GetDW_C_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DW_C_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.DW_C_ID field.
	''' </summary>
	Public Sub SetDW_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DW_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.DW_C_ID field.
	''' </summary>
	Public Sub SetDW_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DW_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.DW_C_ID field.
	''' </summary>
	Public Sub SetDW_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DW_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.DW_C_ID field.
	''' </summary>
	Public Sub SetDW_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DW_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.DW_C_ID field.
	''' </summary>
	Public Sub SetDW_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DW_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's View_DW_Company_.Name field.
	''' </summary>
	Public Function GetNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's View_DW_Company_.Name field.
	''' </summary>
	Public Function GetNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.Name field.
	''' </summary>
	Public Sub SetNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.Name field.
	''' </summary>
	Public Sub SetNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's View_DW_Company_.ShortName field.
	''' </summary>
	Public Function GetShortNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.ShortNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's View_DW_Company_.ShortName field.
	''' </summary>
	Public Function GetShortNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ShortNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.ShortName field.
	''' </summary>
	Public Sub SetShortNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ShortNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.ShortName field.
	''' </summary>
	Public Sub SetShortNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ShortNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's View_DW_Company_.GroupID field.
	''' </summary>
	Public Function GetGroupIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.GroupIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's View_DW_Company_.GroupID field.
	''' </summary>
	Public Function GetGroupIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.GroupIDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.GroupID field.
	''' </summary>
	Public Sub SetGroupIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GroupIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.GroupID field.
	''' </summary>
	Public Sub SetGroupIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.GroupIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.GroupID field.
	''' </summary>
	Public Sub SetGroupIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GroupIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.GroupID field.
	''' </summary>
	Public Sub SetGroupIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GroupIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.GroupID field.
	''' </summary>
	Public Sub SetGroupIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GroupIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's View_DW_Company_.IsNonGP field.
	''' </summary>
	Public Function GetIsNonGPValue() As ColumnValue
		Return Me.GetValue(TableUtils.IsNonGPColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's View_DW_Company_.IsNonGP field.
	''' </summary>
	Public Function GetIsNonGPFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.IsNonGPColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.IsNonGP field.
	''' </summary>
	Public Sub SetIsNonGPFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IsNonGPColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.IsNonGP field.
	''' </summary>
	Public Sub SetIsNonGPFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.IsNonGPColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.IsNonGP field.
	''' </summary>
	Public Sub SetIsNonGPFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IsNonGPColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's View_DW_Company_.DynamicsCompanyID field.
	''' </summary>
	Public Function GetDynamicsCompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DynamicsCompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's View_DW_Company_.DynamicsCompanyID field.
	''' </summary>
	Public Function GetDynamicsCompanyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DynamicsCompanyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.DynamicsCompanyID field.
	''' </summary>
	Public Sub SetDynamicsCompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DynamicsCompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.DynamicsCompanyID field.
	''' </summary>
	Public Sub SetDynamicsCompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DynamicsCompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.DynamicsCompanyID field.
	''' </summary>
	Public Sub SetDynamicsCompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DynamicsCompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.DynamicsCompanyID field.
	''' </summary>
	Public Sub SetDynamicsCompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DynamicsCompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.DynamicsCompanyID field.
	''' </summary>
	Public Sub SetDynamicsCompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DynamicsCompanyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's View_DW_Company_.GPInterID field.
	''' </summary>
	Public Function GetGPInterIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.GPInterIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's View_DW_Company_.GPInterID field.
	''' </summary>
	Public Function GetGPInterIDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.GPInterIDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.GPInterID field.
	''' </summary>
	Public Sub SetGPInterIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.GPInterIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's View_DW_Company_.GPInterID field.
	''' </summary>
	Public Sub SetGPInterIDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.GPInterIDColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's View_DW_Company_.wass_C_ID field.
	''' </summary>
	Public Property wass_C_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.wass_C_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.wass_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property wass_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.wass_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property wass_C_IDDefault() As String
        Get
            Return TableUtils.wass_C_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's View_DW_Company_.DW_C_ID field.
	''' </summary>
	Public Property DW_C_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DW_C_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DW_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DW_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DW_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DW_C_IDDefault() As String
        Get
            Return TableUtils.DW_C_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's View_DW_Company_.Name field.
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
	''' This is a convenience property that provides direct access to the value of the record's View_DW_Company_.ShortName field.
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
	''' This is a convenience property that provides direct access to the value of the record's View_DW_Company_.GroupID field.
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
	''' This is a convenience property that provides direct access to the value of the record's View_DW_Company_.IsNonGP field.
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
	''' This is a convenience property that provides direct access to the value of the record's View_DW_Company_.DynamicsCompanyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's View_DW_Company_.GPInterID field.
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



#End Region

End Class
End Namespace
