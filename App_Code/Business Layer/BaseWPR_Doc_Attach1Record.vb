' This class is "generated" and will be overwritten.
' Your customizations should be made in WPR_Doc_Attach1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WPR_Doc_Attach1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WPR_Doc_Attach1Table"></see> class.
''' </remarks>
''' <seealso cref="WPR_Doc_Attach1Table"></seealso>
''' <seealso cref="WPR_Doc_Attach1Record"></seealso>

<Serializable()> Public Class BaseWPR_Doc_Attach1Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WPR_Doc_Attach1Table = WPR_Doc_Attach1Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WPR_Doc_Attach1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WPR_Doc_Attach1Rec As WPR_Doc_Attach1Record = CType(sender,WPR_Doc_Attach1Record)
        Validate_Inserting()
        If Not WPR_Doc_Attach1Rec Is Nothing AndAlso Not WPR_Doc_Attach1Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WPR_Doc_Attach1Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WPR_Doc_Attach1Rec As WPR_Doc_Attach1Record = CType(sender,WPR_Doc_Attach1Record)
        Validate_Updating()
        If Not WPR_Doc_Attach1Rec Is Nothing AndAlso Not WPR_Doc_Attach1Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WPR_Doc_Attach1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WPR_Doc_Attach1Rec As WPR_Doc_Attach1Record = CType(sender,WPR_Doc_Attach1Record)
        If Not WPR_Doc_Attach1Rec Is Nothing AndAlso Not WPR_Doc_Attach1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_Attach_.WPRDA_ID field.
	''' </summary>
	Public Function GetWPRDA_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRDA_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_Attach_.WPRDA_ID field.
	''' </summary>
	Public Function GetWPRDA_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRDA_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_Attach_.WPRDA_WPRD_ID field.
	''' </summary>
	Public Function GetWPRDA_WPRD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRDA_WPRD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_Attach_.WPRDA_WPRD_ID field.
	''' </summary>
	Public Function GetWPRDA_WPRD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRDA_WPRD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Attach_.WPRDA_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRDA_WPRD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRDA_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Attach_.WPRDA_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRDA_WPRD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRDA_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Attach_.WPRDA_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRDA_WPRD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRDA_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Attach_.WPRDA_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRDA_WPRD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRDA_WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Attach_.WPRDA_WPRD_ID field.
	''' </summary>
	Public Sub SetWPRDA_WPRD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRDA_WPRD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_Attach_.WPRDA_Desc field.
	''' </summary>
	Public Function GetWPRDA_DescValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRDA_DescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_Attach_.WPRDA_Desc field.
	''' </summary>
	Public Function GetWPRDA_DescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRDA_DescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Attach_.WPRDA_Desc field.
	''' </summary>
	Public Sub SetWPRDA_DescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRDA_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Attach_.WPRDA_Desc field.
	''' </summary>
	Public Sub SetWPRDA_DescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRDA_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_Attach_.WPRDA_File field.
	''' </summary>
	Public Function GetWPRDA_FileValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRDA_FileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_Attach_.WPRDA_File field.
	''' </summary>
	Public Function GetWPRDA_FileFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.WPRDA_FileColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Attach_.WPRDA_File field.
	''' </summary>
	Public Sub SetWPRDA_FileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRDA_FileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Attach_.WPRDA_File field.
	''' </summary>
	Public Sub SetWPRDA_FileFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRDA_FileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Attach_.WPRDA_File field.
	''' </summary>
	Public Sub SetWPRDA_FileFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRDA_FileColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_Attach_.WPRDA_WAT_ID field.
	''' </summary>
	Public Function GetWPRDA_WAT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRDA_WAT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPR_Doc_Attach_.WPRDA_WAT_ID field.
	''' </summary>
	Public Function GetWPRDA_WAT_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WPRDA_WAT_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Attach_.WPRDA_WAT_ID field.
	''' </summary>
	Public Sub SetWPRDA_WAT_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRDA_WAT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Attach_.WPRDA_WAT_ID field.
	''' </summary>
	Public Sub SetWPRDA_WAT_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRDA_WAT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Attach_.WPRDA_WAT_ID field.
	''' </summary>
	Public Sub SetWPRDA_WAT_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRDA_WAT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Attach_.WPRDA_WAT_ID field.
	''' </summary>
	Public Sub SetWPRDA_WAT_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRDA_WAT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPR_Doc_Attach_.WPRDA_WAT_ID field.
	''' </summary>
	Public Sub SetWPRDA_WAT_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRDA_WAT_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_Attach_.WPRDA_ID field.
	''' </summary>
	Public Property WPRDA_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRDA_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRDA_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRDA_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRDA_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRDA_IDDefault() As String
        Get
            Return TableUtils.WPRDA_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_Attach_.WPRDA_WPRD_ID field.
	''' </summary>
	Public Property WPRDA_WPRD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRDA_WPRD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRDA_WPRD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRDA_WPRD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRDA_WPRD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRDA_WPRD_IDDefault() As String
        Get
            Return TableUtils.WPRDA_WPRD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_Attach_.WPRDA_Desc field.
	''' </summary>
	Public Property WPRDA_Desc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRDA_DescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRDA_DescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRDA_DescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRDA_DescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRDA_DescDefault() As String
        Get
            Return TableUtils.WPRDA_DescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_Attach_.WPRDA_File field.
	''' </summary>
	Public Property WPRDA_File() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.WPRDA_FileColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRDA_FileColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRDA_FileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRDA_FileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRDA_FileDefault() As String
        Get
            Return TableUtils.WPRDA_FileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPR_Doc_Attach_.WPRDA_WAT_ID field.
	''' </summary>
	Public Property WPRDA_WAT_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WPRDA_WAT_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRDA_WAT_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRDA_WAT_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRDA_WAT_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRDA_WAT_IDDefault() As String
        Get
            Return TableUtils.WPRDA_WAT_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
