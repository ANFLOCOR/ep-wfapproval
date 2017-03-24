' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_GL00100Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_GL00100Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_GL00100View"></see> class.
''' </remarks>
''' <seealso cref="Sel_GL00100View"></seealso>
''' <seealso cref="Sel_GL00100Record"></seealso>

<Serializable()> Public Class BaseSel_GL00100Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_GL00100View = Sel_GL00100View.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_GL00100Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_GL00100Rec As Sel_GL00100Record = CType(sender,Sel_GL00100Record)
        Validate_Inserting()
        If Not Sel_GL00100Rec Is Nothing AndAlso Not Sel_GL00100Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub Sel_GL00100Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim Sel_GL00100Rec As Sel_GL00100Record = CType(sender,Sel_GL00100Record)
        Validate_Updating()
        If Not Sel_GL00100Rec Is Nothing AndAlso Not Sel_GL00100Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_GL00100Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_GL00100Rec As Sel_GL00100Record = CType(sender,Sel_GL00100Record)
        If Not Sel_GL00100Rec Is Nothing AndAlso Not Sel_GL00100Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.ACTINDX field.
	''' </summary>
	Public Function GetACTINDXValue() As ColumnValue
		Return Me.GetValue(TableUtils.ACTINDXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.ACTINDX field.
	''' </summary>
	Public Function GetACTINDXFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ACTINDXColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.ACTINDX field.
	''' </summary>
	Public Sub SetACTINDXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ACTINDXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.ACTINDX field.
	''' </summary>
	Public Sub SetACTINDXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ACTINDXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.ACTINDX field.
	''' </summary>
	Public Sub SetACTINDXFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ACTINDXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.ACTINDX field.
	''' </summary>
	Public Sub SetACTINDXFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ACTINDXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.ACTINDX field.
	''' </summary>
	Public Sub SetACTINDXFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ACTINDXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.ACTNUMBR_1 field.
	''' </summary>
	Public Function GetACTNUMBR_1Value() As ColumnValue
		Return Me.GetValue(TableUtils.ACTNUMBR_1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.ACTNUMBR_1 field.
	''' </summary>
	Public Function GetACTNUMBR_1FieldValue() As String
		Return CType(Me.GetValue(TableUtils.ACTNUMBR_1Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.ACTNUMBR_1 field.
	''' </summary>
	Public Sub SetACTNUMBR_1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ACTNUMBR_1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.ACTNUMBR_1 field.
	''' </summary>
	Public Sub SetACTNUMBR_1FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ACTNUMBR_1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.ACTNUMBR_2 field.
	''' </summary>
	Public Function GetACTNUMBR_2Value() As ColumnValue
		Return Me.GetValue(TableUtils.ACTNUMBR_2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.ACTNUMBR_2 field.
	''' </summary>
	Public Function GetACTNUMBR_2FieldValue() As String
		Return CType(Me.GetValue(TableUtils.ACTNUMBR_2Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.ACTNUMBR_2 field.
	''' </summary>
	Public Sub SetACTNUMBR_2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ACTNUMBR_2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.ACTNUMBR_2 field.
	''' </summary>
	Public Sub SetACTNUMBR_2FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ACTNUMBR_2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.ACTNUMBR_3 field.
	''' </summary>
	Public Function GetACTNUMBR_3Value() As ColumnValue
		Return Me.GetValue(TableUtils.ACTNUMBR_3Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.ACTNUMBR_3 field.
	''' </summary>
	Public Function GetACTNUMBR_3FieldValue() As String
		Return CType(Me.GetValue(TableUtils.ACTNUMBR_3Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.ACTNUMBR_3 field.
	''' </summary>
	Public Sub SetACTNUMBR_3FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ACTNUMBR_3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.ACTNUMBR_3 field.
	''' </summary>
	Public Sub SetACTNUMBR_3FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ACTNUMBR_3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.ACTNUMBR_4 field.
	''' </summary>
	Public Function GetACTNUMBR_4Value() As ColumnValue
		Return Me.GetValue(TableUtils.ACTNUMBR_4Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.ACTNUMBR_4 field.
	''' </summary>
	Public Function GetACTNUMBR_4FieldValue() As String
		Return CType(Me.GetValue(TableUtils.ACTNUMBR_4Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.ACTNUMBR_4 field.
	''' </summary>
	Public Sub SetACTNUMBR_4FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ACTNUMBR_4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.ACTNUMBR_4 field.
	''' </summary>
	Public Sub SetACTNUMBR_4FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ACTNUMBR_4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.ACTNUMBR_5 field.
	''' </summary>
	Public Function GetACTNUMBR_5Value() As ColumnValue
		Return Me.GetValue(TableUtils.ACTNUMBR_5Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.ACTNUMBR_5 field.
	''' </summary>
	Public Function GetACTNUMBR_5FieldValue() As String
		Return CType(Me.GetValue(TableUtils.ACTNUMBR_5Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.ACTNUMBR_5 field.
	''' </summary>
	Public Sub SetACTNUMBR_5FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ACTNUMBR_5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.ACTNUMBR_5 field.
	''' </summary>
	Public Sub SetACTNUMBR_5FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ACTNUMBR_5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.ACTNUMBR_6 field.
	''' </summary>
	Public Function GetACTNUMBR_6Value() As ColumnValue
		Return Me.GetValue(TableUtils.ACTNUMBR_6Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.ACTNUMBR_6 field.
	''' </summary>
	Public Function GetACTNUMBR_6FieldValue() As String
		Return CType(Me.GetValue(TableUtils.ACTNUMBR_6Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.ACTNUMBR_6 field.
	''' </summary>
	Public Sub SetACTNUMBR_6FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ACTNUMBR_6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.ACTNUMBR_6 field.
	''' </summary>
	Public Sub SetACTNUMBR_6FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ACTNUMBR_6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.Company_ID field.
	''' </summary>
	Public Function GetCompany_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.Company_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.Company_ID field.
	''' </summary>
	Public Function GetCompany_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.Company_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.ACTDESCR field.
	''' </summary>
	Public Function GetACTDESCRValue() As ColumnValue
		Return Me.GetValue(TableUtils.ACTDESCRColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.ACTDESCR field.
	''' </summary>
	Public Function GetACTDESCRFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ACTDESCRColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.ACTDESCR field.
	''' </summary>
	Public Sub SetACTDESCRFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ACTDESCRColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.ACTDESCR field.
	''' </summary>
	Public Sub SetACTDESCRFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ACTDESCRColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.AcctCode field.
	''' </summary>
	Public Function GetAcctCodeValue() As ColumnValue
		Return Me.GetValue(TableUtils.AcctCodeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_GL00100_.AcctCode field.
	''' </summary>
	Public Function GetAcctCodeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.AcctCodeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.AcctCode field.
	''' </summary>
	Public Sub SetAcctCodeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AcctCodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_GL00100_.AcctCode field.
	''' </summary>
	Public Sub SetAcctCodeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AcctCodeColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_GL00100_.ACTINDX field.
	''' </summary>
	Public Property ACTINDX() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ACTINDXColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ACTINDXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ACTINDXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ACTINDXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ACTINDXDefault() As String
        Get
            Return TableUtils.ACTINDXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_GL00100_.ACTNUMBR_1 field.
	''' </summary>
	Public Property ACTNUMBR_1() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ACTNUMBR_1Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ACTNUMBR_1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ACTNUMBR_1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ACTNUMBR_1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ACTNUMBR_1Default() As String
        Get
            Return TableUtils.ACTNUMBR_1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_GL00100_.ACTNUMBR_2 field.
	''' </summary>
	Public Property ACTNUMBR_2() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ACTNUMBR_2Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ACTNUMBR_2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ACTNUMBR_2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ACTNUMBR_2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ACTNUMBR_2Default() As String
        Get
            Return TableUtils.ACTNUMBR_2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_GL00100_.ACTNUMBR_3 field.
	''' </summary>
	Public Property ACTNUMBR_3() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ACTNUMBR_3Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ACTNUMBR_3Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ACTNUMBR_3Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ACTNUMBR_3Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ACTNUMBR_3Default() As String
        Get
            Return TableUtils.ACTNUMBR_3Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_GL00100_.ACTNUMBR_4 field.
	''' </summary>
	Public Property ACTNUMBR_4() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ACTNUMBR_4Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ACTNUMBR_4Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ACTNUMBR_4Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ACTNUMBR_4Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ACTNUMBR_4Default() As String
        Get
            Return TableUtils.ACTNUMBR_4Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_GL00100_.ACTNUMBR_5 field.
	''' </summary>
	Public Property ACTNUMBR_5() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ACTNUMBR_5Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ACTNUMBR_5Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ACTNUMBR_5Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ACTNUMBR_5Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ACTNUMBR_5Default() As String
        Get
            Return TableUtils.ACTNUMBR_5Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_GL00100_.ACTNUMBR_6 field.
	''' </summary>
	Public Property ACTNUMBR_6() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ACTNUMBR_6Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ACTNUMBR_6Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ACTNUMBR_6Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ACTNUMBR_6Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ACTNUMBR_6Default() As String
        Get
            Return TableUtils.ACTNUMBR_6Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_GL00100_.Company_ID field.
	''' </summary>
	Public Property Company_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.Company_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Company_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Company_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Company_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Company_IDDefault() As String
        Get
            Return TableUtils.Company_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_GL00100_.ACTDESCR field.
	''' </summary>
	Public Property ACTDESCR() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ACTDESCRColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ACTDESCRColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ACTDESCRSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ACTDESCRColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ACTDESCRDefault() As String
        Get
            Return TableUtils.ACTDESCRColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_GL00100_.AcctCode field.
	''' </summary>
	Public Property AcctCode() As String
		Get 
			Return CType(Me.GetValue(TableUtils.AcctCodeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.AcctCodeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AcctCodeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AcctCodeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AcctCodeDefault() As String
        Get
            Return TableUtils.AcctCodeColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
