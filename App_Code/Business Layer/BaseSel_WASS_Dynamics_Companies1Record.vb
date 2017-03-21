' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WASS_Dynamics_Companies1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_WASS_Dynamics_Companies1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WASS_Dynamics_Companies1View"></see> class.
''' </remarks>
''' <seealso cref="Sel_WASS_Dynamics_Companies1View"></seealso>
''' <seealso cref="Sel_WASS_Dynamics_Companies1Record"></seealso>

<Serializable()> Public Class BaseSel_WASS_Dynamics_Companies1Record
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_WASS_Dynamics_Companies1View = Sel_WASS_Dynamics_Companies1View.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_WASS_Dynamics_Companies1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_WASS_Dynamics_Companies1Rec As Sel_WASS_Dynamics_Companies1Record = CType(sender,Sel_WASS_Dynamics_Companies1Record)
        If Not Sel_WASS_Dynamics_Companies1Rec Is Nothing AndAlso Not Sel_WASS_Dynamics_Companies1Rec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_WASS_Dynamics_Companies1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_WASS_Dynamics_Companies1Rec As Sel_WASS_Dynamics_Companies1Record = CType(sender,Sel_WASS_Dynamics_Companies1Record)
        Validate_Inserting()
        If Not Sel_WASS_Dynamics_Companies1Rec Is Nothing AndAlso Not Sel_WASS_Dynamics_Companies1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's sel_WASS_Dynamics_Companies_.SSC_CompanyName field.
	''' </summary>
	Public Function GetSSC_CompanyNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSC_CompanyNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WASS_Dynamics_Companies_.SSC_CompanyName field.
	''' </summary>
	Public Function GetSSC_CompanyNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSC_CompanyNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WASS_Dynamics_Companies_.SSC_CompanyName field.
	''' </summary>
	Public Sub SetSSC_CompanyNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSC_CompanyNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WASS_Dynamics_Companies_.SSC_CompanyName field.
	''' </summary>
	Public Sub SetSSC_CompanyNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSC_CompanyNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WASS_Dynamics_Companies_.SSC_Description field.
	''' </summary>
	Public Function GetSSC_DescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSC_DescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WASS_Dynamics_Companies_.SSC_Description field.
	''' </summary>
	Public Function GetSSC_DescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSC_DescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WASS_Dynamics_Companies_.SSC_Description field.
	''' </summary>
	Public Sub SetSSC_DescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSC_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WASS_Dynamics_Companies_.SSC_Description field.
	''' </summary>
	Public Sub SetSSC_DescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSC_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WASS_Dynamics_Companies_.INTERID field.
	''' </summary>
	Public Function GetINTERIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.INTERIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WASS_Dynamics_Companies_.INTERID field.
	''' </summary>
	Public Function GetINTERIDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.INTERIDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WASS_Dynamics_Companies_.INTERID field.
	''' </summary>
	Public Sub SetINTERIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.INTERIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WASS_Dynamics_Companies_.INTERID field.
	''' </summary>
	Public Sub SetINTERIDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.INTERIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WASS_Dynamics_Companies_.SSC_CompanyID field.
	''' </summary>
	Public Function GetSSC_CompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSC_CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WASS_Dynamics_Companies_.SSC_CompanyID field.
	''' </summary>
	Public Function GetSSC_CompanyIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.SSC_CompanyIDColumn).ToInt16(), Int16)
	End Function



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WASS_Dynamics_Companies_.SSC_CompanyName field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_WASS_Dynamics_Companies_.SSC_Description field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_WASS_Dynamics_Companies_.INTERID field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_WASS_Dynamics_Companies_.SSC_CompanyID field.
	''' </summary>
	Public Property SSC_CompanyID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.SSC_CompanyIDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSC_CompanyIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSC_CompanyIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSC_CompanyIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSC_CompanyIDDefault() As String
        Get
            Return TableUtils.SSC_CompanyIDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
