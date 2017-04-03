' This class is "generated" and will be overwritten.
' Your customizations should be made in Vw_ANFLO_DW_CompanyNonGPRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Vw_ANFLO_DW_CompanyNonGPRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Vw_ANFLO_DW_CompanyNonGPView"></see> class.
''' </remarks>
''' <seealso cref="Vw_ANFLO_DW_CompanyNonGPView"></seealso>
''' <seealso cref="Vw_ANFLO_DW_CompanyNonGPRecord"></seealso>

<Serializable()> Public Class BaseVw_ANFLO_DW_CompanyNonGPRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As Vw_ANFLO_DW_CompanyNonGPView = Vw_ANFLO_DW_CompanyNonGPView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Vw_ANFLO_DW_CompanyNonGPRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Vw_ANFLO_DW_CompanyNonGPRec As Vw_ANFLO_DW_CompanyNonGPRecord = CType(sender,Vw_ANFLO_DW_CompanyNonGPRecord)
        If Not Vw_ANFLO_DW_CompanyNonGPRec Is Nothing AndAlso Not Vw_ANFLO_DW_CompanyNonGPRec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Vw_ANFLO_DW_CompanyNonGPRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Vw_ANFLO_DW_CompanyNonGPRec As Vw_ANFLO_DW_CompanyNonGPRecord = CType(sender,Vw_ANFLO_DW_CompanyNonGPRecord)
        Validate_Inserting()
        If Not Vw_ANFLO_DW_CompanyNonGPRec Is Nothing AndAlso Not Vw_ANFLO_DW_CompanyNonGPRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyNonGP_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyNonGP_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.CompanyIDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyNonGP_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyNonGP_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyNonGP_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyNonGP_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyNonGP_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyNonGP_.Name field.
	''' </summary>
	Public Function GetNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyNonGP_.Name field.
	''' </summary>
	Public Function GetNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyNonGP_.Name field.
	''' </summary>
	Public Sub SetNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyNonGP_.Name field.
	''' </summary>
	Public Sub SetNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyNonGP_.ShortName field.
	''' </summary>
	Public Function GetShortNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.ShortNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyNonGP_.ShortName field.
	''' </summary>
	Public Function GetShortNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ShortNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyNonGP_.ShortName field.
	''' </summary>
	Public Sub SetShortNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ShortNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyNonGP_.ShortName field.
	''' </summary>
	Public Sub SetShortNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ShortNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyNonGP_.INTERID field.
	''' </summary>
	Public Function GetINTERIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.INTERIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyNonGP_.INTERID field.
	''' </summary>
	Public Function GetINTERIDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.INTERIDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyNonGP_.INTERID field.
	''' </summary>
	Public Sub SetINTERIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.INTERIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyNonGP_.INTERID field.
	''' </summary>
	Public Sub SetINTERIDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.INTERIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyNonGP_.FULLADDRESS field.
	''' </summary>
	Public Function GetFULLADDRESSValue() As ColumnValue
		Return Me.GetValue(TableUtils.FULLADDRESSColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyNonGP_.FULLADDRESS field.
	''' </summary>
	Public Function GetFULLADDRESSFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FULLADDRESSColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyNonGP_.FULLADDRESS field.
	''' </summary>
	Public Sub SetFULLADDRESSFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FULLADDRESSColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyNonGP_.FULLADDRESS field.
	''' </summary>
	Public Sub SetFULLADDRESSFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FULLADDRESSColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyNonGP_.DWCompanyID field.
	''' </summary>
	Public Function GetDWCompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DWCompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_ANFLO_DW_CompanyNonGP_.DWCompanyID field.
	''' </summary>
	Public Function GetDWCompanyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DWCompanyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyNonGP_.DWCompanyID field.
	''' </summary>
	Public Sub SetDWCompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DWCompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyNonGP_.DWCompanyID field.
	''' </summary>
	Public Sub SetDWCompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DWCompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyNonGP_.DWCompanyID field.
	''' </summary>
	Public Sub SetDWCompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DWCompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyNonGP_.DWCompanyID field.
	''' </summary>
	Public Sub SetDWCompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DWCompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_ANFLO_DW_CompanyNonGP_.DWCompanyID field.
	''' </summary>
	Public Sub SetDWCompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DWCompanyIDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_ANFLO_DW_CompanyNonGP_.CompanyID field.
	''' </summary>
	Public Property CompanyID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.CompanyIDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
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
	''' This is a convenience property that provides direct access to the value of the record's vw_ANFLO_DW_CompanyNonGP_.Name field.
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
	''' This is a convenience property that provides direct access to the value of the record's vw_ANFLO_DW_CompanyNonGP_.ShortName field.
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
	''' This is a convenience property that provides direct access to the value of the record's vw_ANFLO_DW_CompanyNonGP_.INTERID field.
	''' </summary>
	Public Property INTERID() As String
		Get 
			Return CType(Me.GetValue(TableUtils.INTERIDColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.INTERIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property INTERIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.INTERIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property INTERIDDefault() As String
        Get
            Return TableUtils.INTERIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_ANFLO_DW_CompanyNonGP_.FULLADDRESS field.
	''' </summary>
	Public Property FULLADDRESS() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FULLADDRESSColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FULLADDRESSColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FULLADDRESSSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FULLADDRESSColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FULLADDRESSDefault() As String
        Get
            Return TableUtils.FULLADDRESSColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_ANFLO_DW_CompanyNonGP_.DWCompanyID field.
	''' </summary>
	Public Property DWCompanyID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DWCompanyIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DWCompanyIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DWCompanyIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DWCompanyIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DWCompanyIDDefault() As String
        Get
            Return TableUtils.DWCompanyIDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
