' This class is "generated" and will be overwritten.
' Your customizations should be made in Vw_WFinRep_DocAttach_FIN_MonthRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Vw_WFinRep_DocAttach_FIN_MonthRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Vw_WFinRep_DocAttach_FIN_MonthView"></see> class.
''' </remarks>
''' <seealso cref="Vw_WFinRep_DocAttach_FIN_MonthView"></seealso>
''' <seealso cref="Vw_WFinRep_DocAttach_FIN_MonthRecord"></seealso>

<Serializable()> Public Class BaseVw_WFinRep_DocAttach_FIN_MonthRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Vw_WFinRep_DocAttach_FIN_MonthView = Vw_WFinRep_DocAttach_FIN_MonthView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Vw_WFinRep_DocAttach_FIN_MonthRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Vw_WFinRep_DocAttach_FIN_MonthRec As Vw_WFinRep_DocAttach_FIN_MonthRecord = CType(sender,Vw_WFinRep_DocAttach_FIN_MonthRecord)
        Validate_Inserting()
        If Not Vw_WFinRep_DocAttach_FIN_MonthRec Is Nothing AndAlso Not Vw_WFinRep_DocAttach_FIN_MonthRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub Vw_WFinRep_DocAttach_FIN_MonthRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim Vw_WFinRep_DocAttach_FIN_MonthRec As Vw_WFinRep_DocAttach_FIN_MonthRecord = CType(sender,Vw_WFinRep_DocAttach_FIN_MonthRecord)
        Validate_Updating()
        If Not Vw_WFinRep_DocAttach_FIN_MonthRec Is Nothing AndAlso Not Vw_WFinRep_DocAttach_FIN_MonthRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Vw_WFinRep_DocAttach_FIN_MonthRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Vw_WFinRep_DocAttach_FIN_MonthRec As Vw_WFinRep_DocAttach_FIN_MonthRecord = CType(sender,Vw_WFinRep_DocAttach_FIN_MonthRecord)
        If Not Vw_WFinRep_DocAttach_FIN_MonthRec Is Nothing AndAlso Not Vw_WFinRep_DocAttach_FIN_MonthRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's Vw_WFinRep_DocAttac_671747064_.Mo field.
	''' </summary>
	Public Function GetMoValue() As ColumnValue
		Return Me.GetValue(TableUtils.MoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Vw_WFinRep_DocAttac_671747064_.Mo field.
	''' </summary>
	Public Function GetMoFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.MoColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Vw_WFinRep_DocAttac_671747064_.Mo field.
	''' </summary>
	Public Sub SetMoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Vw_WFinRep_DocAttac_671747064_.Mo field.
	''' </summary>
	Public Sub SetMoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.MoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Vw_WFinRep_DocAttac_671747064_.Mo field.
	''' </summary>
	Public Sub SetMoFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Vw_WFinRep_DocAttac_671747064_.Mo field.
	''' </summary>
	Public Sub SetMoFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Vw_WFinRep_DocAttac_671747064_.Mo field.
	''' </summary>
	Public Sub SetMoFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Vw_WFinRep_DocAttac_671747064_.MoName field.
	''' </summary>
	Public Function GetMoNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.MoNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Vw_WFinRep_DocAttac_671747064_.MoName field.
	''' </summary>
	Public Function GetMoNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.MoNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Vw_WFinRep_DocAttac_671747064_.MoName field.
	''' </summary>
	Public Sub SetMoNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.MoNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Vw_WFinRep_DocAttac_671747064_.MoName field.
	''' </summary>
	Public Sub SetMoNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.MoNameColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Vw_WFinRep_DocAttac_671747064_.Mo field.
	''' </summary>
	Public Property Mo() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.MoColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MoDefault() As String
        Get
            Return TableUtils.MoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Vw_WFinRep_DocAttac_671747064_.MoName field.
	''' </summary>
	Public Property MoName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.MoNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.MoNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MoNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MoNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MoNameDefault() As String
        Get
            Return TableUtils.MoNameColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
