' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WPO_POP10550Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_WPO_POP10550Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WPO_POP10550View"></see> class.
''' </remarks>
''' <seealso cref="Sel_WPO_POP10550View"></seealso>
''' <seealso cref="Sel_WPO_POP10550Record"></seealso>

<Serializable()> Public Class BaseSel_WPO_POP10550Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_WPO_POP10550View = Sel_WPO_POP10550View.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_WPO_POP10550Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_WPO_POP10550Rec As Sel_WPO_POP10550Record = CType(sender,Sel_WPO_POP10550Record)
        Validate_Inserting()
        If Not Sel_WPO_POP10550Rec Is Nothing AndAlso Not Sel_WPO_POP10550Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub Sel_WPO_POP10550Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim Sel_WPO_POP10550Rec As Sel_WPO_POP10550Record = CType(sender,Sel_WPO_POP10550Record)
        Validate_Updating()
        If Not Sel_WPO_POP10550Rec Is Nothing AndAlso Not Sel_WPO_POP10550Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_WPO_POP10550Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_WPO_POP10550Rec As Sel_WPO_POP10550Record = CType(sender,Sel_WPO_POP10550Record)
        If Not Sel_WPO_POP10550Rec Is Nothing AndAlso Not Sel_WPO_POP10550Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_POP10550_.DOCTYPE field.
	''' </summary>
	Public Function GetDOCTYPEValue() As ColumnValue
		Return Me.GetValue(TableUtils.DOCTYPEColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_POP10550_.DOCTYPE field.
	''' </summary>
	Public Function GetDOCTYPEFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.DOCTYPEColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_POP10550_.DOCTYPE field.
	''' </summary>
	Public Sub SetDOCTYPEFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DOCTYPEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_POP10550_.DOCTYPE field.
	''' </summary>
	Public Sub SetDOCTYPEFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DOCTYPEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_POP10550_.DOCTYPE field.
	''' </summary>
	Public Sub SetDOCTYPEFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DOCTYPEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_POP10550_.DOCTYPE field.
	''' </summary>
	Public Sub SetDOCTYPEFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DOCTYPEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_POP10550_.DOCTYPE field.
	''' </summary>
	Public Sub SetDOCTYPEFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DOCTYPEColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_POP10550_.POPNUMBE field.
	''' </summary>
	Public Function GetPOPNUMBEValue() As ColumnValue
		Return Me.GetValue(TableUtils.POPNUMBEColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_POP10550_.POPNUMBE field.
	''' </summary>
	Public Function GetPOPNUMBEFieldValue() As String
		Return CType(Me.GetValue(TableUtils.POPNUMBEColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_POP10550_.POPNUMBE field.
	''' </summary>
	Public Sub SetPOPNUMBEFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.POPNUMBEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_POP10550_.POPNUMBE field.
	''' </summary>
	Public Sub SetPOPNUMBEFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.POPNUMBEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_POP10550_.ORD field.
	''' </summary>
	Public Function GetORDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ORDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_POP10550_.ORD field.
	''' </summary>
	Public Function GetORDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ORDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_POP10550_.ORD field.
	''' </summary>
	Public Sub SetORDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ORDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_POP10550_.ORD field.
	''' </summary>
	Public Sub SetORDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ORDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_POP10550_.ORD field.
	''' </summary>
	Public Sub SetORDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ORDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_POP10550_.ORD field.
	''' </summary>
	Public Sub SetORDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ORDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_POP10550_.ORD field.
	''' </summary>
	Public Sub SetORDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ORDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_POP10550_.COMMENTS field.
	''' </summary>
	Public Function GetCOMMENTSValue() As ColumnValue
		Return Me.GetValue(TableUtils.COMMENTSColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_POP10550_.COMMENTS field.
	''' </summary>
	Public Function GetCOMMENTSFieldValue() As String
		Return CType(Me.GetValue(TableUtils.COMMENTSColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_POP10550_.COMMENTS field.
	''' </summary>
	Public Sub SetCOMMENTSFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.COMMENTSColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_POP10550_.COMMENTS field.
	''' </summary>
	Public Sub SetCOMMENTSFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.COMMENTSColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_POP10550_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WPO_POP10550_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.CompanyIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_POP10550_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_POP10550_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_POP10550_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_POP10550_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WPO_POP10550_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_POP10550_.DOCTYPE field.
	''' </summary>
	Public Property DOCTYPE() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.DOCTYPEColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DOCTYPEColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DOCTYPESpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DOCTYPEColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DOCTYPEDefault() As String
        Get
            Return TableUtils.DOCTYPEColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_POP10550_.POPNUMBE field.
	''' </summary>
	Public Property POPNUMBE() As String
		Get 
			Return CType(Me.GetValue(TableUtils.POPNUMBEColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.POPNUMBEColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property POPNUMBESpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.POPNUMBEColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property POPNUMBEDefault() As String
        Get
            Return TableUtils.POPNUMBEColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_POP10550_.ORD field.
	''' </summary>
	Public Property ORD() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ORDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ORDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ORDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ORDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ORDDefault() As String
        Get
            Return TableUtils.ORDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_POP10550_.COMMENTS field.
	''' </summary>
	Public Property COMMENTS() As String
		Get 
			Return CType(Me.GetValue(TableUtils.COMMENTSColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.COMMENTSColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property COMMENTSSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.COMMENTSColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property COMMENTSDefault() As String
        Get
            Return TableUtils.COMMENTSColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WPO_POP10550_.CompanyID field.
	''' </summary>
	Public Property CompanyID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.CompanyIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
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



#End Region

End Class
End Namespace
