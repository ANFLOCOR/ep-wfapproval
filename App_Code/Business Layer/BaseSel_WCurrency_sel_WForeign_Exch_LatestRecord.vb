' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WCurrency_sel_WForeign_Exch_LatestRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_WCurrency_sel_WForeign_Exch_LatestRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WCurrency_sel_WForeign_Exch_LatestView"></see> class.
''' </remarks>
''' <seealso cref="Sel_WCurrency_sel_WForeign_Exch_LatestView"></seealso>
''' <seealso cref="Sel_WCurrency_sel_WForeign_Exch_LatestRecord"></seealso>

<Serializable()> Public Class BaseSel_WCurrency_sel_WForeign_Exch_LatestRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_WCurrency_sel_WForeign_Exch_LatestView = Sel_WCurrency_sel_WForeign_Exch_LatestView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_WCurrency_sel_WForeign_Exch_LatestRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_WCurrency_sel_WForeign_Exch_LatestRec As Sel_WCurrency_sel_WForeign_Exch_LatestRecord = CType(sender,Sel_WCurrency_sel_WForeign_Exch_LatestRecord)
        If Not Sel_WCurrency_sel_WForeign_Exch_LatestRec Is Nothing AndAlso Not Sel_WCurrency_sel_WForeign_Exch_LatestRec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_WCurrency_sel_WForeign_Exch_LatestRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_WCurrency_sel_WForeign_Exch_LatestRec As Sel_WCurrency_sel_WForeign_Exch_LatestRecord = CType(sender,Sel_WCurrency_sel_WForeign_Exch_LatestRecord)
        Validate_Inserting()
        If Not Sel_WCurrency_sel_WForeign_Exch_LatestRec Is Nothing AndAlso Not Sel_WCurrency_sel_WForeign_Exch_LatestRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's sel_WCurrency_sel_WForeign_Exch_Latest_.WCur_Short field.
	''' </summary>
	Public Function GetWCur_ShortValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCur_ShortColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCurrency_sel_WForeign_Exch_Latest_.WCur_Short field.
	''' </summary>
	Public Function GetWCur_ShortFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCur_ShortColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCurrency_sel_WForeign_Exch_Latest_.WCur_Short field.
	''' </summary>
	Public Sub SetWCur_ShortFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCur_ShortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCurrency_sel_WForeign_Exch_Latest_.WCur_Short field.
	''' </summary>
	Public Sub SetWCur_ShortFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCur_ShortColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCurrency_sel_WForeign_Exch_Latest_.WFE_Peso_Rate field.
	''' </summary>
	Public Function GetWFE_Peso_RateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFE_Peso_RateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCurrency_sel_WForeign_Exch_Latest_.WFE_Peso_Rate field.
	''' </summary>
	Public Function GetWFE_Peso_RateFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WFE_Peso_RateColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCurrency_sel_WForeign_Exch_Latest_.WFE_Peso_Rate field.
	''' </summary>
	Public Sub SetWFE_Peso_RateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFE_Peso_RateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCurrency_sel_WForeign_Exch_Latest_.WFE_Peso_Rate field.
	''' </summary>
	Public Sub SetWFE_Peso_RateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFE_Peso_RateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCurrency_sel_WForeign_Exch_Latest_.WFE_Peso_Rate field.
	''' </summary>
	Public Sub SetWFE_Peso_RateFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFE_Peso_RateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCurrency_sel_WForeign_Exch_Latest_.WFE_Peso_Rate field.
	''' </summary>
	Public Sub SetWFE_Peso_RateFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFE_Peso_RateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCurrency_sel_WForeign_Exch_Latest_.WFE_Peso_Rate field.
	''' </summary>
	Public Sub SetWFE_Peso_RateFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFE_Peso_RateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCurrency_sel_WForeign_Exch_Latest_.WCur_Desc field.
	''' </summary>
	Public Function GetWCur_DescValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCur_DescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCurrency_sel_WForeign_Exch_Latest_.WCur_Desc field.
	''' </summary>
	Public Function GetWCur_DescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCur_DescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCurrency_sel_WForeign_Exch_Latest_.WCur_Desc field.
	''' </summary>
	Public Sub SetWCur_DescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCur_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCurrency_sel_WForeign_Exch_Latest_.WCur_Desc field.
	''' </summary>
	Public Sub SetWCur_DescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCur_DescColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCurrency_sel_WForeign_Exch_Latest_.WCur_Short field.
	''' </summary>
	Public Property WCur_Short() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCur_ShortColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCur_ShortColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCur_ShortSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCur_ShortColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCur_ShortDefault() As String
        Get
            Return TableUtils.WCur_ShortColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCurrency_sel_WForeign_Exch_Latest_.WFE_Peso_Rate field.
	''' </summary>
	Public Property WFE_Peso_Rate() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WFE_Peso_RateColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFE_Peso_RateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFE_Peso_RateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFE_Peso_RateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFE_Peso_RateDefault() As String
        Get
            Return TableUtils.WFE_Peso_RateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCurrency_sel_WForeign_Exch_Latest_.WCur_Desc field.
	''' </summary>
	Public Property WCur_Desc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCur_DescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCur_DescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCur_DescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCur_DescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCur_DescDefault() As String
        Get
            Return TableUtils.WCur_DescColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
