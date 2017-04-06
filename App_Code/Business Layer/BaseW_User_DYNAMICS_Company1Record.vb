' This class is "generated" and will be overwritten.
' Your customizations should be made in W_User_DYNAMICS_Company1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="W_User_DYNAMICS_Company1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="W_User_DYNAMICS_Company1Table"></see> class.
''' </remarks>
''' <seealso cref="W_User_DYNAMICS_Company1Table"></seealso>
''' <seealso cref="W_User_DYNAMICS_Company1Record"></seealso>

<Serializable()> Public Class BaseW_User_DYNAMICS_Company1Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As W_User_DYNAMICS_Company1Table = W_User_DYNAMICS_Company1Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub W_User_DYNAMICS_Company1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim W_User_DYNAMICS_Company1Rec As W_User_DYNAMICS_Company1Record = CType(sender,W_User_DYNAMICS_Company1Record)
        Validate_Inserting()
        If Not W_User_DYNAMICS_Company1Rec Is Nothing AndAlso Not W_User_DYNAMICS_Company1Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub W_User_DYNAMICS_Company1Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim W_User_DYNAMICS_Company1Rec As W_User_DYNAMICS_Company1Record = CType(sender,W_User_DYNAMICS_Company1Record)
        Validate_Updating()
        If Not W_User_DYNAMICS_Company1Rec Is Nothing AndAlso Not W_User_DYNAMICS_Company1Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub W_User_DYNAMICS_Company1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim W_User_DYNAMICS_Company1Rec As W_User_DYNAMICS_Company1Record = CType(sender,W_User_DYNAMICS_Company1Record)
        If Not W_User_DYNAMICS_Company1Rec Is Nothing AndAlso Not W_User_DYNAMICS_Company1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's W_User_DYNAMICS_Company_.W_UDC_ID field.
	''' </summary>
	Public Function GetW_UDC_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_UDC_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_DYNAMICS_Company_.W_UDC_ID field.
	''' </summary>
	Public Function GetW_UDC_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.W_UDC_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_DYNAMICS_Company_.W_UDC_U_ID field.
	''' </summary>
	Public Function GetW_UDC_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_UDC_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_DYNAMICS_Company_.W_UDC_U_ID field.
	''' </summary>
	Public Function GetW_UDC_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.W_UDC_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_DYNAMICS_Company_.W_UDC_U_ID field.
	''' </summary>
	Public Sub SetW_UDC_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_UDC_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_DYNAMICS_Company_.W_UDC_U_ID field.
	''' </summary>
	Public Sub SetW_UDC_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.W_UDC_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_DYNAMICS_Company_.W_UDC_U_ID field.
	''' </summary>
	Public Sub SetW_UDC_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_UDC_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_DYNAMICS_Company_.W_UDC_U_ID field.
	''' </summary>
	Public Sub SetW_UDC_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_UDC_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_DYNAMICS_Company_.W_UDC_U_ID field.
	''' </summary>
	Public Sub SetW_UDC_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_UDC_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_DYNAMICS_Company_.W_UDC_C_ID field.
	''' </summary>
	Public Function GetW_UDC_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_UDC_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's W_User_DYNAMICS_Company_.W_UDC_C_ID field.
	''' </summary>
	Public Function GetW_UDC_C_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.W_UDC_C_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_DYNAMICS_Company_.W_UDC_C_ID field.
	''' </summary>
	Public Sub SetW_UDC_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_UDC_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_DYNAMICS_Company_.W_UDC_C_ID field.
	''' </summary>
	Public Sub SetW_UDC_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.W_UDC_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_DYNAMICS_Company_.W_UDC_C_ID field.
	''' </summary>
	Public Sub SetW_UDC_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_UDC_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_DYNAMICS_Company_.W_UDC_C_ID field.
	''' </summary>
	Public Sub SetW_UDC_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_UDC_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's W_User_DYNAMICS_Company_.W_UDC_C_ID field.
	''' </summary>
	Public Sub SetW_UDC_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_UDC_C_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_User_DYNAMICS_Company_.W_UDC_ID field.
	''' </summary>
	Public Property W_UDC_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.W_UDC_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.W_UDC_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_UDC_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_UDC_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_UDC_IDDefault() As String
        Get
            Return TableUtils.W_UDC_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_User_DYNAMICS_Company_.W_UDC_U_ID field.
	''' </summary>
	Public Property W_UDC_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.W_UDC_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.W_UDC_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_UDC_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_UDC_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_UDC_U_IDDefault() As String
        Get
            Return TableUtils.W_UDC_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's W_User_DYNAMICS_Company_.W_UDC_C_ID field.
	''' </summary>
	Public Property W_UDC_C_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.W_UDC_C_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.W_UDC_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_UDC_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_UDC_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_UDC_C_IDDefault() As String
        Get
            Return TableUtils.W_UDC_C_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
