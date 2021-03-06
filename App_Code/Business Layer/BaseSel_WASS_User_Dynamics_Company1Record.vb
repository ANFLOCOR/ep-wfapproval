﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WASS_User_Dynamics_Company1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_WASS_User_Dynamics_Company1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WASS_User_Dynamics_Company1View"></see> class.
''' </remarks>
''' <seealso cref="Sel_WASS_User_Dynamics_Company1View"></seealso>
''' <seealso cref="Sel_WASS_User_Dynamics_Company1Record"></seealso>

<Serializable()> Public Class BaseSel_WASS_User_Dynamics_Company1Record
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_WASS_User_Dynamics_Company1View = Sel_WASS_User_Dynamics_Company1View.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_WASS_User_Dynamics_Company1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_WASS_User_Dynamics_Company1Rec As Sel_WASS_User_Dynamics_Company1Record = CType(sender,Sel_WASS_User_Dynamics_Company1Record)
        If Not Sel_WASS_User_Dynamics_Company1Rec Is Nothing AndAlso Not Sel_WASS_User_Dynamics_Company1Rec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_WASS_User_Dynamics_Company1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_WASS_User_Dynamics_Company1Rec As Sel_WASS_User_Dynamics_Company1Record = CType(sender,Sel_WASS_User_Dynamics_Company1Record)
        Validate_Inserting()
        If Not Sel_WASS_User_Dynamics_Company1Rec Is Nothing AndAlso Not Sel_WASS_User_Dynamics_Company1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_SSU_UserName field.
	''' </summary>
	Public Function GetSSUC_SSU_UserNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUC_SSU_UserNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_SSU_UserName field.
	''' </summary>
	Public Function GetSSUC_SSU_UserNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSUC_SSU_UserNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_SSU_UserName field.
	''' </summary>
	Public Sub SetSSUC_SSU_UserNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUC_SSU_UserNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_SSU_UserName field.
	''' </summary>
	Public Sub SetSSUC_SSU_UserNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_SSU_UserNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_APP_ID field.
	''' </summary>
	Public Function GetSSUC_APP_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUC_APP_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_APP_ID field.
	''' </summary>
	Public Function GetSSUC_APP_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.SSUC_APP_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_APP_ID field.
	''' </summary>
	Public Sub SetSSUC_APP_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUC_APP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_APP_ID field.
	''' </summary>
	Public Sub SetSSUC_APP_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUC_APP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_APP_ID field.
	''' </summary>
	Public Sub SetSSUC_APP_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_APP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_APP_ID field.
	''' </summary>
	Public Sub SetSSUC_APP_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_APP_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_APP_ID field.
	''' </summary>
	Public Sub SetSSUC_APP_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_APP_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Function GetSSUC_SSC_CompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUC_SSC_CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Function GetSSUC_SSC_CompanyIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.SSUC_SSC_CompanyIDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSUC_SSC_CompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_SSC_CompanyIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.SSC_CompanyName field.
	''' </summary>
	Public Function GetSSC_CompanyNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSC_CompanyNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.SSC_CompanyName field.
	''' </summary>
	Public Function GetSSC_CompanyNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSC_CompanyNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.SSC_CompanyName field.
	''' </summary>
	Public Sub SetSSC_CompanyNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSC_CompanyNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.SSC_CompanyName field.
	''' </summary>
	Public Sub SetSSC_CompanyNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSC_CompanyNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.SSC_Description field.
	''' </summary>
	Public Function GetSSC_DescriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSC_DescriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.SSC_Description field.
	''' </summary>
	Public Function GetSSC_DescriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.SSC_DescriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.SSC_Description field.
	''' </summary>
	Public Sub SetSSC_DescriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSC_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.SSC_Description field.
	''' </summary>
	Public Sub SetSSC_DescriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSC_DescriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_isDefault field.
	''' </summary>
	Public Function GetSSUC_isDefaultValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSUC_isDefaultColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_isDefault field.
	''' </summary>
	Public Function GetSSUC_isDefaultFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.SSUC_isDefaultColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_isDefault field.
	''' </summary>
	Public Sub SetSSUC_isDefaultFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSUC_isDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_isDefault field.
	''' </summary>
	Public Sub SetSSUC_isDefaultFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSUC_isDefaultColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_isDefault field.
	''' </summary>
	Public Sub SetSSUC_isDefaultFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSUC_isDefaultColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.INTERID field.
	''' </summary>
	Public Function GetINTERIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.INTERIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.INTERID field.
	''' </summary>
	Public Function GetINTERIDFieldValue() As String
		Return CType(Me.GetValue(TableUtils.INTERIDColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.INTERID field.
	''' </summary>
	Public Sub SetINTERIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.INTERIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.INTERID field.
	''' </summary>
	Public Sub SetINTERIDFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.INTERIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.CMPANYID field.
	''' </summary>
	Public Function GetCMPANYIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.CMPANYIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.CMPANYID field.
	''' </summary>
	Public Function GetCMPANYIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.CMPANYIDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.CMPANYID field.
	''' </summary>
	Public Sub SetCMPANYIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CMPANYIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.CMPANYID field.
	''' </summary>
	Public Sub SetCMPANYIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.CMPANYIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.CMPANYID field.
	''' </summary>
	Public Sub SetCMPANYIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CMPANYIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.CMPANYID field.
	''' </summary>
	Public Sub SetCMPANYIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CMPANYIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.CMPANYID field.
	''' </summary>
	Public Sub SetCMPANYIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CMPANYIDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.CMPNYNAM field.
	''' </summary>
	Public Function GetCMPNYNAMValue() As ColumnValue
		Return Me.GetValue(TableUtils.CMPNYNAMColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.CMPNYNAM field.
	''' </summary>
	Public Function GetCMPNYNAMFieldValue() As String
		Return CType(Me.GetValue(TableUtils.CMPNYNAMColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.CMPNYNAM field.
	''' </summary>
	Public Sub SetCMPNYNAMFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.CMPNYNAMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.CMPNYNAM field.
	''' </summary>
	Public Sub SetCMPNYNAMFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.CMPNYNAMColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.Company_Short_Name field.
	''' </summary>
	Public Function GetCompany_Short_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.Company_Short_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.Company_Short_Name field.
	''' </summary>
	Public Function GetCompany_Short_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.Company_Short_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.Company_Short_Name field.
	''' </summary>
	Public Sub SetCompany_Short_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Company_Short_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sel_WASS_User_Dyna_1664604136_.Company_Short_Name field.
	''' </summary>
	Public Sub SetCompany_Short_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Company_Short_NameColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_SSU_UserName field.
	''' </summary>
	Public Property SSUC_SSU_UserName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SSUC_SSU_UserNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SSUC_SSU_UserNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUC_SSU_UserNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUC_SSU_UserNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUC_SSU_UserNameDefault() As String
        Get
            Return TableUtils.SSUC_SSU_UserNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_APP_ID field.
	''' </summary>
	Public Property SSUC_APP_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.SSUC_APP_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSUC_APP_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUC_APP_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUC_APP_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUC_APP_IDDefault() As String
        Get
            Return TableUtils.SSUC_APP_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_SSC_CompanyID field.
	''' </summary>
	Public Property SSUC_SSC_CompanyID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.SSUC_SSC_CompanyIDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSUC_SSC_CompanyIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUC_SSC_CompanyIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUC_SSC_CompanyIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUC_SSC_CompanyIDDefault() As String
        Get
            Return TableUtils.SSUC_SSC_CompanyIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.SSC_CompanyName field.
	''' </summary>
	Public Property SSC_CompanyName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SSC_CompanyNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SSC_CompanyNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSC_CompanyNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSC_CompanyNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSC_CompanyNameDefault() As String
        Get
            Return TableUtils.SSC_CompanyNameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.SSC_Description field.
	''' </summary>
	Public Property SSC_Description() As String
		Get 
			Return CType(Me.GetValue(TableUtils.SSC_DescriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.SSC_DescriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSC_DescriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSC_DescriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSC_DescriptionDefault() As String
        Get
            Return TableUtils.SSC_DescriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.SSUC_isDefault field.
	''' </summary>
	Public Property SSUC_isDefault() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.SSUC_isDefaultColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSUC_isDefaultColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSUC_isDefaultSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSUC_isDefaultColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSUC_isDefaultDefault() As String
        Get
            Return TableUtils.SSUC_isDefaultColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.INTERID field.
	''' </summary>
	Public Property INTERID() As String
		Get 
			Return CType(Me.GetValue(TableUtils.INTERIDColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.INTERIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property INTERIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.INTERIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property INTERIDDefault() As String
        Get
            Return TableUtils.INTERIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.CMPANYID field.
	''' </summary>
	Public Property CMPANYID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.CMPANYIDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.CMPANYIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property CMPANYIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.CMPANYIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property CMPANYIDDefault() As String
        Get
            Return TableUtils.CMPANYIDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.CMPNYNAM field.
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
	''' This is a convenience property that provides direct access to the value of the record's Sel_WASS_User_Dyna_1664604136_.Company_Short_Name field.
	''' </summary>
	Public Property Company_Short_Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Company_Short_NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Company_Short_NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Company_Short_NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Company_Short_NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Company_Short_NameDefault() As String
        Get
            Return TableUtils.Company_Short_NameColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
