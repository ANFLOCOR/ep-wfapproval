' This class is "generated" and will be overwritten.
' Your customizations should be made in WPO_CARNo_QDetails1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WPO_CARNo_QDetails1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WPO_CARNo_QDetails1View"></see> class.
''' </remarks>
''' <seealso cref="WPO_CARNo_QDetails1View"></seealso>
''' <seealso cref="WPO_CARNo_QDetails1Record"></seealso>

<Serializable()> Public Class BaseWPO_CARNo_QDetails1Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WPO_CARNo_QDetails1View = WPO_CARNo_QDetails1View.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WPO_CARNo_QDetails1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WPO_CARNo_QDetails1Rec As WPO_CARNo_QDetails1Record = CType(sender,WPO_CARNo_QDetails1Record)
        Validate_Inserting()
        If Not WPO_CARNo_QDetails1Rec Is Nothing AndAlso Not WPO_CARNo_QDetails1Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WPO_CARNo_QDetails1Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WPO_CARNo_QDetails1Rec As WPO_CARNo_QDetails1Record = CType(sender,WPO_CARNo_QDetails1Record)
        Validate_Updating()
        If Not WPO_CARNo_QDetails1Rec Is Nothing AndAlso Not WPO_CARNo_QDetails1Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WPO_CARNo_QDetails1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WPO_CARNo_QDetails1Rec As WPO_CARNo_QDetails1Record = CType(sender,WPO_CARNo_QDetails1Record)
        If Not WPO_CARNo_QDetails1Rec Is Nothing AndAlso Not WPO_CARNo_QDetails1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.CompanyIDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.PONum field.
	''' </summary>
	Public Function GetPONumValue() As ColumnValue
		Return Me.GetValue(TableUtils.PONumColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.PONum field.
	''' </summary>
	Public Function GetPONumFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PONumColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.PONum field.
	''' </summary>
	Public Sub SetPONumFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PONumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.PONum field.
	''' </summary>
	Public Sub SetPONumFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PONumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.PRNum field.
	''' </summary>
	Public Function GetPRNumValue() As ColumnValue
		Return Me.GetValue(TableUtils.PRNumColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.PRNum field.
	''' </summary>
	Public Function GetPRNumFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PRNumColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.PRNum field.
	''' </summary>
	Public Sub SetPRNumFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PRNumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.PRNum field.
	''' </summary>
	Public Sub SetPRNumFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PRNumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.Comment field.
	''' </summary>
	Public Function GetCommentValue() As ColumnValue
		Return Me.GetValue(TableUtils.CommentColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.Comment field.
	''' </summary>
	Public Function GetCommentFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CommentColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.Comment field.
	''' </summary>
	Public Sub SetCommentFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CommentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.Comment field.
	''' </summary>
	Public Sub SetCommentFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CommentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.CARID field.
	''' </summary>
	Public Function GetCARIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CARIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.CARID field.
	''' </summary>
	Public Function GetCARIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CARIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.CARID field.
	''' </summary>
	Public Sub SetCARIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CARIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.CARID field.
	''' </summary>
	Public Sub SetCARIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CARIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.CARID field.
	''' </summary>
	Public Sub SetCARIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CARIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.CARID field.
	''' </summary>
	Public Sub SetCARIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CARIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.CARID field.
	''' </summary>
	Public Sub SetCARIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CARIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.WCD_No field.
	''' </summary>
	Public Function GetWCD_NoValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_NoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.WCD_No field.
	''' </summary>
	Public Function GetWCD_NoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCD_NoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.WCD_No field.
	''' </summary>
	Public Sub SetWCD_NoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.WCD_No field.
	''' </summary>
	Public Sub SetWCD_NoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.WCD_Remark field.
	''' </summary>
	Public Function GetWCD_RemarkValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_RemarkColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.WCD_Remark field.
	''' </summary>
	Public Function GetWCD_RemarkFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCD_RemarkColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.WCD_Remark field.
	''' </summary>
	Public Sub SetWCD_RemarkFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.WCD_Remark field.
	''' </summary>
	Public Sub SetWCD_RemarkFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.WCD_Project_Title field.
	''' </summary>
	Public Function GetWCD_Project_TitleValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Project_TitleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.WCD_Project_Title field.
	''' </summary>
	Public Function GetWCD_Project_TitleFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCD_Project_TitleColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.WCD_Project_Title field.
	''' </summary>
	Public Sub SetWCD_Project_TitleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Project_TitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.WCD_Project_Title field.
	''' </summary>
	Public Sub SetWCD_Project_TitleFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Project_TitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.WCD_Exp_Total field.
	''' </summary>
	Public Function GetWCD_Exp_TotalValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Exp_TotalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.WCD_Exp_Total field.
	''' </summary>
	Public Function GetWCD_Exp_TotalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCD_Exp_TotalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Exp_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_Exp_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_TotalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.WCD_ID field.
	''' </summary>
	Public Function GetWCD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_CARNo_QDetails_.WCD_ID field.
	''' </summary>
	Public Function GetWCD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.WCD_ID field.
	''' </summary>
	Public Sub SetWCD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.WCD_ID field.
	''' </summary>
	Public Sub SetWCD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.WCD_ID field.
	''' </summary>
	Public Sub SetWCD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.WCD_ID field.
	''' </summary>
	Public Sub SetWCD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_CARNo_QDetails_.WCD_ID field.
	''' </summary>
	Public Sub SetWCD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_CARNo_QDetails_.CompanyID field.
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
	''' This is a convenience property that provides direct access to the value of the record's WPO_CARNo_QDetails_.PONum field.
	''' </summary>
	Public Property PONum() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PONumColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PONumColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PONumSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PONumColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PONumDefault() As String
        Get
            Return TableUtils.PONumColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_CARNo_QDetails_.PRNum field.
	''' </summary>
	Public Property PRNum() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PRNumColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PRNumColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PRNumSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PRNumColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PRNumDefault() As String
        Get
            Return TableUtils.PRNumColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_CARNo_QDetails_.Comment field.
	''' </summary>
	Public Property Comment() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CommentColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CommentColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CommentSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CommentColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CommentDefault() As String
        Get
            Return TableUtils.CommentColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_CARNo_QDetails_.CARID field.
	''' </summary>
	Public Property CARID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CARIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CARIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CARIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CARIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CARIDDefault() As String
        Get
            Return TableUtils.CARIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_CARNo_QDetails_.WCD_No field.
	''' </summary>
	Public Property WCD_No() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_NoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCD_NoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_NoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_NoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_NoDefault() As String
        Get
            Return TableUtils.WCD_NoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_CARNo_QDetails_.WCD_Remark field.
	''' </summary>
	Public Property WCD_Remark() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_RemarkColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCD_RemarkColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_RemarkSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_RemarkColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_RemarkDefault() As String
        Get
            Return TableUtils.WCD_RemarkColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_CARNo_QDetails_.WCD_Project_Title field.
	''' </summary>
	Public Property WCD_Project_Title() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Project_TitleColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCD_Project_TitleColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Project_TitleSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Project_TitleColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Project_TitleDefault() As String
        Get
            Return TableUtils.WCD_Project_TitleColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_CARNo_QDetails_.WCD_Exp_Total field.
	''' </summary>
	Public Property WCD_Exp_Total() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Exp_TotalColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_Exp_TotalColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Exp_TotalSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Exp_TotalColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Exp_TotalDefault() As String
        Get
            Return TableUtils.WCD_Exp_TotalColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_CARNo_QDetails_.WCD_ID field.
	''' </summary>
	Public Property WCD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_IDDefault() As String
        Get
            Return TableUtils.WCD_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
