
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' Homepage.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ePortalWFApproval.UI.Controls.Homepage

#Region "Section 1: Place your customizations here."


    Public Class Sel_Approver_Pending_TasksTableControlRow
        Inherits BaseSel_Approver_Pending_TasksTableControlRow
        ' The BaseSel_Approver_Pending_TasksTableControlRow implements code for a ROW within the
        ' the Sel_Approver_Pending_TasksTableControl table.  The BaseSel_Approver_Pending_TasksTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of Sel_Approver_Pending_TasksTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.


        Public Overrides Sub SetDoc_Type()

            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Doc_TypeSpecified Then
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.Doc_Type)

                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Doc_Type.Text = formattedValue
            Else
                Me.Doc_Type.Text = Sel_Approver_Pending_TasksView.Doc_Type.Format(Sel_Approver_Pending_TasksView.Doc_Type.DefaultValue)
            End If

            If Me.Doc_Type.Text Is Nothing OrElse Me.Doc_Type.Text.Trim() = "" Then
                Me.Doc_Type.Text = "&nbsp;"
            Else
                Select Case Me.Doc_Type.Text
                    Case "PO CANCEL"

                        Me.Doc_Type.Text = "<font color=red>" & Me.Doc_Type.Text & "</font>"

                    Case Else
                        Me.Doc_Type.Text = Me.Doc_Type.Text
                End Select
            End If
        End Sub

        Public Overrides Sub DataBind()
            MyBase.DataBind()

            If Me.DataSource Is Nothing Then
                Return
            End If

            SetCompany_Desc()
            SetDate_Assigned()
            SetDoc_No()
            SetDoc_Type()
            SetPK_ID()

            Select Case Me.DataSource.Doc_Type.ToString()
                Case "CAR"
                    Me.imbList.Attributes.Add("onclick", "setTimeout(""" & "window.location='../wf_car/ShowSel_WCAR_Activity_WCAR_DocTable.aspx';"",1800); return false;")
                Case "PR"
                    Me.imbList.Attributes.Add("onclick", "setTimeout(""" & "window.location='../wf_pr/ShowSel_WPR_Activity_WPR_DocTable.aspx';"",1800); return false;")
                Case "PO"
                    Me.imbList.Attributes.Add("onclick", "setTimeout(""" & "window.location='../wf_PO/ShowSel_WPO_Activity_WPOP10100Table.aspx';"",1800); return false;")
                Case "FS"
                    Me.imbList.Attributes.Add("onclick", "setTimeout(""" & "window.location='../WFinRep_Head/WFin_ApproverTable.aspx';"",1800); return false;")
                Case "FSN"
                    Me.imbList.Attributes.Add("onclick", "setTimeout(""" & "window.location='../WFinRep_Head/WFinRepNGP_ApproverTable.aspx';"",1800); return false;")
                Case "CONSOLIDATED"
                    Me.imbList.Attributes.Add("onclick", "setTimeout(""" & "window.location='../WFinRep_Head/Conso_ReportDoc_ApproverTable.aspx';"",1800); return false;")
                Case "PO CANCEL"
                    Me.imbList.Attributes.Add("onclick", "setTimeout(""" & "window.location='../wf_cv/ShowSel_WCanvass_PO_Map_AdjustmentTable.aspx';"",1800); return false;")
                Case "_CAR(RETURN)", "_PO(RETURN)"
                    Me.imbList.Visible = False
                Case Else
                    Me.imbList.Attributes.Add("onclick", "setTimeout(""" & "window.location='../sel_WCAR_Doc_Creator_Approver/Show-Sel-WCAR-Doc-Creator-Approver-Table.aspx';"",1800); return false;")
            End Select

            Me.IsNewRecord = True

            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
            End If

            Dim shouldResetControl As Boolean = False
        End Sub


        Public Overrides Sub imbList_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
            Try
                Dim oHead As Sel_Approver_Pending_TasksTableControl = DirectCast(Me.Page.FindControlRecursively("Sel_Approver_Pending_TasksTableControl"), Sel_Approver_Pending_TasksTableControl)
                oHead.Image.Visible = True
                oHead.litLoading.Visible = True
                oHead.Literal2.Visible = False
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally

            End Try
        End Sub



        Public Overrides Sub imbDoc_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim pubUrl As String
            Select Case Me.Doc_Type.Text
                Case "CAR", "<font color=black>CAR</font>"
                    pubUrl = "../WCAR_Doc/EditWCAR-Doc-Approval.aspx?WCAR_Doc=" & Me.PK_ID.Text
                Case "PR", "<font color=black>PR</font>"
                    pubUrl = "../wf_pr/EditWPR_Doc_Approval.aspx?WPR_Doc=" & Me.PK_ID.Text
                Case "PO", "<font color=black>PO</font>"
                    pubUrl = "../sel_WPO_WFTask/WPO-WFTask.aspx?POP10100_PO=" & Me.Doc_No.Text & "&POP10100_Co=" & Me.C_ID.Text
                Case "FS", "<font color=black>FS</font>"
                    pubUrl = "../WFinRep_Head/WFin-ApproverPage.aspx?WFinRep_Head=" & Me.Doc_No.Text
                Case "FSN", "<font color=black>FSN</font>"
                    pubUrl = "../WFinRep_Head/WFinRepNGP_Approver.aspx?WFinRepNGP_Head=" & Me.Doc_No.Text
                Case "CONSOLIDATED", "<font color=black>CONSOLIDATED</font>"
                    pubUrl = "../WFinRep_Head/Conso_ReportDoc_Approver.aspx?WFinRepCon_Head=" & Me.Doc_No.Text
                Case "PO CANCEL", "<font color=black>PO CANCEL</font>"
                    pubUrl = "../wf_cv/EditWCanvass_PO_Map.aspx?WCanvass_PO_Map=" & Me.PK_ID.Text
                Case "_CAR(RETURN)", "_PO(RETURN)"
                    Me.imbDoc.Visible = False
                Case Else
                    pubUrl = "../WCAR_Doc/Edit-WCAR-Doc.aspx?WCAR_Doc=" & Me.PK_ID.Text
            End Select
            Dim url As String = pubUrl

            If Me.Page.Request("RedirectStyle") <> "" Then url &= "&RedirectStyle=" & Me.Page.Request("RedirectStyle")

            Dim shouldRedirect As Boolean = True
            Dim target As String = ""

            Try

                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()

                url = Me.ModifyRedirectUrl(url, "", True)
                url = Me.Page.ModifyRedirectUrl(url, "", True)

            Catch ex As Exception

                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally
                DbUtils.EndTransaction()
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)

            End If
        End Sub




    End Class



    Public Class Sel_Approver_Pending_TasksTableControl
        Inherits BaseSel_Approver_Pending_TasksTableControl

        ' The BaseSel_Approver_Pending_TasksTableControl class implements the LoadData, DataBind, CreateWhereClause
        ' and other methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        ' The Sel_Approver_Pending_TasksTableControlRow class offers another place where you can customize
        ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.



        Public Overrides Function CreateWhereClause() As WhereClause
            Sel_Approver_Pending_TasksView.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()

            wc.iAND(Sel_Approver_Pending_TasksView.W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserId").ToString())
            wc.iAND(Sel_Approver_Pending_TasksView.Doc_Type, BaseFilter.ComparisonOperator.Not_Equals, "PR")
            'wc.iAND(Sel_Approver_Pending_TasksView.W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, "161")
            Return wc
        End Function

        Public Overrides Sub LoadData()
            Try
                Dim wc As WhereClause = CreateWhereClause()
                If wc IsNot Nothing AndAlso Not wc.RunQuery Then
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Sel_Approver_Pending_TasksRecord)), Sel_Approver_Pending_TasksRecord())
                    Me.AddNewRecords()
                    Return
                End If

                Dim orderBy As OrderBy = CreateOrderBy()
                orderBy.Add(Sel_Approver_Pending_TasksView.Doc_Type, OrderByItem.OrderDir.Asc)
                orderBy.Add(Sel_Approver_Pending_TasksView.Date_Assigned, OrderByItem.OrderDir.Desc)
                Me.GetPageSize()

                Me.TotalRecords = Sel_Approver_Pending_TasksView.GetRecordCount(wc)

                If Me.TotalPages <= 0 OrElse Me.PageIndex < 0 Then
                    Me.PageIndex = 0
                ElseIf Me.DisplayLastPage OrElse Me.PageIndex >= Me.TotalPages Then
                    Me.PageIndex = Me.TotalPages - 1
                End If

                If Me.TotalRecords <= 0 Then
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Sel_Approver_Pending_TasksRecord)), Sel_Approver_Pending_TasksRecord())
                ElseIf Me.AddNewRecord > 0 Then
                    Dim postdata As New ArrayList
                    For Each rc As Sel_Approver_Pending_TasksTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Sel_Approver_Pending_TasksRecord)), Sel_Approver_Pending_TasksRecord())
                Else
                    Me.DataSource = Sel_Approver_Pending_TasksView.GetRecords(wc, orderBy, Me.PageIndex, Me.PageSize)
                End If

                Me.AddNewRecords()

                Dim sWhere As String = ""
                Dim bApproverCAR As Boolean = False
                Dim bApproverPR As Boolean = False
                Dim bApproverPO As Boolean = False
                Dim bApproverFS As Boolean = False
                Dim iCAR As Integer = 0
                Dim iPR As Integer = 0
                Dim iPO As Integer = 0
                Dim iFS As Integer = 0

                sWhere = Sel_WASP_WF_ApproverView.W_U_ID.UniqueName & " = " & System.Web.HttpContext.Current.Session("UserId").ToString()
                'sWhere = Sel_WASP_WF_ApproverView.W_U_ID.UniqueName & " = 161"
                iCAR = sel_WASP_WF_ApproverView.GetRecordCount(sWhere)
                If iCAR > 0 Then bApproverCAR = True
                sWhere = Sel_WASP_WF_Approver_PRView.W_U_ID.UniqueName & " = " & System.Web.HttpContext.Current.Session("UserId").ToString()
                'sWhere = Sel_WASP_WF_Approver_PRView.W_U_ID.UniqueName & " = 161"
                iPR = Sel_WASP_WF_Approver_PRView.GetRecordCount(sWhere)
                If iPR > 0 Then bApproverPR = True
                sWhere = Sel_WASP_WF_Approver_POView.W_U_ID.UniqueName & " = " & System.Web.HttpContext.Current.Session("UserId").ToString()
                'sWhere = Sel_WASP_WF_Approver_POView.W_U_ID.UniqueName & " =161 "
                iPO = sel_WASP_WF_Approver_POView.GetRecordCount(sWhere)
                If iPO > 0 Then bApproverPO = True
                sWhere = Sel_WASP_WF_Approver_FSView.W_U_ID.UniqueName & " = " & System.Web.HttpContext.Current.Session("UserId").ToString()
                'sWhere = Sel_WASP_WF_Approver_FSView.W_U_ID.UniqueName & " = 161"
                iFS = Sel_WASP_WF_Approver_FSView.GetRecordCount(sWhere)
                If iFS > 0 Then bApproverFS = True

                Me.Literal2.Text = "You currently have <b>" & Me.TotalRecords.ToString() & "</b> pending task(s)."

                If Not bApproverCAR And Not bApproverPR And Not bApproverPO Then
                    Dim oTasks As Sel_Approver_Pending_TasksTableControl = DirectCast(Me.Page.FindControlRecursively("Sel_Approver_Pending_TasksTableControl"), Sel_Approver_Pending_TasksTableControl)
                    'oTasks.Visible = False
                End If

                Me.Image.Visible = False
                Me.litLoading.Visible = False
                Me.Literal2.Visible = True
                'Dim control As System.Web.UI.HtmlControls.HtmlGenericControl = CType(Page.Master.FindControl("Body1"), HtmlGenericControl)
                'Dim sJS_Hide As String = "document.getElementById('" & Me.Image.ClientID & "').style.display='none';" & _
                '"document.getElementById('" & Me.litLoading.ClientID & "').innerHTML='';"
                'control.Attributes.Add("onFocus", sJS_Hide)
                'control.Attributes.Add("onLoad", sJS_Hide)
            Catch ex As Exception
                Dim msg As String = ex.Message
                If ex.InnerException IsNot Nothing Then
                    msg = msg & " InnerException: " & ex.InnerException.Message
                End If
                Throw New Exception(msg, ex.InnerException)
            End Try
        End Sub





    End Class



    'Public Class Sel_Approver_Pending_Tasks2TableControl
    '        Inherits BaseSel_Approver_Pending_Tasks2TableControl
    '
    '    ' The BaseSel_Approver_Pending_Tasks2TableControl class implements the LoadData, DataBind, CreateWhereClause
    '    ' and other methods to load and display the data in a table control.
    '
    '    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    '    ' The Sel_Approver_Pending_Tasks2TableControlRow class offers another place where you can customize
    '    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
    '
    'End Class
    '
    'Public Class Sel_Approver_Pending_Tasks2TableControlRow
    '        Inherits BaseSel_Approver_Pending_Tasks2TableControlRow
    '        ' The BaseSel_Approver_Pending_Tasks2TableControlRow implements code for a ROW within the
    '        ' the Sel_Approver_Pending_Tasks2TableControl table.  The BaseSel_Approver_Pending_Tasks2TableControlRow implements the DataBind and SaveData methods.
    '        ' The loading of data is actually performed by the LoadData method in the base class of Sel_Approver_Pending_Tasks2TableControl.
    '
    '        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
    '        ' SaveData, GetUIData, and Validate methods.
    '        
    '
    'End Class
    '
    Public Class Sel_Approver_Pending_Tasks2TableControl
        Inherits BaseSel_Approver_Pending_Tasks2TableControl

        ' The BaseSel_Approver_Pending_Tasks2TableControl class implements the LoadData, DataBind, CreateWhereClause
        ' and other methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        ' The Sel_Approver_Pending_Tasks2TableControlRow class offers another place where you can customize
        ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.




        Public Overrides Function CreateWhereClause() As WhereClause
            Sel_Approver_Pending_Tasks2View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()

            wc.iAND(Sel_Approver_Pending_Tasks2View.W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIdNorth").ToString())
            wc.iAND(Sel_Approver_Pending_Tasks2View.Doc_Type, BaseFilter.ComparisonOperator.Not_Equals, "PR")
            'wc.iAND(Sel_Approver_Pending_TasksView.W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, "161")
            Return wc
        End Function

        Public Overrides Sub LoadData()
            Try
                Dim wc As WhereClause = CreateWhereClause()
                If wc IsNot Nothing AndAlso Not wc.RunQuery Then
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Sel_Approver_Pending_Tasks2Record)), Sel_Approver_Pending_Tasks2Record())
                    Me.AddNewRecords()
                    Return
                End If

                Dim orderBy As OrderBy = CreateOrderBy()
                orderBy.Add(Sel_Approver_Pending_Tasks2View.Doc_Type, OrderByItem.OrderDir.Asc)
                orderBy.Add(Sel_Approver_Pending_Tasks2View.Date_Assigned, OrderByItem.OrderDir.Desc)
                Me.GetPageSize()

                Me.TotalRecords = Sel_Approver_Pending_Tasks2View.GetRecordCount(wc)

                If Me.TotalPages <= 0 OrElse Me.PageIndex < 0 Then
                    Me.PageIndex = 0
                ElseIf Me.DisplayLastPage OrElse Me.PageIndex >= Me.TotalPages Then
                    Me.PageIndex = Me.TotalPages - 1
                End If

                If Me.TotalRecords <= 0 Then
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Sel_Approver_Pending_Tasks2Record)), Sel_Approver_Pending_Tasks2Record())
                ElseIf Me.AddNewRecord > 0 Then
                    Dim postdata As New ArrayList
                    For Each rc As Sel_Approver_Pending_Tasks2TableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Sel_Approver_Pending_Tasks2Record)), Sel_Approver_Pending_Tasks2Record())
                Else
                    Me.DataSource = Sel_Approver_Pending_Tasks2View.GetRecords(wc, orderBy, Me.PageIndex, Me.PageSize)
                End If

                Me.AddNewRecords()

                Dim sWhere As String = ""
                Dim bApproverCAR As Boolean = False
                Dim bApproverPR As Boolean = False
                Dim bApproverPO As Boolean = False
                Dim bApproverFS As Boolean = False
                Dim iCAR As Integer = 0
                Dim iPR As Integer = 0
                Dim iPO As Integer = 0
                Dim iFS As Integer = 0

                sWhere = Sel_WASP_WF_Approver2View.W_U_ID.UniqueName & " = " & System.Web.HttpContext.Current.Session("UserIdNorth").ToString()
                'sWhere = Sel_WASP_WF_ApproverView.W_U_ID.UniqueName & " = 161"
                iCAR = Sel_WASP_WF_Approver2View.GetRecordCount(sWhere)
                If iCAR > 0 Then bApproverCAR = True
                sWhere = Sel_WASP_WF_Approver_PR2View.W_U_ID.UniqueName & " = " & System.Web.HttpContext.Current.Session("UserIdNorth").ToString()
                'sWhere = Sel_WASP_WF_Approver_PRView.W_U_ID.UniqueName & " = 161"
                iPR = Sel_WASP_WF_Approver_PR2View.GetRecordCount(sWhere)
                If iPR > 0 Then bApproverPR = True
                sWhere = Sel_WASP_WF_Approver_PO2View.W_U_ID.UniqueName & " = " & System.Web.HttpContext.Current.Session("UserIdNorth").ToString()
                'sWhere = Sel_WASP_WF_Approver_POView.W_U_ID.UniqueName & " =161 "
                iPO = Sel_WASP_WF_Approver_PO2View.GetRecordCount(sWhere)
                If iPO > 0 Then bApproverPO = True
                sWhere = Sel_WASP_WF_Approver_FS1View.W_U_ID.UniqueName & " = " & System.Web.HttpContext.Current.Session("UserIdNorth").ToString()
                'sWhere = Sel_WASP_WF_Approver_FSView.W_U_ID.UniqueName & " = 161"
                iFS = Sel_WASP_WF_Approver_FS1View.GetRecordCount(sWhere)
                If iFS > 0 Then bApproverFS = True

                Me.Literal1.Text = "You currently have <b>" & Me.TotalRecords.ToString() & "</b> pending task(s)."

                If Not bApproverCAR And Not bApproverPR And Not bApproverPO Then
                    Dim oTasks As Sel_Approver_Pending_Tasks2TableControl = DirectCast(Me.Page.FindControlRecursively("Sel_Approver_Pending_Tasks2TableControl"), Sel_Approver_Pending_Tasks2TableControl)
                    'oTasks.Visible = False
                End If

                Me.Image1.Visible = True
                Me.litLoading1.Visible = False
                Me.Literal1.Visible = True
                'Dim control As System.Web.UI.HtmlControls.HtmlGenericControl = CType(Page.Master.FindControl("Body1"), HtmlGenericControl)
                'Dim sJS_Hide As String = "document.getElementById('" & Me.Image.ClientID & "').style.display='none';" & _
                '"document.getElementById('" & Me.litLoading.ClientID & "').innerHTML='';"
                'control.Attributes.Add("onFocus", sJS_Hide)
                'control.Attributes.Add("onLoad", sJS_Hide)
            Catch ex As Exception
                Dim msg As String = ex.Message
                If ex.InnerException IsNot Nothing Then
                    msg = msg & " InnerException: " & ex.InnerException.Message
                End If
                Throw New Exception(msg, ex.InnerException)
            End Try
        End Sub


    End Class
    Public Class Sel_Approver_Pending_Tasks2TableControlRow
        Inherits BaseSel_Approver_Pending_Tasks2TableControlRow
        ' The BaseSel_Approver_Pending_Tasks2TableControlRow implements code for a ROW within the
        ' the Sel_Approver_Pending_Tasks2TableControl table.  The BaseSel_Approver_Pending_Tasks2TableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of Sel_Approver_Pending_Tasks2TableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.


        Public Overrides Sub SetDoc_Type1()

            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Doc_TypeSpecified Then
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_Tasks2View.Doc_Type)

                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Doc_Type1.Text = formattedValue
            Else
                Me.Doc_Type1.Text = Sel_Approver_Pending_Tasks2View.Doc_Type.Format(Sel_Approver_Pending_Tasks2View.Doc_Type.DefaultValue)
            End If

            If Me.Doc_Type1.Text Is Nothing OrElse Me.Doc_Type1.Text.Trim() = "" Then
                Me.Doc_Type1.Text = "&nbsp;"
            Else
                Select Case Me.Doc_Type1.Text
                    Case "PO CANCEL"
                        Me.Doc_Type1.Text = "<font color=red>" & Me.Doc_Type1.Text & "</font>"
                    Case Else
                        Me.Doc_Type1.Text = Me.Doc_Type1.Text
                        'Me.Doc_Type1.Text = "<font color=black>" & Me.Doc_Type1.Text & "</font>"
                End Select
            End If
        End Sub


        Public Overrides Sub DataBind()
            MyBase.DataBind()

            If Me.DataSource Is Nothing Then
                Return
            End If

            SetCompany_Desc1()
            SetDate_Assigned1()
            SetDoc_No1()
            SetDoc_Type1()
            SetPK_ID1()

            Select Case Me.DataSource.Doc_Type.ToString()
                Case "CAR"
                    Me.imbList1.Attributes.Add("onclick", "setTimeout(""" & "window.location='../wf_car/ShowSel_WCAR_Activity_WCAR_DocTable.aspx';"",1800); return false;")
                Case "PR"
                    Me.imbList1.Attributes.Add("onclick", "setTimeout(""" & "window.location='../wf_pr/ShowSel_WPR_Activity_WPR_DocTable.aspx';"",1800); return false;")
                Case "PO"
                    Me.imbList1.Attributes.Add("onclick", "setTimeout(""" & "window.location='../wf_PO/ShowSel_WPO_Activity_WPOP10100Table.aspx';"",1800); return false;")
                Case "FS"
                    Me.imbList1.Attributes.Add("onclick", "setTimeout(""" & "window.location='../WFinRep_Head/WFin_ApproverTable.aspx';"",1800); return false;")
                Case "FSN"
                    Me.imbList1.Attributes.Add("onclick", "setTimeout(""" & "window.location='../WFinRep_Head/WFinRepNGP_ApproverTable.aspx';"",1800); return false;")
                Case "CONSOLIDATED"
                    Me.imbList1.Attributes.Add("onclick", "setTimeout(""" & "window.location='../WFinRep_Head/Conso_ReportDoc_ApproverTable.aspx';"",1800); return false;")
                Case "PO CANCEL"
                    Me.imbList1.Attributes.Add("onclick", "setTimeout(""" & "window.location='../wf_cv/ShowSel_WCanvass_PO_Map_AdjustmentTable.aspx';"",1800); return false;")
                Case "_CAR(RETURN)", "_PO(RETURN)"
                    Me.imbList1.Visible = False
                Case Else
                    Me.imbList1.Attributes.Add("onclick", "setTimeout(""" & "window.location='../sel_WCAR_Doc_Creator_Approver/Show-Sel-WCAR-Doc-Creator-Approver-Table.aspx';"",1800); return false;")
            End Select


            Me.IsNewRecord = True

            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
            End If

            Dim shouldResetControl As Boolean = False
        End Sub


        Public Overrides Sub imbList1_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
            Try
                Dim oHead As Sel_Approver_Pending_Tasks2TableControl = DirectCast(Me.Page.FindControlRecursively("Sel_Approver_Pending_Tasks2TableControl"), Sel_Approver_Pending_Tasks2TableControl)
                oHead.Image1.Visible = True
                oHead.litLoading1.Visible = True
                oHead.Literal1.Visible = False
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally

            End Try
        End Sub



        Public Overrides Sub imbDoc1_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim pubUrl As String

            ' ''MsgBox(Me.Doc_Type1.Text)

            Select Case Me.Doc_Type1.Text
                Case "<font color=black>CAR</font>", "CAR"
                    pubUrl = "../WCAR_Doc1/EditWCAR-Doc-Approval1.aspx?WCAR_Doc1=" & Me.PK_ID1.Text
                Case "<font color=black>PR</font>", "PR"
                    pubUrl = "../wf_pr/EditWPR_Doc_Approval.aspx?WPR_Doc=" & Me.PK_ID1.Text
                Case "<font color=black>PO</font>", "PO"
                    pubUrl = "../sel_WPO_WFTask/WPO-WFTaskN.aspx?POP10100_PO=" & Me.Doc_No1.Text & "&POP10100_Co=" & Me.C_ID1.Text
                Case "<font color=black>FS</font>", "FS"
                    pubUrl = "../WFinRep_Head/WFin-ApproverPage.aspx?WFinRep_Head=" & Me.Doc_No1.Text
                Case "<font color=black>FSN</font>", "FSN"
                    pubUrl = "../WFinRep_Head/WFinRepNGP_Approver.aspx?WFinRepNGP_Head=" & Me.Doc_No1.Text
                Case "<font color=black>CONSOLIDATED</font>", "CONSOLIDATED"
                    pubUrl = "../WFinRep_Head/Conso_ReportDoc_Approver.aspx?WFinRepCon_Head=" & Me.Doc_No1.Text
                Case "<font color=black>PO CANCEL</font>", "PO CANCEL"
                    pubUrl = "../wf_cv/EditWCanvass_PO_Map.aspx?WCanvass_PO_Map=" & Me.PK_ID1.Text
                Case "<font color=black>_CAR(RETURN)</font>", "<font color=black>_PO(RETURN)</font>", "_PO(RETURN)", "_CAR(RETURN)"
                    Me.imbDoc1.Visible = False
                Case Else
                    pubUrl = "../WCAR_Doc1/Edit-WCAR-Doc1.aspx?WCAR_Doc1=" & Me.PK_ID1.Text
            End Select
            Dim url As String = pubUrl

            If Me.Page.Request("RedirectStyle") <> "" Then url &= "&RedirectStyle=" & Me.Page.Request("RedirectStyle")

            Dim shouldRedirect As Boolean = True
            Dim target As String = ""

            Try

                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()

                url = Me.ModifyRedirectUrl(url, "", True)
                url = Me.Page.ModifyRedirectUrl(url, "", True)

            Catch ex As Exception

                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally
                DbUtils.EndTransaction()
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)

            End If
        End Sub




    End Class
