' This class is "generated" and will be overwritten.
' Your customizations should be made in WASS_Dynamics_Comp_EqRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WASS_Dynamics_Comp_EqRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WASS_Dynamics_Comp_EqTable"></see> class.
''' </remarks>
''' <seealso cref="WASS_Dynamics_Comp_EqTable"></seealso>
''' <seealso cref="WASS_Dynamics_Comp_EqRecord"></seealso>

<Serializable()> Public Class BaseWASS_Dynamics_Comp_EqRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WASS_Dynamics_Comp_EqTable = WASS_Dynamics_Comp_EqTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WASS_Dynamics_Comp_EqRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WASS_Dynamics_Comp_EqRec As WASS_Dynamics_Comp_EqRecord = CType(sender,WASS_Dynamics_Comp_EqRecord)
        Validate_Inserting()
        If Not WASS_Dynamics_Comp_EqRec Is Nothing AndAlso Not WASS_Dynamics_Comp_EqRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WASS_Dynamics_Comp_EqRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WASS_Dynamics_Comp_EqRec As WASS_Dynamics_Comp_EqRecord = CType(sender,WASS_Dynamics_Comp_EqRecord)
        Validate_Updating()
        If Not WASS_Dynamics_Comp_EqRec Is Nothing AndAlso Not WASS_Dynamics_Comp_EqRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WASS_Dynamics_Comp_EqRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WASS_Dynamics_Comp_EqRec As WASS_Dynamics_Comp_EqRecord = CType(sender,WASS_Dynamics_Comp_EqRecord)
        If Not WASS_Dynamics_Comp_EqRec Is Nothing AndAlso Not WASS_Dynamics_Comp_EqRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_ID field.
	''' </summary>
	Public Function GetWDCE_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WDCE_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_ID field.
	''' </summary>
	Public Function GetWDCE_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WDCE_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_WASS_CompID field.
	''' </summary>
	Public Function GetWDCE_WASS_CompIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WDCE_WASS_CompIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_WASS_CompID field.
	''' </summary>
	Public Function GetWDCE_WASS_CompIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WDCE_WASS_CompIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_WASS_CompID field.
	''' </summary>
	Public Sub SetWDCE_WASS_CompIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WDCE_WASS_CompIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_WASS_CompID field.
	''' </summary>
	Public Sub SetWDCE_WASS_CompIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WDCE_WASS_CompIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_WASS_CompID field.
	''' </summary>
	Public Sub SetWDCE_WASS_CompIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WDCE_WASS_CompIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_WASS_CompID field.
	''' </summary>
	Public Sub SetWDCE_WASS_CompIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WDCE_WASS_CompIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_WASS_CompID field.
	''' </summary>
	Public Sub SetWDCE_WASS_CompIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WDCE_WASS_CompIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_Dynamics_CompID field.
	''' </summary>
	Public Function GetWDCE_Dynamics_CompIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WDCE_Dynamics_CompIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_Dynamics_CompID field.
	''' </summary>
	Public Function GetWDCE_Dynamics_CompIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WDCE_Dynamics_CompIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_Dynamics_CompID field.
	''' </summary>
	Public Sub SetWDCE_Dynamics_CompIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WDCE_Dynamics_CompIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_Dynamics_CompID field.
	''' </summary>
	Public Sub SetWDCE_Dynamics_CompIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WDCE_Dynamics_CompIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_Dynamics_CompID field.
	''' </summary>
	Public Sub SetWDCE_Dynamics_CompIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WDCE_Dynamics_CompIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_Dynamics_CompID field.
	''' </summary>
	Public Sub SetWDCE_Dynamics_CompIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WDCE_Dynamics_CompIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_Dynamics_CompID field.
	''' </summary>
	Public Sub SetWDCE_Dynamics_CompIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WDCE_Dynamics_CompIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_CompName field.
	''' </summary>
	Public Function GetWDCE_CompNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.WDCE_CompNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_CompName field.
	''' </summary>
	Public Function GetWDCE_CompNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WDCE_CompNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_CompName field.
	''' </summary>
	Public Sub SetWDCE_CompNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WDCE_CompNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_CompName field.
	''' </summary>
	Public Sub SetWDCE_CompNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WDCE_CompNameColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_ID field.
	''' </summary>
	Public Property WDCE_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WDCE_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WDCE_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WDCE_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WDCE_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WDCE_IDDefault() As String
        Get
            Return TableUtils.WDCE_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_WASS_CompID field.
	''' </summary>
	Public Property WDCE_WASS_CompID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WDCE_WASS_CompIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WDCE_WASS_CompIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WDCE_WASS_CompIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WDCE_WASS_CompIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WDCE_WASS_CompIDDefault() As String
        Get
            Return TableUtils.WDCE_WASS_CompIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_Dynamics_CompID field.
	''' </summary>
	Public Property WDCE_Dynamics_CompID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WDCE_Dynamics_CompIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WDCE_Dynamics_CompIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WDCE_Dynamics_CompIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WDCE_Dynamics_CompIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WDCE_Dynamics_CompIDDefault() As String
        Get
            Return TableUtils.WDCE_Dynamics_CompIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WASS_Dynamics_Comp_Eq_.WDCE_CompName field.
	''' </summary>
	Public Property WDCE_CompName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WDCE_CompNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WDCE_CompNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WDCE_CompNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WDCE_CompNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WDCE_CompNameDefault() As String
        Get
            Return TableUtils.WDCE_CompNameColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
