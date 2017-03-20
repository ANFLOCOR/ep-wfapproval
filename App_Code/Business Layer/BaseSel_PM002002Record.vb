' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_PM002002Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_PM002002Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_PM002002View"></see> class.
''' </remarks>
''' <seealso cref="Sel_PM002002View"></seealso>
''' <seealso cref="Sel_PM002002Record"></seealso>

<Serializable()> Public Class BaseSel_PM002002Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_PM002002View = Sel_PM002002View.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_PM002002Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_PM002002Rec As Sel_PM002002Record = CType(sender,Sel_PM002002Record)
        Validate_Inserting()
        If Not Sel_PM002002Rec Is Nothing AndAlso Not Sel_PM002002Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub Sel_PM002002Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim Sel_PM002002Rec As Sel_PM002002Record = CType(sender,Sel_PM002002Record)
        Validate_Updating()
        If Not Sel_PM002002Rec Is Nothing AndAlso Not Sel_PM002002Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_PM002002Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_PM002002Rec As Sel_PM002002Record = CType(sender,Sel_PM002002Record)
        If Not Sel_PM002002Rec Is Nothing AndAlso Not Sel_PM002002Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's sel_PM00200_.VENDORID field.
	''' </summary>
	Public Function GetVENDORIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.VENDORIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_PM00200_.VENDORID field.
	''' </summary>
	Public Function GetVENDORIDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.VENDORIDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_PM00200_.VENDORID field.
	''' </summary>
	Public Sub SetVENDORIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.VENDORIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_PM00200_.VENDORID field.
	''' </summary>
	Public Sub SetVENDORIDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VENDORIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_PM00200_.VENDNAME field.
	''' </summary>
	Public Function GetVENDNAMEValue() As ColumnValue
		Return Me.GetValue(TableUtils.VENDNAMEColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_PM00200_.VENDNAME field.
	''' </summary>
	Public Function GetVENDNAMEFieldValue() As String
		Return CType(Me.GetValue(TableUtils.VENDNAMEColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_PM00200_.VENDNAME field.
	''' </summary>
	Public Sub SetVENDNAMEFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.VENDNAMEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_PM00200_.VENDNAME field.
	''' </summary>
	Public Sub SetVENDNAMEFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.VENDNAMEColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_PM00200_.Company_ID field.
	''' </summary>
	Public Function GetCompany_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.Company_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_PM00200_.Company_ID field.
	''' </summary>
	Public Function GetCompany_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.Company_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_PM00200_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_PM00200_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_PM00200_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_PM00200_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_PM00200_.Company_ID field.
	''' </summary>
	Public Sub SetCompany_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_PM00200_.VENDORID field.
	''' </summary>
	Public Property VENDORID() As String
		Get 
			Return CType(Me.GetValue(TableUtils.VENDORIDColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.VENDORIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property VENDORIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.VENDORIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property VENDORIDDefault() As String
        Get
            Return TableUtils.VENDORIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_PM00200_.VENDNAME field.
	''' </summary>
	Public Property VENDNAME() As String
		Get 
			Return CType(Me.GetValue(TableUtils.VENDNAMEColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.VENDNAMEColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property VENDNAMESpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.VENDNAMEColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property VENDNAMEDefault() As String
        Get
            Return TableUtils.VENDNAMEColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_PM00200_.Company_ID field.
	''' </summary>
	Public Property Company_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.Company_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Company_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Company_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Company_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Company_IDDefault() As String
        Get
            Return TableUtils.Company_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