#End Region

  

#Region "Section 2: Do not modify this section."


    ' Base class for the Sel_Approver_Pending_Tasks2TableControlRow control on the Homepage page.
    ' Do not modify this class. Instead override any method in Sel_Approver_Pending_Tasks2TableControlRow.
    Public Class BaseSel_Approver_Pending_Tasks2TableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in Sel_Approver_Pending_Tasks2TableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init


        End Sub

        '  To customize, override this method in Sel_Approver_Pending_Tasks2TableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load


            ' Register the event handlers.

            AddHandler Me.imbDoc1.Click, AddressOf imbDoc1_Click

            AddHandler Me.imbList1.Click, AddressOf imbList1_Click


        End Sub


        Public Overridable Sub LoadData()

            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.sel_Approver_Pending_Tasks record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.

            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseSel_Approver_Pending_Tasks2TableControl when the data for the entire
            ' table is loaded.

            Me.DataSource = New Sel_Approver_Pending_Tasks2Record()



        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Sel_Approver_Pending_Tasks2TableControlRow.
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



            ' Call the Set methods for each controls on the panel

            SetC_ID1()
            SetCompany_Desc1()
            SetDate_Assigned1()
            SetDoc_No1()
            SetDoc_Title1()
            SetDoc_Total1()
            SetDoc_Type1()


            SetPK_ID1()
            SetimbDoc1()

            SetimbList1()



            Me.IsNewRecord = True

            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False

            End If

            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False

        End Sub


        Public Overridable Sub SetC_ID1()




            ' Set the C_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.C_ID1 is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetC_ID1()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.C_IDSpecified Then

                ' If the C_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_Tasks2View.C_ID)

                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.C_ID1.Text = formattedValue

            Else

                ' C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.C_ID1.Text = Sel_Approver_Pending_Tasks2View.C_ID.Format(Sel_Approver_Pending_Tasks2View.C_ID.DefaultValue)

            End If

            ' If the C_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.C_ID1.Text Is Nothing _
                OrElse Me.C_ID1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.C_ID1.Text = "&nbsp;"
            End If

        End Sub

        Public Overridable Sub SetCompany_Desc1()




            ' Set the Company_Desc Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.Company_Desc1 is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCompany_Desc1()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Company_DescSpecified Then

                ' If the Company_Desc is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_Tasks2View.Company_Desc)

                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Company_Desc1.Text = formattedValue

            Else

                ' Company_Desc is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.Company_Desc1.Text = Sel_Approver_Pending_Tasks2View.Company_Desc.Format(Sel_Approver_Pending_Tasks2View.Company_Desc.DefaultValue)

            End If

            ' If the Company_Desc is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Company_Desc1.Text Is Nothing _
                OrElse Me.Company_Desc1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Company_Desc1.Text = "&nbsp;"
            End If

        End Sub

        Public Overridable Sub SetDate_Assigned1()




            ' Set the Date_Assigned Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.Date_Assigned1 is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDate_Assigned1()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Date_AssignedSpecified Then

                ' If the Date_Assigned is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_Tasks2View.Date_Assigned, "d")

                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Date_Assigned1.Text = formattedValue

            Else

                ' Date_Assigned is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.Date_Assigned1.Text = Sel_Approver_Pending_Tasks2View.Date_Assigned.Format(Sel_Approver_Pending_Tasks2View.Date_Assigned.DefaultValue, "d")

            End If

            ' If the Date_Assigned is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Date_Assigned1.Text Is Nothing _
                OrElse Me.Date_Assigned1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Date_Assigned1.Text = "&nbsp;"
            End If

        End Sub

        Public Overridable Sub SetDoc_No1()




            ' Set the Doc_No Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.Doc_No1 is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDoc_No1()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Doc_NoSpecified Then

                ' If the Doc_No is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_Tasks2View.Doc_No)

                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Doc_No1.Text = formattedValue

            Else

                ' Doc_No is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.Doc_No1.Text = Sel_Approver_Pending_Tasks2View.Doc_No.Format(Sel_Approver_Pending_Tasks2View.Doc_No.DefaultValue)

            End If

            ' If the Doc_No is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Doc_No1.Text Is Nothing _
                OrElse Me.Doc_No1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Doc_No1.Text = "&nbsp;"
            End If

        End Sub

        Public Overridable Sub SetDoc_Title1()




            ' Set the Doc_Title Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.Doc_Title1 is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDoc_Title1()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Doc_TitleSpecified Then

                ' If the Doc_Title is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_Tasks2View.Doc_Title)

                If Not formattedValue Is Nothing Then

                    Dim maxLength As Integer = Len(formattedValue)
                    If (maxLength >= CType(300, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(300, Integer)
                        'First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue)

                        formattedValue = HttpUtility.HtmlEncode(formattedValue)

                    End If
                    If maxLength = CType(300, Integer) Then
                        formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0, Math.Min(maxLength, Len(formattedValue))))
                        formattedValue = formattedValue & "..."

                    Else

                        formattedValue = "<table border=""0"" cellpadding=""0"" cellspacing=""0""><tr><td>" & formattedValue & "</td></tr></table>"
                    End If
                End If

                Me.Doc_Title1.Text = formattedValue

            Else

                ' Doc_Title is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.Doc_Title1.Text = Sel_Approver_Pending_Tasks2View.Doc_Title.Format(Sel_Approver_Pending_Tasks2View.Doc_Title.DefaultValue)

            End If

            ' If the Doc_Title is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Doc_Title1.Text Is Nothing _
                OrElse Me.Doc_Title1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Doc_Title1.Text = "&nbsp;"
            End If

        End Sub

        Public Overridable Sub SetDoc_Total1()




            ' Set the Doc_Total Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.Doc_Total1 is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDoc_Total1()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Doc_TotalSpecified Then

                ' If the Doc_Total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_Tasks2View.Doc_Total, "N")

                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Doc_Total1.Text = formattedValue

            Else

                ' Doc_Total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.Doc_Total1.Text = Sel_Approver_Pending_Tasks2View.Doc_Total.Format(Sel_Approver_Pending_Tasks2View.Doc_Total.DefaultValue, "N")

            End If

            ' If the Doc_Total is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Doc_Total1.Text Is Nothing _
                OrElse Me.Doc_Total1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Doc_Total1.Text = "&nbsp;"
            End If

        End Sub

        Public Overridable Sub SetDoc_Type1()




            ' Set the Doc_Type Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.Doc_Type1 is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDoc_Type1()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Doc_TypeSpecified Then

                ' If the Doc_Type is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_Tasks2View.Doc_Type)

                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Doc_Type1.Text = formattedValue

            Else

                ' Doc_Type is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.Doc_Type1.Text = Sel_Approver_Pending_Tasks2View.Doc_Type.Format(Sel_Approver_Pending_Tasks2View.Doc_Type.DefaultValue)

            End If

            ' If the Doc_Type is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Doc_Type1.Text Is Nothing _
                OrElse Me.Doc_Type1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Doc_Type1.Text = "&nbsp;"
            End If

        End Sub

        Public Overridable Sub SetPK_ID1()




            ' Set the PK_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.PK_ID1 is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetPK_ID1()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.PK_IDSpecified Then

                ' If the PK_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_Tasks2View.PK_ID)

                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.PK_ID1.Text = formattedValue

            Else

                ' PK_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.PK_ID1.Text = Sel_Approver_Pending_Tasks2View.PK_ID.Format(Sel_Approver_Pending_Tasks2View.PK_ID.DefaultValue)

            End If

            ' If the PK_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.PK_ID1.Text Is Nothing _
                OrElse Me.PK_ID1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.PK_ID1.Text = "&nbsp;"
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

            If includeDS Then

            End If


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

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, Nothing)
        End Function


        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e As FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS As Boolean) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
        End Function


        Public Overridable Sub RegisterPostback()


        End Sub



        ' To customize, override this method in Sel_Approver_Pending_Tasks2TableControlRow.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()


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

                DirectCast(GetParentControlObject(Me, "Sel_Approver_Pending_Tasks2TableControl"), Sel_Approver_Pending_Tasks2TableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "Sel_Approver_Pending_Tasks2TableControl"), Sel_Approver_Pending_Tasks2TableControl).ResetData = True
            End If


            ' update session or cookie by formula


            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True

            ' For Master-Detail relationships, save data on the Detail table(s)

        End Sub

        ' To customize, override this method in Sel_Approver_Pending_Tasks2TableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.

            ' Call the Get methods for each of the user interface controls.

            GetC_ID1()
            GetCompany_Desc1()
            GetDate_Assigned1()
            GetDoc_No1()
            GetDoc_Title1()
            GetDoc_Total1()
            GetDoc_Type1()
            GetPK_ID1()
        End Sub


        Public Overridable Sub GetC_ID1()

        End Sub

        Public Overridable Sub GetCompany_Desc1()

        End Sub

        Public Overridable Sub GetDate_Assigned1()

        End Sub

        Public Overridable Sub GetDoc_No1()

        End Sub

        Public Overridable Sub GetDoc_Title1()

        End Sub

        Public Overridable Sub GetDoc_Total1()

        End Sub

        Public Overridable Sub GetDoc_Type1()

        End Sub

        Public Overridable Sub GetPK_ID1()

        End Sub


        ' To customize, override this method in Sel_Approver_Pending_Tasks2TableControlRow.

        Public Overridable Function CreateWhereClause() As WhereClause

            Dim hasFiltersSel_Approver_Pending_Tasks2TableControl As Boolean = False

            Dim hasFiltersSel_Approver_Pending_TasksTableControl As Boolean = False

            Return Nothing

        End Function



        ' To customize, override this method in Sel_Approver_Pending_Tasks2TableControlRow.
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

        Public Overridable Sub SetimbDoc1()


        End Sub

        Public Overridable Sub SetimbList1()


        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbDoc1_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.


            Dim url As String = "../WCAR_Doc/Edit-WCAR-Doc.aspx?WCAR_Doc={Sel_Approver_Pending_TasksTableControlRow:FV:PK_ID}"

            If Me.Page.Request("RedirectStyle") <> "" Then url &= "&RedirectStyle=" & Me.Page.Request("RedirectStyle")

            Dim shouldRedirect As Boolean = True
            Dim target As String = ""

            Try

                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()

                url = Me.ModifyRedirectUrl(url, "", True)
                url = Me.Page.ModifyRedirectUrl(url, "", True)

            Catch ex As Exception

                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally
                DbUtils.EndTransaction()
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)

            End If
        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbList1_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

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


        Public Property DataSource() As Sel_Approver_Pending_Tasks2Record
            Get
                Return DirectCast(MyBase._DataSource, Sel_Approver_Pending_Tasks2Record)
            End Get
            Set(ByVal value As Sel_Approver_Pending_Tasks2Record)
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

        Public ReadOnly Property C_ID1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "C_ID1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Company_Desc1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Company_Desc1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Date_Assigned1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Date_Assigned1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Doc_No1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_No1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Doc_Title1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_Title1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Doc_Total1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_Total1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Doc_Type1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_Type1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property imbDoc1() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbDoc1"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbList1() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbList1"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property PK_ID1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PK_ID1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

