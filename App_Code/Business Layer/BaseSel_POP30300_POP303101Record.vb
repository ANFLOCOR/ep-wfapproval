' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_POP30300_POP303101Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_POP30300_POP303101Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_POP30300_POP303101View"></see> class.
''' </remarks>
''' <seealso cref="Sel_POP30300_POP303101View"></seealso>
''' <seealso cref="Sel_POP30300_POP303101Record"></seealso>

<Serializable()> Public Class BaseSel_POP30300_POP303101Record
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_POP30300_POP303101View = Sel_POP30300_POP303101View.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_POP30300_POP303101Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_POP30300_POP303101Rec As Sel_POP30300_POP303101Record = CType(sender,Sel_POP30300_POP303101Record)
        If Not Sel_POP30300_POP303101Rec Is Nothing AndAlso Not Sel_POP30300_POP303101Rec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_POP30300_POP303101Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_POP30300_POP303101Rec As Sel_POP30300_POP303101Record = CType(sender,Sel_POP30300_POP303101Record)
        Validate_Inserting()
        If Not Sel_POP30300_POP303101Rec Is Nothing AndAlso Not Sel_POP30300_POP303101Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.VENDORID field.
	''' </summary>
	Public Function GetVENDORIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.VENDORIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.VENDORID field.
	''' </summary>
	Public Function GetVENDORIDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.VENDORIDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.VENDORID field.
	''' </summary>
	Public Sub SetVENDORIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.VENDORIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.VENDORID field.
	''' </summary>
	Public Sub SetVENDORIDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VENDORIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.VENDNAME field.
	''' </summary>
	Public Function GetVENDNAMEValue() As ColumnValue
		Return Me.GetValue(TableUtils.VENDNAMEColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.VENDNAME field.
	''' </summary>
	Public Function GetVENDNAMEFieldValue() As String
		Return CType(Me.GetValue(TableUtils.VENDNAMEColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.VENDNAME field.
	''' </summary>
	Public Sub SetVENDNAMEFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.VENDNAMEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.VENDNAME field.
	''' </summary>
	Public Sub SetVENDNAMEFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VENDNAMEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.ITEMNMBR field.
	''' </summary>
	Public Function GetITEMNMBRValue() As ColumnValue
		Return Me.GetValue(TableUtils.ITEMNMBRColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.ITEMNMBR field.
	''' </summary>
	Public Function GetITEMNMBRFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ITEMNMBRColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.ITEMNMBR field.
	''' </summary>
	Public Sub SetITEMNMBRFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ITEMNMBRColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.ITEMNMBR field.
	''' </summary>
	Public Sub SetITEMNMBRFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ITEMNMBRColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.ITEMDESC field.
	''' </summary>
	Public Function GetITEMDESCValue() As ColumnValue
		Return Me.GetValue(TableUtils.ITEMDESCColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.ITEMDESC field.
	''' </summary>
	Public Function GetITEMDESCFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ITEMDESCColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.ITEMDESC field.
	''' </summary>
	Public Sub SetITEMDESCFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ITEMDESCColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.ITEMDESC field.
	''' </summary>
	Public Sub SetITEMDESCFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ITEMDESCColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.UOFM field.
	''' </summary>
	Public Function GetUOFMValue() As ColumnValue
		Return Me.GetValue(TableUtils.UOFMColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.UOFM field.
	''' </summary>
	Public Function GetUOFMFieldValue() As String
		Return CType(Me.GetValue(TableUtils.UOFMColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.UOFM field.
	''' </summary>
	Public Sub SetUOFMFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UOFMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.UOFM field.
	''' </summary>
	Public Sub SetUOFMFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UOFMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.UNITCOST field.
	''' </summary>
	Public Function GetUNITCOSTValue() As ColumnValue
		Return Me.GetValue(TableUtils.UNITCOSTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.UNITCOST field.
	''' </summary>
	Public Function GetUNITCOSTFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.UNITCOSTColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.UNITCOST field.
	''' </summary>
	Public Sub SetUNITCOSTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UNITCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.UNITCOST field.
	''' </summary>
	Public Sub SetUNITCOSTFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UNITCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.UNITCOST field.
	''' </summary>
	Public Sub SetUNITCOSTFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UNITCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.UNITCOST field.
	''' </summary>
	Public Sub SetUNITCOSTFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UNITCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.UNITCOST field.
	''' </summary>
	Public Sub SetUNITCOSTFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UNITCOSTColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.EXTDCOST field.
	''' </summary>
	Public Function GetEXTDCOSTValue() As ColumnValue
		Return Me.GetValue(TableUtils.EXTDCOSTColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.EXTDCOST field.
	''' </summary>
	Public Function GetEXTDCOSTFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.EXTDCOSTColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.EXTDCOST field.
	''' </summary>
	Public Sub SetEXTDCOSTFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.EXTDCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.EXTDCOST field.
	''' </summary>
	Public Sub SetEXTDCOSTFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.EXTDCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.EXTDCOST field.
	''' </summary>
	Public Sub SetEXTDCOSTFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EXTDCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.EXTDCOST field.
	''' </summary>
	Public Sub SetEXTDCOSTFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EXTDCOSTColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.EXTDCOST field.
	''' </summary>
	Public Sub SetEXTDCOSTFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.EXTDCOSTColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.receiptdate field.
	''' </summary>
	Public Function GetreceiptdateValue() As ColumnValue
		Return Me.GetValue(TableUtils.receiptdateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.receiptdate field.
	''' </summary>
	Public Function GetreceiptdateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.receiptdateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.receiptdate field.
	''' </summary>
	Public Sub SetreceiptdateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.receiptdateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.receiptdate field.
	''' </summary>
	Public Sub SetreceiptdateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.receiptdateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.receiptdate field.
	''' </summary>
	Public Sub SetreceiptdateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.receiptdateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.Company_ID field.
	''' </summary>
	Public Function GetCompany_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.Company_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.Company_ID field.
	''' </summary>
	Public Function GetCompany_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.Company_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.Qty field.
	''' </summary>
	Public Function GetQtyValue() As ColumnValue
		Return Me.GetValue(TableUtils.QtyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_POP30300_POP30310_.Qty field.
	''' </summary>
	Public Function GetQtyFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.QtyColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.Qty field.
	''' </summary>
	Public Sub SetQtyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.Qty field.
	''' </summary>
	Public Sub SetQtyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.Qty field.
	''' </summary>
	Public Sub SetQtyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.Qty field.
	''' </summary>
	Public Sub SetQtyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.QtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_POP30300_POP30310_.Qty field.
	''' </summary>
	Public Sub SetQtyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.QtyColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_POP30300_POP30310_.VENDORID field.
	''' </summary>
	Public Property VENDORID() As String
		Get 
			Return CType(Me.GetValue(TableUtils.VENDORIDColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.VENDORIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property VENDORIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.VENDORIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property VENDORIDDefault() As String
        Get
            Return TableUtils.VENDORIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_POP30300_POP30310_.VENDNAME field.
	''' </summary>
	Public Property VENDNAME() As String
		Get 
			Return CType(Me.GetValue(TableUtils.VENDNAMEColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.VENDNAMEColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property VENDNAMESpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.VENDNAMEColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property VENDNAMEDefault() As String
        Get
            Return TableUtils.VENDNAMEColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_POP30300_POP30310_.ITEMNMBR field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_POP30300_POP30310_.ITEMDESC field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_POP30300_POP30310_.UOFM field.
	''' </summary>
	Public Property UOFM() As String
		Get 
			Return CType(Me.GetValue(TableUtils.UOFMColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.UOFMColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UOFMSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UOFMColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UOFMDefault() As String
        Get
            Return TableUtils.UOFMColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_POP30300_POP30310_.UNITCOST field.
	''' </summary>
	Public Property UNITCOST() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.UNITCOSTColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.UNITCOSTColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UNITCOSTSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UNITCOSTColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UNITCOSTDefault() As String
        Get
            Return TableUtils.UNITCOSTColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_POP30300_POP30310_.EXTDCOST field.
	''' </summary>
	Public Property EXTDCOST() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.EXTDCOSTColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.EXTDCOSTColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property EXTDCOSTSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.EXTDCOSTColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property EXTDCOSTDefault() As String
        Get
            Return TableUtils.EXTDCOSTColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_POP30300_POP30310_.receiptdate field.
	''' </summary>
	Public Property receiptdate() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.receiptdateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.receiptdateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property receiptdateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.receiptdateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property receiptdateDefault() As String
        Get
            Return TableUtils.receiptdateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_POP30300_POP30310_.Company_ID field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_POP30300_POP30310_.Qty field.
	''' </summary>
	Public Property Qty() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.QtyColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.QtyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property QtySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.QtyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property QtyDefault() As String
        Get
            Return TableUtils.QtyColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
