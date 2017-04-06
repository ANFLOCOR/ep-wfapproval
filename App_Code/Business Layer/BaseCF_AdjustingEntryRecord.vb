' This class is "generated" and will be overwritten.
' Your customizations should be made in CF_AdjustingEntryRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="CF_AdjustingEntryRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="CF_AdjustingEntryTable"></see> class.
''' </remarks>
''' <seealso cref="CF_AdjustingEntryTable"></seealso>
''' <seealso cref="CF_AdjustingEntryRecord"></seealso>

<Serializable()> Public Class BaseCF_AdjustingEntryRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As CF_AdjustingEntryTable = CF_AdjustingEntryTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub CF_AdjustingEntryRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim CF_AdjustingEntryRec As CF_AdjustingEntryRecord = CType(sender,CF_AdjustingEntryRecord)
        Validate_Inserting()
        If Not CF_AdjustingEntryRec Is Nothing AndAlso Not CF_AdjustingEntryRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub CF_AdjustingEntryRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim CF_AdjustingEntryRec As CF_AdjustingEntryRecord = CType(sender,CF_AdjustingEntryRecord)
        Validate_Updating()
        If Not CF_AdjustingEntryRec Is Nothing AndAlso Not CF_AdjustingEntryRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub CF_AdjustingEntryRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim CF_AdjustingEntryRec As CF_AdjustingEntryRecord = CType(sender,CF_AdjustingEntryRecord)
        If Not CF_AdjustingEntryRec Is Nothing AndAlso Not CF_AdjustingEntryRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.AdjustID field.
	''' </summary>
	Public Function GetAdjustIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.AdjustIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.AdjustID field.
	''' </summary>
	Public Function GetAdjustIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.AdjustIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.WFRCH_ID field.
	''' </summary>
	Public Function GetWFRCH_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCH_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.WFRCH_ID field.
	''' </summary>
	Public Function GetWFRCH_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCH_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.WFRCH_ID field.
	''' </summary>
	Public Sub SetWFRCH_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCH_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.WFRCH_ID field.
	''' </summary>
	Public Sub SetWFRCH_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCH_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.WFRCH_ID field.
	''' </summary>
	Public Sub SetWFRCH_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.WFRCH_ID field.
	''' </summary>
	Public Sub SetWFRCH_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.WFRCH_ID field.
	''' </summary>
	Public Sub SetWFRCH_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCH_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.Year field.
	''' </summary>
	Public Function GetYearValue() As ColumnValue
		Return Me.GetValue(TableUtils.YearColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.Year field.
	''' </summary>
	Public Function GetYearFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.YearColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.Year field.
	''' </summary>
	Public Sub SetYearFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.Year field.
	''' </summary>
	Public Sub SetYearFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.Year field.
	''' </summary>
	Public Sub SetYearFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.Year field.
	''' </summary>
	Public Sub SetYearFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.YearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.Year field.
	''' </summary>
	Public Sub SetYearFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.YearColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.PeriodID field.
	''' </summary>
	Public Function GetPeriodIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PeriodIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.PeriodID field.
	''' </summary>
	Public Function GetPeriodIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PeriodIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.PeriodID field.
	''' </summary>
	Public Sub SetPeriodIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PeriodIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.PeriodID field.
	''' </summary>
	Public Sub SetPeriodIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PeriodIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.PeriodID field.
	''' </summary>
	Public Sub SetPeriodIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PeriodIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.PeriodID field.
	''' </summary>
	Public Sub SetPeriodIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PeriodIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.PeriodID field.
	''' </summary>
	Public Sub SetPeriodIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PeriodIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.CFCat_Increase field.
	''' </summary>
	Public Function GetCFCat_IncreaseValue() As ColumnValue
		Return Me.GetValue(TableUtils.CFCat_IncreaseColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.CFCat_Increase field.
	''' </summary>
	Public Function GetCFCat_IncreaseFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CFCat_IncreaseColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.CFCat_Increase field.
	''' </summary>
	Public Sub SetCFCat_IncreaseFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CFCat_IncreaseColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.CFCat_Increase field.
	''' </summary>
	Public Sub SetCFCat_IncreaseFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CFCat_IncreaseColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.CFCat_Increase field.
	''' </summary>
	Public Sub SetCFCat_IncreaseFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CFCat_IncreaseColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.CFCat_Increase field.
	''' </summary>
	Public Sub SetCFCat_IncreaseFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CFCat_IncreaseColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.CFCat_Increase field.
	''' </summary>
	Public Sub SetCFCat_IncreaseFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CFCat_IncreaseColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.CFCat_Decrease field.
	''' </summary>
	Public Function GetCFCat_DecreaseValue() As ColumnValue
		Return Me.GetValue(TableUtils.CFCat_DecreaseColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.CFCat_Decrease field.
	''' </summary>
	Public Function GetCFCat_DecreaseFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CFCat_DecreaseColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.CFCat_Decrease field.
	''' </summary>
	Public Sub SetCFCat_DecreaseFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CFCat_DecreaseColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.CFCat_Decrease field.
	''' </summary>
	Public Sub SetCFCat_DecreaseFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CFCat_DecreaseColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.CFCat_Decrease field.
	''' </summary>
	Public Sub SetCFCat_DecreaseFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CFCat_DecreaseColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.CFCat_Decrease field.
	''' </summary>
	Public Sub SetCFCat_DecreaseFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CFCat_DecreaseColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.CFCat_Decrease field.
	''' </summary>
	Public Sub SetCFCat_DecreaseFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CFCat_DecreaseColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.Amount_Adjust field.
	''' </summary>
	Public Function GetAmount_AdjustValue() As ColumnValue
		Return Me.GetValue(TableUtils.Amount_AdjustColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.Amount_Adjust field.
	''' </summary>
	Public Function GetAmount_AdjustFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.Amount_AdjustColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.Amount_Adjust field.
	''' </summary>
	Public Sub SetAmount_AdjustFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Amount_AdjustColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.Amount_Adjust field.
	''' </summary>
	Public Sub SetAmount_AdjustFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Amount_AdjustColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.Amount_Adjust field.
	''' </summary>
	Public Sub SetAmount_AdjustFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Amount_AdjustColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.Amount_Adjust field.
	''' </summary>
	Public Sub SetAmount_AdjustFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Amount_AdjustColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.Amount_Adjust field.
	''' </summary>
	Public Sub SetAmount_AdjustFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Amount_AdjustColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.CreatedBy field.
	''' </summary>
	Public Function GetCreatedByValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.CreatedBy field.
	''' </summary>
	Public Function GetCreatedByFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CreatedByColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.CreatedBy field.
	''' </summary>
	Public Sub SetCreatedByFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.CreatedBy field.
	''' </summary>
	Public Sub SetCreatedByFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.DateCreated field.
	''' </summary>
	Public Function GetDateCreatedValue() As ColumnValue
		Return Me.GetValue(TableUtils.DateCreatedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.DateCreated field.
	''' </summary>
	Public Function GetDateCreatedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.DateCreatedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.DateCreated field.
	''' </summary>
	Public Sub SetDateCreatedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.DateCreated field.
	''' </summary>
	Public Sub SetDateCreatedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.DateCreated field.
	''' </summary>
	Public Sub SetDateCreatedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.ModifiedBy field.
	''' </summary>
	Public Function GetModifiedByValue() As ColumnValue
		Return Me.GetValue(TableUtils.ModifiedByColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.ModifiedBy field.
	''' </summary>
	Public Function GetModifiedByFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ModifiedByColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.ModifiedBy field.
	''' </summary>
	Public Sub SetModifiedByFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ModifiedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.ModifiedBy field.
	''' </summary>
	Public Sub SetModifiedByFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ModifiedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.DateModified field.
	''' </summary>
	Public Function GetDateModifiedValue() As ColumnValue
		Return Me.GetValue(TableUtils.DateModifiedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CF_AdjustingEntry_.DateModified field.
	''' </summary>
	Public Function GetDateModifiedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.DateModifiedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.DateModified field.
	''' </summary>
	Public Sub SetDateModifiedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DateModifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.DateModified field.
	''' </summary>
	Public Sub SetDateModifiedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DateModifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CF_AdjustingEntry_.DateModified field.
	''' </summary>
	Public Sub SetDateModifiedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DateModifiedColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CF_AdjustingEntry_.AdjustID field.
	''' </summary>
	Public Property AdjustID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.AdjustIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.AdjustIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AdjustIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AdjustIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AdjustIDDefault() As String
        Get
            Return TableUtils.AdjustIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CF_AdjustingEntry_.WFRCH_ID field.
	''' </summary>
	Public Property WFRCH_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCH_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCH_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCH_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCH_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCH_IDDefault() As String
        Get
            Return TableUtils.WFRCH_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CF_AdjustingEntry_.Year field.
	''' </summary>
	Public Property Year() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.YearColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.YearColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property YearSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.YearColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property YearDefault() As String
        Get
            Return TableUtils.YearColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CF_AdjustingEntry_.PeriodID field.
	''' </summary>
	Public Property PeriodID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PeriodIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PeriodIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PeriodIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PeriodIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PeriodIDDefault() As String
        Get
            Return TableUtils.PeriodIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CF_AdjustingEntry_.CFCat_Increase field.
	''' </summary>
	Public Property CFCat_Increase() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CFCat_IncreaseColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CFCat_IncreaseColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CFCat_IncreaseSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CFCat_IncreaseColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CFCat_IncreaseDefault() As String
        Get
            Return TableUtils.CFCat_IncreaseColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CF_AdjustingEntry_.CFCat_Decrease field.
	''' </summary>
	Public Property CFCat_Decrease() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CFCat_DecreaseColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CFCat_DecreaseColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CFCat_DecreaseSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CFCat_DecreaseColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CFCat_DecreaseDefault() As String
        Get
            Return TableUtils.CFCat_DecreaseColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CF_AdjustingEntry_.Amount_Adjust field.
	''' </summary>
	Public Property Amount_Adjust() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.Amount_AdjustColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Amount_AdjustColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Amount_AdjustSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Amount_AdjustColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Amount_AdjustDefault() As String
        Get
            Return TableUtils.Amount_AdjustColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CF_AdjustingEntry_.CreatedBy field.
	''' </summary>
	Public Property CreatedBy() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CreatedByColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CreatedByColumn)
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
	''' This is a convenience property that provides direct access to the value of the record's CF_AdjustingEntry_.DateCreated field.
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
	''' This is a convenience property that provides direct access to the value of the record's CF_AdjustingEntry_.ModifiedBy field.
	''' </summary>
	Public Property ModifiedBy() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ModifiedByColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ModifiedByColumn)
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
	''' This is a convenience property that provides direct access to the value of the record's CF_AdjustingEntry_.DateModified field.
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



#End Region

End Class
End Namespace