#End Region

#Region "Helper Functions"

        Public Overloads Overrides Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overloads Overrides Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overloads Overrides Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String

            Dim rec As Sel_Approver_Pending_Tasks2Record = Nothing


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

        Public Overloads Overrides Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String

            Dim rec As Sel_Approver_Pending_Tasks2Record = Nothing


            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.

                Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ePortalWFApproval"))

            End If
            If includeSession Then
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            Else
                Return EvaluateExpressions(url, arg, rec, bEncrypt, False)
            End If
        End Function


        Public Overridable Function GetRecord() As Sel_Approver_Pending_Tasks2Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
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



    ' Base class for the Sel_Approver_Pending_Tasks2TableControl control on the Homepage page.
    ' Do not modify this class. Instead override any method in Sel_Approver_Pending_Tasks2TableControl.
    Public Class BaseSel_Approver_Pending_Tasks2TableControl
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

            AddHandler Me.WCAR_DocPagination.FirstPage.Click, AddressOf WCAR_DocPagination_FirstPage_Click

            AddHandler Me.WCAR_DocPagination.LastPage.Click, AddressOf WCAR_DocPagination_LastPage_Click

            AddHandler Me.WCAR_DocPagination.NextPage.Click, AddressOf WCAR_DocPagination_NextPage_Click

            AddHandler Me.WCAR_DocPagination.PageSizeButton.Click, AddressOf WCAR_DocPagination_PageSizeButton_Click

            AddHandler Me.WCAR_DocPagination.PreviousPage.Click, AddressOf WCAR_DocPagination_PreviousPage_Click

            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.

            ' Setup the button events.

            AddHandler Me.Sel_Approver_Pending_TasksRefreshButton1.Click, AddressOf Sel_Approver_Pending_TasksRefreshButton1_Click

            AddHandler Me.NorthRedirectorButtonCARDoc.Button.Click, AddressOf NorthRedirectorButtonCARDoc_Click

            AddHandler Me.NorthRedirectorButtonReCAR.Button.Click, AddressOf NorthRedirectorButtonReCAR_Click

            AddHandler Me.NorthRedirectorButtonRePO.Button.Click, AddressOf NorthRedirectorButtonRePO_Click

            AddHandler Me.SouthRedirectorButtonPODoc1.Button.Click, AddressOf SouthRedirectorButtonPODoc1_Click


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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Sel_Approver_Pending_Tasks2Record)), Sel_Approver_Pending_Tasks2Record())
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
                    For Each rc As Sel_Approver_Pending_Tasks2TableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Sel_Approver_Pending_Tasks2Record)), Sel_Approver_Pending_Tasks2Record())
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
            ByVal pageSize As Integer) As Sel_Approver_Pending_Tasks2Record()

            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList



            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Sel_Approver_Pending_Tasks2View.Column1, True)         
            ' selCols.Add(Sel_Approver_Pending_Tasks2View.Column2, True)          
            ' selCols.Add(Sel_Approver_Pending_Tasks2View.Column3, True)    



            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *

            If selCols.Count = 0 Then

                Return Sel_Approver_Pending_Tasks2View.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)

            Else
                Dim databaseTable As New Sel_Approver_Pending_Tasks2View
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)

                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True



                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(Sel_Approver_Pending_Tasks2Record)), Sel_Approver_Pending_Tasks2Record())
            End If

        End Function


        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList


            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Sel_Approver_Pending_Tasks2View.Column1, True)         
            ' selCols.Add(Sel_Approver_Pending_Tasks2View.Column2, True)          
            ' selCols.Add(Sel_Approver_Pending_Tasks2View.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *

            If selCols.Count = 0 Then

                Return Sel_Approver_Pending_Tasks2View.GetRecordCount(join, where)

            Else
                Dim databaseTable As New Sel_Approver_Pending_Tasks2View
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

            Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_Approver_Pending_Tasks2TableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return
            rep.DataSource = DataSource()
            rep.DataBind()

            Dim index As Integer = 0

            For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items

                ' Loop through all rows in the table, set its DataSource and call DataBind().
                Dim recControl As Sel_Approver_Pending_Tasks2TableControlRow = DirectCast(repItem.FindControl("Sel_Approver_Pending_Tasks2TableControlRow"), Sel_Approver_Pending_Tasks2TableControlRow)
                recControl.DataSource = Me.DataSource(index)
                If Me.UIData.Count > index Then
                    recControl.PreviousUIData = Me.UIData(index)
                End If
                recControl.DataBind()

                index += 1
            Next

            ' Call the Set methods for each controls on the panel

            SetCompany_DescLabel2()
            SetDate_AssignedLabel2()
            SetDoc_NoLabel2()
            SetDoc_TitleLabel2()
            SetDoc_TotalLabel2()
            SetDoc_TypeLabel2()


            SetLiteral()
            SetLiteral1()
            SetLiteral5()
            SetlitLoading1()







            SetSel_Approver_Pending_TasksRefreshButton1()

            SetNorthRedirectorButtonCARDoc()

            SetNorthRedirectorButtonReCAR()

            SetNorthRedirectorButtonRePO()

            SetSouthRedirectorButtonPODoc1()

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

            If includeDS Then

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

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, Nothing)
        End Function


        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e As FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS As Boolean) As String
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

                Me.WCAR_DocPagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.WCAR_DocPagination.CurrentPage.Text = "0"
            End If
            Me.WCAR_DocPagination.PageSize.Text = Me.PageSize.ToString()
            Me.WCAR_DocPagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.WCAR_DocPagination.TotalPages.Text = Me.TotalPages.ToString()

            ' Bind the buttons for Sel_Approver_Pending_Tasks2TableControl pagination.

            Me.WCAR_DocPagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.WCAR_DocPagination.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0 Then          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.WCAR_DocPagination.LastPage.Enabled = False
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.WCAR_DocPagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If

            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.WCAR_DocPagination.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0 Then          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.WCAR_DocPagination.NextPage.Enabled = False
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.WCAR_DocPagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If

            Me.WCAR_DocPagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)


        End Sub



        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.

            Dim recCtl As Sel_Approver_Pending_Tasks2TableControlRow
            For Each recCtl In Me.GetRecordControls()

                If recCtl.Visible Then
                    recCtl.SaveData()
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
            Sel_Approver_Pending_Tasks2View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()

            Dim hasFiltersSel_Approver_Pending_Tasks2TableControl As Boolean = False

            Dim hasFiltersSel_Approver_Pending_TasksTableControl As Boolean = False

            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.



            Return wc
        End Function


        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Sel_Approver_Pending_Tasks2View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()

            Dim hasFiltersSel_Approver_Pending_Tasks2TableControl As Boolean = False

            Dim hasFiltersSel_Approver_Pending_TasksTableControl As Boolean = False

            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)

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

            If Me.WCAR_DocPagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.WCAR_DocPagination.PageSize.Text)
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
                Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_Approver_Pending_Tasks2TableControlRepeater"), System.Web.UI.WebControls.Repeater)
                If rep Is Nothing Then Return


                Dim repItem As System.Web.UI.WebControls.RepeaterItem
                For Each repItem In rep.Items

                    ' Loop through all rows in the table, set its DataSource and call DataBind().

                    Dim recControl As Sel_Approver_Pending_Tasks2TableControlRow = DirectCast(repItem.FindControl("Sel_Approver_Pending_Tasks2TableControlRow"), Sel_Approver_Pending_Tasks2TableControlRow)


                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As Sel_Approver_Pending_Tasks2Record = New Sel_Approver_Pending_Tasks2Record()

                        If recControl.C_ID1.Text <> "" Then
                            rec.Parse(recControl.C_ID1.Text, Sel_Approver_Pending_Tasks2View.C_ID)
                        End If
                        If recControl.Company_Desc1.Text <> "" Then
                            rec.Parse(recControl.Company_Desc1.Text, Sel_Approver_Pending_Tasks2View.Company_Desc)
                        End If
                        If recControl.Date_Assigned1.Text <> "" Then
                            rec.Parse(recControl.Date_Assigned1.Text, Sel_Approver_Pending_Tasks2View.Date_Assigned)
                        End If
                        If recControl.Doc_No1.Text <> "" Then
                            rec.Parse(recControl.Doc_No1.Text, Sel_Approver_Pending_Tasks2View.Doc_No)
                        End If
                        If recControl.Doc_Title1.Text <> "" Then
                            rec.Parse(recControl.Doc_Title1.Text, Sel_Approver_Pending_Tasks2View.Doc_Title)
                        End If
                        If recControl.Doc_Total1.Text <> "" Then
                            rec.Parse(recControl.Doc_Total1.Text, Sel_Approver_Pending_Tasks2View.Doc_Total)
                        End If
                        If recControl.Doc_Type1.Text <> "" Then
                            rec.Parse(recControl.Doc_Type1.Text, Sel_Approver_Pending_Tasks2View.Doc_Type)
                        End If
                        If recControl.PK_ID1.Text <> "" Then
                            rec.Parse(recControl.PK_ID1.Text, Sel_Approver_Pending_Tasks2View.PK_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())
                        newRecordList.Add(rec)
                    End If
                Next
            End If


            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord

                newRecordList.Insert(0, New Sel_Approver_Pending_Tasks2Record())
                newUIDataList.Insert(0, New Hashtable())

            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then

                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(Sel_Approver_Pending_Tasks2Record)), Sel_Approver_Pending_Tasks2Record())

            End If

            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If

        End Sub



        ' Create Set, WhereClause, and Populate Methods

        Public Overridable Sub SetCompany_DescLabel2()



        End Sub

        Public Overridable Sub SetDate_AssignedLabel2()



        End Sub

        Public Overridable Sub SetDoc_NoLabel2()



        End Sub

        Public Overridable Sub SetDoc_TitleLabel2()



        End Sub

        Public Overridable Sub SetDoc_TotalLabel2()



        End Sub

        Public Overridable Sub SetDoc_TypeLabel2()



        End Sub

        Public Overridable Sub SetLiteral()



        End Sub

        Public Overridable Sub SetLiteral1()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.Literal1.Text = "Some value"

        End Sub

        Public Overridable Sub SetLiteral5()



        End Sub

        Public Overridable Sub SetlitLoading1()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litLoading1.Text = "Some value"

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

        End Sub

        Protected Sub SaveControlsToSession_Ajax()
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

        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("Sel_Approver_Pending_Tasks2TableControl_OrderBy"), String)

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

        End Sub

        Protected Overrides Function SaveViewState() As Object

            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("Sel_Approver_Pending_Tasks2TableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If

            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize


            ' Load view state for pagination control.


            Return MyBase.SaveViewState()
        End Function

        ' Generate set method for buttons

        Public Overridable Sub SetSel_Approver_Pending_TasksRefreshButton1()


        End Sub

        Public Overridable Sub SetNorthRedirectorButtonCARDoc()


        End Sub

        Public Overridable Sub SetNorthRedirectorButtonReCAR()


        End Sub

        Public Overridable Sub SetNorthRedirectorButtonRePO()


        End Sub

        Public Overridable Sub SetSouthRedirectorButtonPODoc1()


        End Sub


        ' Generate the event handling functions for pagination events.

        ' event handler for ImageButton
        Public Overridable Sub WCAR_DocPagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

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
        Public Overridable Sub WCAR_DocPagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

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
        Public Overridable Sub WCAR_DocPagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

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
        Public Overridable Sub WCAR_DocPagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)

            Try

                Me.DataChanged = True

                Me.PageSize = Me.WCAR_DocPagination.GetCurrentPageSize()

                Me.PageIndex = Integer.Parse(Me.WCAR_DocPagination.CurrentPage.Text) - 1

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub WCAR_DocPagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

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

        ' event handler for ImageButton
        Public Overridable Sub Sel_Approver_Pending_TasksRefreshButton1_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

                Dim Sel_Approver_Pending_Tasks2TableControlObj As Sel_Approver_Pending_Tasks2TableControl = DirectCast(Me.Page.FindControlRecursively("Sel_Approver_Pending_Tasks2TableControl"), Sel_Approver_Pending_Tasks2TableControl)
                Sel_Approver_Pending_Tasks2TableControlObj.ResetData = True


                Dim Sel_Approver_Pending_TasksTableControlObj As Sel_Approver_Pending_TasksTableControl = DirectCast(Me.Page.FindControlRecursively("Sel_Approver_Pending_TasksTableControl"), Sel_Approver_Pending_TasksTableControl)
                Sel_Approver_Pending_TasksTableControlObj.ResetData = True


            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for Button
        Public Overridable Sub NorthRedirectorButtonCARDoc_Click(ByVal sender As Object, ByVal args As EventArgs)

            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.


            Dim url As String = "../sel_WCAR_Doc_Creator_Approver1/Show-Sel-WCAR-Doc-Creator-Approver-Table1.aspx"

            If Me.Page.Request("RedirectStyle") <> "" Then url &= "?RedirectStyle=" & Me.Page.Request("RedirectStyle")

            Dim shouldRedirect As Boolean = True
            Dim target As String = ""

            Try

                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()

                url = Me.ModifyRedirectUrl(url, "", True)
                url = Me.Page.ModifyRedirectUrl(url, "", True)

            Catch ex As Exception

                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally
                DbUtils.EndTransaction()
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)

            End If
        End Sub

        ' event handler for Button
        Public Overridable Sub NorthRedirectorButtonReCAR_Click(ByVal sender As Object, ByVal args As EventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for Button
        Public Overridable Sub NorthRedirectorButtonRePO_Click(ByVal sender As Object, ByVal args As EventArgs)

            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.


            Dim url As String = "../selWFReassign1/Show-SelWFReassign-Table1.aspx"

            If Me.Page.Request("RedirectStyle") <> "" Then url &= "?RedirectStyle=" & Me.Page.Request("RedirectStyle")

            Dim shouldRedirect As Boolean = True
            Dim target As String = ""

            Try

                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()

                url = Me.ModifyRedirectUrl(url, "", True)
                url = Me.Page.ModifyRedirectUrl(url, "", True)

            Catch ex As Exception

                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally
                DbUtils.EndTransaction()
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)

            End If
        End Sub

        ' event handler for Button
        Public Overridable Sub SouthRedirectorButtonPODoc1_Click(ByVal sender As Object, ByVal args As EventArgs)

            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.


            Dim url As String = "../sel_WPO_Activity_WPOP101001/Show-Sel-WPO-Activity-WPOP10100-Table1.aspx"

            If Me.Page.Request("RedirectStyle") <> "" Then url &= "?RedirectStyle=" & Me.Page.Request("RedirectStyle")

            Dim shouldRedirect As Boolean = True
            Dim target As String = ""

            Try

                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()

                url = Me.ModifyRedirectUrl(url, "", True)
                url = Me.Page.ModifyRedirectUrl(url, "", True)

            Catch ex As Exception

                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally
                DbUtils.EndTransaction()
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)

            End If
        End Sub



        ' Generate the event handling functions for filter and search events.


        ' Generate the event handling functions for others




        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 Then
                    _TotalRecords = Sel_Approver_Pending_Tasks2View.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
            Set(ByVal value As OrderBy)
                Me._CurrentSortOrder = value
            End Set
        End Property

        Public Property DataSource() As Sel_Approver_Pending_Tasks2Record()
            Get
                Return DirectCast(MyBase._DataSource, Sel_Approver_Pending_Tasks2Record())
            End Get
            Set(ByVal value As Sel_Approver_Pending_Tasks2Record())
                Me._DataSource = value
            End Set
        End Property

