' This class is "generated" and will be overwritten.
' Your customizations should be made in ACTIVITYRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="ACTIVITYRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="ACTIVITYTable"></see> class.
''' </remarks>
''' <seealso cref="ACTIVITYTable"></seealso>
''' <seealso cref="ACTIVITYRecord"></seealso>

<Serializable()> Public Class BaseACTIVITYRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As ACTIVITYTable = ACTIVITYTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub ACTIVITYRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim ACTIVITYRec As ACTIVITYRecord = CType(sender,ACTIVITYRecord)
        Validate_Inserting()
        If Not ACTIVITYRec Is Nothing AndAlso Not ACTIVITYRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub ACTIVITYRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim ACTIVITYRec As ACTIVITYRecord = CType(sender,ACTIVITYRecord)
        Validate_Updating()
        If Not ACTIVITYRec Is Nothing AndAlso Not ACTIVITYRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub ACTIVITYRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim ACTIVITYRec As ACTIVITYRecord = CType(sender,ACTIVITYRecord)
        If Not ACTIVITYRec Is Nothing AndAlso Not ACTIVITYRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's ACTIVITY_.USERID field.
	''' </summary>
	Public Function GetUserId0Value() As ColumnValue
		Return Me.GetValue(TableUtils.UserId0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ACTIVITY_.USERID field.
	''' </summary>
	Public Function GetUserId0FieldValue() As String
		Return CType(Me.GetValue(TableUtils.UserId0Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.USERID field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UserId0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.USERID field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UserId0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ACTIVITY_.CMPNYNAM field.
	''' </summary>
	Public Function GetCMPNYNAMValue() As ColumnValue
		Return Me.GetValue(TableUtils.CMPNYNAMColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ACTIVITY_.CMPNYNAM field.
	''' </summary>
	Public Function GetCMPNYNAMFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CMPNYNAMColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.CMPNYNAM field.
	''' </summary>
	Public Sub SetCMPNYNAMFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CMPNYNAMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.CMPNYNAM field.
	''' </summary>
	Public Sub SetCMPNYNAMFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CMPNYNAMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ACTIVITY_.LOGINDAT field.
	''' </summary>
	Public Function GetLOGINDATValue() As ColumnValue
		Return Me.GetValue(TableUtils.LOGINDATColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ACTIVITY_.LOGINDAT field.
	''' </summary>
	Public Function GetLOGINDATFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.LOGINDATColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.LOGINDAT field.
	''' </summary>
	Public Sub SetLOGINDATFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LOGINDATColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.LOGINDAT field.
	''' </summary>
	Public Sub SetLOGINDATFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LOGINDATColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.LOGINDAT field.
	''' </summary>
	Public Sub SetLOGINDATFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LOGINDATColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ACTIVITY_.LOGINTIM field.
	''' </summary>
	Public Function GetLOGINTIMValue() As ColumnValue
		Return Me.GetValue(TableUtils.LOGINTIMColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ACTIVITY_.LOGINTIM field.
	''' </summary>
	Public Function GetLOGINTIMFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.LOGINTIMColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.LOGINTIM field.
	''' </summary>
	Public Sub SetLOGINTIMFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LOGINTIMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.LOGINTIM field.
	''' </summary>
	Public Sub SetLOGINTIMFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LOGINTIMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.LOGINTIM field.
	''' </summary>
	Public Sub SetLOGINTIMFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LOGINTIMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ACTIVITY_.SQLSESID field.
	''' </summary>
	Public Function GetSQLSESIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SQLSESIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ACTIVITY_.SQLSESID field.
	''' </summary>
	Public Function GetSQLSESIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SQLSESIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.SQLSESID field.
	''' </summary>
	Public Sub SetSQLSESIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SQLSESIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.SQLSESID field.
	''' </summary>
	Public Sub SetSQLSESIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SQLSESIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.SQLSESID field.
	''' </summary>
	Public Sub SetSQLSESIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SQLSESIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.SQLSESID field.
	''' </summary>
	Public Sub SetSQLSESIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SQLSESIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.SQLSESID field.
	''' </summary>
	Public Sub SetSQLSESIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SQLSESIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ACTIVITY_.Language_ID field.
	''' </summary>
	Public Function GetLanguage_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.Language_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ACTIVITY_.Language_ID field.
	''' </summary>
	Public Function GetLanguage_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.Language_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.Language_ID field.
	''' </summary>
	Public Sub SetLanguage_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Language_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.Language_ID field.
	''' </summary>
	Public Sub SetLanguage_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Language_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.Language_ID field.
	''' </summary>
	Public Sub SetLanguage_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Language_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.Language_ID field.
	''' </summary>
	Public Sub SetLanguage_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Language_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.Language_ID field.
	''' </summary>
	Public Sub SetLanguage_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Language_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ACTIVITY_.IsWebClient field.
	''' </summary>
	Public Function GetIsWebClientValue() As ColumnValue
		Return Me.GetValue(TableUtils.IsWebClientColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ACTIVITY_.IsWebClient field.
	''' </summary>
	Public Function GetIsWebClientFieldValue() As Byte
		Return CType(Me.GetValue(TableUtils.IsWebClientColumn).ToByte(), Byte)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.IsWebClient field.
	''' </summary>
	Public Sub SetIsWebClientFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IsWebClientColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.IsWebClient field.
	''' </summary>
	Public Sub SetIsWebClientFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.IsWebClientColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.IsWebClient field.
	''' </summary>
	Public Sub SetIsWebClientFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IsWebClientColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.IsWebClient field.
	''' </summary>
	Public Sub SetIsWebClientFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IsWebClientColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.IsWebClient field.
	''' </summary>
	Public Sub SetIsWebClientFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IsWebClientColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ACTIVITY_.IsOffline field.
	''' </summary>
	Public Function GetIsOfflineValue() As ColumnValue
		Return Me.GetValue(TableUtils.IsOfflineColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ACTIVITY_.IsOffline field.
	''' </summary>
	Public Function GetIsOfflineFieldValue() As Byte
		Return CType(Me.GetValue(TableUtils.IsOfflineColumn).ToByte(), Byte)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.IsOffline field.
	''' </summary>
	Public Sub SetIsOfflineFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.IsOfflineColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.IsOffline field.
	''' </summary>
	Public Sub SetIsOfflineFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.IsOfflineColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.IsOffline field.
	''' </summary>
	Public Sub SetIsOfflineFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IsOfflineColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.IsOffline field.
	''' </summary>
	Public Sub SetIsOfflineFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IsOfflineColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's ACTIVITY_.IsOffline field.
	''' </summary>
	Public Sub SetIsOfflineFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.IsOfflineColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ACTIVITY_.DEX_ROW_ID field.
	''' </summary>
	Public Function GetDEX_ROW_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.DEX_ROW_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's ACTIVITY_.DEX_ROW_ID field.
	''' </summary>
	Public Function GetDEX_ROW_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.DEX_ROW_IDColumn).ToInt32(), Int32)
	End Function



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ACTIVITY_.USERID field.
	''' </summary>
	Public Property UserId0() As String
		Get 
			Return CType(Me.GetValue(TableUtils.UserId0Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.UserId0Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UserId0Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UserId0Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UserId0Default() As String
        Get
            Return TableUtils.UserId0Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ACTIVITY_.CMPNYNAM field.
	''' </summary>
	Public Property CMPNYNAM() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CMPNYNAMColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CMPNYNAMColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CMPNYNAMSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CMPNYNAMColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CMPNYNAMDefault() As String
        Get
            Return TableUtils.CMPNYNAMColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ACTIVITY_.LOGINDAT field.
	''' </summary>
	Public Property LOGINDAT() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.LOGINDATColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LOGINDATColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LOGINDATSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LOGINDATColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LOGINDATDefault() As String
        Get
            Return TableUtils.LOGINDATColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ACTIVITY_.LOGINTIM field.
	''' </summary>
	Public Property LOGINTIM() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.LOGINTIMColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LOGINTIMColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LOGINTIMSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LOGINTIMColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LOGINTIMDefault() As String
        Get
            Return TableUtils.LOGINTIMColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ACTIVITY_.SQLSESID field.
	''' </summary>
	Public Property SQLSESID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SQLSESIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SQLSESIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SQLSESIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SQLSESIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SQLSESIDDefault() As String
        Get
            Return TableUtils.SQLSESIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ACTIVITY_.Language_ID field.
	''' </summary>
	Public Property Language_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.Language_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Language_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Language_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Language_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Language_IDDefault() As String
        Get
            Return TableUtils.Language_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ACTIVITY_.IsWebClient field.
	''' </summary>
	Public Property IsWebClient() As Byte
		Get 
			Return CType(Me.GetValue(TableUtils.IsWebClientColumn).ToByte(), Byte)
		End Get
		Set (ByVal val As Byte) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.IsWebClientColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property IsWebClientSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.IsWebClientColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property IsWebClientDefault() As String
        Get
            Return TableUtils.IsWebClientColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ACTIVITY_.IsOffline field.
	''' </summary>
	Public Property IsOffline() As Byte
		Get 
			Return CType(Me.GetValue(TableUtils.IsOfflineColumn).ToByte(), Byte)
		End Get
		Set (ByVal val As Byte) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.IsOfflineColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property IsOfflineSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.IsOfflineColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property IsOfflineDefault() As String
        Get
            Return TableUtils.IsOfflineColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's ACTIVITY_.DEX_ROW_ID field.
	''' </summary>
	Public Property DEX_ROW_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.DEX_ROW_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DEX_ROW_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DEX_ROW_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DEX_ROW_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DEX_ROW_IDDefault() As String
        Get
            Return TableUtils.DEX_ROW_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
