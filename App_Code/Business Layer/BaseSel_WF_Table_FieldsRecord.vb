' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WF_Table_FieldsRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_WF_Table_FieldsRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WF_Table_FieldsView"></see> class.
''' </remarks>
''' <seealso cref="Sel_WF_Table_FieldsView"></seealso>
''' <seealso cref="Sel_WF_Table_FieldsRecord"></seealso>

<Serializable()> Public Class BaseSel_WF_Table_FieldsRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_WF_Table_FieldsView = Sel_WF_Table_FieldsView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_WF_Table_FieldsRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_WF_Table_FieldsRec As Sel_WF_Table_FieldsRecord = CType(sender,Sel_WF_Table_FieldsRecord)
        If Not Sel_WF_Table_FieldsRec Is Nothing AndAlso Not Sel_WF_Table_FieldsRec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_WF_Table_FieldsRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_WF_Table_FieldsRec As Sel_WF_Table_FieldsRecord = CType(sender,Sel_WF_Table_FieldsRecord)
        Validate_Inserting()
        If Not Sel_WF_Table_FieldsRec Is Nothing AndAlso Not Sel_WF_Table_FieldsRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's sel_WF_Table_Fields_.Row field.
	''' </summary>
	Public Function GetRowValue() As ColumnValue
		Return Me.GetValue(TableUtils.RowColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WF_Table_Fields_.Row field.
	''' </summary>
	Public Function GetRowFieldValue() As Int64
		Return CType(Me.GetValue(TableUtils.RowColumn).ToInt64(), Int64)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WF_Table_Fields_.Row field.
	''' </summary>
	Public Sub SetRowFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RowColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WF_Table_Fields_.Row field.
	''' </summary>
	Public Sub SetRowFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RowColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WF_Table_Fields_.Row field.
	''' </summary>
	Public Sub SetRowFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RowColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WF_Table_Fields_.Row field.
	''' </summary>
	Public Sub SetRowFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RowColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WF_Table_Fields_.Row field.
	''' </summary>
	Public Sub SetRowFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RowColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WF_Table_Fields_.TABLE_NAME field.
	''' </summary>
	Public Function GetTABLE_NAMEValue() As ColumnValue
		Return Me.GetValue(TableUtils.TABLE_NAMEColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WF_Table_Fields_.TABLE_NAME field.
	''' </summary>
	Public Function GetTABLE_NAMEFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TABLE_NAMEColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WF_Table_Fields_.TABLE_NAME field.
	''' </summary>
	Public Sub SetTABLE_NAMEFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TABLE_NAMEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WF_Table_Fields_.TABLE_NAME field.
	''' </summary>
	Public Sub SetTABLE_NAMEFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TABLE_NAMEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WF_Table_Fields_.COLUMN_NAME field.
	''' </summary>
	Public Function GetCOLUMN_NAMEValue() As ColumnValue
		Return Me.GetValue(TableUtils.COLUMN_NAMEColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WF_Table_Fields_.COLUMN_NAME field.
	''' </summary>
	Public Function GetCOLUMN_NAMEFieldValue() As String
		Return CType(Me.GetValue(TableUtils.COLUMN_NAMEColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WF_Table_Fields_.COLUMN_NAME field.
	''' </summary>
	Public Sub SetCOLUMN_NAMEFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.COLUMN_NAMEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WF_Table_Fields_.COLUMN_NAME field.
	''' </summary>
	Public Sub SetCOLUMN_NAMEFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.COLUMN_NAMEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WF_Table_Fields_.IS_NULLABLE field.
	''' </summary>
	Public Function GetIS_NULLABLEValue() As ColumnValue
		Return Me.GetValue(TableUtils.IS_NULLABLEColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WF_Table_Fields_.IS_NULLABLE field.
	''' </summary>
	Public Function GetIS_NULLABLEFieldValue() As String
		Return CType(Me.GetValue(TableUtils.IS_NULLABLEColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WF_Table_Fields_.IS_NULLABLE field.
	''' </summary>
	Public Sub SetIS_NULLABLEFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IS_NULLABLEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WF_Table_Fields_.IS_NULLABLE field.
	''' </summary>
	Public Sub SetIS_NULLABLEFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IS_NULLABLEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WF_Table_Fields_.DATA_TYPE field.
	''' </summary>
	Public Function GetDATA_TYPEValue() As ColumnValue
		Return Me.GetValue(TableUtils.DATA_TYPEColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WF_Table_Fields_.DATA_TYPE field.
	''' </summary>
	Public Function GetDATA_TYPEFieldValue() As String
		Return CType(Me.GetValue(TableUtils.DATA_TYPEColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WF_Table_Fields_.DATA_TYPE field.
	''' </summary>
	Public Sub SetDATA_TYPEFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DATA_TYPEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WF_Table_Fields_.DATA_TYPE field.
	''' </summary>
	Public Sub SetDATA_TYPEFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DATA_TYPEColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WF_Table_Fields_.Row field.
	''' </summary>
	Public Property Row() As Int64
		Get 
			Return CType(Me.GetValue(TableUtils.RowColumn).ToInt64(), Int64)
		End Get
		Set (ByVal val As Int64) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RowColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RowSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RowColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RowDefault() As String
        Get
            Return TableUtils.RowColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WF_Table_Fields_.TABLE_NAME field.
	''' </summary>
	Public Property TABLE_NAME() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TABLE_NAMEColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TABLE_NAMEColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TABLE_NAMESpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TABLE_NAMEColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TABLE_NAMEDefault() As String
        Get
            Return TableUtils.TABLE_NAMEColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WF_Table_Fields_.COLUMN_NAME field.
	''' </summary>
	Public Property COLUMN_NAME() As String
		Get 
			Return CType(Me.GetValue(TableUtils.COLUMN_NAMEColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.COLUMN_NAMEColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property COLUMN_NAMESpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.COLUMN_NAMEColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property COLUMN_NAMEDefault() As String
        Get
            Return TableUtils.COLUMN_NAMEColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WF_Table_Fields_.IS_NULLABLE field.
	''' </summary>
	Public Property IS_NULLABLE() As String
		Get 
			Return CType(Me.GetValue(TableUtils.IS_NULLABLEColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.IS_NULLABLEColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property IS_NULLABLESpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.IS_NULLABLEColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property IS_NULLABLEDefault() As String
        Get
            Return TableUtils.IS_NULLABLEColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WF_Table_Fields_.DATA_TYPE field.
	''' </summary>
	Public Property DATA_TYPE() As String
		Get 
			Return CType(Me.GetValue(TableUtils.DATA_TYPEColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.DATA_TYPEColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DATA_TYPESpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DATA_TYPEColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DATA_TYPEDefault() As String
        Get
            Return TableUtils.DATA_TYPEColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
