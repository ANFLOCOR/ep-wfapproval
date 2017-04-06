' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRepCon_HistoryRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WFinRepCon_HistoryRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WFinRepCon_HistoryTable"></see> class.
''' </remarks>
''' <seealso cref="WFinRepCon_HistoryTable"></seealso>
''' <seealso cref="WFinRepCon_HistoryRecord"></seealso>

<Serializable()> Public Class BaseWFinRepCon_HistoryRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WFinRepCon_HistoryTable = WFinRepCon_HistoryTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WFinRepCon_HistoryRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WFinRepCon_HistoryRec As WFinRepCon_HistoryRecord = CType(sender,WFinRepCon_HistoryRecord)
        Validate_Inserting()
        If Not WFinRepCon_HistoryRec Is Nothing AndAlso Not WFinRepCon_HistoryRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WFinRepCon_HistoryRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WFinRepCon_HistoryRec As WFinRepCon_HistoryRecord = CType(sender,WFinRepCon_HistoryRecord)
        Validate_Updating()
        If Not WFinRepCon_HistoryRec Is Nothing AndAlso Not WFinRepCon_HistoryRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WFinRepCon_HistoryRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WFinRepCon_HistoryRec As WFinRepCon_HistoryRecord = CType(sender,WFinRepCon_HistoryRecord)
        If Not WFinRepCon_HistoryRec Is Nothing AndAlso Not WFinRepCon_HistoryRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_History_.WFRCHi_ID field.
	''' </summary>
	Public Function GetWFRCHi_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHi_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_History_.WFRCHi_ID field.
	''' </summary>
	Public Function GetWFRCHi_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCHi_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_History_.WFRCHi_WFRCH_ID field.
	''' </summary>
	Public Function GetWFRCHi_WFRCH_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHi_WFRCH_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_History_.WFRCHi_WFRCH_ID field.
	''' </summary>
	Public Function GetWFRCHi_WFRCH_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCHi_WFRCH_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_History_.WFRCHi_WFRCH_ID field.
	''' </summary>
	Public Sub SetWFRCHi_WFRCH_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCHi_WFRCH_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_History_.WFRCHi_WFRCH_ID field.
	''' </summary>
	Public Sub SetWFRCHi_WFRCH_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCHi_WFRCH_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_History_.WFRCHi_WFRCH_ID field.
	''' </summary>
	Public Sub SetWFRCHi_WFRCH_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHi_WFRCH_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_History_.WFRCHi_WFRCH_ID field.
	''' </summary>
	Public Sub SetWFRCHi_WFRCH_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHi_WFRCH_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_History_.WFRCHi_WFRCH_ID field.
	''' </summary>
	Public Sub SetWFRCHi_WFRCH_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHi_WFRCH_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_History_.WFRCHi_File field.
	''' </summary>
	Public Function GetWFRCHi_FileValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHi_FileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_History_.WFRCHi_File field.
	''' </summary>
	Public Function GetWFRCHi_FileFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.WFRCHi_FileColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_History_.WFRCHi_File field.
	''' </summary>
	Public Sub SetWFRCHi_FileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCHi_FileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_History_.WFRCHi_File field.
	''' </summary>
	Public Sub SetWFRCHi_FileFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCHi_FileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_History_.WFRCHi_File field.
	''' </summary>
	Public Sub SetWFRCHi_FileFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHi_FileColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_History_.WFRCHi_CreatedBy field.
	''' </summary>
	Public Function GetWFRCHi_CreatedByValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHi_CreatedByColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_History_.WFRCHi_CreatedBy field.
	''' </summary>
	Public Function GetWFRCHi_CreatedByFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRCHi_CreatedByColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_History_.WFRCHi_CreatedBy field.
	''' </summary>
	Public Sub SetWFRCHi_CreatedByFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCHi_CreatedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_History_.WFRCHi_CreatedBy field.
	''' </summary>
	Public Sub SetWFRCHi_CreatedByFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCHi_CreatedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_History_.WFRCHi_CreatedBy field.
	''' </summary>
	Public Sub SetWFRCHi_CreatedByFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHi_CreatedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_History_.WFRCHi_CreatedBy field.
	''' </summary>
	Public Sub SetWFRCHi_CreatedByFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHi_CreatedByColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_History_.WFRCHi_CreatedBy field.
	''' </summary>
	Public Sub SetWFRCHi_CreatedByFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHi_CreatedByColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_History_.WFRCHi_DateCreated field.
	''' </summary>
	Public Function GetWFRCHi_DateCreatedValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRCHi_DateCreatedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepCon_History_.WFRCHi_DateCreated field.
	''' </summary>
	Public Function GetWFRCHi_DateCreatedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WFRCHi_DateCreatedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_History_.WFRCHi_DateCreated field.
	''' </summary>
	Public Sub SetWFRCHi_DateCreatedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRCHi_DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_History_.WFRCHi_DateCreated field.
	''' </summary>
	Public Sub SetWFRCHi_DateCreatedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRCHi_DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepCon_History_.WFRCHi_DateCreated field.
	''' </summary>
	Public Sub SetWFRCHi_DateCreatedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRCHi_DateCreatedColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_History_.WFRCHi_ID field.
	''' </summary>
	Public Property WFRCHi_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHi_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCHi_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHi_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHi_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHi_IDDefault() As String
        Get
            Return TableUtils.WFRCHi_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_History_.WFRCHi_WFRCH_ID field.
	''' </summary>
	Public Property WFRCHi_WFRCH_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHi_WFRCH_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCHi_WFRCH_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHi_WFRCH_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHi_WFRCH_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHi_WFRCH_IDDefault() As String
        Get
            Return TableUtils.WFRCHi_WFRCH_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_History_.WFRCHi_File field.
	''' </summary>
	Public Property WFRCHi_File() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHi_FileColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCHi_FileColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHi_FileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHi_FileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHi_FileDefault() As String
        Get
            Return TableUtils.WFRCHi_FileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_History_.WFRCHi_CreatedBy field.
	''' </summary>
	Public Property WFRCHi_CreatedBy() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHi_CreatedByColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCHi_CreatedByColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHi_CreatedBySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHi_CreatedByColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHi_CreatedByDefault() As String
        Get
            Return TableUtils.WFRCHi_CreatedByColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepCon_History_.WFRCHi_DateCreated field.
	''' </summary>
	Public Property WFRCHi_DateCreated() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WFRCHi_DateCreatedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRCHi_DateCreatedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRCHi_DateCreatedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRCHi_DateCreatedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRCHi_DateCreatedDefault() As String
        Get
            Return TableUtils.WFRCHi_DateCreatedColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
