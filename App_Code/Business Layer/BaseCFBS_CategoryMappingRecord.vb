' This class is "generated" and will be overwritten.
' Your customizations should be made in CFBS_CategoryMappingRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="CFBS_CategoryMappingRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="CFBS_CategoryMappingTable"></see> class.
''' </remarks>
''' <seealso cref="CFBS_CategoryMappingTable"></seealso>
''' <seealso cref="CFBS_CategoryMappingRecord"></seealso>

<Serializable()> Public Class BaseCFBS_CategoryMappingRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As CFBS_CategoryMappingTable = CFBS_CategoryMappingTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub CFBS_CategoryMappingRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim CFBS_CategoryMappingRec As CFBS_CategoryMappingRecord = CType(sender,CFBS_CategoryMappingRecord)
        Validate_Inserting()
        If Not CFBS_CategoryMappingRec Is Nothing AndAlso Not CFBS_CategoryMappingRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub CFBS_CategoryMappingRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim CFBS_CategoryMappingRec As CFBS_CategoryMappingRecord = CType(sender,CFBS_CategoryMappingRecord)
        Validate_Updating()
        If Not CFBS_CategoryMappingRec Is Nothing AndAlso Not CFBS_CategoryMappingRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub CFBS_CategoryMappingRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim CFBS_CategoryMappingRec As CFBS_CategoryMappingRecord = CType(sender,CFBS_CategoryMappingRecord)
        If Not CFBS_CategoryMappingRec Is Nothing AndAlso Not CFBS_CategoryMappingRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.MapID field.
	''' </summary>
	Public Function GetMapIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.MapIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.MapID field.
	''' </summary>
	Public Function GetMapIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.MapIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.IsPrimary field.
	''' </summary>
	Public Function GetIsPrimaryValue() As ColumnValue
		Return Me.GetValue(TableUtils.IsPrimaryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.IsPrimary field.
	''' </summary>
	Public Function GetIsPrimaryFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.IsPrimaryColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.IsPrimary field.
	''' </summary>
	Public Sub SetIsPrimaryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IsPrimaryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.IsPrimary field.
	''' </summary>
	Public Sub SetIsPrimaryFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.IsPrimaryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.IsPrimary field.
	''' </summary>
	Public Sub SetIsPrimaryFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IsPrimaryColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.BS_OrderNo field.
	''' </summary>
	Public Function GetBS_OrderNoValue() As ColumnValue
		Return Me.GetValue(TableUtils.BS_OrderNoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.BS_OrderNo field.
	''' </summary>
	Public Function GetBS_OrderNoFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.BS_OrderNoColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.BS_OrderNo field.
	''' </summary>
	Public Sub SetBS_OrderNoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.BS_OrderNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.BS_OrderNo field.
	''' </summary>
	Public Sub SetBS_OrderNoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.BS_OrderNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.BS_OrderNo field.
	''' </summary>
	Public Sub SetBS_OrderNoFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.BS_OrderNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.BS_OrderNo field.
	''' </summary>
	Public Sub SetBS_OrderNoFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.BS_OrderNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.BS_OrderNo field.
	''' </summary>
	Public Sub SetBS_OrderNoFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.BS_OrderNoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.CF_OrderNo field.
	''' </summary>
	Public Function GetCF_OrderNoValue() As ColumnValue
		Return Me.GetValue(TableUtils.CF_OrderNoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.CF_OrderNo field.
	''' </summary>
	Public Function GetCF_OrderNoFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CF_OrderNoColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.CF_OrderNo field.
	''' </summary>
	Public Sub SetCF_OrderNoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CF_OrderNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.CF_OrderNo field.
	''' </summary>
	Public Sub SetCF_OrderNoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CF_OrderNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.CF_OrderNo field.
	''' </summary>
	Public Sub SetCF_OrderNoFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CF_OrderNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.CF_OrderNo field.
	''' </summary>
	Public Sub SetCF_OrderNoFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CF_OrderNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.CF_OrderNo field.
	''' </summary>
	Public Sub SetCF_OrderNoFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CF_OrderNoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.Ref_BS_OrderNo field.
	''' </summary>
	Public Function GetRef_BS_OrderNoValue() As ColumnValue
		Return Me.GetValue(TableUtils.Ref_BS_OrderNoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.Ref_BS_OrderNo field.
	''' </summary>
	Public Function GetRef_BS_OrderNoFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.Ref_BS_OrderNoColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.Ref_BS_OrderNo field.
	''' </summary>
	Public Sub SetRef_BS_OrderNoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Ref_BS_OrderNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.Ref_BS_OrderNo field.
	''' </summary>
	Public Sub SetRef_BS_OrderNoFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Ref_BS_OrderNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.Ref_BS_OrderNo field.
	''' </summary>
	Public Sub SetRef_BS_OrderNoFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Ref_BS_OrderNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.Ref_BS_OrderNo field.
	''' </summary>
	Public Sub SetRef_BS_OrderNoFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Ref_BS_OrderNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.Ref_BS_OrderNo field.
	''' </summary>
	Public Sub SetRef_BS_OrderNoFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Ref_BS_OrderNoColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.ActIndx field.
	''' </summary>
	Public Function GetActIndxValue() As ColumnValue
		Return Me.GetValue(TableUtils.ActIndxColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.ActIndx field.
	''' </summary>
	Public Function GetActIndxFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ActIndxColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.ActIndx field.
	''' </summary>
	Public Sub SetActIndxFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ActIndxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.ActIndx field.
	''' </summary>
	Public Sub SetActIndxFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ActIndxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.ActIndx field.
	''' </summary>
	Public Sub SetActIndxFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ActIndxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.ActIndx field.
	''' </summary>
	Public Sub SetActIndxFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ActIndxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.ActIndx field.
	''' </summary>
	Public Sub SetActIndxFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ActIndxColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.CreatedBy field.
	''' </summary>
	Public Function GetCreatedByValue() As ColumnValue
		Return Me.GetValue(TableUtils.CreatedByColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.CreatedBy field.
	''' </summary>
	Public Function GetCreatedByFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CreatedByColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.CreatedBy field.
	''' </summary>
	Public Sub SetCreatedByFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CreatedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.CreatedBy field.
	''' </summary>
	Public Sub SetCreatedByFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CreatedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.DateCreated field.
	''' </summary>
	Public Function GetDateCreatedValue() As ColumnValue
		Return Me.GetValue(TableUtils.DateCreatedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.DateCreated field.
	''' </summary>
	Public Function GetDateCreatedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.DateCreatedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.DateCreated field.
	''' </summary>
	Public Sub SetDateCreatedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.DateCreated field.
	''' </summary>
	Public Sub SetDateCreatedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.DateCreated field.
	''' </summary>
	Public Sub SetDateCreatedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.ModifiedBy field.
	''' </summary>
	Public Function GetModifiedByValue() As ColumnValue
		Return Me.GetValue(TableUtils.ModifiedByColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.ModifiedBy field.
	''' </summary>
	Public Function GetModifiedByFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ModifiedByColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.ModifiedBy field.
	''' </summary>
	Public Sub SetModifiedByFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ModifiedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.ModifiedBy field.
	''' </summary>
	Public Sub SetModifiedByFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ModifiedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.DateModified field.
	''' </summary>
	Public Function GetDateModifiedValue() As ColumnValue
		Return Me.GetValue(TableUtils.DateModifiedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's CFBS_CategoryMapping_.DateModified field.
	''' </summary>
	Public Function GetDateModifiedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.DateModifiedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.DateModified field.
	''' </summary>
	Public Sub SetDateModifiedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DateModifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.DateModified field.
	''' </summary>
	Public Sub SetDateModifiedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DateModifiedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's CFBS_CategoryMapping_.DateModified field.
	''' </summary>
	Public Sub SetDateModifiedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DateModifiedColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CFBS_CategoryMapping_.MapID field.
	''' </summary>
	Public Property MapID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.MapIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.MapIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property MapIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.MapIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property MapIDDefault() As String
        Get
            Return TableUtils.MapIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CFBS_CategoryMapping_.IsPrimary field.
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
	''' This is a convenience property that provides direct access to the value of the record's CFBS_CategoryMapping_.BS_OrderNo field.
	''' </summary>
	Public Property BS_OrderNo() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.BS_OrderNoColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.BS_OrderNoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property BS_OrderNoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.BS_OrderNoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property BS_OrderNoDefault() As String
        Get
            Return TableUtils.BS_OrderNoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CFBS_CategoryMapping_.CF_OrderNo field.
	''' </summary>
	Public Property CF_OrderNo() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CF_OrderNoColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CF_OrderNoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CF_OrderNoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CF_OrderNoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CF_OrderNoDefault() As String
        Get
            Return TableUtils.CF_OrderNoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CFBS_CategoryMapping_.Ref_BS_OrderNo field.
	''' </summary>
	Public Property Ref_BS_OrderNo() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.Ref_BS_OrderNoColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Ref_BS_OrderNoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Ref_BS_OrderNoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Ref_BS_OrderNoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Ref_BS_OrderNoDefault() As String
        Get
            Return TableUtils.Ref_BS_OrderNoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CFBS_CategoryMapping_.ActIndx field.
	''' </summary>
	Public Property ActIndx() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ActIndxColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ActIndxColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ActIndxSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ActIndxColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ActIndxDefault() As String
        Get
            Return TableUtils.ActIndxColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's CFBS_CategoryMapping_.CreatedBy field.
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
	''' This is a convenience property that provides direct access to the value of the record's CFBS_CategoryMapping_.DateCreated field.
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
	''' This is a convenience property that provides direct access to the value of the record's CFBS_CategoryMapping_.ModifiedBy field.
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
	''' This is a convenience property that provides direct access to the value of the record's CFBS_CategoryMapping_.DateModified field.
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
