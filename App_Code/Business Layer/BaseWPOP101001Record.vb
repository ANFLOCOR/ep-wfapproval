' This class is "generated" and will be overwritten.
' Your customizations should be made in WPOP101001Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WPOP101001Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WPOP101001Table"></see> class.
''' </remarks>
''' <seealso cref="WPOP101001Table"></seealso>
''' <seealso cref="WPOP101001Record"></seealso>

<Serializable()> Public Class BaseWPOP101001Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WPOP101001Table = WPOP101001Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WPOP101001Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WPOP101001Rec As WPOP101001Record = CType(sender,WPOP101001Record)
        Validate_Inserting()
        If Not WPOP101001Rec Is Nothing AndAlso Not WPOP101001Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WPOP101001Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WPOP101001Rec As WPOP101001Record = CType(sender,WPOP101001Record)
        Validate_Updating()
        If Not WPOP101001Rec Is Nothing AndAlso Not WPOP101001Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WPOP101001Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WPOP101001Rec As WPOP101001Record = CType(sender,WPOP101001Record)
        If Not WPOP101001Rec Is Nothing AndAlso Not WPOP101001Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_ID field.
	''' </summary>
	Public Function GetWPOP_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPOP_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_ID field.
	''' </summary>
	Public Function GetWPOP_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPOP_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_DT_ID field.
	''' </summary>
	Public Function GetWPOP_DT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPOP_DT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_DT_ID field.
	''' </summary>
	Public Function GetWPOP_DT_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPOP_DT_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_DT_ID field.
	''' </summary>
	Public Sub SetWPOP_DT_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPOP_DT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_DT_ID field.
	''' </summary>
	Public Sub SetWPOP_DT_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPOP_DT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_DT_ID field.
	''' </summary>
	Public Sub SetWPOP_DT_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_DT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_DT_ID field.
	''' </summary>
	Public Sub SetWPOP_DT_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_DT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_DT_ID field.
	''' </summary>
	Public Sub SetWPOP_DT_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_DT_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_PONMBR field.
	''' </summary>
	Public Function GetWPOP_PONMBRValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPOP_PONMBRColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_PONMBR field.
	''' </summary>
	Public Function GetWPOP_PONMBRFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPOP_PONMBRColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_PONMBR field.
	''' </summary>
	Public Sub SetWPOP_PONMBRFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPOP_PONMBRColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_PONMBR field.
	''' </summary>
	Public Sub SetWPOP_PONMBRFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_PONMBRColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_Submit field.
	''' </summary>
	Public Function GetWPOP_SubmitValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPOP_SubmitColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_Submit field.
	''' </summary>
	Public Function GetWPOP_SubmitFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WPOP_SubmitColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_Submit field.
	''' </summary>
	Public Sub SetWPOP_SubmitFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPOP_SubmitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_Submit field.
	''' </summary>
	Public Sub SetWPOP_SubmitFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPOP_SubmitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_Submit field.
	''' </summary>
	Public Sub SetWPOP_SubmitFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_SubmitColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_Status field.
	''' </summary>
	Public Function GetWPOP_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPOP_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_Status field.
	''' </summary>
	Public Function GetWPOP_StatusFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPOP_StatusColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_Status field.
	''' </summary>
	Public Sub SetWPOP_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPOP_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_Status field.
	''' </summary>
	Public Sub SetWPOP_StatusFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPOP_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_Status field.
	''' </summary>
	Public Sub SetWPOP_StatusFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_Status field.
	''' </summary>
	Public Sub SetWPOP_StatusFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_Status field.
	''' </summary>
	Public Sub SetWPOP_StatusFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_StatusColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_C_ID field.
	''' </summary>
	Public Function GetWPOP_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPOP_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_C_ID field.
	''' </summary>
	Public Function GetWPOP_C_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPOP_C_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_C_ID field.
	''' </summary>
	Public Sub SetWPOP_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPOP_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_C_ID field.
	''' </summary>
	Public Sub SetWPOP_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPOP_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_C_ID field.
	''' </summary>
	Public Sub SetWPOP_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_C_ID field.
	''' </summary>
	Public Sub SetWPOP_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_C_ID field.
	''' </summary>
	Public Sub SetWPOP_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_U_ID field.
	''' </summary>
	Public Function GetWPOP_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPOP_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_U_ID field.
	''' </summary>
	Public Function GetWPOP_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPOP_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_U_ID field.
	''' </summary>
	Public Sub SetWPOP_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPOP_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_U_ID field.
	''' </summary>
	Public Sub SetWPOP_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPOP_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_U_ID field.
	''' </summary>
	Public Sub SetWPOP_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_U_ID field.
	''' </summary>
	Public Sub SetWPOP_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_U_ID field.
	''' </summary>
	Public Sub SetWPOP_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_Remark field.
	''' </summary>
	Public Function GetWPOP_RemarkValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPOP_RemarkColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_Remark field.
	''' </summary>
	Public Function GetWPOP_RemarkFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPOP_RemarkColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_Remark field.
	''' </summary>
	Public Sub SetWPOP_RemarkFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPOP_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_Remark field.
	''' </summary>
	Public Sub SetWPOP_RemarkFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_PRTCNT field.
	''' </summary>
	Public Function GetWPOP_PRTCNTValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPOP_PRTCNTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_PRTCNT field.
	''' </summary>
	Public Function GetWPOP_PRTCNTFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPOP_PRTCNTColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_PRTCNT field.
	''' </summary>
	Public Sub SetWPOP_PRTCNTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPOP_PRTCNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_PRTCNT field.
	''' </summary>
	Public Sub SetWPOP_PRTCNTFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPOP_PRTCNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_PRTCNT field.
	''' </summary>
	Public Sub SetWPOP_PRTCNTFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_PRTCNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_PRTCNT field.
	''' </summary>
	Public Sub SetWPOP_PRTCNTFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_PRTCNTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_PRTCNT field.
	''' </summary>
	Public Sub SetWPOP_PRTCNTFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_PRTCNTColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_WCur_ID field.
	''' </summary>
	Public Function GetWPOP_WCur_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPOP_WCur_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPOP10100_.WPOP_WCur_ID field.
	''' </summary>
	Public Function GetWPOP_WCur_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WPOP_WCur_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_WCur_ID field.
	''' </summary>
	Public Sub SetWPOP_WCur_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPOP_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_WCur_ID field.
	''' </summary>
	Public Sub SetWPOP_WCur_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPOP_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_WCur_ID field.
	''' </summary>
	Public Sub SetWPOP_WCur_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_WCur_ID field.
	''' </summary>
	Public Sub SetWPOP_WCur_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPOP10100_.WPOP_WCur_ID field.
	''' </summary>
	Public Sub SetWPOP_WCur_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPOP_WCur_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPOP10100_.WPOP_ID field.
	''' </summary>
	Public Property WPOP_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPOP_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPOP_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPOP_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPOP_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPOP_IDDefault() As String
        Get
            Return TableUtils.WPOP_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPOP10100_.WPOP_DT_ID field.
	''' </summary>
	Public Property WPOP_DT_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPOP_DT_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPOP_DT_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPOP_DT_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPOP_DT_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPOP_DT_IDDefault() As String
        Get
            Return TableUtils.WPOP_DT_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPOP10100_.WPOP_PONMBR field.
	''' </summary>
	Public Property WPOP_PONMBR() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPOP_PONMBRColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPOP_PONMBRColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPOP_PONMBRSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPOP_PONMBRColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPOP_PONMBRDefault() As String
        Get
            Return TableUtils.WPOP_PONMBRColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPOP10100_.WPOP_Submit field.
	''' </summary>
	Public Property WPOP_Submit() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WPOP_SubmitColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPOP_SubmitColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPOP_SubmitSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPOP_SubmitColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPOP_SubmitDefault() As String
        Get
            Return TableUtils.WPOP_SubmitColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPOP10100_.WPOP_Status field.
	''' </summary>
	Public Property WPOP_Status() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPOP_StatusColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPOP_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPOP_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPOP_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPOP_StatusDefault() As String
        Get
            Return TableUtils.WPOP_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPOP10100_.WPOP_C_ID field.
	''' </summary>
	Public Property WPOP_C_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPOP_C_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPOP_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPOP_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPOP_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPOP_C_IDDefault() As String
        Get
            Return TableUtils.WPOP_C_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPOP10100_.WPOP_U_ID field.
	''' </summary>
	Public Property WPOP_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPOP_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPOP_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPOP_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPOP_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPOP_U_IDDefault() As String
        Get
            Return TableUtils.WPOP_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPOP10100_.WPOP_Remark field.
	''' </summary>
	Public Property WPOP_Remark() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPOP_RemarkColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPOP_RemarkColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPOP_RemarkSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPOP_RemarkColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPOP_RemarkDefault() As String
        Get
            Return TableUtils.WPOP_RemarkColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPOP10100_.WPOP_PRTCNT field.
	''' </summary>
	Public Property WPOP_PRTCNT() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPOP_PRTCNTColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPOP_PRTCNTColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPOP_PRTCNTSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPOP_PRTCNTColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPOP_PRTCNTDefault() As String
        Get
            Return TableUtils.WPOP_PRTCNTColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPOP10100_.WPOP_WCur_ID field.
	''' </summary>
	Public Property WPOP_WCur_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WPOP_WCur_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPOP_WCur_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPOP_WCur_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPOP_WCur_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPOP_WCur_IDDefault() As String
        Get
            Return TableUtils.WPOP_WCur_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
