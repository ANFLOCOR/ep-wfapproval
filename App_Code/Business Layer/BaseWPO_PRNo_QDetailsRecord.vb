' This class is "generated" and will be overwritten.
' Your customizations should be made in WPO_PRNo_QDetailsRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WPO_PRNo_QDetailsRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WPO_PRNo_QDetailsView"></see> class.
''' </remarks>
''' <seealso cref="WPO_PRNo_QDetailsView"></seealso>
''' <seealso cref="WPO_PRNo_QDetailsRecord"></seealso>

<Serializable()> Public Class BaseWPO_PRNo_QDetailsRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WPO_PRNo_QDetailsView = WPO_PRNo_QDetailsView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WPO_PRNo_QDetailsRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WPO_PRNo_QDetailsRec As WPO_PRNo_QDetailsRecord = CType(sender,WPO_PRNo_QDetailsRecord)
        Validate_Inserting()
        If Not WPO_PRNo_QDetailsRec Is Nothing AndAlso Not WPO_PRNo_QDetailsRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WPO_PRNo_QDetailsRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WPO_PRNo_QDetailsRec As WPO_PRNo_QDetailsRecord = CType(sender,WPO_PRNo_QDetailsRecord)
        Validate_Updating()
        If Not WPO_PRNo_QDetailsRec Is Nothing AndAlso Not WPO_PRNo_QDetailsRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WPO_PRNo_QDetailsRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WPO_PRNo_QDetailsRec As WPO_PRNo_QDetailsRecord = CType(sender,WPO_PRNo_QDetailsRecord)
        If Not WPO_PRNo_QDetailsRec Is Nothing AndAlso Not WPO_PRNo_QDetailsRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WPO_PRNo_QDetails_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_PRNo_QDetails_.CompanyID field.
	''' </summary>
	Public Function GetCompanyIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.CompanyIDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.CompanyID field.
	''' </summary>
	Public Sub SetCompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CompanyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_PRNo_QDetails_.PRNo field.
	''' </summary>
	Public Function GetPRNoValue() As ColumnValue
		Return Me.GetValue(TableUtils.PRNoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_PRNo_QDetails_.PRNo field.
	''' </summary>
	Public Function GetPRNoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PRNoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.PRNo field.
	''' </summary>
	Public Sub SetPRNoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PRNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.PRNo field.
	''' </summary>
	Public Sub SetPRNoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PRNoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_PRNo_QDetails_.WPRD_Title field.
	''' </summary>
	Public Function GetWPRD_TitleValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_TitleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_PRNo_QDetails_.WPRD_Title field.
	''' </summary>
	Public Function GetWPRD_TitleFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPRD_TitleColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.WPRD_Title field.
	''' </summary>
	Public Sub SetWPRD_TitleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_TitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.WPRD_Title field.
	''' </summary>
	Public Sub SetWPRD_TitleFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_TitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_PRNo_QDetails_.WPRD_Created field.
	''' </summary>
	Public Function GetWPRD_CreatedValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_CreatedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_PRNo_QDetails_.WPRD_Created field.
	''' </summary>
	Public Function GetWPRD_CreatedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WPRD_CreatedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.WPRD_Created field.
	''' </summary>
	Public Sub SetWPRD_CreatedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_CreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.WPRD_Created field.
	''' </summary>
	Public Sub SetWPRD_CreatedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRD_CreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.WPRD_Created field.
	''' </summary>
	Public Sub SetWPRD_CreatedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_CreatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_PRNo_QDetails_.WPRD_Total field.
	''' </summary>
	Public Function GetWPRD_TotalValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_TotalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_PRNo_QDetails_.WPRD_Total field.
	''' </summary>
	Public Function GetWPRD_TotalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WPRD_TotalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.WPRD_Total field.
	''' </summary>
	Public Sub SetWPRD_TotalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.WPRD_Total field.
	''' </summary>
	Public Sub SetWPRD_TotalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRD_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.WPRD_Total field.
	''' </summary>
	Public Sub SetWPRD_TotalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.WPRD_Total field.
	''' </summary>
	Public Sub SetWPRD_TotalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.WPRD_Total field.
	''' </summary>
	Public Sub SetWPRD_TotalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_TotalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_PRNo_QDetails_.Comment field.
	''' </summary>
	Public Function GetCommentValue() As ColumnValue
		Return Me.GetValue(TableUtils.CommentColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_PRNo_QDetails_.Comment field.
	''' </summary>
	Public Function GetCommentFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CommentColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.Comment field.
	''' </summary>
	Public Sub SetCommentFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CommentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.Comment field.
	''' </summary>
	Public Sub SetCommentFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CommentColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_PRNo_QDetails_.PONo field.
	''' </summary>
	Public Function GetPONoValue() As ColumnValue
		Return Me.GetValue(TableUtils.PONoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_PRNo_QDetails_.PONo field.
	''' </summary>
	Public Function GetPONoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.PONoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.PONo field.
	''' </summary>
	Public Sub SetPONoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.PONoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.PONo field.
	''' </summary>
	Public Sub SetPONoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.PONoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_PRNo_QDetails_.WPRD_ID field.
	''' </summary>
	Public Function GetWPRD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPRD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_PRNo_QDetails_.WPRD_ID field.
	''' </summary>
	Public Function GetWPRD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPRD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.WPRD_ID field.
	''' </summary>
	Public Sub SetWPRD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.WPRD_ID field.
	''' </summary>
	Public Sub SetWPRD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.WPRD_ID field.
	''' </summary>
	Public Sub SetWPRD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.WPRD_ID field.
	''' </summary>
	Public Sub SetWPRD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_PRNo_QDetails_.WPRD_ID field.
	''' </summary>
	Public Sub SetWPRD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPRD_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_PRNo_QDetails_.CompanyID field.
	''' </summary>
	Public Property CompanyID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.CompanyIDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_PRNo_QDetails_.PRNo field.
	''' </summary>
	Public Property PRNo() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PRNoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PRNoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PRNoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PRNoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PRNoDefault() As String
        Get
            Return TableUtils.PRNoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_PRNo_QDetails_.WPRD_Title field.
	''' </summary>
	Public Property WPRD_Title() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_TitleColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPRD_TitleColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_TitleSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_TitleColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_TitleDefault() As String
        Get
            Return TableUtils.WPRD_TitleColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_PRNo_QDetails_.WPRD_Created field.
	''' </summary>
	Public Property WPRD_Created() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_CreatedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRD_CreatedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_CreatedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_CreatedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_CreatedDefault() As String
        Get
            Return TableUtils.WPRD_CreatedColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_PRNo_QDetails_.WPRD_Total field.
	''' </summary>
	Public Property WPRD_Total() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_TotalColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRD_TotalColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_TotalSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_TotalColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_TotalDefault() As String
        Get
            Return TableUtils.WPRD_TotalColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_PRNo_QDetails_.Comment field.
	''' </summary>
	Public Property Comment() As String
		Get 
			Return CType(Me.GetValue(TableUtils.CommentColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.CommentColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CommentSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CommentColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CommentDefault() As String
        Get
            Return TableUtils.CommentColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_PRNo_QDetails_.PONo field.
	''' </summary>
	Public Property PONo() As String
		Get 
			Return CType(Me.GetValue(TableUtils.PONoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.PONoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property PONoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.PONoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property PONoDefault() As String
        Get
            Return TableUtils.PONoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_PRNo_QDetails_.WPRD_ID field.
	''' </summary>
	Public Property WPRD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPRD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPRD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPRD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPRD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPRD_IDDefault() As String
        Get
            Return TableUtils.WPRD_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