#Region "Helper Properties"

        Public ReadOnly Property Company_DescLabel2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Company_DescLabel2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Date_AssignedLabel2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Date_AssignedLabel2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Doc_NoLabel2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_NoLabel2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Doc_TitleLabel2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_TitleLabel2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Doc_TotalLabel2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_TotalLabel2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Doc_TypeLabel2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_TypeLabel2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Image1() As System.Web.UI.WebControls.Image
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Image1"), System.Web.UI.WebControls.Image)
            End Get
        End Property

        Public ReadOnly Property Image3() As System.Web.UI.WebControls.Image
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Image3"), System.Web.UI.WebControls.Image)
            End Get
        End Property

        Public ReadOnly Property Literal() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Literal1() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal1"), System.Web.UI.WebControls.Label)
            End Get
        End Property

        Public ReadOnly Property Literal5() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal5"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litLoading1() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litLoading1"), System.Web.UI.WebControls.Label)
            End Get
        End Property

        Public ReadOnly Property NorthRedirectorButtonCARDoc() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NorthRedirectorButtonCARDoc"), ePortalWFApproval.UI.IThemeButton)
            End Get
        End Property

        Public ReadOnly Property NorthRedirectorButtonReCAR() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NorthRedirectorButtonReCAR"), ePortalWFApproval.UI.IThemeButton)
            End Get
        End Property

        Public ReadOnly Property NorthRedirectorButtonRePO() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NorthRedirectorButtonRePO"), ePortalWFApproval.UI.IThemeButton)
            End Get
        End Property

        Public ReadOnly Property Sel_Approver_Pending_TasksRefreshButton1() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_Approver_Pending_TasksRefreshButton1"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property Sel_Approver_Pending_TasksTitle1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_Approver_Pending_TasksTitle1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property SouthRedirectorButtonPODoc1() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SouthRedirectorButtonPODoc1"), ePortalWFApproval.UI.IThemeButton)
            End Get
        End Property

        Public ReadOnly Property WCAR_DocPagination() As ePortalWFApproval.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_DocPagination"), ePortalWFApproval.UI.IPagination)
            End Get
        End Property

