' This class is "generated" and will be overwritten.
' Your customizations should be made in Vw_FS_WFinRep_Attachment_PerReportType1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Vw_FS_WFinRep_Attachment_PerReportType1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Vw_FS_WFinRep_Attachment_PerReportType1View"></see> class.
''' </remarks>
''' <seealso cref="Vw_FS_WFinRep_Attachment_PerReportType1View"></seealso>
''' <seealso cref="Vw_FS_WFinRep_Attachment_PerReportType1Record"></seealso>

<Serializable()> Public Class BaseVw_FS_WFinRep_Attachment_PerReportType1Record
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As Vw_FS_WFinRep_Attachment_PerReportType1View = Vw_FS_WFinRep_Attachment_PerReportType1View.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Vw_FS_WFinRep_Attachment_PerReportType1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Vw_FS_WFinRep_Attachment_PerReportType1Rec As Vw_FS_WFinRep_Attachment_PerReportType1Record = CType(sender,Vw_FS_WFinRep_Attachment_PerReportType1Record)
        If Not Vw_FS_WFinRep_Attachment_PerReportType1Rec Is Nothing AndAlso Not Vw_FS_WFinRep_Attachment_PerReportType1Rec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Vw_FS_WFinRep_Attachment_PerReportType1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Vw_FS_WFinRep_Attachment_PerReportType1Rec As Vw_FS_WFinRep_Attachment_PerReportType1Record = CType(sender,Vw_FS_WFinRep_Attachment_PerReportType1Record)
        Validate_Inserting()
        If Not Vw_FS_WFinRep_Attachment_PerReportType1Rec Is Nothing AndAlso Not Vw_FS_WFinRep_Attachment_PerReportType1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_ID field.
	''' </summary>
	Public Function GetWFRA_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRA_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_ID field.
	''' </summary>
	Public Function GetWFRA_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRA_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_ID field.
	''' </summary>
	Public Sub SetWFRA_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRA_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_ID field.
	''' </summary>
	Public Sub SetWFRA_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRA_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_ID field.
	''' </summary>
	Public Sub SetWFRA_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRA_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_ID field.
	''' </summary>
	Public Sub SetWFRA_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRA_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_ID field.
	''' </summary>
	Public Sub SetWFRA_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRA_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_FIN_ID field.
	''' </summary>
	Public Function GetWFRA_FIN_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRA_FIN_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_FIN_ID field.
	''' </summary>
	Public Function GetWFRA_FIN_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRA_FIN_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_FIN_ID field.
	''' </summary>
	Public Sub SetWFRA_FIN_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRA_FIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_FIN_ID field.
	''' </summary>
	Public Sub SetWFRA_FIN_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRA_FIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_FIN_ID field.
	''' </summary>
	Public Sub SetWFRA_FIN_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRA_FIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_FIN_ID field.
	''' </summary>
	Public Sub SetWFRA_FIN_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRA_FIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_FIN_ID field.
	''' </summary>
	Public Sub SetWFRA_FIN_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRA_FIN_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_Desc field.
	''' </summary>
	Public Function GetWFRA_DescValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRA_DescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_Desc field.
	''' </summary>
	Public Function GetWFRA_DescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRA_DescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_Desc field.
	''' </summary>
	Public Sub SetWFRA_DescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRA_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_Desc field.
	''' </summary>
	Public Sub SetWFRA_DescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRA_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_Doc field.
	''' </summary>
	Public Function GetWFRA_DocValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRA_DocColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_Doc field.
	''' </summary>
	Public Function GetWFRA_DocFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.WFRA_DocColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_Doc field.
	''' </summary>
	Public Sub SetWFRA_DocFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRA_DocColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_Doc field.
	''' </summary>
	Public Sub SetWFRA_DocFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRA_DocColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_Doc field.
	''' </summary>
	Public Sub SetWFRA_DocFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRA_DocColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRT_Description field.
	''' </summary>
	Public Function GetWFRT_DescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRT_DescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRT_Description field.
	''' </summary>
	Public Function GetWFRT_DescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRT_DescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRT_Description field.
	''' </summary>
	Public Sub SetWFRT_DescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRT_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRT_Description field.
	''' </summary>
	Public Sub SetWFRT_DescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRT_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRT_SortOrder field.
	''' </summary>
	Public Function GetWFRT_SortOrderValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRT_SortOrderColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRT_SortOrder field.
	''' </summary>
	Public Function GetWFRT_SortOrderFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRT_SortOrderColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRT_SortOrder field.
	''' </summary>
	Public Sub SetWFRT_SortOrderFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRT_SortOrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRT_SortOrder field.
	''' </summary>
	Public Sub SetWFRT_SortOrderFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRT_SortOrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRT_SortOrder field.
	''' </summary>
	Public Sub SetWFRT_SortOrderFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRT_SortOrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRT_SortOrder field.
	''' </summary>
	Public Sub SetWFRT_SortOrderFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRT_SortOrderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRT_SortOrder field.
	''' </summary>
	Public Sub SetWFRT_SortOrderFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRT_SortOrderColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.FIN_HFIN_ID field.
	''' </summary>
	Public Function GetFIN_HFIN_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.FIN_HFIN_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.FIN_HFIN_ID field.
	''' </summary>
	Public Function GetFIN_HFIN_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.FIN_HFIN_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.FIN_HFIN_ID field.
	''' </summary>
	Public Sub SetFIN_HFIN_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FIN_HFIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.FIN_HFIN_ID field.
	''' </summary>
	Public Sub SetFIN_HFIN_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.FIN_HFIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.FIN_HFIN_ID field.
	''' </summary>
	Public Sub SetFIN_HFIN_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_HFIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.FIN_HFIN_ID field.
	''' </summary>
	Public Sub SetFIN_HFIN_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_HFIN_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.FIN_HFIN_ID field.
	''' </summary>
	Public Sub SetFIN_HFIN_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FIN_HFIN_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_Doc_X field.
	''' </summary>
	Public Function GetWFRA_Doc_XValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRA_Doc_XColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_Doc_X field.
	''' </summary>
	Public Function GetWFRA_Doc_XFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.WFRA_Doc_XColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_Doc_X field.
	''' </summary>
	Public Sub SetWFRA_Doc_XFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRA_Doc_XColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_Doc_X field.
	''' </summary>
	Public Sub SetWFRA_Doc_XFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRA_Doc_XColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_Doc_X field.
	''' </summary>
	Public Sub SetWFRA_Doc_XFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRA_Doc_XColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_ID field.
	''' </summary>
	Public Property WFRA_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRA_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRA_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRA_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRA_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRA_IDDefault() As String
        Get
            Return TableUtils.WFRA_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_FIN_ID field.
	''' </summary>
	Public Property WFRA_FIN_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRA_FIN_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRA_FIN_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRA_FIN_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRA_FIN_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRA_FIN_IDDefault() As String
        Get
            Return TableUtils.WFRA_FIN_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_Desc field.
	''' </summary>
	Public Property WFRA_Desc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WFRA_DescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WFRA_DescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRA_DescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRA_DescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRA_DescDefault() As String
        Get
            Return TableUtils.WFRA_DescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_Doc field.
	''' </summary>
	Public Property WFRA_Doc() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.WFRA_DocColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRA_DocColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRA_DocSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRA_DocColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRA_DocDefault() As String
        Get
            Return TableUtils.WFRA_DocColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRT_Description field.
	''' </summary>
	Public Property WFRT_Description() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WFRT_DescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WFRT_DescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRT_DescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRT_DescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRT_DescriptionDefault() As String
        Get
            Return TableUtils.WFRT_DescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRT_SortOrder field.
	''' </summary>
	Public Property WFRT_SortOrder() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRT_SortOrderColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRT_SortOrderColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRT_SortOrderSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRT_SortOrderColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRT_SortOrderDefault() As String
        Get
            Return TableUtils.WFRT_SortOrderColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.FIN_HFIN_ID field.
	''' </summary>
	Public Property FIN_HFIN_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.FIN_HFIN_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.FIN_HFIN_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FIN_HFIN_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FIN_HFIN_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FIN_HFIN_IDDefault() As String
        Get
            Return TableUtils.FIN_HFIN_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's vw_FS_WFinRep_Attachment_PerReportType_.WFRA_Doc_X field.
	''' </summary>
	Public Property WFRA_Doc_X() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.WFRA_Doc_XColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRA_Doc_XColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRA_Doc_XSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRA_Doc_XColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRA_Doc_XDefault() As String
        Get
            Return TableUtils.WFRA_Doc_XColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
