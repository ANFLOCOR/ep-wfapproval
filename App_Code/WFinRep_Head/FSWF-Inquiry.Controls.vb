
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' FSWF_Inquiry.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ePortalWFApproval.UI.Controls.FSWF_Inquiry

#Region "Section 1: Place your customizations here."

    
Public Class WFinRep_HeadTableControlRow
        Inherits BaseWFinRep_HeadTableControlRow
        ' The BaseWFinRep_HeadTableControlRow implements code for a ROW within the
        ' the WFinRep_HeadTableControl table.  The BaseWFinRep_HeadTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WFinRep_HeadTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.

        Public Overrides Sub DataBind()

            MyBase.DataBind()
            Dim user As String = BaseClasses.Utils.SecurityControls.GetCurrentUserName()
            Dim role As String = BaseClasses.Utils.SecurityControls.GetCurrentUserRoles()
            Dim rolecorrectsouth As Boolean = False
            Dim rolecorrectnorth As Boolean = False
            Dim isAdmin As Boolean = False
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

            If Me.HFIN_Status.Text = "Completed" And rolecorrectsouth = True Then
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
                wherechecker = Sel_W_User_DYNAMICS_Company_FSView.W_U_User_Name.UniqueName & "='" & System.Web.HttpContext.Current.Session("UserName").ToString.Trim & "' AND " & Sel_W_User_DYNAMICS_Company_FSView.IsNonGP.UniqueName & "=0 " 'AND " & Sel_W_User_DYNAMICS_Company_FSView.Company_ID.UniqueName & "='" & Me.HFIN_C_ID1.Text & "'"
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


            If (System.Web.HttpContext.Current.Session("UserID").ToString = "101" Or System.Web.HttpContext.Current.Session("UserID").ToString = "158" Or returnForRevisionRole = True) And Me.HFIN_Status.Text = "Completed" Then
                'Me.imbEdit.Visible = True
                Me.btnEdit.Visible = True
            Else
                'Me.imbEdit.Visible = False
                Me.btnEdit.Visible = False
            End If

            Me.ViewRowButton.Attributes.Add("onClick", "OpenRptViewer2('" & Me.HFIN_Year1.ClientID & "','" & Me.HFIN_Month1.ClientID & "', '" & Me.HFIN_Description1.ClientID & "', '" & Me.HFIN_Description1.ClientID & "', '" & Me.HFIN_C_ID1.ClientID & "', '" & Me.HFIN_Status.ClientID & "', '" & Me.HFIN_ID.ClientID & "');return false;")
            Me.btnPreview1.Button.Attributes.Add("onClick", "OpenRptViewer2('" & Me.HFIN_Year1.ClientID & "','" & Me.HFIN_Month1.ClientID & "', '" & Me.HFIN_Description1.ClientID & "', '" & Me.HFIN_Description1.ClientID & "', '" & Me.HFIN_C_ID1.ClientID & "', '" & Me.HFIN_Status.ClientID & "', '" & Me.HFIN_ID.ClientID & "');return false;")

        End Sub

        Public Overrides Sub SetHFIN_File()

            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_FileSpecified Then

                Me.HFIN_File.Text = Page.GetResourceValue("Txt:OpenFile", "WebFS")

                Me.HFIN_File.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WFinRep_Head") & _
                            "&Field=" & Me.Page.Encrypt("HFIN_File") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"
                Me.btnPreview2.button.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WFinRep_Head") & _
                            "&Field=" & Me.Page.Encrypt("HFIN_File") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"

                ' Me.HFIN_File.Visible = True
            Else
                ' Me.HFIN_File.Visible = False
            End If
        End Sub

        
        Public Sub SaveToDatabase(ByVal pdfFile As Byte(), ByVal pDocID As Integer)

            Dim firstParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            firstParameter = New BaseClasses.Data.StoredProcedureParameter("@p_HFIN_ID", pDocID, System.Data.SqlDbType.Int, System.Data.ParameterDirection.Input)

            Dim secondParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            secondParameter = New BaseClasses.Data.StoredProcedureParameter("@p_HFIN_File", pdfFile, System.Data.SqlDbType.Image, System.Data.ParameterDirection.Input)

            Dim parameterList(1) As BaseClasses.Data.StoredProcedureParameter
            parameterList(0) = firstParameter
            parameterList(1) = secondParameter


            Dim myStoredProcedure As BaseClasses.Data.StoredProcedure = Nothing
            myStoredProcedure = New BaseClasses.Data.StoredProcedure("DatabaseANFLO-WF", "usp_upd_WFinRep_Head_FileUpload", parameterList)
            Dim str As String = ""
            If (myStoredProcedure.RunNonQuery()) Then
                str = "OK"

            Else
                str = myStoredProcedure.ErrorMessage
            End If

        End Sub


        Public Overrides Sub SetHFIN_Month1()



            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.HFIN_Month1.ID) Then

                Me.HFIN_Month1.Text = Me.PreviousUIData(Me.HFIN_Month1.ID).ToString()

                Return
            End If





            ' Set the HFIN_Month TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Month1 is the ASP:TextBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Month1()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_MonthSpecified Then

                ' If the HFIN_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value

                Me.HFIN_Month1.Text = Me.DataSource.HFIN_Month.ToString()

            Else

                ' HFIN_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.HFIN_Month1.Text = WFinRep_HeadTable.HFIN_Month.Format(WFinRep_HeadTable.HFIN_Month.DefaultValue)

            End If

            AddHandler Me.HFIN_Month1.TextChanged, AddressOf HFIN_Month1_TextChanged

        End Sub


End Class

  

Public Class WFinRep_HeadTableControl
        Inherits BaseWFinRep_HeadTableControl

    ' The BaseWFinRep_HeadTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The WFinRep_HeadTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.


		Public Overrides Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            WFinRep_HeadTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()

            ''Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False

            ''Dim hasFiltersWFinRep_ActivityTableControl As Boolean = False

            ''Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False

            Dim hasFiltersWFinRep_HeadTableControl As Boolean = False

            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.
			'JESS

            If IsValueSelected(Me.HFIN_C_IDFilter) Then

                ''hasFiltersWFinRep_HeadTableControl = True

                wc.iAND(WFinRep_HeadTable.HFIN_C_ID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.HFIN_C_IDFilter, Me.GetFromSession(Me.HFIN_C_IDFilter)), False, False)

            End If

            'wc.iAND(WFinRep_HeadTable.HFIN_C_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("DynCompID").ToString)

            If IsValueSelected(Me.HFIN_MonthFilter) Then

                ''hasFiltersWFinRep_HeadTableControl = True

                wc.iAND(WFinRep_HeadTable.HFIN_Month, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.HFIN_MonthFilter, Me.GetFromSession(Me.HFIN_MonthFilter)), False, False)

            End If



            If IsValueSelected(Me.HFIN_StatusFilter) Then

                ''hasFiltersWFinRep_HeadTableControl = True

                wc.iAND(WFinRep_HeadTable.HFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.HFIN_StatusFilter, Me.GetFromSession(Me.HFIN_StatusFilter)), False, False)

            End If



            If IsValueSelected(Me.HFIN_YearFromFilter) Then

                ''hasFiltersWFinRep_HeadTableControl = True

                wc.iAND(WFinRep_HeadTable.HFIN_Year, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.HFIN_YearFromFilter, Me.GetFromSession(Me.HFIN_YearFromFilter)), False, False)

            End If


            If IsValueSelected(Me.HFIN_C_IDFilter) OrElse Me.InSession(Me.HFIN_C_IDFilter) Then
                hasFiltersWFinRep_HeadTableControl = True
            End If

            If IsValueSelected(Me.HFIN_MonthFilter) OrElse Me.InSession(Me.HFIN_MonthFilter) Then
                hasFiltersWFinRep_HeadTableControl = True
            End If

            If IsValueSelected(Me.HFIN_StatusFilter) OrElse Me.InSession(Me.HFIN_StatusFilter) Then
                hasFiltersWFinRep_HeadTableControl = True
            End If

            If IsValueSelected(Me.HFIN_YearFromFilter) OrElse Me.InSession(Me.HFIN_YearFromFilter) Then
                hasFiltersWFinRep_HeadTableControl = True
            End If

            If Not (hasFiltersWFinRep_HeadTableControl) Then
                wc.RunQuery = False
            End If
            wc.iAND("HFIN_C_ID in (SELECT Company_ID FROM sel_W_User_DYNAMICS_Company_WASP where W_U_User_Name = '" & DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & "')")


            ' wc.iAND("HFIN_C_ID in (Select Company_ID From sel_W_User_DYNAMICS_Company_WASP where W_U_User_Name = '" & DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & "')")

            Return wc
        End Function


        Public Overrides Function CreateOrderBy() As OrderBy
            ' The CurrentSortOrder is initialized to the sort order on the
            ' Query Wizard.  It may be modified by the Click handler for any of
            ' the column heading to sort or reverse sort by that column.
            ' You can add your own sort order, or modify it on the Query Wizard. 
            Dim obC As OrderBy = New OrderBy(False, False)
            obC.Add(WFinRep_HeadTable.HFIN_Year, OrderByItem.OrderDir.Desc)
            obC.Add(WFinRep_HeadTable.HFIN_Month, OrderByItem.OrderDir.Asc)
            Return obC
        End Function



		Protected Overrides Sub PopulateHFIN_C_IDFilter(ByVal selectedValue As String, ByVal maxItems As Integer)

            Dim wc As WhereClause = New WhereClause
            wc.iAND(Sel_W_User_DYNAMICS_CompanyView.W_U_User_Name, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString())


            Dim orderBy As OrderBy = New OrderBy(False, True)
            orderBy.Add(Sel_W_User_DYNAMICS_CompanyView.Company_ID, BaseClasses.Data.OrderByItem.OrderDir.Asc)

            Me.HFIN_C_IDFilter.Items.Clear()
            Dim itemValue As Sel_W_User_DYNAMICS_CompanyRecord
            For Each itemValue In Sel_W_User_DYNAMICS_CompanyView.GetRecords(wc, orderBy, 0, maxItems)

                ' Create the item and add to the list.
                Dim cvalue As String = itemValue.Company_ID.ToString()
                Dim fvalue As String = itemValue.Format(Sel_W_User_DYNAMICS_CompanyView.Company_Short_Name)
                Dim item As ListItem = New ListItem(fvalue, cvalue)
                Me.HFIN_C_IDFilter.Items.Add(item)
            Next

            ' Set up the selected item.
            If Not selectedValue Is Nothing AndAlso _
            selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.HFIN_C_IDFilter, selectedValue) Then
                Dim fvalue As String = WFinRep_DocAttachTable.FIN_Company.Format(selectedValue)
                Dim item As ListItem = New ListItem(fvalue, selectedValue)
                item.Selected = True
                Me.HFIN_C_IDFilter.Items.Insert(0, item)
            End If


        End Sub
End Class

  

Public Class WFinRep_DocAttachTableControl
        Inherits BaseWFinRep_DocAttachTableControl

    ' The BaseWFinRep_DocAttachTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The WFinRep_DocAttachTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class
Public Class WFinRep_DocAttachTableControlRow
        Inherits BaseWFinRep_DocAttachTableControlRow
        ' The BaseWFinRep_DocAttachTableControlRow implements code for a ROW within the
        ' the WFinRep_DocAttachTableControl table.  The BaseWFinRep_DocAttachTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WFinRep_DocAttachTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        Protected Overrides Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
            Me.Page.LoadFocusScripts(Me)


            ' Register the event handlers.

            AddHandler Me.btnPreview.Button.Click, AddressOf btnPreview_Click

            Me.btnPreview.Button.Attributes.Add("onClick", "OpenRptViewer2('" & Me.FIN_Year.ClientID & "','" & Me.FIN_Month.ClientID & "', '" & Me.FIN_Type1.ClientID & "', '" & Me.FIN_File1.ClientID & "', '" & Me.FIN_Company.ClientID & "',  '" & Me.FIN_Status.ClientID & "',  '" & Me.FIN_HFIN_ID.ClientID & "');return false;")

        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WFinRep_DocAttachTableControlRow.
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record.  To do this, it calls the Set methods for 
            ' each of the field displayed on the webpage.  It is better to make 
            ' changes in the Set methods, rather than making changes here.

            MyBase.DataBind()

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


            SetFIN_Company()
            SetFIN_File1()
            SetFIN_Month()
            SetFIN_RWRem()
            SetFIN_Status()
            SetFIN_Type()
            SetFIN_Type1()
            SetFIN_Year()


            Me.IsNewRecord = True

            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False

                Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
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
            For Each r As String In roles
                If r = "177" Then
                    rolecorrect = True
                End If
            Next r
            If Me.FIN_Status.Text = "Completed" Or rolecorrect = True Then
                Me.btnPreview.Visible = True
            Else
                Me.btnPreview.Visible = False
            End If
        End Sub

        Public Overrides Sub SetFIN_Month()

            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.FIN_Month.ID) Then

                Me.FIN_Month.Text = Me.PreviousUIData(Me.FIN_Month.ID).ToString()

                Return
            End If


            ' Set the FIN_Month TextBox on the webpage with value from the
            ' WFinRep_DocAttach database record.

            ' Me.DataSource is the WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_Month is the ASP:TextBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_Month()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_MonthSpecified Then


                Me.FIN_Month.Text = Me.DataSource.FIN_Month.ToString()

            Else

                ' FIN_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.FIN_Month.Text = WFinRep_DocAttachTable.FIN_Month.Format(WFinRep_DocAttachTable.FIN_Month.DefaultValue)

            End If

        End Sub

