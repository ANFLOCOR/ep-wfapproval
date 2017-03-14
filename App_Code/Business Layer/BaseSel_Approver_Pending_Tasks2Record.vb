' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_Approver_Pending_Tasks2Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_Approver_Pending_Tasks2Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_Approver_Pending_Tasks2View"></see> class.
''' </remarks>
''' <seealso cref="Sel_Approver_Pending_Tasks2View"></seealso>
''' <seealso cref="Sel_Approver_Pending_Tasks2Record"></seealso>

<Serializable()> Public Class BaseSel_Approver_Pending_Tasks2Record
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_Approver_Pending_Tasks2View = Sel_Approver_Pending_Tasks2View.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_Approver_Pending_Tasks2Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_Approver_Pending_Tasks2Rec As Sel_Approver_Pending_Tasks2Record = CType(sender,Sel_Approver_Pending_Tasks2Record)
        If Not Sel_Approver_Pending_Tasks2Rec Is Nothing AndAlso Not Sel_Approver_Pending_Tasks2Rec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_Approver_Pending_Tasks2Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_Approver_Pending_Tasks2Rec As Sel_Approver_Pending_Tasks2Record = CType(sender,Sel_Approver_Pending_Tasks2Record)
        Validate_Inserting()
        If Not Sel_Approver_Pending_Tasks2Rec Is Nothing AndAlso Not Sel_Approver_Pending_Tasks2Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.Doc_Type field.
	''' </summary>
	Public Function GetDoc_TypeValue() As ColumnValue
		Return Me.GetValue(TableUtils.Doc_TypeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.Doc_Type field.
	''' </summary>
	Public Function GetDoc_TypeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.Doc_TypeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.Doc_Type field.
	''' </summary>
	Public Sub SetDoc_TypeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Doc_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.Doc_Type field.
	''' </summary>
	Public Sub SetDoc_TypeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Doc_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.Company_Desc field.
	''' </summary>
	Public Function GetCompany_DescValue() As ColumnValue
		Return Me.GetValue(TableUtils.Company_DescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.Company_Desc field.
	''' </summary>
	Public Function GetCompany_DescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.Company_DescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.Company_Desc field.
	''' </summary>
	Public Sub SetCompany_DescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Company_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.Company_Desc field.
	''' </summary>
	Public Sub SetCompany_DescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.Doc_No field.
	''' </summary>
	Public Function GetDoc_NoValue() As ColumnValue
		Return Me.GetValue(TableUtils.Doc_NoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.Doc_No field.
	''' </summary>
	Public Function GetDoc_NoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.Doc_NoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.Doc_No field.
	''' </summary>
	Public Sub SetDoc_NoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Doc_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.Doc_No field.
	''' </summary>
	Public Sub SetDoc_NoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Doc_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.Date_Assigned field.
	''' </summary>
	Public Function GetDate_AssignedValue() As ColumnValue
		Return Me.GetValue(TableUtils.Date_AssignedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.Date_Assigned field.
	''' </summary>
	Public Function GetDate_AssignedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.Date_AssignedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.Date_Assigned field.
	''' </summary>
	Public Sub SetDate_AssignedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Date_AssignedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.Date_Assigned field.
	''' </summary>
	Public Sub SetDate_AssignedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Date_AssignedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.Date_Assigned field.
	''' </summary>
	Public Sub SetDate_AssignedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Date_AssignedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.W_U_ID field.
	''' </summary>
	Public Function GetW_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.W_U_ID field.
	''' </summary>
	Public Function GetW_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.W_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.W_U_ID field.
	''' </summary>
	Public Sub SetW_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.W_U_ID field.
	''' </summary>
	Public Sub SetW_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.W_U_ID field.
	''' </summary>
	Public Sub SetW_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.W_U_ID field.
	''' </summary>
	Public Sub SetW_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.W_U_ID field.
	''' </summary>
	Public Sub SetW_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.PK_ID field.
	''' </summary>
	Public Function GetPK_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PK_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.PK_ID field.
	''' </summary>
	Public Function GetPK_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PK_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.PK_ID field.
	''' </summary>
	Public Sub SetPK_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PK_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.PK_ID field.
	''' </summary>
	Public Sub SetPK_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.PK_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.PK_ID field.
	''' </summary>
	Public Sub SetPK_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PK_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.PK_ID field.
	''' </summary>
	Public Sub SetPK_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PK_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.PK_ID field.
	''' </summary>
	Public Sub SetPK_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PK_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.C_ID field.
	''' </summary>
	Public Function GetC_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.C_ID field.
	''' </summary>
	Public Function GetC_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.C_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.C_ID field.
	''' </summary>
	Public Sub SetC_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.C_ID field.
	''' </summary>
	Public Sub SetC_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.C_ID field.
	''' </summary>
	Public Sub SetC_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.C_ID field.
	''' </summary>
	Public Sub SetC_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.C_ID field.
	''' </summary>
	Public Sub SetC_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.Doc_Title field.
	''' </summary>
	Public Function GetDoc_TitleValue() As ColumnValue
		Return Me.GetValue(TableUtils.Doc_TitleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.Doc_Title field.
	''' </summary>
	Public Function GetDoc_TitleFieldValue() As String
		Return CType(Me.GetValue(TableUtils.Doc_TitleColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.Doc_Title field.
	''' </summary>
	Public Sub SetDoc_TitleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Doc_TitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.Doc_Title field.
	''' </summary>
	Public Sub SetDoc_TitleFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Doc_TitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.Doc_Total field.
	''' </summary>
	Public Function GetDoc_TotalValue() As ColumnValue
		Return Me.GetValue(TableUtils.Doc_TotalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.Doc_Total field.
	''' </summary>
	Public Function GetDoc_TotalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.Doc_TotalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.Doc_Total field.
	''' </summary>
	Public Sub SetDoc_TotalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Doc_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.Doc_Total field.
	''' </summary>
	Public Sub SetDoc_TotalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Doc_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.Doc_Total field.
	''' </summary>
	Public Sub SetDoc_TotalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Doc_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.Doc_Total field.
	''' </summary>
	Public Sub SetDoc_TotalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Doc_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.Doc_Total field.
	''' </summary>
	Public Sub SetDoc_TotalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Doc_TotalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.SSC_CompanyID field.
	''' </summary>
	Public Function GetSSC_CompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSC_CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.SSC_CompanyID field.
	''' </summary>
	Public Function GetSSC_CompanyIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.SSC_CompanyIDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSC_CompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSC_CompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSC_CompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSC_CompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSC_CompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSC_CompanyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.SortOrder field.
	''' </summary>
	Public Function GetSortOrderValue() As ColumnValue
		Return Me.GetValue(TableUtils.SortOrderColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.SortOrder field.
	''' </summary>
	Public Function GetSortOrderFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SortOrderColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.SortOrder field.
	''' </summary>
	Public Sub SetSortOrderFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SortOrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.SortOrder field.
	''' </summary>
	Public Sub SetSortOrderFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SortOrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.SortOrder field.
	''' </summary>
	Public Sub SetSortOrderFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SortOrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.SortOrder field.
	''' </summary>
	Public Sub SetSortOrderFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SortOrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_Approver_Pending_Tasks_.SortOrder field.
	''' </summary>
	Public Sub SetSortOrderFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SortOrderColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.Doc_Type field.
	''' </summary>
	Public Property Doc_Type() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Doc_TypeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Doc_TypeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Doc_TypeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Doc_TypeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Doc_TypeDefault() As String
        Get
            Return TableUtils.Doc_TypeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.Company_Desc field.
	''' </summary>
	Public Property Company_Desc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Company_DescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Company_DescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Company_DescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Company_DescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Company_DescDefault() As String
        Get
            Return TableUtils.Company_DescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.Doc_No field.
	''' </summary>
	Public Property Doc_No() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Doc_NoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Doc_NoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Doc_NoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Doc_NoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Doc_NoDefault() As String
        Get
            Return TableUtils.Doc_NoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.Date_Assigned field.
	''' </summary>
	Public Property Date_Assigned() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.Date_AssignedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Date_AssignedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Date_AssignedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Date_AssignedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Date_AssignedDefault() As String
        Get
            Return TableUtils.Date_AssignedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.W_U_ID field.
	''' </summary>
	Public Property W_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.W_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.W_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_U_IDDefault() As String
        Get
            Return TableUtils.W_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.PK_ID field.
	''' </summary>
	Public Property PK_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PK_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PK_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PK_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PK_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PK_IDDefault() As String
        Get
            Return TableUtils.PK_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.C_ID field.
	''' </summary>
	Public Property C_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.C_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property C_IDDefault() As String
        Get
            Return TableUtils.C_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.Doc_Title field.
	''' </summary>
	Public Property Doc_Title() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Doc_TitleColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Doc_TitleColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Doc_TitleSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Doc_TitleColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Doc_TitleDefault() As String
        Get
            Return TableUtils.Doc_TitleColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.Doc_Total field.
	''' </summary>
	Public Property Doc_Total() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.Doc_TotalColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Doc_TotalColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Doc_TotalSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Doc_TotalColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Doc_TotalDefault() As String
        Get
            Return TableUtils.Doc_TotalColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.SSC_CompanyID field.
	''' </summary>
	Public Property SSC_CompanyID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.SSC_CompanyIDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSC_CompanyIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSC_CompanyIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSC_CompanyIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSC_CompanyIDDefault() As String
        Get
            Return TableUtils.SSC_CompanyIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_Approver_Pending_Tasks_.SortOrder field.
	''' </summary>
	Public Property SortOrder() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SortOrderColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SortOrderColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SortOrderSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SortOrderColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SortOrderDefault() As String
        Get
            Return TableUtils.SortOrderColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