#End Region

#Region "Helper Functions"

        Public Overloads Overrides Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, Nothing, bEncrypt)
        End Function

        Public Overloads Overrides Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return EvaluateExpressions(url, arg, Nothing, bEncrypt, includeSession)
        End Function

        Public Overloads Overrides Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, Nothing, bEncrypt)
        End Function

        Public Overloads Overrides Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return EvaluateExpressions(url, arg, Nothing, bEncrypt, includeSession)
        End Function

        Public Overridable Function GetSelectedRecordControl() As Sel_Approver_Pending_Tasks2TableControlRow
            Return Nothing

        End Function

        Public Overridable Function GetSelectedRecordControls() As Sel_Approver_Pending_Tasks2TableControlRow()

            Return DirectCast((New ArrayList()).ToArray(GetType(Sel_Approver_Pending_Tasks2TableControlRow)), Sel_Approver_Pending_Tasks2TableControlRow())

        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As Sel_Approver_Pending_Tasks2TableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If

            Dim recCtl As Sel_Approver_Pending_Tasks2TableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then

                        ' Localization.
                        Throw New Exception(Page.GetResourceValue("Err:CannotDelRecs", "ePortalWFApproval"))

                    End If
                    recCtl.Visible = False

                Else

                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:CannotDelRecs", "ePortalWFApproval"))

                End If
            Next
        End Sub

        Public Overridable Function GetRecordControls() As Sel_Approver_Pending_Tasks2TableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "Sel_Approver_Pending_Tasks2TableControlRow")
            Dim list As New List(Of Sel_Approver_Pending_Tasks2TableControlRow)
            For Each recCtrl As Sel_Approver_Pending_Tasks2TableControlRow In recCtrls
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


    ' Base class for the Sel_Approver_Pending_TasksTableControlRow control on the Homepage page.
    ' Do not modify this class. Instead override any method in Sel_Approver_Pending_TasksTableControlRow.
    Public Class BaseSel_Approver_Pending_TasksTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in Sel_Approver_Pending_TasksTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init


        End Sub

        '  To customize, override this method in Sel_Approver_Pending_TasksTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load


            ' Register the event handlers.

            AddHandler Me.imbDoc.Click, AddressOf imbDoc_Click

            AddHandler Me.imbList.Click, AddressOf imbList_Click


        End Sub


        Public Overridable Sub LoadData()

            ' Load the data from the database into the DataSource DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.

            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseSel_Approver_Pending_TasksTableControl when the data for the entire
            ' table is loaded.

            Me.DataSource = New Sel_Approver_Pending_TasksRecord()



        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Sel_Approver_Pending_TasksTableControlRow.
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



            ' Call the Set methods for each controls on the panel

            SetC_ID()
            SetCompany_Desc()
            SetDate_Assigned()
            SetDoc_No()
            SetDoc_Title()
            SetDoc_Total()
            SetDoc_Type()


            SetPK_ID()
            SetimbDoc()

            SetimbList()



            Me.IsNewRecord = True

            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False

            End If

            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False

        End Sub


        Public Overridable Sub SetC_ID()




            ' Set the C_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.C_ID is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetC_ID()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.C_IDSpecified Then

                ' If the C_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.C_ID)

                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.C_ID.Text = formattedValue

            Else

                ' C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.C_ID.Text = Sel_Approver_Pending_TasksView.C_ID.Format(Sel_Approver_Pending_TasksView.C_ID.DefaultValue)

            End If

            ' If the C_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.C_ID.Text Is Nothing _
                OrElse Me.C_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.C_ID.Text = "&nbsp;"
            End If

        End Sub

        Public Overridable Sub SetCompany_Desc()




            ' Set the Company_Desc Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.Company_Desc is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCompany_Desc()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Company_DescSpecified Then

                ' If the Company_Desc is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.Company_Desc)

                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Company_Desc.Text = formattedValue

            Else

                ' Company_Desc is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.Company_Desc.Text = Sel_Approver_Pending_TasksView.Company_Desc.Format(Sel_Approver_Pending_TasksView.Company_Desc.DefaultValue)

            End If

            ' If the Company_Desc is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Company_Desc.Text Is Nothing _
                OrElse Me.Company_Desc.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Company_Desc.Text = "&nbsp;"
            End If

        End Sub

        Public Overridable Sub SetDate_Assigned()




            ' Set the Date_Assigned Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.Date_Assigned is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDate_Assigned()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Date_AssignedSpecified Then

                ' If the Date_Assigned is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.Date_Assigned, "d")

                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Date_Assigned.Text = formattedValue

            Else

                ' Date_Assigned is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.Date_Assigned.Text = Sel_Approver_Pending_TasksView.Date_Assigned.Format(Sel_Approver_Pending_TasksView.Date_Assigned.DefaultValue, "d")

            End If

            ' If the Date_Assigned is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Date_Assigned.Text Is Nothing _
                OrElse Me.Date_Assigned.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Date_Assigned.Text = "&nbsp;"
            End If

        End Sub

        Public Overridable Sub SetDoc_No()




            ' Set the Doc_No Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.Doc_No is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDoc_No()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Doc_NoSpecified Then

                ' If the Doc_No is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.Doc_No)

                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Doc_No.Text = formattedValue

            Else

                ' Doc_No is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.Doc_No.Text = Sel_Approver_Pending_TasksView.Doc_No.Format(Sel_Approver_Pending_TasksView.Doc_No.DefaultValue)

            End If

            ' If the Doc_No is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Doc_No.Text Is Nothing _
                OrElse Me.Doc_No.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Doc_No.Text = "&nbsp;"
            End If

        End Sub

        Public Overridable Sub SetDoc_Title()




            ' Set the Doc_Title Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.Doc_Title is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDoc_Title()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Doc_TitleSpecified Then

                ' If the Doc_Title is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.Doc_Title)

                If Not formattedValue Is Nothing Then

                    Dim maxLength As Integer = Len(formattedValue)
                    If (maxLength >= CType(300, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(300, Integer)
                        'First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue)

                        formattedValue = HttpUtility.HtmlEncode(formattedValue)

                    End If
                    If maxLength = CType(300, Integer) Then
                        formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0, Math.Min(maxLength, Len(formattedValue))))
                        formattedValue = formattedValue & "..."

                    Else

                        formattedValue = "<table border=""0"" cellpadding=""0"" cellspacing=""0""><tr><td>" & formattedValue & "</td></tr></table>"
                    End If
                End If

                Me.Doc_Title.Text = formattedValue

            Else

                ' Doc_Title is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.Doc_Title.Text = Sel_Approver_Pending_TasksView.Doc_Title.Format(Sel_Approver_Pending_TasksView.Doc_Title.DefaultValue)

            End If

            ' If the Doc_Title is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Doc_Title.Text Is Nothing _
                OrElse Me.Doc_Title.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Doc_Title.Text = "&nbsp;"
            End If

        End Sub

        Public Overridable Sub SetDoc_Total()




            ' Set the Doc_Total Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.Doc_Total is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDoc_Total()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Doc_TotalSpecified Then

                ' If the Doc_Total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.Doc_Total, "N")

                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Doc_Total.Text = formattedValue

            Else

                ' Doc_Total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.Doc_Total.Text = Sel_Approver_Pending_TasksView.Doc_Total.Format(Sel_Approver_Pending_TasksView.Doc_Total.DefaultValue, "N")

            End If

            ' If the Doc_Total is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Doc_Total.Text Is Nothing _
                OrElse Me.Doc_Total.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Doc_Total.Text = "&nbsp;"
            End If

        End Sub

        Public Overridable Sub SetDoc_Type()




            ' Set the Doc_Type Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.Doc_Type is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDoc_Type()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Doc_TypeSpecified Then

                ' If the Doc_Type is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.Doc_Type)

                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Doc_Type.Text = formattedValue

            Else

                ' Doc_Type is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.Doc_Type.Text = Sel_Approver_Pending_TasksView.Doc_Type.Format(Sel_Approver_Pending_TasksView.Doc_Type.DefaultValue)

            End If

            ' If the Doc_Type is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Doc_Type.Text Is Nothing _
                OrElse Me.Doc_Type.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Doc_Type.Text = "&nbsp;"
            End If

        End Sub

        Public Overridable Sub SetPK_ID()




            ' Set the PK_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.PK_ID is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetPK_ID()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.PK_IDSpecified Then

                ' If the PK_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.PK_ID)

                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.PK_ID.Text = formattedValue

            Else

                ' PK_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.PK_ID.Text = Sel_Approver_Pending_TasksView.PK_ID.Format(Sel_Approver_Pending_TasksView.PK_ID.DefaultValue)

            End If

            ' If the PK_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.PK_ID.Text Is Nothing _
                OrElse Me.PK_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.PK_ID.Text = "&nbsp;"
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

            If includeDS Then

            End If


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

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, Nothing)
        End Function


        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e As FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS As Boolean) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
        End Function


        Public Overridable Sub RegisterPostback()


        End Sub



        ' To customize, override this method in Sel_Approver_Pending_TasksTableControlRow.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()


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

                DirectCast(GetParentControlObject(Me, "Sel_Approver_Pending_TasksTableControl"), Sel_Approver_Pending_TasksTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "Sel_Approver_Pending_TasksTableControl"), Sel_Approver_Pending_TasksTableControl).ResetData = True
            End If


            ' update session or cookie by formula


            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True

            ' For Master-Detail relationships, save data on the Detail table(s)

        End Sub

        ' To customize, override this method in Sel_Approver_Pending_TasksTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.

            ' Call the Get methods for each of the user interface controls.

            GetC_ID()
            GetCompany_Desc()
            GetDate_Assigned()
            GetDoc_No()
            GetDoc_Title()
            GetDoc_Total()
            GetDoc_Type()
            GetPK_ID()
        End Sub


        Public Overridable Sub GetC_ID()

        End Sub

        Public Overridable Sub GetCompany_Desc()

        End Sub

        Public Overridable Sub GetDate_Assigned()

        End Sub

        Public Overridable Sub GetDoc_No()

        End Sub

        Public Overridable Sub GetDoc_Title()

        End Sub

        Public Overridable Sub GetDoc_Total()

        End Sub

        Public Overridable Sub GetDoc_Type()

        End Sub

        Public Overridable Sub GetPK_ID()

        End Sub


        ' To customize, override this method in Sel_Approver_Pending_TasksTableControlRow.

        Public Overridable Function CreateWhereClause() As WhereClause

            Dim hasFiltersSel_Approver_Pending_Tasks2TableControl As Boolean = False

            Dim hasFiltersSel_Approver_Pending_TasksTableControl As Boolean = False

            Return Nothing

        End Function



        ' To customize, override this method in Sel_Approver_Pending_TasksTableControlRow.
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

        Public Overridable Sub SetimbDoc()


        End Sub

        Public Overridable Sub SetimbList()


        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbDoc_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.


            Dim url As String = "../WCAR_Doc/Edit-WCAR-Doc.aspx?WCAR_Doc={Sel_Approver_Pending_TasksTableControlRow:FV:PK_ID}"

            If Me.Page.Request("RedirectStyle") <> "" Then url &= "&RedirectStyle=" & Me.Page.Request("RedirectStyle")

            Dim shouldRedirect As Boolean = True
            Dim target As String = ""

            Try

                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()

                url = Me.ModifyRedirectUrl(url, "", True)
                url = Me.Page.ModifyRedirectUrl(url, "", True)

            Catch ex As Exception

                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally
                DbUtils.EndTransaction()
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)

            End If
        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbList_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

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


        Public Property DataSource() As Sel_Approver_Pending_TasksRecord
            Get
                Return DirectCast(MyBase._DataSource, Sel_Approver_Pending_TasksRecord)
            End Get
            Set(ByVal value As Sel_Approver_Pending_TasksRecord)
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

        Public ReadOnly Property C_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "C_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Company_Desc() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Company_Desc"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Date_Assigned() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Date_Assigned"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Doc_No() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_No"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Doc_Title() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_Title"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Doc_Total() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_Total"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Doc_Type() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_Type"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property imbDoc() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbDoc"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbList() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbList"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property PK_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PK_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

