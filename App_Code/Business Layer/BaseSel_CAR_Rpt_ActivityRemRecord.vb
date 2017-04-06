' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_CAR_Rpt_ActivityRemRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_CAR_Rpt_ActivityRemRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_CAR_Rpt_ActivityRemView"></see> class.
''' </remarks>
''' <seealso cref="Sel_CAR_Rpt_ActivityRemView"></seealso>
''' <seealso cref="Sel_CAR_Rpt_ActivityRemRecord"></seealso>

<Serializable()> Public Class BaseSel_CAR_Rpt_ActivityRemRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_CAR_Rpt_ActivityRemView = Sel_CAR_Rpt_ActivityRemView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_CAR_Rpt_ActivityRemRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_CAR_Rpt_ActivityRemRec As Sel_CAR_Rpt_ActivityRemRecord = CType(sender,Sel_CAR_Rpt_ActivityRemRecord)
        Validate_Inserting()
        If Not Sel_CAR_Rpt_ActivityRemRec Is Nothing AndAlso Not Sel_CAR_Rpt_ActivityRemRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub Sel_CAR_Rpt_ActivityRemRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim Sel_CAR_Rpt_ActivityRemRec As Sel_CAR_Rpt_ActivityRemRecord = CType(sender,Sel_CAR_Rpt_ActivityRemRecord)
        Validate_Updating()
        If Not Sel_CAR_Rpt_ActivityRemRec Is Nothing AndAlso Not Sel_CAR_Rpt_ActivityRemRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_CAR_Rpt_ActivityRemRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_CAR_Rpt_ActivityRemRec As Sel_CAR_Rpt_ActivityRemRecord = CType(sender,Sel_CAR_Rpt_ActivityRemRecord)
        If Not Sel_CAR_Rpt_ActivityRemRec Is Nothing AndAlso Not Sel_CAR_Rpt_ActivityRemRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's sel_CAR_Rpt_ActivityRem_.WCD_No field.
	''' </summary>
	Public Function GetWCD_NoValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_NoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_CAR_Rpt_ActivityRem_.WCD_No field.
	''' </summary>
	Public Function GetWCD_NoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCD_NoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_CAR_Rpt_ActivityRem_.WCD_No field.
	''' </summary>
	Public Sub SetWCD_NoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_CAR_Rpt_ActivityRem_.WCD_No field.
	''' </summary>
	Public Sub SetWCD_NoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_CAR_Rpt_ActivityRem_.WCD_C_ID field.
	''' </summary>
	Public Function GetWCD_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_CAR_Rpt_ActivityRem_.WCD_C_ID field.
	''' </summary>
	Public Function GetWCD_C_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCD_C_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_CAR_Rpt_ActivityRem_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_CAR_Rpt_ActivityRem_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_CAR_Rpt_ActivityRem_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_CAR_Rpt_ActivityRem_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_CAR_Rpt_ActivityRem_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_CAR_Rpt_ActivityRem_.WCA_Remark field.
	''' </summary>
	Public Function GetWCA_RemarkValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCA_RemarkColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_CAR_Rpt_ActivityRem_.WCA_Remark field.
	''' </summary>
	Public Function GetWCA_RemarkFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCA_RemarkColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_CAR_Rpt_ActivityRem_.WCA_Remark field.
	''' </summary>
	Public Sub SetWCA_RemarkFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCA_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_CAR_Rpt_ActivityRem_.WCA_Remark field.
	''' </summary>
	Public Sub SetWCA_RemarkFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_CAR_Rpt_ActivityRem_.WCA_ID field.
	''' </summary>
	Public Function GetWCA_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCA_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_CAR_Rpt_ActivityRem_.WCA_ID field.
	''' </summary>
	Public Function GetWCA_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCA_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_CAR_Rpt_ActivityRem_.WCA_ID field.
	''' </summary>
	Public Sub SetWCA_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCA_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_CAR_Rpt_ActivityRem_.WCA_ID field.
	''' </summary>
	Public Sub SetWCA_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCA_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_CAR_Rpt_ActivityRem_.WCA_ID field.
	''' </summary>
	Public Sub SetWCA_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_CAR_Rpt_ActivityRem_.WCA_ID field.
	''' </summary>
	Public Sub SetWCA_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_CAR_Rpt_ActivityRem_.WCA_ID field.
	''' </summary>
	Public Sub SetWCA_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_CAR_Rpt_ActivityRem_.WCA_Status field.
	''' </summary>
	Public Function GetWCA_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCA_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_CAR_Rpt_ActivityRem_.WCA_Status field.
	''' </summary>
	Public Function GetWCA_StatusFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCA_StatusColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_CAR_Rpt_ActivityRem_.WCA_Status field.
	''' </summary>
	Public Sub SetWCA_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCA_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_CAR_Rpt_ActivityRem_.WCA_Status field.
	''' </summary>
	Public Sub SetWCA_StatusFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_StatusColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_CAR_Rpt_ActivityRem_.WCD_No field.
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
	''' This is a convenience property that provides direct access to the value of the record's sel_CAR_Rpt_ActivityRem_.WCD_C_ID field.
	''' </summary>
	Public Property WCD_C_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_C_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_C_IDDefault() As String
        Get
            Return TableUtils.WCD_C_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_CAR_Rpt_ActivityRem_.WCA_Remark field.
	''' </summary>
	Public Property WCA_Remark() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCA_RemarkColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCA_RemarkColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCA_RemarkSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCA_RemarkColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCA_RemarkDefault() As String
        Get
            Return TableUtils.WCA_RemarkColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_CAR_Rpt_ActivityRem_.WCA_ID field.
	''' </summary>
	Public Property WCA_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCA_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCA_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCA_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCA_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCA_IDDefault() As String
        Get
            Return TableUtils.WCA_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_CAR_Rpt_ActivityRem_.WCA_Status field.
	''' </summary>
	Public Property WCA_Status() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCA_StatusColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCA_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCA_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCA_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCA_StatusDefault() As String
        Get
            Return TableUtils.WCA_StatusColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
