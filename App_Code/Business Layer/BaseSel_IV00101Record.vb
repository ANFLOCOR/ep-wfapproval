' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_IV00101Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_IV00101Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_IV00101View"></see> class.
''' </remarks>
''' <seealso cref="Sel_IV00101View"></seealso>
''' <seealso cref="Sel_IV00101Record"></seealso>

<Serializable()> Public Class BaseSel_IV00101Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_IV00101View = Sel_IV00101View.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_IV00101Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_IV00101Rec As Sel_IV00101Record = CType(sender,Sel_IV00101Record)
        Validate_Inserting()
        If Not Sel_IV00101Rec Is Nothing AndAlso Not Sel_IV00101Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub Sel_IV00101Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim Sel_IV00101Rec As Sel_IV00101Record = CType(sender,Sel_IV00101Record)
        Validate_Updating()
        If Not Sel_IV00101Rec Is Nothing AndAlso Not Sel_IV00101Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_IV00101Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_IV00101Rec As Sel_IV00101Record = CType(sender,Sel_IV00101Record)
        If Not Sel_IV00101Rec Is Nothing AndAlso Not Sel_IV00101Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.ITEMNMBR field.
	''' </summary>
	Public Function GetITEMNMBRValue() As ColumnValue
		Return Me.GetValue(TableUtils.ITEMNMBRColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.ITEMNMBR field.
	''' </summary>
	Public Function GetITEMNMBRFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ITEMNMBRColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.ITEMNMBR field.
	''' </summary>
	Public Sub SetITEMNMBRFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ITEMNMBRColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.ITEMNMBR field.
	''' </summary>
	Public Sub SetITEMNMBRFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ITEMNMBRColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.ITEMDESC field.
	''' </summary>
	Public Function GetITEMDESCValue() As ColumnValue
		Return Me.GetValue(TableUtils.ITEMDESCColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.ITEMDESC field.
	''' </summary>
	Public Function GetITEMDESCFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ITEMDESCColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.ITEMDESC field.
	''' </summary>
	Public Sub SetITEMDESCFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ITEMDESCColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.ITEMDESC field.
	''' </summary>
	Public Sub SetITEMDESCFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ITEMDESCColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.CURRCOST field.
	''' </summary>
	Public Function GetCURRCOSTValue() As ColumnValue
		Return Me.GetValue(TableUtils.CURRCOSTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.CURRCOST field.
	''' </summary>
	Public Function GetCURRCOSTFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.CURRCOSTColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.CURRCOST field.
	''' </summary>
	Public Sub SetCURRCOSTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CURRCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.CURRCOST field.
	''' </summary>
	Public Sub SetCURRCOSTFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CURRCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.CURRCOST field.
	''' </summary>
	Public Sub SetCURRCOSTFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CURRCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.CURRCOST field.
	''' </summary>
	Public Sub SetCURRCOSTFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CURRCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.CURRCOST field.
	''' </summary>
	Public Sub SetCURRCOSTFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CURRCOSTColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.IVIVOFIX field.
	''' </summary>
	Public Function GetIVIVOFIXValue() As ColumnValue
		Return Me.GetValue(TableUtils.IVIVOFIXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.IVIVOFIX field.
	''' </summary>
	Public Function GetIVIVOFIXFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.IVIVOFIXColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.IVIVOFIX field.
	''' </summary>
	Public Sub SetIVIVOFIXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IVIVOFIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.IVIVOFIX field.
	''' </summary>
	Public Sub SetIVIVOFIXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.IVIVOFIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.IVIVOFIX field.
	''' </summary>
	Public Sub SetIVIVOFIXFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IVIVOFIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.IVIVOFIX field.
	''' </summary>
	Public Sub SetIVIVOFIXFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IVIVOFIXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.IVIVOFIX field.
	''' </summary>
	Public Sub SetIVIVOFIXFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IVIVOFIXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.IVIVINDX field.
	''' </summary>
	Public Function GetIVIVINDXValue() As ColumnValue
		Return Me.GetValue(TableUtils.IVIVINDXColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.IVIVINDX field.
	''' </summary>
	Public Function GetIVIVINDXFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.IVIVINDXColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.IVIVINDX field.
	''' </summary>
	Public Sub SetIVIVINDXFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IVIVINDXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.IVIVINDX field.
	''' </summary>
	Public Sub SetIVIVINDXFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.IVIVINDXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.IVIVINDX field.
	''' </summary>
	Public Sub SetIVIVINDXFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IVIVINDXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.IVIVINDX field.
	''' </summary>
	Public Sub SetIVIVINDXFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IVIVINDXColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.IVIVINDX field.
	''' </summary>
	Public Sub SetIVIVINDXFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IVIVINDXColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.LOCNCODE field.
	''' </summary>
	Public Function GetLOCNCODEValue() As ColumnValue
		Return Me.GetValue(TableUtils.LOCNCODEColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.LOCNCODE field.
	''' </summary>
	Public Function GetLOCNCODEFieldValue() As String
		Return CType(Me.GetValue(TableUtils.LOCNCODEColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.LOCNCODE field.
	''' </summary>
	Public Sub SetLOCNCODEFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LOCNCODEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.LOCNCODE field.
	''' </summary>
	Public Sub SetLOCNCODEFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LOCNCODEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.PRCHSUOM field.
	''' </summary>
	Public Function GetPRCHSUOMValue() As ColumnValue
		Return Me.GetValue(TableUtils.PRCHSUOMColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.PRCHSUOM field.
	''' </summary>
	Public Function GetPRCHSUOMFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PRCHSUOMColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.PRCHSUOM field.
	''' </summary>
	Public Sub SetPRCHSUOMFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PRCHSUOMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.PRCHSUOM field.
	''' </summary>
	Public Sub SetPRCHSUOMFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PRCHSUOMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.Company_ID field.
	''' </summary>
	Public Function GetCompany_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.Company_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.Company_ID field.
	''' </summary>
	Public Function GetCompany_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.Company_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.Account field.
	''' </summary>
	Public Function GetAccountValue() As ColumnValue
		Return Me.GetValue(TableUtils.AccountColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.Account field.
	''' </summary>
	Public Function GetAccountFieldValue() As String
		Return CType(Me.GetValue(TableUtils.AccountColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.Account field.
	''' </summary>
	Public Sub SetAccountFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.AccountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.Account field.
	''' </summary>
	Public Sub SetAccountFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.AccountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.ITMSHNAM field.
	''' </summary>
	Public Function GetITMSHNAMValue() As ColumnValue
		Return Me.GetValue(TableUtils.ITMSHNAMColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_IV00101_.ITMSHNAM field.
	''' </summary>
	Public Function GetITMSHNAMFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ITMSHNAMColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.ITMSHNAM field.
	''' </summary>
	Public Sub SetITMSHNAMFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ITMSHNAMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_IV00101_.ITMSHNAM field.
	''' </summary>
	Public Sub SetITMSHNAMFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ITMSHNAMColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_IV00101_.ITEMNMBR field.
	''' </summary>
	Public Property ITEMNMBR() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ITEMNMBRColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ITEMNMBRColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ITEMNMBRSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ITEMNMBRColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ITEMNMBRDefault() As String
        Get
            Return TableUtils.ITEMNMBRColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_IV00101_.ITEMDESC field.
	''' </summary>
	Public Property ITEMDESC() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ITEMDESCColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ITEMDESCColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ITEMDESCSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ITEMDESCColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ITEMDESCDefault() As String
        Get
            Return TableUtils.ITEMDESCColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_IV00101_.CURRCOST field.
	''' </summary>
	Public Property CURRCOST() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.CURRCOSTColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CURRCOSTColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CURRCOSTSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CURRCOSTColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CURRCOSTDefault() As String
        Get
            Return TableUtils.CURRCOSTColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_IV00101_.IVIVOFIX field.
	''' </summary>
	Public Property IVIVOFIX() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.IVIVOFIXColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.IVIVOFIXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property IVIVOFIXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.IVIVOFIXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property IVIVOFIXDefault() As String
        Get
            Return TableUtils.IVIVOFIXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_IV00101_.IVIVINDX field.
	''' </summary>
	Public Property IVIVINDX() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.IVIVINDXColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.IVIVINDXColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property IVIVINDXSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.IVIVINDXColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property IVIVINDXDefault() As String
        Get
            Return TableUtils.IVIVINDXColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_IV00101_.LOCNCODE field.
	''' </summary>
	Public Property LOCNCODE() As String
		Get 
			Return CType(Me.GetValue(TableUtils.LOCNCODEColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.LOCNCODEColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LOCNCODESpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LOCNCODEColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LOCNCODEDefault() As String
        Get
            Return TableUtils.LOCNCODEColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_IV00101_.PRCHSUOM field.
	''' </summary>
	Public Property PRCHSUOM() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PRCHSUOMColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PRCHSUOMColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PRCHSUOMSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PRCHSUOMColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PRCHSUOMDefault() As String
        Get
            Return TableUtils.PRCHSUOMColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_IV00101_.Company_ID field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_IV00101_.Account field.
	''' </summary>
	Public Property Account() As String
		Get 
			Return CType(Me.GetValue(TableUtils.AccountColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.AccountColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property AccountSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.AccountColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property AccountDefault() As String
        Get
            Return TableUtils.AccountColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_IV00101_.ITMSHNAM field.
	''' </summary>
	Public Property ITMSHNAM() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ITMSHNAMColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ITMSHNAMColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ITMSHNAMSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ITMSHNAMColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ITMSHNAMDefault() As String
        Get
            Return TableUtils.ITMSHNAMColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
