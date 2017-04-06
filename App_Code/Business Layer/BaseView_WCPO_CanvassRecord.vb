' This class is "generated" and will be overwritten.
' Your customizations should be made in View_WCPO_CanvassRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="View_WCPO_CanvassRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="View_WCPO_CanvassView"></see> class.
''' </remarks>
''' <seealso cref="View_WCPO_CanvassView"></seealso>
''' <seealso cref="View_WCPO_CanvassRecord"></seealso>

<Serializable()> Public Class BaseView_WCPO_CanvassRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As View_WCPO_CanvassView = View_WCPO_CanvassView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub View_WCPO_CanvassRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim View_WCPO_CanvassRec As View_WCPO_CanvassRecord = CType(sender,View_WCPO_CanvassRecord)
        Validate_Inserting()
        If Not View_WCPO_CanvassRec Is Nothing AndAlso Not View_WCPO_CanvassRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub View_WCPO_CanvassRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim View_WCPO_CanvassRec As View_WCPO_CanvassRecord = CType(sender,View_WCPO_CanvassRecord)
        Validate_Updating()
        If Not View_WCPO_CanvassRec Is Nothing AndAlso Not View_WCPO_CanvassRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub View_WCPO_CanvassRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim View_WCPO_CanvassRec As View_WCPO_CanvassRecord = CType(sender,View_WCPO_CanvassRecord)
        If Not View_WCPO_CanvassRec Is Nothing AndAlso Not View_WCPO_CanvassRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.CompanyIDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.PONo field.
	''' </summary>
	Public Function GetPONoValue() As ColumnValue
		Return Me.GetValue(TableUtils.PONoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.PONo field.
	''' </summary>
	Public Function GetPONoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PONoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.PONo field.
	''' </summary>
	Public Sub SetPONoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PONoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.PONo field.
	''' </summary>
	Public Sub SetPONoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PONoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.PRID field.
	''' </summary>
	Public Function GetPRIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PRIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.PRID field.
	''' </summary>
	Public Function GetPRIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PRIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.PRID field.
	''' </summary>
	Public Sub SetPRIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PRIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.PRID field.
	''' </summary>
	Public Sub SetPRIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PRIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.PRID field.
	''' </summary>
	Public Sub SetPRIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PRIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.PRID field.
	''' </summary>
	Public Sub SetPRIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PRIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.PRID field.
	''' </summary>
	Public Sub SetPRIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PRIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.CanvassDate field.
	''' </summary>
	Public Function GetCanvassDateValue() As ColumnValue
		Return Me.GetValue(TableUtils.CanvassDateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.CanvassDate field.
	''' </summary>
	Public Function GetCanvassDateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.CanvassDateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.CanvassDate field.
	''' </summary>
	Public Sub SetCanvassDateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CanvassDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.CanvassDate field.
	''' </summary>
	Public Sub SetCanvassDateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CanvassDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.CanvassDate field.
	''' </summary>
	Public Sub SetCanvassDateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CanvassDateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.Vendors field.
	''' </summary>
	Public Function GetVendorsValue() As ColumnValue
		Return Me.GetValue(TableUtils.VendorsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.Vendors field.
	''' </summary>
	Public Function GetVendorsFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.VendorsColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.Vendors field.
	''' </summary>
	Public Sub SetVendorsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.VendorsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.Vendors field.
	''' </summary>
	Public Sub SetVendorsFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.VendorsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.Vendors field.
	''' </summary>
	Public Sub SetVendorsFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VendorsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.Vendors field.
	''' </summary>
	Public Sub SetVendorsFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VendorsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.Vendors field.
	''' </summary>
	Public Sub SetVendorsFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VendorsColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.WCI_Submit field.
	''' </summary>
	Public Function GetWCI_SubmitValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_SubmitColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.WCI_Submit field.
	''' </summary>
	Public Function GetWCI_SubmitFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCI_SubmitColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.WCI_Submit field.
	''' </summary>
	Public Sub SetWCI_SubmitFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_SubmitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.WCI_Submit field.
	''' </summary>
	Public Sub SetWCI_SubmitFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCI_SubmitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.WCI_Submit field.
	''' </summary>
	Public Sub SetWCI_SubmitFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_SubmitColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.WCI_Status field.
	''' </summary>
	Public Function GetWCI_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.WCI_Status field.
	''' </summary>
	Public Function GetWCI_StatusFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCI_StatusColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.WCI_Status field.
	''' </summary>
	Public Sub SetWCI_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.WCI_Status field.
	''' </summary>
	Public Sub SetWCI_StatusFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.Classification field.
	''' </summary>
	Public Function GetClassificationValue() As ColumnValue
		Return Me.GetValue(TableUtils.ClassificationColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.Classification field.
	''' </summary>
	Public Function GetClassificationFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ClassificationColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.Classification field.
	''' </summary>
	Public Sub SetClassificationFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ClassificationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.Classification field.
	''' </summary>
	Public Sub SetClassificationFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ClassificationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.Classification field.
	''' </summary>
	Public Sub SetClassificationFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ClassificationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.Classification field.
	''' </summary>
	Public Sub SetClassificationFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ClassificationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.Classification field.
	''' </summary>
	Public Sub SetClassificationFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ClassificationColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.Buyer field.
	''' </summary>
	Public Function GetBuyerValue() As ColumnValue
		Return Me.GetValue(TableUtils.BuyerColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.Buyer field.
	''' </summary>
	Public Function GetBuyerFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.BuyerColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.Buyer field.
	''' </summary>
	Public Sub SetBuyerFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.BuyerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.Buyer field.
	''' </summary>
	Public Sub SetBuyerFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.BuyerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.Buyer field.
	''' </summary>
	Public Sub SetBuyerFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.BuyerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.Buyer field.
	''' </summary>
	Public Sub SetBuyerFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.BuyerColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.Buyer field.
	''' </summary>
	Public Sub SetBuyerFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.BuyerColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.WCI_ID field.
	''' </summary>
	Public Function GetWCI_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCI_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's view_WCPO_Canvass_.WCI_ID field.
	''' </summary>
	Public Function GetWCI_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCI_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.WCI_ID field.
	''' </summary>
	Public Sub SetWCI_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.WCI_ID field.
	''' </summary>
	Public Sub SetWCI_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.WCI_ID field.
	''' </summary>
	Public Sub SetWCI_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.WCI_ID field.
	''' </summary>
	Public Sub SetWCI_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's view_WCPO_Canvass_.WCI_ID field.
	''' </summary>
	Public Sub SetWCI_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCI_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_WCPO_Canvass_.CompanyID field.
	''' </summary>
	Public Property CompanyID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.CompanyIDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CompanyIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CompanyIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CompanyIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CompanyIDDefault() As String
        Get
            Return TableUtils.CompanyIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_WCPO_Canvass_.PONo field.
	''' </summary>
	Public Property PONo() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PONoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PONoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PONoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PONoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PONoDefault() As String
        Get
            Return TableUtils.PONoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_WCPO_Canvass_.PRID field.
	''' </summary>
	Public Property PRID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PRIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PRIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PRIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PRIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PRIDDefault() As String
        Get
            Return TableUtils.PRIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_WCPO_Canvass_.CanvassDate field.
	''' </summary>
	Public Property CanvassDate() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.CanvassDateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CanvassDateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CanvassDateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CanvassDateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CanvassDateDefault() As String
        Get
            Return TableUtils.CanvassDateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_WCPO_Canvass_.Vendors field.
	''' </summary>
	Public Property Vendors() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.VendorsColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.VendorsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property VendorsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.VendorsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property VendorsDefault() As String
        Get
            Return TableUtils.VendorsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_WCPO_Canvass_.WCI_Submit field.
	''' </summary>
	Public Property WCI_Submit() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCI_SubmitColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCI_SubmitColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCI_SubmitSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCI_SubmitColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCI_SubmitDefault() As String
        Get
            Return TableUtils.WCI_SubmitColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_WCPO_Canvass_.WCI_Status field.
	''' </summary>
	Public Property WCI_Status() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCI_StatusColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCI_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCI_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCI_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCI_StatusDefault() As String
        Get
            Return TableUtils.WCI_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_WCPO_Canvass_.Classification field.
	''' </summary>
	Public Property Classification() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ClassificationColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ClassificationColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ClassificationSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ClassificationColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ClassificationDefault() As String
        Get
            Return TableUtils.ClassificationColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_WCPO_Canvass_.Buyer field.
	''' </summary>
	Public Property Buyer() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.BuyerColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.BuyerColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property BuyerSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.BuyerColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property BuyerDefault() As String
        Get
            Return TableUtils.BuyerColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's view_WCPO_Canvass_.WCI_ID field.
	''' </summary>
	Public Property WCI_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCI_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCI_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCI_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCI_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCI_IDDefault() As String
        Get
            Return TableUtils.WCI_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
