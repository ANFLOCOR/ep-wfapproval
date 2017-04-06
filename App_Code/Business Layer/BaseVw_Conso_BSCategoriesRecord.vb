' This class is "generated" and will be overwritten.
' Your customizations should be made in Vw_Conso_BSCategoriesRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Vw_Conso_BSCategoriesRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Vw_Conso_BSCategoriesView"></see> class.
''' </remarks>
''' <seealso cref="Vw_Conso_BSCategoriesView"></seealso>
''' <seealso cref="Vw_Conso_BSCategoriesRecord"></seealso>

<Serializable()> Public Class BaseVw_Conso_BSCategoriesRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As Vw_Conso_BSCategoriesView = Vw_Conso_BSCategoriesView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Vw_Conso_BSCategoriesRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Vw_Conso_BSCategoriesRec As Vw_Conso_BSCategoriesRecord = CType(sender,Vw_Conso_BSCategoriesRecord)
        If Not Vw_Conso_BSCategoriesRec Is Nothing AndAlso Not Vw_Conso_BSCategoriesRec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Vw_Conso_BSCategoriesRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Vw_Conso_BSCategoriesRec As Vw_Conso_BSCategoriesRecord = CType(sender,Vw_Conso_BSCategoriesRecord)
        Validate_Inserting()
        If Not Vw_Conso_BSCategoriesRec Is Nothing AndAlso Not Vw_Conso_BSCategoriesRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's vw_Conso_BSCategories_.ACCATROW_ID field.
	''' </summary>
	Public Function GetACCATROW_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ACCATROW_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_Conso_BSCategories_.ACCATROW_ID field.
	''' </summary>
	Public Function GetACCATROW_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ACCATROW_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.ACCATROW_ID field.
	''' </summary>
	Public Sub SetACCATROW_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ACCATROW_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.ACCATROW_ID field.
	''' </summary>
	Public Sub SetACCATROW_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ACCATROW_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.ACCATROW_ID field.
	''' </summary>
	Public Sub SetACCATROW_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ACCATROW_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.ACCATROW_ID field.
	''' </summary>
	Public Sub SetACCATROW_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ACCATROW_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.ACCATROW_ID field.
	''' </summary>
	Public Sub SetACCATROW_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ACCATROW_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_Conso_BSCategories_.ACCATNUM field.
	''' </summary>
	Public Function GetACCATNUMValue() As ColumnValue
		Return Me.GetValue(TableUtils.ACCATNUMColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_Conso_BSCategories_.ACCATNUM field.
	''' </summary>
	Public Function GetACCATNUMFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ACCATNUMColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.ACCATNUM field.
	''' </summary>
	Public Sub SetACCATNUMFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ACCATNUMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.ACCATNUM field.
	''' </summary>
	Public Sub SetACCATNUMFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ACCATNUMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.ACCATNUM field.
	''' </summary>
	Public Sub SetACCATNUMFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ACCATNUMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.ACCATNUM field.
	''' </summary>
	Public Sub SetACCATNUMFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ACCATNUMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.ACCATNUM field.
	''' </summary>
	Public Sub SetACCATNUMFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ACCATNUMColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_Conso_BSCategories_.ACCATDESC field.
	''' </summary>
	Public Function GetACCATDESCValue() As ColumnValue
		Return Me.GetValue(TableUtils.ACCATDESCColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_Conso_BSCategories_.ACCATDESC field.
	''' </summary>
	Public Function GetACCATDESCFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ACCATDESCColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.ACCATDESC field.
	''' </summary>
	Public Sub SetACCATDESCFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ACCATDESCColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.ACCATDESC field.
	''' </summary>
	Public Sub SetACCATDESCFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ACCATDESCColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_Conso_BSCategories_.ORDERNO field.
	''' </summary>
	Public Function GetORDERNOValue() As ColumnValue
		Return Me.GetValue(TableUtils.ORDERNOColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_Conso_BSCategories_.ORDERNO field.
	''' </summary>
	Public Function GetORDERNOFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ORDERNOColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.ORDERNO field.
	''' </summary>
	Public Sub SetORDERNOFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ORDERNOColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.ORDERNO field.
	''' </summary>
	Public Sub SetORDERNOFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ORDERNOColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.ORDERNO field.
	''' </summary>
	Public Sub SetORDERNOFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ORDERNOColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.ORDERNO field.
	''' </summary>
	Public Sub SetORDERNOFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ORDERNOColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.ORDERNO field.
	''' </summary>
	Public Sub SetORDERNOFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ORDERNOColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_Conso_BSCategories_.LEVELNO field.
	''' </summary>
	Public Function GetLEVELNOValue() As ColumnValue
		Return Me.GetValue(TableUtils.LEVELNOColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_Conso_BSCategories_.LEVELNO field.
	''' </summary>
	Public Function GetLEVELNOFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.LEVELNOColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.LEVELNO field.
	''' </summary>
	Public Sub SetLEVELNOFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LEVELNOColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.LEVELNO field.
	''' </summary>
	Public Sub SetLEVELNOFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LEVELNOColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.LEVELNO field.
	''' </summary>
	Public Sub SetLEVELNOFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LEVELNOColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.LEVELNO field.
	''' </summary>
	Public Sub SetLEVELNOFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LEVELNOColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.LEVELNO field.
	''' </summary>
	Public Sub SetLEVELNOFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LEVELNOColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_Conso_BSCategories_.LEVEL1 field.
	''' </summary>
	Public Function GetLEVEL1Value() As ColumnValue
		Return Me.GetValue(TableUtils.LEVEL1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_Conso_BSCategories_.LEVEL1 field.
	''' </summary>
	Public Function GetLEVEL1FieldValue() As String
		Return CType(Me.GetValue(TableUtils.LEVEL1Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.LEVEL1 field.
	''' </summary>
	Public Sub SetLEVEL1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LEVEL1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.LEVEL1 field.
	''' </summary>
	Public Sub SetLEVEL1FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LEVEL1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_Conso_BSCategories_.LEVEL1_ORD field.
	''' </summary>
	Public Function GetLEVEL1_ORDValue() As ColumnValue
		Return Me.GetValue(TableUtils.LEVEL1_ORDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_Conso_BSCategories_.LEVEL1_ORD field.
	''' </summary>
	Public Function GetLEVEL1_ORDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.LEVEL1_ORDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.LEVEL1_ORD field.
	''' </summary>
	Public Sub SetLEVEL1_ORDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LEVEL1_ORDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.LEVEL1_ORD field.
	''' </summary>
	Public Sub SetLEVEL1_ORDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LEVEL1_ORDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.LEVEL1_ORD field.
	''' </summary>
	Public Sub SetLEVEL1_ORDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LEVEL1_ORDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.LEVEL1_ORD field.
	''' </summary>
	Public Sub SetLEVEL1_ORDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LEVEL1_ORDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.LEVEL1_ORD field.
	''' </summary>
	Public Sub SetLEVEL1_ORDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LEVEL1_ORDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_Conso_BSCategories_.LEVEL2 field.
	''' </summary>
	Public Function GetLEVEL2Value() As ColumnValue
		Return Me.GetValue(TableUtils.LEVEL2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_Conso_BSCategories_.LEVEL2 field.
	''' </summary>
	Public Function GetLEVEL2FieldValue() As String
		Return CType(Me.GetValue(TableUtils.LEVEL2Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.LEVEL2 field.
	''' </summary>
	Public Sub SetLEVEL2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LEVEL2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.LEVEL2 field.
	''' </summary>
	Public Sub SetLEVEL2FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LEVEL2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_Conso_BSCategories_.LEVEL2_ORD field.
	''' </summary>
	Public Function GetLEVEL2_ORDValue() As ColumnValue
		Return Me.GetValue(TableUtils.LEVEL2_ORDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_Conso_BSCategories_.LEVEL2_ORD field.
	''' </summary>
	Public Function GetLEVEL2_ORDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.LEVEL2_ORDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.LEVEL2_ORD field.
	''' </summary>
	Public Sub SetLEVEL2_ORDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LEVEL2_ORDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.LEVEL2_ORD field.
	''' </summary>
	Public Sub SetLEVEL2_ORDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LEVEL2_ORDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.LEVEL2_ORD field.
	''' </summary>
	Public Sub SetLEVEL2_ORDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LEVEL2_ORDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.LEVEL2_ORD field.
	''' </summary>
	Public Sub SetLEVEL2_ORDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LEVEL2_ORDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_Conso_BSCategories_.LEVEL2_ORD field.
	''' </summary>
	Public Sub SetLEVEL2_ORDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LEVEL2_ORDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_Conso_BSCategories_.ACCATROW_ID field.
	''' </summary>
	Public Property ACCATROW_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ACCATROW_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ACCATROW_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ACCATROW_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ACCATROW_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ACCATROW_IDDefault() As String
        Get
            Return TableUtils.ACCATROW_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_Conso_BSCategories_.ACCATNUM field.
	''' </summary>
	Public Property ACCATNUM() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ACCATNUMColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ACCATNUMColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ACCATNUMSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ACCATNUMColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ACCATNUMDefault() As String
        Get
            Return TableUtils.ACCATNUMColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_Conso_BSCategories_.ACCATDESC field.
	''' </summary>
	Public Property ACCATDESC() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ACCATDESCColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ACCATDESCColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ACCATDESCSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ACCATDESCColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ACCATDESCDefault() As String
        Get
            Return TableUtils.ACCATDESCColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_Conso_BSCategories_.ORDERNO field.
	''' </summary>
	Public Property ORDERNO() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ORDERNOColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ORDERNOColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ORDERNOSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ORDERNOColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ORDERNODefault() As String
        Get
            Return TableUtils.ORDERNOColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_Conso_BSCategories_.LEVELNO field.
	''' </summary>
	Public Property LEVELNO() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.LEVELNOColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LEVELNOColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LEVELNOSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LEVELNOColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LEVELNODefault() As String
        Get
            Return TableUtils.LEVELNOColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_Conso_BSCategories_.LEVEL1 field.
	''' </summary>
	Public Property LEVEL1() As String
		Get 
			Return CType(Me.GetValue(TableUtils.LEVEL1Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.LEVEL1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LEVEL1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LEVEL1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LEVEL1Default() As String
        Get
            Return TableUtils.LEVEL1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_Conso_BSCategories_.LEVEL1_ORD field.
	''' </summary>
	Public Property LEVEL1_ORD() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.LEVEL1_ORDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LEVEL1_ORDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LEVEL1_ORDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LEVEL1_ORDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LEVEL1_ORDDefault() As String
        Get
            Return TableUtils.LEVEL1_ORDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_Conso_BSCategories_.LEVEL2 field.
	''' </summary>
	Public Property LEVEL2() As String
		Get 
			Return CType(Me.GetValue(TableUtils.LEVEL2Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.LEVEL2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LEVEL2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LEVEL2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LEVEL2Default() As String
        Get
            Return TableUtils.LEVEL2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_Conso_BSCategories_.LEVEL2_ORD field.
	''' </summary>
	Public Property LEVEL2_ORD() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.LEVEL2_ORDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LEVEL2_ORDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LEVEL2_ORDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LEVEL2_ORDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LEVEL2_ORDDefault() As String
        Get
            Return TableUtils.LEVEL2_ORDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
