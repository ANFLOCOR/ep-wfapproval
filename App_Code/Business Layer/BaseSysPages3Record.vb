' This class is "generated" and will be overwritten.
' Your customizations should be made in SysPages3Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="SysPages3Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="SysPages3Table"></see> class.
''' </remarks>
''' <seealso cref="SysPages3Table"></seealso>
''' <seealso cref="SysPages3Record"></seealso>

<Serializable()> Public Class BaseSysPages3Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As SysPages3Table = SysPages3Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub SysPages3Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim SysPages3Rec As SysPages3Record = CType(sender,SysPages3Record)
        Validate_Inserting()
        If Not SysPages3Rec Is Nothing AndAlso Not SysPages3Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub SysPages3Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim SysPages3Rec As SysPages3Record = CType(sender,SysPages3Record)
        Validate_Updating()
        If Not SysPages3Rec Is Nothing AndAlso Not SysPages3Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub SysPages3Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim SysPages3Rec As SysPages3Record = CType(sender,SysPages3Record)
        If Not SysPages3Rec Is Nothing AndAlso Not SysPages3Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.PageID field.
	''' </summary>
	Public Function GetPageIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.PageIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.PageID field.
	''' </summary>
	Public Function GetPageIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.PageIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.PageName field.
	''' </summary>
	Public Function GetPageNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.PageNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.PageName field.
	''' </summary>
	Public Function GetPageNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PageNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.PageName field.
	''' </summary>
	Public Sub SetPageNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PageNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.PageName field.
	''' </summary>
	Public Sub SetPageNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PageNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.ParentID field.
	''' </summary>
	Public Function GetParentIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.ParentIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.ParentID field.
	''' </summary>
	Public Function GetParentIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.ParentIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.ParentID field.
	''' </summary>
	Public Sub SetParentIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.ParentID field.
	''' </summary>
	Public Sub SetParentIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.ParentID field.
	''' </summary>
	Public Sub SetParentIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.ParentID field.
	''' </summary>
	Public Sub SetParentIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ParentIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.ParentID field.
	''' </summary>
	Public Sub SetParentIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ParentIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.Level field.
	''' </summary>
	Public Function GetLevelValue() As ColumnValue
		Return Me.GetValue(TableUtils.LevelColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.Level field.
	''' </summary>
	Public Function GetLevelFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.LevelColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.Level field.
	''' </summary>
	Public Sub SetLevelFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.LevelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.Level field.
	''' </summary>
	Public Sub SetLevelFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.LevelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.Level field.
	''' </summary>
	Public Sub SetLevelFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LevelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.Level field.
	''' </summary>
	Public Sub SetLevelFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LevelColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.Level field.
	''' </summary>
	Public Sub SetLevelFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.LevelColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.URL field.
	''' </summary>
	Public Function GetURLValue() As ColumnValue
		Return Me.GetValue(TableUtils.URLColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.URL field.
	''' </summary>
	Public Function GetURLFieldValue() As String
		Return CType(Me.GetValue(TableUtils.URLColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.URL field.
	''' </summary>
	Public Sub SetURLFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.URLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.URL field.
	''' </summary>
	Public Sub SetURLFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.URLColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.DateCreated field.
	''' </summary>
	Public Function GetDateCreatedValue() As ColumnValue
		Return Me.GetValue(TableUtils.DateCreatedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.DateCreated field.
	''' </summary>
	Public Function GetDateCreatedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.DateCreatedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.DateCreated field.
	''' </summary>
	Public Sub SetDateCreatedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.DateCreated field.
	''' </summary>
	Public Sub SetDateCreatedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.DateCreated field.
	''' </summary>
	Public Sub SetDateCreatedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.DateCreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.Sorting field.
	''' </summary>
	Public Function GetSortingValue() As ColumnValue
		Return Me.GetValue(TableUtils.SortingColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.Sorting field.
	''' </summary>
	Public Function GetSortingFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SortingColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.Sorting field.
	''' </summary>
	Public Sub SetSortingFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SortingColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.Sorting field.
	''' </summary>
	Public Sub SetSortingFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SortingColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.isDisplay field.
	''' </summary>
	Public Function GetisDisplayValue() As ColumnValue
		Return Me.GetValue(TableUtils.isDisplayColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.isDisplay field.
	''' </summary>
	Public Function GetisDisplayFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.isDisplayColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.isDisplay field.
	''' </summary>
	Public Sub SetisDisplayFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.isDisplayColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.isDisplay field.
	''' </summary>
	Public Sub SetisDisplayFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.isDisplayColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.isDisplay field.
	''' </summary>
	Public Sub SetisDisplayFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.isDisplayColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.Checked field.
	''' </summary>
	Public Function GetChecked0Value() As ColumnValue
		Return Me.GetValue(TableUtils.Checked0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.Checked field.
	''' </summary>
	Public Function GetChecked0FieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.Checked0Column).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.Checked field.
	''' </summary>
	Public Sub SetChecked0FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Checked0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.Checked field.
	''' </summary>
	Public Sub SetChecked0FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.Checked0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.Checked field.
	''' </summary>
	Public Sub SetChecked0FieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Checked0Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.SystemID field.
	''' </summary>
	Public Function GetSystemIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SystemIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's SysPages_.SystemID field.
	''' </summary>
	Public Function GetSystemIDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SystemIDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.SystemID field.
	''' </summary>
	Public Sub SetSystemIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SystemIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.SystemID field.
	''' </summary>
	Public Sub SetSystemIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SystemIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.SystemID field.
	''' </summary>
	Public Sub SetSystemIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SystemIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.SystemID field.
	''' </summary>
	Public Sub SetSystemIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SystemIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's SysPages_.SystemID field.
	''' </summary>
	Public Sub SetSystemIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SystemIDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysPages_.PageID field.
	''' </summary>
	Public Property PageID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.PageIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.PageIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PageIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PageIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PageIDDefault() As String
        Get
            Return TableUtils.PageIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysPages_.PageName field.
	''' </summary>
	Public Property PageName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PageNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PageNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PageNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PageNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PageNameDefault() As String
        Get
            Return TableUtils.PageNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysPages_.ParentID field.
	''' </summary>
	Public Property ParentID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.ParentIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ParentIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ParentIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ParentIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ParentIDDefault() As String
        Get
            Return TableUtils.ParentIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysPages_.Level field.
	''' </summary>
	Public Property Level() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.LevelColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.LevelColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property LevelSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.LevelColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property LevelDefault() As String
        Get
            Return TableUtils.LevelColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysPages_.URL field.
	''' </summary>
	Public Property URL() As String
		Get 
			Return CType(Me.GetValue(TableUtils.URLColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.URLColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property URLSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.URLColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property URLDefault() As String
        Get
            Return TableUtils.URLColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysPages_.DateCreated field.
	''' </summary>
	Public Property DateCreated() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.DateCreatedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.DateCreatedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property DateCreatedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.DateCreatedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property DateCreatedDefault() As String
        Get
            Return TableUtils.DateCreatedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysPages_.Sorting field.
	''' </summary>
	Public Property Sorting() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SortingColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SortingColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SortingSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SortingColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SortingDefault() As String
        Get
            Return TableUtils.SortingColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysPages_.isDisplay field.
	''' </summary>
	Public Property isDisplay() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.isDisplayColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.isDisplayColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property isDisplaySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.isDisplayColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property isDisplayDefault() As String
        Get
            Return TableUtils.isDisplayColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysPages_.Checked field.
	''' </summary>
	Public Property Checked0() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.Checked0Column).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.Checked0Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Checked0Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Checked0Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Checked0Default() As String
        Get
            Return TableUtils.Checked0Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's SysPages_.SystemID field.
	''' </summary>
	Public Property SystemID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SystemIDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SystemIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SystemIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SystemIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SystemIDDefault() As String
        Get
            Return TableUtils.SystemIDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
