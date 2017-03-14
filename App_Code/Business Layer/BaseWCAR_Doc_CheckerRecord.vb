' This class is "generated" and will be overwritten.
' Your customizations should be made in WCAR_Doc_CheckerRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WCAR_Doc_CheckerRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WCAR_Doc_CheckerTable"></see> class.
''' </remarks>
''' <seealso cref="WCAR_Doc_CheckerTable"></seealso>
''' <seealso cref="WCAR_Doc_CheckerRecord"></seealso>

<Serializable()> Public Class BaseWCAR_Doc_CheckerRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WCAR_Doc_CheckerTable = WCAR_Doc_CheckerTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WCAR_Doc_CheckerRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WCAR_Doc_CheckerRec As WCAR_Doc_CheckerRecord = CType(sender,WCAR_Doc_CheckerRecord)
        Validate_Inserting()
        If Not WCAR_Doc_CheckerRec Is Nothing AndAlso Not WCAR_Doc_CheckerRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WCAR_Doc_CheckerRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WCAR_Doc_CheckerRec As WCAR_Doc_CheckerRecord = CType(sender,WCAR_Doc_CheckerRecord)
        Validate_Updating()
        If Not WCAR_Doc_CheckerRec Is Nothing AndAlso Not WCAR_Doc_CheckerRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WCAR_Doc_CheckerRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WCAR_Doc_CheckerRec As WCAR_Doc_CheckerRecord = CType(sender,WCAR_Doc_CheckerRecord)
        If Not WCAR_Doc_CheckerRec Is Nothing AndAlso Not WCAR_Doc_CheckerRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Checker_.WCDC_ID field.
	''' </summary>
	Public Function GetWCDC_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDC_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Checker_.WCDC_ID field.
	''' </summary>
	Public Function GetWCDC_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCDC_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Checker_.WCDC_WCD_ID field.
	''' </summary>
	Public Function GetWCDC_WCD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDC_WCD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Checker_.WCDC_WCD_ID field.
	''' </summary>
	Public Function GetWCDC_WCD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCDC_WCD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Checker_.WCDC_WCD_ID field.
	''' </summary>
	Public Sub SetWCDC_WCD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDC_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Checker_.WCDC_WCD_ID field.
	''' </summary>
	Public Sub SetWCDC_WCD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDC_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Checker_.WCDC_WCD_ID field.
	''' </summary>
	Public Sub SetWCDC_WCD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDC_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Checker_.WCDC_WCD_ID field.
	''' </summary>
	Public Sub SetWCDC_WCD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDC_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Checker_.WCDC_WCD_ID field.
	''' </summary>
	Public Sub SetWCDC_WCD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDC_WCD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Checker_.WCDC_U_ID field.
	''' </summary>
	Public Function GetWCDC_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDC_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Checker_.WCDC_U_ID field.
	''' </summary>
	Public Function GetWCDC_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCDC_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Checker_.WCDC_U_ID field.
	''' </summary>
	Public Sub SetWCDC_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDC_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Checker_.WCDC_U_ID field.
	''' </summary>
	Public Sub SetWCDC_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDC_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Checker_.WCDC_U_ID field.
	''' </summary>
	Public Sub SetWCDC_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDC_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Checker_.WCDC_U_ID field.
	''' </summary>
	Public Sub SetWCDC_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDC_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Checker_.WCDC_U_ID field.
	''' </summary>
	Public Sub SetWCDC_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDC_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Checker_.WCDC_Status field.
	''' </summary>
	Public Function GetWCDC_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDC_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Checker_.WCDC_Status field.
	''' </summary>
	Public Function GetWCDC_StatusFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDC_StatusColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Checker_.WCDC_Status field.
	''' </summary>
	Public Sub SetWCDC_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDC_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Checker_.WCDC_Status field.
	''' </summary>
	Public Sub SetWCDC_StatusFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDC_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Checker_.WCDC_Rem field.
	''' </summary>
	Public Function GetWCDC_RemValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDC_RemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Checker_.WCDC_Rem field.
	''' </summary>
	Public Function GetWCDC_RemFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDC_RemColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Checker_.WCDC_Rem field.
	''' </summary>
	Public Sub SetWCDC_RemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDC_RemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Checker_.WCDC_Rem field.
	''' </summary>
	Public Sub SetWCDC_RemFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDC_RemColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCAR_Doc_Checker_.WCDC_ID field.
	''' </summary>
	Public Property WCDC_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCDC_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDC_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDC_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDC_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDC_IDDefault() As String
        Get
            Return TableUtils.WCDC_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCAR_Doc_Checker_.WCDC_WCD_ID field.
	''' </summary>
	Public Property WCDC_WCD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCDC_WCD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDC_WCD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDC_WCD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDC_WCD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDC_WCD_IDDefault() As String
        Get
            Return TableUtils.WCDC_WCD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCAR_Doc_Checker_.WCDC_U_ID field.
	''' </summary>
	Public Property WCDC_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCDC_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDC_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDC_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDC_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDC_U_IDDefault() As String
        Get
            Return TableUtils.WCDC_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCAR_Doc_Checker_.WCDC_Status field.
	''' </summary>
	Public Property WCDC_Status() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCDC_StatusColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCDC_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDC_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDC_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDC_StatusDefault() As String
        Get
            Return TableUtils.WCDC_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCAR_Doc_Checker_.WCDC_Rem field.
	''' </summary>
	Public Property WCDC_Rem() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCDC_RemColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCDC_RemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDC_RemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDC_RemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDC_RemDefault() As String
        Get
            Return TableUtils.WCDC_RemColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