End Class
Public Class WFinRep_ActivityTableControl
        Inherits BaseWFinRep_ActivityTableControl

    ' The BaseWFinRep_ActivityTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The WFinRep_ActivityTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class
Public Class WFinRep_ActivityTableControlRow
        Inherits BaseWFinRep_ActivityTableControlRow
        ' The BaseWFinRep_ActivityTableControlRow implements code for a ROW within the
        ' the WFinRep_ActivityTableControl table.  The BaseWFinRep_ActivityTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WFinRep_ActivityTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class
Public Class Vw_FS_WFinRep_Attachment_PerReportTypeTableControl
        Inherits BaseVw_FS_WFinRep_Attachment_PerReportTypeTableControl

    ' The BaseVw_FS_WFinRep_Attachment_PerReportTypeTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class
Public Class Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow
        Inherits BaseVw_FS_WFinRep_Attachment_PerReportTypeTableControlRow
        ' The BaseVw_FS_WFinRep_Attachment_PerReportTypeTableControlRow implements code for a ROW within the
        ' the Vw_FS_WFinRep_Attachment_PerReportTypeTableControl table.  The BaseVw_FS_WFinRep_Attachment_PerReportTypeTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of Vw_FS_WFinRep_Attachment_PerReportTypeTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class
#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow control on the FSWF_Inquiry page.
' Do not modify this class. Instead override any method in Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow.
Public Class BaseVw_FS_WFinRep_Attachment_PerReportTypeTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WF%dbo.vw_FS_WFinRep_Attachment_PerReportType record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Vw_FS_WFinRep_Attachment_PerReportTypeView.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseVw_FS_WFinRep_Attachment_PerReportTypeTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New Vw_FS_WFinRep_Attachment_PerReportTypeRecord()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow.
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
        
                SetWFRA_Desc()
                SetWFRA_Doc()
                SetWFRT_Description()
      
      
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
        
        
        Public Overridable Sub SetWFRA_Desc()

                  
            
        
            ' Set the WFRA_Desc Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.vw_FS_WFinRep_Attachment_PerReportType database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.vw_FS_WFinRep_Attachment_PerReportType record retrieved from the database.
            ' Me.WFRA_Desc is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRA_Desc()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRA_DescSpecified Then
                				
                ' If the WFRA_Desc is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Vw_FS_WFinRep_Attachment_PerReportTypeView.WFRA_Desc)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRA_Desc.Text = formattedValue
                
            Else 
            
                ' WFRA_Desc is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRA_Desc.Text = Vw_FS_WFinRep_Attachment_PerReportTypeView.WFRA_Desc.Format(Vw_FS_WFinRep_Attachment_PerReportTypeView.WFRA_Desc.DefaultValue)
                        		
                End If
                 
            ' If the WFRA_Desc is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRA_Desc.Text Is Nothing _
                OrElse Me.WFRA_Desc.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRA_Desc.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWFRA_Doc()

                  
                
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRA_DocSpecified Then
                
                Me.WFRA_Doc.Text = Page.GetResourceValue("Txt:OpenFile", "ePortalWFApproval")
                        
                Me.WFRA_Doc.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("Vw_FS_WFinRep_Attachment_PerReportType") & _
                            "&Field=" & Me.Page.Encrypt("WFRA_Doc") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"
                   
                Me.WFRA_Doc.Visible = True
            Else
                Me.WFRA_Doc.Visible = False
            End If
        End Sub
                
        Public Overridable Sub SetWFRT_Description()

                  
            
        
            ' Set the WFRT_Description Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.vw_FS_WFinRep_Attachment_PerReportType database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.vw_FS_WFinRep_Attachment_PerReportType record retrieved from the database.
            ' Me.WFRT_Description is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRT_Description()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRT_DescriptionSpecified Then
                				
                ' If the WFRT_Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Vw_FS_WFinRep_Attachment_PerReportTypeView.WFRT_Description)
                              
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
                      
                        Dim name As String = HttpUtility.HtmlEncode(Vw_FS_WFinRep_Attachment_PerReportTypeView.WFRT_Description.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ePortalWFApproval.Business.Vw_FS_WFinRep_Attachment_PerReportTypeView, App_Code\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""WFRT_Description\"", \""WFRT_Description\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) & "\"", \""" & Page.GetResourceValue("Btn:Close", "ePortalWFApproval") & "\"", false, 200," _
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
                
                Me.WFRT_Description.Text = formattedValue
                
            Else 
            
                ' WFRT_Description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRT_Description.Text = Vw_FS_WFinRep_Attachment_PerReportTypeView.WFRT_Description.Format(Vw_FS_WFinRep_Attachment_PerReportTypeView.WFRT_Description.DefaultValue)
                        		
                End If
                 
            ' If the WFRT_Description is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRT_Description.Text Is Nothing _
                OrElse Me.WFRT_Description.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRT_Description.Text = "&nbsp;"
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

      
        
        ' To customize, override this method in Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow.
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
        
        Dim parentCtrl As WFinRep_HeadTableControlRow
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_HeadTableControlRow"), WFinRep_HeadTableControlRow)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ePortalWFApproval"))
            End If
            
            Me.DataSource.FIN_HFIN_ID = parentCtrl.DataSource.HFIN_ID
              
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
              
                DirectCast(GetParentControlObject(Me, "Vw_FS_WFinRep_Attachment_PerReportTypeTableControl"), Vw_FS_WFinRep_Attachment_PerReportTypeTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "Vw_FS_WFinRep_Attachment_PerReportTypeTableControl"), Vw_FS_WFinRep_Attachment_PerReportTypeTableControl).ResetData = True
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

        ' To customize, override this method in Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWFRA_Desc()
            GetWFRT_Description()
        End Sub
        
        
        Public Overridable Sub GetWFRA_Desc()
            
        End Sub
                
        Public Overridable Sub GetWFRT_Description()
            
        End Sub
                
      
        ' To customize, override this method in Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow.
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
          Vw_FS_WFinRep_Attachment_PerReportTypeView.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "Vw_FS_WFinRep_Attachment_PerReportTypeTableControl"), Vw_FS_WFinRep_Attachment_PerReportTypeTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "Vw_FS_WFinRep_Attachment_PerReportTypeTableControl"), Vw_FS_WFinRep_Attachment_PerReportTypeTableControl).ResetData = True
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
                Return CType(Me.ViewState("BaseVw_FS_WFinRep_Attachment_PerReportTypeTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseVw_FS_WFinRep_Attachment_PerReportTypeTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As Vw_FS_WFinRep_Attachment_PerReportTypeRecord
            Get
                Return DirectCast(MyBase._DataSource, Vw_FS_WFinRep_Attachment_PerReportTypeRecord)
            End Get
            Set(ByVal value As Vw_FS_WFinRep_Attachment_PerReportTypeRecord)
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
        
        Public ReadOnly Property WFRA_Desc() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRA_Desc"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRA_Doc() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRA_Doc"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property WFRT_Description() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRT_Description"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As Vw_FS_WFinRep_Attachment_PerReportTypeRecord = Nothing
             
        
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
            
            Dim rec As Vw_FS_WFinRep_Attachment_PerReportTypeRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As Vw_FS_WFinRep_Attachment_PerReportTypeRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return Vw_FS_WFinRep_Attachment_PerReportTypeView.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the Vw_FS_WFinRep_Attachment_PerReportTypeTableControl control on the FSWF_Inquiry page.
' Do not modify this class. Instead override any method in Vw_FS_WFinRep_Attachment_PerReportTypeTableControl.
Public Class BaseVw_FS_WFinRep_Attachment_PerReportTypeTableControl
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
            
              AddHandler Me.Pagination3.FirstPage.Click, AddressOf Pagination3_FirstPage_Click
                        
              AddHandler Me.Pagination3.LastPage.Click, AddressOf Pagination3_LastPage_Click
                        
              AddHandler Me.Pagination3.NextPage.Click, AddressOf Pagination3_NextPage_Click
                        
              AddHandler Me.Pagination3.PageSizeButton.Click, AddressOf Pagination3_PageSizeButton_Click
                        
              AddHandler Me.Pagination3.PreviousPage.Click, AddressOf Pagination3_PreviousPage_Click
                                    
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Vw_FS_WFinRep_Attachment_PerReportTypeRecord)), Vw_FS_WFinRep_Attachment_PerReportTypeRecord())
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
                    For Each rc As Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Vw_FS_WFinRep_Attachment_PerReportTypeRecord)), Vw_FS_WFinRep_Attachment_PerReportTypeRecord())
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
            ByVal pageSize As Integer) As Vw_FS_WFinRep_Attachment_PerReportTypeRecord()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Vw_FS_WFinRep_Attachment_PerReportTypeView.Column1, True)         
            ' selCols.Add(Vw_FS_WFinRep_Attachment_PerReportTypeView.Column2, True)          
            ' selCols.Add(Vw_FS_WFinRep_Attachment_PerReportTypeView.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return Vw_FS_WFinRep_Attachment_PerReportTypeView.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New Vw_FS_WFinRep_Attachment_PerReportTypeView
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(Vw_FS_WFinRep_Attachment_PerReportTypeRecord)), Vw_FS_WFinRep_Attachment_PerReportTypeRecord())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Vw_FS_WFinRep_Attachment_PerReportTypeView.Column1, True)         
            ' selCols.Add(Vw_FS_WFinRep_Attachment_PerReportTypeView.Column2, True)          
            ' selCols.Add(Vw_FS_WFinRep_Attachment_PerReportTypeView.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return Vw_FS_WFinRep_Attachment_PerReportTypeView.GetRecordCount(join, where)

            Else
                Dim databaseTable As New Vw_FS_WFinRep_Attachment_PerReportTypeView
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow = DirectCast(repItem.FindControl("Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow"), Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                
                SetWFRA_DescLabel()
                SetWFRA_DocLabel()
                SetWFRT_DescriptionLabel()
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
                    
                Me.Pagination3.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Pagination3.CurrentPage.Text = "0"
            End If
            Me.Pagination3.PageSize.Text = Me.PageSize.ToString()
            Me.Pagination3.TotalItems.Text = Me.TotalRecords.ToString()
            Me.Pagination3.TotalPages.Text = Me.TotalPages.ToString()

            ' Bind the buttons for Vw_FS_WFinRep_Attachment_PerReportTypeTableControl pagination.
        
            Me.Pagination3.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination3.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination3.LastPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination3.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination3.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination3.NextPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination3.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            Me.Pagination3.PreviousPage.Enabled = Not (Me.PageIndex = 0)


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow
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
            Vw_FS_WFinRep_Attachment_PerReportTypeView.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
        Dim wFinRep_HeadRecordObj as KeyValue
        wFinRep_HeadRecordObj = Nothing
      
              Dim wFinRep_HeadTableControlObjRow As WFinRep_HeadTableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_HeadTableControlRow") ,WFinRep_HeadTableControlRow)
            
                If (Not IsNothing(wFinRep_HeadTableControlObjRow) AndAlso Not IsNothing(wFinRep_HeadTableControlObjRow.GetRecord()) AndAlso Not IsNothing(wFinRep_HeadTableControlObjRow.GetRecord().HFIN_ID))
                    wc.iAND(Vw_FS_WFinRep_Attachment_PerReportTypeView.FIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, wFinRep_HeadTableControlObjRow.GetRecord().HFIN_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If
              
      HttpContext.Current.Session("Vw_FS_WFinRep_Attachment_PerReportTypeTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Vw_FS_WFinRep_Attachment_PerReportTypeView.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_ActivityTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWFinRep_HeadTableControl as String = DirectCast(HttpContext.Current.Session("Vw_FS_WFinRep_Attachment_PerReportTypeTableControlWhereClause"), String)
            
            If Not selectedRecordInWFinRep_HeadTableControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWFinRep_HeadTableControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWFinRep_HeadTableControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(Vw_FS_WFinRep_Attachment_PerReportTypeView.FIN_HFIN_ID) Then
            wc.iAND(Vw_FS_WFinRep_Attachment_PerReportTypeView.FIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(Vw_FS_WFinRep_Attachment_PerReportTypeView.FIN_HFIN_ID).ToString())
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
        
            If Me.Pagination3.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.Pagination3.PageSize.Text)
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow = DirectCast(repItem.FindControl("Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow"), Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As Vw_FS_WFinRep_Attachment_PerReportTypeRecord = New Vw_FS_WFinRep_Attachment_PerReportTypeRecord()
        
                        If recControl.WFRA_Desc.Text <> "" Then
                            rec.Parse(recControl.WFRA_Desc.Text, Vw_FS_WFinRep_Attachment_PerReportTypeView.WFRA_Desc)
                        End If
                        If recControl.WFRA_Doc.Text <> "" Then
                            rec.Parse(recControl.WFRA_Doc.Text, Vw_FS_WFinRep_Attachment_PerReportTypeView.WFRA_Doc)
                        End If
                        If recControl.WFRT_Description.Text <> "" Then
                            rec.Parse(recControl.WFRT_Description.Text, Vw_FS_WFinRep_Attachment_PerReportTypeView.WFRT_Description)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New Vw_FS_WFinRep_Attachment_PerReportTypeRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(Vw_FS_WFinRep_Attachment_PerReportTypeRecord)), Vw_FS_WFinRep_Attachment_PerReportTypeRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow) As Boolean
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
        
        Public Overridable Sub SetWFRA_DescLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRA_DescLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRA_DocLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRA_DocLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRT_DescriptionLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRT_DescriptionLabel.Text = "Some value"
                    
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

            Dim orderByStr As String = CType(ViewState("Vw_FS_WFinRep_Attachment_PerReportTypeTableControl_OrderBy"), String)
          
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            
            Else 
                Me.CurrentSortOrder = New OrderBy(True, False)
            
            End If
            
            
            Dim Pagination As Control = Me.FindControl("Pagination3")
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
                Me.ViewState("Vw_FS_WFinRep_Attachment_PerReportTypeTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
        Public Overridable Sub Pagination3_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Pagination3_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Pagination3_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Pagination3_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Me.DataChanged = True
      
            Me.PageSize = Me.Pagination3.GetCurrentPageSize()
      
            Me.PageIndex = Integer.Parse(Me.Pagination3.CurrentPage.Text) - 1
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination3_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
                    _TotalRecords = Vw_FS_WFinRep_Attachment_PerReportTypeView.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As Vw_FS_WFinRep_Attachment_PerReportTypeRecord ()
            Get
                Return DirectCast(MyBase._DataSource, Vw_FS_WFinRep_Attachment_PerReportTypeRecord())
            End Get
            Set(ByVal value() As Vw_FS_WFinRep_Attachment_PerReportTypeRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property Pagination3() As ePortalWFApproval.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pagination3"), ePortalWFApproval.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property WFRA_DescLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRA_DescLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRA_DocLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRA_DocLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRT_DescriptionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRT_DescriptionLabel"), System.Web.UI.WebControls.Literal)
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
                Dim recCtl As Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As Vw_FS_WFinRep_Attachment_PerReportTypeRecord = Nothing     
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
                Dim recCtl As Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As Vw_FS_WFinRep_Attachment_PerReportTypeRecord = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow)), Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow
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

        Public Overridable Function GetRecordControls() As Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow")
            Dim list As New List(Of Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow)
            For Each recCtrl As Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow In recCtrls
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

  
' Base class for the WFinRep_ActivityTableControlRow control on the FSWF_Inquiry page.
' Do not modify this class. Instead override any method in WFinRep_ActivityTableControlRow.
Public Class BaseWFinRep_ActivityTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WFinRep_ActivityTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WFinRep_ActivityTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WF%dbo.WFinRep_Activity record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WFinRep_ActivityTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWFinRep_ActivityTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WFinRep_ActivityRecord()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WFinRep_ActivityTableControlRow.
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
        
                SetAFIN_Date_Action()
                SetAFIN_Date_Assign()
                SetAFIN_Remark()
                SetAFIN_Status()
                SetAFIN_W_U_ID()
      
      
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
        
        
        Public Overridable Sub SetAFIN_Date_Action()

                  
            
        
            ' Set the AFIN_Date_Action Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_Date_Action is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Date_Action()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_Date_ActionSpecified Then
                				
                ' If the AFIN_Date_Action is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_ActivityTable.AFIN_Date_Action, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_Date_Action.Text = formattedValue
                
            Else 
            
                ' AFIN_Date_Action is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_Date_Action.Text = WFinRep_ActivityTable.AFIN_Date_Action.Format(WFinRep_ActivityTable.AFIN_Date_Action.DefaultValue, "g")
                        		
                End If
                 
            ' If the AFIN_Date_Action is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_Date_Action.Text Is Nothing _
                OrElse Me.AFIN_Date_Action.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_Date_Action.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetAFIN_Date_Assign()

                  
            
        
            ' Set the AFIN_Date_Assign Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_Date_Assign is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Date_Assign()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_Date_AssignSpecified Then
                				
                ' If the AFIN_Date_Assign is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_ActivityTable.AFIN_Date_Assign, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_Date_Assign.Text = formattedValue
                
            Else 
            
                ' AFIN_Date_Assign is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_Date_Assign.Text = WFinRep_ActivityTable.AFIN_Date_Assign.Format(WFinRep_ActivityTable.AFIN_Date_Assign.DefaultValue, "g")
                        		
                End If
                 
            ' If the AFIN_Date_Assign is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_Date_Assign.Text Is Nothing _
                OrElse Me.AFIN_Date_Assign.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_Date_Assign.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetAFIN_Remark()

                  
            
        
            ' Set the AFIN_Remark Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_Remark is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Remark()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_RemarkSpecified Then
                				
                ' If the AFIN_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_ActivityTable.AFIN_Remark)
                              
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
                      
                        Dim name As String = HttpUtility.HtmlEncode(WFinRep_ActivityTable.AFIN_Remark.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ePortalWFApproval.Business.WFinRep_ActivityTable, App_Code\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""AFIN_Remark\"", \""AFIN_Remark\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) & "\"", \""" & Page.GetResourceValue("Btn:Close", "ePortalWFApproval") & "\"", false, 200," _
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
                
                Me.AFIN_Remark.Text = formattedValue
                
            Else 
            
                ' AFIN_Remark is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_Remark.Text = WFinRep_ActivityTable.AFIN_Remark.Format(WFinRep_ActivityTable.AFIN_Remark.DefaultValue)
                        		
                End If
                 
            ' If the AFIN_Remark is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_Remark.Text Is Nothing _
                OrElse Me.AFIN_Remark.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_Remark.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetAFIN_Status()

                  
            
        
            ' Set the AFIN_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_Status is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_StatusSpecified Then
                				
                ' If the AFIN_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_ActivityTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_ActivityTable.AFIN_Status)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_ActivityTable.AFIN_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_ActivityTable.GetDFKA(Me.DataSource.AFIN_Status.ToString(),WFinRep_ActivityTable.AFIN_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_ActivityTable.AFIN_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.AFIN_Status.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_Status.Text = formattedValue
                
            Else 
            
                ' AFIN_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_Status.Text = WFinRep_ActivityTable.AFIN_Status.Format(WFinRep_ActivityTable.AFIN_Status.DefaultValue)
                        		
                End If
                 
            ' If the AFIN_Status is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_Status.Text Is Nothing _
                OrElse Me.AFIN_Status.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_Status.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetAFIN_W_U_ID()

                  
            
        
            ' Set the AFIN_W_U_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_W_U_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_W_U_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_W_U_IDSpecified Then
                				
                ' If the AFIN_W_U_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_ActivityTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_ActivityTable.AFIN_W_U_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_ActivityTable.AFIN_W_U_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_ActivityTable.GetDFKA(Me.DataSource.AFIN_W_U_ID.ToString(),WFinRep_ActivityTable.AFIN_W_U_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_ActivityTable.AFIN_W_U_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.AFIN_W_U_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_W_U_ID.Text = formattedValue
                
            Else 
            
                ' AFIN_W_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_W_U_ID.Text = WFinRep_ActivityTable.AFIN_W_U_ID.Format(WFinRep_ActivityTable.AFIN_W_U_ID.DefaultValue)
                        		
                End If
                 
            ' If the AFIN_W_U_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_W_U_ID.Text Is Nothing _
                OrElse Me.AFIN_W_U_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_W_U_ID.Text = "&nbsp;"
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

      
        
        ' To customize, override this method in WFinRep_ActivityTableControlRow.
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
        
        Dim parentCtrl As WFinRep_HeadTableControlRow
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_HeadTableControlRow"), WFinRep_HeadTableControlRow)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ePortalWFApproval"))
            End If
            
            Me.DataSource.AFIN_HFIN_ID = parentCtrl.DataSource.HFIN_ID
              
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
              
                DirectCast(GetParentControlObject(Me, "WFinRep_ActivityTableControl"), WFinRep_ActivityTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WFinRep_ActivityTableControl"), WFinRep_ActivityTableControl).ResetData = True
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

        ' To customize, override this method in WFinRep_ActivityTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetAFIN_Date_Action()
            GetAFIN_Date_Assign()
            GetAFIN_Remark()
            GetAFIN_Status()
            GetAFIN_W_U_ID()
        End Sub
        
        
        Public Overridable Sub GetAFIN_Date_Action()
            
        End Sub
                
        Public Overridable Sub GetAFIN_Date_Assign()
            
        End Sub
                
        Public Overridable Sub GetAFIN_Remark()
            
        End Sub
                
        Public Overridable Sub GetAFIN_Status()
            
        End Sub
                
        Public Overridable Sub GetAFIN_W_U_ID()
            
        End Sub
                
      
        ' To customize, override this method in WFinRep_ActivityTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WFinRep_ActivityTableControlRow.
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
          WFinRep_ActivityTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WFinRep_ActivityTableControl"), WFinRep_ActivityTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WFinRep_ActivityTableControl"), WFinRep_ActivityTableControl).ResetData = True
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
                Return CType(Me.ViewState("BaseWFinRep_ActivityTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWFinRep_ActivityTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WFinRep_ActivityRecord
            Get
                Return DirectCast(MyBase._DataSource, WFinRep_ActivityRecord)
            End Get
            Set(ByVal value As WFinRep_ActivityRecord)
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
        
        Public ReadOnly Property AFIN_Date_Action() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Date_Action"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_Date_Assign() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Date_Assign"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_Remark() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Remark"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_Status() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Status"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_W_U_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_W_U_ID"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As WFinRep_ActivityRecord = Nothing
             
        
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
            
            Dim rec As WFinRep_ActivityRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WFinRep_ActivityRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WFinRep_ActivityTable.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WFinRep_ActivityTableControl control on the FSWF_Inquiry page.
' Do not modify this class. Instead override any method in WFinRep_ActivityTableControl.
Public Class BaseWFinRep_ActivityTableControl
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WFinRep_ActivityRecord)), WFinRep_ActivityRecord())
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
                    For Each rc As WFinRep_ActivityTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WFinRep_ActivityRecord)), WFinRep_ActivityRecord())
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
            ByVal pageSize As Integer) As WFinRep_ActivityRecord()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRep_ActivityTable.Column1, True)         
            ' selCols.Add(WFinRep_ActivityTable.Column2, True)          
            ' selCols.Add(WFinRep_ActivityTable.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WFinRep_ActivityTable.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WFinRep_ActivityTable
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WFinRep_ActivityRecord)), WFinRep_ActivityRecord())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRep_ActivityTable.Column1, True)         
            ' selCols.Add(WFinRep_ActivityTable.Column2, True)          
            ' selCols.Add(WFinRep_ActivityTable.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WFinRep_ActivityTable.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WFinRep_ActivityTable
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_ActivityTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WFinRep_ActivityTableControlRow = DirectCast(repItem.FindControl("WFinRep_ActivityTableControlRow"), WFinRep_ActivityTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                SetAFIN_Date_ActionLabel()
                SetAFIN_Date_AssignLabel()
                SetAFIN_RemarkLabel()
                SetAFIN_StatusLabel()
                SetAFIN_W_U_IDLabel()
                
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
          
            Me.Page.PregetDfkaRecords(WFinRep_ActivityTable.AFIN_Status, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_ActivityTable.AFIN_W_U_ID, Me.DataSource)
          
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

            ' Bind the buttons for WFinRep_ActivityTableControl pagination.
        
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
            
            Dim recCtl As WFinRep_ActivityTableControlRow
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
            WFinRep_ActivityTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
        Dim wFinRep_HeadRecordObj as KeyValue
        wFinRep_HeadRecordObj = Nothing
      
              Dim wFinRep_HeadTableControlObjRow As WFinRep_HeadTableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_HeadTableControlRow") ,WFinRep_HeadTableControlRow)
            
                If (Not IsNothing(wFinRep_HeadTableControlObjRow) AndAlso Not IsNothing(wFinRep_HeadTableControlObjRow.GetRecord()) AndAlso Not IsNothing(wFinRep_HeadTableControlObjRow.GetRecord().HFIN_ID))
                    wc.iAND(WFinRep_ActivityTable.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, wFinRep_HeadTableControlObjRow.GetRecord().HFIN_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If
              
      HttpContext.Current.Session("WFinRep_ActivityTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WFinRep_ActivityTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_ActivityTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWFinRep_HeadTableControl as String = DirectCast(HttpContext.Current.Session("WFinRep_ActivityTableControlWhereClause"), String)
            
            If Not selectedRecordInWFinRep_HeadTableControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWFinRep_HeadTableControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWFinRep_HeadTableControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(WFinRep_ActivityTable.AFIN_HFIN_ID) Then
            wc.iAND(WFinRep_ActivityTable.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(WFinRep_ActivityTable.AFIN_HFIN_ID).ToString())
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_ActivityTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WFinRep_ActivityTableControlRow = DirectCast(repItem.FindControl("WFinRep_ActivityTableControlRow"), WFinRep_ActivityTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WFinRep_ActivityRecord = New WFinRep_ActivityRecord()
        
                        If recControl.AFIN_Date_Action.Text <> "" Then
                            rec.Parse(recControl.AFIN_Date_Action.Text, WFinRep_ActivityTable.AFIN_Date_Action)
                        End If
                        If recControl.AFIN_Date_Assign.Text <> "" Then
                            rec.Parse(recControl.AFIN_Date_Assign.Text, WFinRep_ActivityTable.AFIN_Date_Assign)
                        End If
                        If recControl.AFIN_Remark.Text <> "" Then
                            rec.Parse(recControl.AFIN_Remark.Text, WFinRep_ActivityTable.AFIN_Remark)
                        End If
                        If recControl.AFIN_Status.Text <> "" Then
                            rec.Parse(recControl.AFIN_Status.Text, WFinRep_ActivityTable.AFIN_Status)
                        End If
                        If recControl.AFIN_W_U_ID.Text <> "" Then
                            rec.Parse(recControl.AFIN_W_U_ID.Text, WFinRep_ActivityTable.AFIN_W_U_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WFinRep_ActivityRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WFinRep_ActivityRecord)), WFinRep_ActivityRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WFinRep_ActivityTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WFinRep_ActivityTableControlRow) As Boolean
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
        
        Public Overridable Sub SetAFIN_Date_ActionLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AFIN_Date_ActionLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetAFIN_Date_AssignLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AFIN_Date_AssignLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetAFIN_RemarkLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AFIN_RemarkLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetAFIN_StatusLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AFIN_StatusLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetAFIN_W_U_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AFIN_W_U_IDLabel.Text = "Some value"
                    
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

            Dim orderByStr As String = CType(ViewState("WFinRep_ActivityTableControl_OrderBy"), String)
          
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
                Me.ViewState("WFinRep_ActivityTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
                    _TotalRecords = WFinRep_ActivityTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WFinRep_ActivityRecord ()
            Get
                Return DirectCast(MyBase._DataSource, WFinRep_ActivityRecord())
            End Get
            Set(ByVal value() As WFinRep_ActivityRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property AFIN_Date_ActionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Date_ActionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_Date_AssignLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Date_AssignLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_RemarkLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_RemarkLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_W_U_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_W_U_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Pagination1() As ePortalWFApproval.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pagination1"), ePortalWFApproval.UI.IPagination)
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
                Dim recCtl As WFinRep_ActivityTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRep_ActivityRecord = Nothing     
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
                Dim recCtl As WFinRep_ActivityTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRep_ActivityRecord = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WFinRep_ActivityTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WFinRep_ActivityTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WFinRep_ActivityTableControlRow)), WFinRep_ActivityTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WFinRep_ActivityTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WFinRep_ActivityTableControlRow
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

        Public Overridable Function GetRecordControls() As WFinRep_ActivityTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WFinRep_ActivityTableControlRow")
            Dim list As New List(Of WFinRep_ActivityTableControlRow)
            For Each recCtrl As WFinRep_ActivityTableControlRow In recCtrls
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

  
' Base class for the WFinRep_DocAttachTableControlRow control on the FSWF_Inquiry page.
' Do not modify this class. Instead override any method in WFinRep_DocAttachTableControlRow.
Public Class BaseWFinRep_DocAttachTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WFinRep_DocAttachTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WFinRep_DocAttachTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
              AddHandler Me.btnPreview.Button.Click, AddressOf btnPreview_Click
                        
              AddHandler Me.FIN_Company.TextChanged, AddressOf FIN_Company_TextChanged
            
              AddHandler Me.FIN_File1.TextChanged, AddressOf FIN_File1_TextChanged
            
              AddHandler Me.FIN_HFIN_ID.TextChanged, AddressOf FIN_HFIN_ID_TextChanged
            
              AddHandler Me.FIN_Month.TextChanged, AddressOf FIN_Month_TextChanged
            
              AddHandler Me.FIN_Status.TextChanged, AddressOf FIN_Status_TextChanged
            
              AddHandler Me.FIN_Type1.TextChanged, AddressOf FIN_Type1_TextChanged
            
              AddHandler Me.FIN_Year.TextChanged, AddressOf FIN_Year_TextChanged
            
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WF%dbo.WFinRep_DocAttach record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WFinRep_DocAttachTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWFinRep_DocAttachTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WFinRep_DocAttachRecord()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WFinRep_DocAttachTableControlRow.
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
        
                
                SetFIN_Company()
                SetFIN_File1()
                SetFIN_HFIN_ID()
                SetFIN_Month()
                SetFIN_RWRem()
                SetFIN_Status()
                SetFIN_Type()
                SetFIN_Type1()
                SetFIN_Year()
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
        
        
        Public Overridable Sub SetFIN_Company()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.FIN_Company.ID) Then
            
                Me.FIN_Company.Text = Me.PreviousUIData(Me.FIN_Company.ID).ToString()
              
                Return
            End If
            
        
            ' Set the FIN_Company TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_Company is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_Company()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_CompanySpecified Then
                				
                ' If the FIN_Company is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_DocAttachTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_DocAttachTable.FIN_Company)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_DocAttachTable.FIN_Company.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_DocAttachTable.GetDFKA(Me.DataSource.FIN_Company.ToString(),WFinRep_DocAttachTable.FIN_Company, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_DocAttachTable.FIN_Company)
                       End If
                Else
                       formattedValue = Me.DataSource.FIN_Company.ToString()
                End If
                                
                Me.FIN_Company.Text = formattedValue
                
            Else 
            
                ' FIN_Company is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_Company.Text = WFinRep_DocAttachTable.FIN_Company.Format(WFinRep_DocAttachTable.FIN_Company.DefaultValue)
                        		
                End If
                 
              AddHandler Me.FIN_Company.TextChanged, AddressOf FIN_Company_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetFIN_File1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.FIN_File1.ID) Then
            
                Me.FIN_File1.Text = Me.PreviousUIData(Me.FIN_File1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the FIN_File1 TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_File1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_File1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_File1Specified Then
                				
                ' If the FIN_File1 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_DocAttachTable.FIN_File1)
                              
                Me.FIN_File1.Text = formattedValue
                
            Else 
            
                ' FIN_File1 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_File1.Text = WFinRep_DocAttachTable.FIN_File1.Format(WFinRep_DocAttachTable.FIN_File1.DefaultValue)
                        		
                End If
                 
              AddHandler Me.FIN_File1.TextChanged, AddressOf FIN_File1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetFIN_HFIN_ID()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.FIN_HFIN_ID.ID) Then
            
                Me.FIN_HFIN_ID.Text = Me.PreviousUIData(Me.FIN_HFIN_ID.ID).ToString()
              
                Return
            End If
            
        
            ' Set the FIN_HFIN_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_HFIN_ID is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_HFIN_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_HFIN_IDSpecified Then
                				
                ' If the FIN_HFIN_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_DocAttachTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_DocAttachTable.FIN_HFIN_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_DocAttachTable.FIN_HFIN_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_DocAttachTable.GetDFKA(Me.DataSource.FIN_HFIN_ID.ToString(),WFinRep_DocAttachTable.FIN_HFIN_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_DocAttachTable.FIN_HFIN_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.FIN_HFIN_ID.ToString()
                End If
                                
                Me.FIN_HFIN_ID.Text = formattedValue
                
            Else 
            
                ' FIN_HFIN_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_HFIN_ID.Text = WFinRep_DocAttachTable.FIN_HFIN_ID.Format(WFinRep_DocAttachTable.FIN_HFIN_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.FIN_HFIN_ID.TextChanged, AddressOf FIN_HFIN_ID_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetFIN_Month()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.FIN_Month.ID) Then
            
                Me.FIN_Month.Text = Me.PreviousUIData(Me.FIN_Month.ID).ToString()
              
                Return
            End If
            
        
            ' Set the FIN_Month TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_Month is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_Month()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_MonthSpecified Then
                				
                ' If the FIN_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_DocAttachTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_DocAttachTable.FIN_Month)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_DocAttachTable.FIN_Month.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_DocAttachTable.GetDFKA(Me.DataSource.FIN_Month.ToString(),WFinRep_DocAttachTable.FIN_Month, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_DocAttachTable.FIN_Month)
                       End If
                Else
                       formattedValue = Me.DataSource.FIN_Month.ToString()
                End If
                                
                Me.FIN_Month.Text = formattedValue
                
            Else 
            
                ' FIN_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_Month.Text = WFinRep_DocAttachTable.FIN_Month.Format(WFinRep_DocAttachTable.FIN_Month.DefaultValue)
                        		
                End If
                 
              AddHandler Me.FIN_Month.TextChanged, AddressOf FIN_Month_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetFIN_RWRem()

                  
            
        
            ' Set the FIN_RWRem Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_RWRem is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_RWRem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_RWRemSpecified Then
                				
                ' If the FIN_RWRem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_DocAttachTable.FIN_RWRem)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FIN_RWRem.Text = formattedValue
                
            Else 
            
                ' FIN_RWRem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_RWRem.Text = WFinRep_DocAttachTable.FIN_RWRem.Format(WFinRep_DocAttachTable.FIN_RWRem.DefaultValue)
                        		
                End If
                 
            ' If the FIN_RWRem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIN_RWRem.Text Is Nothing _
                OrElse Me.FIN_RWRem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIN_RWRem.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetFIN_Status()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.FIN_Status.ID) Then
            
                Me.FIN_Status.Text = Me.PreviousUIData(Me.FIN_Status.ID).ToString()
              
                Return
            End If
            
        
            ' Set the FIN_Status TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_Status is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_StatusSpecified Then
                				
                ' If the FIN_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_DocAttachTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_DocAttachTable.FIN_Status)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_DocAttachTable.FIN_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_DocAttachTable.GetDFKA(Me.DataSource.FIN_Status.ToString(),WFinRep_DocAttachTable.FIN_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_DocAttachTable.FIN_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.FIN_Status.ToString()
                End If
                                
                Me.FIN_Status.Text = formattedValue
                
            Else 
            
                ' FIN_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_Status.Text = WFinRep_DocAttachTable.FIN_Status.Format(WFinRep_DocAttachTable.FIN_Status.DefaultValue)
                        		
                End If
                 
              AddHandler Me.FIN_Status.TextChanged, AddressOf FIN_Status_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetFIN_Type()

                  
            
        
            ' Set the FIN_Type Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_Type is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_Type()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_TypeSpecified Then
                				
                ' If the FIN_Type is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_DocAttachTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_DocAttachTable.FIN_Type)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_DocAttachTable.FIN_Type.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_DocAttachTable.GetDFKA(Me.DataSource.FIN_Type.ToString(),WFinRep_DocAttachTable.FIN_Type, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_DocAttachTable.FIN_Type)
                       End If
                Else
                       formattedValue = Me.DataSource.FIN_Type.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FIN_Type.Text = formattedValue
                
            Else 
            
                ' FIN_Type is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_Type.Text = WFinRep_DocAttachTable.FIN_Type.Format(WFinRep_DocAttachTable.FIN_Type.DefaultValue)
                        		
                End If
                 
            ' If the FIN_Type is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIN_Type.Text Is Nothing _
                OrElse Me.FIN_Type.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIN_Type.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetFIN_Type1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.FIN_Type1.ID) Then
            
                Me.FIN_Type1.Text = Me.PreviousUIData(Me.FIN_Type1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the FIN_Type TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_Type1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_Type1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_TypeSpecified Then
                				
                ' If the FIN_Type is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_DocAttachTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_DocAttachTable.FIN_Type)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_DocAttachTable.FIN_Type.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_DocAttachTable.GetDFKA(Me.DataSource.FIN_Type.ToString(),WFinRep_DocAttachTable.FIN_Type, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_DocAttachTable.FIN_Type)
                       End If
                Else
                       formattedValue = Me.DataSource.FIN_Type.ToString()
                End If
                                
                Me.FIN_Type1.Text = formattedValue
                
            Else 
            
                ' FIN_Type is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_Type1.Text = WFinRep_DocAttachTable.FIN_Type.Format(WFinRep_DocAttachTable.FIN_Type.DefaultValue)
                        		
                End If
                 
              AddHandler Me.FIN_Type1.TextChanged, AddressOf FIN_Type1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetFIN_Year()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.FIN_Year.ID) Then
            
                Me.FIN_Year.Text = Me.PreviousUIData(Me.FIN_Year.ID).ToString()
              
                Return
            End If
            
        
            ' Set the FIN_Year TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_Year is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_Year()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_YearSpecified Then
                				
                ' If the FIN_Year is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_DocAttachTable.FIN_Year)
                              
                Me.FIN_Year.Text = formattedValue
                
            Else 
            
                ' FIN_Year is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_Year.Text = WFinRep_DocAttachTable.FIN_Year.Format(WFinRep_DocAttachTable.FIN_Year.DefaultValue)
                        		
                End If
                 
              AddHandler Me.FIN_Year.TextChanged, AddressOf FIN_Year_TextChanged
                                 
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

      
        
        ' To customize, override this method in WFinRep_DocAttachTableControlRow.
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
        
        Dim parentCtrl As WFinRep_HeadTableControlRow
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_HeadTableControlRow"), WFinRep_HeadTableControlRow)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ePortalWFApproval"))
            End If
            
            Me.DataSource.FIN_HFIN_ID = parentCtrl.DataSource.HFIN_ID
              
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
              
                DirectCast(GetParentControlObject(Me, "WFinRep_DocAttachTableControl"), WFinRep_DocAttachTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WFinRep_DocAttachTableControl"), WFinRep_DocAttachTableControl).ResetData = True
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

        ' To customize, override this method in WFinRep_DocAttachTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetFIN_Company()
            GetFIN_File1()
            GetFIN_HFIN_ID()
            GetFIN_Month()
            GetFIN_RWRem()
            GetFIN_Status()
            GetFIN_Type()
            GetFIN_Type1()
            GetFIN_Year()
        End Sub
        
        
        Public Overridable Sub GetFIN_Company()
            
        End Sub
                
        Public Overridable Sub GetFIN_File1()
            
        End Sub
                
        Public Overridable Sub GetFIN_HFIN_ID()
            
        End Sub
                
        Public Overridable Sub GetFIN_Month()
            
        End Sub
                
        Public Overridable Sub GetFIN_RWRem()
            
        End Sub
                
        Public Overridable Sub GetFIN_Status()
            
        End Sub
                
        Public Overridable Sub GetFIN_Type()
            
        End Sub
                
        Public Overridable Sub GetFIN_Type1()
            
        End Sub
                
        Public Overridable Sub GetFIN_Year()
            
        End Sub
                
      
        ' To customize, override this method in WFinRep_DocAttachTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WFinRep_DocAttachTableControlRow.
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
          WFinRep_DocAttachTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WFinRep_DocAttachTableControl"), WFinRep_DocAttachTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WFinRep_DocAttachTableControl"), WFinRep_DocAttachTableControl).ResetData = True
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
        
        Protected Overridable Sub FIN_Company_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub FIN_File1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub FIN_HFIN_ID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub FIN_Month_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub FIN_Status_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub FIN_Type1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub FIN_Year_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
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
                Return CType(Me.ViewState("BaseWFinRep_DocAttachTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWFinRep_DocAttachTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WFinRep_DocAttachRecord
            Get
                Return DirectCast(MyBase._DataSource, WFinRep_DocAttachRecord)
            End Get
            Set(ByVal value As WFinRep_DocAttachRecord)
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
        
        Public ReadOnly Property FIN_Company() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_Company"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property FIN_File1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_File1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property FIN_HFIN_ID() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_HFIN_ID"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property FIN_Month() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_Month"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property FIN_RWRem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_RWRem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FIN_Status() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_Status"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property FIN_Type() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_Type"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FIN_Type1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_Type1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property FIN_Year() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_Year"), System.Web.UI.WebControls.TextBox)
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
            
            Dim rec As WFinRep_DocAttachRecord = Nothing
             
        
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
            
            Dim rec As WFinRep_DocAttachRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WFinRep_DocAttachRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WFinRep_DocAttachTable.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WFinRep_DocAttachTableControl control on the FSWF_Inquiry page.
' Do not modify this class. Instead override any method in WFinRep_DocAttachTableControl.
Public Class BaseWFinRep_DocAttachTableControl
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WFinRep_DocAttachRecord)), WFinRep_DocAttachRecord())
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
                    For Each rc As WFinRep_DocAttachTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WFinRep_DocAttachRecord)), WFinRep_DocAttachRecord())
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
            ByVal pageSize As Integer) As WFinRep_DocAttachRecord()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRep_DocAttachTable.Column1, True)         
            ' selCols.Add(WFinRep_DocAttachTable.Column2, True)          
            ' selCols.Add(WFinRep_DocAttachTable.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WFinRep_DocAttachTable.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WFinRep_DocAttachTable
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WFinRep_DocAttachRecord)), WFinRep_DocAttachRecord())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRep_DocAttachTable.Column1, True)         
            ' selCols.Add(WFinRep_DocAttachTable.Column2, True)          
            ' selCols.Add(WFinRep_DocAttachTable.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WFinRep_DocAttachTable.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WFinRep_DocAttachTable
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_DocAttachTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WFinRep_DocAttachTableControlRow = DirectCast(repItem.FindControl("WFinRep_DocAttachTableControlRow"), WFinRep_DocAttachTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                SetFIN_RWRemLabel()
                SetFIN_TypeLabel()
                SetLiteral()
                
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
          
            Me.Page.PregetDfkaRecords(WFinRep_DocAttachTable.FIN_Company, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_DocAttachTable.FIN_HFIN_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_DocAttachTable.FIN_Month, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_DocAttachTable.FIN_Status, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_DocAttachTable.FIN_Type, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_DocAttachTable.FIN_Type, Me.DataSource)
          
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

            ' Bind the buttons for WFinRep_DocAttachTableControl pagination.
        
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
            
            Dim recCtl As WFinRep_DocAttachTableControlRow
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
            WFinRep_DocAttachTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
        Dim wFinRep_HeadRecordObj as KeyValue
        wFinRep_HeadRecordObj = Nothing
      
              Dim wFinRep_HeadTableControlObjRow As WFinRep_HeadTableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_HeadTableControlRow") ,WFinRep_HeadTableControlRow)
            
                If (Not IsNothing(wFinRep_HeadTableControlObjRow) AndAlso Not IsNothing(wFinRep_HeadTableControlObjRow.GetRecord()) AndAlso Not IsNothing(wFinRep_HeadTableControlObjRow.GetRecord().HFIN_ID))
                    wc.iAND(WFinRep_DocAttachTable.FIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, wFinRep_HeadTableControlObjRow.GetRecord().HFIN_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If
              
      HttpContext.Current.Session("WFinRep_DocAttachTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WFinRep_DocAttachTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_ActivityTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWFinRep_HeadTableControl as String = DirectCast(HttpContext.Current.Session("WFinRep_DocAttachTableControlWhereClause"), String)
            
            If Not selectedRecordInWFinRep_HeadTableControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWFinRep_HeadTableControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWFinRep_HeadTableControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(WFinRep_DocAttachTable.FIN_HFIN_ID) Then
            wc.iAND(WFinRep_DocAttachTable.FIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(WFinRep_DocAttachTable.FIN_HFIN_ID).ToString())
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_DocAttachTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WFinRep_DocAttachTableControlRow = DirectCast(repItem.FindControl("WFinRep_DocAttachTableControlRow"), WFinRep_DocAttachTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WFinRep_DocAttachRecord = New WFinRep_DocAttachRecord()
        
                        If recControl.FIN_Company.Text <> "" Then
                            rec.Parse(recControl.FIN_Company.Text, WFinRep_DocAttachTable.FIN_Company)
                        End If
                        If recControl.FIN_File1.Text <> "" Then
                            rec.Parse(recControl.FIN_File1.Text, WFinRep_DocAttachTable.FIN_File1)
                        End If
                        If recControl.FIN_HFIN_ID.Text <> "" Then
                            rec.Parse(recControl.FIN_HFIN_ID.Text, WFinRep_DocAttachTable.FIN_HFIN_ID)
                        End If
                        If recControl.FIN_Month.Text <> "" Then
                            rec.Parse(recControl.FIN_Month.Text, WFinRep_DocAttachTable.FIN_Month)
                        End If
                        If recControl.FIN_RWRem.Text <> "" Then
                            rec.Parse(recControl.FIN_RWRem.Text, WFinRep_DocAttachTable.FIN_RWRem)
                        End If
                        If recControl.FIN_Status.Text <> "" Then
                            rec.Parse(recControl.FIN_Status.Text, WFinRep_DocAttachTable.FIN_Status)
                        End If
                        If recControl.FIN_Type.Text <> "" Then
                            rec.Parse(recControl.FIN_Type.Text, WFinRep_DocAttachTable.FIN_Type)
                        End If
                        If recControl.FIN_Type1.Text <> "" Then
                            rec.Parse(recControl.FIN_Type1.Text, WFinRep_DocAttachTable.FIN_Type)
                        End If
                        If recControl.FIN_Year.Text <> "" Then
                            rec.Parse(recControl.FIN_Year.Text, WFinRep_DocAttachTable.FIN_Year)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WFinRep_DocAttachRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WFinRep_DocAttachRecord)), WFinRep_DocAttachRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WFinRep_DocAttachTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WFinRep_DocAttachTableControlRow) As Boolean
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
        
        Public Overridable Sub SetFIN_RWRemLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.FIN_RWRemLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetFIN_TypeLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.FIN_TypeLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal.Text = "Some value"
                    
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

            Dim orderByStr As String = CType(ViewState("WFinRep_DocAttachTableControl_OrderBy"), String)
          
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
                Me.ViewState("WFinRep_DocAttachTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
                    _TotalRecords = WFinRep_DocAttachTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WFinRep_DocAttachRecord ()
            Get
                Return DirectCast(MyBase._DataSource, WFinRep_DocAttachRecord())
            End Get
            Set(ByVal value() As WFinRep_DocAttachRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property FIN_RWRemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_RWRemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FIN_TypeLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_TypeLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Pagination2() As ePortalWFApproval.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pagination2"), ePortalWFApproval.UI.IPagination)
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
                Dim recCtl As WFinRep_DocAttachTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRep_DocAttachRecord = Nothing     
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
                Dim recCtl As WFinRep_DocAttachTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRep_DocAttachRecord = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WFinRep_DocAttachTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WFinRep_DocAttachTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WFinRep_DocAttachTableControlRow)), WFinRep_DocAttachTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WFinRep_DocAttachTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WFinRep_DocAttachTableControlRow
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

        Public Overridable Function GetRecordControls() As WFinRep_DocAttachTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WFinRep_DocAttachTableControlRow")
            Dim list As New List(Of WFinRep_DocAttachTableControlRow)
            For Each recCtrl As WFinRep_DocAttachTableControlRow In recCtrls
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

  
' Base class for the WFinRep_HeadTableControlRow control on the FSWF_Inquiry page.
' Do not modify this class. Instead override any method in WFinRep_HeadTableControlRow.
Public Class BaseWFinRep_HeadTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WFinRep_HeadTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WFinRep_HeadTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
              AddHandler Me.EditRowButton.Click, AddressOf EditRowButton_Click
                        
              AddHandler Me.ExpandRowButton.Click, AddressOf ExpandRowButton_Click
                        
              AddHandler Me.ViewRowButton.Click, AddressOf ViewRowButton_Click
                        
              AddHandler Me.btnEdit.Button.Click, AddressOf btnEdit_Click
                        
              AddHandler Me.btnPreview1.Button.Click, AddressOf btnPreview1_Click
                        
              AddHandler Me.btnPreview2.Button.Click, AddressOf btnPreview2_Click
                        
              AddHandler Me.HFIN_C_ID1.TextChanged, AddressOf HFIN_C_ID1_TextChanged
            
              AddHandler Me.HFIN_Description1.TextChanged, AddressOf HFIN_Description1_TextChanged
            
              AddHandler Me.HFIN_ID.TextChanged, AddressOf HFIN_ID_TextChanged
            
              AddHandler Me.HFIN_Month1.TextChanged, AddressOf HFIN_Month1_TextChanged
            
              AddHandler Me.HFIN_Status.TextChanged, AddressOf HFIN_Status_TextChanged
            
              AddHandler Me.HFIN_Year1.TextChanged, AddressOf HFIN_Year1_TextChanged
            
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WF%dbo.WFinRep_Head record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WFinRep_HeadTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWFinRep_HeadTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WFinRep_HeadRecord()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WFinRep_HeadTableControlRow.
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
        
                
                
                
                
                
                SetHFIN_C_ID()
                SetHFIN_C_ID1()
                SetHFIN_Description()
                SetHFIN_Description1()
                SetHFIN_File()
                SetHFIN_ID()
                SetHFIN_Month()
                SetHFIN_Month1()
                SetHFIN_RptCount()
                SetHFIN_Status()
                SetHFIN_Status1()
                SetHFIN_Year()
                SetHFIN_Year1()
                
                
                
                
                
                
                
                SetWFinRep_HeadTableControlTabContainer()
                SetEditRowButton()
              
                SetExpandRowButton()
              
                SetViewRowButton()
              
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
                      
        SetVw_FS_WFinRep_Attachment_PerReportTypeTableControl()
                  
        SetWFinRep_ActivityTableControl()
                  
        SetWFinRep_DocAttachTableControl()
        
        End Sub
        
        
        Public Overridable Sub SetHFIN_C_ID()

                  
            
        
            ' Set the HFIN_C_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_C_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_C_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_C_IDSpecified Then
                				
                ' If the HFIN_C_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_HeadTable.HFIN_C_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_HeadTable.HFIN_C_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_HeadTable.GetDFKA(Me.DataSource.HFIN_C_ID.ToString(),WFinRep_HeadTable.HFIN_C_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_HeadTable.HFIN_C_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_C_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_C_ID.Text = formattedValue
                
            Else 
            
                ' HFIN_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_C_ID.Text = WFinRep_HeadTable.HFIN_C_ID.Format(WFinRep_HeadTable.HFIN_C_ID.DefaultValue)
                        		
                End If
                 
            ' If the HFIN_C_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.HFIN_C_ID.Text Is Nothing _
                OrElse Me.HFIN_C_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.HFIN_C_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetHFIN_C_ID1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.HFIN_C_ID1.ID) Then
            
                Me.HFIN_C_ID1.Text = Me.PreviousUIData(Me.HFIN_C_ID1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the HFIN_C_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_C_ID1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_C_ID1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_C_IDSpecified Then
                				
                ' If the HFIN_C_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_HeadTable.HFIN_C_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_HeadTable.HFIN_C_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_HeadTable.GetDFKA(Me.DataSource.HFIN_C_ID.ToString(),WFinRep_HeadTable.HFIN_C_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_HeadTable.HFIN_C_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_C_ID.ToString()
                End If
                                
                Me.HFIN_C_ID1.Text = formattedValue
                
            Else 
            
                ' HFIN_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_C_ID1.Text = WFinRep_HeadTable.HFIN_C_ID.Format(WFinRep_HeadTable.HFIN_C_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_C_ID1.TextChanged, AddressOf HFIN_C_ID1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_Description()

                  
            
        
            ' Set the HFIN_Description Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Description is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Description()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_DescriptionSpecified Then
                				
                ' If the HFIN_Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_HeadTable.HFIN_Description)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_Description.Text = formattedValue
                
            Else 
            
                ' HFIN_Description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Description.Text = WFinRep_HeadTable.HFIN_Description.Format(WFinRep_HeadTable.HFIN_Description.DefaultValue)
                        		
                End If
                 
            ' If the HFIN_Description is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.HFIN_Description.Text Is Nothing _
                OrElse Me.HFIN_Description.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.HFIN_Description.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetHFIN_Description1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.HFIN_Description1.ID) Then
            
                Me.HFIN_Description1.Text = Me.PreviousUIData(Me.HFIN_Description1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the HFIN_Description TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Description1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Description1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_DescriptionSpecified Then
                				
                ' If the HFIN_Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_HeadTable.HFIN_Description)
                              
                Me.HFIN_Description1.Text = formattedValue
                
            Else 
            
                ' HFIN_Description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Description1.Text = WFinRep_HeadTable.HFIN_Description.Format(WFinRep_HeadTable.HFIN_Description.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_Description1.TextChanged, AddressOf HFIN_Description1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_File()

                  
                
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_FileSpecified Then
                
                Me.HFIN_File.Text = Page.GetResourceValue("Txt:OpenFile", "ePortalWFApproval")
                        
                Me.HFIN_File.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WFinRep_Head") & _
                            "&Field=" & Me.Page.Encrypt("HFIN_File") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"
                   
                Me.HFIN_File.Visible = True
            Else
                Me.HFIN_File.Visible = False
            End If
        End Sub
                
        Public Overridable Sub SetHFIN_ID()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.HFIN_ID.ID) Then
            
                Me.HFIN_ID.Text = Me.PreviousUIData(Me.HFIN_ID.ID).ToString()
              
                Return
            End If
            
        
            ' Set the HFIN_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_ID is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_IDSpecified Then
                				
                ' If the HFIN_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_HeadTable.HFIN_ID)
                              
                Me.HFIN_ID.Text = formattedValue
                
            Else 
            
                ' HFIN_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_ID.Text = WFinRep_HeadTable.HFIN_ID.Format(WFinRep_HeadTable.HFIN_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_ID.TextChanged, AddressOf HFIN_ID_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_Month()

                  
            
        
            ' Set the HFIN_Month Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Month is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Month()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_MonthSpecified Then
                				
                ' If the HFIN_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_HeadTable.HFIN_Month)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_HeadTable.HFIN_Month.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_HeadTable.GetDFKA(Me.DataSource.HFIN_Month.ToString(),WFinRep_HeadTable.HFIN_Month, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_HeadTable.HFIN_Month)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_Month.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_Month.Text = formattedValue
                
            Else 
            
                ' HFIN_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Month.Text = WFinRep_HeadTable.HFIN_Month.Format(WFinRep_HeadTable.HFIN_Month.DefaultValue)
                        		
                End If
                 
            ' If the HFIN_Month is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.HFIN_Month.Text Is Nothing _
                OrElse Me.HFIN_Month.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.HFIN_Month.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetHFIN_Month1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.HFIN_Month1.ID) Then
            
                Me.HFIN_Month1.Text = Me.PreviousUIData(Me.HFIN_Month1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the HFIN_Month TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Month1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Month1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_MonthSpecified Then
                				
                ' If the HFIN_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_HeadTable.HFIN_Month)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_HeadTable.HFIN_Month.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_HeadTable.GetDFKA(Me.DataSource.HFIN_Month.ToString(),WFinRep_HeadTable.HFIN_Month, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_HeadTable.HFIN_Month)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_Month.ToString()
                End If
                                
                Me.HFIN_Month1.Text = formattedValue
                
            Else 
            
                ' HFIN_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Month1.Text = WFinRep_HeadTable.HFIN_Month.Format(WFinRep_HeadTable.HFIN_Month.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_Month1.TextChanged, AddressOf HFIN_Month1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_RptCount()

                  
            
        
            ' Set the HFIN_RptCount Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_RptCount is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_RptCount()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_RptCountSpecified Then
                				
                ' If the HFIN_RptCount is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_HeadTable.HFIN_RptCount)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_RptCount.Text = formattedValue
                
            Else 
            
                ' HFIN_RptCount is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_RptCount.Text = WFinRep_HeadTable.HFIN_RptCount.Format(WFinRep_HeadTable.HFIN_RptCount.DefaultValue)
                        		
                End If
                 
            ' If the HFIN_RptCount is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.HFIN_RptCount.Text Is Nothing _
                OrElse Me.HFIN_RptCount.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.HFIN_RptCount.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetHFIN_Status()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.HFIN_Status.ID) Then
            
                Me.HFIN_Status.Text = Me.PreviousUIData(Me.HFIN_Status.ID).ToString()
              
                Return
            End If
            
        
            ' Set the HFIN_Status TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Status is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_StatusSpecified Then
                				
                ' If the HFIN_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_HeadTable.HFIN_Status)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_HeadTable.HFIN_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_HeadTable.GetDFKA(Me.DataSource.HFIN_Status.ToString(),WFinRep_HeadTable.HFIN_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_HeadTable.HFIN_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_Status.ToString()
                End If
                                
                Me.HFIN_Status.Text = formattedValue
                
            Else 
            
                ' HFIN_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Status.Text = WFinRep_HeadTable.HFIN_Status.Format(WFinRep_HeadTable.HFIN_Status.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_Status.TextChanged, AddressOf HFIN_Status_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_Status1()

                  
            
        
            ' Set the HFIN_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Status1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Status1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_StatusSpecified Then
                				
                ' If the HFIN_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_HeadTable.HFIN_Status)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_HeadTable.HFIN_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_HeadTable.GetDFKA(Me.DataSource.HFIN_Status.ToString(),WFinRep_HeadTable.HFIN_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_HeadTable.HFIN_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_Status.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_Status1.Text = formattedValue
                
            Else 
            
                ' HFIN_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Status1.Text = WFinRep_HeadTable.HFIN_Status.Format(WFinRep_HeadTable.HFIN_Status.DefaultValue)
                        		
                End If
                 
            ' If the HFIN_Status is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.HFIN_Status1.Text Is Nothing _
                OrElse Me.HFIN_Status1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.HFIN_Status1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetHFIN_Year()

                  
            
        
            ' Set the HFIN_Year Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Year is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Year()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_YearSpecified Then
                				
                ' If the HFIN_Year is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_HeadTable.HFIN_Year)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_Year.Text = formattedValue
                
            Else 
            
                ' HFIN_Year is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Year.Text = WFinRep_HeadTable.HFIN_Year.Format(WFinRep_HeadTable.HFIN_Year.DefaultValue)
                        		
                End If
                 
            ' If the HFIN_Year is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.HFIN_Year.Text Is Nothing _
                OrElse Me.HFIN_Year.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.HFIN_Year.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetHFIN_Year1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.HFIN_Year1.ID) Then
            
                Me.HFIN_Year1.Text = Me.PreviousUIData(Me.HFIN_Year1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the HFIN_Year TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Year1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Year1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_YearSpecified Then
                				
                ' If the HFIN_Year is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_HeadTable.HFIN_Year)
                              
                Me.HFIN_Year1.Text = formattedValue
                
            Else 
            
                ' HFIN_Year is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Year1.Text = WFinRep_HeadTable.HFIN_Year.Format(WFinRep_HeadTable.HFIN_Year.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_Year1.TextChanged, AddressOf HFIN_Year1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFinRep_HeadTableControlTabContainer()           
                        
                   
            If EvaluateFormula("URL(""TabVisible"")").ToLower() = "true" Then
                MiscUtils.FindControlRecursively(Me, "WFinRep_HeadTableControlTabContainer").Visible = True
            ElseIf EvaluateFormula("URL(""TabVisible"")").ToLower() = "false" Then
                MiscUtils.FindControlRecursively(Me, "WFinRep_HeadTableControlTabContainer").Visible = False
            End If
         
  
        End Sub        
      
        Public Overridable Sub SetVw_FS_WFinRep_Attachment_PerReportTypeTableControl()           
        
        
            If Vw_FS_WFinRep_Attachment_PerReportTypeTableControl.Visible Then
                Vw_FS_WFinRep_Attachment_PerReportTypeTableControl.LoadData()
                Vw_FS_WFinRep_Attachment_PerReportTypeTableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWFinRep_ActivityTableControl()           
        
        
            If WFinRep_ActivityTableControl.Visible Then
                WFinRep_ActivityTableControl.LoadData()
                WFinRep_ActivityTableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWFinRep_DocAttachTableControl()           
        
        
            If WFinRep_DocAttachTableControl.Visible Then
                WFinRep_DocAttachTableControl.LoadData()
                WFinRep_DocAttachTableControl.DataBind()
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

      
        
        ' To customize, override this method in WFinRep_HeadTableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "WFinRep_HeadTableControl"), WFinRep_HeadTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WFinRep_HeadTableControl"), WFinRep_HeadTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            Me.CheckSum = ""
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        Dim recVw_FS_WFinRep_Attachment_PerReportTypeTableControl as Vw_FS_WFinRep_Attachment_PerReportTypeTableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "Vw_FS_WFinRep_Attachment_PerReportTypeTableControl"), Vw_FS_WFinRep_Attachment_PerReportTypeTableControl)
        recVw_FS_WFinRep_Attachment_PerReportTypeTableControl.SaveData()
          
        Dim recWFinRep_ActivityTableControl as WFinRep_ActivityTableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WFinRep_ActivityTableControl"), WFinRep_ActivityTableControl)
        recWFinRep_ActivityTableControl.SaveData()
          
        Dim recWFinRep_DocAttachTableControl as WFinRep_DocAttachTableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WFinRep_DocAttachTableControl"), WFinRep_DocAttachTableControl)
        recWFinRep_DocAttachTableControl.SaveData()
          
        End Sub

        ' To customize, override this method in WFinRep_HeadTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetHFIN_C_ID()
            GetHFIN_C_ID1()
            GetHFIN_Description()
            GetHFIN_Description1()
            GetHFIN_ID()
            GetHFIN_Month()
            GetHFIN_Month1()
            GetHFIN_RptCount()
            GetHFIN_Status()
            GetHFIN_Status1()
            GetHFIN_Year()
            GetHFIN_Year1()
        End Sub
        
        
        Public Overridable Sub GetHFIN_C_ID()
            
        End Sub
                
        Public Overridable Sub GetHFIN_C_ID1()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Description()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Description1()
            
        End Sub
                
        Public Overridable Sub GetHFIN_ID()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Month()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Month1()
            
        End Sub
                
        Public Overridable Sub GetHFIN_RptCount()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Status()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Status1()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Year()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Year1()
            
        End Sub
                
      
        ' To customize, override this method in WFinRep_HeadTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WFinRep_HeadTableControlRow.
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
          WFinRep_HeadTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WFinRep_HeadTableControl"), WFinRep_HeadTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WFinRep_HeadTableControl"), WFinRep_HeadTableControl).ResetData = True
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
        
        Public Overridable Sub SetEditRowButton()                
              
   
        End Sub
            
        Public Overridable Sub SetExpandRowButton()                
              
   
        End Sub
            
        Public Overridable Sub SetViewRowButton()                
              
   
        End Sub
            
        Public Overridable Sub SetbtnEdit()                
              
   
        End Sub
            
        Public Overridable Sub SetbtnPreview1()                
              
   
        End Sub
            
        Public Overridable Sub SetbtnPreview2()                
              
   
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub EditRowButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../WFinRep_Head/Edit-WFinRep-Head.aspx?WFinRep_Head={PK}"
                  
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
        
        ' event handler for ImageButton
        Public Overridable Sub ExpandRowButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
          Dim panelControl as WFinRep_HeadTableControl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_HeadTableControl"), WFinRep_HeadTableControl)

          Dim repeatedRows() as WFinRep_HeadTableControlRow = panelControl.GetRecordControls()
          For Each repeatedRow as WFinRep_HeadTableControlRow in repeatedRows
              Dim altRow as System.Web.UI.Control= DirectCast(MiscUtils.FindControlRecursively(repeatedRow, "WFinRep_HeadTableControlAltRow"), System.Web.UI.Control)
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
        Public Overridable Sub ViewRowButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../Shared/ConfigureViewRecord.aspx"
                  
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
        
        ' event handler for Button
        Public Overridable Sub btnEdit_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../WFinRep_Head/WFin-ApproverPage.aspx?WFinRep_Head={WFinRep_HeadTableControlRow:PK}"
                  
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
        
        Protected Overridable Sub HFIN_C_ID1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_Description1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_ID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_Month1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_Status_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_Year1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
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
                Return CType(Me.ViewState("BaseWFinRep_HeadTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWFinRep_HeadTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WFinRep_HeadRecord
            Get
                Return DirectCast(MyBase._DataSource, WFinRep_HeadRecord)
            End Get
            Set(ByVal value As WFinRep_HeadRecord)
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
        
        Public ReadOnly Property EditRowButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EditRowButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property ExpandRowButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ExpandRowButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_C_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_C_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_C_ID1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_C_ID1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Description() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Description"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Description1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Description1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_File() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_File"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_ID() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_ID"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Month() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Month"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Month1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Month1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_RptCount() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_RptCount"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Status() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Status"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Status1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Status1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Year() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Year"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Year1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Year1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property ViewRowButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ViewRowButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Vw_FS_WFinRep_Attachment_PerReportTypeTableControl() As Vw_FS_WFinRep_Attachment_PerReportTypeTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Vw_FS_WFinRep_Attachment_PerReportTypeTableControl"), Vw_FS_WFinRep_Attachment_PerReportTypeTableControl)
            End Get
        End Property
        
        Public ReadOnly Property WFinRep_ActivityTableControl() As WFinRep_ActivityTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_ActivityTableControl"), WFinRep_ActivityTableControl)
            End Get
        End Property
        
        Public ReadOnly Property WFinRep_DocAttachTableControl() As WFinRep_DocAttachTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_DocAttachTableControl"), WFinRep_DocAttachTableControl)
            End Get
        End Property
        
        Public ReadOnly Property WFinRep_HeadTableControlTabContainer() As AjaxControlToolkit.TabContainer
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_HeadTableControlTabContainer"), AjaxControlToolkit.TabContainer)
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
            
            Dim rec As WFinRep_HeadRecord = Nothing
             
        
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
            
            Dim rec As WFinRep_HeadRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WFinRep_HeadRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WFinRep_HeadTable.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WFinRep_HeadTableControl control on the FSWF_Inquiry page.
' Do not modify this class. Instead override any method in WFinRep_HeadTableControl.
Public Class BaseWFinRep_HeadTableControl
        Inherits ePortalWFApproval.UI.BaseApplicationTableControl

        
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
    
           ' Setup the filter and search.
        
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.HFIN_C_IDFilter) 				
                    initialVal = Me.GetFromSession(Me.HFIN_C_IDFilter)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""HFIN_C_ID"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.HFIN_C_IDFilter.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.HFIN_C_IDFilter.SelectedValue = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.HFIN_MonthFilter) 				
                    initialVal = Me.GetFromSession(Me.HFIN_MonthFilter)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""HFIN_Month"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.HFIN_MonthFilter.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.HFIN_MonthFilter.SelectedValue = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.HFIN_StatusFilter) 				
                    initialVal = Me.GetFromSession(Me.HFIN_StatusFilter)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""HFIN_Status"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.HFIN_StatusFilter.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.HFIN_StatusFilter.SelectedValue = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.HFIN_YearFromFilter) 				
                    initialVal = Me.GetFromSession(Me.HFIN_YearFromFilter)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""HFIN_YearFrom"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.HFIN_YearFromFilter.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.HFIN_YearFromFilter.SelectedValue = initialVal
                            
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
    
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "12"))
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
                        
              AddHandler Me.HFIN_C_IDFilter.SelectedIndexChanged, AddressOf HFIN_C_IDFilter_SelectedIndexChanged
            
              AddHandler Me.HFIN_MonthFilter.SelectedIndexChanged, AddressOf HFIN_MonthFilter_SelectedIndexChanged
            
              AddHandler Me.HFIN_StatusFilter.SelectedIndexChanged, AddressOf HFIN_StatusFilter_SelectedIndexChanged
            
              AddHandler Me.HFIN_YearFromFilter.SelectedIndexChanged, AddressOf HFIN_YearFromFilter_SelectedIndexChanged
                    
        
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WFinRep_HeadRecord)), WFinRep_HeadRecord())
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
                    For Each rc As WFinRep_HeadTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WFinRep_HeadRecord)), WFinRep_HeadRecord())
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
            ByVal pageSize As Integer) As WFinRep_HeadRecord()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRep_HeadTable.Column1, True)         
            ' selCols.Add(WFinRep_HeadTable.Column2, True)          
            ' selCols.Add(WFinRep_HeadTable.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WFinRep_HeadTable.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WFinRep_HeadTable
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WFinRep_HeadRecord)), WFinRep_HeadRecord())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRep_HeadTable.Column1, True)         
            ' selCols.Add(WFinRep_HeadTable.Column2, True)          
            ' selCols.Add(WFinRep_HeadTable.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WFinRep_HeadTable.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WFinRep_HeadTable
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_HeadTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WFinRep_HeadTableControlRow = DirectCast(repItem.FindControl("WFinRep_HeadTableControlRow"), WFinRep_HeadTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                
                SetHFIN_C_IDFilter()
                SetHFIN_C_IDLabel()
                SetHFIN_C_IDLabel1()
                SetHFIN_DescriptionLabel()
                SetHFIN_MonthFilter()
                SetHFIN_MonthLabel()
                SetHFIN_MonthLabel1()
                SetHFIN_RptCountLabel()
                SetHFIN_StatusFilter()
                SetHFIN_StatusLabel()
                SetHFIN_StatusLabel1()
                SetHFIN_YearFromFilter()
                SetHFIN_YearLabel()
                SetHFIN_YearLabel1()
                
                
                SetGoButton()
              
            ' setting the state of expand or collapse alternative rows
      
            Dim expandFirstRow As Boolean= True
        
            Dim recControls() As WFinRep_HeadTableControlRow = Me.GetRecordControls()
            For i As Integer = 0 to recControls.Length - 1
                Dim altRow As System.Web.UI.Control = DirectCast(MiscUtils.FindControlRecursively(recControls(i), "WFinRep_HeadTableControlAltRow"), System.Web.UI.Control)
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
          
            Me.Page.PregetDfkaRecords(WFinRep_HeadTable.HFIN_C_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_HeadTable.HFIN_C_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_HeadTable.HFIN_Month, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_HeadTable.HFIN_Month, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_HeadTable.HFIN_Status, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_HeadTable.HFIN_Status, Me.DataSource)
          
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

            
            Me.HFIN_C_IDFilter.ClearSelection()
            
            Me.HFIN_MonthFilter.ClearSelection()
            
            Me.HFIN_StatusFilter.ClearSelection()
            
            Me.HFIN_YearFromFilter.ClearSelection()
            
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
            If DbUtils.GetCreatedRecords(Me.DataSource).Length > 0 Then                      
                    
                Me.Pagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Pagination.CurrentPage.Text = "0"
            End If
            Me.Pagination.PageSize.Text = Me.PageSize.ToString()
            Me.Pagination.PageSize.Text = Me.PageSize.ToString()
            Me.Pagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.Pagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.Pagination.TotalPages.Text = Me.TotalPages.ToString()
            Me.Pagination.TotalPages.Text = Me.TotalPages.ToString()

            ' Bind the buttons for WFinRep_HeadTableControl pagination.
        
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
            
            Dim recCtl As WFinRep_HeadTableControlRow
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
            WFinRep_HeadTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
            If IsValueSelected(Me.HFIN_C_IDFilter) Then
    
              hasFiltersWFinRep_HeadTableControl = True            
    
                wc.iAND(WFinRep_HeadTable.HFIN_C_ID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.HFIN_C_IDFilter, Me.GetFromSession(Me.HFIN_C_IDFilter)), False, False)
            
            End If
                  
                
                       
            If IsValueSelected(Me.HFIN_MonthFilter) Then
    
              hasFiltersWFinRep_HeadTableControl = True            
    
                wc.iAND(WFinRep_HeadTable.HFIN_Month, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.HFIN_MonthFilter, Me.GetFromSession(Me.HFIN_MonthFilter)), False, False)
            
            End If
                  
                
                       
            If IsValueSelected(Me.HFIN_StatusFilter) Then
    
              hasFiltersWFinRep_HeadTableControl = True            
    
                wc.iAND(WFinRep_HeadTable.HFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.HFIN_StatusFilter, Me.GetFromSession(Me.HFIN_StatusFilter)), False, False)
            
            End If
                  
                
                       
            If IsValueSelected(Me.HFIN_YearFromFilter) Then
    
              hasFiltersWFinRep_HeadTableControl = True            
    
                wc.iAND(WFinRep_HeadTable.HFIN_Year, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, MiscUtils.GetSelectedValue(Me.HFIN_YearFromFilter, Me.GetFromSession(Me.HFIN_YearFromFilter)), False, False)
            
            End If
                  
                
                       
            Dim bAnyFiltersChanged As Boolean = False
            
            If IsValueSelected(Me.HFIN_C_IDFilter) OrElse Me.InSession(Me.HFIN_C_IDFilter) Then
                bAnyFiltersChanged = True
            End If
            
            If IsValueSelected(Me.HFIN_MonthFilter) OrElse Me.InSession(Me.HFIN_MonthFilter) Then
                bAnyFiltersChanged = True
            End If
            
            If IsValueSelected(Me.HFIN_StatusFilter) OrElse Me.InSession(Me.HFIN_StatusFilter) Then
                bAnyFiltersChanged = True
            End If
            
            If IsValueSelected(Me.HFIN_YearFromFilter) OrElse Me.InSession(Me.HFIN_YearFromFilter) Then
                bAnyFiltersChanged = True
            End If
            
            If Not(bAnyFiltersChanged) Then
                wc.RunQuery = False
            End If 
          
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WFinRep_HeadTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_ActivityTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            Dim HFIN_C_IDFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "HFIN_C_IDFilter_Ajax"), String)
            If IsValueSelected(HFIN_C_IDFilterSelectedValue) Then
    
              hasFiltersWFinRep_HeadTableControl = True            
    
                 wc.iAND(WFinRep_HeadTable.HFIN_C_ID, BaseFilter.ComparisonOperator.EqualsTo, HFIN_C_IDFilterSelectedValue, false, False)
             
             End If
                      
            Dim HFIN_MonthFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "HFIN_MonthFilter_Ajax"), String)
            If IsValueSelected(HFIN_MonthFilterSelectedValue) Then
    
              hasFiltersWFinRep_HeadTableControl = True            
    
                 wc.iAND(WFinRep_HeadTable.HFIN_Month, BaseFilter.ComparisonOperator.EqualsTo, HFIN_MonthFilterSelectedValue, false, False)
             
             End If
                      
            Dim HFIN_StatusFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "HFIN_StatusFilter_Ajax"), String)
            If IsValueSelected(HFIN_StatusFilterSelectedValue) Then
    
              hasFiltersWFinRep_HeadTableControl = True            
    
                 wc.iAND(WFinRep_HeadTable.HFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, HFIN_StatusFilterSelectedValue, false, False)
             
             End If
                      
            Dim HFIN_YearFromFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "HFIN_YearFromFilter_Ajax"), String)
            If IsValueSelected(HFIN_YearFromFilterSelectedValue) Then
    
              hasFiltersWFinRep_HeadTableControl = True            
    
                 wc.iAND(WFinRep_HeadTable.HFIN_Year, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, HFIN_YearFromFilterSelectedValue, false, False)
             
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_HeadTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WFinRep_HeadTableControlRow = DirectCast(repItem.FindControl("WFinRep_HeadTableControlRow"), WFinRep_HeadTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WFinRep_HeadRecord = New WFinRep_HeadRecord()
        
                        If recControl.HFIN_C_ID.Text <> "" Then
                            rec.Parse(recControl.HFIN_C_ID.Text, WFinRep_HeadTable.HFIN_C_ID)
                        End If
                        If recControl.HFIN_C_ID1.Text <> "" Then
                            rec.Parse(recControl.HFIN_C_ID1.Text, WFinRep_HeadTable.HFIN_C_ID)
                        End If
                        If recControl.HFIN_Description.Text <> "" Then
                            rec.Parse(recControl.HFIN_Description.Text, WFinRep_HeadTable.HFIN_Description)
                        End If
                        If recControl.HFIN_Description1.Text <> "" Then
                            rec.Parse(recControl.HFIN_Description1.Text, WFinRep_HeadTable.HFIN_Description)
                        End If
                        If recControl.HFIN_File.Text <> "" Then
                            rec.Parse(recControl.HFIN_File.Text, WFinRep_HeadTable.HFIN_File)
                        End If
                        If recControl.HFIN_ID.Text <> "" Then
                            rec.Parse(recControl.HFIN_ID.Text, WFinRep_HeadTable.HFIN_ID)
                        End If
                        If recControl.HFIN_Month.Text <> "" Then
                            rec.Parse(recControl.HFIN_Month.Text, WFinRep_HeadTable.HFIN_Month)
                        End If
                        If recControl.HFIN_Month1.Text <> "" Then
                            rec.Parse(recControl.HFIN_Month1.Text, WFinRep_HeadTable.HFIN_Month)
                        End If
                        If recControl.HFIN_RptCount.Text <> "" Then
                            rec.Parse(recControl.HFIN_RptCount.Text, WFinRep_HeadTable.HFIN_RptCount)
                        End If
                        If recControl.HFIN_Status.Text <> "" Then
                            rec.Parse(recControl.HFIN_Status.Text, WFinRep_HeadTable.HFIN_Status)
                        End If
                        If recControl.HFIN_Status1.Text <> "" Then
                            rec.Parse(recControl.HFIN_Status1.Text, WFinRep_HeadTable.HFIN_Status)
                        End If
                        If recControl.HFIN_Year.Text <> "" Then
                            rec.Parse(recControl.HFIN_Year.Text, WFinRep_HeadTable.HFIN_Year)
                        End If
                        If recControl.HFIN_Year1.Text <> "" Then
                            rec.Parse(recControl.HFIN_Year1.Text, WFinRep_HeadTable.HFIN_Year)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WFinRep_HeadRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WFinRep_HeadRecord)), WFinRep_HeadRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WFinRep_HeadTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WFinRep_HeadTableControlRow) As Boolean
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
        
        Public Overridable Sub SetHFIN_C_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_C_IDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_C_IDLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_C_IDLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_DescriptionLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_DescriptionLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_MonthLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_MonthLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_MonthLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_MonthLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_RptCountLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_RptCountLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_StatusLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_StatusLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_StatusLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_StatusLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_YearLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_YearLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_YearLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_YearLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_C_IDFilter()

              
            
                Me.PopulateHFIN_C_IDFilter(GetSelectedValue(Me.HFIN_C_IDFilter,  GetFromSession(Me.HFIN_C_IDFilter)), 500)					
                                     
              End Sub	
            
        Public Overridable Sub SetHFIN_MonthFilter()

              
            
                Me.PopulateHFIN_MonthFilter(GetSelectedValue(Me.HFIN_MonthFilter,  GetFromSession(Me.HFIN_MonthFilter)), 500)					
                                     
              End Sub	
            
        Public Overridable Sub SetHFIN_StatusFilter()

              
            
                Me.PopulateHFIN_StatusFilter(GetSelectedValue(Me.HFIN_StatusFilter,  GetFromSession(Me.HFIN_StatusFilter)), 500)					
                                     
              End Sub	
            
        Public Overridable Sub SetHFIN_YearFromFilter()

              
            
                Me.PopulateHFIN_YearFromFilter(GetSelectedValue(Me.HFIN_YearFromFilter,  GetFromSession(Me.HFIN_YearFromFilter)), 500)					
                                     
              End Sub	
            
        ' Get the filters' data for HFIN_C_IDFilter
        Protected Overridable Sub PopulateHFIN_C_IDFilter(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Me.HFIN_C_IDFilter.Items.Clear()
            Dim wc As WhereClause = Me.CreateWhereClause_HFIN_C_IDFilter()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_HFIN_C_IDFilter function.
            ' It is better to customize the where clause there.
            
            ' Setup the static list items        
            
            ' Add the Please Select item.
            Me.HFIN_C_IDFilter.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(Sel_WF_DYNAMICS_CompanyView.Company_Short_Name, OrderByItem.OrderDir.Asc)

            Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)

            	

            Dim noValueFormat As String = Page.GetResourceValue("Txt:Other", "ePortalWFApproval")
            

            Dim itemValues() As Sel_WF_DYNAMICS_CompanyRecord = Nothing
            
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim evaluator As New FormulaEvaluator
                Dim listDuplicates As New ArrayList()

                
                
                Do
                    
                    itemValues = Sel_WF_DYNAMICS_CompanyView.GetRecords(wc, orderBy, pageNum, maxItems)
                                    
                    For each itemValue As Sel_WF_DYNAMICS_CompanyRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.Company_IDSpecified Then
                            cvalue = itemValue.Company_ID.ToString()

                            If counter < maxItems AndAlso Me.HFIN_C_IDFilter.Items.FindByValue(cvalue) Is Nothing  Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_HeadTable.HFIN_C_ID)
                                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_HeadTable.HFIN_C_ID.IsApplyDisplayAs Then
                                    fvalue = WFinRep_HeadTable.GetDFKA(itemValue, WFinRep_HeadTable.HFIN_C_ID)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                    fvalue = itemValue.Format(Sel_WF_DYNAMICS_CompanyView.Company_ID)
                                End If
                                    
                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                   fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If ( fvalue.Length > 50 ) Then
                                   fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.HFIN_C_IDFilter.Items.FindByText(fvalue)
                
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.HFIN_C_IDFilter.Items.Add(newItem)

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
                SetSelectedValue(Me.HFIN_C_IDFilter, selectedValue)
                    
            Catch
            End Try
            
                        
            If Me.HFIN_C_IDFilter.SelectedValue IsNot Nothing AndAlso Me.HFIN_C_IDFilter.Items.FindByValue(Me.HFIN_C_IDFilter.SelectedValue) Is Nothing
                Me.HFIN_C_IDFilter.SelectedValue = Nothing
            End If            
                          
        End Sub
            
        ' Get the filters' data for HFIN_MonthFilter
        Protected Overridable Sub PopulateHFIN_MonthFilter(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Me.HFIN_MonthFilter.Items.Clear()
            Dim wc As WhereClause = Me.CreateWhereClause_HFIN_MonthFilter()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_HFIN_MonthFilter function.
            ' It is better to customize the where clause there.
            
            ' Setup the static list items        
            
            ' Add the Please Select item.
            Me.HFIN_MonthFilter.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            

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

                            If counter < maxItems AndAlso Me.HFIN_MonthFilter.Items.FindByValue(cvalue) Is Nothing  Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_HeadTable.HFIN_Month)
                                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_HeadTable.HFIN_Month.IsApplyDisplayAs Then
                                    fvalue = WFinRep_HeadTable.GetDFKA(itemValue, WFinRep_HeadTable.HFIN_Month)
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

                                Dim dupItem As ListItem = Me.HFIN_MonthFilter.Items.FindByText(fvalue)
                
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.HFIN_MonthFilter.Items.Add(newItem)

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
                SetSelectedValue(Me.HFIN_MonthFilter, selectedValue)
                    
            Catch
            End Try
            
                        
            If Me.HFIN_MonthFilter.SelectedValue IsNot Nothing AndAlso Me.HFIN_MonthFilter.Items.FindByValue(Me.HFIN_MonthFilter.SelectedValue) Is Nothing
                Me.HFIN_MonthFilter.SelectedValue = Nothing
            End If            
                          
        End Sub
            
        ' Get the filters' data for HFIN_StatusFilter
        Protected Overridable Sub PopulateHFIN_StatusFilter(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Me.HFIN_StatusFilter.Items.Clear()
            Dim wc As WhereClause = Me.CreateWhereClause_HFIN_StatusFilter()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_HFIN_StatusFilter function.
            ' It is better to customize the where clause there.
            
            ' Setup the static list items        
            
            ' Add the Please Select item.
            Me.HFIN_StatusFilter.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            

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

                            If counter < maxItems AndAlso Me.HFIN_StatusFilter.Items.FindByValue(cvalue) Is Nothing  Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_HeadTable.HFIN_Status)
                                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_HeadTable.HFIN_Status.IsApplyDisplayAs Then
                                    fvalue = WFinRep_HeadTable.GetDFKA(itemValue, WFinRep_HeadTable.HFIN_Status)
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

                                Dim dupItem As ListItem = Me.HFIN_StatusFilter.Items.FindByText(fvalue)
                
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.HFIN_StatusFilter.Items.Add(newItem)

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
                SetSelectedValue(Me.HFIN_StatusFilter, selectedValue)
                    
            Catch
            End Try
            
                        
            If Me.HFIN_StatusFilter.SelectedValue IsNot Nothing AndAlso Me.HFIN_StatusFilter.Items.FindByValue(Me.HFIN_StatusFilter.SelectedValue) Is Nothing
                Me.HFIN_StatusFilter.SelectedValue = Nothing
            End If            
                          
        End Sub
            
        ' Get the filters' data for HFIN_YearFromFilter
        Protected Overridable Sub PopulateHFIN_YearFromFilter(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Me.HFIN_YearFromFilter.Items.Clear()
            Dim wc As WhereClause = Me.CreateWhereClause_HFIN_YearFromFilter()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_HFIN_YearFromFilter function.
            ' It is better to customize the where clause there.
            
            ' Setup the static list items        
            
            ' Add the Please Select item.
            Me.HFIN_YearFromFilter.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            
            
            
            Dim orderBy As OrderBy = New OrderBy(False, False)
            orderBy.Add(WFinRep_HeadTable.HFIN_Year, OrderByItem.OrderDir.Asc)                
            
            	

            Dim values(-1) As String
            If wc.RunQuery Then
            
                values = WFinRep_HeadTable.GetValues(WFinRep_HeadTable.HFIN_Year, wc, orderBy, maxItems)
            
            End If
            
                  
            Dim cvalue As String
            
            Dim listDuplicates As New ArrayList()
            For Each cvalue In values
                ' Create the item and add to the list.
                Dim fvalue As String
                If ( WFinRep_HeadTable.HFIN_Year.IsColumnValueTypeBoolean()) Then
                    fvalue = cvalue
                Else
                    fvalue = WFinRep_HeadTable.HFIN_Year.Format(cvalue)
                End If

                If (IsNothing(fvalue)) Then
                    fvalue = ""
                End If

                fvalue = fvalue.Trim()

                If ( fvalue.Length > 50 ) Then
                    fvalue = fvalue.Substring(0, 50) & "..."
                End If

                Dim dupItem As ListItem = Me.HFIN_YearFromFilter.Items.FindByText(fvalue)
                
                If Not IsNothing(dupItem) Then
                    listDuplicates.Add(fvalue)
                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                    End If
                End If

                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                Me.HFIN_YearFromFilter.Items.Add(newItem)

                If listDuplicates.Contains(fvalue)  AndAlso Not String.IsNullOrEmpty(cvalue) Then
                    newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                End If
            Next
                                  

            Try    
                
                ' Set the selected value.
                SetSelectedValue(Me.HFIN_YearFromFilter, selectedValue)
                    
            Catch
            End Try
            
                        
            If Me.HFIN_YearFromFilter.SelectedValue IsNot Nothing AndAlso Me.HFIN_YearFromFilter.Items.FindByValue(Me.HFIN_YearFromFilter.SelectedValue) Is Nothing
                Me.HFIN_YearFromFilter.SelectedValue = Nothing
            End If            
                          
        End Sub
            
              

        Public Overridable Function CreateWhereClause_HFIN_C_IDFilter() As WhereClause
          
              Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
            
              Dim hasFiltersWFinRep_ActivityTableControl As Boolean = False
            
              Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
            
              Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
            
            ' Create a where clause for the filter HFIN_C_IDFilter.
            ' This function is called by the Populate method to load the items 
            ' in the HFIN_C_IDFilterDropDownList
            
            Dim wc As WhereClause= New WhereClause()
            Return wc
            
        End Function			
            
              

        Public Overridable Function CreateWhereClause_HFIN_MonthFilter() As WhereClause
          
              Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
            
              Dim hasFiltersWFinRep_ActivityTableControl As Boolean = False
            
              Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
            
              Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
            
            ' Create a where clause for the filter HFIN_MonthFilter.
            ' This function is called by the Populate method to load the items 
            ' in the HFIN_MonthFilterDropDownList
            
            Dim wc As WhereClause= New WhereClause()
            Return wc
            
        End Function			
            
              

        Public Overridable Function CreateWhereClause_HFIN_StatusFilter() As WhereClause
          
              Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
            
              Dim hasFiltersWFinRep_ActivityTableControl As Boolean = False
            
              Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
            
              Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
            
            ' Create a where clause for the filter HFIN_StatusFilter.
            ' This function is called by the Populate method to load the items 
            ' in the HFIN_StatusFilterDropDownList
            
            Dim wc As WhereClause= New WhereClause()
            Return wc
            
        End Function			
            
              

        Public Overridable Function CreateWhereClause_HFIN_YearFromFilter() As WhereClause
          
              Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
            
              Dim hasFiltersWFinRep_ActivityTableControl As Boolean = False
            
              Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
            
              Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
            
            ' Create a where clause for the filter HFIN_YearFromFilter.
            ' This function is called by the Populate method to load the items 
            ' in the HFIN_YearFromFilterDropDownList
            
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
        
            Me.SaveToSession(Me.HFIN_C_IDFilter, Me.HFIN_C_IDFilter.SelectedValue)
                  
            Me.SaveToSession(Me.HFIN_MonthFilter, Me.HFIN_MonthFilter.SelectedValue)
                  
            Me.SaveToSession(Me.HFIN_StatusFilter, Me.HFIN_StatusFilter.SelectedValue)
                  
            Me.SaveToSession(Me.HFIN_YearFromFilter, Me.HFIN_YearFromFilter.SelectedValue)
                  
        
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
          
      Me.SaveToSession("HFIN_C_IDFilter_Ajax", Me.HFIN_C_IDFilter.SelectedValue)
              
      Me.SaveToSession("HFIN_MonthFilter_Ajax", Me.HFIN_MonthFilter.SelectedValue)
              
      Me.SaveToSession("HFIN_StatusFilter_Ajax", Me.HFIN_StatusFilter.SelectedValue)
              
      Me.SaveToSession("HFIN_YearFromFilter_Ajax", Me.HFIN_YearFromFilter.SelectedValue)
              
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.HFIN_C_IDFilter)
            Me.RemoveFromSession(Me.HFIN_MonthFilter)
            Me.RemoveFromSession(Me.HFIN_StatusFilter)
            Me.RemoveFromSession(Me.HFIN_YearFromFilter)
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("WFinRep_HeadTableControl_OrderBy"), String)
          
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
                Me.ViewState("WFinRep_HeadTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
        Protected Overridable Sub HFIN_C_IDFilter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
           ' Setting the DataChanged to True results in the page being refreshed with
           ' the most recent data from the database.  This happens in PreRender event
           ' based on the current sort, search and filter criteria.
           Me.DataChanged = True
           
          	                   
              
        End Sub
            
        ' event handler for FieldFilter
        Protected Overridable Sub HFIN_MonthFilter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
           ' Setting the DataChanged to True results in the page being refreshed with
           ' the most recent data from the database.  This happens in PreRender event
           ' based on the current sort, search and filter criteria.
           Me.DataChanged = True
           
          	                   
              
        End Sub
            
        ' event handler for FieldFilter
        Protected Overridable Sub HFIN_StatusFilter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
           ' Setting the DataChanged to True results in the page being refreshed with
           ' the most recent data from the database.  This happens in PreRender event
           ' based on the current sort, search and filter criteria.
           Me.DataChanged = True
           
          	                   
              
        End Sub
            
        ' event handler for FieldFilter
        Protected Overridable Sub HFIN_YearFromFilter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
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
                    _TotalRecords = WFinRep_HeadTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WFinRep_HeadRecord ()
            Get
                Return DirectCast(MyBase._DataSource, WFinRep_HeadRecord())
            End Get
            Set(ByVal value() As WFinRep_HeadRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property GoButton() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "GoButton"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property HFIN_C_IDFilter() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_C_IDFilter"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_C_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_C_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_C_IDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_C_IDLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_DescriptionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_DescriptionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_MonthFilter() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_MonthFilter"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_MonthLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_MonthLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_MonthLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_MonthLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_RptCountLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_RptCountLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_StatusFilter() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_StatusFilter"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_StatusLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_StatusLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_YearFromFilter() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_YearFromFilter"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_YearLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_YearLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_YearLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_YearLabel1"), System.Web.UI.WebControls.Literal)
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
                Dim recCtl As WFinRep_HeadTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRep_HeadRecord = Nothing     
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
                Dim recCtl As WFinRep_HeadTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRep_HeadRecord = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WFinRep_HeadTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WFinRep_HeadTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WFinRep_HeadTableControlRow)), WFinRep_HeadTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WFinRep_HeadTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WFinRep_HeadTableControlRow
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

        Public Overridable Function GetRecordControls() As WFinRep_HeadTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WFinRep_HeadTableControlRow")
            Dim list As New List(Of WFinRep_HeadTableControlRow)
            For Each recCtrl As WFinRep_HeadTableControlRow In recCtrls
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

  