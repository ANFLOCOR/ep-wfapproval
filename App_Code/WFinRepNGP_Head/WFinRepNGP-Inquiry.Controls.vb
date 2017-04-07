
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' WFinRepNGP_Inquiry.aspx page.  The Row or RecordControl classes are the 
' ideal place to add code customizations. For example, you can override the LoadData, 
' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

#Region "Imports statements"

Option Strict On
Imports Microsoft.VisualBasic
Imports BaseClasses.Web.UI.WebControls
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Web.Script.Serialization
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Utils
Imports ReportTools.ReportCreator
Imports ReportTools.Shared

  
        
Imports ePortalWFApproval.Business
Imports ePortalWFApproval.Data
Imports ePortalWFApproval.UI
        

#End Region

  
Namespace ePortalWFApproval.UI.Controls.WFinRepNGP_Inquiry

#Region "Section 1: Place your customizations here."

    
Public Class WFinRepNGP_ActivityTableControlRow
        Inherits BaseWFinRepNGP_ActivityTableControlRow
        ' The BaseWFinRepNGP_ActivityTableControlRow implements code for a ROW within the
        ' the WFinRepNGP_ActivityTableControl table.  The BaseWFinRepNGP_ActivityTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WFinRepNGP_ActivityTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class WFinRepNGP_ActivityTableControl
        Inherits BaseWFinRepNGP_ActivityTableControl

    ' The BaseWFinRepNGP_ActivityTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The WFinRepNGP_ActivityTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  
Public Class WFinRepNGP_AttachmentTableControlRow
        Inherits BaseWFinRepNGP_AttachmentTableControlRow
        ' The BaseWFinRepNGP_AttachmentTableControlRow implements code for a ROW within the
        ' the WFinRepNGP_AttachmentTableControl table.  The BaseWFinRepNGP_AttachmentTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WFinRepNGP_AttachmentTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class WFinRepNGP_AttachmentTableControl
        Inherits BaseWFinRepNGP_AttachmentTableControl

    ' The BaseWFinRepNGP_AttachmentTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The WFinRepNGP_AttachmentTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  
Public Class WFinRepNGP_DocAttachTableControlRow
        Inherits BaseWFinRepNGP_DocAttachTableControlRow
        ' The BaseWFinRepNGP_DocAttachTableControlRow implements code for a ROW within the
        ' the WFinRepNGP_DocAttachTableControl table.  The BaseWFinRepNGP_DocAttachTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WFinRepNGP_DocAttachTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        


        Protected Overrides Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load


            ' Register the event handlers.

            AddHandler Me.btnPreview.Button.Click, AddressOf btnPreview_Click

            AddHandler Me.WFRCDNGP_Company.TextChanged, AddressOf WFRCDNGP_Company_TextChanged

            AddHandler Me.WFRCDNGP_File1.TextChanged, AddressOf WFRCDNGP_File1_TextChanged

            AddHandler Me.WFRCDNGP_Month.TextChanged, AddressOf WFRCDNGP_Month_TextChanged

            AddHandler Me.WFRCDNGP_Status.TextChanged, AddressOf WFRCDNGP_Status_TextChanged

            AddHandler Me.WFRCDNGP_Type1.TextChanged, AddressOf WFRCDNGP_Type1_TextChanged

            AddHandler Me.WFRCDNGP_WFRCHNGP_ID.TextChanged, AddressOf WFRCDNGP_WFRCHNGP_ID_TextChanged

            AddHandler Me.WFRCDNGP_Year.TextChanged, AddressOf WFRCDNGP_Year_TextChanged

            Me.btnPreview.Button.Attributes.Add("onClick", "OpenRptViewer2('" & Me.WFRCDNGP_Year.ClientID & "','" & Me.WFRCDNGP_Month.ClientID & "', '" & Me.WFRCDNGP_Type1.ClientID & "', '" & Me.WFRCDNGP_File1.ClientID & "', '" & Me.WFRCDNGP_Company.ClientID & "',  '" & Me.WFRCDNGP_Status.ClientID & "',  '" & Me.WFRCDNGP_WFRCHNGP_ID.ClientID & "');return false;")
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WFinRepNGP_DocAttachTableControlRow.
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record.  To do this, it calls the Set methods for 
            ' each of the field displayed on the webpage.  It is better to make 
            ' changes in the Set methods, rather than making changes here.

            MyBase.DataBind()
            Me.ClearControlsFromSession()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then

                Return
            End If


            'LoadData for DataSource for chart and report if they exist

            ' Store the checksum. The checksum is used to
            ' ensure the record was not changed by another user.
            If Not Me.DataSource.GetCheckSumValue() Is Nothing Then
                Me.CheckSum = Me.DataSource.GetCheckSumValue().Value
            End If



            ' Call the Set methods for each controls on the panel


            SetWFRCDNGP_Company()
            SetWFRCDNGP_File1()
            SetWFRCDNGP_Month()
            SetWFRCDNGP_RWRem()
            SetWFRCDNGP_Status()
            SetWFRCDNGP_Type()
            SetWFRCDNGP_Type1()
            SetWFRCDNGP_WFRCHNGP_ID()
            SetWFRCDNGP_Year()
            SetbtnPreview()



            Me.IsNewRecord = True

            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False

                If Me.DataSource.GetID IsNot Nothing Then
                    Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
                End If

            End If

            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
            Dim role As String = BaseClasses.Utils.SecurityControls.GetCurrentUserRoles()
            Dim rolecorrect As Boolean = False
            Dim separator As Char() = {";"c}
            Dim roles As String() = role.Split(separator, System.StringSplitOptions.RemoveEmptyEntries)
            Dim includes As Boolean = False

            Dim wherssouth As String = Nothing
            If Not System.Web.HttpContext.Current.Session("UserId").ToString Is Nothing And Not System.Web.HttpContext.Current.Session("UserId").ToString = "" Then
                wherssouth = Sel_W_User_W_ModuleView.W_U_ID.UniqueName & "=" & System.Web.HttpContext.Current.Session("UserId").ToString
            Else
                wherssouth = Sel_W_User_W_ModuleView.W_U_ID.UniqueName & "=0"
            End If
            Dim obysouth As BaseClasses.Data.OrderBy = New OrderBy(False, False)
            Dim waspsouth() As Sel_W_User_W_ModuleRecord = Nothing
            waspsouth = Sel_W_User_W_ModuleView.GetRecords(wherssouth, obysouth)
            For Each r As Sel_W_User_W_ModuleRecord In waspsouth
                If r.W_MS_ID = 177 Then
                    rolecorrect = True
                End If
            Next


            'For Each r As String In roles
            '    If r = "177" Then
            '        rolecorrect = True
            '    End If
            'Next r
            If Me.WFRCDNGP_Status.Text = "Completed" Or rolecorrect = True Then
                Me.btnPreview.Visible = True
            Else
                Me.btnPreview.Visible = False
            End If
        End Sub




    End Class



    Public Class WFinRepNGP_DocAttachTableControl
        Inherits BaseWFinRepNGP_DocAttachTableControl

        ' The BaseWFinRepNGP_DocAttachTableControl class implements the LoadData, DataBind, CreateWhereClause
        ' and other methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        ' The WFinRepNGP_DocAttachTableControlRow class offers another place where you can customize
        ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

    End Class


    Public Class WFinRepNGP_HeadTableControlRow
        Inherits BaseWFinRepNGP_HeadTableControlRow
        ' The BaseWFinRepNGP_HeadTableControlRow implements code for a ROW within the
        ' the WFinRepNGP_HeadTableControl table.  The BaseWFinRepNGP_HeadTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WFinRepNGP_HeadTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.


        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record.  To do this, it calls the Set methods for 
            ' each of the field displayed on the webpage.  It is better to make 
            ' changes in the Set methods, rather than making changes here.

            MyBase.DataBind()


            Dim user As String = BaseClasses.Utils.SecurityControls.GetCurrentUserName()
            Dim role As String = BaseClasses.Utils.SecurityControls.GetCurrentUserRoles()
            Dim rolecorrectsouth As Boolean = False
            Dim rolecorrectnorth As Boolean = False
            Dim separator As Char() = {";"c}
            Dim roles As String() = role.Split(separator, System.StringSplitOptions.RemoveEmptyEntries)
            Dim includes As Boolean = False
            Dim wherssouth As String = Nothing
            If Not System.Web.HttpContext.Current.Session("UserId").ToString Is Nothing And Not System.Web.HttpContext.Current.Session("UserId").ToString = "" Then
                wherssouth = Sel_W_User_W_ModuleView.W_U_ID.UniqueName & "=" & System.Web.HttpContext.Current.Session("UserId").ToString
            Else
                wherssouth = Sel_W_User_W_ModuleView.W_U_ID.UniqueName & "=0"
            End If
            Dim obysouth As BaseClasses.Data.OrderBy = New OrderBy(False, False)
            Dim waspsouth() As Sel_W_User_W_ModuleRecord = Nothing
            waspsouth = Sel_W_User_W_ModuleView.GetRecords(wherssouth, obysouth)
            For Each r As Sel_W_User_W_ModuleRecord In waspsouth
                If r.W_MS_ID = 157 Then
                    rolecorrectsouth = True
                End If
            Next r

            'For Each r As String In roles
            '    If r = "157" Then ' 157 - old FS Viewer 151
            '        rolecorrect = True
            '    End If
            'Next r

            If Me.WFRCHNGP_Status.Text = "Completed" And rolecorrectsouth = True Then
                'Me.imbView.Visible = True
                Me.btnPreview1.Visible = True
                Me.btnPreview2.Visible = True
            Else
                'Me.imbView.Visible = False
                Me.btnPreview1.Visible = False
                Me.btnPreview2.Visible = False
            End If

            Dim returnForRevisionRole As Boolean = False
            ' old ID  158 - FS Setup Role  = new 150 
            '         159 - FS Final Approver = new 190
            'For Each r As String In roles
            '    'If r = "150" Or r = "190" Then
            '    If r = "158" Or r = "159" Then
            '        returnForRevisionRole = True
            '    End If
            'Next r

            Dim wherechecker As String = Nothing
            If Not System.Web.HttpContext.Current.Session("UserName").ToString Is Nothing And Not System.Web.HttpContext.Current.Session("UserName").ToString = "" Then
                wherechecker = Sel_W_User_DYNAMICS_Company_FSView.W_U_User_Name.UniqueName & "='" & System.Web.HttpContext.Current.Session("UserName").ToString.Trim & "' AND " & Sel_W_User_DYNAMICS_Company_FSView.IsNonGP.UniqueName & "=1 AND " & Sel_W_User_DYNAMICS_Company_FSView.Company_ID.UniqueName & "='" & Me.WFRCHNGP_C_ID1.Text & "'"
            Else
                wherechecker = Sel_W_User_DYNAMICS_Company_FSView.W_U_User_Name.UniqueName & "="
            End If
            Dim obychecker As BaseClasses.Data.OrderBy = New OrderBy(False, False)
            'Dim checker() As Sel_W_User_DYNAMICS_Company_FSRecord = Nothing
            Dim checker As Sel_W_User_DYNAMICS_Company_FSRecord = Sel_W_User_DYNAMICS_Company_FSView.GetRecord(wherechecker, obysouth)


            For Each r As Sel_W_User_W_ModuleRecord In waspsouth
                If r.W_MS_ID = 159 And Not checker Is Nothing Then
                    returnForRevisionRole = True
                End If
            Next r


            If (returnForRevisionRole = True) And Me.WFRCHNGP_Status.Text = "Completed" Then
                'Me.imbEdit.Visible = True
                Me.btnEdit.Visible = True
            Else
                'Me.imbEdit.Visible = False
                Me.btnEdit.Visible = False
            End If

            Me.imbView.Attributes.Add("onClick", "OpenRptViewer2('" & Me.WFRCHNGP_Year1.ClientID & "','" & Me.WFRCHNGP_Month1.ClientID & "', '" & Me.WFRCHNGP_Description1.ClientID & "', '" & Me.WFRCHNGP_Description1.ClientID & "', '" & Me.WFRCHNGP_C_ID1.ClientID & "', '" & Me.WFRCHNGP_Status1.ClientID & "', '" & Me.WFRCHNGP_ID.ClientID & "');return false;")
            Me.btnPreview1.Button.Attributes.Add("onClick", "OpenRptViewer2('" & Me.WFRCHNGP_Year1.ClientID & "','" & Me.WFRCHNGP_Month1.ClientID & "', '" & Me.WFRCHNGP_Description1.ClientID & "', '" & Me.WFRCHNGP_Description1.ClientID & "', '" & Me.WFRCHNGP_C_ID1.ClientID & "', '" & Me.WFRCHNGP_Status1.ClientID & "', '" & Me.WFRCHNGP_ID.ClientID & "');return false;")
        End Sub

        Public Overrides Sub SetWFRCHNGP_File()

            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_FileSpecified Then

                Me.WFRCHNGP_File.Text = Page.GetResourceValue("Txt:OpenFile", "EPORTAL")

                Me.WFRCHNGP_File.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WFinRepNGP_Head") & _
                            "&Field=" & Me.Page.Encrypt("WFRCHNGP_File") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"
                Me.btnPreview2.button.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WFinRepNGP_Head") & _
                            "&Field=" & Me.Page.Encrypt("WFRCHNGP_File") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"

                ' Me.WFRCHNGP_File.Visible = True
            Else
                ' Me.WFRCHNGP_File.Visible = False
            End If
        End Sub

        Public Overrides Sub SetWFRCHNGP_C_ID()


            ' Set the WFRCHNGP_C_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Head database record.

            'Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Head record retrieved from the database.
            'Me.WFRCHNGP_C_ID is the ASP:Literal on the webpage.

            'You can modify this method directly, or replace it with a call to
            MyBase.SetWFRCHNGP_C_ID()
            'and add your own code before or after the call to the MyBase function.

            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_C_IDSpecified Then

                ' If the WFRCHNGP_C_ID is non-NULL, then format the value.
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_HeadTable.WFRCHNGP_C_ID)

                Dim sWhere As String = ""
                Dim ordB As New OrderBy(False, False)

                ordB.Add(View_DW_CompanyView.wass_C_ID, OrderByItem.OrderDir.Asc)
                sWhere = "DynamicsCompanyID ='" & formattedValue & "'"

                Dim dw_company As View_DW_CompanyRecord = View_DW_CompanyView.GetRecord(sWhere, ordB)

                If IsNothing(dw_company) = False Then

                    formattedValue = dw_company.ShortName
                End If

                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCHNGP_C_ID.Text = formattedValue

            Else

                ' WFRCHNGP_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.WFRCHNGP_C_ID.Text = WFinRepNGP_HeadTable.WFRCHNGP_C_ID.Format(WFinRepNGP_HeadTable.WFRCHNGP_C_ID.DefaultValue)

            End If

            ' If the WFRCHNGP_C_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRCHNGP_C_ID.Text Is Nothing _
                OrElse Me.WFRCHNGP_C_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRCHNGP_C_ID.Text = "&nbsp;"
            End If


            ' If data was retrieved from UI previously, restore it
            'If Me.PreviousUIData.ContainsKey(Me.WFRCHNGP_C_ID1.ID) Then

            '    Me.WFRCHNGP_C_ID.Text = Me.PreviousUIData(Me.WFRCHNGP_C_ID.ID).ToString()

            '    Return
            'End If


            '' Set the WFRCHNGP_C_ID TextBox on the webpage with value from the
            '' WFinRepNGP_Head database record.

            '' Me.DataSource is the WFinRepNGP_Head record retrieved from the database.
            '' Me.WFRCHNGP_C_ID1 is the ASP:TextBox on the webpage.

            '' You can modify this method directly, or replace it with a call to
            ''     MyBase.SetWFRCHNGP_C_ID1()
            '' and add your own code before or after the call to the MyBase function.



            'If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_C_IDSpecified Then

            '    ' If the WFRCHNGP_C_ID is non-NULL, then format the value.

            '    ' The Format method will return the Display Foreign Key As (DFKA) value
            '    Dim formattedValue As String = ""
            '    Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_HeadTable.WFRCHNGP_C_ID)
            '    If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_HeadTable.WFRCHNGP_C_ID.IsApplyDisplayAs Then

            '        formattedValue = Me.DataSource.Format(WFinRepNGP_HeadTable.WFRCHNGP_C_ID) 'WFinRepNGP_HeadTable.GetDFKA(Me.DataSource.WFRCHNGP_C_ID.ToString(),WFinRepNGP_HeadTable.WFRCHNGP_C_ID, Nothing)

            '        If (formattedValue Is Nothing) Then
            '            formattedValue = Me.DataSource.Format(WFinRepNGP_HeadTable.WFRCHNGP_C_ID)
            '        End If
            '    Else
            '        formattedValue = Me.DataSource.WFRCHNGP_C_ID.ToString()
            '    End If

            '    Me.WFRCHNGP_C_ID.Text = formattedValue

            'Else

            '    ' WFRCHNGP_C_ID is NULL in the database, so use the Default Value.  
            '    ' Default Value could also be NULL.

            '    Me.WFRCHNGP_C_ID.Text = WFinRepNGP_HeadTable.WFRCHNGP_C_ID.Format(WFinRepNGP_HeadTable.WFRCHNGP_C_ID.DefaultValue)

            'End If

        End Sub



        Public Overrides Sub SetWFRCHNGP_Month1()

            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCHNGP_Month1.ID) Then

                Me.WFRCHNGP_Month1.Text = Me.PreviousUIData(Me.WFRCHNGP_Month1.ID).ToString()

                Return
            End If


            ' Set the WFRCHNGP_Month TextBox on the webpage with value from the
            ' WFinRepNGP_Head database record.

            ' Me.DataSource is the WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Month1 is the ASP:TextBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Month1()
            ' and add your own code before or after the call to the MyBase function.

            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_MonthSpecified Then

                ' If the WFRCHNGP_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value

                Me.WFRCHNGP_Month1.Text = Me.DataSource.WFRCHNGP_Month.ToString()

            Else

                ' WFRCHNGP_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.WFRCHNGP_Month1.Text = WFinRepNGP_HeadTable.WFRCHNGP_Month.Format(WFinRepNGP_HeadTable.WFRCHNGP_Month.DefaultValue)

            End If
            '                 
        End Sub




    End Class

  

Public Class WFinRepNGP_HeadTableControl
        Inherits BaseWFinRepNGP_HeadTableControl

    ' The BaseWFinRepNGP_HeadTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The WFinRepNGP_HeadTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.



		Public Overrides Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            WFinRepNGP_HeadTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()

            Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False

            Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False

            Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False

            Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False

            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.


            If IsValueSelected(Me.WFRCHNGP_C_IDFilter) Then

                hasFiltersWFinRepNGP_HeadTableControl = True

                wc.iAND(WFinRepNGP_HeadTable.WFRCHNGP_C_ID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.WFRCHNGP_C_IDFilter, Me.GetFromSession(Me.WFRCHNGP_C_IDFilter)), False, False)
            Else
                Dim wherssouth As String = Nothing
                If Not System.Web.HttpContext.Current.Session("UserName").ToString Is Nothing And Not System.Web.HttpContext.Current.Session("UserName").ToString = "" Then
                    wherssouth = Sel_W_User_DYNAMICS_Company_FSView.W_U_User_Name.UniqueName & "='" & System.Web.HttpContext.Current.Session("UserName").ToString.Trim & "' AND " & Sel_W_User_DYNAMICS_Company_FSView.IsNonGP.UniqueName & "=1"
                Else
                    wherssouth = Sel_W_User_DYNAMICS_Company_FSView.W_U_User_Name.UniqueName & "="
                End If
                Dim obysouth As BaseClasses.Data.OrderBy = New OrderBy(False, False)
                Dim waspsouth() As Sel_W_User_DYNAMICS_Company_FSRecord = Nothing
                waspsouth = Sel_W_User_DYNAMICS_Company_FSView.GetRecords(wherssouth, obysouth)
                For Each r As Sel_W_User_DYNAMICS_Company_FSRecord In waspsouth
                    wc.iAND(WFinRepNGP_HeadTable.WFRCHNGP_C_ID, BaseFilter.ComparisonOperator.EqualsTo, r.Company_ID.ToString)
                Next
            End If

            'wc.iAND(WFinRepNGP_HeadTable.WFRCHNGP_C_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("DynCompID").ToString)


            If IsValueSelected(Me.WFRCHNGP_MonthFilter) Then

                hasFiltersWFinRepNGP_HeadTableControl = True

                wc.iAND(WFinRepNGP_HeadTable.WFRCHNGP_Month, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.WFRCHNGP_MonthFilter, Me.GetFromSession(Me.WFRCHNGP_MonthFilter)), False, False)

            End If



            If IsValueSelected(Me.WFRCHNGP_StatusFilter) Then

                hasFiltersWFinRepNGP_HeadTableControl = True

                wc.iAND(WFinRepNGP_HeadTable.WFRCHNGP_Status, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.WFRCHNGP_StatusFilter, Me.GetFromSession(Me.WFRCHNGP_StatusFilter)), False, False)

            End If



            If IsValueSelected(Me.WFRCHNGP_YearFromFilter) Then

                hasFiltersWFinRepNGP_HeadTableControl = True

                wc.iAND(WFinRepNGP_HeadTable.WFRCHNGP_Year, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.WFRCHNGP_YearFromFilter, Me.GetFromSession(Me.WFRCHNGP_YearFromFilter)), False, False)

            End If
            'wc.iAND(Sel_W_User_DYNAMICS_Company_FSView.W_U_User_Name, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString())
            'wc.iAND("WFRCHNGP_C_ID in (SELECT CompanyID FROM vw_wass_user_company where SSUC_SSU_UserName = '" & DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & "' and SSUC_APP_ID = '" & System.Configuration.ConfigurationManager.AppSettings.Item("WebApplicationID") & "' )")



            Return wc
        End Function


        ' Get the filters' data for WFRCHNGP_StatusFilter
        Protected Overrides Sub PopulateWFRCHNGP_StatusFilter(ByVal selectedValue As String, ByVal maxItems As Integer)

            'Setup the WHERE clause.

            Me.WFRCHNGP_StatusFilter.Items.Clear()
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WFRCHNGP_StatusFilter function.
            ' It is better to customize the where clause there.

            'Setup the WHERE clause.
            Dim wc As WhereClause = Me.CreateWhereClause_WFRCHNGP_StatusFilter()
            wc.iAND(WFin_ApprovalStatusTable.WPO_STAT_CD, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, "0")
            wc.iOR(WFin_ApprovalStatusTable.WPO_STAT_CD, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, "4")
            wc.iOR(WFin_ApprovalStatusTable.WPO_STAT_CD, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, "6")
            wc.iOR(WFin_ApprovalStatusTable.WPO_STAT_CD, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, "7")
            wc.iOR(WFin_ApprovalStatusTable.WPO_STAT_CD, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, "9")
            ' Setup the static list items        

            ' Add the All item.
            Me.WFRCHNGP_StatusFilter.Items.Insert(0, New ListItem(Me.Page.GetResourceValue("Please Select", "WebFS"), "--ANY--"))


            Dim orderBy As OrderBy = New OrderBy(False, False)
            orderBy.Add(WFin_ApprovalStatusTable.WPO_STAT_DESC, OrderByItem.OrderDir.Asc)

            Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)



            Dim noValueFormat As String = Page.GetResourceValue("Other", "WebFS")


            Dim itemValues() As WFin_ApprovalStatusRecord = Nothing

            If wc.RunQuery Then
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim evaluator As New FormulaEvaluator
                Dim listDuplicates As New ArrayList()



                Do

                    itemValues = WFin_ApprovalStatusTable.GetRecords(wc, orderBy, pageNum, maxItems)

                    For Each itemValue As WFin_ApprovalStatusRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WPO_STAT_CDSpecified Then
                            cvalue = itemValue.WPO_STAT_CD.ToString()

                            If counter < maxItems AndAlso Me.WFRCHNGP_StatusFilter.Items.FindByValue(cvalue) Is Nothing Then

                                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_HeadTable.WFRCHNGP_Status)
                                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_HeadTable.WFRCHNGP_Status.IsApplyDisplayAs Then
                                    fvalue = WFinRepNGP_HeadTable.GetDFKA(itemValue, WFinRepNGP_HeadTable.WFRCHNGP_Status)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                    fvalue = itemValue.Format(WFin_ApprovalStatusTable.WPO_STAT_CD)
                                End If

                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                    fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If (fvalue.Length > 50) Then
                                    fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.WFRCHNGP_StatusFilter.Items.FindByText(fvalue)

                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length, 38)) & ")"
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.WFRCHNGP_StatusFilter.Items.Add(newItem)

                                If listDuplicates.Contains(fvalue) Then
                                    newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length, 38)) & ")"
                                End If

                                counter += 1
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If



            ' Set the selected value.
            SetSelectedValue(Me.WFRCHNGP_StatusFilter, selectedValue)

        End Sub

        Public Overrides Function CreateOrderBy() As OrderBy
            ' The CurrentSortOrder is initialized to the sort order on the
            ' Query Wizard.  It may be modified by the Click handler for any of
            ' the column heading to sort or reverse sort by that column.
            ' You can add your own sort order, or modify it on the Query Wizard.
            Dim obC As OrderBy = New OrderBy(False, False)
            obC.Add(WFinRepNGP_HeadTable.WFRCHNGP_Year, OrderByItem.OrderDir.Desc)
            obC.Add(WFinRepNGP_HeadTable.WFRCHNGP_Month, OrderByItem.OrderDir.Asc)
            Return obC
        End Function


        Public Overrides Function CreateWhereClause_WFRCHNGP_C_IDFilter() As WhereClause

            Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False

            Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False

            Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False

            Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False

            ' Create a where clause for the filter WFRCHNGP_C_IDFilter.
            ' This function is called by the Populate method to load the items 
            ' in the WFRCHNGP_C_IDFilterDropDownList

            Dim wc As WhereClause = New WhereClause()
            Return wc

        End Function

        Protected Overrides Sub PopulateWFRCHNGP_C_IDFilter(ByVal selectedValue As String, ByVal maxItems As Integer)

            'Setup the WHERE clause.

            Me.WFRCHNGP_C_IDFilter.Items.Clear()
            Dim wc As WhereClause = Me.CreateWhereClause_WFRCHNGP_C_IDFilter()

            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WFRCHNGP_C_IDFilter function.
            ' It is better to customize the where clause there.

            ' Setup the static list items        

            ' Add the All item.
            Me.WFRCHNGP_C_IDFilter.Items.Insert(0, New ListItem(Me.Page.GetResourceValue("Please Select", "ePortalWFApproval"), "--ANY--"))


            Dim orderBy As OrderBy = New OrderBy(False, False)
            orderBy.Add(Vw_ANFLO_DW_CompanyNonGPView.ShortName, OrderByItem.OrderDir.Asc)
            orderBy.Add(Vw_ANFLO_DW_CompanyNonGPView.Name, OrderByItem.OrderDir.Asc)

            Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)



            Dim noValueFormat As String = Page.GetResourceValue("Txt:Other", "ePortalWFApproval")


            Dim itemValues() As Vw_ANFLO_DW_CompanyNonGPRecord = Nothing

            If wc.RunQuery Then
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim evaluator As New FormulaEvaluator
                Dim listDuplicates As New ArrayList()

                'Dim wherssouth As String = Nothing
                'If Not System.Web.HttpContext.Current.Session("UserName").ToString Is Nothing And Not System.Web.HttpContext.Current.Session("UserName").ToString = "" Then
                '    wherssouth = Sel_W_User_DYNAMICS_Company_FSView.W_U_User_Name.UniqueName & "='" & System.Web.HttpContext.Current.Session("UserName").ToString.Trim & "' AND " & Sel_W_User_DYNAMICS_Company_FSView.IsNonGP.UniqueName & "=1"
                'Else
                '    wherssouth = Sel_W_User_DYNAMICS_Company_FSView.W_U_User_Name.UniqueName & "="
                'End If
                'Dim obysouth As BaseClasses.Data.OrderBy = New OrderBy(False, False)
                'Dim waspsouth() As Sel_W_User_DYNAMICS_Company_FSRecord = Nothing
                'waspsouth = Sel_W_User_DYNAMICS_Company_FSView.GetRecords(wherssouth, obysouth)
                'For Each r As Sel_W_User_DYNAMICS_Company_FSRecord In waspsouth
                '    wc.iAND(Vw_ANFLO_DW_CompanyNonGPView.CompanyID, BaseFilter.ComparisonOperator.EqualsTo, r.Company_ID.ToString)
                'Next


                Do

                    itemValues = Vw_ANFLO_DW_CompanyNonGPView.GetRecords(wc, orderBy, pageNum, maxItems)

                    For Each itemValue As Vw_ANFLO_DW_CompanyNonGPRecord In itemValues
                        ' Create the item and add to the list.
                        'Dim cvalue As String = Nothing
                        'Dim fvalue As String = Nothing
                        'If itemValue.CompanyIDSpecified Then
                        '    cvalue = itemValue.CompanyID.ToString()

                        '    If counter < maxItems AndAlso Me.WFRCHNGP_C_IDFilter.Items.FindByValue(cvalue) Is Nothing Then

                        '        Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_HeadTable.WFRCHNGP_C_ID)
                        '        If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_HeadTable.WFRCHNGP_C_ID.IsApplyDisplayAs Then
                        '            fvalue = WFinRepNGP_HeadTable.GetDFKA(itemValue, WFinRepNGP_HeadTable.WFRCHNGP_C_ID)
                        '        End If
                        '        If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                        '            fvalue = itemValue.Format(Vw_ANFLO_DW_CompanyNonGPView.CompanyID)
                        '        End If

                        '        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                        '        If (IsNothing(fvalue)) Then
                        '            fvalue = ""
                        '        End If

                        '        fvalue = fvalue.Trim()

                        '        If (fvalue.Length > 50) Then
                        '            fvalue = fvalue.Substring(0, 50) & "..."
                        '        End If

                        '        Dim dupItem As ListItem = Me.WFRCHNGP_C_IDFilter.Items.FindByText(fvalue)

                        '        If Not IsNothing(dupItem) Then
                        '            listDuplicates.Add(fvalue)
                        '            If Not String.IsNullOrEmpty(dupItem.Value) Then
                        '                dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length, 38)) & ")"
                        '            End If
                        '        End If

                        '        Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                        '        Me.WFRCHNGP_C_IDFilter.Items.Add(newItem)

                        '        If listDuplicates.Contains(fvalue) AndAlso Not String.IsNullOrEmpty(cvalue) Then
                        '            newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length, 38)) & ")"
                        '        End If

                        '        counter += 1
                        '    End If
                        'End If

                        Dim cvalue As String = itemValue.CompanyID.ToString()
                        Dim fvalue As String = itemValue.Format(Vw_ANFLO_DW_CompanyNonGPView.ShortName)
                        Dim item As ListItem = New ListItem(fvalue, cvalue)
                        Dim wherssouth As String = Nothing
                        If Not System.Web.HttpContext.Current.Session("UserName").ToString Is Nothing And Not System.Web.HttpContext.Current.Session("UserName").ToString = "" Then
                            wherssouth = Sel_W_User_DYNAMICS_Company_FSView.W_U_User_Name.UniqueName & "='" & System.Web.HttpContext.Current.Session("UserName").ToString.Trim & "' AND " & Sel_W_User_DYNAMICS_Company_FSView.IsNonGP.UniqueName & "=1"
                        Else
                            wherssouth = Sel_W_User_DYNAMICS_Company_FSView.W_U_User_Name.UniqueName & "="
                        End If
                        Dim obysouth As BaseClasses.Data.OrderBy = New OrderBy(False, False)
                        Dim waspsouth() As Sel_W_User_DYNAMICS_Company_FSRecord = Nothing
                        waspsouth = Sel_W_User_DYNAMICS_Company_FSView.GetRecords(wherssouth, obysouth)
                        For Each r As Sel_W_User_DYNAMICS_Company_FSRecord In waspsouth
                            If r.Company_ID = itemValue.CompanyID Then
                                Me.WFRCHNGP_C_IDFilter.Items.Add(item)
                            End If
                        Next
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If

            If Not selectedValue Is Nothing AndAlso _
            selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.WFRCHNGP_C_IDFilter, selectedValue) Then
                'Dim fvalue As String = WFinRepNGP_DocAttachTable.WFRCDNGP_Company.Format(selectedValue)
                'Dim item As ListItem = New ListItem(fvalue, selectedValue)
                'item.Selected = True
                'Me.WFRCHNGP_C_IDFilter.Items.Insert(0, item)
            End If



            'Try

            '    ' Set the selected value.
            '    SetSelectedValue(Me.WFRCHNGP_C_IDFilter, selectedValue)

            'Catch
            'End Try


            'If Me.WFRCHNGP_C_IDFilter.SelectedValue IsNot Nothing AndAlso Me.WFRCHNGP_C_IDFilter.Items.FindByValue(Me.WFRCHNGP_C_IDFilter.SelectedValue) Is Nothing Then
            '    Me.WFRCHNGP_C_IDFilter.SelectedValue = Nothing
            'End If

        End Sub
    End Class






  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the WFinRepNGP_ActivityTableControlRow control on the WFinRepNGP_Inquiry page.
