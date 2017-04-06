' This class is "generated" and will be overwritten.
' Your customizations should be made in WCanvass_Quotation_Internal1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WCanvass_Quotation_Internal1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WCanvass_Quotation_Internal1Table"></see> class.
''' </remarks>
''' <seealso cref="WCanvass_Quotation_Internal1Table"></seealso>
''' <seealso cref="WCanvass_Quotation_Internal1Record"></seealso>

<Serializable()> Public Class BaseWCanvass_Quotation_Internal1Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WCanvass_Quotation_Internal1Table = WCanvass_Quotation_Internal1Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WCanvass_Quotation_Internal1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WCanvass_Quotation_Internal1Rec As WCanvass_Quotation_Internal1Record = CType(sender,WCanvass_Quotation_Internal1Record)
        Validate_Inserting()
        If Not WCanvass_Quotation_Internal1Rec Is Nothing AndAlso Not WCanvass_Quotation_Internal1Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WCanvass_Quotation_Internal1Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WCanvass_Quotation_Internal1Rec As WCanvass_Quotation_Internal1Record = CType(sender,WCanvass_Quotation_Internal1Record)
        Validate_Updating()
        If Not WCanvass_Quotation_Internal1Rec Is Nothing AndAlso Not WCanvass_Quotation_Internal1Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WCanvass_Quotation_Internal1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WCanvass_Quotation_Internal1Rec As WCanvass_Quotation_Internal1Record = CType(sender,WCanvass_Quotation_Internal1Record)
        If Not WCanvass_Quotation_Internal1Rec Is Nothing AndAlso Not WCanvass_Quotation_Internal1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Quotation_Internal_.WCQI_ID field.
	''' </summary>
	Public Function GetWCQI_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCQI_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Quotation_Internal_.WCQI_ID field.
	''' </summary>
	Public Function GetWCQI_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCQI_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Quotation_Internal_.WCQI_WCI_ID field.
	''' </summary>
	Public Function GetWCQI_WCI_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCQI_WCI_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Quotation_Internal_.WCQI_WCI_ID field.
	''' </summary>
	Public Function GetWCQI_WCI_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCQI_WCI_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Quotation_Internal_.WCQI_WCI_ID field.
	''' </summary>
	Public Sub SetWCQI_WCI_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCQI_WCI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Quotation_Internal_.WCQI_WCI_ID field.
	''' </summary>
	Public Sub SetWCQI_WCI_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCQI_WCI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Quotation_Internal_.WCQI_WCI_ID field.
	''' </summary>
	Public Sub SetWCQI_WCI_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCQI_WCI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Quotation_Internal_.WCQI_WCI_ID field.
	''' </summary>
	Public Sub SetWCQI_WCI_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCQI_WCI_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Quotation_Internal_.WCQI_WCI_ID field.
	''' </summary>
	Public Sub SetWCQI_WCI_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCQI_WCI_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Quotation_Internal_.WCQI_Desc field.
	''' </summary>
	Public Function GetWCQI_DescValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCQI_DescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Quotation_Internal_.WCQI_Desc field.
	''' </summary>
	Public Function GetWCQI_DescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCQI_DescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Quotation_Internal_.WCQI_Desc field.
	''' </summary>
	Public Sub SetWCQI_DescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCQI_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Quotation_Internal_.WCQI_Desc field.
	''' </summary>
	Public Sub SetWCQI_DescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCQI_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Quotation_Internal_.WCQI_File field.
	''' </summary>
	Public Function GetWCQI_FileValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCQI_FileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Quotation_Internal_.WCQI_File field.
	''' </summary>
	Public Function GetWCQI_FileFieldValue() As Byte()
		Return CType(Me.GetValue(TableUtils.WCQI_FileColumn).ToBinary(), Byte())
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Quotation_Internal_.WCQI_File field.
	''' </summary>
	Public Sub SetWCQI_FileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCQI_FileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Quotation_Internal_.WCQI_File field.
	''' </summary>
	Public Sub SetWCQI_FileFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCQI_FileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Quotation_Internal_.WCQI_File field.
	''' </summary>
	Public Sub SetWCQI_FileFieldValue(ByVal val As Byte ())
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCQI_FileColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Quotation_Internal_.WCQI_PM00200_Vendor_ID field.
	''' </summary>
	Public Function GetWCQI_PM00200_Vendor_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCQI_PM00200_Vendor_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCanvass_Quotation_Internal_.WCQI_PM00200_Vendor_ID field.
	''' </summary>
	Public Function GetWCQI_PM00200_Vendor_IDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCQI_PM00200_Vendor_IDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Quotation_Internal_.WCQI_PM00200_Vendor_ID field.
	''' </summary>
	Public Sub SetWCQI_PM00200_Vendor_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCQI_PM00200_Vendor_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCanvass_Quotation_Internal_.WCQI_PM00200_Vendor_ID field.
	''' </summary>
	Public Sub SetWCQI_PM00200_Vendor_IDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCQI_PM00200_Vendor_IDColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Quotation_Internal_.WCQI_ID field.
	''' </summary>
	Public Property WCQI_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCQI_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCQI_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCQI_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCQI_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCQI_IDDefault() As String
        Get
            Return TableUtils.WCQI_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Quotation_Internal_.WCQI_WCI_ID field.
	''' </summary>
	Public Property WCQI_WCI_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCQI_WCI_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCQI_WCI_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCQI_WCI_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCQI_WCI_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCQI_WCI_IDDefault() As String
        Get
            Return TableUtils.WCQI_WCI_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Quotation_Internal_.WCQI_Desc field.
	''' </summary>
	Public Property WCQI_Desc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCQI_DescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCQI_DescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCQI_DescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCQI_DescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCQI_DescDefault() As String
        Get
            Return TableUtils.WCQI_DescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Quotation_Internal_.WCQI_File field.
	''' </summary>
	Public Property WCQI_File() As Byte()
		Get 
			Return CType(Me.GetValue(TableUtils.WCQI_FileColumn).ToBinary(), Byte())
		End Get
		Set (ByVal val As Byte ()) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCQI_FileColumn)
		End Set
	End Property



	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCQI_FileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCQI_FileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCQI_FileDefault() As String
        Get
            Return TableUtils.WCQI_FileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCanvass_Quotation_Internal_.WCQI_PM00200_Vendor_ID field.
	''' </summary>
	Public Property WCQI_PM00200_Vendor_ID() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCQI_PM00200_Vendor_IDColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCQI_PM00200_Vendor_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCQI_PM00200_Vendor_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCQI_PM00200_Vendor_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCQI_PM00200_Vendor_IDDefault() As String
        Get
            Return TableUtils.WCQI_PM00200_Vendor_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