#End Region

#Region "Helper Functions"

        Public Overloads Overrides Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overloads Overrides Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overloads Overrides Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String

            Dim rec As Sel_Approver_Pending_TasksRecord = Nothing


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

        Public Overloads Overrides Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String

            Dim rec As Sel_Approver_Pending_TasksRecord = Nothing


            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.

                Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ePortalWFApproval"))

            End If
            If includeSession Then
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            Else
                Return EvaluateExpressions(url, arg, rec, bEncrypt, False)
            End If
        End Function


        Public Overridable Function GetRecord() As Sel_Approver_Pending_TasksRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
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



    ' Base class for the Sel_Approver_Pending_TasksTableControl control on the Homepage page.
    ' Do not modify this class. Instead override any method in Sel_Approver_Pending_TasksTableControl.
    Public Class BaseSel_Approver_Pending_TasksTableControl
        Inherits ePortalWFApproval.UI.BaseApplicationTableControl


        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init



            ' Setup the filter and search.




            ' Control Initializations.
            ' Initialize the table's current sort order.
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))

            Else

                Me.CurrentSortOrder = New OrderBy(True, False)

                Me.CurrentSortOrder.Add(Sel_Approver_Pending_TasksView.SortOrder, OrderByItem.OrderDir.Asc)

                Me.CurrentSortOrder.Add(Sel_Approver_Pending_TasksView.Date_Assigned, OrderByItem.OrderDir.Desc)

            End If



            ' Setup default pagination settings.

            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))


        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            SaveControlsToSession_Ajax()

            ' Setup the pagination events.

            AddHandler Me.WCAR_DocPagination1.FirstPage.Click, AddressOf WCAR_DocPagination1_FirstPage_Click

            AddHandler Me.WCAR_DocPagination1.LastPage.Click, AddressOf WCAR_DocPagination1_LastPage_Click

            AddHandler Me.WCAR_DocPagination1.NextPage.Click, AddressOf WCAR_DocPagination1_NextPage_Click

            AddHandler Me.WCAR_DocPagination1.PageSizeButton.Click, AddressOf WCAR_DocPagination1_PageSizeButton_Click

            AddHandler Me.WCAR_DocPagination1.PreviousPage.Click, AddressOf WCAR_DocPagination1_PreviousPage_Click

            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.

            ' Setup the button events.

            AddHandler Me.Sel_Approver_Pending_TasksRefreshButton.Click, AddressOf Sel_Approver_Pending_TasksRefreshButton_Click

            AddHandler Me.SouthRedirectorButtonCARDoc.Button.Click, AddressOf SouthRedirectorButtonCARDoc_Click

            AddHandler Me.SouthRedirectorButtonPODoc.Button.Click, AddressOf SouthRedirectorButtonPODoc_Click

            AddHandler Me.SouthRedirectorButtonReCAR.Button.Click, AddressOf SouthRedirectorButtonReCAR_Click

            AddHandler Me.SouthRedirectorButtonRePO.Button.Click, AddressOf SouthRedirectorButtonRePO_Click


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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Sel_Approver_Pending_TasksRecord)), Sel_Approver_Pending_TasksRecord())
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
                    For Each rc As Sel_Approver_Pending_TasksTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Sel_Approver_Pending_TasksRecord)), Sel_Approver_Pending_TasksRecord())
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
            ByVal pageSize As Integer) As Sel_Approver_Pending_TasksRecord()

            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList



            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Sel_Approver_Pending_TasksView.Column1, True)         
            ' selCols.Add(Sel_Approver_Pending_TasksView.Column2, True)          
            ' selCols.Add(Sel_Approver_Pending_TasksView.Column3, True)    



            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *

            If selCols.Count = 0 Then

                Return Sel_Approver_Pending_TasksView.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)

            Else
                Dim databaseTable As New Sel_Approver_Pending_TasksView
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)

                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True



                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(Sel_Approver_Pending_TasksRecord)), Sel_Approver_Pending_TasksRecord())
            End If

        End Function


        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList


            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Sel_Approver_Pending_TasksView.Column1, True)         
            ' selCols.Add(Sel_Approver_Pending_TasksView.Column2, True)          
            ' selCols.Add(Sel_Approver_Pending_TasksView.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *

            If selCols.Count = 0 Then

                Return Sel_Approver_Pending_TasksView.GetRecordCount(join, where)

            Else
                Dim databaseTable As New Sel_Approver_Pending_TasksView
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

            Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_Approver_Pending_TasksTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return
            rep.DataSource = DataSource()
            rep.DataBind()

            Dim index As Integer = 0

            For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items

                ' Loop through all rows in the table, set its DataSource and call DataBind().
                Dim recControl As Sel_Approver_Pending_TasksTableControlRow = DirectCast(repItem.FindControl("Sel_Approver_Pending_TasksTableControlRow"), Sel_Approver_Pending_TasksTableControlRow)
                recControl.DataSource = Me.DataSource(index)
                If Me.UIData.Count > index Then
                    recControl.PreviousUIData = Me.UIData(index)
                End If
                recControl.DataBind()

                index += 1
            Next

            ' Call the Set methods for each controls on the panel

            SetCompany_DescLabel()
            SetDate_AssignedLabel()
            SetDoc_NoLabel()
            SetDoc_TitleLabel()
            SetDoc_TotalLabel()
            SetDoc_TypeLabel()


            SetLiteral2()
            SetLiteral3()
            SetLiteral4()
            SetlitLoading()







            SetSel_Approver_Pending_TasksRefreshButton()

            SetSouthRedirectorButtonCARDoc()

            SetSouthRedirectorButtonPODoc()

            SetSouthRedirectorButtonReCAR()

            SetSouthRedirectorButtonRePO()

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

            If includeDS Then

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

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, Nothing)
        End Function


        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e As FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS As Boolean) As String
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

                Me.CurrentSortOrder.Add(Sel_Approver_Pending_TasksView.SortOrder, OrderByItem.OrderDir.Asc)

                Me.CurrentSortOrder.Add(Sel_Approver_Pending_TasksView.Date_Assigned, OrderByItem.OrderDir.Desc)

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

                Me.WCAR_DocPagination1.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.WCAR_DocPagination1.CurrentPage.Text = "0"
            End If
            If DbUtils.GetCreatedRecords(Me.DataSource).Length > 0 Then

                Me.WCAR_DocPagination1.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.WCAR_DocPagination1.CurrentPage.Text = "0"
            End If
            Me.WCAR_DocPagination1.PageSize.Text = Me.PageSize.ToString()
            Me.WCAR_DocPagination1.PageSize.Text = Me.PageSize.ToString()
            Me.WCAR_DocPagination1.TotalItems.Text = Me.TotalRecords.ToString()
            Me.WCAR_DocPagination1.TotalItems.Text = Me.TotalRecords.ToString()
            Me.WCAR_DocPagination1.TotalPages.Text = Me.TotalPages.ToString()
            Me.WCAR_DocPagination1.TotalPages.Text = Me.TotalPages.ToString()

            ' Bind the buttons for Sel_Approver_Pending_TasksTableControl pagination.

            Me.WCAR_DocPagination1.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.WCAR_DocPagination1.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0 Then          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.WCAR_DocPagination1.LastPage.Enabled = False
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.WCAR_DocPagination1.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If

            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.WCAR_DocPagination1.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0 Then          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.WCAR_DocPagination1.NextPage.Enabled = False
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.WCAR_DocPagination1.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If

            Me.WCAR_DocPagination1.PreviousPage.Enabled = Not (Me.PageIndex = 0)


        End Sub



        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.

            Dim recCtl As Sel_Approver_Pending_TasksTableControlRow
            For Each recCtl In Me.GetRecordControls()

                If recCtl.Visible Then
                    recCtl.SaveData()
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
            Sel_Approver_Pending_TasksView.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()

            Dim hasFiltersSel_Approver_Pending_Tasks2TableControl As Boolean = False

            Dim hasFiltersSel_Approver_Pending_TasksTableControl As Boolean = False

            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.



            Return wc
        End Function


        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Sel_Approver_Pending_TasksView.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()

            Dim hasFiltersSel_Approver_Pending_Tasks2TableControl As Boolean = False

            Dim hasFiltersSel_Approver_Pending_TasksTableControl As Boolean = False

            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)

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

            If Me.WCAR_DocPagination1.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.WCAR_DocPagination1.PageSize.Text)
                Catch ex As Exception
                End Try
            End If
            If Me.WCAR_DocPagination1.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.WCAR_DocPagination1.PageSize.Text)
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
                Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_Approver_Pending_TasksTableControlRepeater"), System.Web.UI.WebControls.Repeater)
                If rep Is Nothing Then Return


                Dim repItem As System.Web.UI.WebControls.RepeaterItem
                For Each repItem In rep.Items

                    ' Loop through all rows in the table, set its DataSource and call DataBind().

                    Dim recControl As Sel_Approver_Pending_TasksTableControlRow = DirectCast(repItem.FindControl("Sel_Approver_Pending_TasksTableControlRow"), Sel_Approver_Pending_TasksTableControlRow)


                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As Sel_Approver_Pending_TasksRecord = New Sel_Approver_Pending_TasksRecord()

                        If recControl.C_ID.Text <> "" Then
                            rec.Parse(recControl.C_ID.Text, Sel_Approver_Pending_TasksView.C_ID)
                        End If
                        If recControl.Company_Desc.Text <> "" Then
                            rec.Parse(recControl.Company_Desc.Text, Sel_Approver_Pending_TasksView.Company_Desc)
                        End If
                        If recControl.Date_Assigned.Text <> "" Then
                            rec.Parse(recControl.Date_Assigned.Text, Sel_Approver_Pending_TasksView.Date_Assigned)
                        End If
                        If recControl.Doc_No.Text <> "" Then
                            rec.Parse(recControl.Doc_No.Text, Sel_Approver_Pending_TasksView.Doc_No)
                        End If
                        If recControl.Doc_Title.Text <> "" Then
                            rec.Parse(recControl.Doc_Title.Text, Sel_Approver_Pending_TasksView.Doc_Title)
                        End If
                        If recControl.Doc_Total.Text <> "" Then
                            rec.Parse(recControl.Doc_Total.Text, Sel_Approver_Pending_TasksView.Doc_Total)
                        End If
                        If recControl.Doc_Type.Text <> "" Then
                            rec.Parse(recControl.Doc_Type.Text, Sel_Approver_Pending_TasksView.Doc_Type)
                        End If
                        If recControl.PK_ID.Text <> "" Then
                            rec.Parse(recControl.PK_ID.Text, Sel_Approver_Pending_TasksView.PK_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())
                        newRecordList.Add(rec)
                    End If
                Next
            End If


            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord

                newRecordList.Insert(0, New Sel_Approver_Pending_TasksRecord())
                newUIDataList.Insert(0, New Hashtable())

            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then

                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(Sel_Approver_Pending_TasksRecord)), Sel_Approver_Pending_TasksRecord())

            End If

            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If

        End Sub



        ' Create Set, WhereClause, and Populate Methods

        Public Overridable Sub SetCompany_DescLabel()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.Company_DescLabel.Text = "Some value"

        End Sub

        Public Overridable Sub SetDate_AssignedLabel()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.Date_AssignedLabel.Text = "Some value"

        End Sub

        Public Overridable Sub SetDoc_NoLabel()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.Doc_NoLabel.Text = "Some value"

        End Sub

        Public Overridable Sub SetDoc_TitleLabel()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.Doc_TitleLabel.Text = "Some value"

        End Sub

        Public Overridable Sub SetDoc_TotalLabel()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.Doc_TotalLabel.Text = "Some value"

        End Sub

        Public Overridable Sub SetDoc_TypeLabel()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.Doc_TypeLabel.Text = "Some value"

        End Sub

        Public Overridable Sub SetLiteral2()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.Literal2.Text = "Some value"

        End Sub

        Public Overridable Sub SetLiteral3()



        End Sub

        Public Overridable Sub SetLiteral4()



        End Sub

        Public Overridable Sub SetlitLoading()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litLoading.Text = "Some value"

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

        End Sub

        Protected Sub SaveControlsToSession_Ajax()
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

        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("Sel_Approver_Pending_TasksTableControl_OrderBy"), String)

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

        End Sub

        Protected Overrides Function SaveViewState() As Object

            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("Sel_Approver_Pending_TasksTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If

            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize


            ' Load view state for pagination control.


            Return MyBase.SaveViewState()
        End Function

        ' Generate set method for buttons

        Public Overridable Sub SetSel_Approver_Pending_TasksRefreshButton()


        End Sub

        Public Overridable Sub SetSouthRedirectorButtonCARDoc()


        End Sub

        Public Overridable Sub SetSouthRedirectorButtonPODoc()


        End Sub

        Public Overridable Sub SetSouthRedirectorButtonReCAR()


        End Sub

        Public Overridable Sub SetSouthRedirectorButtonRePO()


        End Sub


        ' Generate the event handling functions for pagination events.

        ' event handler for ImageButton
        Public Overridable Sub WCAR_DocPagination1_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

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
        Public Overridable Sub WCAR_DocPagination1_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

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
        Public Overridable Sub WCAR_DocPagination1_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

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
        Public Overridable Sub WCAR_DocPagination1_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)

            Try

                Me.DataChanged = True

                Me.PageSize = Me.WCAR_DocPagination1.GetCurrentPageSize()

                Me.PageIndex = Integer.Parse(Me.WCAR_DocPagination1.CurrentPage.Text) - 1

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub WCAR_DocPagination1_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

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

        ' event handler for ImageButton
        Public Overridable Sub Sel_Approver_Pending_TasksRefreshButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

                Dim Sel_Approver_Pending_Tasks2TableControlObj As Sel_Approver_Pending_Tasks2TableControl = DirectCast(Me.Page.FindControlRecursively("Sel_Approver_Pending_Tasks2TableControl"), Sel_Approver_Pending_Tasks2TableControl)
                Sel_Approver_Pending_Tasks2TableControlObj.ResetData = True


                Dim Sel_Approver_Pending_TasksTableControlObj As Sel_Approver_Pending_TasksTableControl = DirectCast(Me.Page.FindControlRecursively("Sel_Approver_Pending_TasksTableControl"), Sel_Approver_Pending_TasksTableControl)
                Sel_Approver_Pending_TasksTableControlObj.ResetData = True


            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for Button
        Public Overridable Sub SouthRedirectorButtonCARDoc_Click(ByVal sender As Object, ByVal args As EventArgs)

            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.


            Dim url As String = "../sel_WCAR_Doc_Creator_Approver/Show-Sel-WCAR-Doc-Creator-Approver-Table.aspx"

            If Me.Page.Request("RedirectStyle") <> "" Then url &= "?RedirectStyle=" & Me.Page.Request("RedirectStyle")

            Dim shouldRedirect As Boolean = True
            Dim target As String = ""

            Try

                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()

                url = Me.ModifyRedirectUrl(url, "", True)
                url = Me.Page.ModifyRedirectUrl(url, "", True)

            Catch ex As Exception

                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally
                DbUtils.EndTransaction()
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)

            End If
        End Sub

        ' event handler for Button
        Public Overridable Sub SouthRedirectorButtonPODoc_Click(ByVal sender As Object, ByVal args As EventArgs)

            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.


            Dim url As String = "../sel_WPO_Activity_WPOP10100/Show-Sel-WPO-Activity-WPOP10100-Table.aspx"

            If Me.Page.Request("RedirectStyle") <> "" Then url &= "?RedirectStyle=" & Me.Page.Request("RedirectStyle")

            Dim shouldRedirect As Boolean = True
            Dim target As String = ""

            Try

                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()

                url = Me.ModifyRedirectUrl(url, "", True)
                url = Me.Page.ModifyRedirectUrl(url, "", True)

            Catch ex As Exception

                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally
                DbUtils.EndTransaction()
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)

            End If
        End Sub

        ' event handler for Button
        Public Overridable Sub SouthRedirectorButtonReCAR_Click(ByVal sender As Object, ByVal args As EventArgs)

            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.


            Dim url As String = "../WCAR_Activity/Show-WCAR-Activity-Table.aspx"

            If Me.Page.Request("RedirectStyle") <> "" Then url &= "?RedirectStyle=" & Me.Page.Request("RedirectStyle")

            Dim shouldRedirect As Boolean = True
            Dim target As String = ""

            Try

                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()

                url = Me.ModifyRedirectUrl(url, "", True)
                url = Me.Page.ModifyRedirectUrl(url, "", True)

            Catch ex As Exception

                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally
                DbUtils.EndTransaction()
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)

            End If
        End Sub

        ' event handler for Button
        Public Overridable Sub SouthRedirectorButtonRePO_Click(ByVal sender As Object, ByVal args As EventArgs)

            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.


            Dim url As String = "../selWFReassign/Show-SelWFReassign-Table.aspx"

            If Me.Page.Request("RedirectStyle") <> "" Then url &= "?RedirectStyle=" & Me.Page.Request("RedirectStyle")

            Dim shouldRedirect As Boolean = True
            Dim target As String = ""

            Try

                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()

                url = Me.ModifyRedirectUrl(url, "", True)
                url = Me.Page.ModifyRedirectUrl(url, "", True)

            Catch ex As Exception

                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally
                DbUtils.EndTransaction()
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)

            End If
        End Sub



        ' Generate the event handling functions for filter and search events.


        ' Generate the event handling functions for others




        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 Then
                    _TotalRecords = Sel_Approver_Pending_TasksView.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
            Set(ByVal value As OrderBy)
                Me._CurrentSortOrder = value
            End Set
        End Property

        Public Property DataSource() As Sel_Approver_Pending_TasksRecord()
            Get
                Return DirectCast(MyBase._DataSource, Sel_Approver_Pending_TasksRecord())
            End Get
            Set(ByVal value As Sel_Approver_Pending_TasksRecord())
                Me._DataSource = value
            End Set
        End Property

