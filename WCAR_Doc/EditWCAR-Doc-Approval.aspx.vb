
' This file implements the code-behind class for EditWCAR-Doc-Approval.aspx.
' App_Code\MyPage.Controls.vb contains the Table, Row and Record control classes
' for the page.  Best practices calls for overriding methods in the Row or Record control classes.

#Region "Imports statements"

Option Strict On
Imports System
Imports System.Data
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports BaseClasses
Imports BaseClasses.Utils
Imports BaseClasses.Utils.StringUtils
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports BaseClasses.Data.OrderByItem.OrderDir
Imports BaseClasses.Data.BaseFilter
Imports BaseClasses.Data.BaseFilter.ComparisonOperator
Imports BaseClasses.Web.UI.WebControls
        
Imports ePortalWFApproval.Business
Imports ePortalWFApproval.Data
        

#End Region

  
Namespace ePortalWFApproval.UI
  
Partial Public Class EditWCAR_Doc_Approval
        Inherits BaseApplicationPage
' Code-behind class for the EditWCAR_Doc_Approval page.
' Place your customizations in Section 1. Do not modify Section 2.
        
#Region "Section 1: Place your customizations here."
    
      Public Sub SetPageFocus()
          'To set focus on page load to a specific control pass this control to the SetStartupFocus method. To get a hold of  a control
          'use FindControlRecursively method. For example:
          'Dim controlToFocus As System.Web.UI.WebControls.TextBox = DirectCast(Me.FindControlRecursively("ProductsSearch"), System.Web.UI.WebControls.TextBox)
          'Me.SetFocusOnLoad(controlToFocus)
          'If no control is passed or control does not exist this method will set focus on the first focusable control on the page.
          Me.SetFocusOnLoad()  
      End Sub
       
      Public Sub LoadData()

            LoadData_Base()
            btnSubmitAction.Font.Name = "Tahoma"
            btnSubmitAction.Font.Size = New FontUnit(9)
            ''added Return status **pepanes 09.20.2013
            ddlAction.Items.Add("Approve")
            ddlAction.Items.Add("Reject")
            ddlAction.Items.Add("Void")
            ddlAction.Items.Add("Return")

            ddlAction.AutoPostBack = True
            If WCD_Status.Text = "Completed" Then
                ddlAction.Enabled = False
            Else
                ddlAction.Enabled = True
            End If
            ''04.02.2014 - pepanes **gftey
            ''bug fixed for CAR pending document
            If Me.Page.Request.QueryString.Item("WCAR_Doc") Is Nothing Then
                'ShowSel_WCAR_Activity_WCAR_DocTable.aspx
                'Dim url As String = "../wf_car/ShowSel_WCAR_Activity_WCAR_DocTable.aspx?"
                Dim url As String = "../Security/Homepage.aspx?"

                url = Me.ModifyRedirectUrl(url, "")

                Me.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            End If
        End Sub


        Private Function FindDelegate(ByVal AssignedApprover As String, Optional ByRef Info As String = "") As String
            Dim sApprover As String = AssignedApprover
            Dim sCheck As String = AssignedApprover
            Dim bNoMoreDelegate As Boolean = False
            Dim sWhereDelegate As String = ""
            Dim iCircular As Integer = 0
            Do While Not bNoMoreDelegate
                sWhereDelegate = WTask_DelegationTable.WTD_W_U_ID.UniqueName & " = '" & sApprover & _
                "' And " & WTask_DelegationTable.WTD_WDT_Type.UniqueName & " = 'CAR' And " & _
                WTask_DelegationTable.WTD_From.UniqueName & " <= '" & Now.ToShortDateString() & _
                "' And " & WTask_DelegationTable.WTD_To.UniqueName & " >= '" & Now.ToShortDateString() & "'" & _
                " And " & WTask_DelegationTable.WTD_C_ID.UniqueName & " = " & Me.WCD_C_ID.SelectedValue.ToString()

                sCheck = ""
                For Each oDelegate As WTask_DelegationRecord In WTask_DelegationTable.GetRecords(sWhereDelegate, Nothing, 0, 5)
                    sApprover = oDelegate.WTD_W_U_ID_Delegate.ToString()
                    sCheck = oDelegate.WTD_W_U_ID_Delegate.ToString()
                    Info = " #Delegated Task#"
                Next

                If sCheck = "" Then
                    bNoMoreDelegate = True
                End If
                iCircular += 1
                If iCircular > 15 Then 'threshold loop
                    'default to original approver
                    sApprover = AssignedApprover
                    'exit infinite loop
                    bNoMoreDelegate = True
                End If
            Loop
            Return sApprover
        End Function

        Public Sub SaveButton_Click(ByVal sender As Object, ByVal args As EventArgs) Handles btnSubmitAction.Click
            '*** NEW: 02-02-2012
            Dim wcCreator As WhereClause = New WhereClause
            Dim sCreator_ID As String

            wcCreator.iAND(WCAR_DocTable.WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
            For Each itemCreator As WCAR_DocRecord In WCAR_DocTable.GetRecords(wcCreator, Nothing, 0, 100)
                sCreator_ID = itemCreator.WCD_U_ID.ToString()
            Next
            '*** NEW: 02-02-2012

            Dim wc1 As WhereClause = New WhereClause
            Dim sCurStep As String
            Dim sEmailContent As String = "Company: @C" & vbcrlf & vbcrlf & "Details:" & vbcrlf & "@D" & vbcrlf & _
            vbcrlf & "Request Date: @RD" & _
            vbcrlf & "Remarks: @Rem" & vbcrlf & "Total: @T"
            'itemValue.Format(Sel_W_User_DYNAMICS_CompanyView.Company_Short_Name)
            sEmailContent = Replace(sEmailContent, "@C", Me.WCD_C_ID.SelectedItem.ToString())
            sEmailContent = Replace(sEmailContent, "@D", Me.WCD_Project_Title.Text)
            sEmailContent = Replace(sEmailContent, "@RD", Me.WCD_Request_Date.Text)
            sEmailContent = Replace(sEmailContent, "@Rem", Me.WCD_Remark.Text)
            sEmailContent = Replace(sEmailContent, "@T", Me.WCD_Exp_Cur_Yr.Text)
            sEmailContent &= vbcrlf & "Creator: " & Me.WCD_U_ID.Text
            sEmailContent &= vbCrLf & vbCrLf & "http://eportal.anflocor.com"

            'note: CAR Doc ID, User ID, Status
            wc1.iAND(WCAR_ActivityTable.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
            wc1.iAND(WCAR_ActivityTable.WCA_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("ActivityUserID").ToString())
            wc1.iAND(WCAR_ActivityTable.WCA_Status, BaseFilter.ComparisonOperator.EqualsTo, "Pending")
            'note: check to see if record is still pending, if not then do not save
            If WCAR_ActivityTable.GetRecords(wc1, Nothing, 0, 100).Length > 0 Then
                'note: get Current step to be used in wc2
                For Each itemValue1 As WCAR_ActivityRecord In WCAR_ActivityTable.GetRecords(wc1, Nothing, 0, 100)
                    sCurStep = itemValue1.WCA_WS_ID.ToString()
                Next
                'note: check actions
                Select Case ddlAction.SelectedIndex
                    Case 0 'Approved
                        'email:Send_Email_Notification
                        'note: get 'No of Approvers Needed',Next Step ID in WStep table
                        Dim wc2 As WhereClause = New WhereClause
                        Dim iApprovers As Integer = 0
                        Dim sNextStep As String = ""

                        wc2.iAND(Sel_WStep_WStep_DetailView.WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)
                        'commented: 07/23/2010 -> causes re-assigned tasks to have an empty next step
                        'wc2.iAND(Sel_WStep_WStep_DetailView.WSD_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("ActivityUserID").ToString())
                        For Each itemValue2 As Sel_WStep_WStep_DetailRecord In Sel_WStep_WStep_DetailView.GetRecords(wc2, Nothing, 0, 100)
                            iApprovers = itemValue2.WS_Approval_Needed
                            sNextStep = itemValue2.WS_ID_Next.ToString
                        Next

                        Dim wc3 As WhereClause = New WhereClause
                        'note: arrange to desc, we want to get the latest ids
                        'Dim ob1 As OrderBy = New OrderBy(False, True)
                        Dim colUser As New Collection
                        'Dim colAct as New Collection
                        'note: query Activity to count # of approvers <> to current user
                        'ob1.AddColumn(WCAR_ActivityTable.WCA_ID, Desc)
                        wc3.iAND(WCAR_ActivityTable.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                        wc3.iAND(WCAR_ActivityTable.WCA_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("ActivityUserID").ToString())
                        wc3.iAND(WCAR_ActivityTable.WCA_Status, BaseFilter.ComparisonOperator.EqualsTo, "Approved")
                        wc3.iAND(WCAR_ActivityTable.WCA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)
                        ''04.02.2014 -pepanes **gftey
                        wc3.iAND(WCAR_ActivityTable.WCA_Is_Done, BaseFilter.ComparisonOperator.EqualsTo, "0") 'WCA_Is_Done field is updated through trigger


                        For Each itemValue3 As WCAR_ActivityRecord In WCAR_ActivityTable.GetRecords(wc3, Nothing, 0, 100)
                            'note: do not include previous same step if wf has been 'Rejected'
                            If Not colUser.Contains(itemValue3.WCA_W_U_ID.ToString) Then
                                colUser.Add(itemValue3.WCA_W_U_ID, itemValue3.WCA_W_U_ID.ToString)
                                'colAct.Add(itemValue3.WCA_ID)'used to set 'System Approved'
                            End If
                        Next
                        '--------------------------------------------------------------------------------------------------------
                        If iApprovers = colUser.Count + 1 Then 'met the # of approvers requirement (+1 -> means the current user)
                            If sNextStep = "0" Then 'no next step (end workflow here)
                                'note: set current user status task to 'Approved' & set CAR doc status to 'Completed'
                                Dim wc5 As WhereClause = New WhereClause

                                wc5.iAND(WCAR_ActivityTable.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                                wc5.iAND(WCAR_ActivityTable.WCA_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("ActivityUserID").ToString())
                                wc5.iAND(WCAR_ActivityTable.WCA_Status, BaseFilter.ComparisonOperator.EqualsTo, "Pending")
                                wc5.iAND(WCAR_ActivityTable.WCA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                                If WCAR_ActivityTable.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                                    For Each itemValue5 As WCAR_ActivityRecord In WCAR_ActivityTable.GetRecords(wc5, Nothing, 0, 100)
                                        'note: update Activity table (current user) -> 'Approved'
                                        WCAR_ActivityRecord.UpdateRecord(itemValue5.WCA_ID.ToString(), "Approved")
                                    Next
                                End If
                                'note: set CAR doc status to 'Completed'
                                Dim wc6 As WhereClause = New WhereClause
                                wc6.iAND(WCAR_DocTable.WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                                For Each itemValue6 As WCAR_DocRecord In WCAR_DocTable.GetRecords(wc6, Nothing, 0, 100)
                                    WCAR_DocRecord.UpdateRecord(itemValue6.WCD_ID.ToString(), "Completed")
                                    'send Creator confirmation email that the task is already completed
                                    '--added email content (12/20/2011)

                                    sEmailContent = Content_Formatter(itemValue6.WCD_U_ID.ToString(), _
                                    "CAR Approval Completed (CAR# " & Me.WCD_No.Text & ")", Me.WCD_C_ID.SelectedItem.ToString(), _
                                    Me.WCD_Project_Title.Text, Me.WCD_Request_Date.Text, Me.WCD_Remark.Text, Me.WCD_Exp_Cur_Yr.Text, _
                                    sCreator_ID, "#64d04b", "wf_car/ShowSel_WCAR_Activity_WCAR_DocTable.aspx", Me.WCD_No.Text, _
                                    "Please print the CAR document then submit it to M&S for PR preparation.", "CAR WF Completed", "CAR", "CAR Creator")

                                    'sEmailContent &= vbcrlf & vbcrlf & "Note: Please print the CAR document then submit it to M&S for PR preparation."
                                    Send_Email_Notification(itemValue6.WCD_U_ID.ToString(), "CAR Approval Completed (CAR# " & _
                                    Me.WCD_No.Text & ")", sEmailContent)
                                Next
                                ''04.02.2014 -pepanes **gftey
                                Dim sNotifyComplete As String = "WFCN_C_ID =" & Me.WCD_C_ID.SelectedValue.ToString() & " And WFCN_DocType ='CAR'"
                                For Each itemValueN As WF_Complete_NotifyRecord In WF_Complete_NotifyTable.GetRecords(sNotifyComplete, Nothing, 0, 100)
                                    sEmailContent = Content_Formatter(itemValueN.WFCN_U_ID.ToString(), _
                                    "CAR Approval Completed (CAR# " & Me.WCD_No.Text & ")", Me.WCD_C_ID.SelectedItem.ToString(), _
                                    Me.WCD_Project_Title.Text, Me.WCD_Request_Date.Text, Me.WCD_Remark.Text, Me.WCD_Exp_Cur_Yr.Text, _
                                    sCreator_ID, "#64d04b", "wf_car/ShowSel_WCAR_Activity_WCAR_DocTable.aspx", Me.WCD_No.Text, _
                                    "CAR WF Completed", "CAR WF Completed", "CAR", "CAR Creator")

                                    Send_Email_Notification(itemValueN.WFCN_U_ID.ToString(), "CAR Approval Completed (CAR# " & _
                                    Me.WCD_No.Text & ")", sEmailContent)
                                Next
                            Else
                                If WCD_Status.Text <> "Return" Then
                                    'note: if # of approvers needed < multiple approvers then set other 'Pending' status to 'System Approved'
                                    'note: set current user status to 'Approved'
                                    'note: get user(s) for the next step & insert to Activity table
                                    Dim wc4 As WhereClause = New WhereClause

                                    wc4.iAND(WCAR_ActivityTable.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                                    wc4.iAND(WCAR_ActivityTable.WCA_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("ActivityUserID").ToString())
                                    wc4.iAND(WCAR_ActivityTable.WCA_Status, BaseFilter.ComparisonOperator.EqualsTo, "Pending")
                                    wc4.iAND(WCAR_ActivityTable.WCA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                                    For Each itemValue4 As WCAR_ActivityRecord In WCAR_ActivityTable.GetRecords(wc4, Nothing, 0, 100)
                                        'note: update Activity table (other user(s) if multiple approvers) -> 'System Approved'
                                        WCAR_ActivityRecord.UpdateRecord(itemValue4.WCA_ID.ToString(), "System Approved")
                                    Next

                                    Dim wc5 As WhereClause = New WhereClause

                                    wc5.iAND(WCAR_ActivityTable.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                                    wc5.iAND(WCAR_ActivityTable.WCA_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("ActivityUserID").ToString())
                                    wc5.iAND(WCAR_ActivityTable.WCA_Status, BaseFilter.ComparisonOperator.EqualsTo, "Pending")
                                    wc5.iAND(WCAR_ActivityTable.WCA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                                    If WCAR_ActivityTable.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                                        For Each itemValue5 As WCAR_ActivityRecord In WCAR_ActivityTable.GetRecords(wc5, Nothing, 0, 100)
                                            'note: update Activity table (current user) -> 'Approved'
                                            WCAR_ActivityRecord.UpdateRecord(itemValue5.WCA_ID.ToString(), "Approved")
                                        Next
                                    End If

                                    Dim wc6 As WhereClause = New WhereClause

                                    wc6.iAND(Sel_WStep_WStep_DetailView.WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sNextStep)

                                    For Each itemValue6 As Sel_WStep_WStep_DetailRecord In Sel_WStep_WStep_DetailView.GetRecords(wc6, Nothing, 0, 100)
                                        'note: use returned items to insert to Activity table
                                        'note: do not insert(update) delegate until task expires
                                        '01/24/2011: insert delegate function here ####################################
                                        Dim sRemark As String = txtRemark.Text
                                        WCAR_ActivityRecord.AddRecord(itemValue6.WS_ID.ToString(), itemValue6.WSD_ID.ToString(), _
                                        Me.WCD_WDT_ID.SelectedValue.ToString(), _
                                        FindDelegate(itemValue6.WSD_W_U_ID.ToString()), "0", _
                                        Me.WCD_ID.SelectedValue.ToString(), _
                                        DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                                        ": " & sRemark)

                                        Dim sInfo As String = ""
                                        Dim sDelegate As String = FindDelegate(itemValue6.WSD_W_U_ID.ToString(), sInfo)
                                        Dim sUserRej As String = System.Web.HttpContext.Current.Session("UserFullName").ToString()

                                        sEmailContent = Content_Formatter(sDelegate, _
                                        "CAR Approval Needed (CAR# " & Me.WCD_No.Text & ")", Me.WCD_C_ID.SelectedItem.ToString(), _
                                        Me.WCD_Project_Title.Text, Me.WCD_Request_Date.Text, Me.WCD_Remark.Text, Me.WCD_Exp_Cur_Yr.Text, _
                                        sCreator_ID, "#4682b4", "wf_car/ShowSel_WCAR_Activity_WCAR_DocTable.aspx", Me.WCD_No.Text, _
                                        sRemark, "Approved by " & sUserRej, "CAR")

                                        Send_Email_Notification(sDelegate, "CAR Approval Needed (CAR# " & _
                                        Me.WCD_No.Text & ")" & sInfo, sEmailContent)
                                    Next
                                Else
                                    '------------------------------------------ Approved Return (3/13/14)
                                    ''04.02.2014 -pepanes **gftey
                                    Dim wc41 As WhereClause = New WhereClause

                                    wc41.iAND(WCAR_ActivityTable.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                                    wc41.iAND(WCAR_ActivityTable.WCA_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("ActivityUserID").ToString())
                                    wc41.iAND(WCAR_ActivityTable.WCA_Status, BaseFilter.ComparisonOperator.EqualsTo, "Pending")
                                    wc41.iAND(WCAR_ActivityTable.WCA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                                    For Each itemValue41 As WCAR_ActivityRecord In WCAR_ActivityTable.GetRecords(wc41, Nothing, 0, 100)
                                        'note: update Activity table (other user(s) if multiple approvers) -> 'System Approved'
                                        WCAR_ActivityRecord.UpdateRecord(itemValue41.WCA_ID.ToString(), "System Approved")
                                    Next

                                    Dim wc4 As WhereClause = New WhereClause

                                    wc4.iAND(WCAR_ActivityTable.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                                    wc4.iAND(WCAR_ActivityTable.WCA_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("ActivityUserID").ToString())
                                    wc4.iAND(WCAR_ActivityTable.WCA_Status, BaseFilter.ComparisonOperator.EqualsTo, "Pending")
                                    wc4.iAND(WCAR_ActivityTable.WCA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                                    For Each itemValue4 As WCAR_ActivityRecord In WCAR_ActivityTable.GetRecords(wc4, Nothing, 0, 100)
                                        WCAR_ActivityRecord.UpdateRecord(itemValue4.WCA_ID.ToString(), "Approved")
                                    Next

                                    Dim wc5 As WhereClause = New WhereClause
                                    Dim orderBy As OrderBy = New OrderBy(False, True)
                                    orderBy.Add(WCAR_ActivityTable.WCA_ID, BaseClasses.Data.OrderByItem.OrderDir.Desc) 'get the latest return

                                    wc5.iAND(WCAR_ActivityTable.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                                    'wc5.iAND(WCAR_ActivityTable.WCA_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, "")
                                    wc5.iAND(WCAR_ActivityTable.WCA_Status, BaseFilter.ComparisonOperator.EqualsTo, "Return")
                                    'wc5.iAND(WCAR_ActivityTable.WCA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                                    If WCAR_ActivityTable.GetRecords(wc5, orderBy, 0, 100).Length > 0 Then
                                        For Each itemValue5 As WCAR_ActivityRecord In WCAR_ActivityTable.GetRecords(wc5, orderBy, 0, 100)
                                            'note: update Activity table (current user) -> 'Approved'

                                            Dim sInfo As String = ""
                                            Dim sDelegate As String = FindDelegate(itemValue5.WCA_W_U_ID.ToString(), sInfo)

                                            sEmailContent = Content_Formatter(sDelegate, _
                                            "CAR Information Needed (CAR# " & Me.WCD_No.Text & ")", Me.WCD_C_ID.SelectedItem.ToString(), _
                                            Me.WCD_Project_Title.Text, Me.WCD_Request_Date.Text, Me.WCD_Remark.Text, Me.WCD_Exp_Cur_Yr.Text, _
                                            System.Web.HttpContext.Current.Session("UserID").ToString(), "#4682b4", "wf_car/ShowSel_WCAR_Activity_WCAR_DocTable.aspx", Me.WCD_No.Text, _
                                            "", "", "CAR")

                                            Send_Email_Notification(sDelegate, "CAR Approval Needed (CAR# " & _
                                            Me.WCD_No.Text & ")" & sInfo, sEmailContent)

                                            Dim sRemark As String = txtRemark.Text

                                            'change return to pending
                                            WCAR_DocRecord.UpdateRecord_Status_Submit(Me.WCD_ID.Text, "Pending", "1", _
                                            DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                                            ": " & sRemark)

                                            WCAR_ActivityRecord.AddRecord(itemValue5.WCA_WS_ID.ToString(), itemValue5.WCA_WSD_ID.ToString(), _
                                            Me.WCD_WDT_ID.SelectedValue.ToString(), _
                                            FindDelegate(itemValue5.WCA_W_U_ID.ToString()), "0", _
                                            Me.WCD_ID.SelectedValue.ToString(), _
                                            DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                                            ": " & sRemark)

                                            Exit For 'only once since only a single approver can return stuff
                                        Next
                                    End If
                                End If

                            End If
                        Else 'just set current user status to 'Approved'
                            'note: this routine: requires another user to approve for the WF to move, so just update user's status
                            Dim wc5 As WhereClause = New WhereClause

                            wc5.iAND(WCAR_ActivityTable.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                            wc5.iAND(WCAR_ActivityTable.WCA_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("ActivityUserID").ToString())
                            wc5.iAND(WCAR_ActivityTable.WCA_Status, BaseFilter.ComparisonOperator.EqualsTo, "Pending")
                            wc5.iAND(WCAR_ActivityTable.WCA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                            If WCAR_ActivityTable.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                                For Each itemValue5 As WCAR_ActivityRecord In WCAR_ActivityTable.GetRecords(wc5, Nothing, 0, 100)
                                    'note: update Activity table (current user) -> 'Approved'
                                    WCAR_ActivityRecord.UpdateRecord(itemValue5.WCA_ID.ToString(), "Approved")
                                Next
                            End If
                        End If
                    Case 1 'Rejected ---------------------------------------------------------------------------------------------
                        'note: update other user status -> 'System Rejected'
                        Dim wc4 As WhereClause = New WhereClause

                        wc4.iAND(WCAR_ActivityTable.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                        wc4.iAND(WCAR_ActivityTable.WCA_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("ActivityUserID").ToString())
                        wc4.iAND(WCAR_ActivityTable.WCA_Status, BaseFilter.ComparisonOperator.EqualsTo, "Pending")
                        wc4.iAND(WCAR_ActivityTable.WCA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                        For Each itemValue4 As WCAR_ActivityRecord In WCAR_ActivityTable.GetRecords(wc4, Nothing, 0, 100)
                            'note: update Activity table (other user(s) if multiple approvers) -> 'System Rejected'
                            WCAR_ActivityRecord.UpdateRecord(itemValue4.WCA_ID.ToString(), "System Rejected")
                        Next
                        'note: update current task status -> 'Rejected
                        Dim wc5 As WhereClause = New WhereClause

                        wc5.iAND(WCAR_ActivityTable.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                        wc5.iAND(WCAR_ActivityTable.WCA_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("ActivityUserID").ToString())
                        wc5.iAND(WCAR_ActivityTable.WCA_Status, BaseFilter.ComparisonOperator.EqualsTo, "Pending")
                        wc5.iAND(WCAR_ActivityTable.WCA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                        If WCAR_ActivityTable.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                            For Each itemValue5 As WCAR_ActivityRecord In WCAR_ActivityTable.GetRecords(wc5, Nothing, 0, 100)
                                'note: update Activity table (current user) -> 'Rejected'
                                WCAR_ActivityRecord.UpdateRecord(itemValue5.WCA_ID.ToString(), "Rejected")
                            Next
                        End If
                        'note: insert user(s) to Activity using the chosen Return To field
                        Dim wc6 As WhereClause = New WhereClause

                        If ddlMoveto.SelectedValue.ToString() <> "0" Then 'not the creator
                            wc6.iAND(Sel_WStep_WStep_DetailView.WS_ID, BaseFilter.ComparisonOperator.EqualsTo, ddlMoveto.SelectedValue.ToString())

                            For Each itemValue6 As Sel_WStep_WStep_DetailRecord In Sel_WStep_WStep_DetailView.GetRecords(wc6, Nothing, 0, 100)
                                'note: use returned items to insert to Activity table
                                'note: do not insert(update) delegate until task expires
                                Dim sRemark As String = txtRemark.Text

                                WCAR_ActivityRecord.AddRecord(itemValue6.WS_ID.ToString(), itemValue6.WSD_ID.ToString(), _
                                Me.WCD_WDT_ID.SelectedValue.ToString(), _
                                FindDelegate(itemValue6.WSD_W_U_ID.ToString()), "0", _
                                Me.WCD_ID.SelectedValue.ToString(), _
                                DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                                ": " & sRemark)

                                'email to Returned user								
                                Dim sUserRej As String = System.Web.HttpContext.Current.Session("UserFullName").ToString()
                                Dim sInfo As String = ""
                                Dim sDelegate As String = FindDelegate(itemValue6.WSD_W_U_ID.ToString(), sInfo)

                                sEmailContent = Content_Formatter(sDelegate, _
                                "CAR Approval Needed (CAR# " & Me.WCD_No.Text & ")", Me.WCD_C_ID.SelectedItem.ToString(), _
                                Me.WCD_Project_Title.Text, Me.WCD_Request_Date.Text, Me.WCD_Remark.Text, Me.WCD_Exp_Cur_Yr.Text, _
                                sCreator_ID, "#f46f6f", "wf_car/ShowSel_WCAR_Activity_WCAR_DocTable.aspx", Me.WCD_No.Text, _
                                sRemark, "Returned By " & sUserRej, "CAR")

                                Send_Email_Notification(sDelegate, "CAR Approval Needed (CAR# " & _
                                Me.WCD_No.Text & ")" & sInfo, sEmailContent)
                            Next
                        Else
                            'note: if the 1st step rejected the task and the task has nowhere to go -> set the document's
                            'submitted status to 'False' and set Doc Status to 'For Review' this enables the user(Creator)
                            'to submit the Document again.
                            wc6.iAND(WCAR_DocTable.WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                            For Each itemValue6 As WCAR_DocRecord In WCAR_DocTable.GetRecords(wc6, Nothing, 0, 100)
                                Dim sRemark As String = txtRemark.Text
                                WCAR_DocRecord.UpdateRecord_Status_Submit(itemValue6.WCD_ID.ToString(), "For Review", "0", _
                                DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                                ": " & sRemark)

                                Dim sUserRej As String = System.Web.HttpContext.Current.Session("UserFullName").ToString()

                                sEmailContent = Content_Formatter(itemValue6.WCD_U_ID.ToString(), _
                                "CAR Approval Needed (CAR# " & Me.WCD_No.Text & ")", Me.WCD_C_ID.SelectedItem.ToString(), _
                                Me.WCD_Project_Title.Text, Me.WCD_Request_Date.Text, Me.WCD_Remark.Text, Me.WCD_Exp_Cur_Yr.Text, _
                                sCreator_ID, "#f46f6f", "wf_car/ShowWCAR_DocTable.aspx", Me.WCD_No.Text, _
                                sRemark, "Returned By " & sUserRej, "CAR", "CAR Creator")

                                Send_Email_Notification(itemValue6.WCD_U_ID.ToString(), "CAR Information Needed (CAR# " & _
                                Me.WCD_No.Text & ")", sEmailContent)
                            Next
                        End If
                    Case 2 'Voided -----------------------------------------------------------------------------------------------
                        'note: void other user's status if status = 'Pending'
                        'note: if 1 user voided the trx then wf fails
                        'note: update CAR doc status -> 'Failed'
                        Dim wc4 As WhereClause = New WhereClause

                        wc4.iAND(WCAR_ActivityTable.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                        wc4.iAND(WCAR_ActivityTable.WCA_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("ActivityUserID").ToString())
                        wc4.iAND(WCAR_ActivityTable.WCA_Status, BaseFilter.ComparisonOperator.EqualsTo, "Pending")
                        wc4.iAND(WCAR_ActivityTable.WCA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                        For Each itemValue4 As WCAR_ActivityRecord In WCAR_ActivityTable.GetRecords(wc4, Nothing, 0, 100)
                            'note: update Activity table (other user(s) if multiple approvers) -> 'System Voided'
                            WCAR_ActivityRecord.UpdateRecord(itemValue4.WCA_ID.ToString(), "System Voided")
                        Next

                        Dim wc5 As WhereClause = New WhereClause

                        wc5.iAND(WCAR_ActivityTable.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                        wc5.iAND(WCAR_ActivityTable.WCA_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("ActivityUserID").ToString())
                        wc5.iAND(WCAR_ActivityTable.WCA_Status, BaseFilter.ComparisonOperator.EqualsTo, "Pending")
                        wc5.iAND(WCAR_ActivityTable.WCA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                        If WCAR_ActivityTable.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                            For Each itemValue5 As WCAR_ActivityRecord In WCAR_ActivityTable.GetRecords(wc5, Nothing, 0, 100)
                                'note: update Activity table (current user) -> 'Voided'
                                WCAR_ActivityRecord.UpdateRecord(itemValue5.WCA_ID.ToString(), "Voided")
                            Next
                        End If
                        'note: void CAR
                        Dim wc6 As WhereClause = New WhereClause
                        wc6.iAND(WCAR_DocTable.WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                        For Each itemValue6 As WCAR_DocRecord In WCAR_DocTable.GetRecords(wc6, Nothing, 0, 100)
                            WCAR_DocRecord.UpdateRecord(itemValue6.WCD_ID.ToString(), "Failed")

                            Dim sUserRej As String = System.Web.HttpContext.Current.Session("UserFullName").ToString()
                            'Dim sInfo As String = ""							
                            'Dim sDelegate As String = FindDelegate(itemValue6.WSD_W_U_ID.ToString(), sInfo)

                            sEmailContent = Content_Formatter(itemValue6.WCD_U_ID.ToString(), _
                            "CAR Approval Needed (CAR# " & Me.WCD_No.Text & ")", Me.WCD_C_ID.SelectedItem.ToString(), _
                            Me.WCD_Project_Title.Text, Me.WCD_Request_Date.Text, Me.WCD_Remark.Text, Me.WCD_Exp_Cur_Yr.Text, _
                            sCreator_ID, "#f46f6f", "wf_car/ShowSel_WCAR_Activity_WCAR_DocTable.aspx", Me.WCD_No.Text, _
                            "Document Void", "Voided By " & sUserRej, "CAR")

                            Send_Email_Notification(itemValue6.WCD_U_ID.ToString(), "CAR Voided (CAR# " & _
                            Me.WCD_No.Text & ")", sEmailContent)
                        Next
                        ''added Case 3 for Return Status **pepanes 09.20.2013
                    Case 3 '### Return ###
                        Dim wc4 As WhereClause = New WhereClause

                        wc4.iAND(WCAR_ActivityTable.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                        wc4.iAND(WCAR_ActivityTable.WCA_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("ActivityUserID").ToString())
                        wc4.iAND(WCAR_ActivityTable.WCA_Status, BaseFilter.ComparisonOperator.EqualsTo, "Pending")
                        wc4.iAND(WCAR_ActivityTable.WCA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                        For Each itemValue4 As WCAR_ActivityRecord In WCAR_ActivityTable.GetRecords(wc4, Nothing, 0, 100)
                            'note: update Activity table (other user(s) if multiple approvers) -> 'Return'
                            WCAR_ActivityRecord.UpdateRecord(itemValue4.WCA_ID.ToString(), "Return")
                        Next

                        Dim wc5 As WhereClause = New WhereClause

                        wc5.iAND(WCAR_ActivityTable.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                        wc5.iAND(WCAR_ActivityTable.WCA_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("ActivityUserID").ToString())
                        wc5.iAND(WCAR_ActivityTable.WCA_Status, BaseFilter.ComparisonOperator.EqualsTo, "Pending")
                        wc5.iAND(WCAR_ActivityTable.WCA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                        If WCAR_ActivityTable.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                            For Each itemValue5 As WCAR_ActivityRecord In WCAR_ActivityTable.GetRecords(wc5, Nothing, 0, 100)
                                WCAR_ActivityRecord.UpdateRecord(itemValue5.WCA_ID.ToString(), "Return")
                            Next
                        End If

                        'Dim wc6 As WhereClause = New WhereClause
                        'wc6.iAND(WCAR_DocTable.WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                        'For Each itemValue6 As WCAR_DocRecord In WCAR_DocTable.GetRecords(wc6, Nothing, 0, 100)
                        '    Dim sRemark As String = txtRemark.Text
                        '    WCAR_DocRecord.UpdateRecord_Status_Submit(itemValue6.WCD_ID.ToString(), "Return", "0", _
                        '    DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                        '    "(Return): " & sRemark)

                        '    Dim sUserRej As String = System.Web.HttpContext.Current.Session("FullName").ToString()

                        '    sEmailContent = Content_Formatter(itemValue6.WCD_U_ID.ToString(), _
                        '    "CAR Information Needed (CAR# " & Me.WCD_No.Text & ")", Me.WCD_C_ID.SelectedItem.ToString(), _
                        '    Me.WCD_Project_Title.Text, Me.WCD_Request_Date.Text, Me.WCD_Remark.Text, Me.WCD_Exp_Cur_Yr.Text, _
                        '    sCreator_ID, "#f46f6f", "wf_car/ShowWCAR_DocTable.aspx", Me.WCD_No.Text, _
                        '    sRemark, "Returned By " & sUserRej, "CAR", "CAR Creator")

                        '    Send_Email_Notification(itemValue6.WCD_U_ID.ToString(), "CAR Information Needed (CAR# " & _
                        '    Me.WCD_No.Text & ")", sEmailContent)
                        'Next
                        ''04.02.2014 - pepanes **gftey
                        Dim wc6 As WhereClause = New WhereClause '--------added:3/13/14 enables approver to select a user for Return status

                        If ddlMoveto.SelectedValue.ToString() <> "0" Then 'not the creator
                            wc6.iAND(Sel_WStep_WStep_DetailView.WS_ID, BaseFilter.ComparisonOperator.EqualsTo, ddlMoveto.SelectedValue.ToString())

                            For Each itemValue6 As Sel_WStep_WStep_DetailRecord In Sel_WStep_WStep_DetailView.GetRecords(wc6, Nothing, 0, 100)
                                'note: use returned items to insert to Activity table
                                'note: do not insert(update) delegate until task expires
                                Dim sRemark As String = txtRemark.Text
                                'bahala na balik-balik
                                'make the doc as 'return' for easier approving process
                                WCAR_DocRecord.UpdateRecord_Status_Submit(Me.WCD_ID.Text, "Return", "1", _
                                                        DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                                                        ": " & sRemark)

                                WCAR_ActivityRecord.AddRecord(itemValue6.WS_ID.ToString(), itemValue6.WSD_ID.ToString(), _
                                Me.WCD_WDT_ID.SelectedValue.ToString(), _
                                FindDelegate(itemValue6.WSD_W_U_ID.ToString()), "0", _
                                Me.WCD_ID.SelectedValue.ToString(), _
                                DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                                ": " & sRemark)

                                'email to Returned user								
                                Dim sUserRej As String = System.Web.HttpContext.Current.Session("UserFullName").ToString()
                                Dim sInfo As String = ""
                                Dim sDelegate As String = FindDelegate(itemValue6.WSD_W_U_ID.ToString(), sInfo)

                                sEmailContent = Content_Formatter(sDelegate, _
                                "CAR Approval Needed (CAR# " & Me.WCD_No.Text & ")", Me.WCD_C_ID.SelectedItem.ToString(), _
                                Me.WCD_Project_Title.Text, Me.WCD_Request_Date.Text, Me.WCD_Remark.Text, Me.WCD_Exp_Cur_Yr.Text, _
                                sCreator_ID, "#f46f6f", "wf_car/ShowSel_WCAR_Activity_WCAR_DocTable.aspx", Me.WCD_No.Text, _
                                sRemark, "Returned By " & sUserRej, "CAR")

                                Send_Email_Notification(sDelegate, "CAR Approval Needed (CAR# " & _
                                Me.WCD_No.Text & ")" & sInfo, sEmailContent)
                            Next
                        Else
                            'note: if the 1st step rejected the task and the task has nowhere to go -> set the document's
                            'submitted status to 'False' and set Doc Status to 'For Review' this enables the user(Creator)
                            'to submit the Document again.
                            wc6.iAND(WCAR_DocTable.WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                            For Each itemValue6 As WCAR_DocRecord In WCAR_DocTable.GetRecords(wc6, Nothing, 0, 100)
                                Dim sRemark As String = txtRemark.Text
                                WCAR_DocRecord.UpdateRecord_Status_Submit(itemValue6.WCD_ID.ToString(), "Return", "0", _
                                DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                                ": " & sRemark)

                                Dim sUserRej As String = System.Web.HttpContext.Current.Session("UserFullName").ToString()

                                sEmailContent = Content_Formatter(itemValue6.WCD_U_ID.ToString(), _
                                "CAR Information Needed (CAR# " & Me.WCD_No.Text & ")", Me.WCD_C_ID.SelectedItem.ToString(), _
                                Me.WCD_Project_Title.Text, Me.WCD_Request_Date.Text, Me.WCD_Remark.Text, Me.WCD_Exp_Cur_Yr.Text, _
                                sCreator_ID, "#f46f6f", "wf_car/ShowWCAR_DocTable.aspx", Me.WCD_No.Text, _
                                sRemark, "Returned By " & sUserRej, "CAR", "CAR Creator")

                                Send_Email_Notification(itemValue6.WCD_U_ID.ToString(), "CAR Information Needed (CAR# " & _
                                Me.WCD_No.Text & ")", sEmailContent)
                            Next
                        End If
                End Select

                'SaveButton_Click_Base(sender, args)
                'note: instead of using the save button to redirect, do it manually coz it causes errors ('user already modified the record')
                If ddlMoveTo.Items.Count > 0 Then

                    'RegisterAlert
                    Utils.MiscUtils.RegisterJScriptAlert(Me, "Success", "Selected workflow settings were successfully applied to CAR No: " & Me.WCD_No.Text & "." & _
                    vbCrLf & vbCrLf & "Action: " & ddlAction.Text & vbCrLf & "Returned To: " & ddlMoveto.SelectedItem.Text())
                Else
                    Utils.MiscUtils.RegisterJScriptAlert(Me, "Success", "Selected workflow settings were successfully applied to CAR No: " & Me.WCD_No.Text & "." & _
                    vbCrLf & vbCrLf & "Action: " & ddlAction.Text)
                End If

                'Dim url As String = "../wf_car/ShowSel_WCAR_Activity_WCAR_DocTable.aspx?"
                Dim url As String = "../Security/Homepage.aspx?"

                url = Me.ModifyRedirectUrl(url, "")

                Me.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)

            Else

                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", "Transaction was already recorded for this task due to these following reasons:" & _
                vbCrLf & vbCrLf & "1) The number of approvers needed to approve/reject was fulfilled." & vbCrLf & _
                "2) The creator voided this document." & vbCrLf & _
                "3) Another approver already voided this document." & vbcrlf & vbcrlf & "Contact MIS for more details regarding this message.")
            End If

            'SaveButton_Click_Base(sender, args)
        End Sub

        Protected Sub ddlAction_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlAction.SelectedIndexChanged
            ''04.02.2014 pepanes **gftey
            ''Enable Return To dropdown list if action selected is "Reject" or "Return"
            If ddlAction.SelectedIndex = 1 Or ddlAction.SelectedIndex = 3 Then
                ddlMoveto.Enabled = True
                txtRemark.Enabled = True

                Me.ddlMoveto.Items.Clear()
                'note: this populates the Return To drop down
                Dim wc1 As WhereClause = New WhereClause
                wc1.iAND(WCAR_ActivityTable.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                wc1.iAND(WCAR_ActivityTable.WCA_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("ActivityUserID").ToString())
                wc1.iAND(WCAR_ActivityTable.WCA_Status, BaseFilter.ComparisonOperator.EqualsTo, "Pending")
                'wc1.iOR(WCAR_ActivityTable.WCA_W_U_ID_Delegate, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserID").ToString())

                Dim itemValue1 As WCAR_ActivityRecord
                Dim bNoParent As Boolean = False
                Dim sStepID As String = ""
                Dim sStepType As String = ""
                For Each itemValue1 In WCAR_ActivityTable.GetRecords(wc1, Nothing, 0, 100)
                    If (itemValue1.WCA_WS_IDSpecified) Then
                        sStepID = itemValue1.WCA_WS_ID.ToString()

                        Do While sStepType <> "Start"
                            Dim wc2 As WhereClause = New WhereClause
                            Dim itemValue2 As WStepRecord
                            wc2.iAND(WStepTable.WS_ID_Next, BaseFilter.ComparisonOperator.EqualsTo, sStepID)


                            If WStepTable.GetRecords(wc2, Nothing, 0, 100).Length > 0 Then
                                For Each itemValue2 In WStepTable.GetRecords(wc2, Nothing, 0, 100)
                                    If itemValue2.WS_IDSpecified Then
                                        Dim cvalue As String = Nothing
                                        Dim fvalue As String = Nothing

                                        cvalue = itemValue2.WS_ID.ToString()
                                        fvalue = itemValue2.WS_Desc.ToString()
                                        sStepID = cvalue
                                        sStepType = itemValue2.WS_Step_Type

                                        Dim item As ListItem = New ListItem(fvalue, cvalue)
                                        Me.ddlMoveto.Items.Add(item)
                                    End If
                                Next
                            Else
                                sStepType = "Start"
                            End If
                        Loop
                    End If
                Next

                Dim cvalue1 As String = Nothing
                Dim fvalue1 As String = Nothing

                cvalue1 = "0"
                fvalue1 = Me.WCD_U_ID.Text '"Creator"

                Dim item1 As ListItem = New ListItem(fvalue1, cvalue1)
                Me.ddlMoveto.Items.Add(item1)

                If Me.ddlMoveto.Items.Count > 0 Then
                    'note: default to first step
                    Me.ddlMoveto.SelectedIndex = Me.ddlMoveto.Items.Count - 1
                End If
            Else
                ddlMoveto.Items.Clear()
                ddlMoveto.Enabled = False
                txtRemark.Enabled = True
            End If
        End Sub

        Private Function Content_Formatter(User_ID As String, Title As String, Company As String, Details As String, _
        DocDate As String, Remarks As String, Total As String, Requester_ID As String, Color_Hex As String, _
        Page As String, Document As String, ApproverRem As String, Status As String, WF_Type As String, Optional Default_Type As String = "") As String
            Dim wc2 As WhereClause = New WhereClause
            Dim itemValue2 As W_EmailRecord
            Dim sDirectory As String
            Dim sSite As String
            Dim sTemplate As String

            If Default_Type = "" Then
                wc2.iAND(W_EmailTable.WE_U_ID, BaseFilter.ComparisonOperator.EqualsTo, User_ID)

                If W_EmailTable.GetRecords(wc2, Nothing, 0, 100).Length > 0 Then
                    For Each itemValue2 In W_EmailTable.GetRecords(wc2, Nothing, 0, 100)
                        If itemValue2.WE_U_IDSpecified Then
                            sDirectory = itemValue2.WE_Directory.ToString()
                            sSite = itemValue2.WE_Site.ToString()
                            sTemplate = itemValue2.WE_Template.ToString()
                        End If
                    Next
                End If
            Else
                wc2.iAND(W_Email_DefaultTable.WED_Type, BaseFilter.ComparisonOperator.EqualsTo, Default_Type)

                If W_Email_DefaultTable.GetRecords(wc2, Nothing, 0, 100).Length > 0 Then
                    For Each itemValue21 As W_Email_DefaultRecord In W_Email_DefaultTable.GetRecords(wc2, Nothing, 0, 100)
                        If itemValue21.WED_IDSpecified Then
                            sDirectory = "eportal" 'itemValue21.WE_Directory.ToString()
                            sSite = "http://eportal.anflocor.com" 'itemValue21.WE_Site.ToString()
                            sTemplate = itemValue21.WED_Template.ToString()
                        End If
                    Next
                End If
            End If

            sTemplate = Replace(sTemplate, "@TITLE", Title)
            sTemplate = Replace(sTemplate, "@COM", Company)
            sTemplate = Replace(sTemplate, "@DET", Details)
            sTemplate = Replace(sTemplate, "@DTE", DocDate)
            sTemplate = Replace(sTemplate, "@REM", Remarks)
            sTemplate = Replace(sTemplate, "@TOT", Total)
            sTemplate = Replace(sTemplate, "@SITE", sSite)
            sTemplate = Replace(sTemplate, "@LOC", sDirectory)

            Dim wc3 As WhereClause = New WhereClause
            Dim itemValue3 As W_UserRecord
            Dim sFullName As String 'creator
            Dim sUserEmail As String 'creator
            wc3.iAND(W_UserTable.W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, Requester_ID)

            If W_UserTable.GetRecords(wc3, Nothing, 0, 100).Length > 0 Then
                For Each itemValue3 In W_UserTable.GetRecords(wc3, Nothing, 0, 100)
                    If itemValue3.W_U_IDSpecified Then
                        sFullName = itemValue3.W_U_Full_Name.ToString()
                        sUserEmail = itemValue3.W_U_Email.ToString()
                    End If
                Next
            End If

            sTemplate = Replace(sTemplate, "@USR", sUserEmail)
            sTemplate = Replace(sTemplate, "@REQ", sFullName)

            sTemplate = Replace(sTemplate, "@PAGE", Page)
            sTemplate = Replace(sTemplate, "@DOC", "CAR# " & Document)
            sTemplate = Replace(sTemplate, "@COLOR", Color_Hex)
            sTemplate = Replace(sTemplate, "@APPREM", ApproverRem)
            sTemplate = Replace(sTemplate, "@STAT", Status)
            sTemplate = Replace(sTemplate, "@WF", WF_Type)

            Return sTemplate
        End Function

        Private Sub Send_Email_Notification(ByVal SendTo_User_ID As String, ByVal Subject As String, ByVal Content As String)
            Dim sEmail As String = ""

            Try

                Dim wc2 As WhereClause = New WhereClause
                Dim itemValue2 As W_UserRecord
                wc2.iAND(W_UserTable.W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, SendTo_User_ID)

                If W_UserTable.GetRecords(wc2, Nothing, 0, 100).Length > 0 Then
                    For Each itemValue2 In W_UserTable.GetRecords(wc2, Nothing, 0, 100)
                        If itemValue2.W_U_IDSpecified Then
                            sEmail = itemValue2.W_U_Email.ToString()
                        End If
                    Next
                End If

                Dim email As New BaseClasses.Utils.MailSender

                email.AddFrom("noreply@anflocor.com")
                email.AddTo(sEmail)
                email.SetSubject(Subject)
                email.SetContent(Content)
                email.SetIsHtmlContent(True)
                email.SendMessage()
            Catch ex As Exception
                'RegisterAlert(Me.Title, ex.Message, True)
                Utils.MiscUtils.RegisterJScriptAlert(Me, "Error", ex.Message)
            End Try
        End Sub


      Private Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS as Boolean) As String
          Return EvaluateFormula_Base(formula, dataSourceForEvaluate, format, variables, includeDS)
      End Function

      Public Sub Page_InitializeEventHandlers(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
            ' Handles MyBase.Init. 
            ' Register the Event handler for any Events.
           Me.Page_InitializeEventHandlers_Base(sender,e)
      End Sub
      
        Protected Overrides Sub SaveControlsToSession()
            SaveControlsToSession_Base()
        End Sub

        Protected Overrides Sub ClearControlsFromSession()
            ClearControlsFromSession_Base()
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            LoadViewState_Base(savedState)
        End Sub


        Protected Overrides Function SaveViewState() As Object
            Return SaveViewState_Base()
        End Function
      
      Public Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
          Me.Page_PreRender_Base(sender,e)
      End Sub


      
      Public Overrides Sub SaveData()
          Me.SaveData_Base()
      End Sub
               
               

      Public Overrides Sub SetControl(ByVal control As String)
          Me.SetControl_Base(control)
      End Sub    
      
      
      Public Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit
          'Override call to PreInit_Base() here to change top level master page used by this page.
          'For example for SharePoint applications uncomment next line to use Microsoft SharePoint default master page
          'If Not Me.Master Is Nothing Then Me.Master.MasterPageFile = Microsoft.SharePoint.SPContext.Current.Web.MasterUrl	
          'You may change here assignment of application theme
          Try
              Me.PreInit_Base()
          Catch ex As Exception
          
          End Try			  
      End Sub
      
#Region "Ajax Functions"

        <System.Web.Services.WebMethod()> _
        Public Shared Function GetRecordFieldValue(ByVal tableName As String, _
                                                  ByVal recordID As String, _
                                                  ByVal columnName As String, _
                                                  ByVal fieldName As String, _
                                                  ByVal title As String, _
                                                  ByVal closeBtnText As String, _
                                                  ByVal persist As Boolean, _
                                                  ByVal popupWindowHeight As Integer, _
                                                  ByVal popupWindowWidth As Integer, _
                                                  ByVal popupWindowScrollBar As Boolean _
                                                  ) As Object()
            ' GetRecordFieldValue gets the pop up window content from the column specified by
            ' columnName in the record specified by the recordID in data base table specified by tableName.
            ' Customize by adding code before or after the call to  GetRecordFieldValue_Base()
            ' or replace the call to  GetRecordFieldValue_Base().
            Return GetRecordFieldValue_Base(tableName, recordID, columnName, fieldName, title, closeBtnText, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
        End Function

        <System.Web.Services.WebMethod()> _
        Public Shared Function GetImage(ByVal tableName As String, _
                                        ByVal recordID As String, _
                                        ByVal columnName As String, _
                                        ByVal title As String, _
                                        ByVal closeBtnText As String, _
                                        ByVal persist As Boolean, _
                                        ByVal popupWindowHeight As Integer, _
                                        ByVal popupWindowWidth As Integer, _
                                        ByVal popupWindowScrollBar As Boolean _
                                        ) As Object()
            ' GetImage gets the Image url for the image in the column "columnName" and
            ' in the record specified by recordID in data base table specified by tableName.
            ' Customize by adding code before or after the call to  GetImage_Base()
            ' or replace the call to  GetImage_Base().
            Return GetImage_Base(tableName, recordID, columnName, title, closeBtnText, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
        End Function
    
      Protected Overloads Overrides Sub BasePage_PreRender(ByVal sender As Object, ByVal e As EventArgs)
          MyBase.BasePage_PreRender(sender, e)
          Base_RegisterPostback()
      End Sub
      
    
      


#End Region

    ' Page Event Handlers - buttons, sort, links
    

        ' Write out the Set methods
                     
        
        ' Write out the methods for DataSource
        
   

Public Sub SetWCAR_DocRecordControl()
            SetWCAR_DocRecordControl_Base() 
        End Sub
#End Region

#Region "Section 2: Do not modify this section."

        Protected Sub Page_InitializeEventHandlers_Base(ByVal sender As Object, ByVal e As System.EventArgs)            		
           
            ' This page does not have FileInput  control inside repeater which requires "multipart/form-data" form encoding, but it might
            'include ascx controls which in turn do have FileInput controls inside repeater. So check if they set Enctype property.
            If Not String.IsNullOrEmpty(Me.Enctype) Then Me.Page.Form.Enctype = Me.Enctype
          
            ' Register the Event handler for any Events.
      

          ' Setup the pagination events.
        
          Me.ClearControlsFromSession()
    
          System.Web.HttpContext.Current.Session("isd_geo_location") = "<location><error>LOCATION_ERROR_DISABLED</error></location>"
    
          Dim Include As System.Web.UI.HtmlControls.HtmlGenericControl = New System.Web.UI.HtmlControls.HtmlGenericControl("script")
          Include.Attributes.Add("type", "text/javascript")
          Include.InnerHtml = "var IsInfinitePage = true; var sessvar = ""is_loaded"";if (window.frameElement != null) {sessvar = ""is_loaded"" +window.frameElement.id;}var iframeName = """";var bolea = ""False"";if(window.frameElement != null){iframeName =window.frameElement.id;}if(iframeName.indexOf(""Infiniteframe"") == -1){bolea = ""True"";}if (bolea == ""True"") {if(!sessionStorage.getItem(sessvar) || sessionStorage.getItem(sessvar) == ""False"") {sessionStorage.setItem(sessvar, ""True"");}else {var htmlurl = window.location.href; if(htmlurl.indexOf(""?InfiIframe"") != -1){htmlurl = htmlurl.replace(""?InfiIframe"","""");}else{if(htmlurl.indexOf(""&InfiIframe"") != -1){htmlurl = htmlurl.replace(""&InfiIframe"", """");}} window.location.href =htmlurl;if (navigator.appName == 'Microsoft Internet Explorer'){window.location.href = htmlurl;}sessionStorage.setItem(sessvar, ""False"");}}else{if (bolea == ""False"") {window.alert = function() {};}}"
          Include.ID = "InfiScript"
          Me.Page.Header.Controls.Add(Include)
    
        End Sub

        Private Sub Base_RegisterPostback()
        
        End Sub

    

       ' Handles MyBase.Load.  Read database data and put into the UI controls.
       ' If you need to, you can add additional Load handlers in Section 1.
       Protected Overridable Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    
           If Me.FindControlRecursively("Infiniteframe") Is Nothing Then
                Dim RmvControl As Control = Me.FindControlRecursively("InfiScript")
                Me.Page.Header.Controls.Remove(RmvControl)
           End If
           
           Me.SetPageFocus()
           
            ' Check if user has access to this page.  Redirects to either sign-in page
            ' or 'no access' page if not. Does not do anything if role-based security
            ' is not turned on, but you can override to add your own security.
            Me.Authorize("NOT_ANONYMOUS")
			Me.Authorize(Ctype(WCAR_DocRecordControl, Control), "NOT_ANONYMOUS")
					
    
            If (Not Me.IsPostBack) Then
            
                ' Setup the header text for the validation summary control.
                Me.ValidationSummary1.HeaderText = GetResourceValue("ValidationSummaryHeaderText", "ePortalWFApproval")
              
            End If
           
            ' Load data only when displaying the page for the first time or if postback from child window
            If (Not Me.IsPostBack OrElse Me.Request("__EVENTTARGET") = "ChildWindowPostBack" OrElse ( Me.Request("__EVENTTARGET") = "isd_geo_location")) Then
                ' Read the data for all controls on the page.
                ' To change the behavior, override the DataBind method for the individual
                ' record or table UI controls.
                Me.LoadData()
            End If
        
        
            Page.Title = "ePortal Workflow Approval - CAR Approval (South)"
        If Not IsPostBack Then
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(Me, Me.GetType(), "PopupScript", "openPopupPage('QPageSize');", True)
        End If
    

    End Sub

    Public Shared Function GetRecordFieldValue_Base(ByVal tableName As String, _
                ByVal recordID As String, _
                ByVal columnName As String, _
                ByVal fieldName As String, _
                ByVal title As String, _
                ByVal closeBtnText As String, _
                ByVal persist As Boolean, _
                ByVal popupWindowHeight As Integer, _
                ByVal popupWindowWidth As Integer, _
                ByVal popupWindowScrollBar As Boolean _
                ) As Object()
        If Not IsNothing(recordID) Then
            recordID = System.Web.HttpUtility.UrlDecode(recordID)
        End If
        Dim content as String = BaseClasses.Utils.MiscUtils.GetFieldData(tableName, recordID, columnName)
    
        content = NetUtils.EncodeStringForHtmlDisplay(content)

        ' returnValue is an array of string values.
        ' returnValue(0) represents title of the pop up window.
        ' returnValue(1) represents the tooltip of the close button.
        ' returnValue(2) represents content of the text.
        ' returnValue(3) represents whether pop up window should be made persistant
        ' or it should close as soon as mouse moves out.
        ' returnValue(4), (5) represents pop up window height and width respectivly
        ' returnValue(6) represents whether pop up window should contain scroll bar.
        ' They can be modified by going to Attribute tab of the properties window of the control in aspx page.
        Dim returnValue(6) As Object
        returnValue(0) = title
        returnValue(1) = closeBtnText
        returnValue(2) = content
        returnValue(3) = persist
        returnValue(4) = popupWindowWidth
        returnValue(5) = popupWindowHeight
        returnValue(6) = popupWindowScrollBar
        Return returnValue
    End Function


    Public Shared Function GetImage_Base(ByVal tableName As String, _
                                    ByVal recordID As String, _
                                    ByVal columnName As String, _
                                    ByVal title As String, _
                                    ByVal closeBtnText As String, _
                                    ByVal persist As Boolean, _
                                    ByVal popupWindowHeight As Integer, _
                                    ByVal popupWindowWidth As Integer, _
                                    ByVal popupWindowScrollBar As Boolean _
                                    ) As Object()
        Dim content As String = "<IMG alt =""" & title & """ src =" & """../Shared/ExportFieldValue.aspx?Table=" & tableName & "&Field=" & columnName & "&Record=" & recordID & """/>"
        ' returnValue is an array of string values.
        ' returnValue(0) represents title of the pop up window.
        ' returnValue(1) represents the tooltip of the close button.
        ' returnValue(2) represents content ie, image url.
        ' returnValue(3) represents whether pop up window should be made persistant
        ' or it should close as soon as mouse moves out.
        ' returnValue(4), (5) represents pop up window height and width respectivly
        ' returnValue(6) represents whether pop up window should contain scroll bar.
        ' They can be modified by going to Attribute tab of the properties window of the control in aspx page.
        Dim returnValue(7) As Object
        returnValue(0) = title
        returnValue(1) = closeBtnText
        returnValue(2) = content
        returnValue(3) = persist
        returnValue(4) = popupWindowWidth
        returnValue(5) = popupWindowHeight
        returnValue(6) = popupWindowScrollBar
        Return returnValue
    End Function
        
      Public Sub SetControl_Base(ByVal control As String)
          ' Load data for each record and table UI control.
        
          Select Case control
          
              Case "WCAR_DocRecordControl"
                 SetWCAR_DocRecordControl()
               
          End Select
        
      End Sub          


    
      
      Public Sub SaveData_Base()
              
        Me.WCAR_DocRecordControl.SaveData()
        
      End Sub
      
      

    
    
        Protected Sub SaveControlsToSession_Base()
            MyBase.SaveControlsToSession()
        
        End Sub


        Protected Sub ClearControlsFromSession_Base()
            MyBase.ClearControlsFromSession()
        
        End Sub

        Protected Sub LoadViewState_Base(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)
        
        End Sub


        Protected Function SaveViewState_Base() As Object
            
            Return MyBase.SaveViewState()
        End Function


      Public Sub PreInit_Base()
      'If it is SharePoint application this function performs dynamic Master Page assignment.
      
            ' if url parameter specified a master apge, load it here

            
            If DirectCast(Me.Page, BaseApplicationPage).GetDecryptedURLParameter("RedirectStyle")  = "Popup" Then
                Dim masterPage As String = "../Master Pages/Popup.master"      
                Me.Page.MasterPageFile = masterPage
            End If            
            
            If DirectCast(Me.Page, BaseApplicationPage).GetDecryptedURLParameter("RedirectStyle")  = "NewWindow" Then
                Dim masterPage As String = "../Master Pages/Blank.master"      
                Me.Page.MasterPageFile = masterPage
            End If                        
            
            If Me.Page.Request("MasterPage") <> "" Then
                Dim masterPage As String = DirectCast(Me.Page, BaseApplicationPage).GetDecryptedURLParameter("MasterPage")          
                Me.Page.MasterPageFile = masterPage
            End If         
                  
    
      End Sub
      
      Public Sub Page_PreRender_Base(ByVal sender As Object, ByVal e As System.EventArgs)
     
          If DirectCast(Me.Page, BaseApplicationPage).GetDecryptedURLParameter("RedirectStyle")  = "Popup" Then
              AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(Me, Me.GetType(), "QPopupCreateHeader", "QPopupCreateHeader();", True)
          End If
          
    
            ' Load data for each record and table UI control.
                  
            ' Data bind for each chart UI control.
              
      End Sub  
      
        
        ' Load data from database into UI controls.
        ' Modify LoadData in Section 1 above to customize.  Or override DataBind() in
        ' the individual table and record controls to customize.
        Public Sub LoadData_Base()
            Try
              
                If (Not Me.IsPostBack OrElse Me.Request("__EVENTTARGET") = "ChildWindowPostBack" OrElse ( Me.Request("__EVENTTARGET") = "isd_geo_location"))  Then
                    ' Must start a transaction before performing database operations
                    DbUtils.StartTransaction()
                End If


     
                Me.DataBind()
                
                    
    
                ' Load and bind data for each record and table UI control.
                        
        SetWCAR_DocRecordControl()
        
    
                ' Load data for chart.
                
            
                ' initialize aspx controls
                
                

            Catch ex As Exception
                ' An error has occured so display an error message.
                Utils.RegisterJScriptAlert(Me, "Page_Load_Error_Message", ex.Message)
            Finally
                If (Not Me.IsPostBack OrElse Me.Request("__EVENTTARGET") = "ChildWindowPostBack" OrElse ( Me.Request("__EVENTTARGET") = "isd_geo_location"))  Then
                    ' End database transaction
                      DbUtils.EndTransaction()
                End If
            End Try
        End Sub
        
        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)
        
        Public Overridable Function EvaluateFormula_Base(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Dim e As FormulaEvaluator = New FormulaEvaluator()

            ' add variables for formula evaluation
            If variables IsNot Nothing Then
                Dim enumerator As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) = variables.GetEnumerator()
                While enumerator.MoveNext()
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value)
                End While
            End If

            If includeDS
                
            End If

            
            e.CallingControl = Me

            e.DataSource = dataSourceForEvaluate


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
        
        Public Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
          Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, True)
        End Function


        Private Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
          Return EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True)
        End Function

        Public Function EvaluateFormula(ByVal formula As String, ByVal includeDS As Boolean) As String
          Return EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS)
        End Function

        Public Function EvaluateFormula(ByVal formula As String) As String
          Return EvaluateFormula(formula, Nothing, Nothing, Nothing, True)
        End Function
 
        

        ' Write out the Set methods
        
        Public Sub SetWCAR_DocRecordControl_Base()           
        
        
            If WCAR_DocRecordControl.Visible Then
                WCAR_DocRecordControl.LoadData()
                WCAR_DocRecordControl.DataBind()
            End If
        End Sub        
          

        ' Write out the DataSource properties and methods
                

        ' Write out event methods for the page events
            
    
#End Region

  
End Class
  
End Namespace
  