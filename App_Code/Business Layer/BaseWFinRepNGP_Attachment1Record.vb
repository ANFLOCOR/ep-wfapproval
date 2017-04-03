' This class is "generated" and will be overwritten.
' Your customizations should be made in WFinRepNGP_Attachment1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WFinRepNGP_Attachment1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WFinRepNGP_Attachment1Table"></see> class.
''' </remarks>
''' <seealso cref="WFinRepNGP_Attachment1Table"></seealso>
''' <seealso cref="WFinRepNGP_Attachment1Record"></seealso>

<Serializable()> Public Class BaseWFinRepNGP_Attachment1Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WFinRepNGP_Attachment1Table = WFinRepNGP_Attachment1Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WFinRepNGP_Attachment1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WFinRepNGP_Attachment1Rec As WFinRepNGP_Attachment1Record = CType(sender,WFinRepNGP_Attachment1Record)
        Validate_Inserting()
        If Not WFinRepNGP_Attachment1Rec Is Nothing AndAlso Not WFinRepNGP_Attachment1Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WFinRepNGP_Attachment1Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WFinRepNGP_Attachment1Rec As WFinRepNGP_Attachment1Record = CType(sender,WFinRepNGP_Attachment1Record)
        Validate_Updating()
        If Not WFinRepNGP_Attachment1Rec Is Nothing AndAlso Not WFinRepNGP_Attachment1Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WFinRepNGP_Attachment1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WFinRepNGP_Attachment1Rec As WFinRepNGP_Attachment1Record = CType(sender,WFinRepNGP_Attachment1Record)
        If Not WFinRepNGP_Attachment1Rec Is Nothing AndAlso Not WFinRepNGP_Attachment1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_ID field.
	''' </summary>
	Public Function GetWFRNGPAt_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPAt_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_ID field.
	''' </summary>
	Public Function GetWFRNGPAt_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRNGPAt_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_WFRCHNGP_ID field.
	''' </summary>
	Public Function GetWFRNGPAt_WFRCHNGP_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPAt_WFRCHNGP_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_WFRCHNGP_ID field.
	''' </summary>
	Public Function GetWFRNGPAt_WFRCHNGP_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WFRNGPAt_WFRCHNGP_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRNGPAt_WFRCHNGP_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPAt_WFRCHNGP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRNGPAt_WFRCHNGP_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPAt_WFRCHNGP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRNGPAt_WFRCHNGP_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPAt_WFRCHNGP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRNGPAt_WFRCHNGP_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPAt_WFRCHNGP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_WFRCHNGP_ID field.
	''' </summary>
	Public Sub SetWFRNGPAt_WFRCHNGP_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPAt_WFRCHNGP_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_Desc field.
	''' </summary>
	Public Function GetWFRNGPAt_DescValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPAt_DescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_Desc field.
	''' </summary>
	Public Function GetWFRNGPAt_DescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WFRNGPAt_DescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_Desc field.
	''' </summary>
	Public Sub SetWFRNGPAt_DescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPAt_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_Desc field.
	''' </summary>
	Public Sub SetWFRNGPAt_DescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPAt_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_Doc field.
	''' </summary>
	Public Function GetWFRNGPAt_DocValue() As ColumnValue
		Return Me.GetValue(TableUtils.WFRNGPAt_DocColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_Doc field.
	''' </summary>
	Public Function GetWFRNGPAt_DocFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.WFRNGPAt_DocColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_Doc field.
	''' </summary>
	Public Sub SetWFRNGPAt_DocFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WFRNGPAt_DocColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_Doc field.
	''' </summary>
	Public Sub SetWFRNGPAt_DocFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WFRNGPAt_DocColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_Doc field.
	''' </summary>
	Public Sub SetWFRNGPAt_DocFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WFRNGPAt_DocColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_ID field.
	''' </summary>
	Public Property WFRNGPAt_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRNGPAt_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRNGPAt_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRNGPAt_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRNGPAt_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRNGPAt_IDDefault() As String
        Get
            Return TableUtils.WFRNGPAt_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_WFRCHNGP_ID field.
	''' </summary>
	Public Property WFRNGPAt_WFRCHNGP_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WFRNGPAt_WFRCHNGP_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRNGPAt_WFRCHNGP_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRNGPAt_WFRCHNGP_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRNGPAt_WFRCHNGP_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRNGPAt_WFRCHNGP_IDDefault() As String
        Get
            Return TableUtils.WFRNGPAt_WFRCHNGP_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_Desc field.
	''' </summary>
	Public Property WFRNGPAt_Desc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WFRNGPAt_DescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WFRNGPAt_DescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRNGPAt_DescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRNGPAt_DescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRNGPAt_DescDefault() As String
        Get
            Return TableUtils.WFRNGPAt_DescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WFinRepNGP_Attachment_.WFRNGPAt_Doc field.
	''' </summary>
	Public Property WFRNGPAt_Doc() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.WFRNGPAt_DocColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WFRNGPAt_DocColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WFRNGPAt_DocSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WFRNGPAt_DocColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WFRNGPAt_DocDefault() As String
        Get
            Return TableUtils.WFRNGPAt_DocColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