#Region "Helper Properties"

        Public ReadOnly Property Company_DescLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Company_DescLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Date_AssignedLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Date_AssignedLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Doc_NoLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_NoLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Doc_TitleLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_TitleLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Doc_TotalLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_TotalLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Doc_TypeLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_TypeLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Image() As System.Web.UI.WebControls.Image
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Image"), System.Web.UI.WebControls.Image)
            End Get
        End Property

        Public ReadOnly Property Image2() As System.Web.UI.WebControls.Image
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Image2"), System.Web.UI.WebControls.Image)
            End Get
        End Property

        Public ReadOnly Property Literal2() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal2"), System.Web.UI.WebControls.Label)
            End Get
        End Property

        Public ReadOnly Property Literal3() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal3"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property Literal4() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal4"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litLoading() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litLoading"), System.Web.UI.WebControls.Label)
            End Get
        End Property

        Public ReadOnly Property Sel_Approver_Pending_TasksRefreshButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_Approver_Pending_TasksRefreshButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property Sel_Approver_Pending_TasksTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_Approver_Pending_TasksTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property SouthRedirectorButtonCARDoc() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SouthRedirectorButtonCARDoc"), ePortalWFApproval.UI.IThemeButton)
            End Get
        End Property

        Public ReadOnly Property SouthRedirectorButtonPODoc() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SouthRedirectorButtonPODoc"), ePortalWFApproval.UI.IThemeButton)
            End Get
        End Property

        Public ReadOnly Property SouthRedirectorButtonReCAR() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SouthRedirectorButtonReCAR"), ePortalWFApproval.UI.IThemeButton)
            End Get
        End Property

        Public ReadOnly Property SouthRedirectorButtonRePO() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SouthRedirectorButtonRePO"), ePortalWFApproval.UI.IThemeButton)
            End Get
        End Property

        Public ReadOnly Property WCAR_DocPagination1() As ePortalWFApproval.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_DocPagination1"), ePortalWFApproval.UI.IPagination)
            End Get
        End Property

