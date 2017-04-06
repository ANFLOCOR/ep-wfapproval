' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_FIN_ReportListRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_FIN_ReportListRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_FIN_ReportListView"></see> class.
''' </remarks>
''' <seealso cref="Sel_FIN_ReportListView"></seealso>
''' <seealso cref="Sel_FIN_ReportListRecord"></seealso>

<Serializable()> Public Class BaseSel_FIN_ReportListRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_FIN_ReportListView = Sel_FIN_ReportListView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_FIN_ReportListRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_FIN_ReportListRec As Sel_FIN_ReportListRecord = CType(sender,Sel_FIN_ReportListRecord)
        If Not Sel_FIN_ReportListRec Is Nothing AndAlso Not Sel_FIN_ReportListRec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_FIN_ReportListRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_FIN_ReportListRec As Sel_FIN_ReportListRecord = CType(sender,Sel_FIN_ReportListRecord)
        Validate_Inserting()
        If Not Sel_FIN_ReportListRec Is Nothing AndAlso Not Sel_FIN_ReportListRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's sel_FIN_ReportList_.W_Rpt_ID field.
	''' </summary>
	Public Function GetW_Rpt_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_Rpt_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_FIN_ReportList_.W_Rpt_ID field.
	''' </summary>
	Public Function GetW_Rpt_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.W_Rpt_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.W_Rpt_ID field.
	''' </summary>
	Public Sub SetW_Rpt_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_Rpt_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.W_Rpt_ID field.
	''' </summary>
	Public Sub SetW_Rpt_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.W_Rpt_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.W_Rpt_ID field.
	''' </summary>
	Public Sub SetW_Rpt_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_Rpt_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.W_Rpt_ID field.
	''' </summary>
	Public Sub SetW_Rpt_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_Rpt_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.W_Rpt_ID field.
	''' </summary>
	Public Sub SetW_Rpt_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_Rpt_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_FIN_ReportList_.W_Rpt_Desc field.
	''' </summary>
	Public Function GetW_Rpt_DescValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_Rpt_DescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_FIN_ReportList_.W_Rpt_Desc field.
	''' </summary>
	Public Function GetW_Rpt_DescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.W_Rpt_DescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.W_Rpt_Desc field.
	''' </summary>
	Public Sub SetW_Rpt_DescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_Rpt_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.W_Rpt_Desc field.
	''' </summary>
	Public Sub SetW_Rpt_DescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_Rpt_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_FIN_ReportList_.W_Rpt_Server_Path field.
	''' </summary>
	Public Function GetW_Rpt_Server_PathValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_Rpt_Server_PathColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_FIN_ReportList_.W_Rpt_Server_Path field.
	''' </summary>
	Public Function GetW_Rpt_Server_PathFieldValue() As String
		Return CType(Me.GetValue(TableUtils.W_Rpt_Server_PathColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.W_Rpt_Server_Path field.
	''' </summary>
	Public Sub SetW_Rpt_Server_PathFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_Rpt_Server_PathColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.W_Rpt_Server_Path field.
	''' </summary>
	Public Sub SetW_Rpt_Server_PathFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_Rpt_Server_PathColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_FIN_ReportList_.Company field.
	''' </summary>
	Public Function GetCompanyValue() As ColumnValue
		Return Me.GetValue(TableUtils.CompanyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_FIN_ReportList_.Company field.
	''' </summary>
	Public Function GetCompanyFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CompanyColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.Company field.
	''' </summary>
	Public Sub SetCompanyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CompanyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.Company field.
	''' </summary>
	Public Sub SetCompanyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CompanyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.Company field.
	''' </summary>
	Public Sub SetCompanyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.Company field.
	''' </summary>
	Public Sub SetCompanyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.Company field.
	''' </summary>
	Public Sub SetCompanyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_FIN_ReportList_.W_Rpt_ShortName field.
	''' </summary>
	Public Function GetW_Rpt_ShortNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_Rpt_ShortNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_FIN_ReportList_.W_Rpt_ShortName field.
	''' </summary>
	Public Function GetW_Rpt_ShortNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.W_Rpt_ShortNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.W_Rpt_ShortName field.
	''' </summary>
	Public Sub SetW_Rpt_ShortNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_Rpt_ShortNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.W_Rpt_ShortName field.
	''' </summary>
	Public Sub SetW_Rpt_ShortNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_Rpt_ShortNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_FIN_ReportList_.W_Rpt_SortOrder field.
	''' </summary>
	Public Function GetW_Rpt_SortOrderValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_Rpt_SortOrderColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_FIN_ReportList_.W_Rpt_SortOrder field.
	''' </summary>
	Public Function GetW_Rpt_SortOrderFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.W_Rpt_SortOrderColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.W_Rpt_SortOrder field.
	''' </summary>
	Public Sub SetW_Rpt_SortOrderFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_Rpt_SortOrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.W_Rpt_SortOrder field.
	''' </summary>
	Public Sub SetW_Rpt_SortOrderFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.W_Rpt_SortOrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.W_Rpt_SortOrder field.
	''' </summary>
	Public Sub SetW_Rpt_SortOrderFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_Rpt_SortOrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.W_Rpt_SortOrder field.
	''' </summary>
	Public Sub SetW_Rpt_SortOrderFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_Rpt_SortOrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_FIN_ReportList_.W_Rpt_SortOrder field.
	''' </summary>
	Public Sub SetW_Rpt_SortOrderFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_Rpt_SortOrderColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_FIN_ReportList_.W_Rpt_ID field.
	''' </summary>
	Public Property W_Rpt_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.W_Rpt_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.W_Rpt_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_Rpt_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_Rpt_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_Rpt_IDDefault() As String
        Get
            Return TableUtils.W_Rpt_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_FIN_ReportList_.W_Rpt_Desc field.
	''' </summary>
	Public Property W_Rpt_Desc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.W_Rpt_DescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.W_Rpt_DescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_Rpt_DescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_Rpt_DescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_Rpt_DescDefault() As String
        Get
            Return TableUtils.W_Rpt_DescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_FIN_ReportList_.W_Rpt_Server_Path field.
	''' </summary>
	Public Property W_Rpt_Server_Path() As String
		Get 
			Return CType(Me.GetValue(TableUtils.W_Rpt_Server_PathColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.W_Rpt_Server_PathColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_Rpt_Server_PathSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_Rpt_Server_PathColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_Rpt_Server_PathDefault() As String
        Get
            Return TableUtils.W_Rpt_Server_PathColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_FIN_ReportList_.Company field.
	''' </summary>
	Public Property Company() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CompanyColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CompanyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CompanySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CompanyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CompanyDefault() As String
        Get
            Return TableUtils.CompanyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_FIN_ReportList_.W_Rpt_ShortName field.
	''' </summary>
	Public Property W_Rpt_ShortName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.W_Rpt_ShortNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.W_Rpt_ShortNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_Rpt_ShortNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_Rpt_ShortNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_Rpt_ShortNameDefault() As String
        Get
            Return TableUtils.W_Rpt_ShortNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_FIN_ReportList_.W_Rpt_SortOrder field.
	''' </summary>
	Public Property W_Rpt_SortOrder() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.W_Rpt_SortOrderColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.W_Rpt_SortOrderColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_Rpt_SortOrderSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_Rpt_SortOrderColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_Rpt_SortOrderDefault() As String
        Get
            Return TableUtils.W_Rpt_SortOrderColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
