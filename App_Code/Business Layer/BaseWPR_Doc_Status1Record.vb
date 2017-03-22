' This class is "generated" and will be overwritten.
' Your customizations should be made in WPR_Doc_Status1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WPR_Doc_Status1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WPR_Doc_Status1Table"></see> class.
''' </remarks>
''' <seealso cref="WPR_Doc_Status1Table"></seealso>
''' <seealso cref="WPR_Doc_Status1Record"></seealso>

<Serializable()> Public Class BaseWPR_Doc_Status1Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WPR_Doc_Status1Table = WPR_Doc_Status1Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WPR_Doc_Status1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WPR_Doc_Status1Rec As WPR_Doc_Status1Record = CType(sender,WPR_Doc_Status1Record)
        Validate_Inserting()
        If Not WPR_Doc_Status1Rec Is Nothing AndAlso Not WPR_Doc_Status1Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WPR_Doc_Status1Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WPR_Doc_Status1Rec As WPR_Doc_Status1Record = CType(sender,WPR_Doc_Status1Record)
        Validate_Updating()
        If Not WPR_Doc_Status1Rec Is Nothing AndAlso Not WPR_Doc_Status1Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WPR_Doc_Status1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WPR_Doc_Status1Rec As WPR_Doc_Status1Record = CType(sender,WPR_Doc_Status1Record)
        If Not WPR_Doc_Status1Rec Is Nothing AndAlso Not WPR_Doc_Status1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_Status_.WPRDS_ID field.
	''' </summary>
	Public Function GetWPRDS_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRDS_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_Status_.WPRDS_ID field.
	''' </summary>
	Public Function GetWPRDS_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WPRDS_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_Status_.WPRDS_Desc field.
	''' </summary>
	Public Function GetWPRDS_DescValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRDS_DescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_Status_.WPRDS_Desc field.
	''' </summary>
	Public Function GetWPRDS_DescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRDS_DescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Status_.WPRDS_Desc field.
	''' </summary>
	Public Sub SetWPRDS_DescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRDS_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Status_.WPRDS_Desc field.
	''' </summary>
	Public Sub SetWPRDS_DescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRDS_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_Status_.WPRDS_Value field.
	''' </summary>
	Public Function GetWPRDS_ValueValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRDS_ValueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_Status_.WPRDS_Value field.
	''' </summary>
	Public Function GetWPRDS_ValueFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WPRDS_ValueColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Status_.WPRDS_Value field.
	''' </summary>
	Public Sub SetWPRDS_ValueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRDS_ValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Status_.WPRDS_Value field.
	''' </summary>
	Public Sub SetWPRDS_ValueFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRDS_ValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Status_.WPRDS_Value field.
	''' </summary>
	Public Sub SetWPRDS_ValueFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRDS_ValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Status_.WPRDS_Value field.
	''' </summary>
	Public Sub SetWPRDS_ValueFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRDS_ValueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Status_.WPRDS_Value field.
	''' </summary>
	Public Sub SetWPRDS_ValueFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRDS_ValueColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_Status_.WPRDS_ID field.
	''' </summary>
	Public Property WPRDS_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WPRDS_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRDS_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRDS_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRDS_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRDS_IDDefault() As String
        Get
            Return TableUtils.WPRDS_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_Status_.WPRDS_Desc field.
	''' </summary>
	Public Property WPRDS_Desc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRDS_DescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRDS_DescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRDS_DescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRDS_DescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRDS_DescDefault() As String
        Get
            Return TableUtils.WPRDS_DescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_Status_.WPRDS_Value field.
	''' </summary>
	Public Property WPRDS_Value() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WPRDS_ValueColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRDS_ValueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRDS_ValueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRDS_ValueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRDS_ValueDefault() As String
        Get
            Return TableUtils.WPRDS_ValueColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