#End Region

#Region "Helper Functions"

        Public Overloads Overrides Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, Nothing, bEncrypt)
        End Function

        Public Overloads Overrides Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return EvaluateExpressions(url, arg, Nothing, bEncrypt, includeSession)
        End Function

        Public Overloads Overrides Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, Nothing, bEncrypt)
        End Function

        Public Overloads Overrides Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return EvaluateExpressions(url, arg, Nothing, bEncrypt, includeSession)
        End Function

        Public Overridable Function GetSelectedRecordControl() As Sel_Approver_Pending_TasksTableControlRow
            Return Nothing

        End Function

        Public Overridable Function GetSelectedRecordControls() As Sel_Approver_Pending_TasksTableControlRow()

            Return DirectCast((New ArrayList()).ToArray(GetType(Sel_Approver_Pending_TasksTableControlRow)), Sel_Approver_Pending_TasksTableControlRow())

        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As Sel_Approver_Pending_TasksTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If

            Dim recCtl As Sel_Approver_Pending_TasksTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then

                        ' Localization.
                        Throw New Exception(Page.GetResourceValue("Err:CannotDelRecs", "ePortalWFApproval"))

                    End If
                    recCtl.Visible = False

                Else

                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:CannotDelRecs", "ePortalWFApproval"))

                End If
            Next
        End Sub

        Public Overridable Function GetRecordControls() As Sel_Approver_Pending_TasksTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "Sel_Approver_Pending_TasksTableControlRow")
            Dim list As New List(Of Sel_Approver_Pending_TasksTableControlRow)
            For Each recCtrl As Sel_Approver_Pending_TasksTableControlRow In recCtrls
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

  