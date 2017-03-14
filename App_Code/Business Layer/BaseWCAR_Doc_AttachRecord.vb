' This class is "generated" and will be overwritten.
' Your customizations should be made in WCAR_Doc_AttachRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WCAR_Doc_AttachRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WCAR_Doc_AttachTable"></see> class.
''' </remarks>
''' <seealso cref="WCAR_Doc_AttachTable"></seealso>
''' <seealso cref="WCAR_Doc_AttachRecord"></seealso>

<Serializable()> Public Class BaseWCAR_Doc_AttachRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WCAR_Doc_AttachTable = WCAR_Doc_AttachTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WCAR_Doc_AttachRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WCAR_Doc_AttachRec As WCAR_Doc_AttachRecord = CType(sender,WCAR_Doc_AttachRecord)
        Validate_Inserting()
        If Not WCAR_Doc_AttachRec Is Nothing AndAlso Not WCAR_Doc_AttachRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WCAR_Doc_AttachRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WCAR_Doc_AttachRec As WCAR_Doc_AttachRecord = CType(sender,WCAR_Doc_AttachRecord)
        Validate_Updating()
        If Not WCAR_Doc_AttachRec Is Nothing AndAlso Not WCAR_Doc_AttachRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WCAR_Doc_AttachRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WCAR_Doc_AttachRec As WCAR_Doc_AttachRecord = CType(sender,WCAR_Doc_AttachRecord)
        If Not WCAR_Doc_AttachRec Is Nothing AndAlso Not WCAR_Doc_AttachRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Attach_.WCDA_ID field.
	''' </summary>
	Public Function GetWCDA_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDA_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Attach_.WCDA_ID field.
	''' </summary>
	Public Function GetWCDA_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCDA_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Attach_.WCDA_WCD_ID field.
	''' </summary>
	Public Function GetWCDA_WCD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDA_WCD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Attach_.WCDA_WCD_ID field.
	''' </summary>
	Public Function GetWCDA_WCD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCDA_WCD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Attach_.WCDA_WCD_ID field.
	''' </summary>
	Public Sub SetWCDA_WCD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDA_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Attach_.WCDA_WCD_ID field.
	''' </summary>
	Public Sub SetWCDA_WCD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDA_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Attach_.WCDA_WCD_ID field.
	''' </summary>
	Public Sub SetWCDA_WCD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDA_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Attach_.WCDA_WCD_ID field.
	''' </summary>
	Public Sub SetWCDA_WCD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDA_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Attach_.WCDA_WCD_ID field.
	''' </summary>
	Public Sub SetWCDA_WCD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDA_WCD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Attach_.WCDA_Desc field.
	''' </summary>
	Public Function GetWCDA_DescValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDA_DescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Attach_.WCDA_Desc field.
	''' </summary>
	Public Function GetWCDA_DescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCDA_DescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Attach_.WCDA_Desc field.
	''' </summary>
	Public Sub SetWCDA_DescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDA_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Attach_.WCDA_Desc field.
	''' </summary>
	Public Sub SetWCDA_DescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDA_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Attach_.WCDA_File field.
	''' </summary>
	Public Function GetWCDA_FileValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDA_FileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Attach_.WCDA_File field.
	''' </summary>
	Public Function GetWCDA_FileFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.WCDA_FileColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Attach_.WCDA_File field.
	''' </summary>
	Public Sub SetWCDA_FileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDA_FileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Attach_.WCDA_File field.
	''' </summary>
	Public Sub SetWCDA_FileFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDA_FileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Attach_.WCDA_File field.
	''' </summary>
	Public Sub SetWCDA_FileFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDA_FileColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Attach_.WCDA_WAT_ID field.
	''' </summary>
	Public Function GetWCDA_WAT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCDA_WAT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Doc_Attach_.WCDA_WAT_ID field.
	''' </summary>
	Public Function GetWCDA_WAT_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCDA_WAT_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Attach_.WCDA_WAT_ID field.
	''' </summary>
	Public Sub SetWCDA_WAT_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCDA_WAT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Attach_.WCDA_WAT_ID field.
	''' </summary>
	Public Sub SetWCDA_WAT_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCDA_WAT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Attach_.WCDA_WAT_ID field.
	''' </summary>
	Public Sub SetWCDA_WAT_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDA_WAT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Attach_.WCDA_WAT_ID field.
	''' </summary>
	Public Sub SetWCDA_WAT_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDA_WAT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Doc_Attach_.WCDA_WAT_ID field.
	''' </summary>
	Public Sub SetWCDA_WAT_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCDA_WAT_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCAR_Doc_Attach_.WCDA_ID field.
	''' </summary>
	Public Property WCDA_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCDA_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDA_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDA_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDA_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDA_IDDefault() As String
        Get
            Return TableUtils.WCDA_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCAR_Doc_Attach_.WCDA_WCD_ID field.
	''' </summary>
	Public Property WCDA_WCD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCDA_WCD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDA_WCD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDA_WCD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDA_WCD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDA_WCD_IDDefault() As String
        Get
            Return TableUtils.WCDA_WCD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCAR_Doc_Attach_.WCDA_Desc field.
	''' </summary>
	Public Property WCDA_Desc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCDA_DescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCDA_DescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDA_DescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDA_DescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDA_DescDefault() As String
        Get
            Return TableUtils.WCDA_DescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCAR_Doc_Attach_.WCDA_File field.
	''' </summary>
	Public Property WCDA_File() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.WCDA_FileColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDA_FileColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDA_FileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDA_FileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDA_FileDefault() As String
        Get
            Return TableUtils.WCDA_FileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCAR_Doc_Attach_.WCDA_WAT_ID field.
	''' </summary>
	Public Property WCDA_WAT_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCDA_WAT_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCDA_WAT_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCDA_WAT_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCDA_WAT_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCDA_WAT_IDDefault() As String
        Get
            Return TableUtils.WCDA_WAT_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
