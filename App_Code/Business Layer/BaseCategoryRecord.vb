' This class is "generated" and will be overwritten.
' Your customizations should be made in CategoryRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="CategoryRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="CategoryTable"></see> class.
''' </remarks>
''' <seealso cref="CategoryTable"></seealso>
''' <seealso cref="CategoryRecord"></seealso>

<Serializable()> Public Class BaseCategoryRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As CategoryTable = CategoryTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub CategoryRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim CategoryRec As CategoryRecord = CType(sender,CategoryRecord)
        Validate_Inserting()
        If Not CategoryRec Is Nothing AndAlso Not CategoryRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub CategoryRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim CategoryRec As CategoryRecord = CType(sender,CategoryRecord)
        Validate_Updating()
        If Not CategoryRec Is Nothing AndAlso Not CategoryRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub CategoryRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim CategoryRec As CategoryRecord = CType(sender,CategoryRecord)
        If Not CategoryRec Is Nothing AndAlso Not CategoryRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's Category_.ID field.
	''' </summary>
	Public Function GetID0Value() As ColumnValue
		Return Me.GetValue(TableUtils.ID0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.ID field.
	''' </summary>
	Public Function GetID0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ID0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.Accatnum field.
	''' </summary>
	Public Function GetAccatnumValue() As ColumnValue
		Return Me.GetValue(TableUtils.AccatnumColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.Accatnum field.
	''' </summary>
	Public Function GetAccatnumFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AccatnumColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Accatnum field.
	''' </summary>
	Public Sub SetAccatnumFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AccatnumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Accatnum field.
	''' </summary>
	Public Sub SetAccatnumFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.AccatnumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Accatnum field.
	''' </summary>
	Public Sub SetAccatnumFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AccatnumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Accatnum field.
	''' </summary>
	Public Sub SetAccatnumFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AccatnumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Accatnum field.
	''' </summary>
	Public Sub SetAccatnumFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AccatnumColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.Accatdesc field.
	''' </summary>
	Public Function GetAccatdescValue() As ColumnValue
		Return Me.GetValue(TableUtils.AccatdescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.Accatdesc field.
	''' </summary>
	Public Function GetAccatdescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.AccatdescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Accatdesc field.
	''' </summary>
	Public Sub SetAccatdescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AccatdescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Accatdesc field.
	''' </summary>
	Public Sub SetAccatdescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AccatdescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.TypicalBalance field.
	''' </summary>
	Public Function GetTypicalBalanceValue() As ColumnValue
		Return Me.GetValue(TableUtils.TypicalBalanceColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.TypicalBalance field.
	''' </summary>
	Public Function GetTypicalBalanceFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.TypicalBalanceColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.TypicalBalance field.
	''' </summary>
	Public Sub SetTypicalBalanceFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TypicalBalanceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.TypicalBalance field.
	''' </summary>
	Public Sub SetTypicalBalanceFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.TypicalBalanceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.TypicalBalance field.
	''' </summary>
	Public Sub SetTypicalBalanceFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TypicalBalanceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.TypicalBalance field.
	''' </summary>
	Public Sub SetTypicalBalanceFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TypicalBalanceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.TypicalBalance field.
	''' </summary>
	Public Sub SetTypicalBalanceFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TypicalBalanceColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.Orderno field.
	''' </summary>
	Public Function GetOrdernoValue() As ColumnValue
		Return Me.GetValue(TableUtils.OrdernoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.Orderno field.
	''' </summary>
	Public Function GetOrdernoFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.OrdernoColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Orderno field.
	''' </summary>
	Public Sub SetOrdernoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.OrdernoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Orderno field.
	''' </summary>
	Public Sub SetOrdernoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.OrdernoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Orderno field.
	''' </summary>
	Public Sub SetOrdernoFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OrdernoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Orderno field.
	''' </summary>
	Public Sub SetOrdernoFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OrdernoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Orderno field.
	''' </summary>
	Public Sub SetOrdernoFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.OrdernoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.Orderno1 field.
	''' </summary>
	Public Function GetOrderno1Value() As ColumnValue
		Return Me.GetValue(TableUtils.Orderno1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.Orderno1 field.
	''' </summary>
	Public Function GetOrderno1FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.Orderno1Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Orderno1 field.
	''' </summary>
	Public Sub SetOrderno1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Orderno1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Orderno1 field.
	''' </summary>
	Public Sub SetOrderno1FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Orderno1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Orderno1 field.
	''' </summary>
	Public Sub SetOrderno1FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Orderno1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Orderno1 field.
	''' </summary>
	Public Sub SetOrderno1FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Orderno1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Orderno1 field.
	''' </summary>
	Public Sub SetOrderno1FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Orderno1Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.ReportID field.
	''' </summary>
	Public Function GetReportIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ReportIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.ReportID field.
	''' </summary>
	Public Function GetReportIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ReportIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.ReportID field.
	''' </summary>
	Public Sub SetReportIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ReportIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.ReportID field.
	''' </summary>
	Public Sub SetReportIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ReportIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.ReportID field.
	''' </summary>
	Public Sub SetReportIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReportIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.ReportID field.
	''' </summary>
	Public Sub SetReportIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReportIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.ReportID field.
	''' </summary>
	Public Sub SetReportIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ReportIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.LevelNo field.
	''' </summary>
	Public Function GetLevelNoValue() As ColumnValue
		Return Me.GetValue(TableUtils.LevelNoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.LevelNo field.
	''' </summary>
	Public Function GetLevelNoFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.LevelNoColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.LevelNo field.
	''' </summary>
	Public Sub SetLevelNoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LevelNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.LevelNo field.
	''' </summary>
	Public Sub SetLevelNoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LevelNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.LevelNo field.
	''' </summary>
	Public Sub SetLevelNoFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LevelNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.LevelNo field.
	''' </summary>
	Public Sub SetLevelNoFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LevelNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.LevelNo field.
	''' </summary>
	Public Sub SetLevelNoFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LevelNoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.Level1 field.
	''' </summary>
	Public Function GetLevel1Value() As ColumnValue
		Return Me.GetValue(TableUtils.Level1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.Level1 field.
	''' </summary>
	Public Function GetLevel1FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Level1Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Level1 field.
	''' </summary>
	Public Sub SetLevel1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Level1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Level1 field.
	''' </summary>
	Public Sub SetLevel1FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Level1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.Level1_Ord field.
	''' </summary>
	Public Function GetLevel1_OrdValue() As ColumnValue
		Return Me.GetValue(TableUtils.Level1_OrdColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.Level1_Ord field.
	''' </summary>
	Public Function GetLevel1_OrdFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.Level1_OrdColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Level1_Ord field.
	''' </summary>
	Public Sub SetLevel1_OrdFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Level1_OrdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Level1_Ord field.
	''' </summary>
	Public Sub SetLevel1_OrdFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Level1_OrdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Level1_Ord field.
	''' </summary>
	Public Sub SetLevel1_OrdFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Level1_OrdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Level1_Ord field.
	''' </summary>
	Public Sub SetLevel1_OrdFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Level1_OrdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Level1_Ord field.
	''' </summary>
	Public Sub SetLevel1_OrdFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Level1_OrdColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.Level2 field.
	''' </summary>
	Public Function GetLevel2Value() As ColumnValue
		Return Me.GetValue(TableUtils.Level2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.Level2 field.
	''' </summary>
	Public Function GetLevel2FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Level2Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Level2 field.
	''' </summary>
	Public Sub SetLevel2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Level2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Level2 field.
	''' </summary>
	Public Sub SetLevel2FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Level2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.Level2_Ord field.
	''' </summary>
	Public Function GetLevel2_OrdValue() As ColumnValue
		Return Me.GetValue(TableUtils.Level2_OrdColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.Level2_Ord field.
	''' </summary>
	Public Function GetLevel2_OrdFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.Level2_OrdColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Level2_Ord field.
	''' </summary>
	Public Sub SetLevel2_OrdFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Level2_OrdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Level2_Ord field.
	''' </summary>
	Public Sub SetLevel2_OrdFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Level2_OrdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Level2_Ord field.
	''' </summary>
	Public Sub SetLevel2_OrdFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Level2_OrdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Level2_Ord field.
	''' </summary>
	Public Sub SetLevel2_OrdFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Level2_OrdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Level2_Ord field.
	''' </summary>
	Public Sub SetLevel2_OrdFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Level2_OrdColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.Indent field.
	''' </summary>
	Public Function GetIndentValue() As ColumnValue
		Return Me.GetValue(TableUtils.IndentColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.Indent field.
	''' </summary>
	Public Function GetIndentFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.IndentColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Indent field.
	''' </summary>
	Public Sub SetIndentFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IndentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Indent field.
	''' </summary>
	Public Sub SetIndentFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.IndentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Indent field.
	''' </summary>
	Public Sub SetIndentFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IndentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Indent field.
	''' </summary>
	Public Sub SetIndentFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IndentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.Indent field.
	''' </summary>
	Public Sub SetIndentFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IndentColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.CreatedBy field.
	''' </summary>
	Public Function GetCreatedByValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.CreatedBy field.
	''' </summary>
	Public Function GetCreatedByFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CreatedByColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.CreatedBy field.
	''' </summary>
	Public Sub SetCreatedByFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.CreatedBy field.
	''' </summary>
	Public Sub SetCreatedByFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CreatedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.CreatedBy field.
	''' </summary>
	Public Sub SetCreatedByFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.CreatedBy field.
	''' </summary>
	Public Sub SetCreatedByFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.CreatedBy field.
	''' </summary>
	Public Sub SetCreatedByFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.DateCreated field.
	''' </summary>
	Public Function GetDateCreatedValue() As ColumnValue
		Return Me.GetValue(TableUtils.DateCreatedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.DateCreated field.
	''' </summary>
	Public Function GetDateCreatedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.DateCreatedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.DateCreated field.
	''' </summary>
	Public Sub SetDateCreatedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.DateCreated field.
	''' </summary>
	Public Sub SetDateCreatedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.DateCreated field.
	''' </summary>
	Public Sub SetDateCreatedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.ModifiedBy field.
	''' </summary>
	Public Function GetModifiedByValue() As ColumnValue
		Return Me.GetValue(TableUtils.ModifiedByColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.ModifiedBy field.
	''' </summary>
	Public Function GetModifiedByFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ModifiedByColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.ModifiedBy field.
	''' </summary>
	Public Sub SetModifiedByFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ModifiedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.ModifiedBy field.
	''' </summary>
	Public Sub SetModifiedByFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ModifiedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.ModifiedBy field.
	''' </summary>
	Public Sub SetModifiedByFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ModifiedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.ModifiedBy field.
	''' </summary>
	Public Sub SetModifiedByFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ModifiedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.ModifiedBy field.
	''' </summary>
	Public Sub SetModifiedByFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ModifiedByColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.DateModified field.
	''' </summary>
	Public Function GetDateModifiedValue() As ColumnValue
		Return Me.GetValue(TableUtils.DateModifiedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.DateModified field.
	''' </summary>
	Public Function GetDateModifiedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.DateModifiedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.DateModified field.
	''' </summary>
	Public Sub SetDateModifiedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DateModifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.DateModified field.
	''' </summary>
	Public Sub SetDateModifiedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DateModifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.DateModified field.
	''' </summary>
	Public Sub SetDateModifiedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DateModifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.IsPrimary field.
	''' </summary>
	Public Function GetIsPrimaryValue() As ColumnValue
		Return Me.GetValue(TableUtils.IsPrimaryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.IsPrimary field.
	''' </summary>
	Public Function GetIsPrimaryFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.IsPrimaryColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.IsPrimary field.
	''' </summary>
	Public Sub SetIsPrimaryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IsPrimaryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.IsPrimary field.
	''' </summary>
	Public Sub SetIsPrimaryFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.IsPrimaryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.IsPrimary field.
	''' </summary>
	Public Sub SetIsPrimaryFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IsPrimaryColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.TotalOf field.
	''' </summary>
	Public Function GetTotalOfValue() As ColumnValue
		Return Me.GetValue(TableUtils.TotalOfColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Category_.TotalOf field.
	''' </summary>
	Public Function GetTotalOfFieldValue() As String
		Return CType(Me.GetValue(TableUtils.TotalOfColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.TotalOf field.
	''' </summary>
	Public Sub SetTotalOfFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.TotalOfColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Category_.TotalOf field.
	''' </summary>
	Public Sub SetTotalOfFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.TotalOfColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Category_.ID field.
	''' </summary>
	Public Property ID0() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ID0Column).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ID0Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ID0Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ID0Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ID0Default() As String
        Get
            Return TableUtils.ID0Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Category_.Accatnum field.
	''' </summary>
	Public Property Accatnum() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AccatnumColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AccatnumColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AccatnumSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AccatnumColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AccatnumDefault() As String
        Get
            Return TableUtils.AccatnumColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Category_.Accatdesc field.
	''' </summary>
	Public Property Accatdesc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.AccatdescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.AccatdescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AccatdescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AccatdescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AccatdescDefault() As String
        Get
            Return TableUtils.AccatdescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Category_.TypicalBalance field.
	''' </summary>
	Public Property TypicalBalance() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.TypicalBalanceColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.TypicalBalanceColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TypicalBalanceSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TypicalBalanceColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TypicalBalanceDefault() As String
        Get
            Return TableUtils.TypicalBalanceColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Category_.Orderno field.
	''' </summary>
	Public Property Orderno() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.OrdernoColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.OrdernoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property OrdernoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.OrdernoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property OrdernoDefault() As String
        Get
            Return TableUtils.OrdernoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Category_.Orderno1 field.
	''' </summary>
	Public Property Orderno1() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.Orderno1Column).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Orderno1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Orderno1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Orderno1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Orderno1Default() As String
        Get
            Return TableUtils.Orderno1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Category_.ReportID field.
	''' </summary>
	Public Property ReportID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ReportIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ReportIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ReportIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ReportIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ReportIDDefault() As String
        Get
            Return TableUtils.ReportIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Category_.LevelNo field.
	''' </summary>
	Public Property LevelNo() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.LevelNoColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LevelNoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LevelNoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LevelNoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LevelNoDefault() As String
        Get
            Return TableUtils.LevelNoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Category_.Level1 field.
	''' </summary>
	Public Property Level1() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Level1Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Level1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Level1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Level1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Level1Default() As String
        Get
            Return TableUtils.Level1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Category_.Level1_Ord field.
	''' </summary>
	Public Property Level1_Ord() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.Level1_OrdColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Level1_OrdColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Level1_OrdSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Level1_OrdColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Level1_OrdDefault() As String
        Get
            Return TableUtils.Level1_OrdColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Category_.Level2 field.
	''' </summary>
	Public Property Level2() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Level2Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Level2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Level2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Level2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Level2Default() As String
        Get
            Return TableUtils.Level2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Category_.Level2_Ord field.
	''' </summary>
	Public Property Level2_Ord() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.Level2_OrdColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Level2_OrdColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Level2_OrdSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Level2_OrdColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Level2_OrdDefault() As String
        Get
            Return TableUtils.Level2_OrdColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Category_.Indent field.
	''' </summary>
	Public Property Indent() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.IndentColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.IndentColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property IndentSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.IndentColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property IndentDefault() As String
        Get
            Return TableUtils.IndentColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Category_.CreatedBy field.
	''' </summary>
	Public Property CreatedBy() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CreatedByColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CreatedByColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CreatedBySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CreatedByColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CreatedByDefault() As String
        Get
            Return TableUtils.CreatedByColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Category_.DateCreated field.
	''' </summary>
	Public Property DateCreated() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.DateCreatedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DateCreatedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DateCreatedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DateCreatedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DateCreatedDefault() As String
        Get
            Return TableUtils.DateCreatedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Category_.ModifiedBy field.
	''' </summary>
	Public Property ModifiedBy() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ModifiedByColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ModifiedByColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ModifiedBySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ModifiedByColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ModifiedByDefault() As String
        Get
            Return TableUtils.ModifiedByColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Category_.DateModified field.
	''' </summary>
	Public Property DateModified() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.DateModifiedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DateModifiedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DateModifiedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DateModifiedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DateModifiedDefault() As String
        Get
            Return TableUtils.DateModifiedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Category_.IsPrimary field.
	''' </summary>
	Public Property IsPrimary() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.IsPrimaryColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.IsPrimaryColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property IsPrimarySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.IsPrimaryColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property IsPrimaryDefault() As String
        Get
            Return TableUtils.IsPrimaryColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Category_.TotalOf field.
	''' </summary>
	Public Property TotalOf() As String
		Get 
			Return CType(Me.GetValue(TableUtils.TotalOfColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.TotalOfColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property TotalOfSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.TotalOfColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property TotalOfDefault() As String
        Get
            Return TableUtils.TotalOfColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
