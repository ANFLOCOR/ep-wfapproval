﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in WCAR_MinimumRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WCAR_MinimumRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WCAR_MinimumTable"></see> class.
''' </remarks>
''' <seealso cref="WCAR_MinimumTable"></seealso>
''' <seealso cref="WCAR_MinimumRecord"></seealso>

<Serializable()> Public Class BaseWCAR_MinimumRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WCAR_MinimumTable = WCAR_MinimumTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WCAR_MinimumRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WCAR_MinimumRec As WCAR_MinimumRecord = CType(sender,WCAR_MinimumRecord)
        Validate_Inserting()
        If Not WCAR_MinimumRec Is Nothing AndAlso Not WCAR_MinimumRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WCAR_MinimumRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WCAR_MinimumRec As WCAR_MinimumRecord = CType(sender,WCAR_MinimumRecord)
        Validate_Updating()
        If Not WCAR_MinimumRec Is Nothing AndAlso Not WCAR_MinimumRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WCAR_MinimumRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WCAR_MinimumRec As WCAR_MinimumRecord = CType(sender,WCAR_MinimumRecord)
        If Not WCAR_MinimumRec Is Nothing AndAlso Not WCAR_MinimumRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Minimum_.WCM_ID field.
	''' </summary>
	Public Function GetWCM_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCM_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Minimum_.WCM_ID field.
	''' </summary>
	Public Function GetWCM_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCM_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Minimum_.WCM_C_ID field.
	''' </summary>
	Public Function GetWCM_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCM_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Minimum_.WCM_C_ID field.
	''' </summary>
	Public Function GetWCM_C_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCM_C_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Minimum_.WCM_C_ID field.
	''' </summary>
	Public Sub SetWCM_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCM_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Minimum_.WCM_C_ID field.
	''' </summary>
	Public Sub SetWCM_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCM_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Minimum_.WCM_C_ID field.
	''' </summary>
	Public Sub SetWCM_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCM_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Minimum_.WCM_C_ID field.
	''' </summary>
	Public Sub SetWCM_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCM_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Minimum_.WCM_C_ID field.
	''' </summary>
	Public Sub SetWCM_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCM_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Minimum_.WCM_Min field.
	''' </summary>
	Public Function GetWCM_MinValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCM_MinColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Minimum_.WCM_Min field.
	''' </summary>
	Public Function GetWCM_MinFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCM_MinColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Minimum_.WCM_Min field.
	''' </summary>
	Public Sub SetWCM_MinFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCM_MinColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Minimum_.WCM_Min field.
	''' </summary>
	Public Sub SetWCM_MinFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCM_MinColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Minimum_.WCM_Min field.
	''' </summary>
	Public Sub SetWCM_MinFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCM_MinColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Minimum_.WCM_Min field.
	''' </summary>
	Public Sub SetWCM_MinFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCM_MinColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Minimum_.WCM_Min field.
	''' </summary>
	Public Sub SetWCM_MinFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCM_MinColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Minimum_.WCM_WCur_ID field.
	''' </summary>
	Public Function GetWCM_WCur_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCM_WCur_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WCAR_Minimum_.WCM_WCur_ID field.
	''' </summary>
	Public Function GetWCM_WCur_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCM_WCur_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Minimum_.WCM_WCur_ID field.
	''' </summary>
	Public Sub SetWCM_WCur_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCM_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Minimum_.WCM_WCur_ID field.
	''' </summary>
	Public Sub SetWCM_WCur_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCM_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Minimum_.WCM_WCur_ID field.
	''' </summary>
	Public Sub SetWCM_WCur_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCM_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Minimum_.WCM_WCur_ID field.
	''' </summary>
	Public Sub SetWCM_WCur_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCM_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WCAR_Minimum_.WCM_WCur_ID field.
	''' </summary>
	Public Sub SetWCM_WCur_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCM_WCur_IDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCAR_Minimum_.WCM_ID field.
	''' </summary>
	Public Property WCM_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCM_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCM_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCM_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCM_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCM_IDDefault() As String
        Get
            Return TableUtils.WCM_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCAR_Minimum_.WCM_C_ID field.
	''' </summary>
	Public Property WCM_C_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCM_C_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCM_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCM_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCM_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCM_C_IDDefault() As String
        Get
            Return TableUtils.WCM_C_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCAR_Minimum_.WCM_Min field.
	''' </summary>
	Public Property WCM_Min() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCM_MinColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCM_MinColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCM_MinSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCM_MinColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCM_MinDefault() As String
        Get
            Return TableUtils.WCM_MinColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WCAR_Minimum_.WCM_WCur_ID field.
	''' </summary>
	Public Property WCM_WCur_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCM_WCur_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCM_WCur_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCM_WCur_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCM_WCur_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCM_WCur_IDDefault() As String
        Get
            Return TableUtils.WCM_WCur_IDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