' Do not modify this class. Instead override any method in WFinRepNGP_ActivityTableControlRow.
Public Class BaseWFinRepNGP_ActivityTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WFinRepNGP_ActivityTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WFinRepNGP_ActivityTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WF%dbo.WFinRepNGP_Activity record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WFinRepNGP_ActivityTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWFinRepNGP_ActivityTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WFinRepNGP_ActivityRecord()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WFinRepNGP_ActivityTableControlRow.
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record.  To do this, it calls the Set methods for 
            ' each of the field displayed on the webpage.  It is better to make 
            ' changes in the Set methods, rather than making changes here.
            
            MyBase.DataBind()
            Me.ClearControlsFromSession()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
              
                Return
            End If
             
   
            'LoadData for DataSource for chart and report if they exist
          
            ' Store the checksum. The checksum is used to
            ' ensure the record was not changed by another user.
            If Not Me.DataSource.GetCheckSumValue() Is Nothing
                Me.CheckSum = Me.DataSource.GetCheckSumValue().Value
            End If
            
      
      
            ' Call the Set methods for each controls on the panel
        
                SetWFRNGPA_Date_Action()
                SetWFRNGPA_Date_Assign()
                SetWFRNGPA_Remark()
                SetWFRNGPA_Status()
                SetWFRNGPA_W_U_ID()
      
      
            Me.IsNewRecord = True
            
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
                
                If Me.DataSource.GetID IsNot Nothing Then
                    Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
                End If
                
            End If
            
            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
            
        End Sub
        
        
        Public Overridable Sub SetWFRNGPA_Date_Action()

                  
            
        
            ' Set the WFRNGPA_Date_Action Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Activity record retrieved from the database.
            ' Me.WFRNGPA_Date_Action is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRNGPA_Date_Action()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRNGPA_Date_ActionSpecified Then
                				
                ' If the WFRNGPA_Date_Action is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_ActivityTable.WFRNGPA_Date_Action, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRNGPA_Date_Action.Text = formattedValue
                
            Else 
            
                ' WFRNGPA_Date_Action is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRNGPA_Date_Action.Text = WFinRepNGP_ActivityTable.WFRNGPA_Date_Action.Format(WFinRepNGP_ActivityTable.WFRNGPA_Date_Action.DefaultValue, "g")
                        		
                End If
                 
            ' If the WFRNGPA_Date_Action is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRNGPA_Date_Action.Text Is Nothing _
                OrElse Me.WFRNGPA_Date_Action.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRNGPA_Date_Action.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWFRNGPA_Date_Assign()

                  
            
        
            ' Set the WFRNGPA_Date_Assign Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Activity record retrieved from the database.
            ' Me.WFRNGPA_Date_Assign is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRNGPA_Date_Assign()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRNGPA_Date_AssignSpecified Then
                				
                ' If the WFRNGPA_Date_Assign is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_ActivityTable.WFRNGPA_Date_Assign, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRNGPA_Date_Assign.Text = formattedValue
                
            Else 
            
                ' WFRNGPA_Date_Assign is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRNGPA_Date_Assign.Text = WFinRepNGP_ActivityTable.WFRNGPA_Date_Assign.Format(WFinRepNGP_ActivityTable.WFRNGPA_Date_Assign.DefaultValue, "g")
                        		
                End If
                 
            ' If the WFRNGPA_Date_Assign is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRNGPA_Date_Assign.Text Is Nothing _
                OrElse Me.WFRNGPA_Date_Assign.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRNGPA_Date_Assign.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWFRNGPA_Remark()

                  
            
        
            ' Set the WFRNGPA_Remark Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Activity record retrieved from the database.
            ' Me.WFRNGPA_Remark is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRNGPA_Remark()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRNGPA_RemarkSpecified Then
                				
                ' If the WFRNGPA_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_ActivityTable.WFRNGPA_Remark)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                If Not formattedValue is Nothing Then
                    Dim popupThreshold as Integer = CType(300, Integer)
                              
                    Dim maxLength as Integer = Len(formattedValue)
                    Dim originalLength As Integer = maxLength
                    If (maxLength >= CType(300, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(300, Integer)
                        'First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue)                       
                                      
                    End If
                                
                    ' For fields values larger than the PopupTheshold on Properties, display a popup.
                    If originalLength >= popupThreshold Then
                      
                        Dim name As String = HttpUtility.HtmlEncode(WFinRepNGP_ActivityTable.WFRNGPA_Remark.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ePortalWFApproval.Business.WFinRepNGP_ActivityTable, App_Code\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""WFRNGPA_Remark\"", \""WFRNGPA_Remark\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) & "\"", \""" & Page.GetResourceValue("Btn:Close", "ePortalWFApproval") & "\"", false, 200," _
                            & " 300, true, PopupDisplayWindowCallBackWith20);"", 500);'>" &  NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, Len(formattedValue))))
                      
                        If (maxLength = CType(300, Integer)) Then
                            formattedValue = formattedValue & "..." & "</a>"
                        Else
                            formattedValue = formattedValue & "</a>"
                        
                        End If
                    Else
                        If maxLength = CType(300, Integer) Then
                            formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,MaxLength))
                            formattedValue = formattedValue & "..."
                        
                        End If
                    End If
                End If  
                
                Me.WFRNGPA_Remark.Text = formattedValue
                
            Else 
            
                ' WFRNGPA_Remark is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRNGPA_Remark.Text = WFinRepNGP_ActivityTable.WFRNGPA_Remark.Format(WFinRepNGP_ActivityTable.WFRNGPA_Remark.DefaultValue)
                        		
                End If
                 
            ' If the WFRNGPA_Remark is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRNGPA_Remark.Text Is Nothing _
                OrElse Me.WFRNGPA_Remark.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRNGPA_Remark.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWFRNGPA_Status()

                  
            
        
            ' Set the WFRNGPA_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Activity record retrieved from the database.
            ' Me.WFRNGPA_Status is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRNGPA_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRNGPA_StatusSpecified Then
                				
                ' If the WFRNGPA_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_ActivityTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_ActivityTable.WFRNGPA_Status)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_ActivityTable.WFRNGPA_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRepNGP_ActivityTable.GetDFKA(Me.DataSource.WFRNGPA_Status.ToString(),WFinRepNGP_ActivityTable.WFRNGPA_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRepNGP_ActivityTable.WFRNGPA_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.WFRNGPA_Status.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRNGPA_Status.Text = formattedValue
                
            Else 
            
                ' WFRNGPA_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRNGPA_Status.Text = WFinRepNGP_ActivityTable.WFRNGPA_Status.Format(WFinRepNGP_ActivityTable.WFRNGPA_Status.DefaultValue)
                        		
                End If
                 
            ' If the WFRNGPA_Status is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRNGPA_Status.Text Is Nothing _
                OrElse Me.WFRNGPA_Status.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRNGPA_Status.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWFRNGPA_W_U_ID()

                  
            
        
            ' Set the WFRNGPA_W_U_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Activity record retrieved from the database.
            ' Me.WFRNGPA_W_U_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRNGPA_W_U_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRNGPA_W_U_IDSpecified Then
                				
                ' If the WFRNGPA_W_U_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_ActivityTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_ActivityTable.WFRNGPA_W_U_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_ActivityTable.WFRNGPA_W_U_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRepNGP_ActivityTable.GetDFKA(Me.DataSource.WFRNGPA_W_U_ID.ToString(),WFinRepNGP_ActivityTable.WFRNGPA_W_U_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRepNGP_ActivityTable.WFRNGPA_W_U_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WFRNGPA_W_U_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRNGPA_W_U_ID.Text = formattedValue
                
            Else 
            
                ' WFRNGPA_W_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRNGPA_W_U_ID.Text = WFinRepNGP_ActivityTable.WFRNGPA_W_U_ID.Format(WFinRepNGP_ActivityTable.WFRNGPA_W_U_ID.DefaultValue)
                        		
                End If
                 
            ' If the WFRNGPA_W_U_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRNGPA_W_U_ID.Text Is Nothing _
                OrElse Me.WFRNGPA_W_U_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRNGPA_W_U_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                

        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean, ByVal e As FormulaEvaluator) As String
            If e Is Nothing Then
                e = New FormulaEvaluator()
            End If
            
            e.Variables.Clear()

            
            ' add variables for formula evaluation
            If variables IsNot Nothing Then
                Dim enumerator As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) = variables.GetEnumerator()
                While enumerator.MoveNext()
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value)
                End While
            End If

            If includeDS
                
            End IF
            
            
            ' Other variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            If dataSourceForEvaluate Is Nothing Then

                e.DataSource = Me.DataSource

            Else
                e.DataSource = dataSourceForEvaluate
            End If

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If

            If Not String.IsNullOrEmpty(format) AndAlso (String.IsNullOrEmpty(formula) OrElse formula.IndexOf("Format(") < 0) Then
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function      
        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format,variables ,includeDS, Nothing)        
        End Function        

        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables ,True, Nothing)        
        End Function        

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e as FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS as Boolean) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
        End Function


        Public Overridable Sub RegisterPostback()       
        
        
        End Sub

      
        
        ' To customize, override this method in WFinRepNGP_ActivityTableControlRow.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
            ' The checksum is used to ensure the record was not changed by another user.
            If (Not Me.DataSource Is Nothing) AndAlso (Not Me.DataSource.GetCheckSumValue Is Nothing) Then
                If Not Me.CheckSum Is Nothing AndAlso Me.CheckSum <> Me.DataSource.GetCheckSumValue.Value Then
                    Throw New Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "ePortalWFApproval"))
                End If
            End If
        
        Dim parentCtrl As WFinRepNGP_HeadTableControlRow
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRepNGP_HeadTableControlRow"), WFinRepNGP_HeadTableControlRow)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ePortalWFApproval"))
            End If
            
            Me.DataSource.WFRNGPA_WFRCHNGP_ID = parentCtrl.DataSource.WFRCHNGP_ID
              
            ' 2. Perform any custom validation.
            Me.Validate()

            ' 3. Set the values in the record with data from UI controls.
            ' This calls the Get() method for each of the user interface controls.
            Me.GetUIData()

            ' 4. Save in the database.
            ' We should not save the record if the data did not change. This
            ' will save a database hit and avoid triggering any database triggers.
             
            If Me.DataSource.IsAnyValueChanged Then
                ' Save record to database but do not commit yet.
                ' Auto generated ids are available after saving for use by child (dependent) records.
                Me.DataSource.Save()
              
                DirectCast(GetParentControlObject(Me, "WFinRepNGP_ActivityTableControl"), WFinRepNGP_ActivityTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WFinRepNGP_ActivityTableControl"), WFinRepNGP_ActivityTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            Me.CheckSum = ""
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in WFinRepNGP_ActivityTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWFRNGPA_Date_Action()
            GetWFRNGPA_Date_Assign()
            GetWFRNGPA_Remark()
            GetWFRNGPA_Status()
            GetWFRNGPA_W_U_ID()
        End Sub
        
        
        Public Overridable Sub GetWFRNGPA_Date_Action()
            
        End Sub
                
        Public Overridable Sub GetWFRNGPA_Date_Assign()
            
        End Sub
                
        Public Overridable Sub GetWFRNGPA_Remark()
            
        End Sub
                
        Public Overridable Sub GetWFRNGPA_Status()
            
        End Sub
                
        Public Overridable Sub GetWFRNGPA_W_U_ID()
            
        End Sub
                
      
        ' To customize, override this method in WFinRepNGP_ActivityTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WFinRepNGP_ActivityTableControlRow.
        Public Overridable Sub Validate() 
            ' Add custom validation for any control within this panel.
            ' Example.  If you have a State ASP:Textbox control
            ' If Me.State.Text <> "CA" Then
            '    Throw New Exception("State must be CA (California).")
            ' End If

            ' The Validate method is common across all controls within
            ' this panel so you can validate multiple fields, but report
            ' one error message.
            
                
        End Sub

        Public Overridable Sub Delete()
        
            If Me.IsNewRecord() Then
                Return
            End If

            Dim pkValue As KeyValue = KeyValue.XmlToKey(Me.RecordUniqueId)
          WFinRepNGP_ActivityTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WFinRepNGP_ActivityTableControl"), WFinRepNGP_ActivityTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WFinRepNGP_ActivityTableControl"), WFinRepNGP_ActivityTableControl).ResetData = True
        End Sub

        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction()
                Me.RegisterPostback()

                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                  
                
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    Me.LoadData()
                    Me.DataBind()			
                End If
                                
                						
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction()
            End Try
        End Sub
        
            
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()
        
    
            'Save pagination state to session.
          
        End Sub
        
        
    
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

        

            ' Clear pagination state from session.
        
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)
            Dim isNewRecord As String = CType(ViewState("IsNewRecord"), String)
            If Not isNewRecord Is Nothing AndAlso isNewRecord.Trim <> "" Then
                Me.IsNewRecord = Boolean.Parse(isNewRecord)
            End If
            
            Dim myCheckSum As String = CType(ViewState("CheckSum"), String)
            If Not myCheckSum Is Nothing AndAlso myCheckSum.Trim <> "" Then
                Me.CheckSum = myCheckSum
            End If
            
    
            ' Load view state for pagination control.
                 
        End Sub

        Protected Overrides Function SaveViewState() As Object
            ViewState("IsNewRecord") = Me.IsNewRecord.ToString()
            ViewState("CheckSum") = Me.CheckSum
            
    
            ' Load view state for pagination control.
                  
            Return MyBase.SaveViewState()
        End Function
        
        
    
        ' Generate set method for buttons
        
   
        Private _PreviousUIData As New Hashtable
        Public Overridable Property PreviousUIData() As Hashtable
            Get
                Return _PreviousUIData
            End Get
            Set(ByVal value As Hashtable)
                _PreviousUIData = value
            End Set
        End Property   

        
        Public Property RecordUniqueId() As String
            Get
                Return CType(Me.ViewState("BaseWFinRepNGP_ActivityTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWFinRepNGP_ActivityTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WFinRepNGP_ActivityRecord
            Get
                Return DirectCast(MyBase._DataSource, WFinRepNGP_ActivityRecord)
            End Get
            Set(ByVal value As WFinRepNGP_ActivityRecord)
                Me._DataSource = value
            End Set
        End Property

        
        Private _checkSum As String
        Public Overridable Property CheckSum() As String
            Get
                Return Me._checkSum
            End Get
            Set(ByVal value As String)
                Me._checkSum = value
            End Set
        End Property
        
        Private _TotalPages As Integer
        Public Property TotalPages() As Integer
            Get
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property
        
        Private _PageIndex As Integer
        Public Property PageIndex() As Integer
            Get
                ' Return the PageIndex
                Return Me._PageIndex
            End Get
            Set(ByVal value As Integer)
                Me._PageIndex = value
            End Set
        End Property
    
        Private _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property
        
        

#Region "Helper Properties"
        
        Public ReadOnly Property WFRNGPA_Date_Action() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRNGPA_Date_Action"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRNGPA_Date_Assign() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRNGPA_Date_Assign"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRNGPA_Remark() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRNGPA_Remark"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRNGPA_Status() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRNGPA_Status"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRNGPA_W_U_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRNGPA_W_U_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
        
        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As WFinRepNGP_ActivityRecord = Nothing
             
        
            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.
                
            Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ePortalWFApproval"))
                    
            End If
            Return EvaluateExpressions(url, arg, rec, bEncrypt)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean,ByVal includeSession as Boolean) As String
            
            Dim rec As WFinRepNGP_ActivityRecord = Nothing
             
        
            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.
                
            Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ePortalWFApproval"))
                    
            End If
            If includeSession  Then
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            Else
                Return EvaluateExpressions(url, arg, rec, bEncrypt,False)  
            End If
        End Function

         
        Public Overridable Function GetRecord() As WFinRepNGP_ActivityRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WFinRepNGP_ActivityTable.GetRecord(Me.RecordUniqueId, True)
                
            End If
            
            ' Localization.
            
            Return Nothing
                
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

End Class

  

' Base class for the WFinRepNGP_ActivityTableControl control on the WFinRepNGP_Inquiry page.
' Do not modify this class. Instead override any method in WFinRepNGP_ActivityTableControl.
Public Class BaseWFinRepNGP_ActivityTableControl
        Inherits ePortalWFApproval.UI.BaseApplicationTableControl

        
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
    
           ' Setup the filter and search.
        

      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
         
            Else
                   
                Me.CurrentSortOrder = New OrderBy(True, False)
            
        End If

    

    ' Setup default pagination settings.
    
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
        
            
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
            ' Setup the pagination events.
            
              AddHandler Me.Pagination1.FirstPage.Click, AddressOf Pagination1_FirstPage_Click
                        
              AddHandler Me.Pagination1.LastPage.Click, AddressOf Pagination1_LastPage_Click
                        
              AddHandler Me.Pagination1.NextPage.Click, AddressOf Pagination1_NextPage_Click
                        
              AddHandler Me.Pagination1.PageSizeButton.Click, AddressOf Pagination1_PageSizeButton_Click
                        
              AddHandler Me.Pagination1.PreviousPage.Click, AddressOf Pagination1_PreviousPage_Click
                                    
            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.
          
            ' Setup the button events.
                  
        
          ' Setup events for others
                
        End Sub
        
        
        Public Overridable Sub LoadData()        
        
            ' Read data from database. Returns an array of records that can be assigned
            ' to the DataSource table control property.
            Try	
                Dim joinFilter As CompoundFilter = CreateCompoundJoinFilter()
                
                ' The WHERE clause will be empty when displaying all records in table.
                Dim wc As WhereClause = CreateWhereClause()
                If wc IsNot Nothing AndAlso Not wc.RunQuery Then
                    ' Initialize an empty array of records
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WFinRepNGP_ActivityRecord)), WFinRepNGP_ActivityRecord())
                    ' Add records to the list if needed.
                    Me.AddNewRecords()
                    Me._TotalRecords = 0
                    Me._TotalPages = 0
                    Return
                End If

                ' Call OrderBy to determine the order - either use the order defined
                ' on the Query Wizard, or specified by user (by clicking on column heading)
                Dim orderBy As OrderBy = CreateOrderBy()
                
                ' Get the pagesize from the pagesize control.
                Me.GetPageSize()
                               
                If Me.DisplayLastPage Then
                    Dim totalRecords As Integer = If(Me._TotalRecords < 0, GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()), Me._TotalRecords)
                     
                      Dim totalPages As Integer = CInt(Math.Ceiling(totalRecords / Me.PageSize))
                    
                    Me.PageIndex = totalPages - 1
                End If                               
                
                ' Make sure PageIndex (current page) and PageSize are within bounds.
                If Me.PageIndex < 0 Then
                    Me.PageIndex = 0
                End If
                If Me.PageSize < 1 Then
                    Me.PageSize = 1
                End If
                
                ' Retrieve the records and set the table DataSource.
                ' Only PageSize records are fetched starting at PageIndex (zero based).
                If Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                    Dim postdata As New ArrayList
                    For Each rc As WFinRepNGP_ActivityTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WFinRepNGP_ActivityRecord)), WFinRepNGP_ActivityRecord())
                Else  ' Get the records from the database	
                      
                        Me.DataSource = GetRecords(joinFilter, wc, orderBy, Me.PageIndex, Me.PageSize)
                      
                End If
                
                ' if the datasource contains no records contained in database, then load the last page.
                If (DbUtils.GetCreatedRecords(Me.DataSource).Length = 0 AndAlso Not Me.DisplayLastPage) Then
                      Me.DisplayLastPage = True
                      LoadData()
                Else
                
                    ' Add any new rows desired by the user.
                    Me.AddNewRecords()
                       

                    ' Initialize the page and grand totals. now
                
                End If
    
            Catch ex As Exception
                ' Report the error message to the end user
                Dim msg As String = ex.Message
                If ex.InnerException IsNot Nothing Then
                    msg = msg & " InnerException: " & ex.InnerException.Message
                End If
                Throw New Exception(msg, ex.InnerException)
            End Try
        End Sub
        
        Public Overridable Function GetRecords( _
            ByVal join As BaseFilter, _
            ByVal where As WhereClause, _
            ByVal orderBy As OrderBy, _
            ByVal pageIndex As Integer, _
            ByVal pageSize As Integer) As WFinRepNGP_ActivityRecord()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRepNGP_ActivityTable.Column1, True)         
            ' selCols.Add(WFinRepNGP_ActivityTable.Column2, True)          
            ' selCols.Add(WFinRepNGP_ActivityTable.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WFinRepNGP_ActivityTable.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WFinRepNGP_ActivityTable
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WFinRepNGP_ActivityRecord)), WFinRepNGP_ActivityRecord())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRepNGP_ActivityTable.Column1, True)         
            ' selCols.Add(WFinRepNGP_ActivityTable.Column2, True)          
            ' selCols.Add(WFinRepNGP_ActivityTable.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WFinRepNGP_ActivityTable.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WFinRepNGP_ActivityTable
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)           
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
                
                Return CInt(databaseTable.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
            End If

        End Function        
        
      
    
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record for each row in the table.  To do this, it calls the
            ' DataBind for each of the rows.
            ' DataBind also populates any filters above the table, and sets the pagination
            ' control to the correct number of records and the current page number.
            
            
              MyBase.DataBind()
            
    
            Me.ClearControlsFromSession()    

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
            
            'LoadData for DataSource for chart and report if they exist
          
          ' Improve performance by prefetching display as records.
          Me.PreFetchForeignKeyValues()
             
            ' Setup the pagination controls.
            BindPaginationControls()

      

    
        
          ' Bind the repeater with the list of records to expand the UI.
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_ActivityTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WFinRepNGP_ActivityTableControlRow = DirectCast(repItem.FindControl("WFinRepNGP_ActivityTableControlRow"), WFinRepNGP_ActivityTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                
                SetWFRNGPA_Date_ActionLabel()
                SetWFRNGPA_Date_AssignLabel()
                SetWFRNGPA_RemarkLabel()
                SetWFRNGPA_StatusLabel()
                SetWFRNGPA_W_U_IDLabel()
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                
      
            ' this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls()
            
                    
            
      End Sub
      
        Public Overridable Sub SetFormulaControls()
            ' this method calls Set methods for the control that has special formula
        
        

    End Sub

    
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(WFinRepNGP_ActivityTable.WFRNGPA_Status, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRepNGP_ActivityTable.WFRNGPA_W_U_ID, Me.DataSource)
          
          End Sub
        
      
        Public Overridable Sub RegisterPostback()
        
        
        End Sub

        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean, ByVal e as FormulaEvaluator) As String
            If e Is Nothing
                e = New FormulaEvaluator()
            End If
            
            e.Variables.Clear()
            
            
            ' add variables for formula evaluation
            If variables IsNot Nothing Then
                Dim enumerator As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) = variables.GetEnumerator()
                While enumerator.MoveNext()
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value)
                End While
            End If
            
            If includeDS
                
            End If
            
            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If
            
            If Not String.IsNullOrEmpty(format) AndAlso (String.IsNullOrEmpty(formula) OrElse formula.IndexOf("Format(") < 0) Then
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function			

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format,variables ,includeDS, Nothing)        
        End Function        

        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables ,True, Nothing)        
        End Function        

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e as FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS as Boolean) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
        End Function




        Public Overridable Sub ResetControl()

            
            Me.CurrentSortOrder.Reset()
            If (Me.InSession(Me, "Order_By")) Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
                
            End If
                
            Me.PageIndex = 0
        End Sub

        Public Overridable Sub ResetPageControl()
            Me.PageIndex = 0
        End Sub
        
        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the pagination labels.
        
            If DbUtils.GetCreatedRecords(Me.DataSource).Length > 0 Then                      
                    
                Me.Pagination1.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Pagination1.CurrentPage.Text = "0"
            End If
            Me.Pagination1.PageSize.Text = Me.PageSize.ToString()
            Me.Pagination1.TotalItems.Text = Me.TotalRecords.ToString()
            Me.Pagination1.TotalPages.Text = Me.TotalPages.ToString()

            ' Bind the buttons for WFinRepNGP_ActivityTableControl pagination.
        
            Me.Pagination1.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination1.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination1.LastPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination1.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination1.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination1.NextPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination1.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            Me.Pagination1.PreviousPage.Enabled = Not (Me.PageIndex = 0)


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As WFinRepNGP_ActivityTableControlRow
            For Each recCtl In Me.GetRecordControls()
        
                If Me.InDeletedRecordIds(recCtl) Then
                    ' Delete any pending deletes. 
                    recCtl.Delete()
                Else
                    If recCtl.Visible Then
                        recCtl.SaveData()
                    End If
                End If
          
            Next
            
            
          
    
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
          
            ' Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            For Each recCtl In Me.GetRecordControls()
                recCtl.IsNewRecord = False
            Next
    
      
            ' Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            Me.DeletedRecordIds = Nothing
      
        End Sub

        Public Overridable Function CreateCompoundJoinFilter() As CompoundFilter
            Dim jFilter As CompoundFilter = New CompoundFilter()
         
            Return jFilter
        End Function

      
          Public Overridable Function CreateOrderBy() As OrderBy
          ' The CurrentSortOrder is initialized to the sort order on the
          ' Query Wizard.  It may be modified by the Click handler for any of
          ' the column heading to sort or reverse sort by that column.
          ' You can add your own sort order, or modify it on the Query Wizard.
          Return Me.CurrentSortOrder
          End Function
      
        Public Overridable Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            WFinRepNGP_ActivityTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
        Dim wFinRepNGP_HeadRecordObj as KeyValue
        wFinRepNGP_HeadRecordObj = Nothing
      
              Dim wFinRepNGP_HeadTableControlObjRow As WFinRepNGP_HeadTableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRepNGP_HeadTableControlRow") ,WFinRepNGP_HeadTableControlRow)
            
                If (Not IsNothing(wFinRepNGP_HeadTableControlObjRow) AndAlso Not IsNothing(wFinRepNGP_HeadTableControlObjRow.GetRecord()) AndAlso Not IsNothing(wFinRepNGP_HeadTableControlObjRow.GetRecord().WFRCHNGP_ID))
                    wc.iAND(WFinRepNGP_ActivityTable.WFRNGPA_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, wFinRepNGP_HeadTableControlObjRow.GetRecord().WFRCHNGP_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If
              
      HttpContext.Current.Session("WFinRepNGP_ActivityTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WFinRepNGP_ActivityTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWFinRepNGP_HeadTableControl as String = DirectCast(HttpContext.Current.Session("WFinRepNGP_ActivityTableControlWhereClause"), String)
            
            If Not selectedRecordInWFinRepNGP_HeadTableControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWFinRepNGP_HeadTableControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWFinRepNGP_HeadTableControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(WFinRepNGP_ActivityTable.WFRNGPA_WFRCHNGP_ID) Then
            wc.iAND(WFinRepNGP_ActivityTable.WFRNGPA_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(WFinRepNGP_ActivityTable.WFRNGPA_WFRCHNGP_ID).ToString())
       End If
      
            End If
          
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
      
      
            Return wc
        End Function

      

         Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                         ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                         ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                         ByVal resultList As ArrayList) As Boolean
              Return FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText, _
                                       autoTypeAheadSearch, AutoTypeAheadWordSeparators, _
                                       resultList, False)
         End Function

        Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                               ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                               ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                               ByVal resultList As ArrayList, ByVal stripHTML As Boolean) As Boolean
            If stripHTML Then
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText)
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem)
            End If
            'Formats the resultItem and adds it to the list of suggestions.
            Dim index As Integer = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))
            Dim itemToAdd As String = ""
            Dim isFound As Boolean = False
            Dim isAdded As Boolean = False
            ' Get the index where prfixt is at the beginning of resultItem. If not found then, index of word which begins with prefixText.
            If InvariantLCase(autoTypeAheadSearch).equals("wordsstartingwithsearchstring") And Not index = 0 Then
                ' Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex(AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                If regex1.IsMatch(resultItem) Then
                    index = regex1.Match(resultItem).Index
                    isFound = True
                End If
                ' If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                If Not resultItem(index).ToString() = " " Then
                    ' Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    If regex.IsMatch(resultItem) Then
                        index = regex.Match(resultItem).Index
                        isFound = True
                    End If
                End If
            End If

            ' If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            ' beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            If index = 0 Or isFound Or InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") Then
                If InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atbeginningofmatchedstring") Then
                    ' Expression to find beginning of the word which contains prefixText
                    Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    '  Find the beginning of the word which contains prefexText
                    If (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") AndAlso regex1.IsMatch(resultItem)) Then
                        index = regex1.Match(resultItem).Index
                        isFound = True
                    End If
                    ' Display string from the index till end of the string if sub string from index till end is less than columnLength value.
                    If Len(resultItem) - index <= columnLength Then
                        If index = 0 Then
                            itemToAdd = resultItem
                        Else                            
                            itemToAdd = resultItem.Substring(index)
                        End If
                    Else                       
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward)
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("inmiddleofmatchedstring") Then
                    Dim subStringBeginIndex As Integer = CType(columnLength / 2, Integer)
                    If Len(resultItem) <= columnLength Then
                        itemToAdd = resultItem
                    Else
                        ' Sanity check at end of the string
                        If index + Len(prefixText) >= Len(resultItem) - 1 OrElse _
                        Len(resultItem) - index < subStringBeginIndex Then                           
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, Len(resultItem) - 1 - columnLength, Len(resultItem) - 1, StringUtils.Direction.backward)
                        ElseIf index <= subStringBeginIndex Then
                            ' Sanity check at beginning of the string                          
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward)
                        Else
                            ' Display string containing text before the prefixText occures and text after the prefixText                         
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both)
                        End If
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atendofmatchedstring") Then
                    ' Expression to find ending of the word which contains prefexText
                    Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    ' Find the ending of the word which contains prefexText
                    If regex1.IsMatch(resultItem, index + 1) Then
                        index = regex1.Match(resultItem, index + 1).Index
                    Else
                        ' If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length
                    End If
                    If index > Len(resultItem) Then
                        index = Len(resultItem)
                    End If
                    ' If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    If index <= columnLength Then
                        itemToAdd = resultItem.Substring(0, index)
                    Else
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward)
                    End If
                End If

                ' Remove newline character from itemToAdd
                Dim prefixTextIndex As Integer = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase)
                If prefixTextIndex < 0 Then Return False
                ' If itemToAdd contains any newline after the search text then show text only till newline
                Dim regex2 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                Dim newLineIndexAfterPrefix As Integer = -1
                If regex2.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexAfterPrefix > -1) Then
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix)
                End If
                ' If itemToAdd contains any newline before search text then show text which comes after newline
                Dim regex3 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", (System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.RightToLeft))
                Dim newLineIndexBeforePrefix As Integer = -1
                If regex3.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexBeforePrefix > -1) Then
                    itemToAdd = itemToAdd.Substring((newLineIndexBeforePrefix + regex3.Match(itemToAdd, prefixTextIndex).Length))
                End If

                If Not String.IsNullOrEmpty(itemToAdd) AndAlso Not resultList.Contains(itemToAdd) Then
                   
                    resultList.Add(itemToAdd)
          				
                    isAdded = True
                End If
            End If
            Return isAdded
        End Function
        
    
        Protected Overridable Sub GetPageSize()
        
            If Me.Pagination1.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.Pagination1.PageSize.Text)
                Catch ex As Exception
                End Try
            End If
        End Sub

        Protected Overridable Sub AddNewRecords()
          
            Dim newRecordList As ArrayList = New ArrayList()
          
    Dim newUIDataList As System.Collections.Generic.List(Of Hashtable) = New System.Collections.Generic.List(Of Hashtable)()

    ' Loop though all the record controls and if the record control
    ' does not have a unique record id set, then create a record
    ' and add to the list.
    If Not Me.ResetData Then
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_ActivityTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WFinRepNGP_ActivityTableControlRow = DirectCast(repItem.FindControl("WFinRepNGP_ActivityTableControlRow"), WFinRepNGP_ActivityTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WFinRepNGP_ActivityRecord = New WFinRepNGP_ActivityRecord()
        
                        If recControl.WFRNGPA_Date_Action.Text <> "" Then
                            rec.Parse(recControl.WFRNGPA_Date_Action.Text, WFinRepNGP_ActivityTable.WFRNGPA_Date_Action)
                        End If
                        If recControl.WFRNGPA_Date_Assign.Text <> "" Then
                            rec.Parse(recControl.WFRNGPA_Date_Assign.Text, WFinRepNGP_ActivityTable.WFRNGPA_Date_Assign)
                        End If
                        If recControl.WFRNGPA_Remark.Text <> "" Then
                            rec.Parse(recControl.WFRNGPA_Remark.Text, WFinRepNGP_ActivityTable.WFRNGPA_Remark)
                        End If
                        If recControl.WFRNGPA_Status.Text <> "" Then
                            rec.Parse(recControl.WFRNGPA_Status.Text, WFinRepNGP_ActivityTable.WFRNGPA_Status)
                        End If
                        If recControl.WFRNGPA_W_U_ID.Text <> "" Then
                            rec.Parse(recControl.WFRNGPA_W_U_ID.Text, WFinRepNGP_ActivityTable.WFRNGPA_W_U_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WFinRepNGP_ActivityRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WFinRepNGP_ActivityRecord)), WFinRepNGP_ActivityRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WFinRepNGP_ActivityTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WFinRepNGP_ActivityTableControlRow) As Boolean
            If Me.DeletedRecordIds Is Nothing OrElse Me.DeletedRecordIds.Trim = "" Then
                Return False
            End If

            Return Me.DeletedRecordIds.IndexOf("[" & rec.RecordUniqueId & "]") >= 0
        End Function

        Private _DeletedRecordIds As String
        Public Property DeletedRecordIds() As String
            Get
                Return Me._DeletedRecordIds
            End Get
            Set(ByVal value As String)
                Me._DeletedRecordIds = value
            End Set
        End Property
        
      
        ' Create Set, WhereClause, and Populate Methods
        
        Public Overridable Sub SetWFRNGPA_Date_ActionLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRNGPA_Date_ActionLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRNGPA_Date_AssignLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRNGPA_Date_AssignLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRNGPA_RemarkLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRNGPA_RemarkLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRNGPA_StatusLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRNGPA_StatusLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRNGPA_W_U_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRNGPA_W_U_IDLabel.Text = "Some value"
                    
                  End Sub
                

    
    
        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction
                Me.RegisterPostback()
                
                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                  
                
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    
                    Me.LoadData()
                    Me.DataBind()
                    
                End If
                
               
                				
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
        End Sub
        
        
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()

            ' Save filter controls to values to session.
        
        
            'Save pagination state to session.
         
            
            ' Save table control properties to the session.
            
 If Not Me.CurrentSortOrder Is Nothing Then
                If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then
                    Me.SaveToSession(Me, "Order_By", Me.CurrentSortOrder.ToXmlString())
                End If
            End If            
            Me.SaveToSession(Me, "Page_Index", Me.PageIndex.ToString())
            Me.SaveToSession(Me, "Page_Size", Me.PageSize.ToString())
        
            Me.SaveToSession(Me, "DeletedRecordIds", Me.DeletedRecordIds)  
        
        End Sub
        
        Protected  Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.
          
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("WFinRepNGP_ActivityTableControl_OrderBy"), String)
          
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            
            Else 
                Me.CurrentSortOrder = New OrderBy(True, False)
            
            End If
            
            
            Dim Pagination As Control = Me.FindControl("Pagination1")
             Dim PaginationType As String = ""
             If Not (Pagination Is Nothing) Then
                Dim Summary As Control = Pagination.FindControl("_Summary")
                If Not (Summary Is Nothing) Then
                    If (DirectCast(Summary, System.Web.UI.WebControls.TextBox).Text.Equals("Infinite Pagination")) Then
                        PaginationType = "Infinite Pagination"
                    End If
                    If (DirectCast(Summary, System.Web.UI.WebControls.TextBox).Text.Equals("Infinite Pagination Mobile")) Then
                        PaginationType = "Infinite Pagination Mobile"
                End If
             End If
             End If

            If Not (PaginationType.Equals("Infinite Pagination")) Then 
              If Not Me.Page.ClientQueryString.Contains("InfiIframe") AndAlso PaginationType.Equals("Infinite Pagination Mobile") Then
                    Me.ViewState("Page_Index") = 0
                End If
              Dim pageIndex As String = CType(ViewState("Page_Index"), String)
              If pageIndex IsNot Nothing Then
                Me.PageIndex = CInt(pageIndex)
              End If
            End If

            Dim pageSize As String = CType(ViewState("Page_Size"), String)
            If Not pageSize Is Nothing Then
              Me.PageSize = CInt(pageSize)
            End If

            
    
            ' Load view state for pagination control.
        
            Me.DeletedRecordIds = CType(Me.ViewState("DeletedRecordIds"), String)
        
        End Sub

        Protected Overrides Function SaveViewState() As Object
          
            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("WFinRepNGP_ActivityTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function
        
        ' Generate set method for buttons
                

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination1_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            Me.PageIndex = 0
            Me.DataChanged = True
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination1_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            Me.DisplayLastPage = True
            Me.DataChanged = True
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination1_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            Me.PageIndex += 1
            Me.DataChanged = True
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for LinkButton
        Public Overridable Sub Pagination1_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Me.DataChanged = True
      
            Me.PageSize = Me.Pagination1.GetCurrentPageSize()
      
            Me.PageIndex = Integer.Parse(Me.Pagination1.CurrentPage.Text) - 1
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination1_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            If Me.PageIndex > 0 Then
                Me.PageIndex -= 1
                Me.DataChanged = True
            End If
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        

        ' Generate the event handling functions for sorting events.
        

        ' Generate the event handling functions for button events.
        
      

        ' Generate the event handling functions for filter and search events.
        
    
        ' Generate the event handling functions for others
        
      


        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = WFinRepNGP_ActivityTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
                End If
                Return Me._TotalRecords
            End Get
            Set(ByVal value As Integer)
                If Me.PageSize > 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(value / Me.PageSize))
                  
                End If
                Me._TotalRecords = value
            End Set
        End Property

        
    
        Protected _TotalPages As Integer = -1
        Public Property TotalPages() As Integer
            Get
                If _TotalPages < 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(TotalRecords / Me.PageSize))
                  
                End If                
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property

        Protected _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property


          
        Private _CurrentSortOrder As OrderBy = Nothing
        Public Property CurrentSortOrder() As OrderBy
            Get
                Return Me._CurrentSortOrder
            End Get
            Set(ByVal value As BaseClasses.Data.OrderBy)
                Me._CurrentSortOrder = value
            End Set
        End Property
        
        Public Property DataSource() As WFinRepNGP_ActivityRecord ()
            Get
                Return DirectCast(MyBase._DataSource, WFinRepNGP_ActivityRecord())
            End Get
            Set(ByVal value() As WFinRepNGP_ActivityRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property Pagination1() As ePortalWFApproval.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pagination1"), ePortalWFApproval.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property WFRNGPA_Date_ActionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRNGPA_Date_ActionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRNGPA_Date_AssignLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRNGPA_Date_AssignLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRNGPA_RemarkLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRNGPA_RemarkLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRNGPA_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRNGPA_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRNGPA_W_U_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRNGPA_W_U_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"
        
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
      
      
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me,includeSession)
        End Function
        
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As WFinRepNGP_ActivityTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRepNGP_ActivityRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
        
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As WFinRepNGP_ActivityTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRepNGP_ActivityRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                If includeSession then
                    Return EvaluateExpressions(url, arg, rec, bEncrypt)
                Else
                    Return EvaluateExpressions(url, arg, rec, bEncrypt,False)
                End If
            End If
            Return url
        End Function
        
          
        Public Overridable Function GetSelectedRecordControl() As WFinRepNGP_ActivityTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WFinRepNGP_ActivityTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WFinRepNGP_ActivityTableControlRow)), WFinRepNGP_ActivityTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WFinRepNGP_ActivityTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WFinRepNGP_ActivityTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                Else
                
                    recCtl.Delete()
                    
                    ' Setting the DataChanged to True results in the page being refreshed with
                    ' the most recent data from the database.  This happens in PreRender event
                    ' based on the current sort, search and filter criteria.
                    Me.DataChanged = True
                    Me.ResetData = True
                  
                End If
            Next
        End Sub

        Public Overridable Function GetRecordControls() As WFinRepNGP_ActivityTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WFinRepNGP_ActivityTableControlRow")
            Dim list As New List(Of WFinRepNGP_ActivityTableControlRow)
            For Each recCtrl As WFinRepNGP_ActivityTableControlRow In recCtrls
                list.Add(recCtrl)
            Next
            Return list.ToArray()
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property
                


#End Region



End Class

  
' Base class for the WFinRepNGP_AttachmentTableControlRow control on the WFinRepNGP_Inquiry page.
' Do not modify this class. Instead override any method in WFinRepNGP_AttachmentTableControlRow.
Public Class BaseWFinRepNGP_AttachmentTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WFinRepNGP_AttachmentTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WFinRepNGP_AttachmentTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WF%dbo.WFinRepNGP_Attachment record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WFinRepNGP_AttachmentTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWFinRepNGP_AttachmentTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WFinRepNGP_AttachmentRecord()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WFinRepNGP_AttachmentTableControlRow.
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record.  To do this, it calls the Set methods for 
            ' each of the field displayed on the webpage.  It is better to make 
            ' changes in the Set methods, rather than making changes here.
            
            MyBase.DataBind()
            Me.ClearControlsFromSession()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
              
                Return
            End If
             
   
            'LoadData for DataSource for chart and report if they exist
          
            ' Store the checksum. The checksum is used to
            ' ensure the record was not changed by another user.
            If Not Me.DataSource.GetCheckSumValue() Is Nothing
                Me.CheckSum = Me.DataSource.GetCheckSumValue().Value
            End If
            
      
      
            ' Call the Set methods for each controls on the panel
        
                SetWFRNGPAt_Desc()
                SetWFRNGPAt_Doc()
      
      
            Me.IsNewRecord = True
            
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
                
                If Me.DataSource.GetID IsNot Nothing Then
                    Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
                End If
                
            End If
            
            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
            
        End Sub
        
        
        Public Overridable Sub SetWFRNGPAt_Desc()

                  
            
        
            ' Set the WFRNGPAt_Desc Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Attachment database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Attachment record retrieved from the database.
            ' Me.WFRNGPAt_Desc is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRNGPAt_Desc()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRNGPAt_DescSpecified Then
                				
                ' If the WFRNGPAt_Desc is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_AttachmentTable.WFRNGPAt_Desc)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRNGPAt_Desc.Text = formattedValue
                
            Else 
            
                ' WFRNGPAt_Desc is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRNGPAt_Desc.Text = WFinRepNGP_AttachmentTable.WFRNGPAt_Desc.Format(WFinRepNGP_AttachmentTable.WFRNGPAt_Desc.DefaultValue)
                        		
                End If
                 
            ' If the WFRNGPAt_Desc is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRNGPAt_Desc.Text Is Nothing _
                OrElse Me.WFRNGPAt_Desc.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRNGPAt_Desc.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWFRNGPAt_Doc()

                  
                
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRNGPAt_DocSpecified Then
                
                Me.WFRNGPAt_Doc.Text = Page.GetResourceValue("Txt:OpenFile", "ePortalWFApproval")
                        
                Me.WFRNGPAt_Doc.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WFinRepNGP_Attachment") & _
                            "&Field=" & Me.Page.Encrypt("WFRNGPAt_Doc") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"
                   
                Me.WFRNGPAt_Doc.Visible = True
            Else
                Me.WFRNGPAt_Doc.Visible = False
            End If
        End Sub
                

        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean, ByVal e As FormulaEvaluator) As String
            If e Is Nothing Then
                e = New FormulaEvaluator()
            End If
            
            e.Variables.Clear()

            
            ' add variables for formula evaluation
            If variables IsNot Nothing Then
                Dim enumerator As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) = variables.GetEnumerator()
                While enumerator.MoveNext()
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value)
                End While
            End If

            If includeDS
                
            End IF
            
            
            ' Other variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            If dataSourceForEvaluate Is Nothing Then

                e.DataSource = Me.DataSource

            Else
                e.DataSource = dataSourceForEvaluate
            End If

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If

            If Not String.IsNullOrEmpty(format) AndAlso (String.IsNullOrEmpty(formula) OrElse formula.IndexOf("Format(") < 0) Then
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function      
        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format,variables ,includeDS, Nothing)        
        End Function        

        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables ,True, Nothing)        
        End Function        

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e as FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS as Boolean) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
        End Function


        Public Overridable Sub RegisterPostback()       
        
        
        End Sub

      
        
        ' To customize, override this method in WFinRepNGP_AttachmentTableControlRow.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
            ' The checksum is used to ensure the record was not changed by another user.
            If (Not Me.DataSource Is Nothing) AndAlso (Not Me.DataSource.GetCheckSumValue Is Nothing) Then
                If Not Me.CheckSum Is Nothing AndAlso Me.CheckSum <> Me.DataSource.GetCheckSumValue.Value Then
                    Throw New Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "ePortalWFApproval"))
                End If
            End If
        
        Dim parentCtrl As WFinRepNGP_HeadTableControlRow
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRepNGP_HeadTableControlRow"), WFinRepNGP_HeadTableControlRow)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ePortalWFApproval"))
            End If
            
            Me.DataSource.WFRNGPAt_WFRCHNGP_ID = parentCtrl.DataSource.WFRCHNGP_ID
              
            ' 2. Perform any custom validation.
            Me.Validate()

            ' 3. Set the values in the record with data from UI controls.
            ' This calls the Get() method for each of the user interface controls.
            Me.GetUIData()

            ' 4. Save in the database.
            ' We should not save the record if the data did not change. This
            ' will save a database hit and avoid triggering any database triggers.
             
            If Me.DataSource.IsAnyValueChanged Then
                ' Save record to database but do not commit yet.
                ' Auto generated ids are available after saving for use by child (dependent) records.
                Me.DataSource.Save()
              
                DirectCast(GetParentControlObject(Me, "WFinRepNGP_AttachmentTableControl"), WFinRepNGP_AttachmentTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WFinRepNGP_AttachmentTableControl"), WFinRepNGP_AttachmentTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            Me.CheckSum = ""
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in WFinRepNGP_AttachmentTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWFRNGPAt_Desc()
        End Sub
        
        
        Public Overridable Sub GetWFRNGPAt_Desc()
            
        End Sub
                
      
        ' To customize, override this method in WFinRepNGP_AttachmentTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WFinRepNGP_AttachmentTableControlRow.
        Public Overridable Sub Validate() 
            ' Add custom validation for any control within this panel.
            ' Example.  If you have a State ASP:Textbox control
            ' If Me.State.Text <> "CA" Then
            '    Throw New Exception("State must be CA (California).")
            ' End If

            ' The Validate method is common across all controls within
            ' this panel so you can validate multiple fields, but report
            ' one error message.
            
                
        End Sub

        Public Overridable Sub Delete()
        
            If Me.IsNewRecord() Then
                Return
            End If

            Dim pkValue As KeyValue = KeyValue.XmlToKey(Me.RecordUniqueId)
          WFinRepNGP_AttachmentTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WFinRepNGP_AttachmentTableControl"), WFinRepNGP_AttachmentTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WFinRepNGP_AttachmentTableControl"), WFinRepNGP_AttachmentTableControl).ResetData = True
        End Sub

        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction()
                Me.RegisterPostback()

                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                  
                
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    Me.LoadData()
                    Me.DataBind()			
                End If
                                
                						
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction()
            End Try
        End Sub
        
            
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()
        
    
            'Save pagination state to session.
          
        End Sub
        
        
    
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

        

            ' Clear pagination state from session.
        
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)
            Dim isNewRecord As String = CType(ViewState("IsNewRecord"), String)
            If Not isNewRecord Is Nothing AndAlso isNewRecord.Trim <> "" Then
                Me.IsNewRecord = Boolean.Parse(isNewRecord)
            End If
            
            Dim myCheckSum As String = CType(ViewState("CheckSum"), String)
            If Not myCheckSum Is Nothing AndAlso myCheckSum.Trim <> "" Then
                Me.CheckSum = myCheckSum
            End If
            
    
            ' Load view state for pagination control.
                 
        End Sub

        Protected Overrides Function SaveViewState() As Object
            ViewState("IsNewRecord") = Me.IsNewRecord.ToString()
            ViewState("CheckSum") = Me.CheckSum
            
    
            ' Load view state for pagination control.
                  
            Return MyBase.SaveViewState()
        End Function
        
        
    
        ' Generate set method for buttons
        
   
        Private _PreviousUIData As New Hashtable
        Public Overridable Property PreviousUIData() As Hashtable
            Get
                Return _PreviousUIData
            End Get
            Set(ByVal value As Hashtable)
                _PreviousUIData = value
            End Set
        End Property   

        
        Public Property RecordUniqueId() As String
            Get
                Return CType(Me.ViewState("BaseWFinRepNGP_AttachmentTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWFinRepNGP_AttachmentTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WFinRepNGP_AttachmentRecord
            Get
                Return DirectCast(MyBase._DataSource, WFinRepNGP_AttachmentRecord)
            End Get
            Set(ByVal value As WFinRepNGP_AttachmentRecord)
                Me._DataSource = value
            End Set
        End Property

        
        Private _checkSum As String
        Public Overridable Property CheckSum() As String
            Get
                Return Me._checkSum
            End Get
            Set(ByVal value As String)
                Me._checkSum = value
            End Set
        End Property
        
        Private _TotalPages As Integer
        Public Property TotalPages() As Integer
            Get
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property
        
        Private _PageIndex As Integer
        Public Property PageIndex() As Integer
            Get
                ' Return the PageIndex
                Return Me._PageIndex
            End Get
            Set(ByVal value As Integer)
                Me._PageIndex = value
            End Set
        End Property
    
        Private _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property
        
        

#Region "Helper Properties"
        
        Public ReadOnly Property WFRNGPAt_Desc() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRNGPAt_Desc"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRNGPAt_Doc() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRNGPAt_Doc"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
        
        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As WFinRepNGP_AttachmentRecord = Nothing
             
        
            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.
                
            Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ePortalWFApproval"))
                    
            End If
            Return EvaluateExpressions(url, arg, rec, bEncrypt)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean,ByVal includeSession as Boolean) As String
            
            Dim rec As WFinRepNGP_AttachmentRecord = Nothing
             
        
            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.
                
            Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ePortalWFApproval"))
                    
            End If
            If includeSession  Then
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            Else
                Return EvaluateExpressions(url, arg, rec, bEncrypt,False)  
            End If
        End Function

         
        Public Overridable Function GetRecord() As WFinRepNGP_AttachmentRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WFinRepNGP_AttachmentTable.GetRecord(Me.RecordUniqueId, True)
                
            End If
            
            ' Localization.
            
            Return Nothing
                
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

End Class

  

' Base class for the WFinRepNGP_AttachmentTableControl control on the WFinRepNGP_Inquiry page.
' Do not modify this class. Instead override any method in WFinRepNGP_AttachmentTableControl.
Public Class BaseWFinRepNGP_AttachmentTableControl
        Inherits ePortalWFApproval.UI.BaseApplicationTableControl

        
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
    
           ' Setup the filter and search.
        

      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
         
            Else
                   
                Me.CurrentSortOrder = New OrderBy(True, False)
            
        End If

    

    ' Setup default pagination settings.
    
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
        
            
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
            ' Setup the pagination events.
            
              AddHandler Me.Pagination2.FirstPage.Click, AddressOf Pagination2_FirstPage_Click
                        
              AddHandler Me.Pagination2.LastPage.Click, AddressOf Pagination2_LastPage_Click
                        
              AddHandler Me.Pagination2.NextPage.Click, AddressOf Pagination2_NextPage_Click
                        
              AddHandler Me.Pagination2.PageSizeButton.Click, AddressOf Pagination2_PageSizeButton_Click
                        
              AddHandler Me.Pagination2.PreviousPage.Click, AddressOf Pagination2_PreviousPage_Click
                                    
            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.
          
            ' Setup the button events.
                  
        
          ' Setup events for others
                
        End Sub
        
        
        Public Overridable Sub LoadData()        
        
            ' Read data from database. Returns an array of records that can be assigned
            ' to the DataSource table control property.
            Try	
                Dim joinFilter As CompoundFilter = CreateCompoundJoinFilter()
                
                ' The WHERE clause will be empty when displaying all records in table.
                Dim wc As WhereClause = CreateWhereClause()
                If wc IsNot Nothing AndAlso Not wc.RunQuery Then
                    ' Initialize an empty array of records
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WFinRepNGP_AttachmentRecord)), WFinRepNGP_AttachmentRecord())
                    ' Add records to the list if needed.
                    Me.AddNewRecords()
                    Me._TotalRecords = 0
                    Me._TotalPages = 0
                    Return
                End If

                ' Call OrderBy to determine the order - either use the order defined
                ' on the Query Wizard, or specified by user (by clicking on column heading)
                Dim orderBy As OrderBy = CreateOrderBy()
                
                ' Get the pagesize from the pagesize control.
                Me.GetPageSize()
                               
                If Me.DisplayLastPage Then
                    Dim totalRecords As Integer = If(Me._TotalRecords < 0, GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()), Me._TotalRecords)
                     
                      Dim totalPages As Integer = CInt(Math.Ceiling(totalRecords / Me.PageSize))
                    
                    Me.PageIndex = totalPages - 1
                End If                               
                
                ' Make sure PageIndex (current page) and PageSize are within bounds.
                If Me.PageIndex < 0 Then
                    Me.PageIndex = 0
                End If
                If Me.PageSize < 1 Then
                    Me.PageSize = 1
                End If
                
                ' Retrieve the records and set the table DataSource.
                ' Only PageSize records are fetched starting at PageIndex (zero based).
                If Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                    Dim postdata As New ArrayList
                    For Each rc As WFinRepNGP_AttachmentTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WFinRepNGP_AttachmentRecord)), WFinRepNGP_AttachmentRecord())
                Else  ' Get the records from the database	
                      
                        Me.DataSource = GetRecords(joinFilter, wc, orderBy, Me.PageIndex, Me.PageSize)
                      
                End If
                
                ' if the datasource contains no records contained in database, then load the last page.
                If (DbUtils.GetCreatedRecords(Me.DataSource).Length = 0 AndAlso Not Me.DisplayLastPage) Then
                      Me.DisplayLastPage = True
                      LoadData()
                Else
                
                    ' Add any new rows desired by the user.
                    Me.AddNewRecords()
                       

                    ' Initialize the page and grand totals. now
                
                End If
    
            Catch ex As Exception
                ' Report the error message to the end user
                Dim msg As String = ex.Message
                If ex.InnerException IsNot Nothing Then
                    msg = msg & " InnerException: " & ex.InnerException.Message
                End If
                Throw New Exception(msg, ex.InnerException)
            End Try
        End Sub
        
        Public Overridable Function GetRecords( _
            ByVal join As BaseFilter, _
            ByVal where As WhereClause, _
            ByVal orderBy As OrderBy, _
            ByVal pageIndex As Integer, _
            ByVal pageSize As Integer) As WFinRepNGP_AttachmentRecord()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRepNGP_AttachmentTable.Column1, True)         
            ' selCols.Add(WFinRepNGP_AttachmentTable.Column2, True)          
            ' selCols.Add(WFinRepNGP_AttachmentTable.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WFinRepNGP_AttachmentTable.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WFinRepNGP_AttachmentTable
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WFinRepNGP_AttachmentRecord)), WFinRepNGP_AttachmentRecord())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRepNGP_AttachmentTable.Column1, True)         
            ' selCols.Add(WFinRepNGP_AttachmentTable.Column2, True)          
            ' selCols.Add(WFinRepNGP_AttachmentTable.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WFinRepNGP_AttachmentTable.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WFinRepNGP_AttachmentTable
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)           
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
                
                Return CInt(databaseTable.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
            End If

        End Function        
        
      
    
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record for each row in the table.  To do this, it calls the
            ' DataBind for each of the rows.
            ' DataBind also populates any filters above the table, and sets the pagination
            ' control to the correct number of records and the current page number.
            
            
              MyBase.DataBind()
            
    
            Me.ClearControlsFromSession()    

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
            
            'LoadData for DataSource for chart and report if they exist
               
            ' Setup the pagination controls.
            BindPaginationControls()

      

    
        
          ' Bind the repeater with the list of records to expand the UI.
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_AttachmentTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WFinRepNGP_AttachmentTableControlRow = DirectCast(repItem.FindControl("WFinRepNGP_AttachmentTableControlRow"), WFinRepNGP_AttachmentTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                
                SetWFRNGPAt_DescLabel()
                SetWFRNGPAt_DocLabel()
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                
      
            ' this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls()
            
                    
            
      End Sub
      
        Public Overridable Sub SetFormulaControls()
            ' this method calls Set methods for the control that has special formula
        
        

    End Sub

    
      
        Public Overridable Sub RegisterPostback()
        
        
        End Sub

        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean, ByVal e as FormulaEvaluator) As String
            If e Is Nothing
                e = New FormulaEvaluator()
            End If
            
            e.Variables.Clear()
            
            
            ' add variables for formula evaluation
            If variables IsNot Nothing Then
                Dim enumerator As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) = variables.GetEnumerator()
                While enumerator.MoveNext()
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value)
                End While
            End If
            
            If includeDS
                
            End If
            
            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If
            
            If Not String.IsNullOrEmpty(format) AndAlso (String.IsNullOrEmpty(formula) OrElse formula.IndexOf("Format(") < 0) Then
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function			

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format,variables ,includeDS, Nothing)        
        End Function        

        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables ,True, Nothing)        
        End Function        

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e as FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS as Boolean) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
        End Function




        Public Overridable Sub ResetControl()

            
            Me.CurrentSortOrder.Reset()
            If (Me.InSession(Me, "Order_By")) Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
                
            End If
                
            Me.PageIndex = 0
        End Sub

        Public Overridable Sub ResetPageControl()
            Me.PageIndex = 0
        End Sub
        
        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the pagination labels.
        
            If DbUtils.GetCreatedRecords(Me.DataSource).Length > 0 Then                      
                    
                Me.Pagination2.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Pagination2.CurrentPage.Text = "0"
            End If
            Me.Pagination2.PageSize.Text = Me.PageSize.ToString()
            Me.Pagination2.TotalItems.Text = Me.TotalRecords.ToString()
            Me.Pagination2.TotalPages.Text = Me.TotalPages.ToString()

            ' Bind the buttons for WFinRepNGP_AttachmentTableControl pagination.
        
            Me.Pagination2.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination2.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination2.LastPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination2.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination2.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination2.NextPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination2.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            Me.Pagination2.PreviousPage.Enabled = Not (Me.PageIndex = 0)


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As WFinRepNGP_AttachmentTableControlRow
            For Each recCtl In Me.GetRecordControls()
        
                If Me.InDeletedRecordIds(recCtl) Then
                    ' Delete any pending deletes. 
                    recCtl.Delete()
                Else
                    If recCtl.Visible Then
                        recCtl.SaveData()
                    End If
                End If
          
            Next
            
            
          
    
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
          
            ' Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            For Each recCtl In Me.GetRecordControls()
                recCtl.IsNewRecord = False
            Next
    
      
            ' Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            Me.DeletedRecordIds = Nothing
      
        End Sub

        Public Overridable Function CreateCompoundJoinFilter() As CompoundFilter
            Dim jFilter As CompoundFilter = New CompoundFilter()
         
            Return jFilter
        End Function

      
          Public Overridable Function CreateOrderBy() As OrderBy
          ' The CurrentSortOrder is initialized to the sort order on the
          ' Query Wizard.  It may be modified by the Click handler for any of
          ' the column heading to sort or reverse sort by that column.
          ' You can add your own sort order, or modify it on the Query Wizard.
          Return Me.CurrentSortOrder
          End Function
      
        Public Overridable Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            WFinRepNGP_AttachmentTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
        Dim wFinRepNGP_HeadRecordObj as KeyValue
        wFinRepNGP_HeadRecordObj = Nothing
      
              Dim wFinRepNGP_HeadTableControlObjRow As WFinRepNGP_HeadTableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRepNGP_HeadTableControlRow") ,WFinRepNGP_HeadTableControlRow)
            
                If (Not IsNothing(wFinRepNGP_HeadTableControlObjRow) AndAlso Not IsNothing(wFinRepNGP_HeadTableControlObjRow.GetRecord()) AndAlso Not IsNothing(wFinRepNGP_HeadTableControlObjRow.GetRecord().WFRCHNGP_ID))
                    wc.iAND(WFinRepNGP_AttachmentTable.WFRNGPAt_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, wFinRepNGP_HeadTableControlObjRow.GetRecord().WFRCHNGP_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If
              
      HttpContext.Current.Session("WFinRepNGP_AttachmentTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WFinRepNGP_AttachmentTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWFinRepNGP_HeadTableControl as String = DirectCast(HttpContext.Current.Session("WFinRepNGP_AttachmentTableControlWhereClause"), String)
            
            If Not selectedRecordInWFinRepNGP_HeadTableControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWFinRepNGP_HeadTableControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWFinRepNGP_HeadTableControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(WFinRepNGP_AttachmentTable.WFRNGPAt_WFRCHNGP_ID) Then
            wc.iAND(WFinRepNGP_AttachmentTable.WFRNGPAt_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(WFinRepNGP_AttachmentTable.WFRNGPAt_WFRCHNGP_ID).ToString())
       End If
      
            End If
          
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
      
      
            Return wc
        End Function

      

         Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                         ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                         ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                         ByVal resultList As ArrayList) As Boolean
              Return FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText, _
                                       autoTypeAheadSearch, AutoTypeAheadWordSeparators, _
                                       resultList, False)
         End Function

        Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                               ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                               ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                               ByVal resultList As ArrayList, ByVal stripHTML As Boolean) As Boolean
            If stripHTML Then
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText)
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem)
            End If
            'Formats the resultItem and adds it to the list of suggestions.
            Dim index As Integer = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))
            Dim itemToAdd As String = ""
            Dim isFound As Boolean = False
            Dim isAdded As Boolean = False
            ' Get the index where prfixt is at the beginning of resultItem. If not found then, index of word which begins with prefixText.
            If InvariantLCase(autoTypeAheadSearch).equals("wordsstartingwithsearchstring") And Not index = 0 Then
                ' Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex(AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                If regex1.IsMatch(resultItem) Then
                    index = regex1.Match(resultItem).Index
                    isFound = True
                End If
                ' If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                If Not resultItem(index).ToString() = " " Then
                    ' Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    If regex.IsMatch(resultItem) Then
                        index = regex.Match(resultItem).Index
                        isFound = True
                    End If
                End If
            End If

            ' If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            ' beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            If index = 0 Or isFound Or InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") Then
                If InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atbeginningofmatchedstring") Then
                    ' Expression to find beginning of the word which contains prefixText
                    Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    '  Find the beginning of the word which contains prefexText
                    If (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") AndAlso regex1.IsMatch(resultItem)) Then
                        index = regex1.Match(resultItem).Index
                        isFound = True
                    End If
                    ' Display string from the index till end of the string if sub string from index till end is less than columnLength value.
                    If Len(resultItem) - index <= columnLength Then
                        If index = 0 Then
                            itemToAdd = resultItem
                        Else                            
                            itemToAdd = resultItem.Substring(index)
                        End If
                    Else                       
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward)
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("inmiddleofmatchedstring") Then
                    Dim subStringBeginIndex As Integer = CType(columnLength / 2, Integer)
                    If Len(resultItem) <= columnLength Then
                        itemToAdd = resultItem
                    Else
                        ' Sanity check at end of the string
                        If index + Len(prefixText) >= Len(resultItem) - 1 OrElse _
                        Len(resultItem) - index < subStringBeginIndex Then                           
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, Len(resultItem) - 1 - columnLength, Len(resultItem) - 1, StringUtils.Direction.backward)
                        ElseIf index <= subStringBeginIndex Then
                            ' Sanity check at beginning of the string                          
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward)
                        Else
                            ' Display string containing text before the prefixText occures and text after the prefixText                         
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both)
                        End If
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atendofmatchedstring") Then
                    ' Expression to find ending of the word which contains prefexText
                    Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    ' Find the ending of the word which contains prefexText
                    If regex1.IsMatch(resultItem, index + 1) Then
                        index = regex1.Match(resultItem, index + 1).Index
                    Else
                        ' If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length
                    End If
                    If index > Len(resultItem) Then
                        index = Len(resultItem)
                    End If
                    ' If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    If index <= columnLength Then
                        itemToAdd = resultItem.Substring(0, index)
                    Else
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward)
                    End If
                End If

                ' Remove newline character from itemToAdd
                Dim prefixTextIndex As Integer = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase)
                If prefixTextIndex < 0 Then Return False
                ' If itemToAdd contains any newline after the search text then show text only till newline
                Dim regex2 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                Dim newLineIndexAfterPrefix As Integer = -1
                If regex2.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexAfterPrefix > -1) Then
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix)
                End If
                ' If itemToAdd contains any newline before search text then show text which comes after newline
                Dim regex3 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", (System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.RightToLeft))
                Dim newLineIndexBeforePrefix As Integer = -1
                If regex3.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexBeforePrefix > -1) Then
                    itemToAdd = itemToAdd.Substring((newLineIndexBeforePrefix + regex3.Match(itemToAdd, prefixTextIndex).Length))
                End If

                If Not String.IsNullOrEmpty(itemToAdd) AndAlso Not resultList.Contains(itemToAdd) Then
                   
                    resultList.Add(itemToAdd)
          				
                    isAdded = True
                End If
            End If
            Return isAdded
        End Function
        
    
        Protected Overridable Sub GetPageSize()
        
            If Me.Pagination2.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.Pagination2.PageSize.Text)
                Catch ex As Exception
                End Try
            End If
        End Sub

        Protected Overridable Sub AddNewRecords()
          
            Dim newRecordList As ArrayList = New ArrayList()
          
    Dim newUIDataList As System.Collections.Generic.List(Of Hashtable) = New System.Collections.Generic.List(Of Hashtable)()

    ' Loop though all the record controls and if the record control
    ' does not have a unique record id set, then create a record
    ' and add to the list.
    If Not Me.ResetData Then
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_AttachmentTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WFinRepNGP_AttachmentTableControlRow = DirectCast(repItem.FindControl("WFinRepNGP_AttachmentTableControlRow"), WFinRepNGP_AttachmentTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WFinRepNGP_AttachmentRecord = New WFinRepNGP_AttachmentRecord()
        
                        If recControl.WFRNGPAt_Desc.Text <> "" Then
                            rec.Parse(recControl.WFRNGPAt_Desc.Text, WFinRepNGP_AttachmentTable.WFRNGPAt_Desc)
                        End If
                        If recControl.WFRNGPAt_Doc.Text <> "" Then
                            rec.Parse(recControl.WFRNGPAt_Doc.Text, WFinRepNGP_AttachmentTable.WFRNGPAt_Doc)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WFinRepNGP_AttachmentRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WFinRepNGP_AttachmentRecord)), WFinRepNGP_AttachmentRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WFinRepNGP_AttachmentTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WFinRepNGP_AttachmentTableControlRow) As Boolean
            If Me.DeletedRecordIds Is Nothing OrElse Me.DeletedRecordIds.Trim = "" Then
                Return False
            End If

            Return Me.DeletedRecordIds.IndexOf("[" & rec.RecordUniqueId & "]") >= 0
        End Function

        Private _DeletedRecordIds As String
        Public Property DeletedRecordIds() As String
            Get
                Return Me._DeletedRecordIds
            End Get
            Set(ByVal value As String)
                Me._DeletedRecordIds = value
            End Set
        End Property
        
      
        ' Create Set, WhereClause, and Populate Methods
        
        Public Overridable Sub SetWFRNGPAt_DescLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRNGPAt_DescLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRNGPAt_DocLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRNGPAt_DocLabel.Text = "Some value"
                    
                  End Sub
                

    
    
        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction
                Me.RegisterPostback()
                
                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                  
                
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    
                    Me.LoadData()
                    Me.DataBind()
                    
                End If
                
               
                				
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
        End Sub
        
        
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()

            ' Save filter controls to values to session.
        
        
            'Save pagination state to session.
         
            
            ' Save table control properties to the session.
            
 If Not Me.CurrentSortOrder Is Nothing Then
                If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then
                    Me.SaveToSession(Me, "Order_By", Me.CurrentSortOrder.ToXmlString())
                End If
            End If            
            Me.SaveToSession(Me, "Page_Index", Me.PageIndex.ToString())
            Me.SaveToSession(Me, "Page_Size", Me.PageSize.ToString())
        
            Me.SaveToSession(Me, "DeletedRecordIds", Me.DeletedRecordIds)  
        
        End Sub
        
        Protected  Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.
          
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("WFinRepNGP_AttachmentTableControl_OrderBy"), String)
          
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            
            Else 
                Me.CurrentSortOrder = New OrderBy(True, False)
            
            End If
            
            
            Dim Pagination As Control = Me.FindControl("Pagination2")
             Dim PaginationType As String = ""
             If Not (Pagination Is Nothing) Then
                Dim Summary As Control = Pagination.FindControl("_Summary")
                If Not (Summary Is Nothing) Then
                    If (DirectCast(Summary, System.Web.UI.WebControls.TextBox).Text.Equals("Infinite Pagination")) Then
                        PaginationType = "Infinite Pagination"
                    End If
                    If (DirectCast(Summary, System.Web.UI.WebControls.TextBox).Text.Equals("Infinite Pagination Mobile")) Then
                        PaginationType = "Infinite Pagination Mobile"
                End If
             End If
             End If

            If Not (PaginationType.Equals("Infinite Pagination")) Then 
              If Not Me.Page.ClientQueryString.Contains("InfiIframe") AndAlso PaginationType.Equals("Infinite Pagination Mobile") Then
                    Me.ViewState("Page_Index") = 0
                End If
              Dim pageIndex As String = CType(ViewState("Page_Index"), String)
              If pageIndex IsNot Nothing Then
                Me.PageIndex = CInt(pageIndex)
              End If
            End If

            Dim pageSize As String = CType(ViewState("Page_Size"), String)
            If Not pageSize Is Nothing Then
              Me.PageSize = CInt(pageSize)
            End If

            
    
            ' Load view state for pagination control.
        
            Me.DeletedRecordIds = CType(Me.ViewState("DeletedRecordIds"), String)
        
        End Sub

        Protected Overrides Function SaveViewState() As Object
          
            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("WFinRepNGP_AttachmentTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function
        
        ' Generate set method for buttons
                

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination2_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            Me.PageIndex = 0
            Me.DataChanged = True
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination2_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            Me.DisplayLastPage = True
            Me.DataChanged = True
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination2_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            Me.PageIndex += 1
            Me.DataChanged = True
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for LinkButton
        Public Overridable Sub Pagination2_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Me.DataChanged = True
      
            Me.PageSize = Me.Pagination2.GetCurrentPageSize()
      
            Me.PageIndex = Integer.Parse(Me.Pagination2.CurrentPage.Text) - 1
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination2_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            If Me.PageIndex > 0 Then
                Me.PageIndex -= 1
                Me.DataChanged = True
            End If
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        

        ' Generate the event handling functions for sorting events.
        

        ' Generate the event handling functions for button events.
        
      

        ' Generate the event handling functions for filter and search events.
        
    
        ' Generate the event handling functions for others
        
      


        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = WFinRepNGP_AttachmentTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
                End If
                Return Me._TotalRecords
            End Get
            Set(ByVal value As Integer)
                If Me.PageSize > 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(value / Me.PageSize))
                  
                End If
                Me._TotalRecords = value
            End Set
        End Property

        
    
        Protected _TotalPages As Integer = -1
        Public Property TotalPages() As Integer
            Get
                If _TotalPages < 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(TotalRecords / Me.PageSize))
                  
                End If                
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property

        Protected _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property


          
        Private _CurrentSortOrder As OrderBy = Nothing
        Public Property CurrentSortOrder() As OrderBy
            Get
                Return Me._CurrentSortOrder
            End Get
            Set(ByVal value As BaseClasses.Data.OrderBy)
                Me._CurrentSortOrder = value
            End Set
        End Property
        
        Public Property DataSource() As WFinRepNGP_AttachmentRecord ()
            Get
                Return DirectCast(MyBase._DataSource, WFinRepNGP_AttachmentRecord())
            End Get
            Set(ByVal value() As WFinRepNGP_AttachmentRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property Pagination2() As ePortalWFApproval.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pagination2"), ePortalWFApproval.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property WFRNGPAt_DescLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRNGPAt_DescLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRNGPAt_DocLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRNGPAt_DocLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"
        
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
      
      
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me,includeSession)
        End Function
        
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As WFinRepNGP_AttachmentTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRepNGP_AttachmentRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
        
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As WFinRepNGP_AttachmentTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRepNGP_AttachmentRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                If includeSession then
                    Return EvaluateExpressions(url, arg, rec, bEncrypt)
                Else
                    Return EvaluateExpressions(url, arg, rec, bEncrypt,False)
                End If
            End If
            Return url
        End Function
        
          
        Public Overridable Function GetSelectedRecordControl() As WFinRepNGP_AttachmentTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WFinRepNGP_AttachmentTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WFinRepNGP_AttachmentTableControlRow)), WFinRepNGP_AttachmentTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WFinRepNGP_AttachmentTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WFinRepNGP_AttachmentTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                Else
                
                    recCtl.Delete()
                    
                    ' Setting the DataChanged to True results in the page being refreshed with
                    ' the most recent data from the database.  This happens in PreRender event
                    ' based on the current sort, search and filter criteria.
                    Me.DataChanged = True
                    Me.ResetData = True
                  
                End If
            Next
        End Sub

        Public Overridable Function GetRecordControls() As WFinRepNGP_AttachmentTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WFinRepNGP_AttachmentTableControlRow")
            Dim list As New List(Of WFinRepNGP_AttachmentTableControlRow)
            For Each recCtrl As WFinRepNGP_AttachmentTableControlRow In recCtrls
                list.Add(recCtrl)
            Next
            Return list.ToArray()
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property
                


#End Region



End Class

  
' Base class for the WFinRepNGP_DocAttachTableControlRow control on the WFinRepNGP_Inquiry page.
' Do not modify this class. Instead override any method in WFinRepNGP_DocAttachTableControlRow.
Public Class BaseWFinRepNGP_DocAttachTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WFinRepNGP_DocAttachTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WFinRepNGP_DocAttachTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
              AddHandler Me.btnPreview.Button.Click, AddressOf btnPreview_Click
                        
              AddHandler Me.WFRCDNGP_Company.TextChanged, AddressOf WFRCDNGP_Company_TextChanged
            
              AddHandler Me.WFRCDNGP_File1.TextChanged, AddressOf WFRCDNGP_File1_TextChanged
            
              AddHandler Me.WFRCDNGP_Month.TextChanged, AddressOf WFRCDNGP_Month_TextChanged
            
              AddHandler Me.WFRCDNGP_Status.TextChanged, AddressOf WFRCDNGP_Status_TextChanged
            
              AddHandler Me.WFRCDNGP_Type1.TextChanged, AddressOf WFRCDNGP_Type1_TextChanged
            
              AddHandler Me.WFRCDNGP_WFRCHNGP_ID.TextChanged, AddressOf WFRCDNGP_WFRCHNGP_ID_TextChanged
            
              AddHandler Me.WFRCDNGP_Year.TextChanged, AddressOf WFRCDNGP_Year_TextChanged
            
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WF%dbo.WFinRepNGP_DocAttach record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WFinRepNGP_DocAttachTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWFinRepNGP_DocAttachTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WFinRepNGP_DocAttachRecord()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WFinRepNGP_DocAttachTableControlRow.
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record.  To do this, it calls the Set methods for 
            ' each of the field displayed on the webpage.  It is better to make 
            ' changes in the Set methods, rather than making changes here.
            
            MyBase.DataBind()
            Me.ClearControlsFromSession()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
              
                Return
            End If
             
   
            'LoadData for DataSource for chart and report if they exist
          
            ' Store the checksum. The checksum is used to
            ' ensure the record was not changed by another user.
            If Not Me.DataSource.GetCheckSumValue() Is Nothing
                Me.CheckSum = Me.DataSource.GetCheckSumValue().Value
            End If
            
      
      
            ' Call the Set methods for each controls on the panel
        
                
                SetWFRCDNGP_Company()
                SetWFRCDNGP_File1()
                SetWFRCDNGP_Month()
                SetWFRCDNGP_RWRem()
                SetWFRCDNGP_Status()
                SetWFRCDNGP_Type()
                SetWFRCDNGP_Type1()
                SetWFRCDNGP_WFRCHNGP_ID()
                SetWFRCDNGP_Year()
                SetbtnPreview()
              
      
      
            Me.IsNewRecord = True
            
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
                
                If Me.DataSource.GetID IsNot Nothing Then
                    Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
                End If
                
            End If
            
            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
            
        End Sub
        
        
        Public Overridable Sub SetWFRCDNGP_Company()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCDNGP_Company.ID) Then
            
                Me.WFRCDNGP_Company.Text = Me.PreviousUIData(Me.WFRCDNGP_Company.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCDNGP_Company TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_DocAttach record retrieved from the database.
            ' Me.WFRCDNGP_Company is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCDNGP_Company()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCDNGP_CompanySpecified Then
                				
                ' If the WFRCDNGP_Company is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_DocAttachTable.WFRCDNGP_Company)
                              
                Me.WFRCDNGP_Company.Text = formattedValue
                
            Else 
            
                ' WFRCDNGP_Company is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCDNGP_Company.Text = WFinRepNGP_DocAttachTable.WFRCDNGP_Company.Format(WFinRepNGP_DocAttachTable.WFRCDNGP_Company.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCDNGP_Company.TextChanged, AddressOf WFRCDNGP_Company_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCDNGP_File1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCDNGP_File1.ID) Then
            
                Me.WFRCDNGP_File1.Text = Me.PreviousUIData(Me.WFRCDNGP_File1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCDNGP_File1 TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_DocAttach record retrieved from the database.
            ' Me.WFRCDNGP_File1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCDNGP_File1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCDNGP_File1Specified Then
                				
                ' If the WFRCDNGP_File1 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_DocAttachTable.WFRCDNGP_File1)
                              
                Me.WFRCDNGP_File1.Text = formattedValue
                
            Else 
            
                ' WFRCDNGP_File1 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCDNGP_File1.Text = WFinRepNGP_DocAttachTable.WFRCDNGP_File1.Format(WFinRepNGP_DocAttachTable.WFRCDNGP_File1.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCDNGP_File1.TextChanged, AddressOf WFRCDNGP_File1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCDNGP_Month()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCDNGP_Month.ID) Then
            
                Me.WFRCDNGP_Month.Text = Me.PreviousUIData(Me.WFRCDNGP_Month.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCDNGP_Month TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_DocAttach record retrieved from the database.
            ' Me.WFRCDNGP_Month is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCDNGP_Month()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCDNGP_MonthSpecified Then
                				
                ' If the WFRCDNGP_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_DocAttachTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_DocAttachTable.WFRCDNGP_Month)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_DocAttachTable.WFRCDNGP_Month.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRepNGP_DocAttachTable.GetDFKA(Me.DataSource.WFRCDNGP_Month.ToString(),WFinRepNGP_DocAttachTable.WFRCDNGP_Month, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRepNGP_DocAttachTable.WFRCDNGP_Month)
                       End If
                Else
                       formattedValue = Me.DataSource.WFRCDNGP_Month.ToString()
                End If
                                
                Me.WFRCDNGP_Month.Text = formattedValue
                
            Else 
            
                ' WFRCDNGP_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCDNGP_Month.Text = WFinRepNGP_DocAttachTable.WFRCDNGP_Month.Format(WFinRepNGP_DocAttachTable.WFRCDNGP_Month.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCDNGP_Month.TextChanged, AddressOf WFRCDNGP_Month_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCDNGP_RWRem()

                  
            
        
            ' Set the WFRCDNGP_RWRem Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_DocAttach record retrieved from the database.
            ' Me.WFRCDNGP_RWRem is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCDNGP_RWRem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCDNGP_RWRemSpecified Then
                				
                ' If the WFRCDNGP_RWRem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_DocAttachTable.WFRCDNGP_RWRem)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCDNGP_RWRem.Text = formattedValue
                
            Else 
            
                ' WFRCDNGP_RWRem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCDNGP_RWRem.Text = WFinRepNGP_DocAttachTable.WFRCDNGP_RWRem.Format(WFinRepNGP_DocAttachTable.WFRCDNGP_RWRem.DefaultValue)
                        		
                End If
                 
            ' If the WFRCDNGP_RWRem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRCDNGP_RWRem.Text Is Nothing _
                OrElse Me.WFRCDNGP_RWRem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRCDNGP_RWRem.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWFRCDNGP_Status()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCDNGP_Status.ID) Then
            
                Me.WFRCDNGP_Status.Text = Me.PreviousUIData(Me.WFRCDNGP_Status.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCDNGP_Status TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_DocAttach record retrieved from the database.
            ' Me.WFRCDNGP_Status is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCDNGP_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCDNGP_StatusSpecified Then
                				
                ' If the WFRCDNGP_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_DocAttachTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_DocAttachTable.WFRCDNGP_Status)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_DocAttachTable.WFRCDNGP_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRepNGP_DocAttachTable.GetDFKA(Me.DataSource.WFRCDNGP_Status.ToString(),WFinRepNGP_DocAttachTable.WFRCDNGP_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRepNGP_DocAttachTable.WFRCDNGP_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.WFRCDNGP_Status.ToString()
                End If
                                
                Me.WFRCDNGP_Status.Text = formattedValue
                
            Else 
            
                ' WFRCDNGP_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCDNGP_Status.Text = WFinRepNGP_DocAttachTable.WFRCDNGP_Status.Format(WFinRepNGP_DocAttachTable.WFRCDNGP_Status.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCDNGP_Status.TextChanged, AddressOf WFRCDNGP_Status_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCDNGP_Type()

                  
            
        
            ' Set the WFRCDNGP_Type Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_DocAttach record retrieved from the database.
            ' Me.WFRCDNGP_Type is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCDNGP_Type()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCDNGP_TypeSpecified Then
                				
                ' If the WFRCDNGP_Type is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_DocAttachTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_DocAttachTable.WFRCDNGP_Type)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_DocAttachTable.WFRCDNGP_Type.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRepNGP_DocAttachTable.GetDFKA(Me.DataSource.WFRCDNGP_Type.ToString(),WFinRepNGP_DocAttachTable.WFRCDNGP_Type, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRepNGP_DocAttachTable.WFRCDNGP_Type)
                       End If
                Else
                       formattedValue = Me.DataSource.WFRCDNGP_Type.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCDNGP_Type.Text = formattedValue
                
            Else 
            
                ' WFRCDNGP_Type is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCDNGP_Type.Text = WFinRepNGP_DocAttachTable.WFRCDNGP_Type.Format(WFinRepNGP_DocAttachTable.WFRCDNGP_Type.DefaultValue)
                        		
                End If
                 
            ' If the WFRCDNGP_Type is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRCDNGP_Type.Text Is Nothing _
                OrElse Me.WFRCDNGP_Type.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRCDNGP_Type.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWFRCDNGP_Type1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCDNGP_Type1.ID) Then
            
                Me.WFRCDNGP_Type1.Text = Me.PreviousUIData(Me.WFRCDNGP_Type1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCDNGP_Type TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_DocAttach record retrieved from the database.
            ' Me.WFRCDNGP_Type1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCDNGP_Type1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCDNGP_TypeSpecified Then
                				
                ' If the WFRCDNGP_Type is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_DocAttachTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_DocAttachTable.WFRCDNGP_Type)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_DocAttachTable.WFRCDNGP_Type.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRepNGP_DocAttachTable.GetDFKA(Me.DataSource.WFRCDNGP_Type.ToString(),WFinRepNGP_DocAttachTable.WFRCDNGP_Type, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRepNGP_DocAttachTable.WFRCDNGP_Type)
                       End If
                Else
                       formattedValue = Me.DataSource.WFRCDNGP_Type.ToString()
                End If
                                
                Me.WFRCDNGP_Type1.Text = formattedValue
                
            Else 
            
                ' WFRCDNGP_Type is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCDNGP_Type1.Text = WFinRepNGP_DocAttachTable.WFRCDNGP_Type.Format(WFinRepNGP_DocAttachTable.WFRCDNGP_Type.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCDNGP_Type1.TextChanged, AddressOf WFRCDNGP_Type1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCDNGP_WFRCHNGP_ID()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCDNGP_WFRCHNGP_ID.ID) Then
            
                Me.WFRCDNGP_WFRCHNGP_ID.Text = Me.PreviousUIData(Me.WFRCDNGP_WFRCHNGP_ID.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCDNGP_WFRCHNGP_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_DocAttach record retrieved from the database.
            ' Me.WFRCDNGP_WFRCHNGP_ID is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCDNGP_WFRCHNGP_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCDNGP_WFRCHNGP_IDSpecified Then
                				
                ' If the WFRCDNGP_WFRCHNGP_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_DocAttachTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_DocAttachTable.WFRCDNGP_WFRCHNGP_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_DocAttachTable.WFRCDNGP_WFRCHNGP_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRepNGP_DocAttachTable.GetDFKA(Me.DataSource.WFRCDNGP_WFRCHNGP_ID.ToString(),WFinRepNGP_DocAttachTable.WFRCDNGP_WFRCHNGP_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRepNGP_DocAttachTable.WFRCDNGP_WFRCHNGP_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WFRCDNGP_WFRCHNGP_ID.ToString()
                End If
                                
                Me.WFRCDNGP_WFRCHNGP_ID.Text = formattedValue
                
            Else 
            
                ' WFRCDNGP_WFRCHNGP_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCDNGP_WFRCHNGP_ID.Text = WFinRepNGP_DocAttachTable.WFRCDNGP_WFRCHNGP_ID.Format(WFinRepNGP_DocAttachTable.WFRCDNGP_WFRCHNGP_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCDNGP_WFRCHNGP_ID.TextChanged, AddressOf WFRCDNGP_WFRCHNGP_ID_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCDNGP_Year()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCDNGP_Year.ID) Then
            
                Me.WFRCDNGP_Year.Text = Me.PreviousUIData(Me.WFRCDNGP_Year.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCDNGP_Year TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_DocAttach record retrieved from the database.
            ' Me.WFRCDNGP_Year is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCDNGP_Year()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCDNGP_YearSpecified Then
                				
                ' If the WFRCDNGP_Year is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_DocAttachTable.WFRCDNGP_Year)
                              
                Me.WFRCDNGP_Year.Text = formattedValue
                
            Else 
            
                ' WFRCDNGP_Year is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCDNGP_Year.Text = WFinRepNGP_DocAttachTable.WFRCDNGP_Year.Format(WFinRepNGP_DocAttachTable.WFRCDNGP_Year.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCDNGP_Year.TextChanged, AddressOf WFRCDNGP_Year_TextChanged
                                 
        End Sub
                

        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean, ByVal e As FormulaEvaluator) As String
            If e Is Nothing Then
                e = New FormulaEvaluator()
            End If
            
            e.Variables.Clear()

            
            ' add variables for formula evaluation
            If variables IsNot Nothing Then
                Dim enumerator As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) = variables.GetEnumerator()
                While enumerator.MoveNext()
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value)
                End While
            End If

            If includeDS
                
            End IF
            
            
            ' Other variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            If dataSourceForEvaluate Is Nothing Then

                e.DataSource = Me.DataSource

            Else
                e.DataSource = dataSourceForEvaluate
            End If

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If

            If Not String.IsNullOrEmpty(format) AndAlso (String.IsNullOrEmpty(formula) OrElse formula.IndexOf("Format(") < 0) Then
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function      
        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format,variables ,includeDS, Nothing)        
        End Function        

        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables ,True, Nothing)        
        End Function        

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e as FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS as Boolean) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
        End Function


        Public Overridable Sub RegisterPostback()       
        
        
        End Sub

      
        
        ' To customize, override this method in WFinRepNGP_DocAttachTableControlRow.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
            ' The checksum is used to ensure the record was not changed by another user.
            If (Not Me.DataSource Is Nothing) AndAlso (Not Me.DataSource.GetCheckSumValue Is Nothing) Then
                If Not Me.CheckSum Is Nothing AndAlso Me.CheckSum <> Me.DataSource.GetCheckSumValue.Value Then
                    Throw New Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "ePortalWFApproval"))
                End If
            End If
        
        Dim parentCtrl As WFinRepNGP_HeadTableControlRow
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRepNGP_HeadTableControlRow"), WFinRepNGP_HeadTableControlRow)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ePortalWFApproval"))
            End If
            
            Me.DataSource.WFRCDNGP_WFRCHNGP_ID = parentCtrl.DataSource.WFRCHNGP_ID
              
            ' 2. Perform any custom validation.
            Me.Validate()

            ' 3. Set the values in the record with data from UI controls.
            ' This calls the Get() method for each of the user interface controls.
            Me.GetUIData()

            ' 4. Save in the database.
            ' We should not save the record if the data did not change. This
            ' will save a database hit and avoid triggering any database triggers.
             
            If Me.DataSource.IsAnyValueChanged Then
                ' Save record to database but do not commit yet.
                ' Auto generated ids are available after saving for use by child (dependent) records.
                Me.DataSource.Save()
              
                DirectCast(GetParentControlObject(Me, "WFinRepNGP_DocAttachTableControl"), WFinRepNGP_DocAttachTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WFinRepNGP_DocAttachTableControl"), WFinRepNGP_DocAttachTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            Me.CheckSum = ""
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in WFinRepNGP_DocAttachTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWFRCDNGP_Company()
            GetWFRCDNGP_File1()
            GetWFRCDNGP_Month()
            GetWFRCDNGP_RWRem()
            GetWFRCDNGP_Status()
            GetWFRCDNGP_Type()
            GetWFRCDNGP_Type1()
            GetWFRCDNGP_WFRCHNGP_ID()
            GetWFRCDNGP_Year()
        End Sub
        
        
        Public Overridable Sub GetWFRCDNGP_Company()
            
        End Sub
                
        Public Overridable Sub GetWFRCDNGP_File1()
            
        End Sub
                
        Public Overridable Sub GetWFRCDNGP_Month()
            
        End Sub
                
        Public Overridable Sub GetWFRCDNGP_RWRem()
            
        End Sub
                
        Public Overridable Sub GetWFRCDNGP_Status()
            
        End Sub
                
        Public Overridable Sub GetWFRCDNGP_Type()
            
        End Sub
                
        Public Overridable Sub GetWFRCDNGP_Type1()
            
        End Sub
                
        Public Overridable Sub GetWFRCDNGP_WFRCHNGP_ID()
            
        End Sub
                
        Public Overridable Sub GetWFRCDNGP_Year()
            
        End Sub
                
      
        ' To customize, override this method in WFinRepNGP_DocAttachTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WFinRepNGP_DocAttachTableControlRow.
        Public Overridable Sub Validate() 
            ' Add custom validation for any control within this panel.
            ' Example.  If you have a State ASP:Textbox control
            ' If Me.State.Text <> "CA" Then
            '    Throw New Exception("State must be CA (California).")
            ' End If

            ' The Validate method is common across all controls within
            ' this panel so you can validate multiple fields, but report
            ' one error message.
            
                
        End Sub

        Public Overridable Sub Delete()
        
            If Me.IsNewRecord() Then
                Return
            End If

            Dim pkValue As KeyValue = KeyValue.XmlToKey(Me.RecordUniqueId)
          WFinRepNGP_DocAttachTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WFinRepNGP_DocAttachTableControl"), WFinRepNGP_DocAttachTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WFinRepNGP_DocAttachTableControl"), WFinRepNGP_DocAttachTableControl).ResetData = True
        End Sub

        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction()
                Me.RegisterPostback()

                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                  
                
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    Me.LoadData()
                    Me.DataBind()			
                End If
                                
                						
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction()
            End Try
        End Sub
        
            
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()
        
    
            'Save pagination state to session.
          
        End Sub
        
        
    
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

        

            ' Clear pagination state from session.
        
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)
            Dim isNewRecord As String = CType(ViewState("IsNewRecord"), String)
            If Not isNewRecord Is Nothing AndAlso isNewRecord.Trim <> "" Then
                Me.IsNewRecord = Boolean.Parse(isNewRecord)
            End If
            
            Dim myCheckSum As String = CType(ViewState("CheckSum"), String)
            If Not myCheckSum Is Nothing AndAlso myCheckSum.Trim <> "" Then
                Me.CheckSum = myCheckSum
            End If
            
    
            ' Load view state for pagination control.
                 
        End Sub

        Protected Overrides Function SaveViewState() As Object
            ViewState("IsNewRecord") = Me.IsNewRecord.ToString()
            ViewState("CheckSum") = Me.CheckSum
            
    
            ' Load view state for pagination control.
                  
            Return MyBase.SaveViewState()
        End Function
        
        
    
        ' Generate set method for buttons
        
        Public Overridable Sub SetbtnPreview()                
              
   
        End Sub
            
        ' event handler for Button
        Public Overridable Sub btnPreview_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        Protected Overridable Sub WFRCDNGP_Company_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCDNGP_File1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCDNGP_Month_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCDNGP_Status_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCDNGP_Type1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCDNGP_WFRCHNGP_ID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCDNGP_Year_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
   
        Private _PreviousUIData As New Hashtable
        Public Overridable Property PreviousUIData() As Hashtable
            Get
                Return _PreviousUIData
            End Get
            Set(ByVal value As Hashtable)
                _PreviousUIData = value
            End Set
        End Property   

        
        Public Property RecordUniqueId() As String
            Get
                Return CType(Me.ViewState("BaseWFinRepNGP_DocAttachTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWFinRepNGP_DocAttachTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WFinRepNGP_DocAttachRecord
            Get
                Return DirectCast(MyBase._DataSource, WFinRepNGP_DocAttachRecord)
            End Get
            Set(ByVal value As WFinRepNGP_DocAttachRecord)
                Me._DataSource = value
            End Set
        End Property

        
        Private _checkSum As String
        Public Overridable Property CheckSum() As String
            Get
                Return Me._checkSum
            End Get
            Set(ByVal value As String)
                Me._checkSum = value
            End Set
        End Property
        
        Private _TotalPages As Integer
        Public Property TotalPages() As Integer
            Get
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property
        
        Private _PageIndex As Integer
        Public Property PageIndex() As Integer
            Get
                ' Return the PageIndex
                Return Me._PageIndex
            End Get
            Set(ByVal value As Integer)
                Me._PageIndex = value
            End Set
        End Property
    
        Private _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property
        
        

#Region "Helper Properties"
        
        Public ReadOnly Property btnPreview() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "btnPreview"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property WFRCDNGP_Company() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCDNGP_Company"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCDNGP_File1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCDNGP_File1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCDNGP_Month() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCDNGP_Month"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCDNGP_RWRem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCDNGP_RWRem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCDNGP_Status() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCDNGP_Status"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCDNGP_Type() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCDNGP_Type"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCDNGP_Type1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCDNGP_Type1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCDNGP_WFRCHNGP_ID() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCDNGP_WFRCHNGP_ID"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCDNGP_Year() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCDNGP_Year"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
        
        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As WFinRepNGP_DocAttachRecord = Nothing
             
        
            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.
                
            Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ePortalWFApproval"))
                    
            End If
            Return EvaluateExpressions(url, arg, rec, bEncrypt)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean,ByVal includeSession as Boolean) As String
            
            Dim rec As WFinRepNGP_DocAttachRecord = Nothing
             
        
            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.
                
            Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ePortalWFApproval"))
                    
            End If
            If includeSession  Then
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            Else
                Return EvaluateExpressions(url, arg, rec, bEncrypt,False)  
            End If
        End Function

         
        Public Overridable Function GetRecord() As WFinRepNGP_DocAttachRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WFinRepNGP_DocAttachTable.GetRecord(Me.RecordUniqueId, True)
                
            End If
            
            ' Localization.
            
            Return Nothing
                
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

End Class

  

' Base class for the WFinRepNGP_DocAttachTableControl control on the WFinRepNGP_Inquiry page.
' Do not modify this class. Instead override any method in WFinRepNGP_DocAttachTableControl.
Public Class BaseWFinRepNGP_DocAttachTableControl
        Inherits ePortalWFApproval.UI.BaseApplicationTableControl

        
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
    
           ' Setup the filter and search.
        

      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
         
            Else
                   
                Me.CurrentSortOrder = New OrderBy(True, False)
            
        End If

    

    ' Setup default pagination settings.
    
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
        
            
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
            ' Setup the pagination events.
                        
            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.
          
            ' Setup the button events.
                  
        
          ' Setup events for others
                
        End Sub
        
        
        Public Overridable Sub LoadData()        
        
            ' Read data from database. Returns an array of records that can be assigned
            ' to the DataSource table control property.
            Try	
                Dim joinFilter As CompoundFilter = CreateCompoundJoinFilter()
                
                ' The WHERE clause will be empty when displaying all records in table.
                Dim wc As WhereClause = CreateWhereClause()
                If wc IsNot Nothing AndAlso Not wc.RunQuery Then
                    ' Initialize an empty array of records
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WFinRepNGP_DocAttachRecord)), WFinRepNGP_DocAttachRecord())
                    ' Add records to the list if needed.
                    Me.AddNewRecords()
                    Me._TotalRecords = 0
                    Me._TotalPages = 0
                    Return
                End If

                ' Call OrderBy to determine the order - either use the order defined
                ' on the Query Wizard, or specified by user (by clicking on column heading)
                Dim orderBy As OrderBy = CreateOrderBy()
                
                ' Get the pagesize from the pagesize control.
                Me.GetPageSize()
                               
                If Me.DisplayLastPage Then
                    Dim totalRecords As Integer = If(Me._TotalRecords < 0, GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()), Me._TotalRecords)
                     
                      Dim totalPages As Integer = CInt(Math.Ceiling(totalRecords / Me.PageSize))
                    
                    Me.PageIndex = totalPages - 1
                End If                               
                
                ' Make sure PageIndex (current page) and PageSize are within bounds.
                If Me.PageIndex < 0 Then
                    Me.PageIndex = 0
                End If
                If Me.PageSize < 1 Then
                    Me.PageSize = 1
                End If
                
                ' Retrieve the records and set the table DataSource.
                ' Only PageSize records are fetched starting at PageIndex (zero based).
                If Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                    Dim postdata As New ArrayList
                    For Each rc As WFinRepNGP_DocAttachTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WFinRepNGP_DocAttachRecord)), WFinRepNGP_DocAttachRecord())
                Else  ' Get the records from the database	
                      
                        Me.DataSource = GetRecords(joinFilter, wc, orderBy, Me.PageIndex, Me.PageSize)
                      
                End If
                
                ' if the datasource contains no records contained in database, then load the last page.
                If (DbUtils.GetCreatedRecords(Me.DataSource).Length = 0 AndAlso Not Me.DisplayLastPage) Then
                      Me.DisplayLastPage = True
                      LoadData()
                Else
                
                    ' Add any new rows desired by the user.
                    Me.AddNewRecords()
                       

                    ' Initialize the page and grand totals. now
                
                End If
    
            Catch ex As Exception
                ' Report the error message to the end user
                Dim msg As String = ex.Message
                If ex.InnerException IsNot Nothing Then
                    msg = msg & " InnerException: " & ex.InnerException.Message
                End If
                Throw New Exception(msg, ex.InnerException)
            End Try
        End Sub
        
        Public Overridable Function GetRecords( _
            ByVal join As BaseFilter, _
            ByVal where As WhereClause, _
            ByVal orderBy As OrderBy, _
            ByVal pageIndex As Integer, _
            ByVal pageSize As Integer) As WFinRepNGP_DocAttachRecord()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRepNGP_DocAttachTable.Column1, True)         
            ' selCols.Add(WFinRepNGP_DocAttachTable.Column2, True)          
            ' selCols.Add(WFinRepNGP_DocAttachTable.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WFinRepNGP_DocAttachTable.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WFinRepNGP_DocAttachTable
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WFinRepNGP_DocAttachRecord)), WFinRepNGP_DocAttachRecord())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRepNGP_DocAttachTable.Column1, True)         
            ' selCols.Add(WFinRepNGP_DocAttachTable.Column2, True)          
            ' selCols.Add(WFinRepNGP_DocAttachTable.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WFinRepNGP_DocAttachTable.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WFinRepNGP_DocAttachTable
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)           
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
                
                Return CInt(databaseTable.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
            End If

        End Function        
        
      
    
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record for each row in the table.  To do this, it calls the
            ' DataBind for each of the rows.
            ' DataBind also populates any filters above the table, and sets the pagination
            ' control to the correct number of records and the current page number.
            
            
              MyBase.DataBind()
            
    
            Me.ClearControlsFromSession()    

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
            
            'LoadData for DataSource for chart and report if they exist
          
          ' Improve performance by prefetching display as records.
          Me.PreFetchForeignKeyValues()
             
            ' Setup the pagination controls.
            BindPaginationControls()

      

    
        
          ' Bind the repeater with the list of records to expand the UI.
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_DocAttachTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WFinRepNGP_DocAttachTableControlRow = DirectCast(repItem.FindControl("WFinRepNGP_DocAttachTableControlRow"), WFinRepNGP_DocAttachTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                SetWFRCDNGP_RWRemLabel()
                SetWFRCDNGP_TypeLabel()
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                
      
            ' this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls()
            
                    
            
      End Sub
      
        Public Overridable Sub SetFormulaControls()
            ' this method calls Set methods for the control that has special formula
        
        

    End Sub

    
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(WFinRepNGP_DocAttachTable.WFRCDNGP_Month, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRepNGP_DocAttachTable.WFRCDNGP_Status, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRepNGP_DocAttachTable.WFRCDNGP_Type, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRepNGP_DocAttachTable.WFRCDNGP_Type, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRepNGP_DocAttachTable.WFRCDNGP_WFRCHNGP_ID, Me.DataSource)
          
          End Sub
        
      
        Public Overridable Sub RegisterPostback()
        
        
        End Sub

        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean, ByVal e as FormulaEvaluator) As String
            If e Is Nothing
                e = New FormulaEvaluator()
            End If
            
            e.Variables.Clear()
            
            
            ' add variables for formula evaluation
            If variables IsNot Nothing Then
                Dim enumerator As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) = variables.GetEnumerator()
                While enumerator.MoveNext()
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value)
                End While
            End If
            
            If includeDS
                
            End If
            
            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If
            
            If Not String.IsNullOrEmpty(format) AndAlso (String.IsNullOrEmpty(formula) OrElse formula.IndexOf("Format(") < 0) Then
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function			

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format,variables ,includeDS, Nothing)        
        End Function        

        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables ,True, Nothing)        
        End Function        

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e as FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS as Boolean) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
        End Function




        Public Overridable Sub ResetControl()

            
            Me.CurrentSortOrder.Reset()
            If (Me.InSession(Me, "Order_By")) Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
                
            End If
                
            Me.PageIndex = 0
        End Sub

        Public Overridable Sub ResetPageControl()
            Me.PageIndex = 0
        End Sub
        
        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the pagination labels.
        

            ' Bind the buttons for WFinRepNGP_DocAttachTableControl pagination.
        


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As WFinRepNGP_DocAttachTableControlRow
            For Each recCtl In Me.GetRecordControls()
        
                If Me.InDeletedRecordIds(recCtl) Then
                    ' Delete any pending deletes. 
                    recCtl.Delete()
                Else
                    If recCtl.Visible Then
                        recCtl.SaveData()
                    End If
                End If
          
            Next
            
            
          
    
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
          
            ' Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            For Each recCtl In Me.GetRecordControls()
                recCtl.IsNewRecord = False
            Next
    
      
            ' Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            Me.DeletedRecordIds = Nothing
      
        End Sub

        Public Overridable Function CreateCompoundJoinFilter() As CompoundFilter
            Dim jFilter As CompoundFilter = New CompoundFilter()
         
            Return jFilter
        End Function

      
          Public Overridable Function CreateOrderBy() As OrderBy
          ' The CurrentSortOrder is initialized to the sort order on the
          ' Query Wizard.  It may be modified by the Click handler for any of
          ' the column heading to sort or reverse sort by that column.
          ' You can add your own sort order, or modify it on the Query Wizard.
          Return Me.CurrentSortOrder
          End Function
      
        Public Overridable Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            WFinRepNGP_DocAttachTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
        Dim wFinRepNGP_HeadRecordObj as KeyValue
        wFinRepNGP_HeadRecordObj = Nothing
      
              Dim wFinRepNGP_HeadTableControlObjRow As WFinRepNGP_HeadTableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRepNGP_HeadTableControlRow") ,WFinRepNGP_HeadTableControlRow)
            
                If (Not IsNothing(wFinRepNGP_HeadTableControlObjRow) AndAlso Not IsNothing(wFinRepNGP_HeadTableControlObjRow.GetRecord()) AndAlso Not IsNothing(wFinRepNGP_HeadTableControlObjRow.GetRecord().WFRCHNGP_ID))
                    wc.iAND(WFinRepNGP_DocAttachTable.WFRCDNGP_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, wFinRepNGP_HeadTableControlObjRow.GetRecord().WFRCHNGP_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If
              
      HttpContext.Current.Session("WFinRepNGP_DocAttachTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WFinRepNGP_DocAttachTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWFinRepNGP_HeadTableControl as String = DirectCast(HttpContext.Current.Session("WFinRepNGP_DocAttachTableControlWhereClause"), String)
            
            If Not selectedRecordInWFinRepNGP_HeadTableControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWFinRepNGP_HeadTableControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWFinRepNGP_HeadTableControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(WFinRepNGP_DocAttachTable.WFRCDNGP_WFRCHNGP_ID) Then
            wc.iAND(WFinRepNGP_DocAttachTable.WFRCDNGP_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(WFinRepNGP_DocAttachTable.WFRCDNGP_WFRCHNGP_ID).ToString())
       End If
      
            End If
          
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
      
      
            Return wc
        End Function

      

         Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                         ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                         ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                         ByVal resultList As ArrayList) As Boolean
              Return FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText, _
                                       autoTypeAheadSearch, AutoTypeAheadWordSeparators, _
                                       resultList, False)
         End Function

        Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                               ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                               ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                               ByVal resultList As ArrayList, ByVal stripHTML As Boolean) As Boolean
            If stripHTML Then
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText)
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem)
            End If
            'Formats the resultItem and adds it to the list of suggestions.
            Dim index As Integer = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))
            Dim itemToAdd As String = ""
            Dim isFound As Boolean = False
            Dim isAdded As Boolean = False
            ' Get the index where prfixt is at the beginning of resultItem. If not found then, index of word which begins with prefixText.
            If InvariantLCase(autoTypeAheadSearch).equals("wordsstartingwithsearchstring") And Not index = 0 Then
                ' Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex(AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                If regex1.IsMatch(resultItem) Then
                    index = regex1.Match(resultItem).Index
                    isFound = True
                End If
                ' If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                If Not resultItem(index).ToString() = " " Then
                    ' Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    If regex.IsMatch(resultItem) Then
                        index = regex.Match(resultItem).Index
                        isFound = True
                    End If
                End If
            End If

            ' If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            ' beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            If index = 0 Or isFound Or InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") Then
                If InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atbeginningofmatchedstring") Then
                    ' Expression to find beginning of the word which contains prefixText
                    Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    '  Find the beginning of the word which contains prefexText
                    If (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") AndAlso regex1.IsMatch(resultItem)) Then
                        index = regex1.Match(resultItem).Index
                        isFound = True
                    End If
                    ' Display string from the index till end of the string if sub string from index till end is less than columnLength value.
                    If Len(resultItem) - index <= columnLength Then
                        If index = 0 Then
                            itemToAdd = resultItem
                        Else                            
                            itemToAdd = resultItem.Substring(index)
                        End If
                    Else                       
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward)
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("inmiddleofmatchedstring") Then
                    Dim subStringBeginIndex As Integer = CType(columnLength / 2, Integer)
                    If Len(resultItem) <= columnLength Then
                        itemToAdd = resultItem
                    Else
                        ' Sanity check at end of the string
                        If index + Len(prefixText) >= Len(resultItem) - 1 OrElse _
                        Len(resultItem) - index < subStringBeginIndex Then                           
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, Len(resultItem) - 1 - columnLength, Len(resultItem) - 1, StringUtils.Direction.backward)
                        ElseIf index <= subStringBeginIndex Then
                            ' Sanity check at beginning of the string                          
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward)
                        Else
                            ' Display string containing text before the prefixText occures and text after the prefixText                         
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both)
                        End If
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atendofmatchedstring") Then
                    ' Expression to find ending of the word which contains prefexText
                    Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    ' Find the ending of the word which contains prefexText
                    If regex1.IsMatch(resultItem, index + 1) Then
                        index = regex1.Match(resultItem, index + 1).Index
                    Else
                        ' If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length
                    End If
                    If index > Len(resultItem) Then
                        index = Len(resultItem)
                    End If
                    ' If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    If index <= columnLength Then
                        itemToAdd = resultItem.Substring(0, index)
                    Else
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward)
                    End If
                End If

                ' Remove newline character from itemToAdd
                Dim prefixTextIndex As Integer = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase)
                If prefixTextIndex < 0 Then Return False
                ' If itemToAdd contains any newline after the search text then show text only till newline
                Dim regex2 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                Dim newLineIndexAfterPrefix As Integer = -1
                If regex2.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexAfterPrefix > -1) Then
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix)
                End If
                ' If itemToAdd contains any newline before search text then show text which comes after newline
                Dim regex3 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", (System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.RightToLeft))
                Dim newLineIndexBeforePrefix As Integer = -1
                If regex3.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexBeforePrefix > -1) Then
                    itemToAdd = itemToAdd.Substring((newLineIndexBeforePrefix + regex3.Match(itemToAdd, prefixTextIndex).Length))
                End If

                If Not String.IsNullOrEmpty(itemToAdd) AndAlso Not resultList.Contains(itemToAdd) Then
                   
                    resultList.Add(itemToAdd)
          				
                    isAdded = True
                End If
            End If
            Return isAdded
        End Function
        
    
        Protected Overridable Sub GetPageSize()
        
        End Sub

        Protected Overridable Sub AddNewRecords()
          
            Dim newRecordList As ArrayList = New ArrayList()
          
    Dim newUIDataList As System.Collections.Generic.List(Of Hashtable) = New System.Collections.Generic.List(Of Hashtable)()

    ' Loop though all the record controls and if the record control
    ' does not have a unique record id set, then create a record
    ' and add to the list.
    If Not Me.ResetData Then
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_DocAttachTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WFinRepNGP_DocAttachTableControlRow = DirectCast(repItem.FindControl("WFinRepNGP_DocAttachTableControlRow"), WFinRepNGP_DocAttachTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WFinRepNGP_DocAttachRecord = New WFinRepNGP_DocAttachRecord()
        
                        If recControl.WFRCDNGP_Company.Text <> "" Then
                            rec.Parse(recControl.WFRCDNGP_Company.Text, WFinRepNGP_DocAttachTable.WFRCDNGP_Company)
                        End If
                        If recControl.WFRCDNGP_File1.Text <> "" Then
                            rec.Parse(recControl.WFRCDNGP_File1.Text, WFinRepNGP_DocAttachTable.WFRCDNGP_File1)
                        End If
                        If recControl.WFRCDNGP_Month.Text <> "" Then
                            rec.Parse(recControl.WFRCDNGP_Month.Text, WFinRepNGP_DocAttachTable.WFRCDNGP_Month)
                        End If
                        If recControl.WFRCDNGP_RWRem.Text <> "" Then
                            rec.Parse(recControl.WFRCDNGP_RWRem.Text, WFinRepNGP_DocAttachTable.WFRCDNGP_RWRem)
                        End If
                        If recControl.WFRCDNGP_Status.Text <> "" Then
                            rec.Parse(recControl.WFRCDNGP_Status.Text, WFinRepNGP_DocAttachTable.WFRCDNGP_Status)
                        End If
                        If recControl.WFRCDNGP_Type.Text <> "" Then
                            rec.Parse(recControl.WFRCDNGP_Type.Text, WFinRepNGP_DocAttachTable.WFRCDNGP_Type)
                        End If
                        If recControl.WFRCDNGP_Type1.Text <> "" Then
                            rec.Parse(recControl.WFRCDNGP_Type1.Text, WFinRepNGP_DocAttachTable.WFRCDNGP_Type)
                        End If
                        If recControl.WFRCDNGP_WFRCHNGP_ID.Text <> "" Then
                            rec.Parse(recControl.WFRCDNGP_WFRCHNGP_ID.Text, WFinRepNGP_DocAttachTable.WFRCDNGP_WFRCHNGP_ID)
                        End If
                        If recControl.WFRCDNGP_Year.Text <> "" Then
                            rec.Parse(recControl.WFRCDNGP_Year.Text, WFinRepNGP_DocAttachTable.WFRCDNGP_Year)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WFinRepNGP_DocAttachRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WFinRepNGP_DocAttachRecord)), WFinRepNGP_DocAttachRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WFinRepNGP_DocAttachTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WFinRepNGP_DocAttachTableControlRow) As Boolean
            If Me.DeletedRecordIds Is Nothing OrElse Me.DeletedRecordIds.Trim = "" Then
                Return False
            End If

            Return Me.DeletedRecordIds.IndexOf("[" & rec.RecordUniqueId & "]") >= 0
        End Function

        Private _DeletedRecordIds As String
        Public Property DeletedRecordIds() As String
            Get
                Return Me._DeletedRecordIds
            End Get
            Set(ByVal value As String)
                Me._DeletedRecordIds = value
            End Set
        End Property
        
      
        ' Create Set, WhereClause, and Populate Methods
        
        Public Overridable Sub SetWFRCDNGP_RWRemLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCDNGP_RWRemLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRCDNGP_TypeLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCDNGP_TypeLabel.Text = "Some value"
                    
                  End Sub
                

    
    
        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction
                Me.RegisterPostback()
                
                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                  
                
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    
                    Me.LoadData()
                    Me.DataBind()
                    
                End If
                
               
                				
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
        End Sub
        
        
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()

            ' Save filter controls to values to session.
        
        
            'Save pagination state to session.
         
            
            ' Save table control properties to the session.
            
 If Not Me.CurrentSortOrder Is Nothing Then
                If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then
                    Me.SaveToSession(Me, "Order_By", Me.CurrentSortOrder.ToXmlString())
                End If
            End If            
            Me.SaveToSession(Me, "Page_Index", Me.PageIndex.ToString())
            Me.SaveToSession(Me, "Page_Size", Me.PageSize.ToString())
        
            Me.SaveToSession(Me, "DeletedRecordIds", Me.DeletedRecordIds)  
        
        End Sub
        
        Protected  Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.
          
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("WFinRepNGP_DocAttachTableControl_OrderBy"), String)
          
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            
            Else 
                Me.CurrentSortOrder = New OrderBy(True, False)
            
            End If
            
            
            Dim Pagination As Control = Me.FindControl("")
             Dim PaginationType As String = ""
             If Not (Pagination Is Nothing) Then
                Dim Summary As Control = Pagination.FindControl("_Summary")
                If Not (Summary Is Nothing) Then
                    If (DirectCast(Summary, System.Web.UI.WebControls.TextBox).Text.Equals("Infinite Pagination")) Then
                        PaginationType = "Infinite Pagination"
                    End If
                    If (DirectCast(Summary, System.Web.UI.WebControls.TextBox).Text.Equals("Infinite Pagination Mobile")) Then
                        PaginationType = "Infinite Pagination Mobile"
                End If
             End If
             End If

            If Not (PaginationType.Equals("Infinite Pagination")) Then 
              If Not Me.Page.ClientQueryString.Contains("InfiIframe") AndAlso PaginationType.Equals("Infinite Pagination Mobile") Then
                    Me.ViewState("Page_Index") = 0
                End If
              Dim pageIndex As String = CType(ViewState("Page_Index"), String)
              If pageIndex IsNot Nothing Then
                Me.PageIndex = CInt(pageIndex)
              End If
            End If

            Dim pageSize As String = CType(ViewState("Page_Size"), String)
            If Not pageSize Is Nothing Then
              Me.PageSize = CInt(pageSize)
            End If

            
    
            ' Load view state for pagination control.
        
            Me.DeletedRecordIds = CType(Me.ViewState("DeletedRecordIds"), String)
        
        End Sub

        Protected Overrides Function SaveViewState() As Object
          
            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("WFinRepNGP_DocAttachTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function
        
        ' Generate set method for buttons
                

        ' Generate the event handling functions for pagination events.
        

        ' Generate the event handling functions for sorting events.
        

        ' Generate the event handling functions for button events.
        
      

        ' Generate the event handling functions for filter and search events.
        
    
        ' Generate the event handling functions for others
        
      


        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = WFinRepNGP_DocAttachTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
                End If
                Return Me._TotalRecords
            End Get
            Set(ByVal value As Integer)
                If Me.PageSize > 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(value / Me.PageSize))
                  
                End If
                Me._TotalRecords = value
            End Set
        End Property

        
    
        Protected _TotalPages As Integer = -1
        Public Property TotalPages() As Integer
            Get
                If _TotalPages < 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(TotalRecords / Me.PageSize))
                  
                End If                
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property

        Protected _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property


          
        Private _CurrentSortOrder As OrderBy = Nothing
        Public Property CurrentSortOrder() As OrderBy
            Get
                Return Me._CurrentSortOrder
            End Get
            Set(ByVal value As BaseClasses.Data.OrderBy)
                Me._CurrentSortOrder = value
            End Set
        End Property
        
        Public Property DataSource() As WFinRepNGP_DocAttachRecord ()
            Get
                Return DirectCast(MyBase._DataSource, WFinRepNGP_DocAttachRecord())
            End Get
            Set(ByVal value() As WFinRepNGP_DocAttachRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property WFRCDNGP_RWRemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCDNGP_RWRemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCDNGP_TypeLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCDNGP_TypeLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"
        
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
      
      
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me,includeSession)
        End Function
        
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As WFinRepNGP_DocAttachTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRepNGP_DocAttachRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
        
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As WFinRepNGP_DocAttachTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRepNGP_DocAttachRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                If includeSession then
                    Return EvaluateExpressions(url, arg, rec, bEncrypt)
                Else
                    Return EvaluateExpressions(url, arg, rec, bEncrypt,False)
                End If
            End If
            Return url
        End Function
        
          
        Public Overridable Function GetSelectedRecordControl() As WFinRepNGP_DocAttachTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WFinRepNGP_DocAttachTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WFinRepNGP_DocAttachTableControlRow)), WFinRepNGP_DocAttachTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WFinRepNGP_DocAttachTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WFinRepNGP_DocAttachTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                Else
                
                    recCtl.Delete()
                    
                    ' Setting the DataChanged to True results in the page being refreshed with
                    ' the most recent data from the database.  This happens in PreRender event
                    ' based on the current sort, search and filter criteria.
                    Me.DataChanged = True
                    Me.ResetData = True
                  
                End If
            Next
        End Sub

        Public Overridable Function GetRecordControls() As WFinRepNGP_DocAttachTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WFinRepNGP_DocAttachTableControlRow")
            Dim list As New List(Of WFinRepNGP_DocAttachTableControlRow)
            For Each recCtrl As WFinRepNGP_DocAttachTableControlRow In recCtrls
                list.Add(recCtrl)
            Next
            Return list.ToArray()
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property
                


#End Region



End Class

  
' Base class for the WFinRepNGP_HeadTableControlRow control on the WFinRepNGP_Inquiry page.
' Do not modify this class. Instead override any method in WFinRepNGP_HeadTableControlRow.
Public Class BaseWFinRepNGP_HeadTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WFinRepNGP_HeadTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WFinRepNGP_HeadTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
              AddHandler Me.ExpandRowButton.Click, AddressOf ExpandRowButton_Click
                        
              AddHandler Me.imbEdit.Click, AddressOf imbEdit_Click
                        
              AddHandler Me.imbView.Click, AddressOf imbView_Click
                        
              AddHandler Me.btnEdit.Button.Click, AddressOf btnEdit_Click
                        
              AddHandler Me.btnPreview1.Button.Click, AddressOf btnPreview1_Click
                        
              AddHandler Me.btnPreview2.Button.Click, AddressOf btnPreview2_Click
                        
              AddHandler Me.WFRCHNGP_C_ID1.TextChanged, AddressOf WFRCHNGP_C_ID1_TextChanged
            
              AddHandler Me.WFRCHNGP_Description1.TextChanged, AddressOf WFRCHNGP_Description1_TextChanged
            
              AddHandler Me.WFRCHNGP_ID.TextChanged, AddressOf WFRCHNGP_ID_TextChanged
            
              AddHandler Me.WFRCHNGP_Month1.TextChanged, AddressOf WFRCHNGP_Month1_TextChanged
            
              AddHandler Me.WFRCHNGP_Status1.TextChanged, AddressOf WFRCHNGP_Status1_TextChanged
            
              AddHandler Me.WFRCHNGP_U_ID.TextChanged, AddressOf WFRCHNGP_U_ID_TextChanged
            
              AddHandler Me.WFRCHNGP_Year1.TextChanged, AddressOf WFRCHNGP_Year1_TextChanged
            
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WF%dbo.WFinRepNGP_Head record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WFinRepNGP_HeadTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWFinRepNGP_HeadTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WFinRepNGP_HeadRecord()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WFinRepNGP_HeadTableControlRow.
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record.  To do this, it calls the Set methods for 
            ' each of the field displayed on the webpage.  It is better to make 
            ' changes in the Set methods, rather than making changes here.
            
            MyBase.DataBind()
            Me.ClearControlsFromSession()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
              
                Return
            End If
             
   
            'LoadData for DataSource for chart and report if they exist
          
            ' Store the checksum. The checksum is used to
            ' ensure the record was not changed by another user.
            If Not Me.DataSource.GetCheckSumValue() Is Nothing
                Me.CheckSum = Me.DataSource.GetCheckSumValue().Value
            End If
            
      
      
            ' Call the Set methods for each controls on the panel
        
                
                
                
                
                
                
                
                
                
                
                
                
                SetWFinRepNGP_HeadTabContainer()
                SetWFRCHNGP_C_ID()
                SetWFRCHNGP_C_ID1()
                SetWFRCHNGP_Description()
                SetWFRCHNGP_Description1()
                SetWFRCHNGP_File()
                SetWFRCHNGP_ID()
                SetWFRCHNGP_Month()
                SetWFRCHNGP_Month1()
                SetWFRCHNGP_RptCount()
                SetWFRCHNGP_Status()
                SetWFRCHNGP_Status1()
                SetWFRCHNGP_U_ID()
                SetWFRCHNGP_Year()
                SetWFRCHNGP_Year1()
                SetExpandRowButton()
              
                SetimbEdit()
              
                SetimbView()
              
                SetbtnEdit()
              
                SetbtnPreview1()
              
                SetbtnPreview2()
              
      
      
            Me.IsNewRecord = True
            
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
                
                If Me.DataSource.GetID IsNot Nothing Then
                    Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
                End If
                
            End If
            
            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
                      
        SetWFinRepNGP_ActivityTableControl()
                  
        SetWFinRepNGP_AttachmentTableControl()
                  
        SetWFinRepNGP_DocAttachTableControl()
        
        End Sub
        
        
        Public Overridable Sub SetWFRCHNGP_C_ID()

                  
            
        
            ' Set the WFRCHNGP_C_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_C_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_C_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_C_IDSpecified Then
                				
                ' If the WFRCHNGP_C_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_HeadTable.WFRCHNGP_C_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCHNGP_C_ID.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_C_ID.Text = WFinRepNGP_HeadTable.WFRCHNGP_C_ID.Format(WFinRepNGP_HeadTable.WFRCHNGP_C_ID.DefaultValue)
                        		
                End If
                 
            ' If the WFRCHNGP_C_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRCHNGP_C_ID.Text Is Nothing _
                OrElse Me.WFRCHNGP_C_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRCHNGP_C_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_C_ID1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCHNGP_C_ID1.ID) Then
            
                Me.WFRCHNGP_C_ID1.Text = Me.PreviousUIData(Me.WFRCHNGP_C_ID1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCHNGP_C_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_C_ID1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_C_ID1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_C_IDSpecified Then
                				
                ' If the WFRCHNGP_C_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_HeadTable.WFRCHNGP_C_ID)
                              
                Me.WFRCHNGP_C_ID1.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_C_ID1.Text = WFinRepNGP_HeadTable.WFRCHNGP_C_ID.Format(WFinRepNGP_HeadTable.WFRCHNGP_C_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCHNGP_C_ID1.TextChanged, AddressOf WFRCHNGP_C_ID1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Description()

                  
            
        
            ' Set the WFRCHNGP_Description Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Description is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Description()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_DescriptionSpecified Then
                				
                ' If the WFRCHNGP_Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_HeadTable.WFRCHNGP_Description)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCHNGP_Description.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Description.Text = WFinRepNGP_HeadTable.WFRCHNGP_Description.Format(WFinRepNGP_HeadTable.WFRCHNGP_Description.DefaultValue)
                        		
                End If
                 
            ' If the WFRCHNGP_Description is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRCHNGP_Description.Text Is Nothing _
                OrElse Me.WFRCHNGP_Description.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRCHNGP_Description.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Description1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCHNGP_Description1.ID) Then
            
                Me.WFRCHNGP_Description1.Text = Me.PreviousUIData(Me.WFRCHNGP_Description1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCHNGP_Description TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Description1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Description1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_DescriptionSpecified Then
                				
                ' If the WFRCHNGP_Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_HeadTable.WFRCHNGP_Description)
                              
                Me.WFRCHNGP_Description1.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Description1.Text = WFinRepNGP_HeadTable.WFRCHNGP_Description.Format(WFinRepNGP_HeadTable.WFRCHNGP_Description.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCHNGP_Description1.TextChanged, AddressOf WFRCHNGP_Description1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_File()

                  
                
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_FileSpecified Then
                
                Me.WFRCHNGP_File.Text = Page.GetResourceValue("Txt:OpenFile", "ePortalWFApproval")
                        
                Me.WFRCHNGP_File.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WFinRepNGP_Head") & _
                            "&Field=" & Me.Page.Encrypt("WFRCHNGP_File") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"
                   
                Me.WFRCHNGP_File.Visible = True
            Else
                Me.WFRCHNGP_File.Visible = False
            End If
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_ID()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCHNGP_ID.ID) Then
            
                Me.WFRCHNGP_ID.Text = Me.PreviousUIData(Me.WFRCHNGP_ID.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCHNGP_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_ID is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_IDSpecified Then
                				
                ' If the WFRCHNGP_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_HeadTable.WFRCHNGP_ID)
                              
                Me.WFRCHNGP_ID.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_ID.Text = WFinRepNGP_HeadTable.WFRCHNGP_ID.Format(WFinRepNGP_HeadTable.WFRCHNGP_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCHNGP_ID.TextChanged, AddressOf WFRCHNGP_ID_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Month()

                  
            
        
            ' Set the WFRCHNGP_Month Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Month is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Month()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_MonthSpecified Then
                				
                ' If the WFRCHNGP_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_HeadTable.WFRCHNGP_Month)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_HeadTable.WFRCHNGP_Month.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRepNGP_HeadTable.GetDFKA(Me.DataSource.WFRCHNGP_Month.ToString(),WFinRepNGP_HeadTable.WFRCHNGP_Month, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRepNGP_HeadTable.WFRCHNGP_Month)
                       End If
                Else
                       formattedValue = Me.DataSource.WFRCHNGP_Month.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCHNGP_Month.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Month.Text = WFinRepNGP_HeadTable.WFRCHNGP_Month.Format(WFinRepNGP_HeadTable.WFRCHNGP_Month.DefaultValue)
                        		
                End If
                 
            ' If the WFRCHNGP_Month is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRCHNGP_Month.Text Is Nothing _
                OrElse Me.WFRCHNGP_Month.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRCHNGP_Month.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Month1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCHNGP_Month1.ID) Then
            
                Me.WFRCHNGP_Month1.Text = Me.PreviousUIData(Me.WFRCHNGP_Month1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCHNGP_Month TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Month1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Month1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_MonthSpecified Then
                				
                ' If the WFRCHNGP_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_HeadTable.WFRCHNGP_Month)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_HeadTable.WFRCHNGP_Month.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRepNGP_HeadTable.GetDFKA(Me.DataSource.WFRCHNGP_Month.ToString(),WFinRepNGP_HeadTable.WFRCHNGP_Month, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRepNGP_HeadTable.WFRCHNGP_Month)
                       End If
                Else
                       formattedValue = Me.DataSource.WFRCHNGP_Month.ToString()
                End If
                                
                Me.WFRCHNGP_Month1.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Month1.Text = WFinRepNGP_HeadTable.WFRCHNGP_Month.Format(WFinRepNGP_HeadTable.WFRCHNGP_Month.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCHNGP_Month1.TextChanged, AddressOf WFRCHNGP_Month1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_RptCount()

                  
            
        
            ' Set the WFRCHNGP_RptCount Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_RptCount is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_RptCount()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_RptCountSpecified Then
                				
                ' If the WFRCHNGP_RptCount is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_HeadTable.WFRCHNGP_RptCount)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCHNGP_RptCount.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_RptCount is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_RptCount.Text = WFinRepNGP_HeadTable.WFRCHNGP_RptCount.Format(WFinRepNGP_HeadTable.WFRCHNGP_RptCount.DefaultValue)
                        		
                End If
                 
            ' If the WFRCHNGP_RptCount is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRCHNGP_RptCount.Text Is Nothing _
                OrElse Me.WFRCHNGP_RptCount.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRCHNGP_RptCount.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Status()

                  
            
        
            ' Set the WFRCHNGP_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Status is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_StatusSpecified Then
                				
                ' If the WFRCHNGP_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_HeadTable.WFRCHNGP_Status)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_HeadTable.WFRCHNGP_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRepNGP_HeadTable.GetDFKA(Me.DataSource.WFRCHNGP_Status.ToString(),WFinRepNGP_HeadTable.WFRCHNGP_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRepNGP_HeadTable.WFRCHNGP_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.WFRCHNGP_Status.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCHNGP_Status.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Status.Text = WFinRepNGP_HeadTable.WFRCHNGP_Status.Format(WFinRepNGP_HeadTable.WFRCHNGP_Status.DefaultValue)
                        		
                End If
                 
            ' If the WFRCHNGP_Status is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRCHNGP_Status.Text Is Nothing _
                OrElse Me.WFRCHNGP_Status.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRCHNGP_Status.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Status1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCHNGP_Status1.ID) Then
            
                Me.WFRCHNGP_Status1.Text = Me.PreviousUIData(Me.WFRCHNGP_Status1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCHNGP_Status TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Status1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Status1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_StatusSpecified Then
                				
                ' If the WFRCHNGP_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_HeadTable.WFRCHNGP_Status)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_HeadTable.WFRCHNGP_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRepNGP_HeadTable.GetDFKA(Me.DataSource.WFRCHNGP_Status.ToString(),WFinRepNGP_HeadTable.WFRCHNGP_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRepNGP_HeadTable.WFRCHNGP_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.WFRCHNGP_Status.ToString()
                End If
                                
                Me.WFRCHNGP_Status1.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Status1.Text = WFinRepNGP_HeadTable.WFRCHNGP_Status.Format(WFinRepNGP_HeadTable.WFRCHNGP_Status.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCHNGP_Status1.TextChanged, AddressOf WFRCHNGP_Status1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_U_ID()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCHNGP_U_ID.ID) Then
            
                Me.WFRCHNGP_U_ID.Text = Me.PreviousUIData(Me.WFRCHNGP_U_ID.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCHNGP_U_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_U_ID is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_U_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_U_IDSpecified Then
                				
                ' If the WFRCHNGP_U_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_HeadTable.WFRCHNGP_U_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_HeadTable.WFRCHNGP_U_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRepNGP_HeadTable.GetDFKA(Me.DataSource.WFRCHNGP_U_ID.ToString(),WFinRepNGP_HeadTable.WFRCHNGP_U_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRepNGP_HeadTable.WFRCHNGP_U_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WFRCHNGP_U_ID.ToString()
                End If
                                
                Me.WFRCHNGP_U_ID.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_U_ID.Text = WFinRepNGP_HeadTable.WFRCHNGP_U_ID.Format(WFinRepNGP_HeadTable.WFRCHNGP_U_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCHNGP_U_ID.TextChanged, AddressOf WFRCHNGP_U_ID_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Year()

                  
            
        
            ' Set the WFRCHNGP_Year Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Year is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Year()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_YearSpecified Then
                				
                ' If the WFRCHNGP_Year is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_HeadTable.WFRCHNGP_Year)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCHNGP_Year.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Year is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Year.Text = WFinRepNGP_HeadTable.WFRCHNGP_Year.Format(WFinRepNGP_HeadTable.WFRCHNGP_Year.DefaultValue)
                        		
                End If
                 
            ' If the WFRCHNGP_Year is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRCHNGP_Year.Text Is Nothing _
                OrElse Me.WFRCHNGP_Year.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRCHNGP_Year.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Year1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCHNGP_Year1.ID) Then
            
                Me.WFRCHNGP_Year1.Text = Me.PreviousUIData(Me.WFRCHNGP_Year1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCHNGP_Year TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Year1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Year1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_YearSpecified Then
                				
                ' If the WFRCHNGP_Year is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_HeadTable.WFRCHNGP_Year)
                              
                Me.WFRCHNGP_Year1.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Year is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Year1.Text = WFinRepNGP_HeadTable.WFRCHNGP_Year.Format(WFinRepNGP_HeadTable.WFRCHNGP_Year.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCHNGP_Year1.TextChanged, AddressOf WFRCHNGP_Year1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFinRepNGP_HeadTabContainer()           
                        
                   
            If EvaluateFormula("URL(""TabVisible"")").ToLower() = "true" Then
                MiscUtils.FindControlRecursively(Me, "WFinRepNGP_HeadTabContainer").Visible = True
            ElseIf EvaluateFormula("URL(""TabVisible"")").ToLower() = "false" Then
                MiscUtils.FindControlRecursively(Me, "WFinRepNGP_HeadTabContainer").Visible = False
            End If
         
  
        End Sub        
      
        Public Overridable Sub SetWFinRepNGP_ActivityTableControl()           
        
        
            If WFinRepNGP_ActivityTableControl.Visible Then
                WFinRepNGP_ActivityTableControl.LoadData()
                WFinRepNGP_ActivityTableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWFinRepNGP_AttachmentTableControl()           
        
        
            If WFinRepNGP_AttachmentTableControl.Visible Then
                WFinRepNGP_AttachmentTableControl.LoadData()
                WFinRepNGP_AttachmentTableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWFinRepNGP_DocAttachTableControl()           
        
        
            If WFinRepNGP_DocAttachTableControl.Visible Then
                WFinRepNGP_DocAttachTableControl.LoadData()
                WFinRepNGP_DocAttachTableControl.DataBind()
            End If
        End Sub        
      

        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean, ByVal e As FormulaEvaluator) As String
            If e Is Nothing Then
                e = New FormulaEvaluator()
            End If
            
            e.Variables.Clear()

            
            ' add variables for formula evaluation
            If variables IsNot Nothing Then
                Dim enumerator As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) = variables.GetEnumerator()
                While enumerator.MoveNext()
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value)
                End While
            End If

            If includeDS
                
            End IF
            
            
            ' Other variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            If dataSourceForEvaluate Is Nothing Then

                e.DataSource = Me.DataSource

            Else
                e.DataSource = dataSourceForEvaluate
            End If

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If

            If Not String.IsNullOrEmpty(format) AndAlso (String.IsNullOrEmpty(formula) OrElse formula.IndexOf("Format(") < 0) Then
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function      
        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format,variables ,includeDS, Nothing)        
        End Function        

        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables ,True, Nothing)        
        End Function        

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e as FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS as Boolean) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
        End Function


        Public Overridable Sub RegisterPostback()       
        
        
        End Sub

      
        
        ' To customize, override this method in WFinRepNGP_HeadTableControlRow.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
            ' The checksum is used to ensure the record was not changed by another user.
            If (Not Me.DataSource Is Nothing) AndAlso (Not Me.DataSource.GetCheckSumValue Is Nothing) Then
                If Not Me.CheckSum Is Nothing AndAlso Me.CheckSum <> Me.DataSource.GetCheckSumValue.Value Then
                    Throw New Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "ePortalWFApproval"))
                End If
            End If
        
              
            ' 2. Perform any custom validation.
            Me.Validate()

            ' 3. Set the values in the record with data from UI controls.
            ' This calls the Get() method for each of the user interface controls.
            Me.GetUIData()

            ' 4. Save in the database.
            ' We should not save the record if the data did not change. This
            ' will save a database hit and avoid triggering any database triggers.
             
            If Me.DataSource.IsAnyValueChanged Then
                ' Save record to database but do not commit yet.
                ' Auto generated ids are available after saving for use by child (dependent) records.
                Me.DataSource.Save()
              
                DirectCast(GetParentControlObject(Me, "WFinRepNGP_HeadTableControl"), WFinRepNGP_HeadTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WFinRepNGP_HeadTableControl"), WFinRepNGP_HeadTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            Me.CheckSum = ""
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        Dim recWFinRepNGP_ActivityTableControl as WFinRepNGP_ActivityTableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WFinRepNGP_ActivityTableControl"), WFinRepNGP_ActivityTableControl)
        recWFinRepNGP_ActivityTableControl.SaveData()
          
        Dim recWFinRepNGP_AttachmentTableControl as WFinRepNGP_AttachmentTableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WFinRepNGP_AttachmentTableControl"), WFinRepNGP_AttachmentTableControl)
        recWFinRepNGP_AttachmentTableControl.SaveData()
          
        Dim recWFinRepNGP_DocAttachTableControl as WFinRepNGP_DocAttachTableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WFinRepNGP_DocAttachTableControl"), WFinRepNGP_DocAttachTableControl)
        recWFinRepNGP_DocAttachTableControl.SaveData()
          
        End Sub

        ' To customize, override this method in WFinRepNGP_HeadTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWFRCHNGP_C_ID()
            GetWFRCHNGP_C_ID1()
            GetWFRCHNGP_Description()
            GetWFRCHNGP_Description1()
            GetWFRCHNGP_ID()
            GetWFRCHNGP_Month()
            GetWFRCHNGP_Month1()
            GetWFRCHNGP_RptCount()
            GetWFRCHNGP_Status()
            GetWFRCHNGP_Status1()
            GetWFRCHNGP_U_ID()
            GetWFRCHNGP_Year()
            GetWFRCHNGP_Year1()
        End Sub
        
        
        Public Overridable Sub GetWFRCHNGP_C_ID()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_C_ID1()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Description()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Description1()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_ID()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Month()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Month1()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_RptCount()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Status()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Status1()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_U_ID()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Year()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Year1()
            
        End Sub
                
      
        ' To customize, override this method in WFinRepNGP_HeadTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WFinRepNGP_HeadTableControlRow.
        Public Overridable Sub Validate() 
            ' Add custom validation for any control within this panel.
            ' Example.  If you have a State ASP:Textbox control
            ' If Me.State.Text <> "CA" Then
            '    Throw New Exception("State must be CA (California).")
            ' End If

            ' The Validate method is common across all controls within
            ' this panel so you can validate multiple fields, but report
            ' one error message.
            
                
        End Sub

        Public Overridable Sub Delete()
        
            If Me.IsNewRecord() Then
                Return
            End If

            Dim pkValue As KeyValue = KeyValue.XmlToKey(Me.RecordUniqueId)
          WFinRepNGP_HeadTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WFinRepNGP_HeadTableControl"), WFinRepNGP_HeadTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WFinRepNGP_HeadTableControl"), WFinRepNGP_HeadTableControl).ResetData = True
        End Sub

        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction()
                Me.RegisterPostback()

                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                  
                
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    Me.LoadData()
                    Me.DataBind()			
                End If
                                
                						
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction()
            End Try
        End Sub
        
            
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()
        
    
            'Save pagination state to session.
          
        End Sub
        
        
    
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

        

            ' Clear pagination state from session.
        
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)
            Dim isNewRecord As String = CType(ViewState("IsNewRecord"), String)
            If Not isNewRecord Is Nothing AndAlso isNewRecord.Trim <> "" Then
                Me.IsNewRecord = Boolean.Parse(isNewRecord)
            End If
            
            Dim myCheckSum As String = CType(ViewState("CheckSum"), String)
            If Not myCheckSum Is Nothing AndAlso myCheckSum.Trim <> "" Then
                Me.CheckSum = myCheckSum
            End If
            
    
            ' Load view state for pagination control.
                 
        End Sub

        Protected Overrides Function SaveViewState() As Object
            ViewState("IsNewRecord") = Me.IsNewRecord.ToString()
            ViewState("CheckSum") = Me.CheckSum
            
    
            ' Load view state for pagination control.
                  
            Return MyBase.SaveViewState()
        End Function
        
        
    
        ' Generate set method for buttons
        
        Public Overridable Sub SetExpandRowButton()                
              
   
        End Sub
            
        Public Overridable Sub SetimbEdit()                
              
   
        End Sub
            
        Public Overridable Sub SetimbView()                
              
   
        End Sub
            
        Public Overridable Sub SetbtnEdit()                
              
   
        End Sub
            
        Public Overridable Sub SetbtnPreview1()                
              
   
        End Sub
            
        Public Overridable Sub SetbtnPreview2()                
              
   
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub ExpandRowButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
          Dim panelControl as WFinRepNGP_HeadTableControl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRepNGP_HeadTableControl"), WFinRepNGP_HeadTableControl)

          Dim repeatedRows() as WFinRepNGP_HeadTableControlRow = panelControl.GetRecordControls()
          For Each repeatedRow as WFinRepNGP_HeadTableControlRow in repeatedRows
              Dim altRow as System.Web.UI.Control= DirectCast(MiscUtils.FindControlRecursively(repeatedRow, "WFinRepNGP_HeadTableControlAltRow"), System.Web.UI.Control)
              If (altRow IsNot Nothing) Then
                  If (sender Is repeatedRow.ExpandRowButton) Then
                      altRow.Visible = Not altRow.Visible
                  
                  End If                      
                  If (altRow.Visible) Then        
                   
                     repeatedRow.ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow.gif"
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over.gif'")
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow.gif'")
                                     
                  Else
                   
                     repeatedRow.ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow2.gif"
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over2.gif'")
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow2.gif'")
                   
                  End If
              Else
                  Me.Page.Response.Redirect("../Shared/ConfigureCollapseExpandRowBtn.aspx")
              End If
          Next
          
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub imbEdit_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../Shared/ConfigureEditRecord.aspx"
                  
                  If Me.Page.Request("RedirectStyle") <> "" Then url &= "?RedirectStyle=" & Me.Page.Request("RedirectStyle")
                  
        Dim shouldRedirect As Boolean = True
        Dim target As String = ""
      
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",True)
            url = Me.Page.ModifyRedirectUrl(url, "",True)
          
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
      Me.Page.Response.Redirect(url)
        
            End If
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub imbView_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub btnEdit_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../WFinRep_Head/WFinRepNGP-Approver.aspx?WFinRepNGP_Head={WFinRepNGP_HeadTableControlRow:NoUrlEncode:FV:WFRCHNGP_ID}"
                  
                  If Me.Page.Request("RedirectStyle") <> "" Then url &= "&RedirectStyle=" & Me.Page.Request("RedirectStyle")
                  
        Dim shouldRedirect As Boolean = True
        Dim target As String = ""
      
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",True)
            url = Me.Page.ModifyRedirectUrl(url, "",True)
          
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
      Me.Page.Response.Redirect(url)
        
            End If
        End Sub
        
        ' event handler for Button
        Public Overridable Sub btnPreview1_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub btnPreview2_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        Protected Overridable Sub WFRCHNGP_C_ID1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCHNGP_Description1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCHNGP_ID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCHNGP_Month1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCHNGP_Status1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCHNGP_U_ID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCHNGP_Year1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
   
        Private _PreviousUIData As New Hashtable
        Public Overridable Property PreviousUIData() As Hashtable
            Get
                Return _PreviousUIData
            End Get
            Set(ByVal value As Hashtable)
                _PreviousUIData = value
            End Set
        End Property   

        
        Public Property RecordUniqueId() As String
            Get
                Return CType(Me.ViewState("BaseWFinRepNGP_HeadTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWFinRepNGP_HeadTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WFinRepNGP_HeadRecord
            Get
                Return DirectCast(MyBase._DataSource, WFinRepNGP_HeadRecord)
            End Get
            Set(ByVal value As WFinRepNGP_HeadRecord)
                Me._DataSource = value
            End Set
        End Property

        
        Private _checkSum As String
        Public Overridable Property CheckSum() As String
            Get
                Return Me._checkSum
            End Get
            Set(ByVal value As String)
                Me._checkSum = value
            End Set
        End Property
        
        Private _TotalPages As Integer
        Public Property TotalPages() As Integer
            Get
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property
        
        Private _PageIndex As Integer
        Public Property PageIndex() As Integer
            Get
                ' Return the PageIndex
                Return Me._PageIndex
            End Get
            Set(ByVal value As Integer)
                Me._PageIndex = value
            End Set
        End Property
    
        Private _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property
        
        

#Region "Helper Properties"
        
        Public ReadOnly Property btnEdit() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "btnEdit"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property btnPreview1() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "btnPreview1"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property btnPreview2() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "btnPreview2"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property ExpandRowButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ExpandRowButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property imbEdit() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbEdit"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property imbView() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbView"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property WFinRepNGP_ActivityTableControl() As WFinRepNGP_ActivityTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_ActivityTableControl"), WFinRepNGP_ActivityTableControl)
            End Get
        End Property
        
        Public ReadOnly Property WFinRepNGP_AttachmentTableControl() As WFinRepNGP_AttachmentTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_AttachmentTableControl"), WFinRepNGP_AttachmentTableControl)
            End Get
        End Property
        
        Public ReadOnly Property WFinRepNGP_DocAttachTableControl() As WFinRepNGP_DocAttachTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_DocAttachTableControl"), WFinRepNGP_DocAttachTableControl)
            End Get
        End Property
        
        Public ReadOnly Property WFinRepNGP_HeadTabContainer() As AjaxControlToolkit.TabContainer
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_HeadTabContainer"), AjaxControlToolkit.TabContainer)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_C_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_C_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_C_ID1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_C_ID1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_Description() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Description"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_Description1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Description1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_File() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_File"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_ID() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_ID"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_Month() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Month"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_Month1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Month1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_RptCount() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_RptCount"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_Status() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Status"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_Status1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Status1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_U_ID() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_U_ID"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_Year() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Year"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_Year1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Year1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
        
        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As WFinRepNGP_HeadRecord = Nothing
             
        
            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.
                
            Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ePortalWFApproval"))
                    
            End If
            Return EvaluateExpressions(url, arg, rec, bEncrypt)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean,ByVal includeSession as Boolean) As String
            
            Dim rec As WFinRepNGP_HeadRecord = Nothing
             
        
            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.
                
            Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ePortalWFApproval"))
                    
            End If
            If includeSession  Then
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            Else
                Return EvaluateExpressions(url, arg, rec, bEncrypt,False)  
            End If
        End Function

         
        Public Overridable Function GetRecord() As WFinRepNGP_HeadRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WFinRepNGP_HeadTable.GetRecord(Me.RecordUniqueId, True)
                
            End If
            
            ' Localization.
            
            Throw New Exception(Page.GetResourceValue("Err:RetrieveRec", "ePortalWFApproval"))
                
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

End Class

  

' Base class for the WFinRepNGP_HeadTableControl control on the WFinRepNGP_Inquiry page.
' Do not modify this class. Instead override any method in WFinRepNGP_HeadTableControl.
Public Class BaseWFinRepNGP_HeadTableControl
        Inherits ePortalWFApproval.UI.BaseApplicationTableControl

        
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
    
           ' Setup the filter and search.
        
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.WFRCHNGP_C_IDFilter) 				
                    initialVal = Me.GetFromSession(Me.WFRCHNGP_C_IDFilter)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""WFRCHNGP_C_ID"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.WFRCHNGP_C_IDFilter.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.WFRCHNGP_C_IDFilter.SelectedValue = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.WFRCHNGP_MonthFilter) 				
                    initialVal = Me.GetFromSession(Me.WFRCHNGP_MonthFilter)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""WFRCHNGP_Month"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.WFRCHNGP_MonthFilter.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.WFRCHNGP_MonthFilter.SelectedValue = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.WFRCHNGP_StatusFilter) 				
                    initialVal = Me.GetFromSession(Me.WFRCHNGP_StatusFilter)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""WFRCHNGP_Status"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.WFRCHNGP_StatusFilter.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.WFRCHNGP_StatusFilter.SelectedValue = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.WFRCHNGP_YearFromFilter) 				
                    initialVal = Me.GetFromSession(Me.WFRCHNGP_YearFromFilter)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""WFRCHNGP_YearFrom"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.WFRCHNGP_YearFromFilter.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.WFRCHNGP_YearFromFilter.SelectedValue = initialVal
                            
                    End If
                
            End If

      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
         
            Else
                   
                Me.CurrentSortOrder = New OrderBy(True, False)
            
        End If

    

    ' Setup default pagination settings.
    
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
        
            
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
            ' Setup the pagination events.
            
              AddHandler Me.Pagination.FirstPage.Click, AddressOf Pagination_FirstPage_Click
                        
              AddHandler Me.Pagination.LastPage.Click, AddressOf Pagination_LastPage_Click
                        
              AddHandler Me.Pagination.NextPage.Click, AddressOf Pagination_NextPage_Click
                        
              AddHandler Me.Pagination.PageSizeButton.Click, AddressOf Pagination_PageSizeButton_Click
                        
              AddHandler Me.Pagination.PreviousPage.Click, AddressOf Pagination_PreviousPage_Click
                                    
            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.
          
            ' Setup the button events.
          
              AddHandler Me.GoButton.Button.Click, AddressOf GoButton_Click
                        
              AddHandler Me.WFRCHNGP_C_IDFilter.SelectedIndexChanged, AddressOf WFRCHNGP_C_IDFilter_SelectedIndexChanged
            
              AddHandler Me.WFRCHNGP_MonthFilter.SelectedIndexChanged, AddressOf WFRCHNGP_MonthFilter_SelectedIndexChanged
            
              AddHandler Me.WFRCHNGP_StatusFilter.SelectedIndexChanged, AddressOf WFRCHNGP_StatusFilter_SelectedIndexChanged
            
              AddHandler Me.WFRCHNGP_YearFromFilter.SelectedIndexChanged, AddressOf WFRCHNGP_YearFromFilter_SelectedIndexChanged
                    
        
          ' Setup events for others
                
        End Sub
        
        
        Public Overridable Sub LoadData()        
        
            ' Read data from database. Returns an array of records that can be assigned
            ' to the DataSource table control property.
            Try	
                Dim joinFilter As CompoundFilter = CreateCompoundJoinFilter()
                
                ' The WHERE clause will be empty when displaying all records in table.
                Dim wc As WhereClause = CreateWhereClause()
                If wc IsNot Nothing AndAlso Not wc.RunQuery Then
                    ' Initialize an empty array of records
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WFinRepNGP_HeadRecord)), WFinRepNGP_HeadRecord())
                    ' Add records to the list if needed.
                    Me.AddNewRecords()
                    Me._TotalRecords = 0
                    Me._TotalPages = 0
                    Return
                End If

                ' Call OrderBy to determine the order - either use the order defined
                ' on the Query Wizard, or specified by user (by clicking on column heading)
                Dim orderBy As OrderBy = CreateOrderBy()
                
                ' Get the pagesize from the pagesize control.
                Me.GetPageSize()
                               
                If Me.DisplayLastPage Then
                    Dim totalRecords As Integer = If(Me._TotalRecords < 0, GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()), Me._TotalRecords)
                     
                      Dim totalPages As Integer = CInt(Math.Ceiling(totalRecords / Me.PageSize))
                    
                    Me.PageIndex = totalPages - 1
                End If                               
                
                ' Make sure PageIndex (current page) and PageSize are within bounds.
                If Me.PageIndex < 0 Then
                    Me.PageIndex = 0
                End If
                If Me.PageSize < 1 Then
                    Me.PageSize = 1
                End If
                
                ' Retrieve the records and set the table DataSource.
                ' Only PageSize records are fetched starting at PageIndex (zero based).
                If Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                    Dim postdata As New ArrayList
                    For Each rc As WFinRepNGP_HeadTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WFinRepNGP_HeadRecord)), WFinRepNGP_HeadRecord())
                Else  ' Get the records from the database	
                      
                        Me.DataSource = GetRecords(joinFilter, wc, orderBy, Me.PageIndex, Me.PageSize)
                      
                End If
                
                ' if the datasource contains no records contained in database, then load the last page.
                If (DbUtils.GetCreatedRecords(Me.DataSource).Length = 0 AndAlso Not Me.DisplayLastPage) Then
                      Me.DisplayLastPage = True
                      LoadData()
                Else
                
                    ' Add any new rows desired by the user.
                    Me.AddNewRecords()
                       

                    ' Initialize the page and grand totals. now
                
                End If
    
            Catch ex As Exception
                ' Report the error message to the end user
                Dim msg As String = ex.Message
                If ex.InnerException IsNot Nothing Then
                    msg = msg & " InnerException: " & ex.InnerException.Message
                End If
                Throw New Exception(msg, ex.InnerException)
            End Try
        End Sub
        
        Public Overridable Function GetRecords( _
            ByVal join As BaseFilter, _
            ByVal where As WhereClause, _
            ByVal orderBy As OrderBy, _
            ByVal pageIndex As Integer, _
            ByVal pageSize As Integer) As WFinRepNGP_HeadRecord()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRepNGP_HeadTable.Column1, True)         
            ' selCols.Add(WFinRepNGP_HeadTable.Column2, True)          
            ' selCols.Add(WFinRepNGP_HeadTable.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WFinRepNGP_HeadTable.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WFinRepNGP_HeadTable
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WFinRepNGP_HeadRecord)), WFinRepNGP_HeadRecord())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRepNGP_HeadTable.Column1, True)         
            ' selCols.Add(WFinRepNGP_HeadTable.Column2, True)          
            ' selCols.Add(WFinRepNGP_HeadTable.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WFinRepNGP_HeadTable.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WFinRepNGP_HeadTable
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)           
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
                
                Return CInt(databaseTable.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
            End If

        End Function        
        
      
    
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record for each row in the table.  To do this, it calls the
            ' DataBind for each of the rows.
            ' DataBind also populates any filters above the table, and sets the pagination
            ' control to the correct number of records and the current page number.
            
            
              MyBase.DataBind()
            
    
            Me.ClearControlsFromSession()    

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
            
            'LoadData for DataSource for chart and report if they exist
          
          ' Improve performance by prefetching display as records.
          Me.PreFetchForeignKeyValues()
             
            ' Setup the pagination controls.
            BindPaginationControls()

      

    
        
          ' Bind the repeater with the list of records to expand the UI.
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_HeadTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WFinRepNGP_HeadTableControlRow = DirectCast(repItem.FindControl("WFinRepNGP_HeadTableControlRow"), WFinRepNGP_HeadTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                
                
                
                SetWFRCHNGP_C_IDFilter()
                SetWFRCHNGP_C_IDLabel()
                SetWFRCHNGP_C_IDLabel1()
                SetWFRCHNGP_DescriptionLabel()
                SetWFRCHNGP_MonthFilter()
                SetWFRCHNGP_MonthLabel()
                SetWFRCHNGP_MonthLabel1()
                SetWFRCHNGP_RptCountLabel()
                SetWFRCHNGP_StatusFilter()
                SetWFRCHNGP_StatusLabel()
                SetWFRCHNGP_StatusLabel1()
                SetWFRCHNGP_YearFromFilter()
                SetWFRCHNGP_YearLabel()
                SetWFRCHNGP_YearLabel1()
                SetGoButton()
              
            ' setting the state of expand or collapse alternative rows
      
            Dim expandFirstRow As Boolean= False   
        
            Dim recControls() As WFinRepNGP_HeadTableControlRow = Me.GetRecordControls()
            For i As Integer = 0 to recControls.Length - 1
                Dim altRow As System.Web.UI.Control = DirectCast(MiscUtils.FindControlRecursively(recControls(i), "WFinRepNGP_HeadTableControlAltRow"), System.Web.UI.Control)
                If (altRow IsNot Nothing) Then
                    If (expandFirstRow AndAlso i = 0) Then                
                        altRow.Visible = True
                   
                         recControls(i).ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow.gif"
                         recControls(i).ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over.gif'")
                         recControls(i).ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow.gif'")
                   
                    Else                
                        altRow.Visible = False
                   
                         recControls(i).ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow2.gif"
                         recControls(i).ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over2.gif'")
                         recControls(i).ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow2.gif'")
                   
                    End If
                End If
            Next
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                
      
            ' this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls()
            
                    
            
      End Sub
      
        Public Overridable Sub SetFormulaControls()
            ' this method calls Set methods for the control that has special formula
        
        

    End Sub

    
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(WFinRepNGP_HeadTable.WFRCHNGP_Month, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRepNGP_HeadTable.WFRCHNGP_Month, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRepNGP_HeadTable.WFRCHNGP_Status, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRepNGP_HeadTable.WFRCHNGP_Status, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRepNGP_HeadTable.WFRCHNGP_U_ID, Me.DataSource)
          
          End Sub
        
      
        Public Overridable Sub RegisterPostback()
        
        
        End Sub

        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean, ByVal e as FormulaEvaluator) As String
            If e Is Nothing
                e = New FormulaEvaluator()
            End If
            
            e.Variables.Clear()
            
            
            ' add variables for formula evaluation
            If variables IsNot Nothing Then
                Dim enumerator As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) = variables.GetEnumerator()
                While enumerator.MoveNext()
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value)
                End While
            End If
            
            If includeDS
                
            End If
            
            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If
            
            If Not String.IsNullOrEmpty(format) AndAlso (String.IsNullOrEmpty(formula) OrElse formula.IndexOf("Format(") < 0) Then
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function			

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format,variables ,includeDS, Nothing)        
        End Function        

        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables ,True, Nothing)        
        End Function        

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e as FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS as Boolean) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
        End Function




        Public Overridable Sub ResetControl()

            
            Me.WFRCHNGP_C_IDFilter.ClearSelection()
            
            Me.WFRCHNGP_MonthFilter.ClearSelection()
            
            Me.WFRCHNGP_StatusFilter.ClearSelection()
            
            Me.WFRCHNGP_YearFromFilter.ClearSelection()
            
            Me.CurrentSortOrder.Reset()
            If (Me.InSession(Me, "Order_By")) Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
                
            End If
                
            Me.PageIndex = 0
        End Sub

        Public Overridable Sub ResetPageControl()
            Me.PageIndex = 0
        End Sub
        
        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the pagination labels.
        
            If DbUtils.GetCreatedRecords(Me.DataSource).Length > 0 Then                      
                    
                Me.Pagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Pagination.CurrentPage.Text = "0"
            End If
            Me.Pagination.PageSize.Text = Me.PageSize.ToString()
            Me.Pagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.Pagination.TotalPages.Text = Me.TotalPages.ToString()

            ' Bind the buttons for WFinRepNGP_HeadTableControl pagination.
        
            Me.Pagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination.LastPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination.NextPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            Me.Pagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As WFinRepNGP_HeadTableControlRow
            For Each recCtl In Me.GetRecordControls()
        
                If Me.InDeletedRecordIds(recCtl) Then
                    ' Delete any pending deletes. 
                    recCtl.Delete()
                Else
                    If recCtl.Visible Then
                        recCtl.SaveData()
                    End If
                End If
          
            Next
            
            
          
    
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
          
            ' Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            For Each recCtl In Me.GetRecordControls()
                recCtl.IsNewRecord = False
            Next
    
      
            ' Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            Me.DeletedRecordIds = Nothing
      
        End Sub

        Public Overridable Function CreateCompoundJoinFilter() As CompoundFilter
            Dim jFilter As CompoundFilter = New CompoundFilter()
         
            Return jFilter
        End Function

      
          Public Overridable Function CreateOrderBy() As OrderBy
          ' The CurrentSortOrder is initialized to the sort order on the
          ' Query Wizard.  It may be modified by the Click handler for any of
          ' the column heading to sort or reverse sort by that column.
          ' You can add your own sort order, or modify it on the Query Wizard.
          Return Me.CurrentSortOrder
          End Function
      
        Public Overridable Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            WFinRepNGP_HeadTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
            If IsValueSelected(Me.WFRCHNGP_C_IDFilter) Then
    
              hasFiltersWFinRepNGP_HeadTableControl = True            
    
                wc.iAND(WFinRepNGP_HeadTable.WFRCHNGP_C_ID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.WFRCHNGP_C_IDFilter, Me.GetFromSession(Me.WFRCHNGP_C_IDFilter)), False, False)
            
            End If
                  
                
                       
            If IsValueSelected(Me.WFRCHNGP_MonthFilter) Then
    
              hasFiltersWFinRepNGP_HeadTableControl = True            
    
                wc.iAND(WFinRepNGP_HeadTable.WFRCHNGP_Month, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.WFRCHNGP_MonthFilter, Me.GetFromSession(Me.WFRCHNGP_MonthFilter)), False, False)
            
            End If
                  
                
                       
            If IsValueSelected(Me.WFRCHNGP_StatusFilter) Then
    
              hasFiltersWFinRepNGP_HeadTableControl = True            
    
                wc.iAND(WFinRepNGP_HeadTable.WFRCHNGP_Status, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.WFRCHNGP_StatusFilter, Me.GetFromSession(Me.WFRCHNGP_StatusFilter)), False, False)
            
            End If
                  
                
                       
            If IsValueSelected(Me.WFRCHNGP_YearFromFilter) Then
    
              hasFiltersWFinRepNGP_HeadTableControl = True            
    
                wc.iAND(WFinRepNGP_HeadTable.WFRCHNGP_Year, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, MiscUtils.GetSelectedValue(Me.WFRCHNGP_YearFromFilter, Me.GetFromSession(Me.WFRCHNGP_YearFromFilter)), False, False)
            
            End If
                  
                
                         
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WFinRepNGP_HeadTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            Dim WFRCHNGP_C_IDFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "WFRCHNGP_C_IDFilter_Ajax"), String)
            If IsValueSelected(WFRCHNGP_C_IDFilterSelectedValue) Then
    
              hasFiltersWFinRepNGP_HeadTableControl = True            
    
                 wc.iAND(WFinRepNGP_HeadTable.WFRCHNGP_C_ID, BaseFilter.ComparisonOperator.EqualsTo, WFRCHNGP_C_IDFilterSelectedValue, false, False)
             
             End If
                      
            Dim WFRCHNGP_MonthFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "WFRCHNGP_MonthFilter_Ajax"), String)
            If IsValueSelected(WFRCHNGP_MonthFilterSelectedValue) Then
    
              hasFiltersWFinRepNGP_HeadTableControl = True            
    
                 wc.iAND(WFinRepNGP_HeadTable.WFRCHNGP_Month, BaseFilter.ComparisonOperator.EqualsTo, WFRCHNGP_MonthFilterSelectedValue, false, False)
             
             End If
                      
            Dim WFRCHNGP_StatusFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "WFRCHNGP_StatusFilter_Ajax"), String)
            If IsValueSelected(WFRCHNGP_StatusFilterSelectedValue) Then
    
              hasFiltersWFinRepNGP_HeadTableControl = True            
    
                 wc.iAND(WFinRepNGP_HeadTable.WFRCHNGP_Status, BaseFilter.ComparisonOperator.EqualsTo, WFRCHNGP_StatusFilterSelectedValue, false, False)
             
             End If
                      
            Dim WFRCHNGP_YearFromFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "WFRCHNGP_YearFromFilter_Ajax"), String)
            If IsValueSelected(WFRCHNGP_YearFromFilterSelectedValue) Then
    
              hasFiltersWFinRepNGP_HeadTableControl = True            
    
                 wc.iAND(WFinRepNGP_HeadTable.WFRCHNGP_Year, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, WFRCHNGP_YearFromFilterSelectedValue, false, False)
             
             End If
                      
      
      
            Return wc
        End Function

      

         Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                         ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                         ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                         ByVal resultList As ArrayList) As Boolean
              Return FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText, _
                                       autoTypeAheadSearch, AutoTypeAheadWordSeparators, _
                                       resultList, False)
         End Function

        Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                               ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                               ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                               ByVal resultList As ArrayList, ByVal stripHTML As Boolean) As Boolean
            If stripHTML Then
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText)
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem)
            End If
            'Formats the resultItem and adds it to the list of suggestions.
            Dim index As Integer = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))
            Dim itemToAdd As String = ""
            Dim isFound As Boolean = False
            Dim isAdded As Boolean = False
            ' Get the index where prfixt is at the beginning of resultItem. If not found then, index of word which begins with prefixText.
            If InvariantLCase(autoTypeAheadSearch).equals("wordsstartingwithsearchstring") And Not index = 0 Then
                ' Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex(AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                If regex1.IsMatch(resultItem) Then
                    index = regex1.Match(resultItem).Index
                    isFound = True
                End If
                ' If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                If Not resultItem(index).ToString() = " " Then
                    ' Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    If regex.IsMatch(resultItem) Then
                        index = regex.Match(resultItem).Index
                        isFound = True
                    End If
                End If
            End If

            ' If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            ' beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            If index = 0 Or isFound Or InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") Then
                If InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atbeginningofmatchedstring") Then
                    ' Expression to find beginning of the word which contains prefixText
                    Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    '  Find the beginning of the word which contains prefexText
                    If (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") AndAlso regex1.IsMatch(resultItem)) Then
                        index = regex1.Match(resultItem).Index
                        isFound = True
                    End If
                    ' Display string from the index till end of the string if sub string from index till end is less than columnLength value.
                    If Len(resultItem) - index <= columnLength Then
                        If index = 0 Then
                            itemToAdd = resultItem
                        Else                            
                            itemToAdd = resultItem.Substring(index)
                        End If
                    Else                       
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward)
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("inmiddleofmatchedstring") Then
                    Dim subStringBeginIndex As Integer = CType(columnLength / 2, Integer)
                    If Len(resultItem) <= columnLength Then
                        itemToAdd = resultItem
                    Else
                        ' Sanity check at end of the string
                        If index + Len(prefixText) >= Len(resultItem) - 1 OrElse _
                        Len(resultItem) - index < subStringBeginIndex Then                           
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, Len(resultItem) - 1 - columnLength, Len(resultItem) - 1, StringUtils.Direction.backward)
                        ElseIf index <= subStringBeginIndex Then
                            ' Sanity check at beginning of the string                          
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward)
                        Else
                            ' Display string containing text before the prefixText occures and text after the prefixText                         
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both)
                        End If
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atendofmatchedstring") Then
                    ' Expression to find ending of the word which contains prefexText
                    Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    ' Find the ending of the word which contains prefexText
                    If regex1.IsMatch(resultItem, index + 1) Then
                        index = regex1.Match(resultItem, index + 1).Index
                    Else
                        ' If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length
                    End If
                    If index > Len(resultItem) Then
                        index = Len(resultItem)
                    End If
                    ' If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    If index <= columnLength Then
                        itemToAdd = resultItem.Substring(0, index)
                    Else
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward)
                    End If
                End If

                ' Remove newline character from itemToAdd
                Dim prefixTextIndex As Integer = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase)
                If prefixTextIndex < 0 Then Return False
                ' If itemToAdd contains any newline after the search text then show text only till newline
                Dim regex2 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                Dim newLineIndexAfterPrefix As Integer = -1
                If regex2.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexAfterPrefix > -1) Then
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix)
                End If
                ' If itemToAdd contains any newline before search text then show text which comes after newline
                Dim regex3 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", (System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.RightToLeft))
                Dim newLineIndexBeforePrefix As Integer = -1
                If regex3.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexBeforePrefix > -1) Then
                    itemToAdd = itemToAdd.Substring((newLineIndexBeforePrefix + regex3.Match(itemToAdd, prefixTextIndex).Length))
                End If

                If Not String.IsNullOrEmpty(itemToAdd) AndAlso Not resultList.Contains(itemToAdd) Then
                   
                    resultList.Add(itemToAdd)
          				
                    isAdded = True
                End If
            End If
            Return isAdded
        End Function
        
    
        Protected Overridable Sub GetPageSize()
        
            If Me.Pagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.Pagination.PageSize.Text)
                Catch ex As Exception
                End Try
            End If
        End Sub

        Protected Overridable Sub AddNewRecords()
          
            Dim newRecordList As ArrayList = New ArrayList()
          
    Dim newUIDataList As System.Collections.Generic.List(Of Hashtable) = New System.Collections.Generic.List(Of Hashtable)()

    ' Loop though all the record controls and if the record control
    ' does not have a unique record id set, then create a record
    ' and add to the list.
    If Not Me.ResetData Then
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_HeadTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WFinRepNGP_HeadTableControlRow = DirectCast(repItem.FindControl("WFinRepNGP_HeadTableControlRow"), WFinRepNGP_HeadTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WFinRepNGP_HeadRecord = New WFinRepNGP_HeadRecord()
        
                        If recControl.WFRCHNGP_C_ID.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_C_ID.Text, WFinRepNGP_HeadTable.WFRCHNGP_C_ID)
                        End If
                        If recControl.WFRCHNGP_C_ID1.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_C_ID1.Text, WFinRepNGP_HeadTable.WFRCHNGP_C_ID)
                        End If
                        If recControl.WFRCHNGP_Description.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_Description.Text, WFinRepNGP_HeadTable.WFRCHNGP_Description)
                        End If
                        If recControl.WFRCHNGP_Description1.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_Description1.Text, WFinRepNGP_HeadTable.WFRCHNGP_Description)
                        End If
                        If recControl.WFRCHNGP_File.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_File.Text, WFinRepNGP_HeadTable.WFRCHNGP_File)
                        End If
                        If recControl.WFRCHNGP_ID.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_ID.Text, WFinRepNGP_HeadTable.WFRCHNGP_ID)
                        End If
                        If recControl.WFRCHNGP_Month.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_Month.Text, WFinRepNGP_HeadTable.WFRCHNGP_Month)
                        End If
                        If recControl.WFRCHNGP_Month1.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_Month1.Text, WFinRepNGP_HeadTable.WFRCHNGP_Month)
                        End If
                        If recControl.WFRCHNGP_RptCount.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_RptCount.Text, WFinRepNGP_HeadTable.WFRCHNGP_RptCount)
                        End If
                        If recControl.WFRCHNGP_Status.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_Status.Text, WFinRepNGP_HeadTable.WFRCHNGP_Status)
                        End If
                        If recControl.WFRCHNGP_Status1.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_Status1.Text, WFinRepNGP_HeadTable.WFRCHNGP_Status)
                        End If
                        If recControl.WFRCHNGP_U_ID.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_U_ID.Text, WFinRepNGP_HeadTable.WFRCHNGP_U_ID)
                        End If
                        If recControl.WFRCHNGP_Year.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_Year.Text, WFinRepNGP_HeadTable.WFRCHNGP_Year)
                        End If
                        If recControl.WFRCHNGP_Year1.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_Year1.Text, WFinRepNGP_HeadTable.WFRCHNGP_Year)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WFinRepNGP_HeadRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WFinRepNGP_HeadRecord)), WFinRepNGP_HeadRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WFinRepNGP_HeadTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WFinRepNGP_HeadTableControlRow) As Boolean
            If Me.DeletedRecordIds Is Nothing OrElse Me.DeletedRecordIds.Trim = "" Then
                Return False
            End If

            Return Me.DeletedRecordIds.IndexOf("[" & rec.RecordUniqueId & "]") >= 0
        End Function

        Private _DeletedRecordIds As String
        Public Property DeletedRecordIds() As String
            Get
                Return Me._DeletedRecordIds
            End Get
            Set(ByVal value As String)
                Me._DeletedRecordIds = value
            End Set
        End Property
        
      
        ' Create Set, WhereClause, and Populate Methods
        
        Public Overridable Sub SetWFRCHNGP_C_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCHNGP_C_IDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRCHNGP_C_IDLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCHNGP_C_IDLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRCHNGP_DescriptionLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCHNGP_DescriptionLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRCHNGP_MonthLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCHNGP_MonthLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRCHNGP_MonthLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCHNGP_MonthLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRCHNGP_RptCountLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCHNGP_RptCountLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRCHNGP_StatusLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCHNGP_StatusLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRCHNGP_StatusLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCHNGP_StatusLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRCHNGP_YearLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCHNGP_YearLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRCHNGP_YearLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCHNGP_YearLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRCHNGP_C_IDFilter()

              
            
                Me.PopulateWFRCHNGP_C_IDFilter(GetSelectedValue(Me.WFRCHNGP_C_IDFilter,  GetFromSession(Me.WFRCHNGP_C_IDFilter)), 500)					
                                     
              End Sub	
            
        Public Overridable Sub SetWFRCHNGP_MonthFilter()

              
            
                Me.PopulateWFRCHNGP_MonthFilter(GetSelectedValue(Me.WFRCHNGP_MonthFilter,  GetFromSession(Me.WFRCHNGP_MonthFilter)), 500)					
                                     
              End Sub	
            
        Public Overridable Sub SetWFRCHNGP_StatusFilter()

              
            
                Me.PopulateWFRCHNGP_StatusFilter(GetSelectedValue(Me.WFRCHNGP_StatusFilter,  GetFromSession(Me.WFRCHNGP_StatusFilter)), 500)					
                                     
              End Sub	
            
        Public Overridable Sub SetWFRCHNGP_YearFromFilter()

              
            
                Me.PopulateWFRCHNGP_YearFromFilter(GetSelectedValue(Me.WFRCHNGP_YearFromFilter,  GetFromSession(Me.WFRCHNGP_YearFromFilter)), 500)					
                                     
              End Sub	
            
        ' Get the filters' data for WFRCHNGP_C_IDFilter
        Protected Overridable Sub PopulateWFRCHNGP_C_IDFilter(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Me.WFRCHNGP_C_IDFilter.Items.Clear()
            Dim wc As WhereClause = Me.CreateWhereClause_WFRCHNGP_C_IDFilter()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WFRCHNGP_C_IDFilter function.
            ' It is better to customize the where clause there.
            
            ' Setup the static list items        
            							
            Me.WFRCHNGP_C_IDFilter.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Please Select"), "--ANY--"))
                            
            
            
            Dim orderBy As OrderBy = New OrderBy(False, False)
            orderBy.Add(WFinRepNGP_HeadTable.WFRCHNGP_C_ID, OrderByItem.OrderDir.Asc)                
            
            	

            Dim values(-1) As String
            If wc.RunQuery Then
            
                values = WFinRepNGP_HeadTable.GetValues(WFinRepNGP_HeadTable.WFRCHNGP_C_ID, wc, orderBy, maxItems)
            
            End If
            
                  
            Dim cvalue As String
            
            Dim listDuplicates As New ArrayList()
            For Each cvalue In values
                ' Create the item and add to the list.
                Dim fvalue As String
                If ( WFinRepNGP_HeadTable.WFRCHNGP_C_ID.IsColumnValueTypeBoolean()) Then
                    fvalue = cvalue
                Else
                    fvalue = WFinRepNGP_HeadTable.WFRCHNGP_C_ID.Format(cvalue)
                End If

                If (IsNothing(fvalue)) Then
                    fvalue = ""
                End If

                fvalue = fvalue.Trim()

                If ( fvalue.Length > 50 ) Then
                    fvalue = fvalue.Substring(0, 50) & "..."
                End If

                Dim dupItem As ListItem = Me.WFRCHNGP_C_IDFilter.Items.FindByText(fvalue)
                
                If Not IsNothing(dupItem) Then
                    listDuplicates.Add(fvalue)
                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                    End If
                End If

                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                Me.WFRCHNGP_C_IDFilter.Items.Add(newItem)

                If listDuplicates.Contains(fvalue)  AndAlso Not String.IsNullOrEmpty(cvalue) Then
                    newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                End If
            Next
                                  

            Try    
                
                ' Set the selected value.
                SetSelectedValue(Me.WFRCHNGP_C_IDFilter, selectedValue)
                    
            Catch
            End Try
            
                        
            If Me.WFRCHNGP_C_IDFilter.SelectedValue IsNot Nothing AndAlso Me.WFRCHNGP_C_IDFilter.Items.FindByValue(Me.WFRCHNGP_C_IDFilter.SelectedValue) Is Nothing
                Me.WFRCHNGP_C_IDFilter.SelectedValue = Nothing
            End If            
                          
        End Sub
            
        ' Get the filters' data for WFRCHNGP_MonthFilter
        Protected Overridable Sub PopulateWFRCHNGP_MonthFilter(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Me.WFRCHNGP_MonthFilter.Items.Clear()
            Dim wc As WhereClause = Me.CreateWhereClause_WFRCHNGP_MonthFilter()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WFRCHNGP_MonthFilter function.
            ' It is better to customize the where clause there.
            
            ' Setup the static list items        
            							
            Me.WFRCHNGP_MonthFilter.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Please Select"), "--ANY--"))
                            

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(Vw_WFinRep_DocAttach_FIN_MonthView.Mo, OrderByItem.OrderDir.Asc)
              orderBy.Add(Vw_WFinRep_DocAttach_FIN_MonthView.MoName, OrderByItem.OrderDir.Asc)

            Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)

            	

            Dim noValueFormat As String = Page.GetResourceValue("Txt:Other", "ePortalWFApproval")
            

            Dim itemValues() As Vw_WFinRep_DocAttach_FIN_MonthRecord = Nothing
            
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim evaluator As New FormulaEvaluator
                Dim listDuplicates As New ArrayList()

                
                
                Do
                    
                    itemValues = Vw_WFinRep_DocAttach_FIN_MonthView.GetRecords(wc, orderBy, pageNum, maxItems)
                                    
                    For each itemValue As Vw_WFinRep_DocAttach_FIN_MonthRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.MoSpecified Then
                            cvalue = itemValue.Mo.ToString()

                            If counter < maxItems AndAlso Me.WFRCHNGP_MonthFilter.Items.FindByValue(cvalue) Is Nothing  Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_HeadTable.WFRCHNGP_Month)
                                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_HeadTable.WFRCHNGP_Month.IsApplyDisplayAs Then
                                    fvalue = WFinRepNGP_HeadTable.GetDFKA(itemValue, WFinRepNGP_HeadTable.WFRCHNGP_Month)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                    fvalue = itemValue.Format(Vw_WFinRep_DocAttach_FIN_MonthView.Mo)
                                End If
                                    
                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                   fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If ( fvalue.Length > 50 ) Then
                                   fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.WFRCHNGP_MonthFilter.Items.FindByText(fvalue)
                
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.WFRCHNGP_MonthFilter.Items.Add(newItem)

                                If listDuplicates.Contains(fvalue) AndAlso Not String.IsNullOrEmpty(cvalue) Then
                                    newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                                End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If			
            


                               

            Try    
                
                ' Set the selected value.
                SetSelectedValue(Me.WFRCHNGP_MonthFilter, selectedValue)
                    
            Catch
            End Try
            
                        
            If Me.WFRCHNGP_MonthFilter.SelectedValue IsNot Nothing AndAlso Me.WFRCHNGP_MonthFilter.Items.FindByValue(Me.WFRCHNGP_MonthFilter.SelectedValue) Is Nothing
                Me.WFRCHNGP_MonthFilter.SelectedValue = Nothing
            End If            
                          
        End Sub
            
        ' Get the filters' data for WFRCHNGP_StatusFilter
        Protected Overridable Sub PopulateWFRCHNGP_StatusFilter(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Me.WFRCHNGP_StatusFilter.Items.Clear()
            Dim wc As WhereClause = Me.CreateWhereClause_WFRCHNGP_StatusFilter()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WFRCHNGP_StatusFilter function.
            ' It is better to customize the where clause there.
            
            ' Setup the static list items        
            							
            Me.WFRCHNGP_StatusFilter.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Please Select"), "--ANY--"))
                            

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(WFin_ApprovalStatusTable.WPO_STAT_DESC, OrderByItem.OrderDir.Asc)

            Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)

            	

            Dim noValueFormat As String = Page.GetResourceValue("Txt:Other", "ePortalWFApproval")
            

            Dim itemValues() As WFin_ApprovalStatusRecord = Nothing
            
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim evaluator As New FormulaEvaluator
                Dim listDuplicates As New ArrayList()

                
                
                Do
                    
                    itemValues = WFin_ApprovalStatusTable.GetRecords(wc, orderBy, pageNum, maxItems)
                                    
                    For each itemValue As WFin_ApprovalStatusRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WPO_STAT_CDSpecified Then
                            cvalue = itemValue.WPO_STAT_CD.ToString()

                            If counter < maxItems AndAlso Me.WFRCHNGP_StatusFilter.Items.FindByValue(cvalue) Is Nothing  Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_HeadTable.WFRCHNGP_Status)
                                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_HeadTable.WFRCHNGP_Status.IsApplyDisplayAs Then
                                    fvalue = WFinRepNGP_HeadTable.GetDFKA(itemValue, WFinRepNGP_HeadTable.WFRCHNGP_Status)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                    fvalue = itemValue.Format(WFin_ApprovalStatusTable.WPO_STAT_CD)
                                End If
                                    
                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                   fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If ( fvalue.Length > 50 ) Then
                                   fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.WFRCHNGP_StatusFilter.Items.FindByText(fvalue)
                
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.WFRCHNGP_StatusFilter.Items.Add(newItem)

                                If listDuplicates.Contains(fvalue) AndAlso Not String.IsNullOrEmpty(cvalue) Then
                                    newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                                End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If			
            


                               

            Try    
                
                ' Set the selected value.
                SetSelectedValue(Me.WFRCHNGP_StatusFilter, selectedValue)
                    
            Catch
            End Try
            
                        
            If Me.WFRCHNGP_StatusFilter.SelectedValue IsNot Nothing AndAlso Me.WFRCHNGP_StatusFilter.Items.FindByValue(Me.WFRCHNGP_StatusFilter.SelectedValue) Is Nothing
                Me.WFRCHNGP_StatusFilter.SelectedValue = Nothing
            End If            
                          
        End Sub
            
        ' Get the filters' data for WFRCHNGP_YearFromFilter
        Protected Overridable Sub PopulateWFRCHNGP_YearFromFilter(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Me.WFRCHNGP_YearFromFilter.Items.Clear()
            Dim wc As WhereClause = Me.CreateWhereClause_WFRCHNGP_YearFromFilter()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WFRCHNGP_YearFromFilter function.
            ' It is better to customize the where clause there.
            
            ' Setup the static list items        
            							
            Me.WFRCHNGP_YearFromFilter.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Please Select"), "--ANY--"))
                            
            
            
            Dim orderBy As OrderBy = New OrderBy(False, False)
            orderBy.Add(WFinRepNGP_HeadTable.WFRCHNGP_Year, OrderByItem.OrderDir.Asc)                
            
            	

            Dim values(-1) As String
            If wc.RunQuery Then
            
                values = WFinRepNGP_HeadTable.GetValues(WFinRepNGP_HeadTable.WFRCHNGP_Year, wc, orderBy, maxItems)
            
            End If
            
                  
            Dim cvalue As String
            
            Dim listDuplicates As New ArrayList()
            For Each cvalue In values
                ' Create the item and add to the list.
                Dim fvalue As String
                If ( WFinRepNGP_HeadTable.WFRCHNGP_Year.IsColumnValueTypeBoolean()) Then
                    fvalue = cvalue
                Else
                    fvalue = WFinRepNGP_HeadTable.WFRCHNGP_Year.Format(cvalue)
                End If

                If (IsNothing(fvalue)) Then
                    fvalue = ""
                End If

                fvalue = fvalue.Trim()

                If ( fvalue.Length > 50 ) Then
                    fvalue = fvalue.Substring(0, 50) & "..."
                End If

                Dim dupItem As ListItem = Me.WFRCHNGP_YearFromFilter.Items.FindByText(fvalue)
                
                If Not IsNothing(dupItem) Then
                    listDuplicates.Add(fvalue)
                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                    End If
                End If

                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                Me.WFRCHNGP_YearFromFilter.Items.Add(newItem)

                If listDuplicates.Contains(fvalue)  AndAlso Not String.IsNullOrEmpty(cvalue) Then
                    newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                End If
            Next
                                  

            Try    
                
                ' Set the selected value.
                SetSelectedValue(Me.WFRCHNGP_YearFromFilter, selectedValue)
                    
            Catch
            End Try
            
                        
            If Me.WFRCHNGP_YearFromFilter.SelectedValue IsNot Nothing AndAlso Me.WFRCHNGP_YearFromFilter.Items.FindByValue(Me.WFRCHNGP_YearFromFilter.SelectedValue) Is Nothing
                Me.WFRCHNGP_YearFromFilter.SelectedValue = Nothing
            End If            
                          
        End Sub
            
              

        Public Overridable Function CreateWhereClause_WFRCHNGP_C_IDFilter() As WhereClause
          
              Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False
            
              Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False
            
              Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False
            
              Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False
            
            ' Create a where clause for the filter WFRCHNGP_C_IDFilter.
            ' This function is called by the Populate method to load the items 
            ' in the WFRCHNGP_C_IDFilterDropDownList
            
            Dim wc As WhereClause= New WhereClause()
            Return wc
            
        End Function			
            
              

        Public Overridable Function CreateWhereClause_WFRCHNGP_MonthFilter() As WhereClause
          
              Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False
            
              Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False
            
              Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False
            
              Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False
            
            ' Create a where clause for the filter WFRCHNGP_MonthFilter.
            ' This function is called by the Populate method to load the items 
            ' in the WFRCHNGP_MonthFilterDropDownList
            
            Dim wc As WhereClause= New WhereClause()
            Return wc
            
        End Function			
            
              

        Public Overridable Function CreateWhereClause_WFRCHNGP_StatusFilter() As WhereClause
          
              Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False
            
              Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False
            
              Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False
            
              Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False
            
            ' Create a where clause for the filter WFRCHNGP_StatusFilter.
            ' This function is called by the Populate method to load the items 
            ' in the WFRCHNGP_StatusFilterDropDownList
            
            Dim wc As WhereClause= New WhereClause()
            Return wc
            
        End Function			
            
              

        Public Overridable Function CreateWhereClause_WFRCHNGP_YearFromFilter() As WhereClause
          
              Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False
            
              Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False
            
              Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False
            
              Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False
            
            ' Create a where clause for the filter WFRCHNGP_YearFromFilter.
            ' This function is called by the Populate method to load the items 
            ' in the WFRCHNGP_YearFromFilterDropDownList
            
            Dim wc As WhereClause= New WhereClause()
            Return wc
            
        End Function			
            

    
    
        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction
                Me.RegisterPostback()
                
                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                  
                
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    
                    Me.LoadData()
                    Me.DataBind()
                    
                End If
                
               
                				
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
        End Sub
        
        
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()

            ' Save filter controls to values to session.
        
            Me.SaveToSession(Me.WFRCHNGP_C_IDFilter, Me.WFRCHNGP_C_IDFilter.SelectedValue)
                  
            Me.SaveToSession(Me.WFRCHNGP_MonthFilter, Me.WFRCHNGP_MonthFilter.SelectedValue)
                  
            Me.SaveToSession(Me.WFRCHNGP_StatusFilter, Me.WFRCHNGP_StatusFilter.SelectedValue)
                  
            Me.SaveToSession(Me.WFRCHNGP_YearFromFilter, Me.WFRCHNGP_YearFromFilter.SelectedValue)
                  
        
            'Save pagination state to session.
         
            
            ' Save table control properties to the session.
            
 If Not Me.CurrentSortOrder Is Nothing Then
                If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then
                    Me.SaveToSession(Me, "Order_By", Me.CurrentSortOrder.ToXmlString())
                End If
            End If            
            Me.SaveToSession(Me, "Page_Index", Me.PageIndex.ToString())
            Me.SaveToSession(Me, "Page_Size", Me.PageSize.ToString())
        
            Me.SaveToSession(Me, "DeletedRecordIds", Me.DeletedRecordIds)  
        
        End Sub
        
        Protected  Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.
          
      Me.SaveToSession("WFRCHNGP_C_IDFilter_Ajax", Me.WFRCHNGP_C_IDFilter.SelectedValue)
              
      Me.SaveToSession("WFRCHNGP_MonthFilter_Ajax", Me.WFRCHNGP_MonthFilter.SelectedValue)
              
      Me.SaveToSession("WFRCHNGP_StatusFilter_Ajax", Me.WFRCHNGP_StatusFilter.SelectedValue)
              
      Me.SaveToSession("WFRCHNGP_YearFromFilter_Ajax", Me.WFRCHNGP_YearFromFilter.SelectedValue)
              
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.WFRCHNGP_C_IDFilter)
            Me.RemoveFromSession(Me.WFRCHNGP_MonthFilter)
            Me.RemoveFromSession(Me.WFRCHNGP_StatusFilter)
            Me.RemoveFromSession(Me.WFRCHNGP_YearFromFilter)
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("WFinRepNGP_HeadTableControl_OrderBy"), String)
          
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            
            Else 
                Me.CurrentSortOrder = New OrderBy(True, False)
            
            End If
            
            
            Dim Pagination As Control = Me.FindControl("Pagination")
             Dim PaginationType As String = ""
             If Not (Pagination Is Nothing) Then
                Dim Summary As Control = Pagination.FindControl("_Summary")
                If Not (Summary Is Nothing) Then
                    If (DirectCast(Summary, System.Web.UI.WebControls.TextBox).Text.Equals("Infinite Pagination")) Then
                        PaginationType = "Infinite Pagination"
                    End If
                    If (DirectCast(Summary, System.Web.UI.WebControls.TextBox).Text.Equals("Infinite Pagination Mobile")) Then
                        PaginationType = "Infinite Pagination Mobile"
                End If
             End If
             End If

            If Not (PaginationType.Equals("Infinite Pagination")) Then 
              If Not Me.Page.ClientQueryString.Contains("InfiIframe") AndAlso PaginationType.Equals("Infinite Pagination Mobile") Then
                    Me.ViewState("Page_Index") = 0
                End If
              Dim pageIndex As String = CType(ViewState("Page_Index"), String)
              If pageIndex IsNot Nothing Then
                Me.PageIndex = CInt(pageIndex)
              End If
            End If

            Dim pageSize As String = CType(ViewState("Page_Size"), String)
            If Not pageSize Is Nothing Then
              Me.PageSize = CInt(pageSize)
            End If

            
    
            ' Load view state for pagination control.
        
            Me.DeletedRecordIds = CType(Me.ViewState("DeletedRecordIds"), String)
        
        End Sub

        Protected Overrides Function SaveViewState() As Object
          
            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("WFinRepNGP_HeadTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function
        
        ' Generate set method for buttons
        
        Public Overridable Sub SetGoButton()                
              
   
        End Sub
                    

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            Me.PageIndex = 0
            Me.DataChanged = True
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            Me.DisplayLastPage = True
            Me.DataChanged = True
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            Me.PageIndex += 1
            Me.DataChanged = True
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for LinkButton
        Public Overridable Sub Pagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Me.DataChanged = True
      
            Me.PageSize = Me.Pagination.GetCurrentPageSize()
      
            Me.PageIndex = Integer.Parse(Me.Pagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            If Me.PageIndex > 0 Then
                Me.PageIndex -= 1
                Me.DataChanged = True
            End If
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        

        ' Generate the event handling functions for sorting events.
        

        ' Generate the event handling functions for button events.
        
        ' event handler for Button
        Public Overridable Sub GoButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
          Me.DataChanged = True
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
      

        ' Generate the event handling functions for filter and search events.
        
        ' event handler for FieldFilter
        Protected Overridable Sub WFRCHNGP_C_IDFilter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
           ' Setting the DataChanged to True results in the page being refreshed with
           ' the most recent data from the database.  This happens in PreRender event
           ' based on the current sort, search and filter criteria.
           Me.DataChanged = True
           
          	                   
              
        End Sub
            
        ' event handler for FieldFilter
        Protected Overridable Sub WFRCHNGP_MonthFilter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
           ' Setting the DataChanged to True results in the page being refreshed with
           ' the most recent data from the database.  This happens in PreRender event
           ' based on the current sort, search and filter criteria.
           Me.DataChanged = True
           
          	                   
              
        End Sub
            
        ' event handler for FieldFilter
        Protected Overridable Sub WFRCHNGP_StatusFilter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
           ' Setting the DataChanged to True results in the page being refreshed with
           ' the most recent data from the database.  This happens in PreRender event
           ' based on the current sort, search and filter criteria.
           Me.DataChanged = True
           
          	                   
              
        End Sub
            
        ' event handler for FieldFilter
        Protected Overridable Sub WFRCHNGP_YearFromFilter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
           ' Setting the DataChanged to True results in the page being refreshed with
           ' the most recent data from the database.  This happens in PreRender event
           ' based on the current sort, search and filter criteria.
           Me.DataChanged = True
           
          	                   
              
        End Sub
            
    
        ' Generate the event handling functions for others
        
      


        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = WFinRepNGP_HeadTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
                End If
                Return Me._TotalRecords
            End Get
            Set(ByVal value As Integer)
                If Me.PageSize > 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(value / Me.PageSize))
                  
                End If
                Me._TotalRecords = value
            End Set
        End Property

        
    
        Protected _TotalPages As Integer = -1
        Public Property TotalPages() As Integer
            Get
                If _TotalPages < 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(TotalRecords / Me.PageSize))
                  
                End If                
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property

        Protected _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property


          
        Private _CurrentSortOrder As OrderBy = Nothing
        Public Property CurrentSortOrder() As OrderBy
            Get
                Return Me._CurrentSortOrder
            End Get
            Set(ByVal value As BaseClasses.Data.OrderBy)
                Me._CurrentSortOrder = value
            End Set
        End Property
        
        Public Property DataSource() As WFinRepNGP_HeadRecord ()
            Get
                Return DirectCast(MyBase._DataSource, WFinRepNGP_HeadRecord())
            End Get
            Set(ByVal value() As WFinRepNGP_HeadRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property GoButton() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "GoButton"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property Pagination() As ePortalWFApproval.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pagination"), ePortalWFApproval.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property Title0() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Title0"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_C_IDFilter() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_C_IDFilter"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_C_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_C_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_C_IDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_C_IDLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_DescriptionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_DescriptionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_MonthFilter() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_MonthFilter"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_MonthLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_MonthLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_MonthLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_MonthLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_RptCountLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_RptCountLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_StatusFilter() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_StatusFilter"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_StatusLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_StatusLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_YearFromFilter() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_YearFromFilter"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_YearLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_YearLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_YearLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_YearLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"
        
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
      
      
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me,includeSession)
        End Function
        
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As WFinRepNGP_HeadTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRepNGP_HeadRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
        
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As WFinRepNGP_HeadTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRepNGP_HeadRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                If includeSession then
                    Return EvaluateExpressions(url, arg, rec, bEncrypt)
                Else
                    Return EvaluateExpressions(url, arg, rec, bEncrypt,False)
                End If
            End If
            Return url
        End Function
        
          
        Public Overridable Function GetSelectedRecordControl() As WFinRepNGP_HeadTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WFinRepNGP_HeadTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WFinRepNGP_HeadTableControlRow)), WFinRepNGP_HeadTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WFinRepNGP_HeadTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WFinRepNGP_HeadTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                Else
                
                    recCtl.Delete()
                    
                    ' Setting the DataChanged to True results in the page being refreshed with
                    ' the most recent data from the database.  This happens in PreRender event
                    ' based on the current sort, search and filter criteria.
                    Me.DataChanged = True
                    Me.ResetData = True
                  
                End If
            Next
        End Sub

        Public Overridable Function GetRecordControls() As WFinRepNGP_HeadTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WFinRepNGP_HeadTableControlRow")
            Dim list As New List(Of WFinRepNGP_HeadTableControlRow)
            For Each recCtrl As WFinRepNGP_HeadTableControlRow In recCtrls
                list.Add(recCtrl)
            Next
            Return list.ToArray()
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property
                


#End Region



End Class

  

#End Region
    
  
End Namespace

  